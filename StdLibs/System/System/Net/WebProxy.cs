using System.Runtime.Serialization;
using System;
using System.Collections;

namespace System.Net
{
    [Serializable]
    public class WebProxy : ISerializable
    {
    
        public Uri Address
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public bool BypassProxyOnLocal
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public string[] BypassList
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public ICredentials Credentials
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public bool UseDefaultCredentials
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public ArrayList BypassArrayList
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public WebProxy()
        {
             throw new NotImplementedException();
        }
        
        
        public WebProxy(Uri Address)
        {
             throw new NotImplementedException();
        }
        
        
        public WebProxy(Uri Address, bool BypassOnLocal)
        {
             throw new NotImplementedException();
        }
        
        
        public WebProxy(Uri Address, bool BypassOnLocal, string[] BypassList)
        {
             throw new NotImplementedException();
        }
        
        
        public WebProxy(Uri Address, bool BypassOnLocal, string[] BypassList, ICredentials Credentials)
        {
             throw new NotImplementedException();
        }
        
        
        public WebProxy(string Host, int Port)
        {
             throw new NotImplementedException();
        }
        
        
        public WebProxy(string Address)
        {
             throw new NotImplementedException();
        }
        
        
        public WebProxy(string Address, bool BypassOnLocal)
        {
             throw new NotImplementedException();
        }
        
        
        public WebProxy(string Address, bool BypassOnLocal, string[] BypassList)
        {
             throw new NotImplementedException();
        }
        
        
        public WebProxy(string Address, bool BypassOnLocal, string[] BypassList, ICredentials Credentials)
        {
             throw new NotImplementedException();
        }
        
        
        public Uri GetProxy(Uri destination)
        {
             throw new NotImplementedException();
        }
        
        
        public bool IsBypassed(Uri host)
        {
             throw new NotImplementedException();
        }
        
        
        [ObsoleteAttribute("This method has been deprecated. Please use the proxy selected for you by default. http://go.microsoft.com/fwlink/?linkid=14202")]
        public static WebProxy GetDefaultProxy()
        {
             throw new NotImplementedException();
        }
        
        
        protected WebProxy(SerializationInfo serializationInfo, StreamingContext streamingContext)
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
        {
             throw new NotImplementedException();
        }

        void ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
        {
            throw new NotImplementedException();
        }
    }
}
