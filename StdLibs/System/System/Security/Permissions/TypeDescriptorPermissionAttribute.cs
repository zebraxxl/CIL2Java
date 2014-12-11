using System;
using System.Security;

namespace System.Security.Permissions
{
    [Serializable]
    [AttributeUsageAttribute(AttributeTargets.Assembly|AttributeTargets.Class|AttributeTargets.Struct|AttributeTargets.Constructor|AttributeTargets.Method, AllowMultiple = true, Inherited = false)]
    public sealed class TypeDescriptorPermissionAttribute : CodeAccessSecurityAttribute
    {
    
        public TypeDescriptorPermissionFlags Flags
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public bool RestrictedRegistrationAccess
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public TypeDescriptorPermissionAttribute(SecurityAction action)
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
