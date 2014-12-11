using System.IO;
using System.Security;
using Microsoft.Win32.SafeHandles;
using System;

namespace System.IO.Pipes
{
    public abstract class PipeStream : Stream
    {
    
        public bool IsConnected
        {
            get { throw new NotImplementedException(); }
            protected set { throw new NotImplementedException(); }
        }
    
        public bool IsAsync
        {
            get { throw new NotImplementedException(); }
        }
    
        public bool IsMessageComplete
        {
            get { throw new NotImplementedException(); }
        }
    
        public virtual PipeTransmissionMode TransmissionMode
        {
            get { throw new NotImplementedException(); }
        }
    
        public virtual int InBufferSize
        {
            get { throw new NotImplementedException(); }
        }
    
        public virtual int OutBufferSize
        {
            get { throw new NotImplementedException(); }
        }
    
        public virtual PipeTransmissionMode ReadMode
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public SafePipeHandle SafePipeHandle
        {
            get { throw new NotImplementedException(); }
        }
    
        protected bool IsHandleExposed
        {
            get { throw new NotImplementedException(); }
        }
    
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
    
    
        protected PipeStream(PipeDirection direction, int bufferSize)
        {
             throw new NotImplementedException();
        }
        
        
        protected PipeStream(PipeDirection direction, PipeTransmissionMode transmissionMode, int outBufferSize)
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        protected void InitializeHandle(SafePipeHandle handle, bool isExposed, bool isAsync)
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        public override int Read(byte[] buffer, int offset, int count)
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        public override int EndRead(IAsyncResult asyncResult)
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        public override void Write(byte[] buffer, int offset, int count)
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        public override void EndWrite(IAsyncResult asyncResult)
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        public override int ReadByte()
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        public override void WriteByte(byte value)
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        public override void Flush()
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        public void WaitForPipeDrain()
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        protected override void Dispose(bool disposing)
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        public PipeSecurity GetAccessControl()
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        public void SetAccessControl(PipeSecurity pipeSecurity)
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
        
        
        [SecurityCriticalAttribute()]
        protected virtual void CheckPipePropertyOperations()
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        protected void CheckReadOperations()
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        protected void CheckWriteOperations()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
