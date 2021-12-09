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
        List<ListUIHandler> handlers = new List<ListUIHandler>();
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
        void FillHandler()
        {
           
            for (int i = 0; i < uiPanels.Count; i++)
            {
                ListUIHandler handler = new ListUIHandler();
                handler.panelIndex = i;
                    handler.buttons.AddRange(uiPanels[i].Controls.OfType<Button>());
                handlers.Add(handler);
            }
            
        }

        int FindButtonParent(Button button)
        {
            for (int i = 0; i < handlers.Count; i++)
            {
                if (handlers[i].FindIndexByButton(button))
                {
                    return handlers[i].panelIndex;
                   
                }
            }
            return -1;
        }






      public  void DrawUI()
        {
            pageIndex = 0;
             messagesCount = 0;
            GreetUser();
            updateAndDisplayMessages(MessageController.getMessages());
        }


            public GuestBookForm(string Message)
        {
            InitializeComponent();
            addPanels();
            FillHandler();
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
            if (pageIndex*pageSize + pageSize >= messagesCount)
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
        public void updateAndDisplayMessages(List<GuestBookMessage> messages)
        {
            if (messages == null)
            {
             
                return;
            }
            else if (messages.Count == 0)
            {
               
                return;
            }
            CloseAllTabs();
            messagesCount = messages.Count;
            int startindex = pageIndex*pageSize;
            int endindex = startindex + pageSize;
            for(int i = startindex ,  pIndex = 0; i < endindex && i< messagesCount && pIndex < 4; i++ , pIndex++ )
            {
                uiPanels[pIndex].Controls[4].Text = messages[i].message;
              
              
                if(UserController.verifyOwner(messages[i].owner.userID))
               {
                    uiPanels[pIndex].Controls[5].Text = messages[i].getOwnerName()+ " (You) ";
                    uiPanels[pIndex].Controls[5].ForeColor = Color.Red;
                   uiPanels[pIndex].Controls[0].Visible = true;
                  uiPanels[pIndex].Controls[1].Visible = true;
              }
              else
              {
                    uiPanels[pIndex].Controls[5].Text = messages[i].getOwnerName();
                    uiPanels[pIndex].Controls[5].ForeColor = Color.Blue;
                    uiPanels[pIndex].Controls[0].Visible = false;
                  uiPanels[pIndex].Controls[1].Visible = false;
              }
                uiPanels[pIndex].Visible = true;
            }
            updateUI();
        }
        void GreetUser()
        {
            
            if (UserController.getUser() != null)
            {
               greetingLabel.Text = "Welcome " + UserController.getUser().getFullName();
          
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

        private void button1_Click_3(object sender, EventArgs e)
        {
            NavigationController.ShowNoteScreen(MessageType.GuestBookMessage);
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
        void CloseForm()
        {
            NavigationController.CloseAllOptionalForms();
            NavigationController.returnToLogin(this);
        }
        protected override void OnClosed(EventArgs e)
        {
            CloseForm();
            base.OnClosed(e);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            CloseForm();
            this.Close();
        }



        int GetButtonIndex(Button button)
        {
            return FindButtonParent(button) + (pageIndex * pageSize);
        }
        private void ReplyButton_Click(object sender, EventArgs e)
        {



            if (MessageController.selectMessage(GetButtonIndex((Button)sender)))
            {
                NavigationController.ShowNoteScreen(MessageType.GuestBookReply);
            }
            else
            {
                MessageBox.Show("Invalid Message");
            }
        }

        private void GuestBookForm_Load(object sender, EventArgs e)
        {

        }

        private void UpdateMessage_Click(object sender, EventArgs e)
        {
            if (MessageController.selectMessage(GetButtonIndex((Button)sender)))
            {
                NavigationController.ShowNoteScreen(MessageType.GuestBookUpdatedMessage);
            }
            else
            {
                MessageBox.Show("Failed");
            }
       
        }

        private void DeleteMessage_Click(object sender, EventArgs e)
        {
            DialogResult verifyDecision = MessageBox.Show("Are you sure you want to permenantly delete this message ?",
                                       "Alert !",
                                       MessageBoxButtons.YesNo);
            if (verifyDecision == DialogResult.Yes)
            {
                if (MessageController.selectMessage(GetButtonIndex((Button)sender)))
                {
                    if (MessageController.DeleteViewedMessage())
                    {
                        MessageBox.Show("Deleted");
                        updateAndDisplayMessages(MessageController.getMessages());
                    }
                    else
                    {
                        MessageBox.Show("Failed");
                    }
                }
                else
                {
                    MessageBox.Show("Failed");
                }
            }
        }

        private void showRepliesButton_Click(object sender, EventArgs e)
        {
            if (MessageController.selectMessage(GetButtonIndex((Button)sender)))
            {
                NavigationController.ShowReplies();
            }
            else
            {
                MessageBox.Show("Failed");
            }
        }
    }
}
