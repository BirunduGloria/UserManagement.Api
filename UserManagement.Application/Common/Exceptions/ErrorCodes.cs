using System.Net;

namespace Core.Application.Common.Exceptions
{
    public static class ErrorCodes
    {
        //Generic Error Codes In All Microservices
        public const string SUCCESS = "200";

        public const string INVALID_SERVICE_CODE = "301";

        public const string MALFORMED_REQUEST = "302";

        public const string UNKNOWN_ERROR = "303";

        public const string NO_RECORDS = "304";

        public const string SERVICE_ERROR = "305";

        public const string INVALID_TOKEN = "306";

        public const string EXPIRED_TOKEN = "307";

        public const string INVALID_SERVICE_ENDPOINT = "308";

        public const string INVALID_SERVICE_CONFIGURATION = "309";

        public const string PROCESS_QUEUE_FAILURE = "310";

        public const string REQUEST_TIMEOUT = "311";

        public const string INVALID_REQUEST = "312";

        public const string VALIDATION_ERROR = "313";


        // Specific Error Codes
        public const string INVALID_CREDENTIALS = "003";

        public const string DUPLICATE_RECORD = "1016";

        public const string PASSWORDS_DONT_MATCH = "1018";

        public const string DEVICE_BLOCKED = "1022";

        public const string USER_ALREADY_EXISTS = "1024";

        public const string UNAUTHORIZED_DEVICE = "1028";

        public const string INVALID_USER_STATUS = "1032";

        public const string INVALID_OTP = "1033";

        public const string INVALID_USER_DETAILS = "1035";

        public const string INVALID_DEVICE_STATUS = "1036";

        public const string CHANGE_PASSWORD = "1038";

        public const string UNAUTHORIZED_USER = "1047";

        public const string DEVICE_NOT_ACTIVATED = "1049";

        public const string ENTITY_MISMATCH = "1051";

        public const string CHANNEL_ASSIGNED = "1052";

        public const string INVALID_OTP_REF = "1053";

        public const string INVALID_ENTITY_TYPE = "1054";

        public const string INACTIVE_ENTITY = "1055";

        public const string INVALID_ENTITY_MAPPING_STATUS = "1056";

        public const string USER_BLOCKED = "1057";

        public const string USER_NOT_MAPPED = "1058";

        public const string USER_IN_SIMILAR_ENTITYTYPE = "1059";

        public const string PASSWORDS_RESET_NOT_ALLOWED = "1060";

        public const string PASSWORD_RESET_FAILED = "1061";

        public const string OWNER_DISABLE_NOT_ALLOWED = "1062";

        public const string INVALID_CHANNEL_STATUS = "1063";

        public const string UNAUTHORIZED_CHANNEL = "1064";

        public const string OLD_NEW_PASSWORD_SIMILAR = "1065";

        public const string UNKNOWN_USER = "1066";
        public const string UNAUTHENTICATED_USER = "1067";
        public const string UNAUTHORIZED_ACCESS = "1068";

        public const string OTP_ATTEMPTS_EXCEEDED = "1069";
        public const string INVALID_REFRESH_TOKEN = "1070";
        public const string USER_LOCKED = "1071";
        public const string BILLER_REQUEST_FAILED = "1072";
        public const string PAYBILL_REQUEST_FAILED = "1073";
        public const string AGENT_REQUEST_FAILED = "1074";
        public const string OUTLET_REQUEST_FAILED = "1075";
        public const string UNAUTHORIZED_BROWSER = "1076";

        public const string INVALID_SIGNATURE = "1077";
        public const string INACTIVE_SUBENTITY = "1078";
        public const string TRANSACTION_NOT_FOUND = "1079";


        public static HttpStatusCode GetStatusCode(string code)
        {
            if (code == INVALID_CREDENTIALS)
                return HttpStatusCode.Forbidden;

            return HttpStatusCode.OK;
        }
    }
}
