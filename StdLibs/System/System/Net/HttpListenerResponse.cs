using System;
using System.Text;
using System.IO;

namespace System.Net
{
    public sealed class HttpListenerResponse : IDisposable
    {
    
        public Encoding ContentEncoding
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public string ContentType
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public Stream OutputStream
        {
            get { throw new NotImplementedException(); }
        }
    
        public string RedirectLocation
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public int StatusCode
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public string StatusDescription
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public CookieCollection Cookies
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public bool SendChunked
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public bool KeepAlive
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public WebHeaderCollection Headers
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public long ContentLength64
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public Version ProtocolVersion
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public void CopyFrom(HttpListenerResponse templateResponse)
        {
             throw new NotImplementedException();
        }
        
        
        public void AddHeader(string name, string value)
        {
             throw new NotImplementedException();
        }
        
        
        public void AppendHeader(string name, string value)
        {
             throw new NotImplementedException();
        }
        
        
        public void Redirect(string url)
        {
             throw new NotImplementedException();
        }
        
        
        public void AppendCookie(Cookie cookie)
        {
             throw new NotImplementedException();
        }
        
        
        public void SetCookie(Cookie cookie)
        {
             throw new NotImplementedException();
        }
        
        
        public void Abort()
        {
             throw new NotImplementedException();
        }
        
        
        public void Close(byte[] responseEntity, bool willBlock)
        {
             throw new NotImplementedException();
        }
        
        
        public void Close()
        {
             throw new NotImplementedException();
        }



        void IDisposable.Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
