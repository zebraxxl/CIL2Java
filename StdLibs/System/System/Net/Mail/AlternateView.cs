using System;
using System.Net.Mime;
using System.IO;
using System.Text;

namespace System.Net.Mail
{
    public class AlternateView : AttachmentBase
    {
    
        public LinkedResourceCollection LinkedResources
        {
            get { throw new NotImplementedException(); }
        }
    
        public Uri BaseUri
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public AlternateView(string fileName)
        {
             throw new NotImplementedException();
        }
        
        
        public AlternateView(string fileName, string mediaType)
        {
             throw new NotImplementedException();
        }
        
        
        public AlternateView(string fileName, ContentType contentType)
        {
             throw new NotImplementedException();
        }
        
        
        public AlternateView(Stream contentStream)
        {
             throw new NotImplementedException();
        }
        
        
        public AlternateView(Stream contentStream, string mediaType)
        {
             throw new NotImplementedException();
        }
        
        
        public AlternateView(Stream contentStream, ContentType contentType)
        {
             throw new NotImplementedException();
        }
        
        
        public static AlternateView CreateAlternateViewFromString(string content)
        {
             throw new NotImplementedException();
        }
        
        
        public static AlternateView CreateAlternateViewFromString(string content, Encoding contentEncoding, string mediaType)
        {
             throw new NotImplementedException();
        }
        
        
        public static AlternateView CreateAlternateViewFromString(string content, ContentType contentType)
        {
             throw new NotImplementedException();
        }
        
        
        protected override void Dispose(bool disposing)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
