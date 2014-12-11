using System;
using System.Runtime.InteropServices;
using System.Security;

namespace System.Security.Permissions
{
    /// <summary>Allows security actions for <see cref="T:System.Security.Permissions.KeyContainerPermission" /> to be applied to code using declarative security. This class cannot be inherited.</summary>
    [Serializable]
    [AttributeUsageAttribute(AttributeTargets.Assembly|AttributeTargets.Class|AttributeTargets.Struct|AttributeTargets.Constructor|AttributeTargets.Method, AllowMultiple = true, Inherited = false)]
    [ComVisibleAttribute(true)]
    public sealed class KeyContainerPermissionAttribute : CodeAccessSecurityAttribute
    {
    
        /// <summary>Gets or sets the name of the key store.</summary><returns>The name of the key store. The default is "*".</returns>
        public string KeyStore
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the provider name.</summary><returns>The name of the provider.</returns>
        public string ProviderName
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the provider type.</summary><returns>One of the PROV_ values defined in the Wincrypt.h header file. </returns>
        public int ProviderType
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the name of the key container.</summary><returns>The name of the key container.</returns>
        public string KeyContainerName
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the key specification.</summary><returns>One of the AT_ values defined in the Wincrypt.h header file. </returns>
        public int KeySpec
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the key container permissions.</summary><returns>A bitwise combination of the <see cref="T:System.Security.Permissions.KeyContainerPermissionFlags" /> values. The default is <see cref="F:System.Security.Permissions.KeyContainerPermissionFlags.NoFlags" />.</returns>
        public KeyContainerPermissionFlags Flags
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Permissions.KeyContainerPermissionAttribute" /> class with the specified security action.</summary><param name="action">One of the <see cref="T:System.Security.Permissions.SecurityAction" /> values. </param>
        public KeyContainerPermissionAttribute(SecurityAction action)
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
