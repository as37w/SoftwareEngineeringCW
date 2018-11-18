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
        private string twitter_id;
        private string message_text;

        //Getter/setter for the tweet message header.
        public string messageHeader
        {
            get { return message_header; }
            set { message_header = value; }
        }

      //Getter/setter for the Twitter id
        public string twitterId
        {
            get { return twitter_id; }
            set { twitter_id = value; }
        }

        //Getter/setter for the tweet message text
        public string messageText
        {
            get { return message_text; }
            set { message_text = value; }
        }


    }
}
