using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StudentMonitoringSystem.Entities;
using System.Collections;

namespace StudentMonitoringSystem.Presenter.Enroll
{
    public interface ISchedule : IBaseView
    {
        int ID { get; set; }
        string Note { get; set; }
        int Course_ID { get; set; }
        int Section_ID { get; set; }
        int Employee_ID { get; set; }
        int Subject_ID { get; set; }
        int Room_ID { get; set; }
        int Day_ID { get; set; }
        DateTime DateStart { get; set; }
        DateTime DateEnd { get; set; }

        List<vscheduleinfo> ScheduleDataSource { set; }
        List<enroll_course> CourseDataSource { set; }
        List<enroll_section> SectionDataSource { set; }
        List<vemployeeinfo> EmployeeDataSource { set; }
        List<enroll_subject> SubjectDataSource { set; }
        List<enroll_room> RoomDataSource { set; }
        List<core_day> DayDataSource { set; }
    }
}
