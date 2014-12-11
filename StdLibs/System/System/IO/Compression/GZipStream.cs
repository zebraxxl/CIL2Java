using System.IO;
using System;

namespace System.IO.Compression
{
    public class GZipStream : Stream
    {
    
        public override bool CanRead
        {
            get { throw new NotImplementedException(); }
        }
    
        public override bool CanWrite
        {
            get { throw new NotImplementedException(); }
        }
    
        public override bool CanSeek
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
    
        public Stream BaseStream
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public GZipStream(Stream stream, CompressionMode mode)
        {
             throw new NotImplementedException();
        }
        
        
        public GZipStream(Stream stream, CompressionMode mode, bool leaveOpen)
        {
             throw new NotImplementedException();
        }
        
        
        public GZipStream(Stream stream, CompressionLevel compressionLevel)
        {
             throw new NotImplementedException();
        }
        
        
        public GZipStream(Stream stream, CompressionLevel compressionLevel, bool leaveOpen)
        {
             throw new NotImplementedException();
        }
        
        
        public override void Flush()
        {
             throw new NotImplementedException();
        }
        
        
        public override long Seek(long offset, SeekOrigin origin)
        {
             throw new NotImplementedException();
        }
        
        
        public override void SetLength(long value)
        {
             throw new NotImplementedException();
        }
        
        
        public override IAsyncResult BeginRead(byte[] array, int offset, int count, AsyncCallback asyncCallback, object asyncState)
        {
             throw new NotImplementedException();
        }
        
        
        public override int EndRead(IAsyncResult asyncResult)
        {
             throw new NotImplementedException();
        }
        
        
        public override IAsyncResult BeginWrite(byte[] array, int offset, int count, AsyncCallback asyncCallback, object asyncState)
        {
             throw new NotImplementedException();
        }
        
        
        public override void EndWrite(IAsyncResult asyncResult)
        {
             throw new NotImplementedException();
        }
        
        
        public override int Read(byte[] array, int offset, int count)
        {
             throw new NotImplementedException();
        }
        
        
        public override void Write(byte[] array, int offset, int count)
        {
             throw new NotImplementedException();
        }
        
        
        protected override void Dispose(bool disposing)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
