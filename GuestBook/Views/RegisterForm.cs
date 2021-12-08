using GuestBook.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuestBook.Views
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (UserController.RegisterUser(usernameTextBox.Text, passwordTextBox.Text, firstNameTextbox.Text, lastNameTextBox.Text))
            {
                MessageBox.Show("Registered");
                UserController.returnToLogin(this);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Already Exists");
            }

        }

        private void usernameLabel_Click(object sender, EventArgs e)
        {

        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            UserController.returnToLogin(this);
          
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        protected override void OnClosed(EventArgs e)
        {
            UserController.returnToLogin(this);
            base.OnClosed(e);
        }
    }
}
