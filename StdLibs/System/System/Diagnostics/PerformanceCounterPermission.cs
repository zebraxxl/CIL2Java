using System.Security.Permissions;

namespace System.Diagnostics
{
    [Serializable]
    public sealed class PerformanceCounterPermission : ResourcePermissionBase
    {
    
        public PerformanceCounterPermissionEntryCollection PermissionEntries
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public PerformanceCounterPermission()
        {
             throw new NotImplementedException();
        }
        
        
        public PerformanceCounterPermission(PermissionState state)
        {
             throw new NotImplementedException();
        }
        
        
        public PerformanceCounterPermission(PerformanceCounterPermissionAccess permissionAccess, string machineName, string categoryName)
        {
             throw new NotImplementedException();
        }
        
        
        public PerformanceCounterPermission(PerformanceCounterPermissionEntry[] permissionAccessEntries)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
