using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Text_MMS_App
{
    public partial class PhoneForm : Form
    {

        public Phone phone; 
        public PhoneForm(Phone phone)
        {
            InitializeComponent();
            this.phone = phone;
        }

        private void PhoneForm_Load(object sender, EventArgs e)
        {
            lblPhoneNumber.Text = this.phone.phoneNumber;
        }

        private void btnInbox_Click(object sender, EventArgs e)
        {
            PhoneInbox inbox = new PhoneInbox(this);
            inbox.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string destinationNumber = txtTo.Text;
            string content = txtContent.Text;
            phone.sendMessage(content, destinationNumber);
        }
    }
}
