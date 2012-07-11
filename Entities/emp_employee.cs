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
    public partial class emp_employee: BaseObject
    {
        #region Primitive Properties
    
        public override int id
        {
            get;
            set;
        }
    
        public  string number
        {
            get;
            set;
        }
    
        public  string firstname
        {
            get;
            set;
        }
    
        public  string middlename
        {
            get;
            set;
        }
    
        public  string lastname
        {
            get;
            set;
        }
    
        public  System.DateTime dateofbirth
        {
            get;
            set;
        }
    
        public  int gender_id
        {
            get;
            set;
        }
    
        public  int civilstatus_id
        {
            get;
            set;
        }
    
        public  string citizenship
        {
            get;
            set;
        }
    
        public  string street
        {
            get;
            set;
        }
    
        public  int barangay_id
        {
            get;
            set;
        }
    
        public  string picture
        {
            get;
            set;
        }
    
        public  string note
        {
            get;
            set;
        }

        #endregion
        #region Navigation Properties
    
        public virtual ICollection<emp_contact> emp_contact
        {
            get
            {
                if (_emp_contact == null)
                {
                    var newCollection = new FixupCollection<emp_contact>();
                    newCollection.CollectionChanged += Fixupemp_contact;
                    _emp_contact = newCollection;
                }
                return _emp_contact;
            }
            set
            {
                if (!ReferenceEquals(_emp_contact, value))
                {
                    var previousValue = _emp_contact as FixupCollection<emp_contact>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= Fixupemp_contact;
                    }
                    _emp_contact = value;
                    var newValue = value as FixupCollection<emp_contact>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += Fixupemp_contact;
                    }
                }
            }
        }
        private ICollection<emp_contact> _emp_contact;
    
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
    
        private void Fixupemp_contact(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (emp_contact item in e.NewItems)
                {
                    item.emp_employee = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (emp_contact item in e.OldItems)
                {
                    if (ReferenceEquals(item.emp_employee, this))
                    {
                        item.emp_employee = null;
                    }
                }
            }
        }
    
        private void Fixupenroll_schedule(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (enroll_schedule item in e.NewItems)
                {
                    item.emp_employee = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (enroll_schedule item in e.OldItems)
                {
                    if (ReferenceEquals(item.emp_employee, this))
                    {
                        item.emp_employee = null;
                    }
                }
            }
        }

        #endregion
    }
}