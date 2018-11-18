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
        //Getter/setter with validation for the message header.
        public string messageHeader
        {
            get {
                return message_header; }

            set
            {


                string x = value.Substring(value.IndexOf("E") + 1);
                double y;

                if (value.Length != 9 || double.TryParse(x, out y) == false)
                {

                    throw new ArgumentException("Error Message header must be 9 characters or format is incorrect");

                }
                
                






                    message_header = value;
                

            }
        }
        //Getter/setter for the email subject
        public string Subject
        {
            get { return subject; }
            set {
                if(value == "")
                {
                    throw new ArgumentException("Error: please enter a subject!");
                }

                subject = value; }
        }

        //Getter/setter for the email message.
        public string messageText
        {
            get { return message_text; }
            set { message_text = value; }
        }

        //Getter/setter for the email sender.
        public string Sender
        {
            get { return sender; }
            set { sender = value; }
        }

    }
}
