
namespace System.Net.NetworkInformation
{
    public abstract class MulticastIPAddressInformation : IPAddressInformation
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
    
    
        protected MulticastIPAddressInformation()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
