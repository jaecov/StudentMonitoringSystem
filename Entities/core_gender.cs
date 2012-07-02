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
    public partial class core_gender: BaseObject
    {
        #region Primitive Properties
    
        public virtual int id
        {
            get;
            set;
        }
    
        public virtual string name
        {
            get;
            set;
        }

        #endregion
        #region Navigation Properties
    
        public virtual ICollection<core_student> core_student
        {
            get
            {
                if (_core_student == null)
                {
                    var newCollection = new FixupCollection<core_student>();
                    newCollection.CollectionChanged += Fixupcore_student;
                    _core_student = newCollection;
                }
                return _core_student;
            }
            set
            {
                if (!ReferenceEquals(_core_student, value))
                {
                    var previousValue = _core_student as FixupCollection<core_student>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= Fixupcore_student;
                    }
                    _core_student = value;
                    var newValue = value as FixupCollection<core_student>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += Fixupcore_student;
                    }
                }
            }
        }
        private ICollection<core_student> _core_student;

        #endregion
        #region Association Fixup
    
        private void Fixupcore_student(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (core_student item in e.NewItems)
                {
                    item.core_gender = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (core_student item in e.OldItems)
                {
                    if (ReferenceEquals(item.core_gender, this))
                    {
                        item.core_gender = null;
                    }
                }
            }
        }

        #endregion
    }
}
