using System;

namespace System.Net
{
    [Serializable]
    public class CookieContainer
    {
        public const int DefaultCookieLimit = 300;
        public const int DefaultPerDomainCookieLimit = 20;
        public const int DefaultCookieLengthLimit = 4096;
    
        public int Capacity
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public int Count
        {
            get { throw new NotImplementedException(); }
        }
    
        public int MaxCookieSize
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public int PerDomainCapacity
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public CookieContainer()
        {
             throw new NotImplementedException();
        }
        
        
        public CookieContainer(int capacity)
        {
             throw new NotImplementedException();
        }
        
        
        public CookieContainer(int capacity, int perDomainCapacity, int maxCookieSize)
        {
             throw new NotImplementedException();
        }
        
        
        public void Add(Cookie cookie)
        {
             throw new NotImplementedException();
        }
        
        
        public void Add(CookieCollection cookies)
        {
             throw new NotImplementedException();
        }
        
        
        public void Add(Uri uri, Cookie cookie)
        {
             throw new NotImplementedException();
        }
        
        
        public void Add(Uri uri, CookieCollection cookies)
        {
             throw new NotImplementedException();
        }
        
        
        public CookieCollection GetCookies(Uri uri)
        {
             throw new NotImplementedException();
        }
        
        
        public string GetCookieHeader(Uri uri)
        {
             throw new NotImplementedException();
        }
        
        
        public void SetCookies(Uri uri, string cookieHeader)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
