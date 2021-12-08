
using System.Collections.Generic;

namespace GuestBook.Views
{
    partial class GuestBookForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nextButton = new System.Windows.Forms.Button();
            this.previousButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.messagesFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.panel0 = new System.Windows.Forms.Panel();
            this.showRepliesButton = new System.Windows.Forms.Button();
            this.ReplyButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.senderLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.greetingLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.messagesFlowLayout.SuspendLayout();
            this.panel0.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(632, 459);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(111, 23);
            this.nextButton.TabIndex = 0;
            this.nextButton.Text = "NextPage";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // previousButton
            // 
            this.previousButton.Location = new System.Drawing.Point(526, 459);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(100, 23);
            this.previousButton.TabIndex = 1;
            this.previousButton.Text = "PreviousPage";
            this.previousButton.UseVisualStyleBackColor = true;
            this.previousButton.Click += new System.EventHandler(this.previousButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(632, 23);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(111, 25);
            this.refreshButton.TabIndex = 2;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "GuestBook Messages : ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // messagesFlowLayout
            // 
            this.messagesFlowLayout.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.messagesFlowLayout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.messagesFlowLayout.Controls.Add(this.panel0);
            this.messagesFlowLayout.Controls.Add(this.panel1);
            this.messagesFlowLayout.Controls.Add(this.panel2);
            this.messagesFlowLayout.Controls.Add(this.panel3);
            this.messagesFlowLayout.Location = new System.Drawing.Point(19, 54);
            this.messagesFlowLayout.Name = "messagesFlowLayout";
            this.messagesFlowLayout.Size = new System.Drawing.Size(724, 347);
            this.messagesFlowLayout.TabIndex = 4;
            // 
            // panel0
            // 
            this.panel0.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel0.Controls.Add(this.showRepliesButton);
            this.panel0.Controls.Add(this.ReplyButton);
            this.panel0.Controls.Add(this.label8);
            this.panel0.Controls.Add(this.senderLabel);
            this.panel0.Location = new System.Drawing.Point(3, 3);
            this.panel0.Name = "panel0";
            this.panel0.Size = new System.Drawing.Size(719, 80);
            this.panel0.TabIndex = 0;
            // 
            // showRepliesButton
            // 
            this.showRepliesButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.showRepliesButton.Location = new System.Drawing.Point(534, 48);
            this.showRepliesButton.Name = "showRepliesButton";
            this.showRepliesButton.Size = new System.Drawing.Size(100, 23);
            this.showRepliesButton.TabIndex = 3;
            this.showRepliesButton.Text = "Show Replies";
            this.showRepliesButton.UseVisualStyleBackColor = false;
            this.showRepliesButton.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // ReplyButton
            // 
            this.ReplyButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ReplyButton.Location = new System.Drawing.Point(640, 48);
            this.ReplyButton.Name = "ReplyButton";
            this.ReplyButton.Size = new System.Drawing.Size(75, 23);
            this.ReplyButton.TabIndex = 2;
            this.ReplyButton.Text = "Reply";
            this.ReplyButton.UseVisualStyleBackColor = false;
            this.ReplyButton.Click += new System.EventHandler(this.ReplyButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(14, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 15);
            this.label8.TabIndex = 1;
            this.label8.Text = "this is a sample message";
            // 
            // senderLabel
            // 
            this.senderLabel.AutoSize = true;
            this.senderLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.senderLabel.Location = new System.Drawing.Point(3, 9);
            this.senderLabel.Name = "senderLabel";
            this.senderLabel.Size = new System.Drawing.Size(52, 15);
            this.senderLabel.TabIndex = 0;
            this.senderLabel.Text = "Sender : ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(3, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(719, 80);
            this.panel1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(534, 48);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Show Replies";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(640, 48);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Reply";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.ReplyButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(14, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "this is a sample message";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(3, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Sender : ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(3, 175);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(719, 80);
            this.panel2.TabIndex = 2;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.Location = new System.Drawing.Point(534, 48);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Show Replies";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button5.Location = new System.Drawing.Point(640, 48);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 2;
            this.button5.Text = "Reply";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.ReplyButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(14, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "this is a sample message";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label5.Location = new System.Drawing.Point(3, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Sender : ";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.Controls.Add(this.button6);
            this.panel3.Controls.Add(this.button7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(3, 261);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(719, 80);
            this.panel3.TabIndex = 3;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button6.Location = new System.Drawing.Point(534, 48);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 23);
            this.button6.TabIndex = 3;
            this.button6.Text = "Show Replies";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button7.Location = new System.Drawing.Point(640, 48);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 2;
            this.button7.Text = "Reply";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.ReplyButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(14, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "this is a sample message";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label7.Location = new System.Drawing.Point(3, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Sender : ";
            // 
            // greetingLabel
            // 
            this.greetingLabel.AutoSize = true;
            this.greetingLabel.Location = new System.Drawing.Point(324, 9);
            this.greetingLabel.Name = "greetingLabel";
            this.greetingLabel.Size = new System.Drawing.Size(81, 15);
            this.greetingLabel.TabIndex = 5;
            this.greetingLabel.Text = "Welcome Text";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(324, 418);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Add Note";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(12, 464);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(111, 23);
            this.button8.TabIndex = 7;
            this.button8.Text = "Log Out";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // GuestBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 499);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.greetingLabel);
            this.Controls.Add(this.messagesFlowLayout);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.previousButton);
            this.Controls.Add(this.nextButton);
            this.Name = "GuestBookForm";
            this.Text = "GuestBook";
            this.messagesFlowLayout.ResumeLayout(false);
            this.panel0.ResumeLayout(false);
            this.panel0.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel messagesFlowLayout;
        private System.Windows.Forms.Panel panel0;
        private System.Windows.Forms.Button ReplyButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label senderLabel;
        private System.Windows.Forms.Button showRepliesButton;
        private System.Windows.Forms.Label greetingLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button8;
    }
}