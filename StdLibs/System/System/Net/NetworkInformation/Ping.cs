using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Net;
using System.Threading.Tasks;

namespace System.Net.NetworkInformation
{
    public class Ping : Component
    {
    
        public event PingCompletedEventHandler PingCompleted;
    
    
    
        protected void OnPingCompleted(PingCompletedEventArgs e)
        {
             throw new NotImplementedException();
        }
        
        
        public Ping()
        {
             throw new NotImplementedException();
        }
        
        
        protected override void Dispose(bool disposing)
        {
             throw new NotImplementedException();
        }
        
        
        public void SendAsyncCancel()
        {
             throw new NotImplementedException();
        }
        
        
        public PingReply Send(string hostNameOrAddress)
        {
             throw new NotImplementedException();
        }
        
        
        public PingReply Send(string hostNameOrAddress, int timeout)
        {
             throw new NotImplementedException();
        }
        
        
        public PingReply Send(IPAddress address)
        {
             throw new NotImplementedException();
        }
        
        
        public PingReply Send(IPAddress address, int timeout)
        {
             throw new NotImplementedException();
        }
        
        
        public PingReply Send(string hostNameOrAddress, int timeout, byte[] buffer)
        {
             throw new NotImplementedException();
        }
        
        
        public PingReply Send(IPAddress address, int timeout, byte[] buffer)
        {
             throw new NotImplementedException();
        }
        
        
        public PingReply Send(string hostNameOrAddress, int timeout, byte[] buffer, PingOptions options)
        {
             throw new NotImplementedException();
        }
        
        
        public PingReply Send(IPAddress address, int timeout, byte[] buffer, PingOptions options)
        {
             throw new NotImplementedException();
        }
        
        
        public void SendAsync(string hostNameOrAddress, object userToken)
        {
             throw new NotImplementedException();
        }
        
        
        public void SendAsync(string hostNameOrAddress, int timeout, object userToken)
        {
             throw new NotImplementedException();
        }
        
        
        public void SendAsync(IPAddress address, object userToken)
        {
             throw new NotImplementedException();
        }
        
        
        public void SendAsync(IPAddress address, int timeout, object userToken)
        {
             throw new NotImplementedException();
        }
        
        
        public void SendAsync(string hostNameOrAddress, int timeout, byte[] buffer, object userToken)
        {
             throw new NotImplementedException();
        }
        
        
        public void SendAsync(IPAddress address, int timeout, byte[] buffer, object userToken)
        {
             throw new NotImplementedException();
        }
        
        
        public void SendAsync(string hostNameOrAddress, int timeout, byte[] buffer, PingOptions options, object userToken)
        {
             throw new NotImplementedException();
        }
        
        
        public void SendAsync(IPAddress address, int timeout, byte[] buffer, PingOptions options, object userToken)
        {
             throw new NotImplementedException();
        }
        
        
        public Task<PingReply> SendPingAsync(IPAddress address)
        {
             throw new NotImplementedException();
        }
        
        
        public Task<PingReply> SendPingAsync(string hostNameOrAddress)
        {
             throw new NotImplementedException();
        }
        
        
        public Task<PingReply> SendPingAsync(IPAddress address, int timeout)
        {
             throw new NotImplementedException();
        }
        
        
        public Task<PingReply> SendPingAsync(string hostNameOrAddress, int timeout)
        {
             throw new NotImplementedException();
        }
        
        
        public Task<PingReply> SendPingAsync(IPAddress address, int timeout, byte[] buffer)
        {
             throw new NotImplementedException();
        }
        
        
        public Task<PingReply> SendPingAsync(string hostNameOrAddress, int timeout, byte[] buffer)
        {
             throw new NotImplementedException();
        }
        
        
        public Task<PingReply> SendPingAsync(IPAddress address, int timeout, byte[] buffer, PingOptions options)
        {
             throw new NotImplementedException();
        }
        
        
        public Task<PingReply> SendPingAsync(string hostNameOrAddress, int timeout, byte[] buffer, PingOptions options)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
