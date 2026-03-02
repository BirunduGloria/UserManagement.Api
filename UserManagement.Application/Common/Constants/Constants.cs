namespace Core.Application.Common.Constants
{
    public static class Constants
    {
        public const int OTPLength = 6;
        public const double OTPExpiry = 300000;
        public const string SETTING_FIELD_DEVICE_BLOCKTIME = "device.blocktime";
        public const string SETTING_FIELD_LOGIN_ATTEMPTS = "login.attempts";
        public const string REDIS_KEY_SUBSIDIARY_SETTINGS_KEY = "{0}_subsidiary.settings";
        public const double SETTING_DEFAULT_TOKEN_EXPIRY = 900; // Seconds
        public const double SETTING_DEFAULT_CLAIMS_EXPIRY = 21600; // Seconds
        public const double SETTING_DEFAULT_DEVICE_BLOCKTIME = 60000;
        public const int SETTING_DEFAULT_LOGIN_ATTEMPTS = 3;
        public const int SETTING_DEFAULT_OTP_ATTEMPTS = 3;
    }
}