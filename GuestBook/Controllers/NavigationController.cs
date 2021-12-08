using GuestBook.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuestBook.Controllers
{
    class NavigationController
    {
      public  static NoteForm noteForm;
        public static LoginForm loginForm;
        public static RegisterForm registerForm;
        public static GuestBookForm guestForm;
        public static LoginForm getLoginForm()
        {
            if (loginForm == null)
            {
                loginForm = new LoginForm();
                return loginForm;
            }
            else
            {
                return loginForm;
            }
        }
        public static void HideLoginForm()
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
            if (loginForm != null)
            {
                loginForm.Visible = true;
            }
            else
            {
                getLoginForm().Visible = true;
            }

        }
        public static void  updateMainScreen()
        {
            guestForm.updateAndDisplayMessages(MessageController.getMessages());
        }
        public static void ShowMainScreen(string Message)
        {

            if (guestForm == null)
            {
                guestForm = new GuestBookForm(Message);
            }
            else
            {
                guestForm.Close();
                guestForm = new GuestBookForm(Message);
                guestForm.DrawUI();
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
        public static void ShowRegister()
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
        public static void returnToLogin(Form openForm)
        {
            UserController.resetUser();
            openForm.Hide();
            NavigationController.showtLoginForm();
        }
    }
}
