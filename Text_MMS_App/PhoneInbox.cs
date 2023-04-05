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
    public partial class PhoneInbox : Form
    {

        public PhoneForm parentForm;
        public PhoneInbox(PhoneForm parent)
        {
            InitializeComponent();
            this.parentForm = parent;
            this.parentForm.phone.inboxForm = this;
        }

        public void updateMessages()
        {
            listInbox.Items.Clear();
            foreach (var message in parentForm.phone.messages)
            {
                listInbox.Items.Add(message.content);
            }
        }

        private void PhoneInbox_Load(object sender, EventArgs e)
        {
            lblPhoneNumber.Text = parentForm.phone.phoneNumber;
            listInbox.Items.Clear();
            foreach (var message in parentForm.phone.messages) 
            {
                listInbox.Items.Add(message.content);
            }
        }
    }
}
