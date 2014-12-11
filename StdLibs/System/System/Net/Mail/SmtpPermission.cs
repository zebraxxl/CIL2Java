using System.Security;
using System.Security.Permissions;

namespace System.Net.Mail
{
    [Serializable]
    public sealed class SmtpPermission : CodeAccessPermission, IUnrestrictedPermission
    {
    
        public SmtpAccess Access
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public SmtpPermission(PermissionState state)
        {
             throw new NotImplementedException();
        }
        
        
        public SmtpPermission(bool unrestricted)
        {
             throw new NotImplementedException();
        }
        
        
        public SmtpPermission(SmtpAccess access)
        {
             throw new NotImplementedException();
        }
        
        
        public void AddPermission(SmtpAccess access)
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
