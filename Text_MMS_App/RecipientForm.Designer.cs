namespace Text_MMS_App
{
    partial class RecipientForm
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
            this.btnReadMessage = new System.Windows.Forms.Button();
            this.txtDisplayText = new System.Windows.Forms.TextBox();
            this.lblMediaFileName = new System.Windows.Forms.Label();
            this.txtMediaFileName = new System.Windows.Forms.TextBox();
            this.btnOpenImage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReadMessage
            // 
            this.btnReadMessage.Location = new System.Drawing.Point(87, 59);
            this.btnReadMessage.Name = "btnReadMessage";
            this.btnReadMessage.Size = new System.Drawing.Size(266, 55);
            this.btnReadMessage.TabIndex = 0;
            this.btnReadMessage.Text = "Read Message";
            this.btnReadMessage.UseVisualStyleBackColor = true;
            this.btnReadMessage.Click += new System.EventHandler(this.btnReadMessage_Click);
            // 
            // txtDisplayText
            // 
            this.txtDisplayText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplayText.Location = new System.Drawing.Point(87, 167);
            this.txtDisplayText.Name = "txtDisplayText";
            this.txtDisplayText.ReadOnly = true;
            this.txtDisplayText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDisplayText.Size = new System.Drawing.Size(266, 44);
            this.txtDisplayText.TabIndex = 1;
            // 
            // lblMediaFileName
            // 
            this.lblMediaFileName.AutoSize = true;
            this.lblMediaFileName.Location = new System.Drawing.Point(87, 303);
            this.lblMediaFileName.Name = "lblMediaFileName";
            this.lblMediaFileName.Size = new System.Drawing.Size(131, 20);
            this.lblMediaFileName.TabIndex = 2;
            this.lblMediaFileName.Text = "Media File Name:";
            // 
            // txtMediaFileName
            // 
            this.txtMediaFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMediaFileName.Location = new System.Drawing.Point(91, 361);
            this.txtMediaFileName.Name = "txtMediaFileName";
            this.txtMediaFileName.Size = new System.Drawing.Size(262, 44);
            this.txtMediaFileName.TabIndex = 3;
            // 
            // btnOpenImage
            // 
            this.btnOpenImage.Location = new System.Drawing.Point(480, 350);
            this.btnOpenImage.Name = "btnOpenImage";
            this.btnOpenImage.Size = new System.Drawing.Size(266, 55);
            this.btnOpenImage.TabIndex = 4;
            this.btnOpenImage.Text = "Open Image?";
            this.btnOpenImage.UseVisualStyleBackColor = true;
            this.btnOpenImage.Click += new System.EventHandler(this.btnOpenImage_Click);
            // 
            // RecipientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOpenImage);
            this.Controls.Add(this.txtMediaFileName);
            this.Controls.Add(this.lblMediaFileName);
            this.Controls.Add(this.txtDisplayText);
            this.Controls.Add(this.btnReadMessage);
            this.Name = "RecipientForm";
            this.Text = "RecipientForm";
            this.Load += new System.EventHandler(this.RecipientForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReadMessage;
        private System.Windows.Forms.TextBox txtDisplayText;
        private System.Windows.Forms.Label lblMediaFileName;
        private System.Windows.Forms.TextBox txtMediaFileName;
        private System.Windows.Forms.Button btnOpenImage;
    }
}