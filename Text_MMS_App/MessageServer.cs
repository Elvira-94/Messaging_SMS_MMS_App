using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_MMS_App
{
    public class MessageServer
    {

        public static List<Phone> phones = new List<Phone>();

        public static void addPhone(Phone phone)
        {
            phones.Add(phone);
        }

        public static void sendMessage(Message message)
        {
            Phone recipientPhone = getPhoneByNumber(message.recipient);
            recipientPhone.receiveMessage(message);
            message.sent = true;
        }

        public static Phone getPhoneByNumber(string phoneNumber)
        {
            foreach (Phone phone in phones)
            {
                if(phone.phoneNumber == phoneNumber)
                {
                    return phone;
                }
            }

            throw new Exception("Phone not found");
            
        }
    }
}
