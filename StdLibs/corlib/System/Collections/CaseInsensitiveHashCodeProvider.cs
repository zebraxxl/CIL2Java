using System;
using System.Runtime.InteropServices;
using System.Globalization;

namespace System.Collections
{
    /// <summary>Supplies a hash code for an object, using a hashing algorithm that ignores the case of strings.</summary><filterpriority>2</filterpriority>
    [Serializable]
    [ObsoleteAttribute("Please use StringComparer instead.")]
    [ComVisibleAttribute(true)]
    public class CaseInsensitiveHashCodeProvider : IHashCodeProvider
    {
    
        /// <summary>Gets an instance of <see cref="T:System.Collections.CaseInsensitiveHashCodeProvider" /> that is associated with the <see cref="P:System.Threading.Thread.CurrentCulture" /> of the current thread and that is always available.</summary><returns>An instance of <see cref="T:System.Collections.CaseInsensitiveHashCodeProvider" /> that is associated with the <see cref="P:System.Threading.Thread.CurrentCulture" /> of the current thread.</returns><filterpriority>1</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        public static CaseInsensitiveHashCodeProvider Default
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets an instance of <see cref="T:System.Collections.CaseInsensitiveHashCodeProvider" /> that is associated with <see cref="P:System.Globalization.CultureInfo.InvariantCulture" /> and that is always available.</summary><returns>An instance of <see cref="T:System.Collections.CaseInsensitiveHashCodeProvider" /> that is associated with <see cref="P:System.Globalization.CultureInfo.InvariantCulture" />.</returns><filterpriority>1</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        public static CaseInsensitiveHashCodeProvider DefaultInvariant
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public CaseInsensitiveHashCodeProvider()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Collections.CaseInsensitiveHashCodeProvider" /> class using the specified <see cref="T:System.Globalization.CultureInfo" />.</summary><param name="culture">The <see cref="T:System.Globalization.CultureInfo" /> to use for the new <see cref="T:System.Collections.CaseInsensitiveHashCodeProvider" />. </param><exception cref="T:System.ArgumentNullException"><paramref name="culture" /> is null. </exception>
        public CaseInsensitiveHashCodeProvider(CultureInfo culture)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a hash code for the given object, using a hashing algorithm that ignores the case of strings.</summary><returns>A hash code for the given object, using a hashing algorithm that ignores the case of strings.</returns><param name="obj">The <see cref="T:System.Object" /> for which a hash code is to be returned. </param><exception cref="T:System.ArgumentNullException"><paramref name="obj" /> is null. </exception><filterpriority>2</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        public int GetHashCode(object obj)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
