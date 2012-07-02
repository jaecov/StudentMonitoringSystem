using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StudentMonitoringSystem.Entities;
using System.Collections;

namespace StudentMonitoringSystem.Presenter.Core
{
    public interface IStudent : IBaseView
    {
        int ID { get; set; }
        string Number { get; set; }
        string Firstname { get; set; }
        string Middlename { get; set; }
        string Lastname { get; set; }
        DateTime DateOfBirth { get; set; }
        int Gender_id { get; set; }
        int CivilStatus_id { get; set; }
        string Citizenship { get; set; }
        IList CivilStatusDataSource { set; }
        IList GenderDataSource { set; }
        List<vstudentinfo> StudentDataSource { set; }
    }
}
