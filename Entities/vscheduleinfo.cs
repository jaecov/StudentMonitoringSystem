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
    public partial class vscheduleinfo: BaseObject
    {
        #region Primitive Properties
    
        public override int id
        {
            get;
            set;
        }
    
        public  int section_id
        {
            get;
            set;
        }
    
        public  int employee_id
        {
            get;
            set;
        }
    
        public  int subject_id
        {
            get;
            set;
        }
    
        public  int room_id
        {
            get;
            set;
        }
    
        public  int day_id
        {
            get;
            set;
        }
    
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
    
        public  string note
        {
            get;
            set;
        }
    
        public  string section_name
        {
            get;
            set;
        }
    
        public  string emp_number
        {
            get;
            set;
        }
    
        public  string emp_firstname
        {
            get;
            set;
        }
    
        public  string emp_middlename
        {
            get;
            set;
        }
    
        public  string emp_lastname
        {
            get;
            set;
        }
    
        public  string emp_picture
        {
            get;
            set;
        }
    
        public  string subject_code
        {
            get;
            set;
        }
    
        public  string subject_name
        {
            get;
            set;
        }
    
        public  string room_name
        {
            get;
            set;
        }
    
        public  string day_code
        {
            get;
            set;
        }
    
        public  string day_name
        {
            get;
            set;
        }
    
        public  int course_id
        {
            get;
            set;
        }
    
        public  string course_name
        {
            get;
            set;
        }
    
        public  string course_code
        {
            get;
            set;
        }
    
        public  int level_id
        {
            get;
            set;
        }
    
        public  string level_name
        {
            get;
            set;
        }

        #endregion
    }
}
