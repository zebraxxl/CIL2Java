using System;
using Microsoft.Win32.SafeHandles;
using System.Security;
using System.IO;

namespace System.IO.MemoryMappedFiles
{
    public class MemoryMappedFile : IDisposable
    {
    
        public SafeMemoryMappedFileHandle SafeMemoryMappedFileHandle
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public static MemoryMappedFile OpenExisting(string mapName)
        {
             throw new NotImplementedException();
        }
        
        
        public static MemoryMappedFile OpenExisting(string mapName, MemoryMappedFileRights desiredAccessRights)
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        public static MemoryMappedFile OpenExisting(string mapName, MemoryMappedFileRights desiredAccessRights, HandleInheritability inheritability)
        {
             throw new NotImplementedException();
        }
        
        
        public static MemoryMappedFile CreateFromFile(string path)
        {
             throw new NotImplementedException();
        }
        
        
        public static MemoryMappedFile CreateFromFile(string path, FileMode mode)
        {
             throw new NotImplementedException();
        }
        
        
        public static MemoryMappedFile CreateFromFile(string path, FileMode mode, string mapName)
        {
             throw new NotImplementedException();
        }
        
        
        public static MemoryMappedFile CreateFromFile(string path, FileMode mode, string mapName, long capacity)
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        public static MemoryMappedFile CreateFromFile(string path, FileMode mode, string mapName, long capacity, MemoryMappedFileAccess access)
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        public static MemoryMappedFile CreateFromFile(FileStream fileStream, string mapName, long capacity, MemoryMappedFileAccess access, MemoryMappedFileSecurity memoryMappedFileSecurity, HandleInheritability inheritability, bool leaveOpen)
        {
             throw new NotImplementedException();
        }
        
        
        public static MemoryMappedFile CreateNew(string mapName, long capacity)
        {
             throw new NotImplementedException();
        }
        
        
        public static MemoryMappedFile CreateNew(string mapName, long capacity, MemoryMappedFileAccess access)
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        public static MemoryMappedFile CreateNew(string mapName, long capacity, MemoryMappedFileAccess access, MemoryMappedFileOptions options, MemoryMappedFileSecurity memoryMappedFileSecurity, HandleInheritability inheritability)
        {
             throw new NotImplementedException();
        }
        
        
        public static MemoryMappedFile CreateOrOpen(string mapName, long capacity)
        {
             throw new NotImplementedException();
        }
        
        
        public static MemoryMappedFile CreateOrOpen(string mapName, long capacity, MemoryMappedFileAccess access)
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        public static MemoryMappedFile CreateOrOpen(string mapName, long capacity, MemoryMappedFileAccess access, MemoryMappedFileOptions options, MemoryMappedFileSecurity memoryMappedFileSecurity, HandleInheritability inheritability)
        {
             throw new NotImplementedException();
        }
        
        
        public MemoryMappedViewStream CreateViewStream()
        {
             throw new NotImplementedException();
        }
        
        
        public MemoryMappedViewStream CreateViewStream(long offset, long size)
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        public MemoryMappedViewStream CreateViewStream(long offset, long size, MemoryMappedFileAccess access)
        {
             throw new NotImplementedException();
        }
        
        
        public MemoryMappedViewAccessor CreateViewAccessor()
        {
             throw new NotImplementedException();
        }
        
        
        public MemoryMappedViewAccessor CreateViewAccessor(long offset, long size)
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        public MemoryMappedViewAccessor CreateViewAccessor(long offset, long size, MemoryMappedFileAccess access)
        {
             throw new NotImplementedException();
        }
        
        
        public void Dispose()
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        protected virtual void Dispose(bool disposing)
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        public MemoryMappedFileSecurity GetAccessControl()
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        public void SetAccessControl(MemoryMappedFileSecurity memoryMappedFileSecurity)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
