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
    public partial class enroll_schedule: BaseObject
    {
        #region Primitive Properties
    
        public override int id
        {
            get;
            set;
        }
    
        public  int course_id
        {
            get { return _course_id; }
            set
            {
                if (_course_id != value)
                {
                    if (enroll_course != null && enroll_course.id != value)
                    {
                        enroll_course = null;
                    }
                    _course_id = value;
                }
            }
        }
        private int _course_id;
    
        public  int section_id
        {
            get { return _section_id; }
            set
            {
                if (_section_id != value)
                {
                    if (enroll_section != null && enroll_section.id != value)
                    {
                        enroll_section = null;
                    }
                    _section_id = value;
                }
            }
        }
        private int _section_id;
    
        public  int employee_id
        {
            get { return _employee_id; }
            set
            {
                if (_employee_id != value)
                {
                    if (emp_employee != null && emp_employee.id != value)
                    {
                        emp_employee = null;
                    }
                    _employee_id = value;
                }
            }
        }
        private int _employee_id;
    
        public  int subject_id
        {
            get { return _subject_id; }
            set
            {
                if (_subject_id != value)
                {
                    if (enroll_subject != null && enroll_subject.id != value)
                    {
                        enroll_subject = null;
                    }
                    _subject_id = value;
                }
            }
        }
        private int _subject_id;
    
        public  int room_id
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
    
        public  System.DateTime datestart
        {
            get;
            set;
        }
    
        public  System.DateTime dateend
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
    
        public virtual enroll_section enroll_section
        {
            get { return _enroll_section; }
            set
            {
                if (!ReferenceEquals(_enroll_section, value))
                {
                    var previousValue = _enroll_section;
                    _enroll_section = value;
                    Fixupenroll_section(previousValue);
                }
            }
        }
        private enroll_section _enroll_section;
    
        public virtual enroll_subject enroll_subject
        {
            get { return _enroll_subject; }
            set
            {
                if (!ReferenceEquals(_enroll_subject, value))
                {
                    var previousValue = _enroll_subject;
                    _enroll_subject = value;
                    Fixupenroll_subject(previousValue);
                }
            }
        }
        private enroll_subject _enroll_subject;
    
        public virtual emp_employee emp_employee
        {
            get { return _emp_employee; }
            set
            {
                if (!ReferenceEquals(_emp_employee, value))
                {
                    var previousValue = _emp_employee;
                    _emp_employee = value;
                    Fixupemp_employee(previousValue);
                }
            }
        }
        private emp_employee _emp_employee;
    
        public virtual enroll_course enroll_course
        {
            get { return _enroll_course; }
            set
            {
                if (!ReferenceEquals(_enroll_course, value))
                {
                    var previousValue = _enroll_course;
                    _enroll_course = value;
                    Fixupenroll_course(previousValue);
                }
            }
        }
        private enroll_course _enroll_course;

        #endregion
        #region Association Fixup
    
        private void Fixupenroll_room(enroll_room previousValue)
        {
            if (previousValue != null && previousValue.enroll_schedule.Contains(this))
            {
                previousValue.enroll_schedule.Remove(this);
            }
    
            if (enroll_room != null)
            {
                if (!enroll_room.enroll_schedule.Contains(this))
                {
                    enroll_room.enroll_schedule.Add(this);
                }
                if (room_id != enroll_room.id)
                {
                    room_id = enroll_room.id;
                }
            }
        }
    
        private void Fixupenroll_section(enroll_section previousValue)
        {
            if (previousValue != null && previousValue.enroll_schedule.Contains(this))
            {
                previousValue.enroll_schedule.Remove(this);
            }
    
            if (enroll_section != null)
            {
                if (!enroll_section.enroll_schedule.Contains(this))
                {
                    enroll_section.enroll_schedule.Add(this);
                }
                if (section_id != enroll_section.id)
                {
                    section_id = enroll_section.id;
                }
            }
        }
    
        private void Fixupenroll_subject(enroll_subject previousValue)
        {
            if (previousValue != null && previousValue.enroll_schedule.Contains(this))
            {
                previousValue.enroll_schedule.Remove(this);
            }
    
            if (enroll_subject != null)
            {
                if (!enroll_subject.enroll_schedule.Contains(this))
                {
                    enroll_subject.enroll_schedule.Add(this);
                }
                if (subject_id != enroll_subject.id)
                {
                    subject_id = enroll_subject.id;
                }
            }
        }
    
        private void Fixupemp_employee(emp_employee previousValue)
        {
            if (previousValue != null && previousValue.enroll_schedule.Contains(this))
            {
                previousValue.enroll_schedule.Remove(this);
            }
    
            if (emp_employee != null)
            {
                if (!emp_employee.enroll_schedule.Contains(this))
                {
                    emp_employee.enroll_schedule.Add(this);
                }
                if (employee_id != emp_employee.id)
                {
                    employee_id = emp_employee.id;
                }
            }
        }
    
        private void Fixupenroll_course(enroll_course previousValue)
        {
            if (previousValue != null && previousValue.enroll_schedule.Contains(this))
            {
                previousValue.enroll_schedule.Remove(this);
            }
    
            if (enroll_course != null)
            {
                if (!enroll_course.enroll_schedule.Contains(this))
                {
                    enroll_course.enroll_schedule.Add(this);
                }
                if (course_id != enroll_course.id)
                {
                    course_id = enroll_course.id;
                }
            }
        }

        #endregion
    }
}
