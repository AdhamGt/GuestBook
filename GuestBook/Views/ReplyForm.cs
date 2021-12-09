using GuestBook.Controllers;
using GuestBook.Models;
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
    public partial class ReplyForm : Form
    {
        List<System.Windows.Forms.Panel> uiPanels = new List<Panel>();
 
        int pageIndex = 0;
        int repliesCount = 0;
        int pageSize = 4;

        void addPanels()
        {
            uiPanels.Add(upanel0);
            uiPanels.Add(upanel1);
            uiPanels.Add(upanel2);
            uiPanels.Add(upanel3);
        }
      
        public ReplyForm()
        {

            InitializeComponent();
 
            addPanels();
       
            updateAndDisplayMessages(ReplyController.getCurrentMessageReplies());
        }
        void CloseAllTabs()
        {
            for (int i = 0; i < uiPanels.Count; i++)
            {
                uiPanels[i].Visible = false;
            }
        }
        public void updateAndDisplayMessages(List<GuestBookReply> replies)
        {
            if (replies == null)
            {
                MessageBox.Show("No Replies");
                this.Close();
               return;
            }
            else if( replies.Count == 0)
            {
                MessageBox.Show("No Replies");
                this.Close();
                return;
            }
           
            CloseAllTabs();
            repliesCount = replies.Count;
            int startindex = pageIndex * pageSize;
            int endindex = startindex + pageSize;

            if (UserController.verifyOwner(MessageController.getselectedMessage().owner.userID))
            {
                mainPanel.Controls[1].ForeColor = Color.Red;
            }
            else
            {
                mainPanel.Controls[1].ForeColor = Color.Blue;
            }
                mainPanel.Controls[1].Text = MessageController.getselectedMessage().getOwnerName()+ " (You) ";
            mainPanel.Controls[0].Text = MessageController.getselectedMessage().message;
            for (int i = startindex, pIndex = 0; i < endindex && i < repliesCount && pIndex < 4; i++, pIndex++)
            {
                uiPanels[pIndex].Controls[0].Text = replies[i].reply;


                if (UserController.verifyOwner(replies[i].owner.userID))
                {
                    uiPanels[pIndex].Controls[1].Text = replies[i].getOwnerName() + " (You) " + " Replied : ";
                    uiPanels[pIndex].Controls[1].ForeColor = Color.Red;
              
                }
                else
                {
                    uiPanels[pIndex].Controls[1].Text = replies[i].getOwnerName() + " Replied : ";
                    uiPanels[pIndex].Controls[1].ForeColor = Color.Blue;
             
                }
                uiPanels[pIndex].Visible = true;
            }
            updateUI();
        }
        void updateUI()
        {

            if (pageIndex > 0)
            {
                previousButton.Visible = true;
            }
            else
            {
                previousButton.Visible = false;

            }
            if (pageIndex * pageSize + pageSize >= repliesCount)
            {
                nextButton.Visible = false;
            }
            else
            {
                nextButton.Visible = true;
            }
        }
     
     


        public void DrawUI()
        {
            pageIndex = 0;
           repliesCount = 0;
          
            updateAndDisplayMessages(ReplyController.getCurrentMessageReplies());
        }

      
        private void nextButton_Click(object sender, EventArgs e)
        {
            pageIndex++;
            updateAndDisplayMessages(ReplyController.getCurrentMessageReplies());
        }

        private void RefreshClick(object sender, EventArgs e)
        {
            updateAndDisplayMessages(ReplyController.getCurrentMessageReplies());
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            pageIndex--;
            updateAndDisplayMessages(ReplyController.getCurrentMessageReplies());

        }
    }
}
