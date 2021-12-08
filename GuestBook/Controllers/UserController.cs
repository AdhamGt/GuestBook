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
       static  NoteForm noteForm;
        static LoginForm loginForm;
        static RegisterForm registerForm;
       static  GuestBookForm guestForm;
        public static GuestBookUser getUser()
        {
            return user;
        }

        public static LoginForm getLoginForm()
        {
            if(loginForm == null)
            {
               loginForm = new LoginForm();
                return loginForm;
            }
            else
            {
                return loginForm;
            }
        }
        static  void HideLoginForm()
        {
            if (loginForm != null)
            {
                loginForm.Visible = false;
            }
            else
            {
                getLoginForm().Visible = false;
            }
        }
        public static void showtLoginForm()
        { 
             if(loginForm != null)
            {
                loginForm.Visible = true;
            }
             else
            {
                getLoginForm().Visible = true;
            }
              
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

                ShowMainScreen("Logged In Successfully");
               
                return true;
             
            }
        }


       public static void returnToLogin(Form openForm)
        {
            user = null;
            openForm.Hide();
            showtLoginForm();
        }

      
         static void ShowMainScreen(string Message)
        {

            if (guestForm == null)
            {
                guestForm = new GuestBookForm(Message);
            }
         
            HideLoginForm();
         
            guestForm.Visible = true;
        }
        public static void ShowNoteScreen(MessageType type)
        {
            if (noteForm == null)
            {
                noteForm = new NoteForm(type); 
            }
            else
            {
                noteForm.Close();
                noteForm = new NoteForm(type);
            }
            noteForm.Visible = true;
        }
        public static  void ShowRegister()
        {
          
            if (registerForm == null)
            {
                registerForm = new RegisterForm();
            }
            else
            {
                registerForm.Close();
                registerForm = new RegisterForm();
            }
            HideLoginForm();
            registerForm.Visible = true;
        }
        public static bool RegisterUser(string username, string password , string firstName , string lastName)
        {
            bool successful = GuestBookUser.addUser(username, password, firstName, lastName);
            if(successful)
            {
                ShowMainScreen("Registered Successfully");
            }

            return successful;
        }



    }
}
