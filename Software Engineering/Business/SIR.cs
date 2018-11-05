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

        public string sortCode
        {
            get { return sort_code; }
            set { sort_code = value; }
        }

        public string incidentName
        {
            get { return incident_name; }
            set { incident_name = value; }
        }
    }
}
