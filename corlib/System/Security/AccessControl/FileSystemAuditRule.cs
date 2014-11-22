using System.Security.Principal;

namespace System.Security.AccessControl
{
    /// <summary>Represents an abstraction of an access control entry (ACE) that defines an audit rule for a file or directory. This class cannot be inherited.</summary>
    public sealed class FileSystemAuditRule : AuditRule
    {
        /// <summary>Gets the <see cref="T:System.Security.AccessControl.FileSystemRights" /> flags associated with the current <see cref="T:System.Security.AccessControl.FileSystemAuditRule" /> object.</summary><returns>The <see cref="T:System.Security.AccessControl.FileSystemRights" /> flags associated with the current <see cref="T:System.Security.AccessControl.FileSystemAuditRule" /> object.</returns>
        public FileSystemRights FileSystemRights
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.AccessControl.FileSystemAuditRule" /> class using a reference to a user account, a value that specifies the type of operation associated with the audit rule, and a value that specifies when to perform auditing. </summary><param name="identity">An <see cref="T:System.Security.Principal.IdentityReference" /> object that encapsulates a reference to a user account.</param><param name="fileSystemRights">One of the <see cref="T:System.Security.AccessControl.FileSystemRights" /> values that specifies the type of operation associated with the audit rule. </param><param name="flags">One of the <see cref="T:System.Security.AccessControl.AuditFlags" /> values that specifies when to perform auditing.</param><exception cref="T:System.ArgumentException">The <paramref name="identity" /> parameter is not an <see cref="T:System.Security.Principal.IdentityReference" /> object.</exception><exception cref="T:System.ArgumentNullException">The <paramref name="identity" /> parameter is null.</exception><exception cref="T:System.ArgumentOutOfRangeException">An incorrect enumeration was passed to the <paramref name="flags" /> parameter.-or-The <see cref="F:System.Security.AccessControl.AuditFlags.None" /> value was passed to the <paramref name="flags" /> parameter.</exception>
        public FileSystemAuditRule(IdentityReference identity, FileSystemRights fileSystemRights, AuditFlags flags)
            : base(null, 0, false, InheritanceFlags.None, PropagationFlags.None, AuditFlags.None)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.AccessControl.FileSystemAuditRule" /> class using the name of a reference to a user account, a value that specifies the type of operation associated with the audit rule, a value that determines how rights are inherited, a value that determines how rights are propagated, and a value that specifies when to perform auditing.  </summary><param name="identity">An <see cref="T:System.Security.Principal.IdentityReference" /> object that encapsulates a reference to a user account.</param><param name="fileSystemRights">One of the <see cref="T:System.Security.AccessControl.FileSystemRights" /> values that specifies the type of operation associated with the audit rule.</param><param name="inheritanceFlags">One of the <see cref="T:System.Security.AccessControl.InheritanceFlags" /> values that specifies how access masks are propagated to child objects.</param><param name="propagationFlags">One of the <see cref="T:System.Security.AccessControl.PropagationFlags" /> values that specifies how Access Control Entries (ACEs) are propagated to child objects.</param><param name="flags">One of the <see cref="T:System.Security.AccessControl.AuditFlags" /> values that specifies when to perform auditing.</param><exception cref="T:System.ArgumentException">The <paramref name="identity" /> parameter is not an <see cref="T:System.Security.Principal.IdentityReference" /> object.</exception><exception cref="T:System.ArgumentNullException">The <paramref name="identity" /> parameter is null.</exception><exception cref="T:System.ArgumentOutOfRangeException">An incorrect enumeration was passed to the <paramref name="flags" /> parameter.-or-The <see cref="F:System.Security.AccessControl.AuditFlags.None" /> value was passed to the <paramref name="flags" /> parameter.</exception>
        public FileSystemAuditRule(IdentityReference identity, FileSystemRights fileSystemRights, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AuditFlags flags)
            : base(null, 0, false, InheritanceFlags.None, PropagationFlags.None, AuditFlags.None)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.AccessControl.FileSystemAuditRule" /> class using a user account name, a value that specifies the type of operation associated with the audit rule, and a value that specifies when to perform auditing.</summary><param name="identity">The name of a user account.</param><param name="fileSystemRights">One of the <see cref="T:System.Security.AccessControl.FileSystemRights" /> values that specifies the type of operation associated with the audit rule. </param><param name="flags">One of the <see cref="T:System.Security.AccessControl.AuditFlags" /> values that specifies when to perform auditing.</param><exception cref="T:System.ArgumentOutOfRangeException">An incorrect enumeration was passed to the <paramref name="flags" /> parameter.-or-The <see cref="F:System.Security.AccessControl.AuditFlags.None" /> value was passed to the <paramref name="flags" /> parameter.</exception>
        public FileSystemAuditRule(string identity, FileSystemRights fileSystemRights, AuditFlags flags)
            : base(null, 0, false, InheritanceFlags.None, PropagationFlags.None, AuditFlags.None)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.AccessControl.FileSystemAuditRule" /> class using the name of a user account, a value that specifies the type of operation associated with the audit rule, a value that determines how rights are inherited, a value that determines how rights are propagated, and a value that specifies when to perform auditing. </summary><param name="identity">The name of a user account.</param><param name="fileSystemRights">One of the <see cref="T:System.Security.AccessControl.FileSystemRights" /> values that specifies the type of operation associated with the audit rule.</param><param name="inheritanceFlags">One of the <see cref="T:System.Security.AccessControl.InheritanceFlags" /> values that specifies how access masks are propagated to child objects.</param><param name="propagationFlags">One of the <see cref="T:System.Security.AccessControl.PropagationFlags" /> values that specifies how Access Control Entries (ACEs) are propagated to child objects.</param><param name="flags">One of the <see cref="T:System.Security.AccessControl.AuditFlags" /> values that specifies when to perform auditing.</param>
        public FileSystemAuditRule(string identity, FileSystemRights fileSystemRights, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AuditFlags flags)
            : base(null, 0, false, InheritanceFlags.None, PropagationFlags.None, AuditFlags.None)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
