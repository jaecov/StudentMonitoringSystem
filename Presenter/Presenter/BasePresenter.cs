using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using StudentMonitoringSystem.Entities;

namespace StudentMonitoringSystem.Presenter
{
    public class BasePresenter<TView> where TView: IBaseView
    {
        protected BasePresenter() { Controller = new Controller(); }        
        protected IController Controller { get; set; }
        public TView View { get; set; }       
    }
}
