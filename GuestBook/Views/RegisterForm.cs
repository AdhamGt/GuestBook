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

        List<string> errors = new List<string>();
        private void loginButton_Click(object sender, EventArgs e)
        {

            if(FieldValidator.ValidateNameStructure(firstNameTextbox.Text))
            {
                if (FieldValidator.ValidateNameStructure(lastNameTextBox.Text))
                {
                    if (FieldValidator.ValidateUsernameStructure(usernameTextBox.Text))
                    {
                        if (FieldValidator.ValidatePasswordStructure(passwordTextBox.Text))
                        {
                            if (FieldValidator.VerifyPassword(passwordTextBox.Text, confirmPasswordTextBox.Text))
                            {
                                if (UserController.RegisterUser(usernameTextBox.Text, passwordTextBox.Text, firstNameTextbox.Text, lastNameTextBox.Text))
                                {

                                    MessageBox.Show("Registered");
                                    NavigationController.returnToLogin(this);
                                    this.Hide();
                                }
                                else
                                {
                                    MessageBox.Show("Username Already Exists");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Passwords Don't Match");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Wrong Password Format ");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Wrong Username Format ");
                    }
                }
                else
                {
                    MessageBox.Show("Wrong LastName Format ");
                }
            }
            else
            {
                MessageBox.Show("Wrong FirstName Format ");

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
            NavigationController.returnToLogin(this);
          
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        protected override void OnClosed(EventArgs e)
        {
            NavigationController.returnToLogin(this);
            base.OnClosed(e);
        }
    }
}
