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
    
        public virtual ICollection<enroll_enrolledyear> enroll_enrolledyear
        {
            get
            {
                if (_enroll_enrolledyear == null)
                {
                    var newCollection = new FixupCollection<enroll_enrolledyear>();
                    newCollection.CollectionChanged += Fixupenroll_enrolledyear;
                    _enroll_enrolledyear = newCollection;
                }
                return _enroll_enrolledyear;
            }
            set
            {
                if (!ReferenceEquals(_enroll_enrolledyear, value))
                {
                    var previousValue = _enroll_enrolledyear as FixupCollection<enroll_enrolledyear>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= Fixupenroll_enrolledyear;
                    }
                    _enroll_enrolledyear = value;
                    var newValue = value as FixupCollection<enroll_enrolledyear>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += Fixupenroll_enrolledyear;
                    }
                }
            }
        }
        private ICollection<enroll_enrolledyear> _enroll_enrolledyear;
    
        public virtual ICollection<enroll_section> enroll_section
        {
            get
            {
                if (_enroll_section == null)
                {
                    var newCollection = new FixupCollection<enroll_section>();
                    newCollection.CollectionChanged += Fixupenroll_section;
                    _enroll_section = newCollection;
                }
                return _enroll_section;
            }
            set
            {
                if (!ReferenceEquals(_enroll_section, value))
                {
                    var previousValue = _enroll_section as FixupCollection<enroll_section>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= Fixupenroll_section;
                    }
                    _enroll_section = value;
                    var newValue = value as FixupCollection<enroll_section>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += Fixupenroll_section;
                    }
                }
            }
        }
        private ICollection<enroll_section> _enroll_section;

        #endregion
        #region Association Fixup
    
        private void Fixupenroll_enrolledyear(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (enroll_enrolledyear item in e.NewItems)
                {
                    item.enroll_course = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (enroll_enrolledyear item in e.OldItems)
                {
                    if (ReferenceEquals(item.enroll_course, this))
                    {
                        item.enroll_course = null;
                    }
                }
            }
        }
    
        private void Fixupenroll_section(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (enroll_section item in e.NewItems)
                {
                    item.enroll_course = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (enroll_section item in e.OldItems)
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
