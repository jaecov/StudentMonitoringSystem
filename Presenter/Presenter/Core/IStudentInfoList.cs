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
        List<vstudentinfo> StudentInfoListDataSource { set; }      
    }
}
