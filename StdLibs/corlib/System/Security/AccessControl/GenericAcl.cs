using System.Collections;

namespace System.Security.AccessControl
{
    /// <summary>Represents an access control list (ACL) and is the base class for the <see cref="T:System.Security.AccessControl.CommonAcl" />, <see cref="T:System.Security.AccessControl.DiscretionaryAcl" />, <see cref="T:System.Security.AccessControl.RawAcl" />, and <see cref="T:System.Security.AccessControl.SystemAcl" /> classes.</summary>
    public abstract class GenericAcl : ICollection
    {
        /// <summary>The revision level of the current <see cref="T:System.Security.AccessControl.GenericAcl" />. This value is returned by the <see cref="P:System.Security.AccessControl.GenericAcl.Revision" /> property for Access Control Lists (ACLs) that are not associated with Directory Services objects.</summary>
        public static readonly byte AclRevision;
        /// <summary>The revision level of the current <see cref="T:System.Security.AccessControl.GenericAcl" />. This value is returned by the <see cref="P:System.Security.AccessControl.GenericAcl.Revision" /> property for Access Control Lists (ACLs) that are associated with Directory Services objects.</summary>
        public static readonly byte AclRevisionDS;
        /// <summary>The maximum allowed binary length of a <see cref="T:System.Security.AccessControl.GenericAcl" /> object.</summary>
        public static readonly int MaxBinaryLength;
    
        /// <summary>Gets the revision level of the <see cref="T:System.Security.AccessControl.GenericAcl" />.</summary><returns>A byte value that specifies the revision level of the <see cref="T:System.Security.AccessControl.GenericAcl" />.</returns>
        public abstract byte Revision
        {
            get;
        }
    
        /// <summary>Gets the length, in bytes, of the binary representation of the current <see cref="T:System.Security.AccessControl.GenericAcl" /> object. This length should be used before marshaling the ACL into a binary array with the <see cref="M:System.Security.AccessControl.GenericAcl.GetBinaryForm" /> method.</summary><returns>The length, in bytes, of the binary representation of the current <see cref="T:System.Security.AccessControl.GenericAcl" /> object.</returns>
        public abstract int BinaryLength
        {
            get;
        }
    
        /// <summary>Gets or sets the <see cref="T:System.Security.AccessControl.GenericAce" /> at the specified index.</summary><returns>The <see cref="T:System.Security.AccessControl.GenericAce" /> at the specified index.</returns><param name="index">The zero-based index of the <see cref="T:System.Security.AccessControl.GenericAce" /> to get or set.</param>
        public abstract GenericAce this[int index]
        {
            get;
            set;
        }
    
        /// <summary>Gets the number of access control entries (ACEs) in the current <see cref="T:System.Security.AccessControl.GenericAcl" /> object.</summary><returns>The number of ACEs in the current <see cref="T:System.Security.AccessControl.GenericAcl" /> object.</returns>
        public abstract int Count
        {
            get;
        }
    
        /// <summary>This property is always set to false. It is implemented only because it is required for the implementation of the <see cref="T:System.Collections.ICollection" /> interface.</summary><returns>Always false.</returns>
        public bool IsSynchronized
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>This property always returns null. It is implemented only because it is required for the implementation of the <see cref="T:System.Collections.ICollection" /> interface.</summary><returns>Always returns null.</returns>
        public virtual object SyncRoot
        {
            get { throw new NotImplementedException(); }
        }
    
    
        protected GenericAcl()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Marshals the contents of the <see cref="T:System.Security.AccessControl.GenericAcl" /> object into the specified byte array beginning at the specified offset.</summary><param name="binaryForm">The byte array into which the contents of the <see cref="T:System.Security.AccessControl.GenericAcl" /> is marshaled.</param><param name="offset">The offset at which to start marshaling.</param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="offset" /> is negative or too high to allow the entire <see cref="T:System.Security.AccessControl.GenericAcl" /> to be copied into <paramref name="array" />.</exception>
        public abstract void GetBinaryForm(byte[] binaryForm, int offset);
        
        
        /// <summary>Copies each <see cref="T:System.Security.AccessControl.GenericAce" /> of the current <see cref="T:System.Security.AccessControl.GenericAcl" /> into the specified array.</summary><param name="array">The array into which copies of the <see cref="T:System.Security.AccessControl.GenericAce" /> objects contained by the current <see cref="T:System.Security.AccessControl.GenericAcl" /> are placed.</param><param name="index">The zero-based index of <paramref name="array" /> where the copying begins.</param>
        public void CopyTo(GenericAce[] array, int index)
        {
             throw new NotImplementedException();
        }
        
        
        public AceEnumerator GetEnumerator()
        {
             throw new NotImplementedException();
        }



        int ICollection.Count
        {
            get { throw new NotImplementedException(); }
        }

        object ICollection.SyncRoot
        {
            get { throw new NotImplementedException(); }
        }

        bool ICollection.IsSynchronized
        {
            get { throw new NotImplementedException(); }
        }

        void ICollection.CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
