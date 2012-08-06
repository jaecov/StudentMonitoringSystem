using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentMonitoringSystem.Entities
{    
    public partial class vemployeeinfo: BaseObject
    {
        public string fullname
        {
            get { return string.Format("{0}, {1} {2}", lastname, firstname, middlename); }
        }

        public string address
        {
            get { return string.Format("{0}, {1} {2}", street, barangay, city, province); }
        }
    }
}
