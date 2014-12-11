using System.Runtime.Serialization;
using System;
using System.IO;

namespace System.Net
{
    [Serializable]
    public class FileWebRequest : WebRequest, ISerializable
    {
    
        public override string ConnectionGroupName
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public override long ContentLength
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public override string ContentType
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public override ICredentials Credentials
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public override WebHeaderCollection Headers
        {
            get { throw new NotImplementedException(); }
        }
    
        public override string Method
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public override bool PreAuthenticate
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public override IWebProxy Proxy
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public override int Timeout
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public override Uri RequestUri
        {
            get { throw new NotImplementedException(); }
        }
    
        public override bool UseDefaultCredentials
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        [ObsoleteAttribute("Serialization is obsoleted for this type. http://go.microsoft.com/fwlink/?linkid=14202")]
        protected FileWebRequest(SerializationInfo serializationInfo, StreamingContext streamingContext)
        {
             throw new NotImplementedException();
        }
        
        
        protected override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
        {
             throw new NotImplementedException();
        }
        
        
        public override IAsyncResult BeginGetRequestStream(AsyncCallback callback, object state)
        {
             throw new NotImplementedException();
        }
        
        
        public override IAsyncResult BeginGetResponse(AsyncCallback callback, object state)
        {
             throw new NotImplementedException();
        }
        
        
        public override Stream EndGetRequestStream(IAsyncResult asyncResult)
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
        
        
        public override WebResponse GetResponse()
        {
             throw new NotImplementedException();
        }
        
        
        public override void Abort()
        {
             throw new NotImplementedException();
        }

        void ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
        {
            throw new NotImplementedException();
        }
    }
}
