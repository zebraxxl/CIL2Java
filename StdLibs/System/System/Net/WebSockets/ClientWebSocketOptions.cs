using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;
using System;

namespace System.Net.WebSockets
{
    public sealed class ClientWebSocketOptions
    {
    
        public bool UseDefaultCredentials
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public ICredentials Credentials
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public IWebProxy Proxy
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public X509CertificateCollection ClientCertificates
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public CookieContainer Cookies
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public TimeSpan KeepAliveInterval
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public void SetRequestHeader(string headerName, string headerValue)
        {
             throw new NotImplementedException();
        }
        
        
        public void SetBuffer(int receiveBufferSize, int sendBufferSize)
        {
             throw new NotImplementedException();
        }
        
        
        public void SetBuffer(int receiveBufferSize, int sendBufferSize, ArraySegment<byte> buffer)
        {
             throw new NotImplementedException();
        }
        
        
        public void AddSubProtocol(string subProtocol)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
