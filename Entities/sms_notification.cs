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
    public partial class sms_notification: BaseObject
    {
        #region Primitive Properties
    
        public virtual int id
        {
            get;
            set;
        }
    
        public virtual string number
        {
            get;
            set;
        }
    
        public virtual string message
        {
            get;
            set;
        }
    
        public virtual string remarks
        {
            get;
            set;
        }
    
        public virtual int room_id
        {
            get { return _room_id; }
            set
            {
                if (_room_id != value)
                {
                    if (enroll_room != null && enroll_room.id != value)
                    {
                        enroll_room = null;
                    }
                    _room_id = value;
                }
            }
        }
        private int _room_id;
    
        public virtual System.DateTime datecreated
        {
            get;
            set;
        }

        #endregion
        #region Navigation Properties
    
        public virtual enroll_room enroll_room
        {
            get { return _enroll_room; }
            set
            {
                if (!ReferenceEquals(_enroll_room, value))
                {
                    var previousValue = _enroll_room;
                    _enroll_room = value;
                    Fixupenroll_room(previousValue);
                }
            }
        }
        private enroll_room _enroll_room;

        #endregion
        #region Association Fixup
    
        private void Fixupenroll_room(enroll_room previousValue)
        {
            if (previousValue != null && previousValue.sms_notification.Contains(this))
            {
                previousValue.sms_notification.Remove(this);
            }
    
            if (enroll_room != null)
            {
                if (!enroll_room.sms_notification.Contains(this))
                {
                    enroll_room.sms_notification.Add(this);
                }
                if (room_id != enroll_room.id)
                {
                    room_id = enroll_room.id;
                }
            }
        }

        #endregion
    }
}
