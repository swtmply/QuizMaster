//#region Account API endpoints
const QUIZMASTER_ACCOUNT = `${process.env.QUIZMASTER_GATEWAY}/gateway/api/account`;
const QUIZMASTER_ACCOUNT_GET = `${QUIZMASTER_ACCOUNT}`;
const QUIZMASTER_ACCOUNT_POST = `${QUIZMASTER_ACCOUNT}/create`;
const QUIZMASTER_ACCOUNT_POST_PARTIAL = `${QUIZMASTER_ACCOUNT}/create_partial`;
const QUIZMASTER_ACCOUNT_DELETE = `${QUIZMASTER_ACCOUNT}/delete/`;
const QUIZMASTER_ACCOUNT_PATCH = `${QUIZMASTER_ACCOUNT}/update/`;
const QUIZMASTER_ACCOUNT_POST_SET_ADMIN = `${QUIZMASTER_ACCOUNT}/set_admin/`;
//#endregion

//#region Authentication API endpoints
const QUIZMASTER_AUTH = `${process.env.QUIZMASTER_GATEWAY}/gateway/api/auth`;
const QUIZMASTER_AUTH_POST_LOGIN = `${QUIZMASTER_AUTH}/login`;
const QUIZMASTER_AUTH_POST_PARTIAL_LOGIN = `${QUIZMASTER_AUTH}/partialLogin`;
const QUIZMASTER_AUTH_POST_PARTIAL_LOGOUT = `${QUIZMASTER_AUTH}/logout`;
const QUIZMASTER_AUTH_GET_COOKIE_INFO = `${QUIZMASTER_AUTH}/info`;
const QUIZMASTER_AUTH_POST_SET_ADMIN = `${QUIZMASTER_AUTH}/set_admin/`;
//#endregion

//#region Media API endpoints
const QUIZMASTER_MEDIA = `${process.env.QUIZMASTER_GATEWAY}/gateway/api/media`;
const QUIZMASTER_MEDIA_POST = `${QUIZMASTER_MEDIA}/upload`;
const QUIZMASTER_MEDIA_GET_MEDIAS = `${QUIZMASTER_MEDIA}/get_all_media`;
const QUIZMASTER_MEDIA_GET_MEDIA = `${QUIZMASTER_MEDIA}/get_media/`;
const QUIZMASTER_MEDIA_GET_DOWNLOAD = `${QUIZMASTER_MEDIA}/download_media/`;
const QUIZMASTER_MEDIA_DELETE = `${QUIZMASTER_MEDIA}/delete_media/`;
//#endregion

//#region Question API endpoints
const QUIZMASTER_QUESTION = `${process.env.QUIZMASTER_GATEWAY}/api/gateway/question`;
const QUIZMASTER_QUESTION_GET_QUESTIONS = `${QUIZMASTER_QUESTION}/get_questions`;
const QUIZMASTER_QUESTION_GET_QUESTION = `${QUIZMASTER_QUESTION}/get_question/`;
const QUIZMASTER_QUESTION_POST = `${QUIZMASTER_QUESTION}/add_question`;
const QUIZMASTER_QUESTION_DELETE = `${QUIZMASTER_QUESTION}/delete_question/`;
const QUIZMASTER_QUESTION_PATCH = `${QUIZMASTER_QUESTION}/update_qustion/`;
//#endregion

//#region Difficulty API endpoints
const QUIZMASTER_QDIFFICULTY = `${process.env.QUIZMASTER_GATEWAY}/api/gateway/question/difficulty`;
const QUIZMASTER_QDIFFICULTY_GET_DIFFICULTIES = `${QUIZMASTER_QDIFFICULTY}/get_difficulties`;
const QUIZMASTER_QDIFFICULTY_GET_DIFFICULTY = `${QUIZMASTER_QDIFFICULTY}/get_difficulty/`;
const QUIZMASTER_QDIFFICULTY_POST = `${QUIZMASTER_QDIFFICULTY}/add_difficulty`;
const QUIZMASTER_QDIFFICULTY_DELETE = `${QUIZMASTER_QDIFFICULTY}/delete_difficulty/`;
const QUIZMASTER_QDIFFICULTY_PATCH = `${QUIZMASTER_QDIFFICULTY}/update_difficulty/`;
//#endregion

//#region Question Type API endpoints
const QUIZMASTER_QTYPE = `${process.env.QUIZMASTER_GATEWAY}/api/gateway/question/type`;
const QUIZMASTER_QTYPE_GET_TYPES = `${QUIZMASTER_QTYPE}/get_all_type`;
const QUIZMASTER_QTYPE_GET_TYPE = `${QUIZMASTER_QTYPE}/get_type/`;
//#endregion

//#region Question Category API endpoints
const QUIZMASTER_QCATEGORY = `${process.env.QUIZMASTER_GATEWAY}/gateway/api/question/category`;
const QUIZMASTER_QCATEGORY_GET_CATEGORIES = `${QUIZMASTER_QCATEGORY}/get_all_category`;
const QUIZMASTER_QCATEGORY_GET_CATEGORY = `${QUIZMASTER_QCATEGORY}/get_category/`;
const QUIZMASTER_QCATEGORY_POST = `${QUIZMASTER_QCATEGORY}/create_category`;
const QUIZMASTER_QCATEGORY_DELETE = `${QUIZMASTER_QCATEGORY}/delete/`;
const QUIZMASTER_QCATEGORY_PATCH = `${QUIZMASTER_QCATEGORY}/update_category/`;
//#endregion

//#region Question Detail API endpoints
const QUIZMASTER_QUESTIONDETAIL = "question_detail";
const QUIZMASTER_QUESTIONDETAIL_GET_QUESTIONDETAILS = `${QUIZMASTER_QUESTIONDETAIL}/get_question_details`;
const QUIZMASTER_QUESTIONDETAIL_GET_QUESTIONDETAIL = `${QUIZMASTER_QUESTIONDETAIL}/get_question_detail/`;
const QUIZMASTER_QUESTIONDETAIL_POST = `${QUIZMASTER_QUESTIONDETAIL}/add_question_detail`;
const QUIZMASTER_QUESTIONDETAIL_DELETE = `${QUIZMASTER_QUESTIONDETAIL}/delete_question_detail/`;
const QUIZMASTER_QUESTIONDETAIL_PATCH = `${QUIZMASTER_QUESTIONDETAIL}/update_qustion_detail/`;
//#endregion

//#region Set API endpoints
const QUIZMASTER_SET = `${process.env.QUIZMASTER_GATEWAY}/gateway/api/set`;
const QUIZMASTER_SET_POST = `${QUIZMASTER_SET}/create`;
const QUIZMASTER_SET_POST_SUBMIT_ANSWER = `${QUIZMASTER_SET}/submitAnswer`;
const QUIZMASTER_SET_GET_SETS = `${QUIZMASTER_SET}/all_set`;
const QUIZMASTER_SET_GET_SET = `${QUIZMASTER_SET}/`;
const QUIZMASTER_SET_GET_SETQUESTIONS = `${QUIZMASTER_SET}/all_question_set`;
const QUIZMASTER_SET_GET_SETQUESTION = `${QUIZMASTER_SET}/get_question_set/`;
const QUIZMASTER_SET_PUT = `${QUIZMASTER_SET}/update_set/`;
const QUIZMASTER_SET_DELETE = `${QUIZMASTER_SET}/delete_set/`;
//#endregion

//Monitoring

const QUIZMASTER_MONITORING_AUDIT_GET = `https://localhost:7065`;

const QUIZMASTER_MONITORING_USER_GET = `${QUIZMASTER_MONITORING_AUDIT_GET}/api/audit/user/all`;
const QUIZMASTER_MONITORING_MEDIA_GET = `${QUIZMASTER_MONITORING_AUDIT_GET}/api/mediaaudit/all`;
const QUIZMASTER_MONITORING_QUIZ_DIFFICULTY_GET = `${QUIZMASTER_MONITORING_AUDIT_GET}/api/mediaaudit/all`;
const QUIZMASTER_MONITORING_QUIZ_AUDIT_GET = `${QUIZMASTER_MONITORING_AUDIT_GET}/api/questionaudit/all`;
const QUIZMASTER_MONITORING_QUIZ_TYPE_GET = `${QUIZMASTER_MONITORING_AUDIT_GET}/api/questiontypeaudit/all`;
const QUIZMASTER_MONITORING_QUIZ_CATEGORY_GET = `${QUIZMASTER_MONITORING_AUDIT_GET}/api/quizcategoryaudit/all`;
const QUIZMASTER_MONITORING_QUIZ_SET_GET = `${QUIZMASTER_MONITORING_AUDIT_GET}/api/questionsetaudit/all`;
const QUIZMASTER_MONITORING_ROOM_GET = `${QUIZMASTER_MONITORING_AUDIT_GET}/api/roomaudit/all`;
const QUIZMASTER_MONITORING_QUESTION_GET = `${QUIZMASTER_MONITORING_AUDIT_GET}/api/questionaudit/all`;
export {
    QUIZMASTER_ACCOUNT_GET,
    QUIZMASTER_ACCOUNT_POST,
    QUIZMASTER_ACCOUNT_POST_PARTIAL,
    QUIZMASTER_ACCOUNT_DELETE,
    QUIZMASTER_ACCOUNT_PATCH,
    QUIZMASTER_ACCOUNT_POST_SET_ADMIN,
    QUIZMASTER_AUTH_POST_LOGIN,
    QUIZMASTER_AUTH_POST_PARTIAL_LOGIN,
    QUIZMASTER_AUTH_POST_PARTIAL_LOGOUT,
    QUIZMASTER_AUTH_GET_COOKIE_INFO,
    QUIZMASTER_AUTH_POST_SET_ADMIN,
    QUIZMASTER_MEDIA_POST,
    QUIZMASTER_MEDIA_GET_MEDIAS,
    QUIZMASTER_MEDIA_GET_MEDIA,
    QUIZMASTER_MEDIA_GET_DOWNLOAD,
    QUIZMASTER_MEDIA_DELETE,
    QUIZMASTER_QUESTION,
    QUIZMASTER_QUESTION_GET_QUESTIONS,
    QUIZMASTER_QUESTION_GET_QUESTION,
    QUIZMASTER_QUESTION_POST,
    QUIZMASTER_QUESTION_DELETE,
    QUIZMASTER_QUESTION_PATCH,
    QUIZMASTER_QCATEGORY_GET_CATEGORIES,
    QUIZMASTER_QCATEGORY_GET_CATEGORY,
    QUIZMASTER_QCATEGORY_POST,
    QUIZMASTER_QCATEGORY_DELETE,
    QUIZMASTER_QCATEGORY_PATCH,
    QUIZMASTER_QDIFFICULTY_GET_DIFFICULTIES,
    QUIZMASTER_QDIFFICULTY_GET_DIFFICULTY,
    QUIZMASTER_QDIFFICULTY_POST,
    QUIZMASTER_QDIFFICULTY_DELETE,
    QUIZMASTER_QDIFFICULTY_PATCH,
    QUIZMASTER_QTYPE_GET_TYPES,
    QUIZMASTER_QTYPE_GET_TYPE,
    QUIZMASTER_QUESTIONDETAIL_GET_QUESTIONDETAILS,
    QUIZMASTER_QUESTIONDETAIL_GET_QUESTIONDETAIL,
    QUIZMASTER_QUESTIONDETAIL_POST,
    QUIZMASTER_QUESTIONDETAIL_DELETE,
    QUIZMASTER_QUESTIONDETAIL_PATCH,
    QUIZMASTER_SET_GET_SETS,
    QUIZMASTER_SET_GET_SET,
    QUIZMASTER_SET_GET_SETQUESTIONS,
    QUIZMASTER_SET_GET_SETQUESTION,
    QUIZMASTER_SET_POST,
    QUIZMASTER_SET_POST_SUBMIT_ANSWER,
    QUIZMASTER_SET_PUT,
    QUIZMASTER_SET_DELETE,
    QUIZMASTER_MONITORING_AUDIT_GET,
    QUIZMASTER_MONITORING_USER_GET,
    QUIZMASTER_MONITORING_MEDIA_GET,
    QUIZMASTER_MONITORING_QUIZ_DIFFICULTY_GET,
    QUIZMASTER_MONITORING_QUIZ_AUDIT_GET,
    QUIZMASTER_MONITORING_QUIZ_TYPE_GET,
    QUIZMASTER_MONITORING_QUIZ_CATEGORY_GET,
    QUIZMASTER_MONITORING_QUIZ_SET_GET,
    QUIZMASTER_MONITORING_ROOM_GET,
    QUIZMASTER_MONITORING_QUESTION_GET,
};
