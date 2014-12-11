using System.IO;
using Microsoft.Win32.SafeHandles;
using System.Security;

namespace System.IO.MemoryMappedFiles
{
    public sealed class MemoryMappedViewStream : UnmanagedMemoryStream
    {
    
        public SafeMemoryMappedViewHandle SafeMemoryMappedViewHandle
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public override void SetLength(long value)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        protected override void Dispose(bool disposing)
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        public override void Flush()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
