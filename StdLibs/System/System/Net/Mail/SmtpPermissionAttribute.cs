using System;
using System.Security.Permissions;
using System.Security;

namespace System.Net.Mail
{
    [Serializable]
    [AttributeUsageAttribute(AttributeTargets.Assembly|AttributeTargets.Class|AttributeTargets.Struct|AttributeTargets.Constructor|AttributeTargets.Method, AllowMultiple = true, Inherited = false)]
    public sealed class SmtpPermissionAttribute : CodeAccessSecurityAttribute
    {
    
        public string Access
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public SmtpPermissionAttribute(SecurityAction action)
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
