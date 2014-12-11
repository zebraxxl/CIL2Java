using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System;
using System.Net.Cache;
using System.Security.Cryptography.X509Certificates;
using System.Net.Security;
using System.IO;
using System.ComponentModel;

namespace System.Net
{
    [Serializable]
    public class HttpWebRequest : WebRequest, ISerializable
    {
    
        public virtual bool AllowAutoRedirect
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public virtual bool AllowWriteStreamBuffering
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public virtual bool AllowReadStreamBuffering
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public virtual bool HaveResponse
        {
            get { throw new NotImplementedException(); }
        }
    
        public bool KeepAlive
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public bool Pipelined
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public override bool PreAuthenticate
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public bool UnsafeAuthenticatedConnectionSharing
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public bool SendChunked
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public DecompressionMethods AutomaticDecompression
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public new static RequestCachePolicy DefaultCachePolicy
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public static int DefaultMaximumResponseHeadersLength
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public static int DefaultMaximumErrorResponseLength
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public int MaximumResponseHeadersLength
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public X509CertificateCollection ClientCertificates
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public virtual CookieContainer CookieContainer
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public virtual bool SupportsCookieContainer
        {
            get { throw new NotImplementedException(); }
        }
    
        public override Uri RequestUri
        {
            get { throw new NotImplementedException(); }
        }
    
        public override long ContentLength
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
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
    
        public int ContinueTimeout
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public Uri Address
        {
            get { throw new NotImplementedException(); }
        }
    
        public HttpContinueDelegate ContinueDelegate
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public ServicePoint ServicePoint
        {
            get { throw new NotImplementedException(); }
        }
    
        public string Host
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public int MaximumAutomaticRedirections
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public override string Method
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public override ICredentials Credentials
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public override bool UseDefaultCredentials
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public override string ConnectionGroupName
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public override WebHeaderCollection Headers
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public override IWebProxy Proxy
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public Version ProtocolVersion
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public override string ContentType
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public string MediaType
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public string TransferEncoding
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public string Connection
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public string Accept
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public string Referer
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public string UserAgent
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public string Expect
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public DateTime IfModifiedSince
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public DateTime Date
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public RemoteCertificateValidationCallback ServerCertificateValidationCallback
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public override IAsyncResult BeginGetRequestStream(AsyncCallback callback, object state)
        {
             throw new NotImplementedException();
        }
        
        
        public override Stream EndGetRequestStream(IAsyncResult asyncResult)
        {
             throw new NotImplementedException();
        }
        
        
        public Stream EndGetRequestStream(IAsyncResult asyncResult, ref TransportContext context)
        {
             throw new NotImplementedException();
        }
        
        
        public override Stream GetRequestStream()
        {
             throw new NotImplementedException();
        }
        
        
        public Stream GetRequestStream(ref TransportContext context)
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
        
        
        public override WebResponse GetResponse()
        {
             throw new NotImplementedException();
        }
        
        
        public override void Abort()
        {
             throw new NotImplementedException();
        }
        
        
        [ObsoleteAttribute("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public HttpWebRequest()
        {
             throw new NotImplementedException();
        }
        
        
        [ObsoleteAttribute("Serialization is obsoleted for this type.  http://go.microsoft.com/fwlink/?linkid=14202")]
        protected HttpWebRequest(SerializationInfo serializationInfo, StreamingContext streamingContext)
        {
             throw new NotImplementedException();
        }
        
        
        protected override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
        {
             throw new NotImplementedException();
        }
        
        
        public void AddRange(int from, int to)
        {
             throw new NotImplementedException();
        }
        
        
        public void AddRange(long from, long to)
        {
             throw new NotImplementedException();
        }
        
        
        public void AddRange(int range)
        {
             throw new NotImplementedException();
        }
        
        
        public void AddRange(long range)
        {
             throw new NotImplementedException();
        }
        
        
        public void AddRange(string rangeSpecifier, int from, int to)
        {
             throw new NotImplementedException();
        }
        
        
        public void AddRange(string rangeSpecifier, long from, long to)
        {
             throw new NotImplementedException();
        }
        
        
        public void AddRange(string rangeSpecifier, int range)
        {
             throw new NotImplementedException();
        }
        
        
        public void AddRange(string rangeSpecifier, long range)
        {
             throw new NotImplementedException();
        }

        void ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
        {
            throw new NotImplementedException();
        }
    }
}
