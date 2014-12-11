using System.Security;
using System.Security.Principal;
using System.IO;
using Microsoft.Win32.SafeHandles;

namespace System.IO.Pipes
{
    public sealed class NamedPipeClientStream : PipeStream
    {
    
        public int NumberOfServerInstances
        {
            get { throw new NotImplementedException(); }
        }
    
    
        [SecuritySafeCriticalAttribute()]
        public NamedPipeClientStream(string pipeName)
            : base(PipeDirection.InOut, -1)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public NamedPipeClientStream(string serverName, string pipeName)
            : base(PipeDirection.InOut, -1)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public NamedPipeClientStream(string serverName, string pipeName, PipeDirection direction)
            : base(PipeDirection.InOut, -1)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public NamedPipeClientStream(string serverName, string pipeName, PipeDirection direction, PipeOptions options)
            : base(PipeDirection.InOut, -1)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public NamedPipeClientStream(string serverName, string pipeName, PipeDirection direction, PipeOptions options, TokenImpersonationLevel impersonationLevel)
            : base(PipeDirection.InOut, -1)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public NamedPipeClientStream(string serverName, string pipeName, PipeDirection direction, PipeOptions options, TokenImpersonationLevel impersonationLevel, HandleInheritability inheritability)
            : base(PipeDirection.InOut, -1)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public NamedPipeClientStream(string serverName, string pipeName, PipeAccessRights desiredAccessRights, PipeOptions options, TokenImpersonationLevel impersonationLevel, HandleInheritability inheritability)
            : base(PipeDirection.InOut, -1)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public NamedPipeClientStream(PipeDirection direction, bool isAsync, bool isConnected, SafePipeHandle safePipeHandle)
            : base(PipeDirection.InOut, -1)
        {
             throw new NotImplementedException();
        }
        
        
        ~NamedPipeClientStream()
        {
             throw new NotImplementedException();
        }
        
        
        public void Connect()
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        public void Connect(int timeout)
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        protected override void CheckPipePropertyOperations()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
