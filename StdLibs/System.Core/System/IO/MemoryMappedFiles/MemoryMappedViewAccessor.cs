using System.IO;
using Microsoft.Win32.SafeHandles;
using System.Security;

namespace System.IO.MemoryMappedFiles
{
    public sealed class MemoryMappedViewAccessor : UnmanagedMemoryAccessor
    {
    
        public SafeMemoryMappedViewHandle SafeMemoryMappedViewHandle
        {
            get { throw new NotImplementedException(); }
        }
    
    
        [SecuritySafeCriticalAttribute()]
        protected override void Dispose(bool disposing)
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        public void Flush()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
