using System.Runtime.InteropServices;
using System;
using System.Security;

namespace System.Security.Permissions
{
    /// <summary>Allows security actions for <see cref="T:System.Security.Permissions.ReflectionPermission" /> to be applied to code using declarative security. </summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    [AttributeUsageAttribute(AttributeTargets.Assembly|AttributeTargets.Class|AttributeTargets.Struct|AttributeTargets.Constructor|AttributeTargets.Method, AllowMultiple = true, Inherited = false)]
    public sealed class ReflectionPermissionAttribute : CodeAccessSecurityAttribute
    {
    
        /// <summary>Gets or sets the current allowed uses of reflection.</summary><returns>One or more of the <see cref="T:System.Security.Permissions.ReflectionPermissionFlag" /> values combined using a bitwise OR.</returns><exception cref="T:System.ArgumentException">An attempt is made to set this property to an invalid value. See <see cref="T:System.Security.Permissions.ReflectionPermissionFlag" /> for the valid values. </exception>
        public ReflectionPermissionFlag Flags
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets a value that indicates whether reflection on members that are not visible is allowed.</summary><returns>true if reflection on members that are not visible is allowed; otherwise, false.</returns>
        [ObsoleteAttribute("This API has been deprecated. http://go.microsoft.com/fwlink/?linkid=14202")]
        public bool TypeInformation
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets a value that indicates whether invocation of operations on non-public members is allowed.</summary><returns>true if invocation of operations on non-public members is allowed; otherwise, false.</returns>
        public bool MemberAccess
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets a value that indicates whether use of certain features in <see cref="N:System.Reflection.Emit" />, such as emitting debug symbols, is allowed.</summary><returns>true if use of the affected features is allowed; otherwise, false.</returns>
        [ObsoleteAttribute("This permission is no longer used by the CLR.")]
        public bool ReflectionEmit
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets a value that indicates whether restricted invocation of non-public members is allowed. Restricted invocation means that the grant set of the assembly that contains the non-public member that is being invoked must be equal to, or a subset of, the grant set of the invoking assembly. </summary><returns>true if restricted invocation of non-public members is allowed; otherwise, false.</returns>
        public bool RestrictedMemberAccess
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Permissions.ReflectionPermissionAttribute" /> class with the specified <see cref="T:System.Security.Permissions.SecurityAction" />.</summary><param name="action">One of the <see cref="T:System.Security.Permissions.SecurityAction" /> values. </param>
        public ReflectionPermissionAttribute(SecurityAction action)
            : base(action)
        {
             throw new NotImplementedException();
        }
        
        
        public override IPermission CreatePermission()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
