using System.IO;
using System;
using System.Threading.Tasks;
using System.Threading;

namespace System.Net.Sockets
{
    public class NetworkStream : Stream
    {
    
        protected Socket Socket
        {
            get { throw new NotImplementedException(); }
        }
    
        protected bool Readable
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        protected bool Writeable
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public override bool CanRead
        {
            get { throw new NotImplementedException(); }
        }
    
        public override bool CanSeek
        {
            get { throw new NotImplementedException(); }
        }
    
        public override bool CanWrite
        {
            get { throw new NotImplementedException(); }
        }
    
        public override bool CanTimeout
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
    
        public virtual bool DataAvailable
        {
            get { throw new NotImplementedException(); }
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
    
    
        public NetworkStream(Socket socket)
        {
             throw new NotImplementedException();
        }
        
        
        public NetworkStream(Socket socket, bool ownsSocket)
        {
             throw new NotImplementedException();
        }
        
        
        public NetworkStream(Socket socket, FileAccess access)
        {
             throw new NotImplementedException();
        }
        
        
        public NetworkStream(Socket socket, FileAccess access, bool ownsSocket)
        {
             throw new NotImplementedException();
        }
        
        
        public override long Seek(long offset, SeekOrigin origin)
        {
             throw new NotImplementedException();
        }
        
        
        public override int Read(byte[] buffer, int offset, int size)
        {
             throw new NotImplementedException();
        }
        
        
        public override void Write(byte[] buffer, int offset, int size)
        {
             throw new NotImplementedException();
        }
        
        
        public void Close(int timeout)
        {
             throw new NotImplementedException();
        }
        
        
        protected override void Dispose(bool disposing)
        {
             throw new NotImplementedException();
        }
        
        
        ~NetworkStream()
        {
             throw new NotImplementedException();
        }
        
        
        public override IAsyncResult BeginRead(byte[] buffer, int offset, int size, AsyncCallback callback, object state)
        {
             throw new NotImplementedException();
        }
        
        
        public override int EndRead(IAsyncResult asyncResult)
        {
             throw new NotImplementedException();
        }
        
        
        public override IAsyncResult BeginWrite(byte[] buffer, int offset, int size, AsyncCallback callback, object state)
        {
             throw new NotImplementedException();
        }
        
        
        public override void EndWrite(IAsyncResult asyncResult)
        {
             throw new NotImplementedException();
        }
        
        
        public override void Flush()
        {
             throw new NotImplementedException();
        }
        
        
        public override Task FlushAsync(CancellationToken cancellationToken)
        {
             throw new NotImplementedException();
        }
        
        
        public override void SetLength(long value)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
