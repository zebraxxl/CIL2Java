using System.Security;
using System.Security.Permissions;

namespace System.Web
{
    [Serializable]
    public sealed class AspNetHostingPermission : CodeAccessPermission, IUnrestrictedPermission
    {
    
        public AspNetHostingPermissionLevel Level
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public AspNetHostingPermission(PermissionState state)
        {
             throw new NotImplementedException();
        }
        
        
        public AspNetHostingPermission(AspNetHostingPermissionLevel level)
        {
             throw new NotImplementedException();
        }
        
        
        public bool IsUnrestricted()
        {
             throw new NotImplementedException();
        }
        
        
        public override IPermission Copy()
        {
             throw new NotImplementedException();
        }
        
        
        public override IPermission Union(IPermission target)
        {
             throw new NotImplementedException();
        }
        
        
        public override IPermission Intersect(IPermission target)
        {
             throw new NotImplementedException();
        }
        
        
        public override bool IsSubsetOf(IPermission target)
        {
             throw new NotImplementedException();
        }
        
        
        public override void FromXml(SecurityElement securityElement)
        {
             throw new NotImplementedException();
        }
        
        
        public override SecurityElement ToXml()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
