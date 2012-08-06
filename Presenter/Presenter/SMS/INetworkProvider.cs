using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StudentMonitoringSystem.Entities;
using System.Collections;

namespace StudentMonitoringSystem.Presenter.SMS
{
    public interface INetworkProvider : IBaseView
    {
        int ID { get; set; }
        string Name { get; set; }
        List<sms_networkprovider> NetworkProviderDataSource { set; }
    }
}
