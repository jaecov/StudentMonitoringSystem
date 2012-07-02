using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace StudentMonitoringSystem.Entities
{
    public abstract partial class BaseObject
    {
        public virtual int id { get; set; }
    }
}
