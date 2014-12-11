using System;
using System.Net;
using System.Collections.Generic;
using System.Collections;

namespace System.Net.Sockets
{
    public class Socket : IDisposable
    {
    
        [ObsoleteAttribute("SupportsIPv4 is obsoleted for this type, please use OSSupportsIPv4 instead. http://go.microsoft.com/fwlink/?linkid=14202")]
        public static bool SupportsIPv4
        {
            get { throw new NotImplementedException(); }
        }
    
        public static bool OSSupportsIPv4
        {
            get { throw new NotImplementedException(); }
        }
    
        [ObsoleteAttribute("SupportsIPv6 is obsoleted for this type, please use OSSupportsIPv6 instead. http://go.microsoft.com/fwlink/?linkid=14202")]
        public static bool SupportsIPv6
        {
            get { throw new NotImplementedException(); }
        }
    
        public static bool OSSupportsIPv6
        {
            get { throw new NotImplementedException(); }
        }
    
        public int Available
        {
            get { throw new NotImplementedException(); }
        }
    
        public EndPoint LocalEndPoint
        {
            get { throw new NotImplementedException(); }
        }
    
        public EndPoint RemoteEndPoint
        {
            get { throw new NotImplementedException(); }
        }
    
        public IntPtr Handle
        {
            get { throw new NotImplementedException(); }
        }
    
        public bool Blocking
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public bool UseOnlyOverlappedIO
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public bool Connected
        {
            get { throw new NotImplementedException(); }
        }
    
        public AddressFamily AddressFamily
        {
            get { throw new NotImplementedException(); }
        }
    
        public SocketType SocketType
        {
            get { throw new NotImplementedException(); }
        }
    
        public ProtocolType ProtocolType
        {
            get { throw new NotImplementedException(); }
        }
    
        public bool IsBound
        {
            get { throw new NotImplementedException(); }
        }
    
        public bool ExclusiveAddressUse
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public int ReceiveBufferSize
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public int SendBufferSize
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public int ReceiveTimeout
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public int SendTimeout
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public LingerOption LingerState
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public bool NoDelay
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public short Ttl
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public bool DontFragment
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public bool MulticastLoopback
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public bool EnableBroadcast
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public bool DualMode
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public Socket(SocketType socketType, ProtocolType protocolType)
        {
             throw new NotImplementedException();
        }
        
        
        public Socket(AddressFamily addressFamily, SocketType socketType, ProtocolType protocolType)
        {
             throw new NotImplementedException();
        }
        
        
        public Socket(SocketInformation socketInformation)
        {
             throw new NotImplementedException();
        }
        
        
        public void Bind(EndPoint localEP)
        {
             throw new NotImplementedException();
        }
        
        
        public void Connect(EndPoint remoteEP)
        {
             throw new NotImplementedException();
        }
        
        
        public void Connect(IPAddress address, int port)
        {
             throw new NotImplementedException();
        }
        
        
        public void Connect(string host, int port)
        {
             throw new NotImplementedException();
        }
        
        
        public void Connect(IPAddress[] addresses, int port)
        {
             throw new NotImplementedException();
        }
        
        
        public void Close()
        {
             throw new NotImplementedException();
        }
        
        
        public void Close(int timeout)
        {
             throw new NotImplementedException();
        }
        
        
        public void Listen(int backlog)
        {
             throw new NotImplementedException();
        }
        
        
        public Socket Accept()
        {
             throw new NotImplementedException();
        }
        
        
        public int Send(byte[] buffer, int size, SocketFlags socketFlags)
        {
             throw new NotImplementedException();
        }
        
        
        public int Send(byte[] buffer, SocketFlags socketFlags)
        {
             throw new NotImplementedException();
        }
        
        
        public int Send(byte[] buffer)
        {
             throw new NotImplementedException();
        }
        
        
        public int Send(IList<ArraySegment<byte>> buffers)
        {
             throw new NotImplementedException();
        }
        
        
        public int Send(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags)
        {
             throw new NotImplementedException();
        }
        
        
        public int Send(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags, ref SocketError errorCode)
        {
             throw new NotImplementedException();
        }
        
        
        public void SendFile(string fileName)
        {
             throw new NotImplementedException();
        }
        
        
        public void SendFile(string fileName, byte[] preBuffer, byte[] postBuffer, TransmitFileOptions flags)
        {
             throw new NotImplementedException();
        }
        
        
        public int Send(byte[] buffer, int offset, int size, SocketFlags socketFlags)
        {
             throw new NotImplementedException();
        }
        
        
        public int Send(byte[] buffer, int offset, int size, SocketFlags socketFlags, ref SocketError errorCode)
        {
             throw new NotImplementedException();
        }
        
        
        public int SendTo(byte[] buffer, int offset, int size, SocketFlags socketFlags, EndPoint remoteEP)
        {
             throw new NotImplementedException();
        }
        
        
        public int SendTo(byte[] buffer, int size, SocketFlags socketFlags, EndPoint remoteEP)
        {
             throw new NotImplementedException();
        }
        
        
        public int SendTo(byte[] buffer, SocketFlags socketFlags, EndPoint remoteEP)
        {
             throw new NotImplementedException();
        }
        
        
        public int SendTo(byte[] buffer, EndPoint remoteEP)
        {
             throw new NotImplementedException();
        }
        
        
        public int Receive(byte[] buffer, int size, SocketFlags socketFlags)
        {
             throw new NotImplementedException();
        }
        
        
        public int Receive(byte[] buffer, SocketFlags socketFlags)
        {
             throw new NotImplementedException();
        }
        
        
        public int Receive(byte[] buffer)
        {
             throw new NotImplementedException();
        }
        
        
        public int Receive(byte[] buffer, int offset, int size, SocketFlags socketFlags)
        {
             throw new NotImplementedException();
        }
        
        
        public int Receive(byte[] buffer, int offset, int size, SocketFlags socketFlags, ref SocketError errorCode)
        {
             throw new NotImplementedException();
        }
        
        
        public int Receive(IList<ArraySegment<byte>> buffers)
        {
             throw new NotImplementedException();
        }
        
        
        public int Receive(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags)
        {
             throw new NotImplementedException();
        }
        
        
        public int Receive(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags, ref SocketError errorCode)
        {
             throw new NotImplementedException();
        }
        
        
        public int ReceiveMessageFrom(byte[] buffer, int offset, int size, ref SocketFlags socketFlags, ref EndPoint remoteEP, ref IPPacketInformation ipPacketInformation)
        {
             throw new NotImplementedException();
        }
        
        
        public int ReceiveFrom(byte[] buffer, int offset, int size, SocketFlags socketFlags, ref EndPoint remoteEP)
        {
             throw new NotImplementedException();
        }
        
        
        public int ReceiveFrom(byte[] buffer, int size, SocketFlags socketFlags, ref EndPoint remoteEP)
        {
             throw new NotImplementedException();
        }
        
        
        public int ReceiveFrom(byte[] buffer, SocketFlags socketFlags, ref EndPoint remoteEP)
        {
             throw new NotImplementedException();
        }
        
        
        public int ReceiveFrom(byte[] buffer, ref EndPoint remoteEP)
        {
             throw new NotImplementedException();
        }
        
        
        public int IOControl(int ioControlCode, byte[] optionInValue, byte[] optionOutValue)
        {
             throw new NotImplementedException();
        }
        
        
        public int IOControl(IOControlCode ioControlCode, byte[] optionInValue, byte[] optionOutValue)
        {
             throw new NotImplementedException();
        }
        
        
        public void SetIPProtectionLevel(IPProtectionLevel level)
        {
             throw new NotImplementedException();
        }
        
        
        public void SetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, int optionValue)
        {
             throw new NotImplementedException();
        }
        
        
        public void SetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, byte[] optionValue)
        {
             throw new NotImplementedException();
        }
        
        
        public void SetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, bool optionValue)
        {
             throw new NotImplementedException();
        }
        
        
        public void SetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, object optionValue)
        {
             throw new NotImplementedException();
        }
        
        
        public object GetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName)
        {
             throw new NotImplementedException();
        }
        
        
        public void GetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, byte[] optionValue)
        {
             throw new NotImplementedException();
        }
        
        
        public byte[] GetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, int optionLength)
        {
             throw new NotImplementedException();
        }
        
        
        public bool Poll(int microSeconds, SelectMode mode)
        {
             throw new NotImplementedException();
        }
        
        
        public static void Select(IList checkRead, IList checkWrite, IList checkError, int microSeconds)
        {
             throw new NotImplementedException();
        }
        
        
        public IAsyncResult BeginSendFile(string fileName, AsyncCallback callback, object state)
        {
             throw new NotImplementedException();
        }
        
        
        public IAsyncResult BeginConnect(EndPoint remoteEP, AsyncCallback callback, object state)
        {
             throw new NotImplementedException();
        }
        
        
        public SocketInformation DuplicateAndClose(int targetProcessId)
        {
             throw new NotImplementedException();
        }
        
        
        public IAsyncResult BeginConnect(string host, int port, AsyncCallback requestCallback, object state)
        {
             throw new NotImplementedException();
        }
        
        
        public IAsyncResult BeginConnect(IPAddress address, int port, AsyncCallback requestCallback, object state)
        {
             throw new NotImplementedException();
        }
        
        
        public IAsyncResult BeginConnect(IPAddress[] addresses, int port, AsyncCallback requestCallback, object state)
        {
             throw new NotImplementedException();
        }
        
        
        public IAsyncResult BeginDisconnect(bool reuseSocket, AsyncCallback callback, object state)
        {
             throw new NotImplementedException();
        }
        
        
        public void Disconnect(bool reuseSocket)
        {
             throw new NotImplementedException();
        }
        
        
        public void EndConnect(IAsyncResult asyncResult)
        {
             throw new NotImplementedException();
        }
        
        
        public void EndDisconnect(IAsyncResult asyncResult)
        {
             throw new NotImplementedException();
        }
        
        
        public IAsyncResult BeginSend(byte[] buffer, int offset, int size, SocketFlags socketFlags, AsyncCallback callback, object state)
        {
             throw new NotImplementedException();
        }
        
        
        public IAsyncResult BeginSend(byte[] buffer, int offset, int size, SocketFlags socketFlags, ref SocketError errorCode, AsyncCallback callback, object state)
        {
             throw new NotImplementedException();
        }
        
        
        public IAsyncResult BeginSendFile(string fileName, byte[] preBuffer, byte[] postBuffer, TransmitFileOptions flags, AsyncCallback callback, object state)
        {
             throw new NotImplementedException();
        }
        
        
        public IAsyncResult BeginSend(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags, AsyncCallback callback, object state)
        {
             throw new NotImplementedException();
        }
        
        
        public IAsyncResult BeginSend(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags, ref SocketError errorCode, AsyncCallback callback, object state)
        {
             throw new NotImplementedException();
        }
        
        
        public int EndSend(IAsyncResult asyncResult)
        {
             throw new NotImplementedException();
        }
        
        
        public int EndSend(IAsyncResult asyncResult, ref SocketError errorCode)
        {
             throw new NotImplementedException();
        }
        
        
        public void EndSendFile(IAsyncResult asyncResult)
        {
             throw new NotImplementedException();
        }
        
        
        public IAsyncResult BeginSendTo(byte[] buffer, int offset, int size, SocketFlags socketFlags, EndPoint remoteEP, AsyncCallback callback, object state)
        {
             throw new NotImplementedException();
        }
        
        
        public int EndSendTo(IAsyncResult asyncResult)
        {
             throw new NotImplementedException();
        }
        
        
        public IAsyncResult BeginReceive(byte[] buffer, int offset, int size, SocketFlags socketFlags, AsyncCallback callback, object state)
        {
             throw new NotImplementedException();
        }
        
        
        public IAsyncResult BeginReceive(byte[] buffer, int offset, int size, SocketFlags socketFlags, ref SocketError errorCode, AsyncCallback callback, object state)
        {
             throw new NotImplementedException();
        }
        
        
        public IAsyncResult BeginReceive(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags, AsyncCallback callback, object state)
        {
             throw new NotImplementedException();
        }
        
        
        public IAsyncResult BeginReceive(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags, ref SocketError errorCode, AsyncCallback callback, object state)
        {
             throw new NotImplementedException();
        }
        
        
        public int EndReceive(IAsyncResult asyncResult)
        {
             throw new NotImplementedException();
        }
        
        
        public int EndReceive(IAsyncResult asyncResult, ref SocketError errorCode)
        {
             throw new NotImplementedException();
        }
        
        
        public IAsyncResult BeginReceiveMessageFrom(byte[] buffer, int offset, int size, SocketFlags socketFlags, ref EndPoint remoteEP, AsyncCallback callback, object state)
        {
             throw new NotImplementedException();
        }
        
        
        public int EndReceiveMessageFrom(IAsyncResult asyncResult, ref SocketFlags socketFlags, ref EndPoint endPoint, ref IPPacketInformation ipPacketInformation)
        {
             throw new NotImplementedException();
        }
        
        
        public IAsyncResult BeginReceiveFrom(byte[] buffer, int offset, int size, SocketFlags socketFlags, ref EndPoint remoteEP, AsyncCallback callback, object state)
        {
             throw new NotImplementedException();
        }
        
        
        public int EndReceiveFrom(IAsyncResult asyncResult, ref EndPoint endPoint)
        {
             throw new NotImplementedException();
        }
        
        
        public IAsyncResult BeginAccept(AsyncCallback callback, object state)
        {
             throw new NotImplementedException();
        }
        
        
        public IAsyncResult BeginAccept(int receiveSize, AsyncCallback callback, object state)
        {
             throw new NotImplementedException();
        }
        
        
        public IAsyncResult BeginAccept(Socket acceptSocket, int receiveSize, AsyncCallback callback, object state)
        {
             throw new NotImplementedException();
        }
        
        
        public Socket EndAccept(IAsyncResult asyncResult)
        {
             throw new NotImplementedException();
        }
        
        
        public Socket EndAccept(ref byte buffer, IAsyncResult asyncResult)
        {
             throw new NotImplementedException();
        }
        
        
        public Socket EndAccept(ref byte buffer, ref int bytesTransferred, IAsyncResult asyncResult)
        {
             throw new NotImplementedException();
        }
        
        
        public void Shutdown(SocketShutdown how)
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual void Dispose(bool disposing)
        {
             throw new NotImplementedException();
        }
        
        
        public void Dispose()
        {
             throw new NotImplementedException();
        }
        
        
        ~Socket()
        {
             throw new NotImplementedException();
        }
        
        
        public bool AcceptAsync(SocketAsyncEventArgs e)
        {
             throw new NotImplementedException();
        }
        
        
        public bool ConnectAsync(SocketAsyncEventArgs e)
        {
             throw new NotImplementedException();
        }
        
        
        public static bool ConnectAsync(SocketType socketType, ProtocolType protocolType, SocketAsyncEventArgs e)
        {
             throw new NotImplementedException();
        }
        
        
        public static void CancelConnectAsync(SocketAsyncEventArgs e)
        {
             throw new NotImplementedException();
        }
        
        
        public bool DisconnectAsync(SocketAsyncEventArgs e)
        {
             throw new NotImplementedException();
        }
        
        
        public bool ReceiveAsync(SocketAsyncEventArgs e)
        {
             throw new NotImplementedException();
        }
        
        
        public bool ReceiveFromAsync(SocketAsyncEventArgs e)
        {
             throw new NotImplementedException();
        }
        
        
        public bool ReceiveMessageFromAsync(SocketAsyncEventArgs e)
        {
             throw new NotImplementedException();
        }
        
        
        public bool SendAsync(SocketAsyncEventArgs e)
        {
             throw new NotImplementedException();
        }
        
        
        public bool SendPacketsAsync(SocketAsyncEventArgs e)
        {
             throw new NotImplementedException();
        }
        
        
        public bool SendToAsync(SocketAsyncEventArgs e)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
