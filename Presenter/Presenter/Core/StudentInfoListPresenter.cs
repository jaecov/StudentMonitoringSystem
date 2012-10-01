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
            View.StudentInfoListDataSource = Controller.GetObject<vstudentinfo>().ToList();
        }

        #endregion

    }
}
