using System.Runtime.CompilerServices;
using System;
using System.Threading.Tasks;
using System.Threading;

namespace System.Net.WebSockets
{
    public sealed class ClientWebSocket : WebSocket
    {
    
        public ClientWebSocketOptions Options
        {
            get { throw new NotImplementedException(); }
        }
    
        public override Nullable<WebSocketCloseStatus> CloseStatus
        {
            get { throw new NotImplementedException(); }
        }
    
        public override string CloseStatusDescription
        {
            get { throw new NotImplementedException(); }
        }
    
        public override string SubProtocol
        {
            get { throw new NotImplementedException(); }
        }
    
        public override WebSocketState State
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public ClientWebSocket()
        {
             throw new NotImplementedException();
        }
        
        
        public Task ConnectAsync(Uri uri, CancellationToken cancellationToken)
        {
             throw new NotImplementedException();
        }
        
        
        public override Task SendAsync(ArraySegment<byte> buffer, WebSocketMessageType messageType, bool endOfMessage, CancellationToken cancellationToken)
        {
             throw new NotImplementedException();
        }
        
        
        public override Task<WebSocketReceiveResult> ReceiveAsync(ArraySegment<byte> buffer, CancellationToken cancellationToken)
        {
             throw new NotImplementedException();
        }
        
        
        public override Task CloseAsync(WebSocketCloseStatus closeStatus, string statusDescription, CancellationToken cancellationToken)
        {
             throw new NotImplementedException();
        }
        
        
        public override Task CloseOutputAsync(WebSocketCloseStatus closeStatus, string statusDescription, CancellationToken cancellationToken)
        {
             throw new NotImplementedException();
        }
        
        
        public override void Abort()
        {
             throw new NotImplementedException();
        }
        
        
        public override void Dispose()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
