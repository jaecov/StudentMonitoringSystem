using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StudentMonitoringSystem.Entities;
using System.Collections;

namespace StudentMonitoringSystem.Presenter.Core
{
    public interface ICivilStatus : IBaseView
    {
        int ID { get; set; }
        string Name { get; set; }
        List<core_civilstatus> CivilStatusDataSource { set; }
    }
}
