using System;
using System.Security.Permissions;
using System.Security;

namespace System.Diagnostics
{
    [Serializable]
    [AttributeUsageAttribute(AttributeTargets.Assembly|AttributeTargets.Class|AttributeTargets.Struct|AttributeTargets.Constructor|AttributeTargets.Method|AttributeTargets.Event, AllowMultiple = true, Inherited = false)]
    public class EventLogPermissionAttribute : CodeAccessSecurityAttribute
    {
    
        public string MachineName
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public EventLogPermissionAccess PermissionAccess
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public EventLogPermissionAttribute(SecurityAction action)
            : base(action)
        {
             throw new NotImplementedException();
        }
        
        
        public override IPermission CreatePermission()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
