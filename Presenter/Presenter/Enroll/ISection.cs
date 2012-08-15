using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StudentMonitoringSystem.Entities;
using System.Collections;

namespace StudentMonitoringSystem.Presenter.Enroll
{
    public interface ISection : IBaseView
    {
        int ID { get; set; }
        string Name { get; set; }
        string Note { get; set; }
        int Course_ID { get; set; }
        int Level_ID { get; set; }
        List<vsectioninfo> SectionDataSource { set; }
        List<enroll_course> CourseDataSource { set; }
        List<enroll_level> LevelDataSource { set; }
    }
}
