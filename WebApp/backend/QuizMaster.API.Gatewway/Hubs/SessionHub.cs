﻿using Grpc.Net.Client;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using QuizMaster.API.Account.Proto;
using QuizMaster.API.Authentication.Proto;
using QuizMaster.API.Gateway.Configuration;
using QuizMaster.API.Gateway.Helper;
using QuizMaster.API.Gateway.Services;
using QuizMaster.API.QuizSession.Models;
using QuizMaster.API.QuizSession.Protos;
using QuizMaster.Library.Common.Entities.Questionnaire;
using QuizMaster.Library.Common.Entities.Rooms;
using QuizMaster.Library.Common.Models.QuizSession;
using System.Linq;
using System.Threading.Channels;

namespace QuizMaster.API.Gateway.Hubs
{

    public class SessionHub : Hub
    {
        private GrpcChannel _channel;
        private  QuizRoomService.QuizRoomServiceClient _channelClient;
        private readonly AuthService.AuthServiceClient _authChannelClient;
        private SessionHandler SessionHandler;
        /*
         * TODO
         * - Create A QB Context for QuizParticipants
         * - Link Participants to ConnectionId
         * - Allow Submission of Answers based on running question [current displayed]
         * - Implement the Authorization to link QuizParticipants and Account.API
         */

        public SessionHub(IOptions<GrpcServerConfiguration> options, SessionHandler sessionHandler)
        {
            _channel = GrpcChannel.ForAddress(options.Value.Session_Service);
            _channelClient = new QuizRoomService.QuizRoomServiceClient(_channel);
            _channel = GrpcChannel.ForAddress(options.Value.Authentication_Service);
            _authChannelClient = new AuthService.AuthServiceClient(_channel);
            SessionHandler = sessionHandler;
        }

        /*
         * Login the User
         */
        public async Task Login(string token)
        {
            var connectionId = Context.ConnectionId;
            await SessionHandler.AuthenticateConnectionId(this, _authChannelClient, connectionId, token);
        }

        public async Task CreateRoom(CreateRoomDTO roomDTO)
        {
            string connectionId = Context.ConnectionId;
            if (!SessionHandler.IsAdmin(connectionId))
            {
                await Clients.Caller.SendAsync("notif", "Please contact administrator");
                return;
            }

            var request = new CreateRoomRequest { Room = JsonConvert.SerializeObject(roomDTO) };
            var reply = await _channelClient.CreateRoomAsync(request);

            if (reply.Code == 200)
            {
               

                var quizRoom = JsonConvert.DeserializeObject<QuizRoom>(reply.Data);
                await Groups.AddToGroupAsync(Context.ConnectionId, quizRoom.QRoomPin+"");

                await Clients.All.SendAsync("NewQuizRooms", new[] { quizRoom });
            }


            // TODO: Reply 500 status
        }


        public async Task DeleteRoom(int roomId)
        {
            string connectionId = Context.ConnectionId;
            if (!SessionHandler.IsAdmin(connectionId))
            {
                await Clients.Caller.SendAsync("notif", "Please contact administrator");
                return;
            }

            var request = new ModifyRoomRequest { Room = roomId };

            var reply = await _channelClient.DeleteRoomAsync(request);

            if (reply.Code == 204)
            {
                await Clients.Caller.SendAsync("chat", "Room was deleted");
                await Clients.Group(reply.Data).SendAsync("chat", "[System] You have been removed from the room");
                await SessionHandler.RemoveGroup(this, reply.Data);
            }
            else
            {
                await Clients.Caller.SendAsync("notif", reply.Message);
            }
        }

        public async Task UpdateRoom(UpdateRoomDTO updateRoomDTO)
        {
            string connectionId = Context.ConnectionId;
            if (!SessionHandler.IsAdmin(connectionId))
            {
                await Clients.Caller.SendAsync("notif", "Please contact administrator");
                return;
            }
            var request = new CreateRoomRequest { Room = JsonConvert.SerializeObject(updateRoomDTO) };
            var reply = await _channelClient.UpdateRoomAsync(request);

            // TODO:
            if (reply.Code == 200)
            {
                var quizRoom = JsonConvert.DeserializeObject<QuizRoom>(reply.Data);
                await Clients.Caller.SendAsync("NewQuizRooms", new[] { quizRoom });
                await Clients.Caller.SendAsync("chat", "Room was updated");
            }
            else
            {
                await Clients.Caller.SendAsync("chat", reply.Message);
            }
        }


        public async Task Chat(string chat, string roomId)
        {
            string connectionId = Context.ConnectionId;

            if (!SessionHandler.IsAuthenticated(connectionId))
            {
                await Clients.Caller.SendAsync("chat", "You need to login to join chat");
                return;
            }
            var participantData = SessionHandler.GetLinkedParticipantInConnectionId(connectionId);
            if(participantData == null) { return; }
            // send chat only to group
            if (SessionHandler.IsAdmin(connectionId))
                await Clients.Group(roomId).SendAsync("chat", $"[{participantData.QParticipantDesc}(host)]: {chat}");
            else await Clients.Group(roomId).SendAsync("chat", $"[{participantData.QParticipantDesc}]: {chat}");
        }

        public async Task JoinRoom(int RoomPin)
        {
            string connectionId = Context.ConnectionId;
            if (!SessionHandler.IsAuthenticated(connectionId))
            {
                await Clients.Caller.SendAsync("notif", "Failed to join room, you are not authorized");
                return;
            }
            // Grab the UserInformation
            var userData = await SessionHandler.GetUserInformation(_authChannelClient, SessionHandler.GetConnectionToken(connectionId));
            if(userData == null)
            {
                await Clients.Caller.SendAsync("notif", $"There was an issue authenticating your account");
                return;
            }

            try
            {
                var reply = _channelClient.GetAllRoom(new RoomsEmptyRequest());

                if (reply.Code == 200)
                {
                    var quizRooms = JsonConvert.DeserializeObject<QuizRoom[]>(reply.Data);

                    bool containsId = false;
                    var room = new QuizRoom();
                    foreach(QuizRoom rooms in quizRooms)
                    {
                        if(rooms.QRoomPin == RoomPin)
                        {
                            room = rooms;
                            containsId = true;
                            break;
                        }
                    }

                    if (containsId)
                    {
                        //string Name = NAMES[new Random().Next(0, NAMES.Count - 1)];
                        string Name = userData.UserData.UserName;
                        SessionHandler.LinkParticipantConnectionId(connectionId, new QuizParticipant { QParticipantDesc = Name, UserId = userData.UserData.Id });
                        await SessionHandler.AddToGroup(this, $"{RoomPin}", connectionId);
                        await Clients.Group($"{RoomPin}").SendAsync("notif", $"{Name} has joined Room {room.QRoomDesc}", room);
                    }
                    //await Clients.All.SendAsync("QuizRooms", quizRooms);
                }
        }
            catch (Exception ex)
            {
                await Clients.Caller.SendAsync("notif", $"An error has occurred while trying to connect");
                Console.Write(ex.ToString());
            }
        }

        public async Task GetAllRooms() 
        {
            try
            {
                var reply = _channelClient.GetAllRoom(new RoomsEmptyRequest());

                if (reply.Code == 200)
                {
                    var quizRooms = JsonConvert.DeserializeObject<QuizRoom[]>(reply.Data);

                    await Clients.All.SendAsync("QuizRooms", quizRooms);
                }
            }
            catch (Exception ex) 
            {
                Console.Write(ex.ToString());
            }
            
        }
        public override async Task OnDisconnectedAsync(Exception? exception)
        {
            await LeaveRoom();
        }

        public async Task LeaveRoom()
        {
            var participantData = SessionHandler.GetLinkedParticipantInConnectionId(Context.ConnectionId);
            if (participantData == null) { return; }
            await SessionHandler.RemoveClientFromGroups(this, Context.ConnectionId, $"{participantData.QParticipantDesc} has left the room");
            SessionHandler.UnbindConnectionId(Context.ConnectionId);
        }

        public async Task StartRoom(string roomPin)
        {
            string connectionId = Context.ConnectionId;
            if (!SessionHandler.IsAdmin(connectionId))
            {
                await Clients.Caller.SendAsync("notif", "Please contact administrator");
                return;
            }
            try
            {
                var reply = _channelClient.GetAllRoom(new RoomsEmptyRequest());
                int roomId = -1;

                if (reply.Code == 200)
                {
                    var quizRooms = JsonConvert.DeserializeObject<QuizRoom[]>(reply.Data);

                    bool containsId = false;
                    var room = new QuizRoom();
                    foreach (QuizRoom rooms in quizRooms)
                    {
                        if (rooms.QRoomPin == Convert.ToInt32(roomPin))
                        {
                            room = rooms;
                            containsId = true;
                            break;
                        }
                    }

                    if(containsId)
                    {
                        roomId = room.Id;
                    }
                }
                await Clients.Group(roomPin).SendAsync("start", true);
                // we will not use await, we will let the request pass
                await SessionHandler.StartQuiz(this, _channelClient, roomId.ToString());
            }
            catch (Exception ex)
            {
                Console.Write(ex?.ToString());
            }
        }

        public async Task GetRoomParticipants(string roomPin)
        {
            var participants = SessionHandler.ParticipantLinkedConnectionsInAGroup(roomPin);
            await Clients.Group(roomPin).SendAsync("participants", participants);
        }



    }
}
