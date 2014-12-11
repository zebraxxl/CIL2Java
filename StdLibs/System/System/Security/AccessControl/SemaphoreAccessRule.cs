using System.Runtime.InteropServices;
using System.Security.Principal;

namespace System.Security.AccessControl
{
    [ComVisibleAttribute(false)]
    public sealed class SemaphoreAccessRule : AccessRule
    {
        public SemaphoreRights SemaphoreRights
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public SemaphoreAccessRule(IdentityReference identity, SemaphoreRights eventRights, AccessControlType type)
            : base(identity, 0, false, InheritanceFlags.None, PropagationFlags.None, AccessControlType.Allow)
        {
             throw new NotImplementedException();
        }
        
        
        public SemaphoreAccessRule(string identity, SemaphoreRights eventRights, AccessControlType type)
            : base(null, 0, false, InheritanceFlags.None, PropagationFlags.None, AccessControlType.Allow)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
