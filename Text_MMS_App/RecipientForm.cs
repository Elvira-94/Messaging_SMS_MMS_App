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
    public partial class RecipientForm : Form
    {
        //Global variables
        public static String mobileNumber = "0878102300"; //Mobile number for the (sender)
        //public  bool pictureThere = false;
        //public bool audioThere = false;
        //public bool videoThere = false;
        public RecipientForm()
        {
            InitializeComponent();
        }

        private void RecipientForm_Load(object sender, EventArgs e)
        {
            this.Text = $"Recipient Mobile ({mobileNumber})";
            lblMediaFileName.Visible = false ;
            txtMediaFileName.Visible = false ;
            
        }

        //Added these to keep track of whether there is actually a new message to be retrieved
        string lastMessageID;
        string latestMessageID;

        

        private void btnReadMessage_Click(object sender, EventArgs e)
        {
            

                

        }

        private void btnOpenImage_Click(object sender, EventArgs e)
        {

        }
    }
}
