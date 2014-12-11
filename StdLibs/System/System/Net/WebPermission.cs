using System.Security;
using System.Security.Permissions;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Collections;

namespace System.Net
{
    [Serializable]
    public sealed class WebPermission : CodeAccessPermission, IUnrestrictedPermission
    {
    
        public IEnumerator ConnectList
        {
            get { throw new NotImplementedException(); }
        }
    
        public IEnumerator AcceptList
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public WebPermission(PermissionState state)
        {
             throw new NotImplementedException();
        }
        
        
        public WebPermission()
        {
             throw new NotImplementedException();
        }
        
        
        public WebPermission(NetworkAccess access, Regex uriRegex)
        {
             throw new NotImplementedException();
        }
        
        
        public WebPermission(NetworkAccess access, string uriString)
        {
             throw new NotImplementedException();
        }
        
        
        public void AddPermission(NetworkAccess access, string uriString)
        {
             throw new NotImplementedException();
        }
        
        
        public void AddPermission(NetworkAccess access, Regex uriRegex)
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
        
        
        public override bool IsSubsetOf(IPermission target)
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
