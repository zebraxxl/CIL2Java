using System;
using System.Runtime.Serialization;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Collections;
using System.Net.Cache;
using System.Net.Security;
using System.Security.Principal;
using System.IO;
using System.Threading.Tasks;

namespace System.Net
{
    [Serializable]
    public abstract class WebRequest : MarshalByRefObject, ISerializable
    {
    
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [ObsoleteAttribute("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
        public virtual IWebRequestCreate CreatorInstance
        {
            get { throw new NotImplementedException(); }
        }
    
        public static RequestCachePolicy DefaultCachePolicy
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public virtual RequestCachePolicy CachePolicy
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public virtual string Method
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public virtual Uri RequestUri
        {
            get { throw new NotImplementedException(); }
        }
    
        public virtual string ConnectionGroupName
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public virtual WebHeaderCollection Headers
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public virtual long ContentLength
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public virtual string ContentType
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public virtual ICredentials Credentials
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public virtual bool UseDefaultCredentials
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public virtual IWebProxy Proxy
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public virtual bool PreAuthenticate
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public virtual int Timeout
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public AuthenticationLevel AuthenticationLevel
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public TokenImpersonationLevel ImpersonationLevel
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public static IWebProxy DefaultWebProxy
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [ObsoleteAttribute("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
        public static void RegisterPortableWebRequestCreator(IWebRequestCreate creator)
        {
             throw new NotImplementedException();
        }
        
        
        public static WebRequest Create(string requestUriString)
        {
             throw new NotImplementedException();
        }
        
        
        public static WebRequest Create(Uri requestUri)
        {
             throw new NotImplementedException();
        }
        
        
        public static WebRequest CreateDefault(Uri requestUri)
        {
             throw new NotImplementedException();
        }
        
        
        public static HttpWebRequest CreateHttp(string requestUriString)
        {
             throw new NotImplementedException();
        }
        
        
        public static HttpWebRequest CreateHttp(Uri requestUri)
        {
             throw new NotImplementedException();
        }
        
        
        public static bool RegisterPrefix(string prefix, IWebRequestCreate creator)
        {
             throw new NotImplementedException();
        }
        
        
        protected WebRequest()
        {
             throw new NotImplementedException();
        }
        
        
        protected WebRequest(SerializationInfo serializationInfo, StreamingContext streamingContext)
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual Stream GetRequestStream()
        {
             throw new NotImplementedException();
        }
        
        
        public virtual WebResponse GetResponse()
        {
             throw new NotImplementedException();
        }
        
        
        public virtual IAsyncResult BeginGetResponse(AsyncCallback callback, object state)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual WebResponse EndGetResponse(IAsyncResult asyncResult)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual IAsyncResult BeginGetRequestStream(AsyncCallback callback, object state)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual Stream EndGetRequestStream(IAsyncResult asyncResult)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual Task<Stream> GetRequestStreamAsync()
        {
             throw new NotImplementedException();
        }
        
        
        public virtual Task<WebResponse> GetResponseAsync()
        {
             throw new NotImplementedException();
        }
        
        
        public virtual void Abort()
        {
             throw new NotImplementedException();
        }
        
        
        public static IWebProxy GetSystemWebProxy()
        {
             throw new NotImplementedException();
        }

        void ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
        {
            throw new NotImplementedException();
        }
    }
}
