using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class SMS
    {
        private string message_header;
        private string sender;
        private string message_text;

        //Getter/setter for the SMS message header
        public string messageHeader
        {
            get { return message_header; }
            set { message_header = value; }
        }

        //Getter/setter for the Sender
            public string Sender
        {
            get { return sender; }
            set { sender = value; }
        }

        //Getter/setter for the SMS message.
        public string messageText
        {
            get { return message_text; }
            set { message_text = value; }
        }
    }
}


