using System.Security;

namespace System.Security.Permissions
{
    [Serializable]
    public sealed class TypeDescriptorPermission : CodeAccessPermission, IUnrestrictedPermission
    {
    
        public TypeDescriptorPermissionFlags Flags
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public TypeDescriptorPermission(PermissionState state)
        {
             throw new NotImplementedException();
        }
        
        
        public TypeDescriptorPermission(TypeDescriptorPermissionFlags flag)
        {
             throw new NotImplementedException();
        }
        
        
        public bool IsUnrestricted()
        {
             throw new NotImplementedException();
        }
        
        
        public override IPermission Union(IPermission target)
        {
             throw new NotImplementedException();
        }
        
        
        public override bool IsSubsetOf(IPermission target)
        {
             throw new NotImplementedException();
        }
        
        
        public override IPermission Intersect(IPermission target)
        {
             throw new NotImplementedException();
        }
        
        
        public override IPermission Copy()
        {
             throw new NotImplementedException();
        }
        
        
        public override SecurityElement ToXml()
        {
             throw new NotImplementedException();
        }
        
        
        public override void FromXml(SecurityElement securityElement)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
