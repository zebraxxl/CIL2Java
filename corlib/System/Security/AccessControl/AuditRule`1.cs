using System.Security.Principal;

namespace System.Security.AccessControl
{
    /// <summary>Represents a combination of a user’s identity and an access mask.</summary><typeparam name="T"></typeparam>
    public class AuditRule<T> : AuditRule
    {
        /// <summary>The rights of the audit rule.</summary><returns>Returns <see cref="{0}" />.</returns>
        public T Rights
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public AuditRule(IdentityReference identity, T rights, AuditFlags flags)
            : base(null, 0, false, InheritanceFlags.None, PropagationFlags.None, AuditFlags.None)
        {
             throw new NotImplementedException();
        }
        
        
        public AuditRule(IdentityReference identity, T rights, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AuditFlags flags)
            : base(null, 0, false, InheritanceFlags.None, PropagationFlags.None, AuditFlags.None)
        {
             throw new NotImplementedException();
        }
        
        
        public AuditRule(string identity, T rights, AuditFlags flags)
            : base(null, 0, false, InheritanceFlags.None, PropagationFlags.None, AuditFlags.None)
        {
             throw new NotImplementedException();
        }
        
        
        public AuditRule(string identity, T rights, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AuditFlags flags)
            : base(null, 0, false, InheritanceFlags.None, PropagationFlags.None, AuditFlags.None)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
