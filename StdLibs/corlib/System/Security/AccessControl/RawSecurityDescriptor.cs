using System.Security.Principal;
using System.Security;

namespace System.Security.AccessControl
{
    /// <summary>Represents a security descriptor. A security descriptor includes an owner, a primary group, a Discretionary Access Control List (DACL), and a System Access Control List (SACL).</summary>
    public sealed class RawSecurityDescriptor : GenericSecurityDescriptor
    {
    
        /// <summary>Gets values that specify behavior of the <see cref="T:System.Security.AccessControl.RawSecurityDescriptor" /> object.</summary><returns>One or more values of the <see cref="T:System.Security.AccessControl.ControlFlags" /> enumeration combined with a logical OR operation.</returns>
        public override ControlFlags ControlFlags
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the owner of the object associated with this <see cref="T:System.Security.AccessControl.RawSecurityDescriptor" /> object.</summary><returns>The owner of the object associated with this <see cref="T:System.Security.AccessControl.RawSecurityDescriptor" /> object.</returns>
        public override SecurityIdentifier Owner
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the primary group for this <see cref="T:System.Security.AccessControl.RawSecurityDescriptor" /> object.</summary><returns>The primary group for this <see cref="T:System.Security.AccessControl.RawSecurityDescriptor" /> object.</returns>
        public override SecurityIdentifier Group
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the System Access Control List (SACL) for this <see cref="T:System.Security.AccessControl.RawSecurityDescriptor" /> object. The SACL contains audit rules.</summary><returns>The SACL for this <see cref="T:System.Security.AccessControl.RawSecurityDescriptor" /> object.</returns>
        public RawAcl SystemAcl
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the Discretionary Access Control List (DACL) for this <see cref="T:System.Security.AccessControl.RawSecurityDescriptor" /> object. The DACL contains access rules.</summary><returns>The DACL for this <see cref="T:System.Security.AccessControl.RawSecurityDescriptor" /> object.</returns>
        public RawAcl DiscretionaryAcl
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets a byte value that represents the resource manager control bits associated with this <see cref="T:System.Security.AccessControl.RawSecurityDescriptor" /> object.</summary><returns>A byte value that represents the resource manager control bits associated with this <see cref="T:System.Security.AccessControl.RawSecurityDescriptor" /> object.</returns>
        public byte ResourceManagerControl
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.AccessControl.RawSecurityDescriptor" /> class with the specified values.</summary><param name="flags">Flags that specify behavior of the new <see cref="T:System.Security.AccessControl.RawSecurityDescriptor" /> object.</param><param name="owner">The owner for the new <see cref="T:System.Security.AccessControl.RawSecurityDescriptor" /> object.</param><param name="group">The primary group for the new <see cref="T:System.Security.AccessControl.RawSecurityDescriptor" /> object.</param><param name="systemAcl">The System Access Control List (SACL) for the new <see cref="T:System.Security.AccessControl.RawSecurityDescriptor" /> object.</param><param name="discretionaryAcl">The Discretionary Access Control List (DACL) for the new <see cref="T:System.Security.AccessControl.RawSecurityDescriptor" /> object.</param>
        public RawSecurityDescriptor(ControlFlags flags, SecurityIdentifier owner, SecurityIdentifier group, RawAcl systemAcl, RawAcl discretionaryAcl)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.AccessControl.RawSecurityDescriptor" /> class from the specified Security Descriptor Definition Language (SDDL) string.</summary><param name="sddlForm">The SDDL string from which to create the new <see cref="T:System.Security.AccessControl.RawSecurityDescriptor" /> object.</param>
        [SecuritySafeCriticalAttribute()]
        public RawSecurityDescriptor(string sddlForm)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.AccessControl.RawSecurityDescriptor" /> class from the specified array of byte values.</summary><param name="binaryForm">The array of byte values from which to create the new <see cref="T:System.Security.AccessControl.RawSecurityDescriptor" /> object.</param><param name="offset">The offset in the  <paramref name="binaryForm" /> array at which to begin copying.</param>
        public RawSecurityDescriptor(byte[] binaryForm, int offset)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sets the <see cref="P:System.Security.AccessControl.RawSecurityDescriptor.ControlFlags" /> property of this <see cref="T:System.Security.AccessControl.RawSecurityDescriptor" /> object to the specified value.</summary><param name="flags">One or more values of the <see cref="T:System.Security.AccessControl.ControlFlags" /> enumeration combined with a logical OR operation.</param>
        public void SetFlags(ControlFlags flags)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
