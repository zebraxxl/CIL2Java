using System.Runtime.InteropServices;
using System.Security.Principal;

namespace System.Security.AccessControl
{
    [ComVisibleAttribute(false)]
    public sealed class SemaphoreAuditRule : AuditRule
    {
        public SemaphoreRights SemaphoreRights
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public SemaphoreAuditRule(IdentityReference identity, SemaphoreRights eventRights, AuditFlags flags)
            : base(identity, 0, false, InheritanceFlags.None, PropagationFlags.None, AuditFlags.None)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
