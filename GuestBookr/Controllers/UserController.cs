using GuestBook.Models;
using GuestBook.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuestBook.Controllers
{

 
    class UserController
    {
      static GuestBookUser user;
    
        public static GuestBookUser getUser()
        {
            return user;
        }
        public static void resetUser()
        {
            user = null;
        }


        public static bool verifyOwner(int id)
        {
            if (UserController.getUser().userID == id)
            {
                return true;
            }
            return false;
        }
    
        public static bool AuthenticateLogin(string username , string password)
        {
           user = GuestBookUser.getUser(username, password);
            if (user == null)
            {
                return false;
            }
            else
            {

                NavigationController.ShowMainScreen("Logged In Successfully");
               
                return true;
             
            }
        }

    
           
        
     
     
      
        
        public static bool RegisterUser(string username, string password , string firstName , string lastName)
        {
            bool successful = GuestBookUser.addUser(username, password, firstName, lastName);
           

            return successful;
        }



    }
}
