using System.Runtime.InteropServices;
using System.Collections;
using System.Runtime.Serialization;
using System.Security.Permissions;
using System;

namespace System.Security
{
    /// <summary>Represents a collection that can contain many different types of permissions.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    public class PermissionSet : ISecurityEncodable, ICollection, IStackWalk, IDeserializationCallback
    {
    
        /// <summary>Gets the root object of the current collection.</summary><returns>The root object of the current collection.</returns>
        public virtual object SyncRoot
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value indicating whether the collection is guaranteed to be thread safe.</summary><returns>Always false.</returns>
        public virtual bool IsSynchronized
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value indicating whether the collection is read-only.</summary><returns>Always false.</returns>
        public virtual bool IsReadOnly
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the number of permission objects contained in the permission set.</summary><returns>The number of permission objects contained in the <see cref="T:System.Security.PermissionSet" />.</returns>
        public virtual int Count
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.PermissionSet" /> class with the specified <see cref="T:System.Security.Permissions.PermissionState" />.</summary><param name="state">One of the enumeration values that specifies the permission set's access to resources. </param><exception cref="T:System.ArgumentException">The <paramref name="state" /> parameter is not a valid <see cref="T:System.Security.Permissions.PermissionState" />. </exception>
        public PermissionSet(PermissionState state)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.PermissionSet" /> class with initial values taken from the <paramref name="permSet" /> parameter.</summary><param name="permSet">The set from which to take the value of the new <see cref="T:System.Security.PermissionSet" />, or null to create an empty <see cref="T:System.Security.PermissionSet" />. </param>
        public PermissionSet(PermissionSet permSet)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Copies the permission objects of the set to the indicated location in an <see cref="T:System.Array" />.</summary><param name="array">The target array to which to copy. </param><param name="index">The starting position in the array to begin copying (zero based). </param><exception cref="T:System.ArgumentNullException">The <paramref name="array" /> parameter is null. </exception><exception cref="T:System.ArgumentException">The <paramref name="array" /> parameter has more than one dimension. </exception><exception cref="T:System.IndexOutOfRangeException">The <paramref name="index" /> parameter is out of the range of the <paramref name="array" /> parameter. </exception>
        public virtual void CopyTo(Array array, int index)
        {
             throw new NotImplementedException();
        }
        
        
        public bool IsEmpty()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Gets a permission object of the specified type, if it exists in the set.</summary><returns>A copy of the permission object of the type specified by the <paramref name="permClass" /> parameter contained in the <see cref="T:System.Security.PermissionSet" />, or null if none exists.</returns><param name="permClass">The type of the desired permission object. </param><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        public IPermission GetPermission(Type permClass)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Gets a permission object of the specified type, if it exists in the set.</summary><returns>A copy of the permission object, of the type specified by the <paramref name="permClass" /> parameter, contained in the <see cref="T:System.Security.PermissionSet" />, or null if none exists.</returns><param name="permClass">The type of the permission object.</param>
        protected virtual IPermission GetPermissionImpl(Type permClass)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sets a permission to the <see cref="T:System.Security.PermissionSet" />, replacing any existing permission of the same type.</summary><returns>The set permission.</returns><param name="perm">The permission to set. </param><exception cref="T:System.InvalidOperationException">The method is called from a <see cref="T:System.Security.ReadOnlyPermissionSet" />.</exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        public IPermission SetPermission(IPermission perm)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sets a permission to the <see cref="T:System.Security.PermissionSet" />, replacing any existing permission of the same type.</summary><returns>The set permission.</returns><param name="perm">The permission to set.</param><exception cref="T:System.InvalidOperationException">The method is called from a <see cref="T:System.Security.ReadOnlyPermissionSet" />.</exception>
        protected virtual IPermission SetPermissionImpl(IPermission perm)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Adds a specified permission to the <see cref="T:System.Security.PermissionSet" />.</summary><returns>The union of the permission added and any permission of the same type that already exists in the <see cref="T:System.Security.PermissionSet" />.</returns><param name="perm">The permission to add. </param><exception cref="T:System.InvalidOperationException">The method is called from a <see cref="T:System.Security.ReadOnlyPermissionSet" />.</exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        public IPermission AddPermission(IPermission perm)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Adds a specified permission to the <see cref="T:System.Security.PermissionSet" />.</summary><returns>The union of the permission added and any permission of the same type that already exists in the <see cref="T:System.Security.PermissionSet" />, or null if <paramref name="perm" /> is null.</returns><param name="perm">The permission to add.</param><exception cref="T:System.InvalidOperationException">The method is called from a <see cref="T:System.Security.ReadOnlyPermissionSet" />.</exception>
        protected virtual IPermission AddPermissionImpl(IPermission perm)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Removes a permission of a certain type from the set.</summary><returns>The permission removed from the set.</returns><param name="permClass">The type of permission to delete. </param><exception cref="T:System.InvalidOperationException">The method is called from a <see cref="T:System.Security.ReadOnlyPermissionSet" />.</exception>
        public IPermission RemovePermission(Type permClass)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Removes a permission of a certain type from the set.</summary><returns>The permission removed from the set.</returns><param name="permClass">The type of the permission to remove.</param><exception cref="T:System.InvalidOperationException">The method is called from a <see cref="T:System.Security.ReadOnlyPermissionSet" />.</exception>
        protected virtual IPermission RemovePermissionImpl(Type permClass)
        {
             throw new NotImplementedException();
        }
        
        
        public bool IsUnrestricted()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether the current <see cref="T:System.Security.PermissionSet" /> is a subset of the specified <see cref="T:System.Security.PermissionSet" />.</summary><returns>true if the current <see cref="T:System.Security.PermissionSet" /> is a subset of the <paramref name="target" /> parameter; otherwise, false.</returns><param name="target">The permission set to test for the subset relationship. This must be either a <see cref="T:System.Security.PermissionSet" /> or a <see cref="T:System.Security.NamedPermissionSet" />. </param><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        public bool IsSubsetOf(PermissionSet target)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates and returns a permission set that is the intersection of the current <see cref="T:System.Security.PermissionSet" /> and the specified <see cref="T:System.Security.PermissionSet" />.</summary><returns>A new permission set that represents the intersection of the current <see cref="T:System.Security.PermissionSet" /> and the specified target. This object is null if the intersection is empty.</returns><param name="other">A permission set to intersect with the current <see cref="T:System.Security.PermissionSet" />. </param><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        public PermissionSet Intersect(PermissionSet other)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates a <see cref="T:System.Security.PermissionSet" /> that is the union of the current <see cref="T:System.Security.PermissionSet" /> and the specified <see cref="T:System.Security.PermissionSet" />.</summary><returns>A new permission set that represents the union of the current <see cref="T:System.Security.PermissionSet" /> and the specified <see cref="T:System.Security.PermissionSet" />.</returns><param name="other">The permission set to form the union with the current <see cref="T:System.Security.PermissionSet" />. </param><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        public PermissionSet Union(PermissionSet other)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether the specified <see cref="T:System.Security.PermissionSet" /> or <see cref="T:System.Security.NamedPermissionSet" /> object is equal to the current <see cref="T:System.Security.PermissionSet" />.</summary><returns>true if the specified object is equal to the current <see cref="T:System.Security.PermissionSet" /> object; otherwise, false.</returns><param name="obj">The object to compare with the current <see cref="T:System.Security.PermissionSet" />. </param>
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
        
        
        public virtual PermissionSet Copy()
        {
             throw new NotImplementedException();
        }
        
        
        public IEnumerator GetEnumerator()
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual IEnumerator GetEnumeratorImpl()
        {
             throw new NotImplementedException();
        }
        
        
        public override string ToString()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Reconstructs a security object with a specified state from an XML encoding.</summary><param name="et">The XML encoding to use to reconstruct the security object. </param><exception cref="T:System.ArgumentNullException">The <paramref name="et" /> parameter is null. </exception><exception cref="T:System.ArgumentException">The <paramref name="et" /> parameter is not a valid permission element.-or- The <paramref name="et" /> parameter's version number is not supported. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        public virtual void FromXml(SecurityElement et)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual SecurityElement ToXml()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Converts an encoded <see cref="T:System.Security.PermissionSet" /> from one XML encoding format to another XML encoding format.</summary><returns>An encrypted permission set with the specified output format.</returns><param name="inFormat">A string representing one of the following encoding formats: ASCII, Unicode, or Binary. Possible values are "XMLASCII" or "XML", "XMLUNICODE", and "BINARY".</param><param name="inData">An XML-encoded permission set.</param><param name="outFormat">A string representing one of the following encoding formats: ASCII, Unicode, or Binary. Possible values are "XMLASCII" or "XML", "XMLUNICODE", and "BINARY".</param><exception cref="T:System.NotImplementedException">In all cases.</exception>
        [ObsoleteAttribute("This method is obsolete and shoud no longer be used.")]
        public static byte[] ConvertPermissionSet(string inFormat, byte[] inData, string outFormat)
        {
             throw new NotImplementedException();
        }
        
        
        public bool ContainsNonCodeAccessPermissions()
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public static void RevertAssert()
        {
             throw new NotImplementedException();
        }



        void IDeserializationCallback.OnDeserialization(object sender)
        {
            throw new NotImplementedException();
        }
    }
}
