using System;
using System.Text;
using System.Collections.Specialized;
using System.Net.Mime;

namespace System.Net.Mail
{
    public class MailMessage : IDisposable
    {
    
        public MailAddress From
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public MailAddress Sender
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        [ObsoleteAttribute("ReplyTo is obsoleted for this type.  Please use ReplyToList instead which can accept multiple addresses. http://go.microsoft.com/fwlink/?linkid=14202")]
        public MailAddress ReplyTo
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public MailAddressCollection ReplyToList
        {
            get { throw new NotImplementedException(); }
        }
    
        public MailAddressCollection To
        {
            get { throw new NotImplementedException(); }
        }
    
        public MailAddressCollection Bcc
        {
            get { throw new NotImplementedException(); }
        }
    
        public MailAddressCollection CC
        {
            get { throw new NotImplementedException(); }
        }
    
        public MailPriority Priority
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public DeliveryNotificationOptions DeliveryNotificationOptions
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public string Subject
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public Encoding SubjectEncoding
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public NameValueCollection Headers
        {
            get { throw new NotImplementedException(); }
        }
    
        public Encoding HeadersEncoding
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public string Body
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public Encoding BodyEncoding
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public TransferEncoding BodyTransferEncoding
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public bool IsBodyHtml
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public AttachmentCollection Attachments
        {
            get { throw new NotImplementedException(); }
        }
    
        public AlternateViewCollection AlternateViews
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public MailMessage()
        {
             throw new NotImplementedException();
        }
        
        
        public MailMessage(string from, string to)
        {
             throw new NotImplementedException();
        }
        
        
        public MailMessage(string from, string to, string subject, string body)
        {
             throw new NotImplementedException();
        }
        
        
        public MailMessage(MailAddress from, MailAddress to)
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
