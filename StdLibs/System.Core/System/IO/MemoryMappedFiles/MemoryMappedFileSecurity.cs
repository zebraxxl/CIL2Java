using System.Security.AccessControl;

namespace System.IO.MemoryMappedFiles
{
    public class MemoryMappedFileSecurity : ObjectSecurity<MemoryMappedFileRights>
    {
        public MemoryMappedFileSecurity()
            : base(false, ResourceType.Unknown)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
