using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class SIR
    {
        private string sort_code;
        private string incident_name;

        //Getter/setter for sortCode
        public string sortCode
        {
            get { return sort_code; }
            set { sort_code = value; }
        }

        //Getter/setter for incident name
        public string incidentName
        {
            get { return incident_name; }
            set { incident_name = value; }
        }
    }
}
