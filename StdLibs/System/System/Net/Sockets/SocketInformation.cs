using System;
using System.Runtime.Serialization;
using System.Net;

namespace System.Net.Sockets
{
    [Serializable]
    public struct SocketInformation
    {
    
        public byte[] ProtocolInformation
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public SocketInformationOptions Options
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
    }
}
