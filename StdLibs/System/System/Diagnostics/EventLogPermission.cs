using System.Security.Permissions;

namespace System.Diagnostics
{
    [Serializable]
    public sealed class EventLogPermission : ResourcePermissionBase
    {
    
        public EventLogPermissionEntryCollection PermissionEntries
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public EventLogPermission()
        {
             throw new NotImplementedException();
        }
        
        
        public EventLogPermission(PermissionState state)
        {
             throw new NotImplementedException();
        }
        
        
        public EventLogPermission(EventLogPermissionAccess permissionAccess, string machineName)
        {
             throw new NotImplementedException();
        }
        
        
        public EventLogPermission(EventLogPermissionEntry[] permissionAccessEntries)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
