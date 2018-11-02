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

        public string messageHeader
        {
            get { return message_header; }
            set { message_header = value; }
        }

            public string Sender
        {
            get { return sender; }
            set { sender = value; }
        }

        public string messageText
        {
            get { return message_text; }
            set { message_text = value; }
        }
    }
}


