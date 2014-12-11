using System.Runtime.CompilerServices;
using System.Net;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using System.IO;
using System;
using System.Threading.Tasks;

namespace System.Net.Security
{
    public class SslStream : AuthenticatedStream
    {
    
        public TransportContext TransportContext
        {
            get { throw new NotImplementedException(); }
        }
    
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
    
        public virtual SslProtocols SslProtocol
        {
            get { throw new NotImplementedException(); }
        }
    
        public virtual bool CheckCertRevocationStatus
        {
            get { throw new NotImplementedException(); }
        }
    
        public virtual X509Certificate LocalCertificate
        {
            get { throw new NotImplementedException(); }
        }
    
        public virtual X509Certificate RemoteCertificate
        {
            get { throw new NotImplementedException(); }
        }
    
        public virtual CipherAlgorithmType CipherAlgorithm
        {
            get { throw new NotImplementedException(); }
        }
    
        public virtual int CipherStrength
        {
            get { throw new NotImplementedException(); }
        }
    
        public virtual HashAlgorithmType HashAlgorithm
        {
            get { throw new NotImplementedException(); }
        }
    
        public virtual int HashStrength
        {
            get { throw new NotImplementedException(); }
        }
    
        public virtual ExchangeAlgorithmType KeyExchangeAlgorithm
        {
            get { throw new NotImplementedException(); }
        }
    
        public virtual int KeyExchangeStrength
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
    
    
        public SslStream(Stream innerStream)
        {
             throw new NotImplementedException();
        }
        
        
        public SslStream(Stream innerStream, bool leaveInnerStreamOpen)
        {
             throw new NotImplementedException();
        }
        
        
        public SslStream(Stream innerStream, bool leaveInnerStreamOpen, RemoteCertificateValidationCallback userCertificateValidationCallback)
        {
             throw new NotImplementedException();
        }
        
        
        public SslStream(Stream innerStream, bool leaveInnerStreamOpen, RemoteCertificateValidationCallback userCertificateValidationCallback, LocalCertificateSelectionCallback userCertificateSelectionCallback)
        {
             throw new NotImplementedException();
        }
        
        
        public SslStream(Stream innerStream, bool leaveInnerStreamOpen, RemoteCertificateValidationCallback userCertificateValidationCallback, LocalCertificateSelectionCallback userCertificateSelectionCallback, EncryptionPolicy encryptionPolicy)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual void AuthenticateAsClient(string targetHost)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual void AuthenticateAsClient(string targetHost, X509CertificateCollection clientCertificates, SslProtocols enabledSslProtocols, bool checkCertificateRevocation)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual IAsyncResult BeginAuthenticateAsClient(string targetHost, AsyncCallback asyncCallback, object asyncState)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual IAsyncResult BeginAuthenticateAsClient(string targetHost, X509CertificateCollection clientCertificates, SslProtocols enabledSslProtocols, bool checkCertificateRevocation, AsyncCallback asyncCallback, object asyncState)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual void EndAuthenticateAsClient(IAsyncResult asyncResult)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual void AuthenticateAsServer(X509Certificate serverCertificate)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual void AuthenticateAsServer(X509Certificate serverCertificate, bool clientCertificateRequired, SslProtocols enabledSslProtocols, bool checkCertificateRevocation)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual IAsyncResult BeginAuthenticateAsServer(X509Certificate serverCertificate, AsyncCallback asyncCallback, object asyncState)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual IAsyncResult BeginAuthenticateAsServer(X509Certificate serverCertificate, bool clientCertificateRequired, SslProtocols enabledSslProtocols, bool checkCertificateRevocation, AsyncCallback asyncCallback, object asyncState)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual void EndAuthenticateAsServer(IAsyncResult asyncResult)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual Task AuthenticateAsClientAsync(string targetHost)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual Task AuthenticateAsClientAsync(string targetHost, X509CertificateCollection clientCertificates, SslProtocols enabledSslProtocols, bool checkCertificateRevocation)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual Task AuthenticateAsServerAsync(X509Certificate serverCertificate)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual Task AuthenticateAsServerAsync(X509Certificate serverCertificate, bool clientCertificateRequired, SslProtocols enabledSslProtocols, bool checkCertificateRevocation)
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
        
        
        public void Write(byte[] buffer)
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
