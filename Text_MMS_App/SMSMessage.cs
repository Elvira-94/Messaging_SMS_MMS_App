using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Text_MMS_App
{
    [Serializable]
    public class SMSMessage : Message
    {
        
        public SMSMessage(string sender, string recipient, string content)
            : base(sender, recipient, content)
        {
            
        }

    }


}
