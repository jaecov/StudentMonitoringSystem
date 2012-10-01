using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StudentMonitoringSystem.Entities;
using System.Collections;
using System.Data.Objects;

namespace StudentMonitoringSystem.Presenter
{
    public partial interface IController
    {
        IQueryable<T> GetObject<T>(bool useSameContext = false) where T : BaseObject;
        T GetObjectItemByColumnID<T>(int id, bool useSameContext = false) where T : BaseObject;
        T CreateObject<T>(T data) where T : BaseObject;
        T UpdateObject<T>(T data) where T : BaseObject;
        void DeleteObject<T>(T data) where T : BaseObject;

        //void UpdateObject<T>(T data) where T : DC.BaseObject;

        //void DeleteObject<T>(T data) where T : DC.BaseObject;

        //List<T> GetDTOObject<T>(string serviceToken) where T : DC.BaseObject;


    }
}
