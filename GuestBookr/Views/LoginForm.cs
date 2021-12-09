using GuestBook.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuestBook
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          bool giveAccess =   UserController.AuthenticateLogin(usernameTextBox.Text, passwordTextBox.Text);
            if (!giveAccess)
            {

                MessageBox.Show("Login Failed");
            }
          

        }
        public void ResetTextBoxes()
        {
            usernameTextBox.Text = "";
            passwordTextBox.Text = "";
        }
        private void label1_Click_1(object sender, EventArgs e)
        {
            NavigationController.ShowRegister();
        }

        protected override void OnClosed(EventArgs e)
        {
            Application.Exit();
        }
    }
}
