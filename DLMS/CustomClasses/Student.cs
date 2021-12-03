namespace DLMS.CustomClasses
{
    class Student
    {
        // Fields
        private static long _studentID;
        private static string _fName, _lName, _acadLvl, _section, _yearLvl, _email, _password, _course, _campus;

        // Properties
        public static long StudentID { get => _studentID; set => _studentID = value; }

        public static string FName { get => _fName; set => _fName = value; }

        public static string LName { get => _lName; set => _lName = value; }

        public static string AcadLvl { get => _acadLvl; set => _acadLvl = value; }

        public static string Section { get => _section; set => _section = value; }

        public static string YearLvl { get => _yearLvl; set => _yearLvl = value; }

        public static string Email { get => _email; set => _email = value; }

        public static string Password { get => _password; set => _password = value; }

        public static string Course { get => _course; set => _course = value; }

        public static string Campus { get => _campus; set => _campus = value; }
    }
}
