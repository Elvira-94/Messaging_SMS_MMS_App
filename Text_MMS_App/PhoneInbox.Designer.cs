namespace Text_MMS_App
{
    partial class PhoneInbox
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
            this.listInbox = new System.Windows.Forms.CheckedListBox();
            this.btnMarkRead = new System.Windows.Forms.Button();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listInbox
            // 
            this.listInbox.FormattingEnabled = true;
            this.listInbox.Location = new System.Drawing.Point(51, 54);
            this.listInbox.Name = "listInbox";
            this.listInbox.Size = new System.Drawing.Size(452, 257);
            this.listInbox.TabIndex = 0;
            // 
            // btnMarkRead
            // 
            this.btnMarkRead.Location = new System.Drawing.Point(125, 357);
            this.btnMarkRead.Name = "btnMarkRead";
            this.btnMarkRead.Size = new System.Drawing.Size(277, 47);
            this.btnMarkRead.TabIndex = 1;
            this.btnMarkRead.Text = "Mark as read";
            this.btnMarkRead.UseVisualStyleBackColor = true;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.Location = new System.Drawing.Point(165, 13);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(70, 25);
            this.lblPhoneNumber.TabIndex = 2;
            this.lblPhoneNumber.Text = "label1";
            // 
            // PhoneInbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 450);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.btnMarkRead);
            this.Controls.Add(this.listInbox);
            this.Name = "PhoneInbox";
            this.Text = "PhoneInbox";
            this.Load += new System.EventHandler(this.PhoneInbox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox listInbox;
        private System.Windows.Forms.Button btnMarkRead;
        private System.Windows.Forms.Label lblPhoneNumber;
    }
}