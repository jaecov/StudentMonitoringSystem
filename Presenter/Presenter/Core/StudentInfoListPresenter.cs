using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StudentMonitoringSystem.Entities;

namespace StudentMonitoringSystem.Presenter.Core
{
    public class StudentInfoListPresenter : BasePresenter<IStudentInfoList>
    {
        #region Constructor

        public StudentInfoListPresenter(IStudentInfoList view)
        {
            View = view;
        }

        #endregion

        #region Load

        public void LoadItems()
        {
            LoadStudentList();
            View.LevelDataSource = Controller.GetObject<enroll_level>().ToList();
            View.SchoolYearDataSource = Controller.GetObject<enroll_schoolyear>().ToList();
            View.SemesterDataSource = Controller.GetObject<enroll_semester>().ToList();
            View.CourseDataSource = Controller.GetObject<enroll_course>().ToList();
            View.SectionDataSource = Controller.GetObject<enroll_section>().ToList();
        }

        public void LoadStudentList()
        {
            var query =  Controller.GetObject<vstudentinfo>()
                                              .Where(c => c.firstname.StartsWith(View.Firstname)
                                                       && c.lastname.StartsWith(View.Lastname));
            //if(View.Course_ID > 0)
            //    query = query

            View.StudentInfoListDataSource =query.ToList();

        }
      
        #endregion

    }
}
