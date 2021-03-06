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
    public partial class sms_networkprovidercode: BaseObject
    {
        #region Primitive Properties
    
        public override int id
        {
            get;
            set;
        }
    
        public  string name
        {
            get;
            set;
        }
    
        public  int networkprovider_id
        {
            get { return _networkprovider_id; }
            set
            {
                if (_networkprovider_id != value)
                {
                    if (sms_networkprovider != null && sms_networkprovider.id != value)
                    {
                        sms_networkprovider = null;
                    }
                    _networkprovider_id = value;
                }
            }
        }
        private int _networkprovider_id;

        #endregion
        #region Navigation Properties
    
        public virtual sms_networkprovider sms_networkprovider
        {
            get { return _sms_networkprovider; }
            set
            {
                if (!ReferenceEquals(_sms_networkprovider, value))
                {
                    var previousValue = _sms_networkprovider;
                    _sms_networkprovider = value;
                    Fixupsms_networkprovider(previousValue);
                }
            }
        }
        private sms_networkprovider _sms_networkprovider;

        #endregion
        #region Association Fixup
    
        private void Fixupsms_networkprovider(sms_networkprovider previousValue)
        {
            if (previousValue != null && previousValue.sms_networkprovidercode.Contains(this))
            {
                previousValue.sms_networkprovidercode.Remove(this);
            }
    
            if (sms_networkprovider != null)
            {
                if (!sms_networkprovider.sms_networkprovidercode.Contains(this))
                {
                    sms_networkprovider.sms_networkprovidercode.Add(this);
                }
                if (networkprovider_id != sms_networkprovider.id)
                {
                    networkprovider_id = sms_networkprovider.id;
                }
            }
        }

        #endregion
    }
}
