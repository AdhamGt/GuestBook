using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuestBook.Models
{
    class GuestBookMessage
    {
        int messageID;
        public string message;
        GuestBookUser owner;
        List<GuestBookReply> replies = new List<GuestBookReply>();



        public void setOwner(GuestBookUser owner)
        {
            this.owner = owner;
        }
        public string getOwnerName()
        {
            return owner.firstName + " " + owner.lastName;
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
            DataTable dt = instance.Query("Select * from " + DatabaseFields.MessageTable + " INNER JOIN " + DatabaseFields.UserTable + " ON " + DatabaseFields.UserTable+"."+DatabaseFields.userID +" = "+ DatabaseFields.MessageTable+"."+DatabaseFields.userID+";");
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
                    return null;
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
        public bool verifyOwner(GuestBookUser user)
        {
            if(user.userID == owner.userID)
            {
                return true;
            }
            return false;
        }
    }
}
