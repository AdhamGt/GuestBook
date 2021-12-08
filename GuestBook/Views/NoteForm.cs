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
            if(messageType == MessageType.GuestBookMessage)
            {
                label3.Text = "Type Your Guest Note : ";
            }
            else if (messageType == MessageType.GuestBookReply)
            {
                label3.Text = "Type Your Reply Note : ";
            }
            else if (messageType == MessageType.GuestBookUpdatedMessage)
            {
                label3.Text = "Update Your Guest Note : ";
                noteTextBox.Text = MessageController.getselectedMessage().message;
            }



        }

        public NoteForm(string message)
        {
       

            InitializeComponent();
            if (messageType == MessageType.GuestBookMessage)
            {
                label3.Text = "Update Your Guest Note : ";
            }
          


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
                        NavigationController.updateUIFields();
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

                    if (ReplyController.AddCurrentMessageReply(noteTextBox.Text))
                    {
                        NavigationController.updateUIFields();
                        MessageBox.Show("Reply Sent Successfully");
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("Reply Faild");
                        this.Close();
                    }


                    break;
                case MessageType.GuestBookUpdatedMessage:

                    if (MessageController.UpdateViewedMessage(noteTextBox.Text))
                    {
                        NavigationController.updateUIFields();
                        MessageBox.Show("Message  Updated Successfully");
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("Reply Faild");
                        this.Close();
                    }


                    break;
            }
        }
    }
}
