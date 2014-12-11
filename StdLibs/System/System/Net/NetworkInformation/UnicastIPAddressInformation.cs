using System.Net;

namespace System.Net.NetworkInformation
{
    public abstract class UnicastIPAddressInformation : IPAddressInformation
    {
        public abstract long AddressPreferredLifetime
        {
            get;
        }
    
        public abstract long AddressValidLifetime
        {
            get;
        }
    
        public abstract long DhcpLeaseLifetime
        {
            get;
        }
    
        public abstract DuplicateAddressDetectionState DuplicateAddressDetectionState
        {
            get;
        }
    
        public abstract PrefixOrigin PrefixOrigin
        {
            get;
        }
    
        public abstract SuffixOrigin SuffixOrigin
        {
            get;
        }
    
        public abstract IPAddress IPv4Mask
        {
            get;
        }
    
        public virtual int PrefixLength
        {
            get { throw new NotImplementedException(); }
        }
    
    
        protected UnicastIPAddressInformation()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
