using System.ComponentModel;
using System;

namespace System.Net.NetworkInformation
{
    public class NetworkChange
    {
        public static event NetworkAvailabilityChangedEventHandler NetworkAvailabilityChanged;
    
        public static event NetworkAddressChangedEventHandler NetworkAddressChanged;
    
    
    
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [ObsoleteAttribute("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
        public NetworkChange()
        {
             throw new NotImplementedException();
        }
        
        
        [ObsoleteAttribute("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public static void RegisterNetworkChange(NetworkChange nc)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
