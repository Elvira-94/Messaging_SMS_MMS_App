using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Text_MMS_App
{
    [Serializable]
    public class Phone
    {
        public Phone(string phoneNumber) { 
            this.phoneNumber = phoneNumber;
            this.messages = new List<Message>();
        }

        //https://stackoverflow.com/questions/22526136/adding-a-clone-of-an-object-to-a-list-in-c-sharp-prevent-modification-from-outs
        public Phone DeepCopy()
        {
            BinaryFormatter BF = new BinaryFormatter();
            MemoryStream memStream = new MemoryStream();
            BF.Serialize(memStream, this);
            memStream.Flush();
            memStream.Position = 0;
            return (Phone)BF.Deserialize(memStream);
        }

        public void sendMessage(string content, string recipientNumber)
        {
            SMSMessage newMessage = new SMSMessage(this.phoneNumber, recipientNumber, content);
            MessageServer.sendMessage(newMessage);
        }

        public void receiveMessage(Message message)
        {
            this.messages.Add(message.DeepCopy());
            this.inboxForm.updateMessages();
            
        }

        static PhoneInbox InboxForm;
        public PhoneInbox inboxForm
        {
            get
            {
                return InboxForm;
            }
            set
            {
                InboxForm = value;
            }

        }

        static string PhoneNumber;
        public string phoneNumber
        {
            get
            {
                return PhoneNumber;
            }
            set
            {
                PhoneNumber = value;
            }

        }

        static List<Message> Messages;
        public List<Message> messages
        {
            get
            {
                return Messages;
            }
            set
            {
                Messages = value;
            }

        }
    }
}
