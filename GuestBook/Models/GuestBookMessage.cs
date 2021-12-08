using GuestBook.Controllers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuestBook.Models
{
   public class GuestBookMessage
    {
        public int messageID;
        public string message;
        public GuestBookUser owner;
        public List<GuestBookReply> replies = new List<GuestBookReply>();



        public void setOwner(GuestBookUser owner)
        {
            this.owner = owner;
        }
        public string getOwnerName()
        {
            return owner.getFullName();
        }
        public GuestBookMessage(int messageID , string message , GuestBookUser owner)
        {
            this.messageID = messageID;
            this.owner = owner;
            this.message = message;

        }
    

   
        public static List<GuestBookMessage>getAllMessages()
        {
            GuestBookDB instance = GuestBookDB.getInstance();


            List<GuestBookMessage> messages = new List<GuestBookMessage>();
            DataTable dt = instance.Query("Select * from " + DatabaseFields.MessageTable + " INNER JOIN " + DatabaseFields.UserTable + " ON " + DatabaseFields.UserTable+"."+DatabaseFields.userID +" = "+ DatabaseFields.MessageTable+"."+DatabaseFields.userID+" Where "+  DatabaseFields.MessageTable + "."+ DatabaseFields.isDeleted + " = 0 ; ");
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                      
                
                       GuestBookMessage message = new GuestBookMessage((int)dt.Rows[i][DatabaseFields.messageID],dt.Rows[i][DatabaseFields.Message_messageText].ToString(),new GuestBookUser((int)(dt.Rows[i][DatabaseFields.userID]), dt.Rows[i][DatabaseFields.User_username].ToString(), dt.Rows[i][DatabaseFields.User_password].ToString(), dt.Rows[i][DatabaseFields.User_firstName].ToString(), dt.Rows[i][DatabaseFields.User_lastName].ToString()));

                    messages.Add(message);

                }
                return messages;
            }
            else
            {
                {
                    return messages;
                }
            }
        }
        public static bool addMessage(string messageText , int userID)
        {
            GuestBookDB instance = GuestBookDB.getInstance();
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add(DatabaseFields.Message_messageText, messageText);
            parameters.Add(DatabaseFields.Message_UserID,  userID);
            parameters.Add(DatabaseFields.isDeleted, 0);
            int affected = instance.Insert(DatabaseFields.MessageTable, parameters);
            if (affected == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool UpdateMessage(string messageText, int messageID)
        {
            GuestBookDB instance = GuestBookDB.getInstance();
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add(DatabaseFields.Message_messageText, messageText);
            parameters.Add(DatabaseFields.messageID, messageID);
            int affected = instance.Update(DatabaseFields.MessageTable, parameters);
            if (affected == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool DeleteMessage( int messageID)
        {
            GuestBookDB instance = GuestBookDB.getInstance();
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add(DatabaseFields.isDeleted, 1);
            parameters.Add(DatabaseFields.messageID, messageID);
            int affected = instance.Update(DatabaseFields.MessageTable, parameters);
            if (affected == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
