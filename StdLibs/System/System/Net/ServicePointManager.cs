using System.Collections;
using System;
using System.Net.Security;

namespace System.Net
{
    public class ServicePointManager
    {
        public const int DefaultNonPersistentConnectionLimit = 4;
        public const int DefaultPersistentConnectionLimit = 2;
    
        public static SecurityProtocolType SecurityProtocol
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public static int MaxServicePoints
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public static int DefaultConnectionLimit
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public static int MaxServicePointIdleTime
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public static bool UseNagleAlgorithm
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public static bool Expect100Continue
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public static bool EnableDnsRoundRobin
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public static int DnsRefreshTimeout
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        [ObsoleteAttribute("CertificatePolicy is obsoleted for this type, please use ServerCertificateValidationCallback instead. http://go.microsoft.com/fwlink/?linkid=14202")]
        public static ICertificatePolicy CertificatePolicy
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public static RemoteCertificateValidationCallback ServerCertificateValidationCallback
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public static bool CheckCertificateRevocationList
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public static EncryptionPolicy EncryptionPolicy
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public static ServicePoint FindServicePoint(Uri address)
        {
             throw new NotImplementedException();
        }
        
        
        public static ServicePoint FindServicePoint(string uriString, IWebProxy proxy)
        {
             throw new NotImplementedException();
        }
        
        
        public static ServicePoint FindServicePoint(Uri address, IWebProxy proxy)
        {
             throw new NotImplementedException();
        }
        
        
        public static void SetTcpKeepAlive(bool enabled, int keepAliveTime, int keepAliveInterval)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
