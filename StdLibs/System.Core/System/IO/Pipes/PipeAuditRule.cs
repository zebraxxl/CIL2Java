using System.Security.AccessControl;
using System.Security.Principal;

namespace System.IO.Pipes
{
    public sealed class PipeAuditRule : AuditRule
    {
        public PipeAccessRights PipeAccessRights
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public PipeAuditRule(IdentityReference identity, PipeAccessRights rights, AuditFlags flags)
            : base(null, 0, false, InheritanceFlags.None, PropagationFlags.None, AuditFlags.None)
        {
             throw new NotImplementedException();
        }
        
        
        public PipeAuditRule(string identity, PipeAccessRights rights, AuditFlags flags)
            : base(null, 0, false, InheritanceFlags.None, PropagationFlags.None, AuditFlags.None)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
