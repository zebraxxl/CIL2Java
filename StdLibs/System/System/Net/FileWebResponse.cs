using System.Runtime.Serialization;
using System;
using System.IO;

namespace System.Net
{
    [Serializable]
    public class FileWebResponse : WebResponse, ISerializable
    {
    
        public override long ContentLength
        {
            get { throw new NotImplementedException(); }
        }
    
        public override string ContentType
        {
            get { throw new NotImplementedException(); }
        }
    
        public override WebHeaderCollection Headers
        {
            get { throw new NotImplementedException(); }
        }
    
        public override bool SupportsHeaders
        {
            get { throw new NotImplementedException(); }
        }
    
        public override Uri ResponseUri
        {
            get { throw new NotImplementedException(); }
        }
    
    
        [ObsoleteAttribute("Serialization is obsoleted for this type. http://go.microsoft.com/fwlink/?linkid=14202")]
        protected FileWebResponse(SerializationInfo serializationInfo, StreamingContext streamingContext)
        {
             throw new NotImplementedException();
        }
        
        
        protected override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
        {
             throw new NotImplementedException();
        }
        
        
        public override void Close()
        {
             throw new NotImplementedException();
        }
        
        
        public override Stream GetResponseStream()
        {
             throw new NotImplementedException();
        }

        void ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
        {
            throw new NotImplementedException();
        }
    }
}
