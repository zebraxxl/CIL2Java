using System;
using System.Net.Mime;
using System.IO;
using System.Text;

namespace System.Net.Mail
{
    public class LinkedResource : AttachmentBase
    {
        public Uri ContentLink
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public LinkedResource(string fileName)
        {
             throw new NotImplementedException();
        }
        
        
        public LinkedResource(string fileName, string mediaType)
        {
             throw new NotImplementedException();
        }
        
        
        public LinkedResource(string fileName, ContentType contentType)
        {
             throw new NotImplementedException();
        }
        
        
        public LinkedResource(Stream contentStream)
        {
             throw new NotImplementedException();
        }
        
        
        public LinkedResource(Stream contentStream, string mediaType)
        {
             throw new NotImplementedException();
        }
        
        
        public LinkedResource(Stream contentStream, ContentType contentType)
        {
             throw new NotImplementedException();
        }
        
        
        public static LinkedResource CreateLinkedResourceFromString(string content)
        {
             throw new NotImplementedException();
        }
        
        
        public static LinkedResource CreateLinkedResourceFromString(string content, Encoding contentEncoding, string mediaType)
        {
             throw new NotImplementedException();
        }
        
        
        public static LinkedResource CreateLinkedResourceFromString(string content, ContentType contentType)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
