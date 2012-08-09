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
    public partial class enroll_course: BaseObject
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
    
        public  string code
        {
            get;
            set;
        }

        #endregion
        #region Navigation Properties
    
        public virtual ICollection<enroll_schedule> enroll_schedule
        {
            get
            {
                if (_enroll_schedule == null)
                {
                    var newCollection = new FixupCollection<enroll_schedule>();
                    newCollection.CollectionChanged += Fixupenroll_schedule;
                    _enroll_schedule = newCollection;
                }
                return _enroll_schedule;
            }
            set
            {
                if (!ReferenceEquals(_enroll_schedule, value))
                {
                    var previousValue = _enroll_schedule as FixupCollection<enroll_schedule>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= Fixupenroll_schedule;
                    }
                    _enroll_schedule = value;
                    var newValue = value as FixupCollection<enroll_schedule>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += Fixupenroll_schedule;
                    }
                }
            }
        }
        private ICollection<enroll_schedule> _enroll_schedule;

        #endregion
        #region Association Fixup
    
        private void Fixupenroll_schedule(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (enroll_schedule item in e.NewItems)
                {
                    item.enroll_course = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (enroll_schedule item in e.OldItems)
                {
                    if (ReferenceEquals(item.enroll_course, this))
                    {
                        item.enroll_course = null;
                    }
                }
            }
        }

        #endregion
    }
}
