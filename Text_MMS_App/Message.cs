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
    public class Message
    {
        private string messageID; //Encapsulated this only field for demonstration purposes.

        public Message(string sender, string recipient, string content)
        {
            this.messageID = Guid.NewGuid().ToString("N");
            this.sender = sender;
            this.recipient = recipient;
            this.content = content;
            this.sent = false;
            this.received = false;
        }

        //https://stackoverflow.com/questions/22526136/adding-a-clone-of-an-object-to-a-list-in-c-sharp-prevent-modification-from-outs
        public Message DeepCopy()
        {
            BinaryFormatter BF = new BinaryFormatter();
            MemoryStream memStream = new MemoryStream();
            BF.Serialize(memStream, this);
            memStream.Flush();
            memStream.Position = 0;
            return (Message)BF.Deserialize(memStream);
        }

        public string getMessageID()
        {
            return messageID;
        }

        static string Content;
        public string content
        {
            get
            {
                return Content;
            }
            set
            {
                Content = value;
            }

        }

        static string Recipient;
        public string recipient
        {
            get
            {
                return Recipient;
            }
            set
            {
                Recipient = value;
            }

        }

        static string Sender;
        public string sender
        {
            get
            {
                return Sender;
            }
            set
            {
                Sender = value;
            }

        }

        static bool Sent;
        public bool sent
        {
            get
            {
                return Sent;
            }
            set
            {
                Sent = value;
            }

        }

        static bool Received;
        public bool received
        {
            get
            {
                return Received;
            }
            set
            {
                Received = value;
            }

        }
    }
}
