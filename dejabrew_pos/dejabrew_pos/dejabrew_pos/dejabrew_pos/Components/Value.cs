using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dejabrew_pos.Components
{
    internal class Value
    {
        public string serverName = "localhost";
        public string serverUser = "root";
        public string serverPass = "";
        public string port = "3306";
        public string database = "dejabrewpos";

        public static int userId;
        public int UserId
        {
            get { return userId; }
            set { userId = value; }
        }

        public static string userFullName;
        public string UserFullName
        {
            get { return userFullName; }
            set { userFullName = value; }
        }

        public static int userAge;
        public int UserAge
        {
            get { return userAge; }
            set { userAge = value; }
        }

        public static string userEmail;
        public string UserEmail
        {
            get { return userEmail; }
            set { userEmail = value; }
        }

        public static string userUsername;
        public string UserUsername
        {
            get { return userUsername; }
            set { userUsername = value; }
        }
    }
}
