using System.Security;
using System.IO;
using Microsoft.Win32.SafeHandles;
using System;

namespace System.IO.Pipes
{
    public sealed class NamedPipeServerStream : PipeStream
    {
        public const int MaxAllowedServerInstances = -1;
    
        [SecuritySafeCriticalAttribute()]
        public NamedPipeServerStream(string pipeName)
            : base(PipeDirection.InOut, -1)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public NamedPipeServerStream(string pipeName, PipeDirection direction)
            : base(PipeDirection.InOut, -1)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public NamedPipeServerStream(string pipeName, PipeDirection direction, int maxNumberOfServerInstances)
            : base(PipeDirection.InOut, -1)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public NamedPipeServerStream(string pipeName, PipeDirection direction, int maxNumberOfServerInstances, PipeTransmissionMode transmissionMode)
            : base(PipeDirection.InOut, -1)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public NamedPipeServerStream(string pipeName, PipeDirection direction, int maxNumberOfServerInstances, PipeTransmissionMode transmissionMode, PipeOptions options)
            : base(PipeDirection.InOut, -1)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public NamedPipeServerStream(string pipeName, PipeDirection direction, int maxNumberOfServerInstances, PipeTransmissionMode transmissionMode, PipeOptions options, int inBufferSize, int outBufferSize)
            : base(PipeDirection.InOut, -1)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public NamedPipeServerStream(string pipeName, PipeDirection direction, int maxNumberOfServerInstances, PipeTransmissionMode transmissionMode, PipeOptions options, int inBufferSize, int outBufferSize, PipeSecurity pipeSecurity)
            : base(PipeDirection.InOut, -1)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public NamedPipeServerStream(string pipeName, PipeDirection direction, int maxNumberOfServerInstances, PipeTransmissionMode transmissionMode, PipeOptions options, int inBufferSize, int outBufferSize, PipeSecurity pipeSecurity, HandleInheritability inheritability)
            : base(PipeDirection.InOut, -1)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public NamedPipeServerStream(string pipeName, PipeDirection direction, int maxNumberOfServerInstances, PipeTransmissionMode transmissionMode, PipeOptions options, int inBufferSize, int outBufferSize, PipeSecurity pipeSecurity, HandleInheritability inheritability, PipeAccessRights additionalAccessRights)
            : base(PipeDirection.InOut, -1)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public NamedPipeServerStream(PipeDirection direction, bool isAsync, bool isConnected, SafePipeHandle safePipeHandle)
            : base(PipeDirection.InOut, -1)
        {
             throw new NotImplementedException();
        }
        
        
        ~NamedPipeServerStream()
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        public void WaitForConnection()
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        public IAsyncResult BeginWaitForConnection(AsyncCallback callback, object state)
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        public void EndWaitForConnection(IAsyncResult asyncResult)
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        public void Disconnect()
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        public void RunAsClient(PipeStreamImpersonationWorker impersonationWorker)
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        public string GetImpersonationUserName()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
