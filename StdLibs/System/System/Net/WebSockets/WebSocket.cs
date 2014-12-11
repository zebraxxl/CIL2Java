using System;
using System.ComponentModel;
using System.IO;
using System.Threading.Tasks;
using System.Threading;

namespace System.Net.WebSockets
{
    public abstract class WebSocket : IDisposable
    {
    
        public abstract Nullable<WebSocketCloseStatus> CloseStatus
        {
            get;
        }
    
        public abstract string CloseStatusDescription
        {
            get;
        }
    
        public abstract string SubProtocol
        {
            get;
        }
    
        public abstract WebSocketState State
        {
            get;
        }
    
        public static TimeSpan DefaultKeepAliveInterval
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public static ArraySegment<byte> CreateClientBuffer(int receiveBufferSize, int sendBufferSize)
        {
             throw new NotImplementedException();
        }
        
        
        public static ArraySegment<byte> CreateServerBuffer(int receiveBufferSize)
        {
             throw new NotImplementedException();
        }
        
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public static WebSocket CreateClientWebSocket(Stream innerStream, string subProtocol, int receiveBufferSize, int sendBufferSize, TimeSpan keepAliveInterval, bool useZeroMaskingKey, ArraySegment<byte> internalBuffer)
        {
             throw new NotImplementedException();
        }
        
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public static void RegisterPrefixes()
        {
             throw new NotImplementedException();
        }
        
        
        [ObsoleteAttribute("This is just a temporary workaround until the CLR provides a public (but hidden) API to check  whether an application is targeting 4.5. So don\'t take a dependency on it.")]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public static bool IsApplicationTargeting45()
        {
             throw new NotImplementedException();
        }
        
        
        public abstract void Abort();
        
        
        public abstract Task CloseAsync(WebSocketCloseStatus closeStatus, string statusDescription, CancellationToken cancellationToken);
        
        
        public abstract Task CloseOutputAsync(WebSocketCloseStatus closeStatus, string statusDescription, CancellationToken cancellationToken);
        
        
        public abstract void Dispose();
        
        
        public abstract Task<WebSocketReceiveResult> ReceiveAsync(ArraySegment<byte> buffer, CancellationToken cancellationToken);
        
        
        public abstract Task SendAsync(ArraySegment<byte> buffer, WebSocketMessageType messageType, bool endOfMessage, CancellationToken cancellationToken);
        
        
        protected static void ThrowOnInvalidState(WebSocketState state, params  WebSocketState[] validStates)
        {
             throw new NotImplementedException();
        }
        
        
        protected static bool IsStateTerminal(WebSocketState state)
        {
             throw new NotImplementedException();
        }
        
        
        protected WebSocket()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
