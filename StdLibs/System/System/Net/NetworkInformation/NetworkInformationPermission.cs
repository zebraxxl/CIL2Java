using System.Security;
using System.Security.Permissions;

namespace System.Net.NetworkInformation
{
    [Serializable]
    public sealed class NetworkInformationPermission : CodeAccessPermission, IUnrestrictedPermission
    {
    
        public NetworkInformationAccess Access
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public NetworkInformationPermission(PermissionState state)
        {
             throw new NotImplementedException();
        }
        
        
        public NetworkInformationPermission(NetworkInformationAccess access)
        {
             throw new NotImplementedException();
        }
        
        
        public void AddPermission(NetworkInformationAccess access)
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
