using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StudentMonitoringSystem.Entities;

namespace StudentMonitoringSystem.Presenter.Core
{
    public class EmployeeInfoListPresenter : BasePresenter<IEmployeeInfoList>
    {
        #region Constructor

        public EmployeeInfoListPresenter(IEmployeeInfoList view)
        {
            View = view;
        }

        #endregion

        #region Load

        public void LoadItems()
        {
            View.EmployeeInfoListDataSource = Controller.GetObject<vemployeeinfo>().ToList();
        }

        #endregion

    }
}
