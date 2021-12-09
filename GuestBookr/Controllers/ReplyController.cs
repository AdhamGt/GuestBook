using GuestBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuestBook.Controllers
{
    class ReplyController
    {
       static List<GuestBookReply> replies = new List<GuestBookReply>();
        public static bool AddReply(string replyText, GuestBookMessage message)
        {
            return GuestBookReply.addReply(replyText, message.messageID,UserController.getUser().userID);
        }
        public static bool AddCurrentMessageReply(string replyText)
        {
            return GuestBookReply.addReply(replyText, MessageController.getselectedMessage().messageID,UserController.getUser().userID);
        }
        public static List<GuestBookReply> getlocalMessages()
        {
            return replies;
        }
        public static List<GuestBookReply> getCurrentMessageReplies()
        {
            replies = GuestBookReply.getAllMessageReplies(MessageController.getselectedMessage());
            if (replies != null)
            {
                MessageController.getselectedMessage().replies = replies;
                return replies;

            }
            else
            {
                return null;
            }

        }
        public static List<GuestBookReply> getReplies(GuestBookMessage message)
        {
            replies = GuestBookReply.getAllMessageReplies(message);
            if (replies != null)
            {
                return replies;

            }
            else
            {
                return null;
            }

        }
    }
}
