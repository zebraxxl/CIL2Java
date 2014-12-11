using System.Text;
using System.Net.Mime;
using System.IO;

namespace System.Net.Mail
{
    public class Attachment : AttachmentBase
    {
    
        public string Name
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public Encoding NameEncoding
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public ContentDisposition ContentDisposition
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public Attachment(string fileName)
        {
             throw new NotImplementedException();
        }
        
        
        public Attachment(string fileName, string mediaType)
        {
             throw new NotImplementedException();
        }
        
        
        public Attachment(string fileName, ContentType contentType)
        {
             throw new NotImplementedException();
        }
        
        
        public Attachment(Stream contentStream, string name)
        {
             throw new NotImplementedException();
        }
        
        
        public Attachment(Stream contentStream, string name, string mediaType)
        {
             throw new NotImplementedException();
        }
        
        
        public Attachment(Stream contentStream, ContentType contentType)
        {
             throw new NotImplementedException();
        }
        
        
        public static Attachment CreateAttachmentFromString(string content, string name)
        {
             throw new NotImplementedException();
        }
        
        
        public static Attachment CreateAttachmentFromString(string content, string name, Encoding contentEncoding, string mediaType)
        {
             throw new NotImplementedException();
        }
        
        
        public static Attachment CreateAttachmentFromString(string content, ContentType contentType)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
