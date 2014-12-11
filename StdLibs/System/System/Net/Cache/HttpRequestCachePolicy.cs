using System;

namespace System.Net.Cache
{
    public class HttpRequestCachePolicy : RequestCachePolicy
    {

        public new HttpRequestCacheLevel Level
        {
            get { throw new NotImplementedException(); }
        }
    
        public DateTime CacheSyncDate
        {
            get { throw new NotImplementedException(); }
        }
    
        public TimeSpan MaxAge
        {
            get { throw new NotImplementedException(); }
        }
    
        public TimeSpan MinFresh
        {
            get { throw new NotImplementedException(); }
        }
    
        public TimeSpan MaxStale
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public HttpRequestCachePolicy()
        {
             throw new NotImplementedException();
        }
        
        
        public HttpRequestCachePolicy(HttpRequestCacheLevel level)
        {
             throw new NotImplementedException();
        }
        
        
        public HttpRequestCachePolicy(HttpCacheAgeControl cacheAgeControl, TimeSpan ageOrFreshOrStale)
        {
             throw new NotImplementedException();
        }
        
        
        public HttpRequestCachePolicy(HttpCacheAgeControl cacheAgeControl, TimeSpan maxAge, TimeSpan freshOrStale)
        {
             throw new NotImplementedException();
        }
        
        
        public HttpRequestCachePolicy(DateTime cacheSyncDate)
        {
             throw new NotImplementedException();
        }
        
        
        public HttpRequestCachePolicy(HttpCacheAgeControl cacheAgeControl, TimeSpan maxAge, TimeSpan freshOrStale, DateTime cacheSyncDate)
        {
             throw new NotImplementedException();
        }
        
        
        public override string ToString()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
