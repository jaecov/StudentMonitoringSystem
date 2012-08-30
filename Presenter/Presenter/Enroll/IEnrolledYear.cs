using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StudentMonitoringSystem.Entities;
using System.Collections;

namespace StudentMonitoringSystem.Presenter.Enroll
{
    public interface IEnrolledYear : IBaseView
    {
        int ID { get; set; }
        string Note { get; set; }
        int Student_ID { get;}
        int Level_ID { get; set; }
        int SchoolYear_ID { get; set; }
        int Semester_ID { get; set; }
        int Course_ID { get; set; }
        int Section_ID { get; set; }   

        List<venrolledyearinfo> EnrolledYearDataSource { set; }
        List<enroll_course> CourseDataSource { set; }
        List<enroll_level> LevelDataSource { set; }
        List<enroll_schoolyear> SchoolYearDataSource { set; }
        List<enroll_semester> SemesterDataSource { set; }
        List<enroll_section> SectionDataSource { set; }
        
    }
}
