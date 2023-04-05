using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Text_MMS_App
{
    public partial class SenderForm : Form
    {
        //Global variables
        public static String mobileNumber = "0891766876"; //Mobile number for the (sender)

        public static Phone senderPhone = new Phone(mobileNumber);

        public SenderForm()
        {
            InitializeComponent();
            
        }


        //Event handler for sending a text message
        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            

            
        }

        private void SenderForm_Load(object sender, EventArgs e)
        {
            this.Text = $"Sender Mobile ({mobileNumber})";
            MessageServer.addPhone(senderPhone);
        }

        private void cboMedia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMedia.SelectedIndex == 1 || cboMedia.SelectedIndex == 2 || cboMedia.SelectedIndex == 3) 
            {
                lblMediaFileName.Visible = true;
                txtMediaFileName.Visible=true;
            }
            else
            {
                lblMediaFileName.Visible = false;
                txtMediaFileName.Visible=false;
            }
        }

        private void btnOImage_Click(object sender, EventArgs e)
        {

        }

    }
}
