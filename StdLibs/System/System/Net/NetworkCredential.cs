using System.Security;
using System;

namespace System.Net
{
    public class NetworkCredential : ICredentials, ICredentialsByHost
    {
    
        public string UserName
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public string Password
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public SecureString SecurePassword
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public string Domain
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public NetworkCredential()
        {
             throw new NotImplementedException();
        }
        
        
        public NetworkCredential(string userName, string password)
        {
             throw new NotImplementedException();
        }
        
        
        public NetworkCredential(string userName, SecureString password)
        {
             throw new NotImplementedException();
        }
        
        
        public NetworkCredential(string userName, string password, string domain)
        {
             throw new NotImplementedException();
        }
        
        
        public NetworkCredential(string userName, SecureString password, string domain)
        {
             throw new NotImplementedException();
        }
        
        
        public NetworkCredential GetCredential(Uri uri, string authType)
        {
             throw new NotImplementedException();
        }
        
        
        public NetworkCredential GetCredential(string host, int port, string authenticationType)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
