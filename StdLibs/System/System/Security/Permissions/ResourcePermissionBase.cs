using System.Security;
using System;

namespace System.Security.Permissions
{
    [Serializable]
    public abstract class ResourcePermissionBase : CodeAccessPermission, IUnrestrictedPermission
    {
        public const string Any = "*";
        public const string Local = ".";
    
        protected Type PermissionAccessType
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        protected string[] TagNames
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        protected ResourcePermissionBase()
        {
             throw new NotImplementedException();
        }
        
        
        protected ResourcePermissionBase(PermissionState state)
        {
             throw new NotImplementedException();
        }
        
        
        protected void AddPermissionAccess(ResourcePermissionBaseEntry entry)
        {
             throw new NotImplementedException();
        }
        
        
        protected void Clear()
        {
             throw new NotImplementedException();
        }
        
        
        public override IPermission Copy()
        {
             throw new NotImplementedException();
        }
        
        
        protected ResourcePermissionBaseEntry[] GetPermissionEntries()
        {
             throw new NotImplementedException();
        }
        
        
        public override void FromXml(SecurityElement securityElement)
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
        
        
        public bool IsUnrestricted()
        {
             throw new NotImplementedException();
        }
        
        
        protected void RemovePermissionAccess(ResourcePermissionBaseEntry entry)
        {
             throw new NotImplementedException();
        }
        
        
        public override SecurityElement ToXml()
        {
             throw new NotImplementedException();
        }
        
        
        public override IPermission Union(IPermission target)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
