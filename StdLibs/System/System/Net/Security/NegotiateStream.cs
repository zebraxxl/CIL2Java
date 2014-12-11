using System.Runtime.CompilerServices;
using System.Security.Principal;
using System.IO;
using System.Net;
using System.Security.Authentication.ExtendedProtection;
using System;
using System.Threading.Tasks;

namespace System.Net.Security
{
    public class NegotiateStream : AuthenticatedStream
    {
    
        public override bool IsAuthenticated
        {
            get { throw new NotImplementedException(); }
        }
    
        public override bool IsMutuallyAuthenticated
        {
            get { throw new NotImplementedException(); }
        }
    
        public override bool IsEncrypted
        {
            get { throw new NotImplementedException(); }
        }
    
        public override bool IsSigned
        {
            get { throw new NotImplementedException(); }
        }
    
        public override bool IsServer
        {
            get { throw new NotImplementedException(); }
        }
    
        public virtual TokenImpersonationLevel ImpersonationLevel
        {
            get { throw new NotImplementedException(); }
        }
    
        public virtual IIdentity RemoteIdentity
        {
            get { throw new NotImplementedException(); }
        }
    
        public override bool CanSeek
        {
            get { throw new NotImplementedException(); }
        }
    
        public override bool CanRead
        {
            get { throw new NotImplementedException(); }
        }
    
        public override bool CanTimeout
        {
            get { throw new NotImplementedException(); }
        }
    
        public override bool CanWrite
        {
            get { throw new NotImplementedException(); }
        }
    
        public override int ReadTimeout
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public override int WriteTimeout
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public override long Length
        {
            get { throw new NotImplementedException(); }
        }
    
        public override long Position
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public NegotiateStream(Stream innerStream)
        {
             throw new NotImplementedException();
        }
        
        
        public NegotiateStream(Stream innerStream, bool leaveInnerStreamOpen)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual void AuthenticateAsClient()
        {
             throw new NotImplementedException();
        }
        
        
        public virtual void AuthenticateAsClient(NetworkCredential credential, string targetName)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual void AuthenticateAsClient(NetworkCredential credential, ChannelBinding binding, string targetName)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual void AuthenticateAsClient(NetworkCredential credential, string targetName, ProtectionLevel requiredProtectionLevel, TokenImpersonationLevel allowedImpersonationLevel)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual void AuthenticateAsClient(NetworkCredential credential, ChannelBinding binding, string targetName, ProtectionLevel requiredProtectionLevel, TokenImpersonationLevel allowedImpersonationLevel)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual IAsyncResult BeginAuthenticateAsClient(AsyncCallback asyncCallback, object asyncState)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual IAsyncResult BeginAuthenticateAsClient(NetworkCredential credential, string targetName, AsyncCallback asyncCallback, object asyncState)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual IAsyncResult BeginAuthenticateAsClient(NetworkCredential credential, ChannelBinding binding, string targetName, AsyncCallback asyncCallback, object asyncState)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual IAsyncResult BeginAuthenticateAsClient(NetworkCredential credential, string targetName, ProtectionLevel requiredProtectionLevel, TokenImpersonationLevel allowedImpersonationLevel, AsyncCallback asyncCallback, object asyncState)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual IAsyncResult BeginAuthenticateAsClient(NetworkCredential credential, ChannelBinding binding, string targetName, ProtectionLevel requiredProtectionLevel, TokenImpersonationLevel allowedImpersonationLevel, AsyncCallback asyncCallback, object asyncState)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual void EndAuthenticateAsClient(IAsyncResult asyncResult)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual void AuthenticateAsServer()
        {
             throw new NotImplementedException();
        }
        
        
        public virtual void AuthenticateAsServer(ExtendedProtectionPolicy policy)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual void AuthenticateAsServer(NetworkCredential credential, ProtectionLevel requiredProtectionLevel, TokenImpersonationLevel requiredImpersonationLevel)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual void AuthenticateAsServer(NetworkCredential credential, ExtendedProtectionPolicy policy, ProtectionLevel requiredProtectionLevel, TokenImpersonationLevel requiredImpersonationLevel)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual IAsyncResult BeginAuthenticateAsServer(AsyncCallback asyncCallback, object asyncState)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual IAsyncResult BeginAuthenticateAsServer(ExtendedProtectionPolicy policy, AsyncCallback asyncCallback, object asyncState)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual IAsyncResult BeginAuthenticateAsServer(NetworkCredential credential, ProtectionLevel requiredProtectionLevel, TokenImpersonationLevel requiredImpersonationLevel, AsyncCallback asyncCallback, object asyncState)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual IAsyncResult BeginAuthenticateAsServer(NetworkCredential credential, ExtendedProtectionPolicy policy, ProtectionLevel requiredProtectionLevel, TokenImpersonationLevel requiredImpersonationLevel, AsyncCallback asyncCallback, object asyncState)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual void EndAuthenticateAsServer(IAsyncResult asyncResult)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual Task AuthenticateAsClientAsync()
        {
             throw new NotImplementedException();
        }
        
        
        public virtual Task AuthenticateAsClientAsync(NetworkCredential credential, string targetName)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual Task AuthenticateAsClientAsync(NetworkCredential credential, string targetName, ProtectionLevel requiredProtectionLevel, TokenImpersonationLevel allowedImpersonationLevel)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual Task AuthenticateAsClientAsync(NetworkCredential credential, ChannelBinding binding, string targetName)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual Task AuthenticateAsClientAsync(NetworkCredential credential, ChannelBinding binding, string targetName, ProtectionLevel requiredProtectionLevel, TokenImpersonationLevel allowedImpersonationLevel)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual Task AuthenticateAsServerAsync()
        {
             throw new NotImplementedException();
        }
        
        
        public virtual Task AuthenticateAsServerAsync(ExtendedProtectionPolicy policy)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual Task AuthenticateAsServerAsync(NetworkCredential credential, ProtectionLevel requiredProtectionLevel, TokenImpersonationLevel requiredImpersonationLevel)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual Task AuthenticateAsServerAsync(NetworkCredential credential, ExtendedProtectionPolicy policy, ProtectionLevel requiredProtectionLevel, TokenImpersonationLevel requiredImpersonationLevel)
        {
             throw new NotImplementedException();
        }
        
        
        public override void SetLength(long value)
        {
             throw new NotImplementedException();
        }
        
        
        public override long Seek(long offset, SeekOrigin origin)
        {
             throw new NotImplementedException();
        }
        
        
        public override void Flush()
        {
             throw new NotImplementedException();
        }
        
        
        protected override void Dispose(bool disposing)
        {
             throw new NotImplementedException();
        }
        
        
        public override int Read(byte[] buffer, int offset, int count)
        {
             throw new NotImplementedException();
        }
        
        
        public override void Write(byte[] buffer, int offset, int count)
        {
             throw new NotImplementedException();
        }
        
        
        public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback asyncCallback, object asyncState)
        {
             throw new NotImplementedException();
        }
        
        
        public override int EndRead(IAsyncResult asyncResult)
        {
             throw new NotImplementedException();
        }
        
        
        public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback asyncCallback, object asyncState)
        {
             throw new NotImplementedException();
        }
        
        
        public override void EndWrite(IAsyncResult asyncResult)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
