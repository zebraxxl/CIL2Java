using System;
using System.Security.Permissions;
using System.Security;

namespace System.Diagnostics
{
    [Serializable]
    [AttributeUsageAttribute(AttributeTargets.Assembly|AttributeTargets.Class|AttributeTargets.Struct|AttributeTargets.Constructor|AttributeTargets.Method|AttributeTargets.Event, AllowMultiple = true, Inherited = false)]
    public class PerformanceCounterPermissionAttribute : CodeAccessSecurityAttribute
    {
    
        public string CategoryName
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public string MachineName
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public PerformanceCounterPermissionAccess PermissionAccess
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public PerformanceCounterPermissionAttribute(SecurityAction action)
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
