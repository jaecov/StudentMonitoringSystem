using System;
using System.Collections.Generic;
using System.Collections;

namespace StudentMonitoringSystem.Presenter
{
    public interface IBaseView
    {
        void Notify(Common.Result result, List<string> messages);
    }
}
