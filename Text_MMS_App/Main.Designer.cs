namespace Text_MMS_App
{
    partial class Main
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
            System.Windows.Forms.Label label1;
            this.txtPhoneNumberInput = new System.Windows.Forms.TextBox();
            this.btnCreatePhone = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPhoneNumberInput
            // 
            this.txtPhoneNumberInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumberInput.Location = new System.Drawing.Point(459, 99);
            this.txtPhoneNumberInput.Name = "txtPhoneNumberInput";
            this.txtPhoneNumberInput.Size = new System.Drawing.Size(323, 44);
            this.txtPhoneNumberInput.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(125, 102);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(255, 37);
            label1.TabIndex = 1;
            label1.Text = "Phone Number:";
            label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnCreatePhone
            // 
            this.btnCreatePhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreatePhone.Location = new System.Drawing.Point(459, 197);
            this.btnCreatePhone.Name = "btnCreatePhone";
            this.btnCreatePhone.Size = new System.Drawing.Size(286, 55);
            this.btnCreatePhone.TabIndex = 2;
            this.btnCreatePhone.Text = "Create New Phone";
            this.btnCreatePhone.UseVisualStyleBackColor = true;
            this.btnCreatePhone.Click += new System.EventHandler(this.btnCreatePhone_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 641);
            this.Controls.Add(this.btnCreatePhone);
            this.Controls.Add(label1);
            this.Controls.Add(this.txtPhoneNumberInput);
            this.Name = "Main";
            this.Text = "MessageStatus";
            this.Load += new System.EventHandler(this.MessageStatus_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPhoneNumberInput;
        private System.Windows.Forms.Button btnCreatePhone;
    }
}