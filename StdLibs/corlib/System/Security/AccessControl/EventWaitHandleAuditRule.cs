using System.Security.Principal;

namespace System.Security.AccessControl
{
    /// <summary>Represents a set of access rights to be audited for a user or group. This class cannot be inherited. </summary>
    public sealed class EventWaitHandleAuditRule : AuditRule
    {
        /// <summary>Gets the access rights affected by the audit rule.</summary><returns>A bitwise combination of <see cref="T:System.Security.AccessControl.EventWaitHandleRights" /> values that indicates the rights affected by the audit rule.</returns>
        public EventWaitHandleRights EventWaitHandleRights
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.AccessControl.EventWaitHandleAuditRule" /> class, specifying the user or group to audit, the rights to audit, and whether to audit success, failure, or both.</summary><param name="identity">The user or group the rule applies to. Must be of type <see cref="T:System.Security.Principal.SecurityIdentifier" /> or a type such as <see cref="T:System.Security.Principal.NTAccount" /> that can be converted to type <see cref="T:System.Security.Principal.SecurityIdentifier" />.</param><param name="eventRights">A bitwise combination of <see cref="T:System.Security.AccessControl.EventWaitHandleRights" /> values specifying the kinds of access to audit.</param><param name="flags">A bitwise combination of <see cref="T:System.Security.AccessControl.AuditFlags" /> values specifying whether to audit success, failure, or both.</param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="eventRights" /> specifies an invalid value.-or-<paramref name="flags" /> specifies an invalid value.</exception><exception cref="T:System.ArgumentNullException"><paramref name="identity" /> is null. -or-<paramref name="eventRights" /> is zero.</exception><exception cref="T:System.ArgumentException"><paramref name="flags" /> is <see cref="F:System.Security.AccessControl.AuditFlags.None" />.</exception><exception cref="T:System.ArgumentException"><paramref name="identity" /> is neither of type <see cref="T:System.Security.Principal.SecurityIdentifier" /> nor of a type such as <see cref="T:System.Security.Principal.NTAccount" /> that can be converted to type <see cref="T:System.Security.Principal.SecurityIdentifier" />.</exception>
        public EventWaitHandleAuditRule(IdentityReference identity, EventWaitHandleRights eventRights, AuditFlags flags)
            : base(null, 0, false, InheritanceFlags.None, PropagationFlags.None, AuditFlags.None)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
