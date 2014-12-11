using System;
using System.Security.Permissions;
using System.Security;

namespace System.Web
{
    [Serializable]
    [AttributeUsageAttribute(AttributeTargets.All, AllowMultiple = true, Inherited = false)]
    public sealed class AspNetHostingPermissionAttribute : CodeAccessSecurityAttribute
    {
    
        public AspNetHostingPermissionLevel Level
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public AspNetHostingPermissionAttribute(SecurityAction action)
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
