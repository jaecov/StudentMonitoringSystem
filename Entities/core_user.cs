//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Runtime.Serialization;

namespace StudentMonitoringSystem.Entities
{
    [Serializable]
    public partial class core_user: BaseObject
    {
        #region Primitive Properties
    
        public override int id
        {
            get;
            set;
        }
    
        public  string username
        {
            get;
            set;
        }
    
        public  string password
        {
            get;
            set;
        }
    
        public  string name
        {
            get;
            set;
        }
    
        public  bool isdeleted
        {
            get;
            set;
        }

        #endregion
    }
}
