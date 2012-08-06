using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StudentMonitoringSystem.Entities;
using System.Collections;

namespace StudentMonitoringSystem.Presenter.SMS
{
    public interface INetworkProviderCode : IBaseView
    {
        int ID { get; set; }
        string Name { get; set; }
        int NetworkProvider_ID { get; set; }
        List<vnetworkprovidercodeinfo> NetworkProviderCodeDataSource { set; }
        List<sms_networkprovider> NetworkProviderDataSource { set; }

    }
}
