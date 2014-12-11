using System.Runtime.InteropServices;
using System;

namespace System.Security
{
    /// <summary>Defines the underlying structure of all code access permissions.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    public abstract class CodeAccessPermission : IPermission, IStackWalk
    {
        [SecuritySafeCriticalAttribute()]
        public static void RevertAssert()
        {
             throw new NotImplementedException();
        }
        
        
        [ObsoleteAttribute("Deny is obsolete and will be removed in a future release of the .NET Framework. See http://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
        [SecuritySafeCriticalAttribute()]
        public static void RevertDeny()
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public static void RevertPermitOnly()
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public static void RevertAll()
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public void Demand()
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public void Assert()
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        [ObsoleteAttribute("Deny is obsolete and will be removed in a future release of the .NET Framework. See http://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
        public void Deny()
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public void PermitOnly()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>When overridden in a derived class, creates a permission that is the union of the current permission and the specified permission.</summary><returns>A new permission that represents the union of the current permission and the specified permission.</returns><param name="other">A permission to combine with the current permission. It must be of the same type as the current permission. </param><exception cref="T:System.NotSupportedException">The <paramref name="other" /> parameter is not null. This method is only supported at this level when passed null. </exception>
        public virtual IPermission Union(IPermission other)
        {
             throw new NotImplementedException();
        }
        
        
        public abstract SecurityElement ToXml();
        
        
        /// <summary>When overridden in a derived class, reconstructs a security object with a specified state from an XML encoding.</summary><param name="elem">The XML encoding to use to reconstruct the security object. </param><exception cref="T:System.ArgumentNullException">The <paramref name="elem" /> parameter is null. </exception><exception cref="T:System.ArgumentException">The <paramref name="elem" /> parameter does not contain the XML encoding for an instance of the same type as the current instance.-or- The version number of the <paramref name="elem" /> parameter is not supported. </exception>
        public abstract void FromXml(SecurityElement elem);
        
        
        public override string ToString()
        {
             throw new NotImplementedException();
        }
        
        
        public abstract IPermission Copy();
        
        
        /// <summary>When implemented by a derived class, creates and returns a permission that is the intersection of the current permission and the specified permission.</summary><returns>A new permission that represents the intersection of the current permission and the specified permission. This new permission is null if the intersection is empty.</returns><param name="target">A permission to intersect with the current permission. It must be of the same type as the current permission. </param><exception cref="T:System.ArgumentException">The <paramref name="target" /> parameter is not null and is not an instance of the same class as the current permission. </exception>
        public abstract IPermission Intersect(IPermission target);
        
        
        /// <summary>When implemented by a derived class, determines whether the current permission is a subset of the specified permission.</summary><returns>true if the current permission is a subset of the specified permission; otherwise, false.</returns><param name="target">A permission that is to be tested for the subset relationship. This permission must be of the same type as the current permission. </param><exception cref="T:System.ArgumentException">The <paramref name="target" /> parameter is not null and is not of the same type as the current permission. </exception>
        public abstract bool IsSubsetOf(IPermission target);
        
        
        /// <summary>Determines whether the specified <see cref="T:System.Security.CodeAccessPermission" /> object is equal to the current <see cref="T:System.Security.CodeAccessPermission" />.</summary><returns>true if the specified <see cref="T:System.Security.CodeAccessPermission" /> object is equal to the current <see cref="T:System.Security.CodeAccessPermission" />; otherwise, false.</returns><param name="obj">The <see cref="T:System.Security.CodeAccessPermission" /> object to compare with the current <see cref="T:System.Security.CodeAccessPermission" />. </param>
        [ComVisibleAttribute(false)]
        public override bool Equals(object obj)
        {
             throw new NotImplementedException();
        }
        
        
        [ComVisibleAttribute(false)]
        public override int GetHashCode()
        {
             throw new NotImplementedException();
        }
        
        
        protected CodeAccessPermission()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
