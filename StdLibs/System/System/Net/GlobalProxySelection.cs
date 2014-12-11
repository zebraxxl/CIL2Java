using System;

namespace System.Net
{
    [ObsoleteAttribute("This class has been deprecated. Please use WebRequest.DefaultWebProxy instead to access and set the global default proxy. Use \'null\' instead of GetEmptyWebProxy. http://go.microsoft.com/fwlink/?linkid=14202")]
    public class GlobalProxySelection
    {
        public static IWebProxy Select
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public static IWebProxy GetEmptyWebProxy()
        {
             throw new NotImplementedException();
        }
        
        
        public GlobalProxySelection()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
