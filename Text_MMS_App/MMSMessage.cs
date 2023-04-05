using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_MMS_App
{
    [Serializable]
    public class MMSMessage : Message
    {
        //Constructor sends common args to base class constructor (last line)
        public MMSMessage(string sender, string recipient, string content, bool isGroupMessage, bool sent, bool received, 
            bool hasPicture, bool hasAudio, bool hasVideo, string fileName)
            : base(sender, recipient, content)
        {
            this.hasPicture = hasPicture;
            this.hasAudio = hasAudio;
            this.hasVideo = hasVideo;
            this.fileName = fileName;
            
        }

        static bool HasPicture;
        public bool hasPicture
        {
            get
            {
                return HasPicture;
            }
            set
            {
                HasPicture = value;
            }

        }

        static bool HasAudio;
        public bool hasAudio
        {
            get
            {
                return HasAudio;
            }
            set
            {
                HasAudio = value;
            }

        }

        static bool HasVideo;
        public bool hasVideo
        {
            get
            {
                return HasVideo;
            }
            set
            {
                HasVideo = value;
            }

        }

        static string FileName;
        public string fileName
        {
            get
            {
                return FileName;
            }
            set
            {
                FileName = value;
            }


        }
    }
}
