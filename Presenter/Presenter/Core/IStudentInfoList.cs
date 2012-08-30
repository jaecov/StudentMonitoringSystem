using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StudentMonitoringSystem.Entities;
using System.Collections;

namespace StudentMonitoringSystem.Presenter.Core
{
    public interface IStudentInfoList : IBaseView
    {
        int ID { get; }
        string Firstname { get; }
        string Lastname { get; }
        int Level_ID { get; }
        int SchoolYear_ID { get; }
        int Semester_ID { get; }
        int Course_ID { get; }
        int Section_ID { get; }

        List<vstudentinfo> StudentInfoListDataSource { set; }
        List<enroll_course> CourseDataSource { set; }
        List<enroll_level> LevelDataSource { set; }
        List<enroll_schoolyear> SchoolYearDataSource { set; }
        List<enroll_semester> SemesterDataSource { set; }
        List<enroll_section> SectionDataSource { set; }
    }
}
