using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StudentMonitoringSystem.Entities;

namespace StudentMonitoringSystem.Presenter.Core
{
    public class ContactPresenter : BasePresenter<IContact>
    {
         #region Constructor

        public ContactPresenter(IContact view)
        {
            View = view;
        }

        #endregion

        #region Load

        public void LoadItems()
        {
            View.ContactDataSource = Controller.GetObject<core_contact>().ToList();
        }

        #endregion
    }
}
