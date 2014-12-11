using System.Security;
using System.Security.Permissions;

namespace System.Net
{
    [Serializable]
    public sealed class DnsPermission : CodeAccessPermission, IUnrestrictedPermission
    {
    
        public DnsPermission(PermissionState state)
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
