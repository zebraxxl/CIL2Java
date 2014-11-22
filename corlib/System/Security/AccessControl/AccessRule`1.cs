using System.Security.Principal;

namespace System.Security.AccessControl
{
    /// <typeparam name="T"></typeparam>
    public class AccessRule<T> : AccessRule
    {
        /// <summary>Represents a combination of a user’s identity, an access mask, and an access control type.</summary><returns>Returns <see cref="{0}" />.</returns>
        public T Rights
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public AccessRule(IdentityReference identity, T rights, AccessControlType type)
            : base(identity, 0, false, InheritanceFlags.None, PropagationFlags.None, AccessControlType.Allow)
        {
             throw new NotImplementedException();
        }
        
        
        public AccessRule(string identity, T rights, AccessControlType type)
            : base(null, 0, false, InheritanceFlags.None, PropagationFlags.None, AccessControlType.Allow)
        {
             throw new NotImplementedException();
        }
        
        
        public AccessRule(IdentityReference identity, T rights, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AccessControlType type)
            : base(null, 0, false, InheritanceFlags.None, PropagationFlags.None, AccessControlType.Allow)
        {
             throw new NotImplementedException();
        }
        
        
        public AccessRule(string identity, T rights, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AccessControlType type)
            : base(null, 0, false, InheritanceFlags.None, PropagationFlags.None, AccessControlType.Allow)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
