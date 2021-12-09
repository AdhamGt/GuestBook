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
        
        public static GuestBookMessage getselectedMessage()
        {
            return viewedMessage;
        }




       public static bool UpdateViewedMessage(string updatedText)
        {
           return GuestBookMessage.UpdateMessage(updatedText, viewedMessage.messageID);
        }
        public static bool DeleteViewedMessage()
        {
            return GuestBookMessage.DeleteMessage(viewedMessage.messageID);
        }

        public static bool selectMessage(int index)
        {
            if (index >= 0 && index < messages.Count)
            {
                viewedMessage = messages[index];
                return true;
            }
            return false;
        }
      public   static List<GuestBookMessage> getlocalMessages()
        {
            return messages;
        }
        public static List<GuestBookMessage> getMessages()
        {
            messages =  GuestBookMessage.getAllMessages();
            return messages;

        }
    }
}
