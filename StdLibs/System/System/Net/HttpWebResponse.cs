using System.Runtime.Serialization;
using System.IO;
using System;
using System.ComponentModel;

namespace System.Net
{
    [Serializable]
    public class HttpWebResponse : WebResponse, ISerializable
    {
    
        public override bool IsMutuallyAuthenticated
        {
            get { throw new NotImplementedException(); }
        }
    
        public virtual CookieCollection Cookies
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public override WebHeaderCollection Headers
        {
            get { throw new NotImplementedException(); }
        }
    
        public override bool SupportsHeaders
        {
            get { throw new NotImplementedException(); }
        }
    
        public override long ContentLength
        {
            get { throw new NotImplementedException(); }
        }
    
        public string ContentEncoding
        {
            get { throw new NotImplementedException(); }
        }
    
        public override string ContentType
        {
            get { throw new NotImplementedException(); }
        }
    
        public string CharacterSet
        {
            get { throw new NotImplementedException(); }
        }
    
        public string Server
        {
            get { throw new NotImplementedException(); }
        }
    
        public DateTime LastModified
        {
            get { throw new NotImplementedException(); }
        }
    
        public virtual HttpStatusCode StatusCode
        {
            get { throw new NotImplementedException(); }
        }
    
        public virtual string StatusDescription
        {
            get { throw new NotImplementedException(); }
        }
    
        public Version ProtocolVersion
        {
            get { throw new NotImplementedException(); }
        }
    
        public override Uri ResponseUri
        {
            get { throw new NotImplementedException(); }
        }
    
        public virtual string Method
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public override Stream GetResponseStream()
        {
             throw new NotImplementedException();
        }
        
        
        public override void Close()
        {
             throw new NotImplementedException();
        }
        
        
        protected override void Dispose(bool disposing)
        {
             throw new NotImplementedException();
        }
        
        
        [ObsoleteAttribute("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public HttpWebResponse()
        {
             throw new NotImplementedException();
        }
        
        
        [ObsoleteAttribute("Serialization is obsoleted for this type.  http://go.microsoft.com/fwlink/?linkid=14202")]
        protected HttpWebResponse(SerializationInfo serializationInfo, StreamingContext streamingContext)
        {
             throw new NotImplementedException();
        }
        
        
        protected override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
        {
             throw new NotImplementedException();
        }
        
        
        public string GetResponseHeader(string headerName)
        {
             throw new NotImplementedException();
        }

        void ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
        {
            throw new NotImplementedException();
        }
    }
}
