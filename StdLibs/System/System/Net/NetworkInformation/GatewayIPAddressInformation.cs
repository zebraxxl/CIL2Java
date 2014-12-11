using System.Net;

namespace System.Net.NetworkInformation
{
    public abstract class GatewayIPAddressInformation
    {
        public abstract IPAddress Address
        {
            get;
        }
    
    
        protected GatewayIPAddressInformation()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
