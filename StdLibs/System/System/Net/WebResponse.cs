using System;
using System.Runtime.Serialization;
using System.IO;

namespace System.Net
{
    [Serializable]
    public abstract class WebResponse : MarshalByRefObject, ISerializable, IDisposable
    {
    
        public virtual bool IsFromCache
        {
            get { throw new NotImplementedException(); }
        }
    
        public virtual bool IsMutuallyAuthenticated
        {
            get { throw new NotImplementedException(); }
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
    
        public virtual Uri ResponseUri
        {
            get { throw new NotImplementedException(); }
        }
    
        public virtual WebHeaderCollection Headers
        {
            get { throw new NotImplementedException(); }
        }
    
        public virtual bool SupportsHeaders
        {
            get { throw new NotImplementedException(); }
        }
    
    
        protected WebResponse()
        {
             throw new NotImplementedException();
        }
        
        
        protected WebResponse(SerializationInfo serializationInfo, StreamingContext streamingContext)
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual void Close()
        {
             throw new NotImplementedException();
        }
        
        
        public void Dispose()
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual void Dispose(bool disposing)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual Stream GetResponseStream()
        {
             throw new NotImplementedException();
        }

        void ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
        {
            throw new NotImplementedException();
        }
    }
}
