using Microsoft.Win32.SafeHandles;
using System.Security;
using System.IO;

namespace System.IO.Pipes
{
    public sealed class AnonymousPipeServerStream : PipeStream
    {
    
        public SafePipeHandle ClientSafePipeHandle
        {
            get { throw new NotImplementedException(); }
        }
    
        public override PipeTransmissionMode TransmissionMode
        {
            get { throw new NotImplementedException(); }
        }
    
        public override PipeTransmissionMode ReadMode
        {
            set { throw new NotImplementedException(); }
        }
    
    
        [SecuritySafeCriticalAttribute()]
        public AnonymousPipeServerStream()
            : base(PipeDirection.InOut, -1)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public AnonymousPipeServerStream(PipeDirection direction)
            : base(PipeDirection.InOut, -1)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public AnonymousPipeServerStream(PipeDirection direction, HandleInheritability inheritability)
            : base(PipeDirection.InOut, -1)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public AnonymousPipeServerStream(PipeDirection direction, HandleInheritability inheritability, int bufferSize)
            : base(PipeDirection.InOut, -1)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public AnonymousPipeServerStream(PipeDirection direction, HandleInheritability inheritability, int bufferSize, PipeSecurity pipeSecurity)
            : base(PipeDirection.InOut, -1)
        {
             throw new NotImplementedException();
        }
        
        
        ~AnonymousPipeServerStream()
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public AnonymousPipeServerStream(PipeDirection direction, SafePipeHandle serverSafePipeHandle, SafePipeHandle clientSafePipeHandle)
            : base(PipeDirection.InOut, -1)
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        public string GetClientHandleAsString()
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        public void DisposeLocalCopyOfClientHandle()
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        protected override void Dispose(bool disposing)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
