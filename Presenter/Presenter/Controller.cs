using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using StudentMonitoringSystem.Entities;
using System.Data.Objects;
using System.Collections;

namespace StudentMonitoringSystem.Presenter
{
    public partial class Controller : IController
    {
        #region Constructor

        public Controller()
        {
        }

        #endregion

        #region GET

        public virtual ObjectSet<T> GetObject<T>() where T : BaseObject
        {
            return _context.GetObjectSet<T>();
        }

        public virtual T GetObjectItemByColumnID<T>(int id) where T : BaseObject
        {
            var list = _context.GetObjectSet<T>().Where(c => c.id == id);

            if (list != null && list.Count() > 0)
            {
                return list.FirstOrDefault();
            }

            return null;
        }

        #endregion

        #region CRUD

        public virtual T CreateObject<T>(T data) where T : BaseObject
        {
            _context.GetObjectSet<T>().AddObject(data);
            this.Save();
            return data;
        }
        
        public virtual T UpdateObject<T>(T data) where T : BaseObject
        {
            _context.GetObjectSet<T>().ApplyCurrentValues(data);
            this.Save();
            return data;
        }

        public virtual void DeleteObject<T>(T data) where T : BaseObject
        {
            _context.DeleteObject(data);
            this.Save();
        }

        #endregion

        #region Context

        private StudentMonitoringEntities _context = new StudentMonitoringEntities();

        public StudentMonitoringEntities Context
        {
            get
            {
                return _context;
            }
        }

        public int Save()
        {
            return _context.SaveChanges();
        }

        #endregion

    }
}
