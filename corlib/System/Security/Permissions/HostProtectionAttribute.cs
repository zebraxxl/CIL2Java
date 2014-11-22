using System;
using System.Runtime.InteropServices;
using System.Security;

namespace System.Security.Permissions
{
    /// <summary>Allows the use of declarative security actions to determine host protection requirements. This class cannot be inherited.</summary>
    [Serializable]
    [AttributeUsageAttribute(AttributeTargets.Assembly|AttributeTargets.Class|AttributeTargets.Struct|AttributeTargets.Constructor|AttributeTargets.Method|AttributeTargets.Delegate, AllowMultiple = true, Inherited = false)]
    [ComVisibleAttribute(true)]
    public sealed class HostProtectionAttribute : CodeAccessSecurityAttribute
    {
    
        /// <summary>Gets or sets flags specifying categories of functionality that are potentially harmful to the host.</summary><returns>A bitwise combination of the <see cref="T:System.Security.Permissions.HostProtectionResource" /> values. The default is <see cref="F:System.Security.Permissions.HostProtectionResource.None" />.</returns>
        public HostProtectionResource Resources
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets a value indicating whether synchronization is exposed.</summary><returns>true if synchronization is exposed; otherwise, false. The default is false.</returns>
        public bool Synchronization
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets a value indicating whether shared state is exposed.</summary><returns>true if shared state is exposed; otherwise, false. The default is false.</returns>
        public bool SharedState
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets a value indicating whether external process management is exposed.</summary><returns>true if external process management is exposed; otherwise, false. The default is false.</returns>
        public bool ExternalProcessMgmt
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets a value indicating whether self-affecting process management is exposed.</summary><returns>true if self-affecting process management is exposed; otherwise, false. The default is false.</returns>
        public bool SelfAffectingProcessMgmt
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets a value indicating whether external threading is exposed.</summary><returns>true if external threading is exposed; otherwise, false. The default is false.</returns>
        public bool ExternalThreading
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets a value indicating whether self-affecting threading is exposed.</summary><returns>true if self-affecting threading is exposed; otherwise, false. The default is false.</returns>
        public bool SelfAffectingThreading
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets a value indicating whether the security infrastructure is exposed.</summary><returns>true if the security infrastructure is exposed; otherwise, false. The default is false.</returns>
        [ComVisibleAttribute(true)]
        public bool SecurityInfrastructure
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets a value indicating whether the user interface is exposed.</summary><returns>true if the user interface is exposed; otherwise, false. The default is false.</returns>
        public bool UI
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets a value indicating whether resources might leak memory if the operation is terminated.</summary><returns>true if resources might leak memory on termination; otherwise, false.</returns>
        public bool MayLeakOnAbort
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public HostProtectionAttribute()
            : base(SecurityAction.Assert)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Permissions.HostProtectionAttribute" /> class with the specified <see cref="T:System.Security.Permissions.SecurityAction" /> value.</summary><param name="action">One of the <see cref="T:System.Security.Permissions.SecurityAction" /> values. </param><exception cref="T:System.ArgumentException"><paramref name="action" /> is not <see cref="F:System.Security.Permissions.SecurityAction.LinkDemand" />. </exception>
        public HostProtectionAttribute(SecurityAction action)
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
