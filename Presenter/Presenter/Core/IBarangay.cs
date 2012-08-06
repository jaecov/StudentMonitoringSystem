using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StudentMonitoringSystem.Entities;
using System.Collections;

namespace StudentMonitoringSystem.Presenter.Core
{
    public interface IBarangay : IBaseView
    {
        int ID { get; set; }
        string Name { get; set; }
        int City_ID { get; set; }
        List<vbarangayinfo> BarangayDataSource { set; }
        List<core_city> CityDataSource { set; }

    }
}
