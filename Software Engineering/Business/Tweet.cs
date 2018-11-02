using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Tweet
    {
        private string message_header;
        private string sender;
        private string twitter_id;

        public string messsageHeader
        {
            get { return message_header; }
            set { message_header = value; }
        }

        public string Sender
        {
            get { return sender; }
            set { sender = value; }
        }

        public string twitterId
        {
            get { return twitter_id; }
            set { twitter_id = value; }
        }



    }
}
