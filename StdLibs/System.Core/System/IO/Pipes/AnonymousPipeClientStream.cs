using System.Security;
using Microsoft.Win32.SafeHandles;

namespace System.IO.Pipes
{
    public sealed class AnonymousPipeClientStream : PipeStream
    {
        public override PipeTransmissionMode TransmissionMode
        {
            get { throw new NotImplementedException(); }
        }
    
        public override PipeTransmissionMode ReadMode
        {
            set { throw new NotImplementedException(); }
        }
    
    
        [SecuritySafeCriticalAttribute()]
        public AnonymousPipeClientStream(string pipeHandleAsString)
            : base(PipeDirection.InOut, -1)
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        public AnonymousPipeClientStream(PipeDirection direction, string pipeHandleAsString)
            : base(PipeDirection.InOut, -1)
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        public AnonymousPipeClientStream(PipeDirection direction, SafePipeHandle safePipeHandle)
            : base(PipeDirection.InOut, -1)
        {
             throw new NotImplementedException();
        }
        
        
        ~AnonymousPipeClientStream()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
