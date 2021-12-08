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
    public partial class NoteForm : Form
    {
        MessageType messageType;
        public NoteForm(MessageType mt)
        {
            messageType = mt;

            InitializeComponent();
           
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            switch (messageType)
            {

                case MessageType.GuestBookMessage:

             
            if (MessageController.AddMessage(noteTextBox.Text))
            {
                MessageBox.Show("Message Sent Successfully");
                this.Close();

            }
            else
            {
                MessageBox.Show("Message Faild");
                this.Close();
            }
                    break;
                case MessageType.GuestBookReply:

                    // add reply to message




                    break;

            }
        }
    }
}
