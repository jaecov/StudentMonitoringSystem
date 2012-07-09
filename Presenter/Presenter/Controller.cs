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

        private string sync = "sync";

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
            this.Save<T>();
            return data;
        }

        public virtual T UpdateObject<T>(T data) where T : BaseObject
        {
            _context.GetObjectSet<T>().ApplyCurrentValues(data);
            this.Save<T>();
            return data;
        }

        public virtual void DeleteObject<T>(T data) where T : BaseObject
        {
            _context.DeleteObject(data);
            this.Save<T>();
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

        public int Save<T>() where T : BaseObject
        {
            string token = typeof(T).Name;
            cachemanager.RemoveData(token);

            return _context.SaveChanges();
        }

        #endregion

        #region Caching

        private SmsCacheManager cachemanager = new SmsCacheManager();
        private static List<string> _cacheList = null;

        private List<string> CacheList
        {
            get
            {
                if (_cacheList != null)
                    return _cacheList;

                _cacheList = new List<string>();

                IController controller = new Controller();
                var cachelist = controller.GetObject<core_systemsettings>().Where(c => c.key == "cache").FirstOrDefault();
                if (cachelist == null)
                    return null;

                var tokens = cachelist.value.Split(new char[] { ',' });
                if (tokens == null || tokens.Count() == 0)
                    return null;

                foreach (var item in tokens)
                {
                    if (item.Trim().Length > 0)
                        _cacheList.Add(item);
                }

                return _cacheList;
            }
        }

        #endregion
    }
}
