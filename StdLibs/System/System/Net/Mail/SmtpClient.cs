using System;
using System.Runtime.CompilerServices;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Net.Configuration;
using System.ComponentModel;
using System.Threading.Tasks;

namespace System.Net.Mail
{
    public class SmtpClient : IDisposable
    {
    
        public event SendCompletedEventHandler SendCompleted;
    
    
        public string Host
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public int Port
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public bool UseDefaultCredentials
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public ICredentialsByHost Credentials
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public int Timeout
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public ServicePoint ServicePoint
        {
            get { throw new NotImplementedException(); }
        }
    
        public SmtpDeliveryMethod DeliveryMethod
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public SmtpDeliveryFormat DeliveryFormat
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public string PickupDirectoryLocation
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public bool EnableSsl
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public X509CertificateCollection ClientCertificates
        {
            get { throw new NotImplementedException(); }
        }
    
        public string TargetName
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public SmtpClient()
        {
             throw new NotImplementedException();
        }
        
        
        public SmtpClient(string host)
        {
             throw new NotImplementedException();
        }
        
        
        public SmtpClient(string host, int port)
        {
             throw new NotImplementedException();
        }
        
        
        protected void OnSendCompleted(AsyncCompletedEventArgs e)
        {
             throw new NotImplementedException();
        }
        
        
        public void Send(string from, string recipients, string subject, string body)
        {
             throw new NotImplementedException();
        }
        
        
        public void Send(MailMessage message)
        {
             throw new NotImplementedException();
        }
        
        
        public void SendAsync(string from, string recipients, string subject, string body, object userToken)
        {
             throw new NotImplementedException();
        }
        
        
        public void SendAsync(MailMessage message, object userToken)
        {
             throw new NotImplementedException();
        }
        
        
        public void SendAsyncCancel()
        {
             throw new NotImplementedException();
        }
        
        
        public Task SendMailAsync(string from, string recipients, string subject, string body)
        {
             throw new NotImplementedException();
        }
        
        
        public Task SendMailAsync(MailMessage message)
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
