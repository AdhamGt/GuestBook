
namespace GuestBook.Views
{
    partial class NoteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NoteForm));
            this.label3 = new System.Windows.Forms.Label();
            this.noteTextBox = new System.Windows.Forms.RichTextBox();
            this.nextButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Type Your Guest Note : ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // noteTextBox
            // 
            this.noteTextBox.Location = new System.Drawing.Point(39, 59);
            this.noteTextBox.Name = "noteTextBox";
            this.noteTextBox.Size = new System.Drawing.Size(722, 130);
            this.noteTextBox.TabIndex = 12;
            this.noteTextBox.Text = "";
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(650, 204);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(111, 23);
            this.nextButton.TabIndex = 11;
            this.nextButton.Text = "Send";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // NoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 256);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.noteTextBox);
            this.Controls.Add(this.nextButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NoteForm";
            this.Text = "Note";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox noteTextBox;
        private System.Windows.Forms.Button nextButton;
    }
}