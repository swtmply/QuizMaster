﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QuizMaster.API.Quiz.DbContexts;

#nullable disable

namespace QuizMaster.API.Quiz.Migrations
{
    [DbContext(typeof(QuestionDbContext))]
    partial class QuestionDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("QuizMaster.Library.Common.Entities.Questionnaire.DetailType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("ActiveData")
                        .HasColumnType("bit");

                    b.Property<int>("CreatedByUserId")
                        .HasColumnType("int");

                    b.Property<string>("DTypeDesc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<int?>("QuestionDetailId")
                        .HasColumnType("int");

                    b.Property<int?>("UpdatedByUserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("QuestionDetailId");

                    b.ToTable("DetailTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ActiveData = false,
                            CreatedByUserId = 0,
                            DTypeDesc = "Answer",
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            ActiveData = false,
                            CreatedByUserId = 0,
                            DTypeDesc = "Option",
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            ActiveData = false,
                            CreatedByUserId = 0,
                            DTypeDesc = "Minimum",
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            ActiveData = false,
                            CreatedByUserId = 0,
                            DTypeDesc = "Maximum",
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 5,
                            ActiveData = false,
                            CreatedByUserId = 0,
                            DTypeDesc = "Interval",
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 6,
                            ActiveData = false,
                            CreatedByUserId = 0,
                            DTypeDesc = "Margin",
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 7,
                            ActiveData = false,
                            CreatedByUserId = 0,
                            DTypeDesc = "TextToAudio",
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 8,
                            ActiveData = false,
                            CreatedByUserId = 0,
                            DTypeDesc = "Language",
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("QuizMaster.Library.Common.Entities.Questionnaire.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("ActiveData")
                        .HasColumnType("bit");

                    b.Property<int>("CreatedByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("QAudio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("QCategoryId")
                        .HasColumnType("int");

                    b.Property<int>("QDifficultyId")
                        .HasColumnType("int");

                    b.Property<string>("QImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QStatement")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("QTime")
                        .HasColumnType("int");

                    b.Property<int>("QTypeId")
                        .HasColumnType("int");

                    b.Property<int?>("UpdatedByUserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("QCategoryId");

                    b.HasIndex("QDifficultyId");

                    b.HasIndex("QTypeId");

                    b.ToTable("Questions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ActiveData = true,
                            CreatedByUserId = 0,
                            DateCreated = new DateTime(2023, 12, 12, 15, 51, 26, 830, DateTimeKind.Local).AddTicks(5744),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            QAudio = "",
                            QCategoryId = 1,
                            QDifficultyId = 1,
                            QImage = "",
                            QStatement = "What is the primary gas in Earth's atmosphere?",
                            QTime = 30,
                            QTypeId = 1
                        },
                        new
                        {
                            Id = 2,
                            ActiveData = true,
                            CreatedByUserId = 0,
                            DateCreated = new DateTime(2023, 12, 12, 15, 51, 26, 831, DateTimeKind.Local).AddTicks(739),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            QAudio = "",
                            QCategoryId = 1,
                            QDifficultyId = 2,
                            QImage = "",
                            QStatement = "True or False: Earth's moon is larger than Pluto.",
                            QTime = 20,
                            QTypeId = 3
                        },
                        new
                        {
                            Id = 3,
                            ActiveData = true,
                            CreatedByUserId = 0,
                            DateCreated = new DateTime(2023, 12, 12, 15, 51, 26, 831, DateTimeKind.Local).AddTicks(1181),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            QAudio = "",
                            QCategoryId = 1,
                            QDifficultyId = 2,
                            QImage = "",
                            QStatement = "What is the number divisible by 3 and 7, anb between 10 and 50?",
                            QTime = 25,
                            QTypeId = 5
                        });
                });

            modelBuilder.Entity("QuizMaster.Library.Common.Entities.Questionnaire.QuestionCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("ActiveData")
                        .HasColumnType("bit");

                    b.Property<int>("CreatedByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("QCategoryDesc")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("UpdatedByUserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ActiveData = true,
                            CreatedByUserId = 1,
                            DateCreated = new DateTime(2023, 12, 12, 15, 51, 26, 829, DateTimeKind.Local).AddTicks(4429),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            QCategoryDesc = "Science"
                        },
                        new
                        {
                            Id = 2,
                            ActiveData = true,
                            CreatedByUserId = 1,
                            DateCreated = new DateTime(2023, 12, 12, 15, 51, 26, 829, DateTimeKind.Local).AddTicks(5465),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            QCategoryDesc = "Movies"
                        },
                        new
                        {
                            Id = 3,
                            ActiveData = true,
                            CreatedByUserId = 1,
                            DateCreated = new DateTime(2023, 12, 12, 15, 51, 26, 829, DateTimeKind.Local).AddTicks(5470),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            QCategoryDesc = "Animals"
                        },
                        new
                        {
                            Id = 4,
                            ActiveData = true,
                            CreatedByUserId = 1,
                            DateCreated = new DateTime(2023, 12, 12, 15, 51, 26, 829, DateTimeKind.Local).AddTicks(5471),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            QCategoryDesc = "Places"
                        },
                        new
                        {
                            Id = 5,
                            ActiveData = true,
                            CreatedByUserId = 1,
                            DateCreated = new DateTime(2023, 12, 12, 15, 51, 26, 829, DateTimeKind.Local).AddTicks(5472),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            QCategoryDesc = "People"
                        },
                        new
                        {
                            Id = 6,
                            ActiveData = true,
                            CreatedByUserId = 1,
                            DateCreated = new DateTime(2023, 12, 12, 15, 51, 26, 829, DateTimeKind.Local).AddTicks(5478),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            QCategoryDesc = "System Operations and Maintenance"
                        },
                        new
                        {
                            Id = 7,
                            ActiveData = true,
                            CreatedByUserId = 1,
                            DateCreated = new DateTime(2023, 12, 12, 15, 51, 26, 829, DateTimeKind.Local).AddTicks(5479),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            QCategoryDesc = "Data Structures"
                        },
                        new
                        {
                            Id = 8,
                            ActiveData = true,
                            CreatedByUserId = 1,
                            DateCreated = new DateTime(2023, 12, 12, 15, 51, 26, 829, DateTimeKind.Local).AddTicks(5480),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            QCategoryDesc = "Algorithms"
                        });
                });

            modelBuilder.Entity("QuizMaster.Library.Common.Entities.Questionnaire.QuestionDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("ActiveData")
                        .HasColumnType("bit");

                    b.Property<int>("CreatedByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("QDetailDesc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("QuestionId")
                        .HasColumnType("int");

                    b.Property<int?>("UpdatedByUserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("QuestionId");

                    b.ToTable("QuestionDetails");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ActiveData = true,
                            CreatedByUserId = 1,
                            DateCreated = new DateTime(2023, 12, 12, 15, 51, 26, 831, DateTimeKind.Local).AddTicks(5400),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            QDetailDesc = "Oxygen",
                            QuestionId = 1
                        },
                        new
                        {
                            Id = 2,
                            ActiveData = true,
                            CreatedByUserId = 1,
                            DateCreated = new DateTime(2023, 12, 12, 15, 51, 26, 831, DateTimeKind.Local).AddTicks(6239),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            QDetailDesc = "Nitrogen",
                            QuestionId = 1
                        },
                        new
                        {
                            Id = 3,
                            ActiveData = true,
                            CreatedByUserId = 1,
                            DateCreated = new DateTime(2023, 12, 12, 15, 51, 26, 831, DateTimeKind.Local).AddTicks(6244),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            QDetailDesc = "Carbon Dioxide",
                            QuestionId = 1
                        },
                        new
                        {
                            Id = 4,
                            ActiveData = true,
                            CreatedByUserId = 1,
                            DateCreated = new DateTime(2023, 12, 12, 15, 51, 26, 831, DateTimeKind.Local).AddTicks(6245),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            QDetailDesc = "Hydrogen",
                            QuestionId = 1
                        },
                        new
                        {
                            Id = 5,
                            ActiveData = true,
                            CreatedByUserId = 1,
                            DateCreated = new DateTime(2023, 12, 12, 15, 51, 26, 831, DateTimeKind.Local).AddTicks(6246),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            QDetailDesc = "True",
                            QuestionId = 2
                        },
                        new
                        {
                            Id = 6,
                            ActiveData = true,
                            CreatedByUserId = 1,
                            DateCreated = new DateTime(2023, 12, 12, 15, 51, 26, 831, DateTimeKind.Local).AddTicks(6250),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            QDetailDesc = "42",
                            QuestionId = 3
                        },
                        new
                        {
                            Id = 7,
                            ActiveData = true,
                            CreatedByUserId = 1,
                            DateCreated = new DateTime(2023, 12, 12, 15, 51, 26, 831, DateTimeKind.Local).AddTicks(6251),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            QDetailDesc = "10",
                            QuestionId = 3
                        },
                        new
                        {
                            Id = 8,
                            ActiveData = true,
                            CreatedByUserId = 1,
                            DateCreated = new DateTime(2023, 12, 12, 15, 51, 26, 831, DateTimeKind.Local).AddTicks(6252),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            QDetailDesc = "50",
                            QuestionId = 3
                        },
                        new
                        {
                            Id = 9,
                            ActiveData = true,
                            CreatedByUserId = 1,
                            DateCreated = new DateTime(2023, 12, 12, 15, 51, 26, 831, DateTimeKind.Local).AddTicks(6253),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            QDetailDesc = "1",
                            QuestionId = 3
                        });
                });

            modelBuilder.Entity("QuizMaster.Library.Common.Entities.Questionnaire.QuestionDetailType", b =>
                {
                    b.Property<int>("QuestionDetailId")
                        .HasColumnType("int");

                    b.Property<int>("DetailTypeId")
                        .HasColumnType("int");

                    b.Property<bool>("ActiveData")
                        .HasColumnType("bit");

                    b.Property<int>("CreatedByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UpdatedByUserId")
                        .HasColumnType("int");

                    b.HasKey("QuestionDetailId", "DetailTypeId");

                    b.HasIndex("DetailTypeId");

                    b.ToTable("QuestionDetailTypes");

                    b.HasData(
                        new
                        {
                            QuestionDetailId = 1,
                            DetailTypeId = 2,
                            ActiveData = true,
                            CreatedByUserId = 1,
                            DateCreated = new DateTime(2023, 12, 12, 15, 51, 26, 831, DateTimeKind.Local).AddTicks(9818),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            QuestionDetailId = 2,
                            DetailTypeId = 1,
                            ActiveData = true,
                            CreatedByUserId = 1,
                            DateCreated = new DateTime(2023, 12, 12, 15, 51, 26, 832, DateTimeKind.Local).AddTicks(403),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            QuestionDetailId = 2,
                            DetailTypeId = 2,
                            ActiveData = true,
                            CreatedByUserId = 1,
                            DateCreated = new DateTime(2023, 12, 12, 15, 51, 26, 832, DateTimeKind.Local).AddTicks(423),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            QuestionDetailId = 3,
                            DetailTypeId = 2,
                            ActiveData = true,
                            CreatedByUserId = 1,
                            DateCreated = new DateTime(2023, 12, 12, 15, 51, 26, 832, DateTimeKind.Local).AddTicks(424),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            QuestionDetailId = 4,
                            DetailTypeId = 2,
                            ActiveData = true,
                            CreatedByUserId = 1,
                            DateCreated = new DateTime(2023, 12, 12, 15, 51, 26, 832, DateTimeKind.Local).AddTicks(425),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            QuestionDetailId = 5,
                            DetailTypeId = 1,
                            ActiveData = true,
                            CreatedByUserId = 1,
                            DateCreated = new DateTime(2023, 12, 12, 15, 51, 26, 832, DateTimeKind.Local).AddTicks(429),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            QuestionDetailId = 6,
                            DetailTypeId = 1,
                            ActiveData = true,
                            CreatedByUserId = 1,
                            DateCreated = new DateTime(2023, 12, 12, 15, 51, 26, 832, DateTimeKind.Local).AddTicks(429),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            QuestionDetailId = 7,
                            DetailTypeId = 3,
                            ActiveData = true,
                            CreatedByUserId = 1,
                            DateCreated = new DateTime(2023, 12, 12, 15, 51, 26, 832, DateTimeKind.Local).AddTicks(430),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            QuestionDetailId = 8,
                            DetailTypeId = 4,
                            ActiveData = true,
                            CreatedByUserId = 1,
                            DateCreated = new DateTime(2023, 12, 12, 15, 51, 26, 832, DateTimeKind.Local).AddTicks(700),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            QuestionDetailId = 9,
                            DetailTypeId = 5,
                            ActiveData = true,
                            CreatedByUserId = 1,
                            DateCreated = new DateTime(2023, 12, 12, 15, 51, 26, 832, DateTimeKind.Local).AddTicks(706),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("QuizMaster.Library.Common.Entities.Questionnaire.QuestionDifficulty", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("ActiveData")
                        .HasColumnType("bit");

                    b.Property<int>("CreatedByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("QDifficultyDesc")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<int?>("UpdatedByUserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Difficulties");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ActiveData = true,
                            CreatedByUserId = 1,
                            DateCreated = new DateTime(2023, 12, 12, 15, 51, 26, 828, DateTimeKind.Local).AddTicks(8961),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            QDifficultyDesc = "Easy"
                        },
                        new
                        {
                            Id = 2,
                            ActiveData = true,
                            CreatedByUserId = 1,
                            DateCreated = new DateTime(2023, 12, 12, 15, 51, 26, 829, DateTimeKind.Local).AddTicks(205),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            QDifficultyDesc = "Average"
                        },
                        new
                        {
                            Id = 3,
                            ActiveData = true,
                            CreatedByUserId = 1,
                            DateCreated = new DateTime(2023, 12, 12, 15, 51, 26, 829, DateTimeKind.Local).AddTicks(272),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            QDifficultyDesc = "Difficult"
                        });
                });

            modelBuilder.Entity("QuizMaster.Library.Common.Entities.Questionnaire.QuestionType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("ActiveData")
                        .HasColumnType("bit");

                    b.Property<int>("CreatedByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<bool>("QDetailRequired")
                        .HasColumnType("bit");

                    b.Property<string>("QTypeDesc")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("UpdatedByUserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Types");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ActiveData = true,
                            CreatedByUserId = 1,
                            DateCreated = new DateTime(2023, 12, 12, 15, 51, 26, 688, DateTimeKind.Local).AddTicks(3),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            QDetailRequired = true,
                            QTypeDesc = "Multiple Choice"
                        },
                        new
                        {
                            Id = 2,
                            ActiveData = true,
                            CreatedByUserId = 1,
                            DateCreated = new DateTime(2023, 12, 12, 15, 51, 26, 827, DateTimeKind.Local).AddTicks(2880),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            QDetailRequired = true,
                            QTypeDesc = "Multiple Choice + Audio"
                        },
                        new
                        {
                            Id = 3,
                            ActiveData = true,
                            CreatedByUserId = 1,
                            DateCreated = new DateTime(2023, 12, 12, 15, 51, 26, 827, DateTimeKind.Local).AddTicks(2893),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            QDetailRequired = false,
                            QTypeDesc = "True or False"
                        },
                        new
                        {
                            Id = 4,
                            ActiveData = true,
                            CreatedByUserId = 1,
                            DateCreated = new DateTime(2023, 12, 12, 15, 51, 26, 827, DateTimeKind.Local).AddTicks(2895),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            QDetailRequired = true,
                            QTypeDesc = "Type Answer"
                        },
                        new
                        {
                            Id = 5,
                            ActiveData = true,
                            CreatedByUserId = 1,
                            DateCreated = new DateTime(2023, 12, 12, 15, 51, 26, 827, DateTimeKind.Local).AddTicks(2896),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            QDetailRequired = true,
                            QTypeDesc = "Slider"
                        },
                        new
                        {
                            Id = 6,
                            ActiveData = true,
                            CreatedByUserId = 1,
                            DateCreated = new DateTime(2023, 12, 12, 15, 51, 26, 827, DateTimeKind.Local).AddTicks(2897),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            QDetailRequired = true,
                            QTypeDesc = "Puzzle"
                        });
                });

            modelBuilder.Entity("QuizMaster.Library.Common.Entities.Questionnaire.DetailType", b =>
                {
                    b.HasOne("QuizMaster.Library.Common.Entities.Questionnaire.QuestionDetail", null)
                        .WithMany("DetailTypes")
                        .HasForeignKey("QuestionDetailId");
                });

            modelBuilder.Entity("QuizMaster.Library.Common.Entities.Questionnaire.Question", b =>
                {
                    b.HasOne("QuizMaster.Library.Common.Entities.Questionnaire.QuestionCategory", "QCategory")
                        .WithMany()
                        .HasForeignKey("QCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("QuizMaster.Library.Common.Entities.Questionnaire.QuestionDifficulty", "QDifficulty")
                        .WithMany()
                        .HasForeignKey("QDifficultyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("QuizMaster.Library.Common.Entities.Questionnaire.QuestionType", "QType")
                        .WithMany()
                        .HasForeignKey("QTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("QCategory");

                    b.Navigation("QDifficulty");

                    b.Navigation("QType");
                });

            modelBuilder.Entity("QuizMaster.Library.Common.Entities.Questionnaire.QuestionDetail", b =>
                {
                    b.HasOne("QuizMaster.Library.Common.Entities.Questionnaire.Question", "Question")
                        .WithMany("Details")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Question");
                });

            modelBuilder.Entity("QuizMaster.Library.Common.Entities.Questionnaire.QuestionDetailType", b =>
                {
                    b.HasOne("QuizMaster.Library.Common.Entities.Questionnaire.DetailType", "DetailType")
                        .WithMany()
                        .HasForeignKey("DetailTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("QuizMaster.Library.Common.Entities.Questionnaire.QuestionDetail", "QuestionDetail")
                        .WithMany()
                        .HasForeignKey("QuestionDetailId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DetailType");

                    b.Navigation("QuestionDetail");
                });

            modelBuilder.Entity("QuizMaster.Library.Common.Entities.Questionnaire.Question", b =>
                {
                    b.Navigation("Details");
                });

            modelBuilder.Entity("QuizMaster.Library.Common.Entities.Questionnaire.QuestionDetail", b =>
                {
                    b.Navigation("DetailTypes");
                });
#pragma warning restore 612, 618
        }
    }
}
