using System;
using System.Text;
using System.Collections.Specialized;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace System.Net
{
    public sealed class HttpListenerRequest
    {
    
        public Guid RequestTraceIdentifier
        {
            get { throw new NotImplementedException(); }
        }
    
        public string[] AcceptTypes
        {
            get { throw new NotImplementedException(); }
        }
    
        public Encoding ContentEncoding
        {
            get { throw new NotImplementedException(); }
        }
    
        public long ContentLength64
        {
            get { throw new NotImplementedException(); }
        }
    
        public string ContentType
        {
            get { throw new NotImplementedException(); }
        }
    
        public NameValueCollection Headers
        {
            get { throw new NotImplementedException(); }
        }
    
        public string HttpMethod
        {
            get { throw new NotImplementedException(); }
        }
    
        public Stream InputStream
        {
            get { throw new NotImplementedException(); }
        }
    
        public bool IsAuthenticated
        {
            get { throw new NotImplementedException(); }
        }
    
        public bool IsLocal
        {
            get { throw new NotImplementedException(); }
        }
    
        public bool IsSecureConnection
        {
            get { throw new NotImplementedException(); }
        }
    
        public bool IsWebSocketRequest
        {
            get { throw new NotImplementedException(); }
        }
    
        public NameValueCollection QueryString
        {
            get { throw new NotImplementedException(); }
        }
    
        public string RawUrl
        {
            get { throw new NotImplementedException(); }
        }
    
        public string ServiceName
        {
            get { throw new NotImplementedException(); }
        }
    
        public Uri Url
        {
            get { throw new NotImplementedException(); }
        }
    
        public Uri UrlReferrer
        {
            get { throw new NotImplementedException(); }
        }
    
        public string UserAgent
        {
            get { throw new NotImplementedException(); }
        }
    
        public string UserHostAddress
        {
            get { throw new NotImplementedException(); }
        }
    
        public string UserHostName
        {
            get { throw new NotImplementedException(); }
        }
    
        public string[] UserLanguages
        {
            get { throw new NotImplementedException(); }
        }
    
        public int ClientCertificateError
        {
            get { throw new NotImplementedException(); }
        }
    
        public TransportContext TransportContext
        {
            get { throw new NotImplementedException(); }
        }
    
        public CookieCollection Cookies
        {
            get { throw new NotImplementedException(); }
        }
    
        public Version ProtocolVersion
        {
            get { throw new NotImplementedException(); }
        }
    
        public bool HasEntityBody
        {
            get { throw new NotImplementedException(); }
        }
    
        public bool KeepAlive
        {
            get { throw new NotImplementedException(); }
        }
    
        public IPEndPoint RemoteEndPoint
        {
            get { throw new NotImplementedException(); }
        }
    
        public IPEndPoint LocalEndPoint
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public X509Certificate2 GetClientCertificate()
        {
             throw new NotImplementedException();
        }
        
        
        public IAsyncResult BeginGetClientCertificate(AsyncCallback requestCallback, object state)
        {
             throw new NotImplementedException();
        }
        
        
        public X509Certificate2 EndGetClientCertificate(IAsyncResult asyncResult)
        {
             throw new NotImplementedException();
        }
        
        
        public Task<X509Certificate2> GetClientCertificateAsync()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
