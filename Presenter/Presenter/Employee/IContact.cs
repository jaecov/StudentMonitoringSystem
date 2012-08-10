using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StudentMonitoringSystem.Entities;
using System.Collections;

namespace StudentMonitoringSystem.Presenter.Employee
{
    public interface IContact : IBaseView
    {
        int ID { get; set; }
        string Number { get; set; }
        string Emailaddress { get; set; }
        string Note { get; set; }
        int Employee_ID { get; }
        List<emp_contact> ContactDataSource { set; }
    }
}
