using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class trending
    {
        private string number;
        private int hashtag;

        //Getter/setter for sortCode
        public string Number
        {
            get { return number; }
            set { number = value; }
        }

        //Getter/setter for incident name
        public int Hashtag
        {
            get { return hashtag; }
            set { hashtag = value; }
        }
    }

}

