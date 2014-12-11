using System;
using System.Threading.Tasks;

namespace System.Net
{
    public static class Dns
    {
    
        [ObsoleteAttribute("GetHostByName is obsoleted for this type, please use GetHostEntry instead. http://go.microsoft.com/fwlink/?linkid=14202")]
        public static IPHostEntry GetHostByName(string hostName)
        {
             throw new NotImplementedException();
        }
        
        
        [ObsoleteAttribute("GetHostByAddress is obsoleted for this type, please use GetHostEntry instead. http://go.microsoft.com/fwlink/?linkid=14202")]
        public static IPHostEntry GetHostByAddress(string address)
        {
             throw new NotImplementedException();
        }
        
        
        [ObsoleteAttribute("GetHostByAddress is obsoleted for this type, please use GetHostEntry instead. http://go.microsoft.com/fwlink/?linkid=14202")]
        public static IPHostEntry GetHostByAddress(IPAddress address)
        {
             throw new NotImplementedException();
        }
        
        
        public static string GetHostName()
        {
             throw new NotImplementedException();
        }
        
        
        [ObsoleteAttribute("Resolve is obsoleted for this type, please use GetHostEntry instead. http://go.microsoft.com/fwlink/?linkid=14202")]
        public static IPHostEntry Resolve(string hostName)
        {
             throw new NotImplementedException();
        }
        
        
        [ObsoleteAttribute("BeginGetHostByName is obsoleted for this type, please use BeginGetHostEntry instead. http://go.microsoft.com/fwlink/?linkid=14202")]
        public static IAsyncResult BeginGetHostByName(string hostName, AsyncCallback requestCallback, object stateObject)
        {
             throw new NotImplementedException();
        }
        
        
        [ObsoleteAttribute("EndGetHostByName is obsoleted for this type, please use EndGetHostEntry instead. http://go.microsoft.com/fwlink/?linkid=14202")]
        public static IPHostEntry EndGetHostByName(IAsyncResult asyncResult)
        {
             throw new NotImplementedException();
        }
        
        
        public static IPHostEntry GetHostEntry(string hostNameOrAddress)
        {
             throw new NotImplementedException();
        }
        
        
        public static IPHostEntry GetHostEntry(IPAddress address)
        {
             throw new NotImplementedException();
        }
        
        
        public static IPAddress[] GetHostAddresses(string hostNameOrAddress)
        {
             throw new NotImplementedException();
        }
        
        
        public static IAsyncResult BeginGetHostEntry(string hostNameOrAddress, AsyncCallback requestCallback, object stateObject)
        {
             throw new NotImplementedException();
        }
        
        
        public static IAsyncResult BeginGetHostEntry(IPAddress address, AsyncCallback requestCallback, object stateObject)
        {
             throw new NotImplementedException();
        }
        
        
        public static IPHostEntry EndGetHostEntry(IAsyncResult asyncResult)
        {
             throw new NotImplementedException();
        }
        
        
        public static IAsyncResult BeginGetHostAddresses(string hostNameOrAddress, AsyncCallback requestCallback, object state)
        {
             throw new NotImplementedException();
        }
        
        
        public static IPAddress[] EndGetHostAddresses(IAsyncResult asyncResult)
        {
             throw new NotImplementedException();
        }
        
        
        [ObsoleteAttribute("BeginResolve is obsoleted for this type, please use BeginGetHostEntry instead. http://go.microsoft.com/fwlink/?linkid=14202")]
        public static IAsyncResult BeginResolve(string hostName, AsyncCallback requestCallback, object stateObject)
        {
             throw new NotImplementedException();
        }
        
        
        [ObsoleteAttribute("EndResolve is obsoleted for this type, please use EndGetHostEntry instead. http://go.microsoft.com/fwlink/?linkid=14202")]
        public static IPHostEntry EndResolve(IAsyncResult asyncResult)
        {
             throw new NotImplementedException();
        }
        
        
        public static Task<IPAddress[]> GetHostAddressesAsync(string hostNameOrAddress)
        {
             throw new NotImplementedException();
        }
        
        
        public static Task<IPHostEntry> GetHostEntryAsync(IPAddress address)
        {
             throw new NotImplementedException();
        }
        
        
        public static Task<IPHostEntry> GetHostEntryAsync(string hostNameOrAddress)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
