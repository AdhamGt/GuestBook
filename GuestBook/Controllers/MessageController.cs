using GuestBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuestBook.Controllers
{
    class MessageController
    {

        static List<GuestBookMessage> messages = new List<GuestBookMessage>();
        static GuestBookMessage viewedMessage;
        public static bool AddMessage(string messageText)
        {
            return GuestBookMessage.addMessage(messageText, UserController.getUser().userID);
        }

        public static int selectMessage(int index)
        {
            if (index > 0 && index < messages.Count)
            {
                viewedMessage = messages[index];
                return 1;
            }
            return -1;
        }
      public   static List<GuestBookMessage> getlocalMessages()
        {
            return messages;
        }
        public static List<GuestBookMessage> getMessages()
        {
            messages =  GuestBookMessage.getAllMessages();
            if(messages != null)
            {
                return messages;

            }
            else
            {
                return null;
            }

        }
    }
}
