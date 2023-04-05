namespace Text_MMS_App
{
    partial class SenderForm
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
            this.btnCreateMessage = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cboMedia = new System.Windows.Forms.ComboBox();
            this.lblMediaFileName = new System.Windows.Forms.Label();
            this.txtMediaFileName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCreateMessage
            // 
            this.btnCreateMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateMessage.Location = new System.Drawing.Point(88, 422);
            this.btnCreateMessage.Name = "btnCreateMessage";
            this.btnCreateMessage.Size = new System.Drawing.Size(233, 114);
            this.btnCreateMessage.TabIndex = 8;
            this.btnCreateMessage.Text = "Create Message";
            this.btnCreateMessage.UseVisualStyleBackColor = true;
            this.btnCreateMessage.Click += new System.EventHandler(this.btnSendMessage_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(81, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(328, 37);
            this.label5.TabIndex = 9;
            this.label5.Text = "Write your Message:";
            // 
            // txtMessage
            // 
            this.txtMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessage.Location = new System.Drawing.Point(458, 72);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMessage.Size = new System.Drawing.Size(311, 109);
            this.txtMessage.TabIndex = 12;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(458, 455);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(244, 81);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Clear";
            this.btnCancel.UseVisualStyleBackColor = true;
            
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(81, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 37);
            this.label3.TabIndex = 16;
            this.label3.Text = "Add Media?";
            // 
            // cboMedia
            // 
            this.cboMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMedia.FormattingEnabled = true;
            this.cboMedia.Items.AddRange(new object[] {
            "(None)",
            "Picture",
            "Audio",
            "Video"});
            this.cboMedia.Location = new System.Drawing.Point(458, 202);
            this.cboMedia.Name = "cboMedia";
            this.cboMedia.Size = new System.Drawing.Size(265, 45);
            this.cboMedia.TabIndex = 17;
            this.cboMedia.SelectedIndexChanged += new System.EventHandler(this.cboMedia_SelectedIndexChanged);
            // 
            // lblMediaFileName
            // 
            this.lblMediaFileName.AutoSize = true;
            this.lblMediaFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMediaFileName.Location = new System.Drawing.Point(81, 273);
            this.lblMediaFileName.Name = "lblMediaFileName";
            this.lblMediaFileName.Size = new System.Drawing.Size(273, 37);
            this.lblMediaFileName.TabIndex = 18;
            this.lblMediaFileName.Text = "Media File Name";
            // 
            // txtMediaFileName
            // 
            this.txtMediaFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMediaFileName.Location = new System.Drawing.Point(458, 273);
            this.txtMediaFileName.Name = "txtMediaFileName";
            this.txtMediaFileName.Size = new System.Drawing.Size(311, 44);
            this.txtMediaFileName.TabIndex = 19;
            // 
            // SenderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 560);
            this.Controls.Add(this.txtMediaFileName);
            this.Controls.Add(this.lblMediaFileName);
            this.Controls.Add(this.cboMedia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCreateMessage);
            this.Name = "SenderForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.SenderForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCreateMessage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboMedia;
        private System.Windows.Forms.Label lblMediaFileName;
        private System.Windows.Forms.TextBox txtMediaFileName;
    }
}

