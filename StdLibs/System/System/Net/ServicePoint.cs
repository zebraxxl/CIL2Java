using System.Runtime.CompilerServices;
using System;
using System.Security.Cryptography.X509Certificates;

namespace System.Net
{
    public class ServicePoint
    {
    
        public BindIPEndPoint BindIPEndPointDelegate
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public int ConnectionLeaseTimeout
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public Uri Address
        {
            get { throw new NotImplementedException(); }
        }
    
        public int MaxIdleTime
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public bool UseNagleAlgorithm
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public int ReceiveBufferSize
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public bool Expect100Continue
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public DateTime IdleSince
        {
            get { throw new NotImplementedException(); }
        }
    
        public virtual Version ProtocolVersion
        {
            get { throw new NotImplementedException(); }
        }
    
        public string ConnectionName
        {
            get { throw new NotImplementedException(); }
        }
    
        public int ConnectionLimit
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public int CurrentConnections
        {
            get { throw new NotImplementedException(); }
        }
    
        public X509Certificate Certificate
        {
            get { throw new NotImplementedException(); }
        }
    
        public X509Certificate ClientCertificate
        {
            get { throw new NotImplementedException(); }
        }
    
        public bool SupportsPipelining
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public bool CloseConnectionGroup(string connectionGroupName)
        {
             throw new NotImplementedException();
        }
        
        
        public void SetTcpKeepAlive(bool enabled, int keepAliveTime, int keepAliveInterval)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
