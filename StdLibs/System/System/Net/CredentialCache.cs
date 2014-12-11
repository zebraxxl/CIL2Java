using System.Collections;
using System;

namespace System.Net
{
    public class CredentialCache : ICredentials, ICredentialsByHost, IEnumerable
    {
    
        public static ICredentials DefaultCredentials
        {
            get { throw new NotImplementedException(); }
        }
    
        public static NetworkCredential DefaultNetworkCredentials
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public CredentialCache()
        {
             throw new NotImplementedException();
        }
        
        
        public void Add(Uri uriPrefix, string authType, NetworkCredential cred)
        {
             throw new NotImplementedException();
        }
        
        
        public void Add(string host, int port, string authenticationType, NetworkCredential credential)
        {
             throw new NotImplementedException();
        }
        
        
        public void Remove(Uri uriPrefix, string authType)
        {
             throw new NotImplementedException();
        }
        
        
        public void Remove(string host, int port, string authenticationType)
        {
             throw new NotImplementedException();
        }
        
        
        public NetworkCredential GetCredential(Uri uriPrefix, string authType)
        {
             throw new NotImplementedException();
        }
        
        
        public NetworkCredential GetCredential(string host, int port, string authenticationType)
        {
             throw new NotImplementedException();
        }
        
        
        public IEnumerator GetEnumerator()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
