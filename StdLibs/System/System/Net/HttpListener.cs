using System;
using System.Security.Authentication.ExtendedProtection;
using System.Runtime.InteropServices;
using System.Collections;
using System.Threading.Tasks;

namespace System.Net
{
    public sealed class HttpListener : IDisposable
    {
        public delegate ExtendedProtectionPolicy ExtendedProtectionSelector(HttpListenerRequest request);
    
    
        public AuthenticationSchemeSelector AuthenticationSchemeSelectorDelegate
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public ExtendedProtectionSelector ExtendedProtectionSelectorDelegate
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public AuthenticationSchemes AuthenticationSchemes
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public ExtendedProtectionPolicy ExtendedProtectionPolicy
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public ServiceNameCollection DefaultServiceNames
        {
            get { throw new NotImplementedException(); }
        }
    
        public string Realm
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public HttpListenerTimeoutManager TimeoutManager
        {
            get { throw new NotImplementedException(); }
        }
    
        public static bool IsSupported
        {
            get { throw new NotImplementedException(); }
        }
    
        public bool IsListening
        {
            get { throw new NotImplementedException(); }
        }
    
        public bool IgnoreWriteExceptions
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public bool UnsafeConnectionNtlmAuthentication
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public HttpListenerPrefixCollection Prefixes
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public HttpListener()
        {
             throw new NotImplementedException();
        }
        
        
        public void Start()
        {
             throw new NotImplementedException();
        }
        
        
        public void Stop()
        {
             throw new NotImplementedException();
        }
        
        
        public void Abort()
        {
             throw new NotImplementedException();
        }
        
        
        public void Close()
        {
             throw new NotImplementedException();
        }
        
        
        public HttpListenerContext GetContext()
        {
             throw new NotImplementedException();
        }
        
        
        public IAsyncResult BeginGetContext(AsyncCallback callback, object state)
        {
             throw new NotImplementedException();
        }
        
        
        public HttpListenerContext EndGetContext(IAsyncResult asyncResult)
        {
             throw new NotImplementedException();
        }
        
        
        public Task<HttpListenerContext> GetContextAsync()
        {
             throw new NotImplementedException();
        }



        void IDisposable.Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
