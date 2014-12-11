using System.Runtime.InteropServices;
using System.Collections.Generic;
using System;
using System.Security;

namespace System.Security.Principal
{
    /// <summary>Represents a collection of <see cref="T:System.Security.Principal.IdentityReference" /> objects and provides a means of converting sets of <see cref="T:System.Security.Principal.IdentityReference" />-derived objects to <see cref="T:System.Security.Principal.IdentityReference" />-derived types. </summary>
    [ComVisibleAttribute(false)]
    public class IdentityReferenceCollection : ICollection<IdentityReference>, IEnumerable<IdentityReference>
    {
    
        /// <summary>Gets the number of items in the <see cref="T:System.Security.Principal.IdentityReferenceCollection" /> collection.</summary><returns>The number of <see cref="T:System.Security.Principal.IdentityReference" /> objects in the <see cref="T:System.Security.Principal.IdentityReferenceCollection" /> collection.</returns>
        public int Count
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value that indicates whether the <see cref="T:System.Security.Principal.IdentityReferenceCollection" /> collection is read-only.</summary><returns>true if the <see cref="T:System.Security.Principal.IdentityReferenceCollection" /> collection is read-only.</returns>
        public bool IsReadOnly
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Sets or gets the node at the specified index of the <see cref="T:System.Security.Principal.IdentityReferenceCollection" /> collection.</summary><returns>The <see cref="T:System.Security.Principal.IdentityReference" /> at the specified index in the collection. If <paramref name="index" /> is greater than or equal to the number of nodes in the collection, the return value is null.</returns><param name="index">The zero-based index in the <see cref="T:System.Security.Principal.IdentityReferenceCollection" /> collection.</param>
        public IdentityReference this[int index]
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public IdentityReferenceCollection()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Principal.IdentityReferenceCollection" /> class by using the specified initial size.</summary><param name="capacity">The initial number of items in the collection. The value of <paramref name="capacity" /> is a hint only; it is not necessarily the maximum number of items created.</param>
        public IdentityReferenceCollection(int capacity)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Copies the <see cref="T:System.Security.Principal.IdentityReferenceCollection" /> collection to an <see cref="T:System.Security.Principal.IdentityReferenceCollection" /> array, starting at the specified index.</summary><param name="array">An <see cref="T:System.Security.Principal.IdentityReferenceCollection" /> array object to which the <see cref="T:System.Security.Principal.IdentityReferenceCollection" /> collection is to be copied.</param><param name="offset">The zero-based index in <paramref name="array" /> where the <see cref="T:System.Security.Principal.IdentityReferenceCollection" /> collection is to be copied.</param>
        public void CopyTo(IdentityReference[] array, int offset)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Adds an <see cref="T:System.Security.Principal.IdentityReference" /> object to the <see cref="T:System.Security.Principal.IdentityReferenceCollection" /> collection.</summary><param name="identity">The <see cref="T:System.Security.Principal.IdentityReference" /> object to add to the collection.</param>
        public void Add(IdentityReference identity)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Removes the specified <see cref="T:System.Security.Principal.IdentityReference" /> object from the collection.</summary><returns>true if the specified object was removed from the collection.</returns><param name="identity">The <see cref="T:System.Security.Principal.IdentityReference" /> object to remove.</param>
        public bool Remove(IdentityReference identity)
        {
             throw new NotImplementedException();
        }
        
        
        public void Clear()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Indicates whether the <see cref="T:System.Security.Principal.IdentityReferenceCollection" /> collection contains the specified <see cref="T:System.Security.Principal.IdentityReference" /> object.</summary><returns>true if the collection contains the specified object.</returns><param name="identity">The <see cref="T:System.Security.Principal.IdentityReference" /> object to check for.</param>
        public bool Contains(IdentityReference identity)
        {
             throw new NotImplementedException();
        }
        
        
        public IEnumerator<IdentityReference> GetEnumerator()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Converts the objects in the collection to the specified type. Calling this method is the same as calling <see cref="M:System.Security.Principal.IdentityReferenceCollection.Translate(System.Type,System.Boolean)" /> with the second parameter set to false, which means that exceptions will not be thrown for items that fail conversion.</summary><returns>A <see cref="T:System.Security.Principal.IdentityReferenceCollection" /> collection that represents the converted contents of the original collection.</returns><param name="targetType">The type to which items in the collection are being converted.</param><PermissionSet><IPermission class="System.Security.Permissions.ReflectionPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="MemberAccess" /></PermissionSet>
        public IdentityReferenceCollection Translate(Type targetType)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Converts the objects in the collection to the specified type and uses the specified fault tolerance to handle or ignore errors associated with a type not having a conversion mapping.</summary><returns>A <see cref="T:System.Security.Principal.IdentityReferenceCollection" /> collection that represents the converted contents of the original collection.</returns><param name="targetType">The type to which items in the collection are being converted.</param><param name="forceSuccess">A Boolean value that determines how conversion errors are handled.If <paramref name="forceSuccess" /> is true, conversion errors due to a mapping not being found for the translation result in a failed conversion and exceptions being thrown.If <paramref name="forceSuccess" /> is false, types that failed to convert due to a mapping not being found for the translation are copied without being converted into the collection being returned.</param><PermissionSet><IPermission class="System.Security.Permissions.ReflectionPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="MemberAccess" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public IdentityReferenceCollection Translate(Type targetType, bool forceSuccess)
        {
             throw new NotImplementedException();
        }



        int ICollection<IdentityReference>.Count
        {
            get { throw new NotImplementedException(); }
        }

        bool ICollection<IdentityReference>.IsReadOnly
        {
            get { throw new NotImplementedException(); }
        }

        void ICollection<IdentityReference>.Add(IdentityReference item)
        {
            throw new NotImplementedException();
        }

        void ICollection<IdentityReference>.Clear()
        {
            throw new NotImplementedException();
        }

        bool ICollection<IdentityReference>.Contains(IdentityReference item)
        {
            throw new NotImplementedException();
        }

        void ICollection<IdentityReference>.CopyTo(IdentityReference[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        bool ICollection<IdentityReference>.Remove(IdentityReference item)
        {
            throw new NotImplementedException();
        }

        IEnumerator<IdentityReference> IEnumerable<IdentityReference>.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        Collections.IEnumerator Collections.IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
