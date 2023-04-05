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
    public partial class Main : Form
    {
        //Added this to make this MessageStatus referenceable in other classes
        public static Main messageStatusInstance;
        static DataTable dt = new DataTable();

        public Main()
        {
            InitializeComponent();
            //Added with static messageStatusInstance declaration above to make referenceable in other classes
            messageStatusInstance = this;
        }

        private void MessageStatus_Load(object sender, EventArgs e)
        {
            this.Location = new Point(700, 100);

            SenderForm senderFormInstance = new SenderForm();
            senderFormInstance.Show();
            senderFormInstance.Location = new Point(200, 460);

            RecipientForm recipientFormInstance = new RecipientForm();
            recipientFormInstance.Show();
            recipientFormInstance.Location = new Point(200, 460);

            dt = new DataTable();
            dt.Columns.Add("Created", typeof(string));
            dt.Columns.Add("Sent", typeof (string));
            dt.Columns.Add("Received", typeof(string));
            dt.Columns.Add("MessageID", typeof(string));
            dt.Columns.Add("Picture", typeof(string));
            dt.Columns.Add("Audio", typeof(string));
            dt.Columns.Add("Video", typeof(string)) ;
            dt.Columns.Add("Event #", typeof(int));
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCreatePhone_Click(object sender, EventArgs e)
        {
            string phoneNumber = txtPhoneNumberInput.Text;
            try
            {
                MessageServer.getPhoneByNumber(phoneNumber);
            }
            catch
            {
                Phone newPhone = new Phone(phoneNumber).DeepCopy();
                PhoneForm phoneForm = new PhoneForm(newPhone);
                phoneForm.Show();
            }
            
        }
    }
}
