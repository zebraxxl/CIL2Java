using System.Net.Cache;
using System;
using System.Security.Cryptography.X509Certificates;
using System.IO;

namespace System.Net
{
    public sealed class FtpWebRequest : WebRequest
    {

        public new static RequestCachePolicy DefaultCachePolicy
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public override string Method
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public string RenameTo
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public override ICredentials Credentials
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public override Uri RequestUri
        {
            get { throw new NotImplementedException(); }
        }
    
        public override int Timeout
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public int ReadWriteTimeout
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public long ContentOffset
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public override long ContentLength
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public override IWebProxy Proxy
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public override string ConnectionGroupName
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public ServicePoint ServicePoint
        {
            get { throw new NotImplementedException(); }
        }
    
        public bool KeepAlive
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public bool UseBinary
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public bool UsePassive
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public X509CertificateCollection ClientCertificates
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public bool EnableSsl
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public override WebHeaderCollection Headers
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public override string ContentType
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public override bool UseDefaultCredentials
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public override bool PreAuthenticate
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public override WebResponse GetResponse()
        {
             throw new NotImplementedException();
        }
        
        
        public override IAsyncResult BeginGetResponse(AsyncCallback callback, object state)
        {
             throw new NotImplementedException();
        }
        
        
        public override WebResponse EndGetResponse(IAsyncResult asyncResult)
        {
             throw new NotImplementedException();
        }
        
        
        public override Stream GetRequestStream()
        {
             throw new NotImplementedException();
        }
        
        
        public override IAsyncResult BeginGetRequestStream(AsyncCallback callback, object state)
        {
             throw new NotImplementedException();
        }
        
        
        public override Stream EndGetRequestStream(IAsyncResult asyncResult)
        {
             throw new NotImplementedException();
        }
        
        
        public override void Abort()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
