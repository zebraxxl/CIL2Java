using System.Security;
using System.Security.Permissions;
using System.Collections;

namespace System.Net
{
    [Serializable]
    public sealed class SocketPermission : CodeAccessPermission, IUnrestrictedPermission
    {
        public const int AllPorts = -1;
    
        public IEnumerator ConnectList
        {
            get { throw new NotImplementedException(); }
        }
    
        public IEnumerator AcceptList
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public SocketPermission(PermissionState state)
        {
             throw new NotImplementedException();
        }
        
        
        public SocketPermission(NetworkAccess access, TransportType transport, string hostName, int portNumber)
        {
             throw new NotImplementedException();
        }
        
        
        public void AddPermission(NetworkAccess access, TransportType transport, string hostName, int portNumber)
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
