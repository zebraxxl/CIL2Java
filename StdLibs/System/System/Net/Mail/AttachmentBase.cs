using System;
using System.IO;
using System.Net.Mime;

namespace System.Net.Mail
{
    public abstract class AttachmentBase : IDisposable
    {
        internal AttachmentBase()
        {
            //TODO: REMOVE THIS
        }
    
        public Stream ContentStream
        {
            get { throw new NotImplementedException(); }
        }
    
        public string ContentId
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public ContentType ContentType
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public TransferEncoding TransferEncoding
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        protected AttachmentBase(string fileName)
        {
             throw new NotImplementedException();
        }
        
        
        protected AttachmentBase(string fileName, string mediaType)
        {
             throw new NotImplementedException();
        }
        
        
        protected AttachmentBase(string fileName, ContentType contentType)
        {
             throw new NotImplementedException();
        }
        
        
        protected AttachmentBase(Stream contentStream)
        {
             throw new NotImplementedException();
        }
        
        
        protected AttachmentBase(Stream contentStream, string mediaType)
        {
             throw new NotImplementedException();
        }
        
        
        protected AttachmentBase(Stream contentStream, ContentType contentType)
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
        
        
    }
}
