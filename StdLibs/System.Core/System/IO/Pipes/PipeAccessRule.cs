using System.Security.AccessControl;
using System.Security.Principal;

namespace System.IO.Pipes
{
    public sealed class PipeAccessRule : AccessRule
    {
        public PipeAccessRights PipeAccessRights
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public PipeAccessRule(string identity, PipeAccessRights rights, AccessControlType type)
            : base(null, 0, false, InheritanceFlags.None, PropagationFlags.None, AccessControlType.Allow)
        {
             throw new NotImplementedException();
        }
        
        
        public PipeAccessRule(IdentityReference identity, PipeAccessRights rights, AccessControlType type)
            : base(null, 0, false, InheritanceFlags.None, PropagationFlags.None, AccessControlType.Allow)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
