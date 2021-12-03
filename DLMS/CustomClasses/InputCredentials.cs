namespace DLMS.CustomClasses
{
    class InputCredentials
    {
        // Fields
        private static int s_logInID;
        private static string s_email, s_password;

        // Properties
        public static int LogInID { get => s_logInID; set => s_logInID = value; }

        public static string Email { get => s_email; set => s_email = value; }

        public static string Password { get => s_password; set => s_password = value; }
    }
}
