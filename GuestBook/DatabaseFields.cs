using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuestBook
{
    class DatabaseFields
    {
        public static string UserTable = "[User]";
        public static string ReplyTable = "Reply";
        public static string MessageTable = "Message";
        public static string userID = "userID";
        public static string User_username = "username";
        public static string User_password = "upassword";
        public static string User_firstName = "firstName";
        public static string User_lastName = "lastName";
        public static string User_isActive = "isActive";
        public static string messageID = "messageID";
        public static string Message_messageText = "messageText";
        public static string Message_UserID = "userID";
        public static string isDeleted = "isDeleted";
        public static string replyID = "replyID";
        public static string Reply_replyText = "replyText";
    }
}
