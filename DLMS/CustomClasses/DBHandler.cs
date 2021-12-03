using System;
using System.Data;
using System.Data.SQLite;
using System.Text;

namespace DLMS.CustomClasses
{
    class DBHandler
    {
        private SQLiteConnection sqliteConn;
        private SQLiteCommand _sqliteCmd;
        private SQLiteDataReader _sqliteReader;
        private StringBuilder _query;

        public DBHandler()
        {
            sqliteConn = new SQLiteConnection(@"DataSource=|DataDirectory|\Databases\StudentDB.db;Version=3");
            _query = new StringBuilder();
        }

        public bool VerifyLogIn(string email, string password)
        {
            bool verify = false;

            // Fetch the data from the database
            _query.Append("SELECT * FROM [tblLogIn] WHERE [Email] = @email AND [Password] = @password");

            // Open the db connection
            sqliteConn.Open();

            // Execute query command
            _sqliteCmd = new SQLiteCommand(_query.ToString(), sqliteConn);
            _sqliteCmd.Parameters.AddWithValue("@email", email);
            _sqliteCmd.Parameters.AddWithValue("@password", password);
            _sqliteReader = _sqliteCmd.ExecuteReader();

            // Returns true if a row is found, otherwise false
            if (_sqliteReader.Read())
            {
                verify = true;
                InputCredentials.LogInID = Convert.ToInt32(_sqliteReader["LogInID"]);
            }

            // Close the db connection
            sqliteConn.Close();

            //Clear objects after use
            _sqliteCmd = null;
            _sqliteReader = null;
            _query.Clear();

            //Force GC
            GC.Collect();

            return verify;
        }

        public void FetchDataStudent()
        {
            // Fetch the data from the database
            _query.Append("SELECT" + "\n" +
                          "[tStud].*," + "\n" +
                          "[tLI].[Email]," + "\n" +
                          "[tLI].[Password]," + "\n" +
                          "[tCour].[Course]," + "\n" +
                          "[tCamp].[Campus]" + "\n" +
                          "FROM [tblInformation] AS [tInfo]" + "\n" +
                          "INNER JOIN [tblStudents] AS [tStud] ON [tInfo].[StudentID] = [tStud].[StudentID]" + "\n" +
                          "INNER JOIN [tblLogIn] AS [tLI] ON [tInfo].[LogInID] = [tLI].[LogInID]" + "\n" +
                          "INNER JOIN [tblCourses] AS [tCour] ON [tInfo].[CourseID] = [tCour].[CourseID]" + "\n" +
                          "INNER JOIN [tblCampuses] AS [tCamp] ON [tInfo].[CampusID] = [tCamp].[CampusID]" + "\n" +
                          "WHERE [tInfo].[LogInID] = @loginID");

            // Open the db connection
            sqliteConn.Open();

            // Execute query command
            _sqliteCmd = new SQLiteCommand(_query.ToString(), sqliteConn);
            _sqliteCmd.Parameters.AddWithValue("@loginID", InputCredentials.LogInID);
            _sqliteReader = _sqliteCmd.ExecuteReader();

            // Get data of student
            if (_sqliteReader.Read())
            {
                Student.StudentID = Convert.ToInt64(_sqliteReader["StudentID"]);
                Student.FName = _sqliteReader["FirstName"].ToString();
                Student.LName = _sqliteReader["LastName"].ToString();
                Student.LName = _sqliteReader["LastName"].ToString();
                Student.AcadLvl = _sqliteReader["AcademicLevel"].ToString();
                Student.Section = _sqliteReader["Section"].ToString();
                Student.YearLvl = _sqliteReader["YearLevel"].ToString();
                Student.Email = _sqliteReader["Email"].ToString();
                Student.Password = _sqliteReader["Password"].ToString();
                Student.Course = _sqliteReader["Course"].ToString();
                Student.Campus = _sqliteReader["Campus"].ToString();
            }

            // Close the db connection
            sqliteConn.Close();

            //Clear objects after use
            this._sqliteCmd = null;
            this._sqliteReader = null;
            _query.Clear();

            //Force GC
            GC.Collect();
        }
    }
}