using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Caching;
using System.Collections;

namespace StudentMonitoringSystem.Presenter
{
    public class SmsCacheManager
    {
        private  ObjectCache cache = MemoryCache.Default;
        private static CacheItemPolicy policy = null;

        public CacheItemPolicy ExpirationPolicy
        {
            get
            {
                if (policy == null)
                {
                    policy = new CacheItemPolicy();
                    policy.SlidingExpiration = new TimeSpan(1, 0, 0); // 1hr,0min,0sec                    
                }
                return policy;
            }
        }

        #region Cache Methods
        
        public virtual void AddData(string key, object data)
        {
            cache.Add(key, data, ExpirationPolicy);
        }

        public virtual object GetData(string key)
        {
            return cache.Get(key);
        }

        public virtual void RemoveData(string key)
        {
            cache.Remove(key);
        }
        
        #endregion

    }
}
