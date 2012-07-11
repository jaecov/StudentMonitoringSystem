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

        private string _sync = "sync";

        public virtual IQueryable<T> GetObject<T>() where T : BaseObject
        {
            string entity = typeof(T).Name;
            if (CacheList.Contains(entity))
            {
                object data = _cachemanager.GetData(entity);
                if (data == null)
                {
                    lock (_sync)
                    {
                        if (data == null)
                        {
                            data = _context.GetObjectSet<T>().ToList().AsQueryable();
                            _cachemanager.AddData(entity, data);
                        }
                    }
                }
                return data as IQueryable<T>;
            }
            else
            {
                return _context.GetObjectSet<T>() as IQueryable<T>;
            }
        }

        public virtual T GetObjectItemByColumnID<T>(int id) where T : BaseObject
        {
            return GetObject<T>().Where(c => c.id == id).FirstOrDefault();
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
            _cachemanager.RemoveData(token);

            return _context.SaveChanges();
        }

        #endregion

        #region Caching

        private SmsCacheManager _cachemanager = new SmsCacheManager();
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
