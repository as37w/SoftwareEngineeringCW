using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Email
    {
        private string message_header;
        private string subject;
        private string message_text;
        private string sender;
        
        public string messageHeader
        {
            get { return message_header; }
            set { message_header = value; }
        }

        public string Subject
        {
            get { return subject; }
            set { subject = value; }
        }

        public string messageText
        {
            get { return message_text; }
            set { message_text = value; }
        }

        public string Sender
        {
            get { return sender; }
            set { sender = value; }
        }

    }
}
