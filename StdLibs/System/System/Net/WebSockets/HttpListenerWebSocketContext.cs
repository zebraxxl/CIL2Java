using System;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.Net;
using System.Security.Principal;

namespace System.Net.WebSockets
{
    public class HttpListenerWebSocketContext : WebSocketContext
    {
    
        public override Uri RequestUri
        {
            get { throw new NotImplementedException(); }
        }
    
        public override NameValueCollection Headers
        {
            get { throw new NotImplementedException(); }
        }
    
        public override string Origin
        {
            get { throw new NotImplementedException(); }
        }
    
        public override IEnumerable<string> SecWebSocketProtocols
        {
            get { throw new NotImplementedException(); }
        }
    
        public override string SecWebSocketVersion
        {
            get { throw new NotImplementedException(); }
        }
    
        public override string SecWebSocketKey
        {
            get { throw new NotImplementedException(); }
        }
    
        public override CookieCollection CookieCollection
        {
            get { throw new NotImplementedException(); }
        }
    
        public override IPrincipal User
        {
            get { throw new NotImplementedException(); }
        }
    
        public override bool IsAuthenticated
        {
            get { throw new NotImplementedException(); }
        }
    
        public override bool IsLocal
        {
            get { throw new NotImplementedException(); }
        }
    
        public override bool IsSecureConnection
        {
            get { throw new NotImplementedException(); }
        }
    
        public override WebSocket WebSocket
        {
            get { throw new NotImplementedException(); }
        }
    
    
    }
}
