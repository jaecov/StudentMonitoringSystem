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
    public partial class sms_sent_archive: BaseObject
    {
        #region Primitive Properties
    
        public override int id
        {
            get;
            set;
        }
    
        public  System.DateTime archiveddate
        {
            get;
            set;
        }
    
        public  int sent_id
        {
            get;
            set;
        }
    
        public  string number
        {
            get;
            set;
        }
    
        public  System.DateTime datecreated
        {
            get;
            set;
        }
    
        public  Nullable<int> notification_id
        {
            get;
            set;
        }

        #endregion
    }
}
