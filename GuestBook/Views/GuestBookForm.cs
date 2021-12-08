using GuestBook.Controllers;
using GuestBook.Models;
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

namespace GuestBook.Views
{
    public partial class GuestBookForm : Form
    {

        List<System.Windows.Forms.Panel> uiPanels = new List<Panel>();
        int pageIndex = 0;
        int messagesCount = 0;
        int pageSize = 4;

        void addPanels()
        {
            uiPanels.Add(panel0);
            uiPanels.Add(panel1);
            uiPanels.Add(panel2);
            uiPanels.Add(panel3);
        }


        int FindButtonParent(Button button)
        {
            int buttonIndex = 1;
            for (int i = 0; i < uiPanels.Count; i++)
            {

                try
                {


                    int index = uiPanels[i].Controls.GetChildIndex(button);

                        if(index == buttonIndex )
                        {
                           return i;
                        }
                }
                catch
                {
                    continue;
                }

            }
            return -1;
        }
            public GuestBookForm(string Message)
        {
            InitializeComponent();
            addPanels();
            GreetUser();
            updateAndDisplayMessages(MessageController.getMessages());
            
            if(!string.IsNullOrEmpty(Message))
            {
                MessageBox.Show(Message);
            }
        }

        void updateUI()
        {
          
            if (pageIndex>0)
            {
                previousButton.Visible = true;
            }
            else
            {
                previousButton.Visible = false;
               
            }
            if (pageIndex*pageSize + 4 >= messagesCount)
            {
                nextButton.Visible = false;
            }
            else
            {
                nextButton.Visible = true;
            }
        }

        void CloseAllTabs()
        {
            for(int i = 0; i < uiPanels.Count; i++)
            {
                uiPanels[i].Visible = false;
            }
        }
        void updateAndDisplayMessages(List<GuestBookMessage> messages)
        {
            CloseAllTabs();
            messagesCount = messages.Count;
            int startindex = pageIndex*pageSize;
            int endindex = startindex + pageSize;
            for(int i = startindex ,  pIndex = 0; i < endindex && i< messagesCount && pageIndex < 4; i++ , pIndex++ )
            {
                uiPanels[pIndex].Controls[2].Text = messages[i].message;
                uiPanels[pIndex].Controls[3].Text = messages[i].getOwnerName();
                uiPanels[pIndex].Visible = true;
            }
            updateUI();
        }
        void GreetUser()
        {
            GuestBookUser user = UserController.getUser();
            if (user != null)
            {
                greetingLabel.Text = "Welcome " + user.getFullName();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            pageIndex++;
            updateAndDisplayMessages(MessageController.getlocalMessages());
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            UserController.ShowNoteScreen(MessageType.GuestBookMessage);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            updateAndDisplayMessages(MessageController.getMessages());
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            pageIndex--;
            updateAndDisplayMessages(MessageController.getlocalMessages());
           
        }
        protected override void OnClosed(EventArgs e)
        {
            Application.Exit();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            UserController.returnToLogin(this);
        }



        int GetButtonIndex(Button button)
        {
            return FindButtonParent(button) + (pageIndex * pageSize);
        }
        private void ReplyButton_Click(object sender, EventArgs e)
        {

           int result =  MessageController.selectMessage(GetButtonIndex((Button)sender));
            if (result == 1)
            {
                UserController.ShowNoteScreen(MessageType.GuestBookReply);
            }
            else
            {
                MessageBox.Show("Invalid Message");
            }
        }
    }
}
