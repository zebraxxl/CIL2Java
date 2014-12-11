using System.Runtime.CompilerServices;
using System;

namespace System.Net.WebSockets
{
    public class WebSocketReceiveResult
    {
    
        public int Count
        {
            get { throw new NotImplementedException(); }
        }
    
        public bool EndOfMessage
        {
            get { throw new NotImplementedException(); }
        }
    
        public WebSocketMessageType MessageType
        {
            get { throw new NotImplementedException(); }
        }
    
        public Nullable<WebSocketCloseStatus> CloseStatus
        {
            get { throw new NotImplementedException(); }
        }
    
        public string CloseStatusDescription
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public WebSocketReceiveResult(int count, WebSocketMessageType messageType, bool endOfMessage)
        {
             throw new NotImplementedException();
        }
        
        
        public WebSocketReceiveResult(int count, WebSocketMessageType messageType, bool endOfMessage, Nullable<WebSocketCloseStatus> closeStatus, string closeStatusDescription)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
