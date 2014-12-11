using System.Security.Principal;
using System.Security.Authentication.ExtendedProtection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Net.WebSockets;
using System;
using System.ComponentModel;

namespace System.Net
{
    public sealed class HttpListenerContext
    {
    
        public HttpListenerRequest Request
        {
            get { throw new NotImplementedException(); }
        }
    
        public HttpListenerResponse Response
        {
            get { throw new NotImplementedException(); }
        }
    
        public IPrincipal User
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public Task<HttpListenerWebSocketContext> AcceptWebSocketAsync(string subProtocol)
        {
             throw new NotImplementedException();
        }
        
        
        public Task<HttpListenerWebSocketContext> AcceptWebSocketAsync(string subProtocol, TimeSpan keepAliveInterval)
        {
             throw new NotImplementedException();
        }
        
        
        public Task<HttpListenerWebSocketContext> AcceptWebSocketAsync(string subProtocol, int receiveBufferSize, TimeSpan keepAliveInterval)
        {
             throw new NotImplementedException();
        }
        
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public Task<HttpListenerWebSocketContext> AcceptWebSocketAsync(string subProtocol, int receiveBufferSize, TimeSpan keepAliveInterval, ArraySegment<byte> internalBuffer)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
