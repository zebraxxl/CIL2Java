using System;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Collections.Generic;
using System.Net;

namespace System.Net.Sockets
{
    public class SocketAsyncEventArgs : EventArgs, IDisposable
    {
    
        public event EventHandler<SocketAsyncEventArgs> Completed;
    
    
        [ObsoleteAttribute("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public SocketClientAccessPolicyProtocol SocketClientAccessPolicyProtocol
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public Socket AcceptSocket
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public Socket ConnectSocket
        {
            get { throw new NotImplementedException(); }
        }
    
        public byte[] Buffer
        {
            get { throw new NotImplementedException(); }
        }
    
        public int Offset
        {
            get { throw new NotImplementedException(); }
        }
    
        public int Count
        {
            get { throw new NotImplementedException(); }
        }
    
        public IList<ArraySegment<byte>> BufferList
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public int BytesTransferred
        {
            get { throw new NotImplementedException(); }
        }
    
        public bool DisconnectReuseSocket
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public SocketAsyncOperation LastOperation
        {
            get { throw new NotImplementedException(); }
        }
    
        public IPPacketInformation ReceiveMessageFromPacketInfo
        {
            get { throw new NotImplementedException(); }
        }
    
        public EndPoint RemoteEndPoint
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public SendPacketsElement[] SendPacketsElements
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public TransmitFileOptions SendPacketsFlags
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public int SendPacketsSendSize
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public SocketError SocketError
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public Exception ConnectByNameError
        {
            get { throw new NotImplementedException(); }
        }
    
        public SocketFlags SocketFlags
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public object UserToken
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public SocketAsyncEventArgs()
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual void OnCompleted(SocketAsyncEventArgs e)
        {
             throw new NotImplementedException();
        }
        
        
        public void SetBuffer(byte[] buffer, int offset, int count)
        {
             throw new NotImplementedException();
        }
        
        
        public void SetBuffer(int offset, int count)
        {
             throw new NotImplementedException();
        }
        
        
        public void Dispose()
        {
             throw new NotImplementedException();
        }
        
        
        ~SocketAsyncEventArgs()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
