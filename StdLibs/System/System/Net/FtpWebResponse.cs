using System;
using System.IO;

namespace System.Net
{
    public class FtpWebResponse : WebResponse, IDisposable
    {
    
        public override long ContentLength
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
    
        public FtpStatusCode StatusCode
        {
            get { throw new NotImplementedException(); }
        }
    
        public string StatusDescription
        {
            get { throw new NotImplementedException(); }
        }
    
        public DateTime LastModified
        {
            get { throw new NotImplementedException(); }
        }
    
        public string BannerMessage
        {
            get { throw new NotImplementedException(); }
        }
    
        public string WelcomeMessage
        {
            get { throw new NotImplementedException(); }
        }
    
        public string ExitMessage
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
        
        
    }
}
