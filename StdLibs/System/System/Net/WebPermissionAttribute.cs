using System;
using System.Security.Permissions;
using System.Security;

namespace System.Net
{
    [Serializable]
    [AttributeUsageAttribute(AttributeTargets.Assembly|AttributeTargets.Class|AttributeTargets.Struct|AttributeTargets.Constructor|AttributeTargets.Method, AllowMultiple = true, Inherited = false)]
    public sealed class WebPermissionAttribute : CodeAccessSecurityAttribute
    {
    
        public string Connect
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public string Accept
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public string ConnectPattern
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public string AcceptPattern
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public WebPermissionAttribute(SecurityAction action)
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
