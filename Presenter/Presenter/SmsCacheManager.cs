using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Caching;
using System.Collections;
using StudentMonitoringSystem.Entities;

namespace StudentMonitoringSystem.Presenter
{
    public class SmsCacheManager
    {
        private  ObjectCache _cache = MemoryCache.Default;
        private static CacheItemPolicy _policy = null;
        
        public CacheItemPolicy ExpirationPolicy
        {
            get
            {
                if (_policy == null)
                {
                    _policy = new CacheItemPolicy();
                    _policy.SlidingExpiration = new TimeSpan(1, 0, 0); // 1hr,0min,0sec                    
                }
                return _policy;
            }
        }

        #region Cache Methods
        
        public virtual void AddData(string key, object data)
        {
            if (!_cache.Contains(key))
            {
                _cache.Add(key, data, ExpirationPolicy);
            }
        }

        public virtual object GetData(string key)
        {
            if (_cache.Contains(key))
            {
                return _cache.Get(key);
            }
            else
            {
                return null;
            }            
        }

        public virtual void RemoveData(string key)
        {
            if (_cache.Contains(key))
            {
                _cache.Remove(key);
            }
        }
        
        #endregion
        
    }
}
