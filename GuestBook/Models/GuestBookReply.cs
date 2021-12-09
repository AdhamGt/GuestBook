using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuestBook.Models
{
    public class GuestBookReply
    {
        int replyID;
        public string reply;
        public GuestBookMessage replyMessage;
        public GuestBookUser owner;
        public GuestBookReply(int replyID, string reply, GuestBookMessage message  , GuestBookUser owner)
        {
            this.replyID = replyID;
           
            this.reply = reply;
            this.replyMessage = message;
            this.owner = owner;
        }


        public string getOwnerName()
        {
            return owner.getFullName();
        }
        public static List<GuestBookReply> getAllMessageReplies(GuestBookMessage message)
        {
            GuestBookDB instance = GuestBookDB.getInstance();


            List<GuestBookReply> replies = new List<GuestBookReply>();
            DataTable dt = instance.Query("Select * from " + DatabaseFields.ReplyTable + " INNER JOIN " + DatabaseFields.UserTable + " ON " + DatabaseFields.UserTable + "." + DatabaseFields.userID + " = " + DatabaseFields.ReplyTable + "." + DatabaseFields.userID+ " Where " + DatabaseFields.messageID + " = " + message.messageID + " and " + DatabaseFields.isDeleted + " = 0 ; ") ;
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {


                    GuestBookReply  reply = new GuestBookReply((int)dt.Rows[i][DatabaseFields.replyID], dt.Rows[i][DatabaseFields.Reply_replyText].ToString() , message , new GuestBookUser((int)(dt.Rows[i][DatabaseFields.userID]), dt.Rows[i][DatabaseFields.User_username].ToString(), dt.Rows[i][DatabaseFields.User_password].ToString(), dt.Rows[i][DatabaseFields.User_firstName].ToString(), dt.Rows[i][DatabaseFields.User_lastName].ToString()));

                    replies.Add(reply);

                }
                message.replies = replies;
                return replies;
            }
            else
            {

                return replies;

            }
        }
        public static bool addReply(string replyText, int messageID,int userID)
        {
            GuestBookDB instance = GuestBookDB.getInstance();
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add(DatabaseFields.Reply_replyText, replyText);
            parameters.Add(DatabaseFields.messageID, messageID);
            parameters.Add(DatabaseFields.userID, userID);
            parameters.Add(DatabaseFields.isDeleted, 0);
            int affected = instance.Insert(DatabaseFields.ReplyTable, parameters);
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
