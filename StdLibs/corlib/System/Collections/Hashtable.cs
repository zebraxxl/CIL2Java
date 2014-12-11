using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System;
using System.Runtime.ConstrainedExecution;
using System.Security;

namespace System.Collections
{
    /// <summary>Represents a collection of key/value pairs that are organized based on the hash code of the key.</summary><filterpriority>1</filterpriority>
    [Serializable]
    [DebuggerDisplayAttribute("Count = {Count}")]
    [ComVisibleAttribute(true)]
    public class Hashtable : IDictionary, ISerializable, IDeserializationCallback, ICloneable
    {
    
        /// <summary>Gets or sets the object that can dispense hash codes.</summary><returns>The object that can dispense hash codes.</returns><exception cref="T:System.ArgumentException">The property is set to a value, but the hash table was created using an <see cref="T:System.Collections.IEqualityComparer" />. </exception>
        [ObsoleteAttribute("Please use EqualityComparer property.")]
        protected IHashCodeProvider hcp
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the <see cref="T:System.Collections.IComparer" /> to use for the <see cref="T:System.Collections.Hashtable" />.</summary><returns>The <see cref="T:System.Collections.IComparer" /> to use for the <see cref="T:System.Collections.Hashtable" />.</returns><exception cref="T:System.ArgumentException">The property is set to a value, but the hash table was created using an <see cref="T:System.Collections.IEqualityComparer" />. </exception>
        [ObsoleteAttribute("Please use KeyComparer properties.")]
        protected IComparer comparer
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the <see cref="T:System.Collections.IEqualityComparer" /> to use for the <see cref="T:System.Collections.Hashtable" />.</summary><returns>The <see cref="T:System.Collections.IEqualityComparer" /> to use for the <see cref="T:System.Collections.Hashtable" />.</returns><exception cref="T:System.ArgumentException">The property is set to a value, but the hash table was created using an <see cref="T:System.Collections.IHashCodeProvider" /> and an <see cref="T:System.Collections.IComparer" />. </exception>
        protected IEqualityComparer EqualityComparer
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the value associated with the specified key.</summary><returns>The value associated with the specified key. If the specified key is not found, attempting to get it returns null, and attempting to set it creates a new element using the specified key.</returns><param name="key">The key whose value to get or set. </param><exception cref="T:System.ArgumentNullException"><paramref name="key" /> is null. </exception><exception cref="T:System.NotSupportedException">The property is set and the <see cref="T:System.Collections.Hashtable" /> is read-only.-or- The property is set, <paramref name="key" /> does not exist in the collection, and the <see cref="T:System.Collections.Hashtable" /> has a fixed size. </exception><filterpriority>2</filterpriority>
        public virtual object this[object key]
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value indicating whether the <see cref="T:System.Collections.Hashtable" /> is read-only.</summary><returns>true if the <see cref="T:System.Collections.Hashtable" /> is read-only; otherwise, false. The default is false.</returns><filterpriority>2</filterpriority>
        public virtual bool IsReadOnly
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value indicating whether the <see cref="T:System.Collections.Hashtable" /> has a fixed size.</summary><returns>true if the <see cref="T:System.Collections.Hashtable" /> has a fixed size; otherwise, false. The default is false.</returns><filterpriority>2</filterpriority>
        public virtual bool IsFixedSize
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value indicating whether access to the <see cref="T:System.Collections.Hashtable" /> is synchronized (thread safe).</summary><returns>true if access to the <see cref="T:System.Collections.Hashtable" /> is synchronized (thread safe); otherwise, false. The default is false.</returns><filterpriority>2</filterpriority>
        public virtual bool IsSynchronized
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets an <see cref="T:System.Collections.ICollection" /> containing the keys in the <see cref="T:System.Collections.Hashtable" />.</summary><returns>An <see cref="T:System.Collections.ICollection" /> containing the keys in the <see cref="T:System.Collections.Hashtable" />.</returns><filterpriority>1</filterpriority>
        public virtual ICollection Keys
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets an <see cref="T:System.Collections.ICollection" /> containing the values in the <see cref="T:System.Collections.Hashtable" />.</summary><returns>An <see cref="T:System.Collections.ICollection" /> containing the values in the <see cref="T:System.Collections.Hashtable" />.</returns><filterpriority>1</filterpriority>
        public virtual ICollection Values
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets an object that can be used to synchronize access to the <see cref="T:System.Collections.Hashtable" />.</summary><returns>An object that can be used to synchronize access to the <see cref="T:System.Collections.Hashtable" />.</returns><filterpriority>2</filterpriority>
        public virtual object SyncRoot
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the number of key/value pairs contained in the <see cref="T:System.Collections.Hashtable" />.</summary><returns>The number of key/value pairs contained in the <see cref="T:System.Collections.Hashtable" />.</returns><filterpriority>1</filterpriority>
        public virtual int Count
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public Hashtable()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new, empty instance of the <see cref="T:System.Collections.Hashtable" /> class using the specified initial capacity, and the default load factor, hash code provider, and comparer.</summary><param name="capacity">The approximate number of elements that the <see cref="T:System.Collections.Hashtable" /> object can initially contain. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="capacity" /> is less than zero. </exception>
        public Hashtable(int capacity)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new, empty instance of the <see cref="T:System.Collections.Hashtable" /> class using the specified initial capacity and load factor, and the default hash code provider and comparer.</summary><param name="capacity">The approximate number of elements that the <see cref="T:System.Collections.Hashtable" /> object can initially contain. </param><param name="loadFactor">A number in the range from 0.1 through 1.0 that is multiplied by the default value which provides the best performance. The result is the maximum ratio of elements to buckets. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="capacity" /> is less than zero.-or- <paramref name="loadFactor" /> is less than 0.1.-or- <paramref name="loadFactor" /> is greater than 1.0. </exception><exception cref="T:System.ArgumentException"><paramref name="capacity" /> is causing an overflow.</exception>
        public Hashtable(int capacity, float loadFactor)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new, empty instance of the <see cref="T:System.Collections.Hashtable" /> class using the specified initial capacity, load factor, hash code provider, and comparer.</summary><param name="capacity">The approximate number of elements that the <see cref="T:System.Collections.Hashtable" /> object can initially contain. </param><param name="loadFactor">A number in the range from 0.1 through 1.0 that is multiplied by the default value which provides the best performance. The result is the maximum ratio of elements to buckets.</param><param name="hcp">The <see cref="T:System.Collections.IHashCodeProvider" /> object that supplies the hash codes for all keys in the <see cref="T:System.Collections.Hashtable" />.-or- null to use the default hash code provider, which is each key's implementation of <see cref="M:System.Object.GetHashCode" />. </param><param name="comparer">The <see cref="T:System.Collections.IComparer" /> object to use to determine whether two keys are equal.-or- null to use the default comparer, which is each key's implementation of <see cref="M:System.Object.Equals(System.Object)" />. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="capacity" /> is less than zero.-or- <paramref name="loadFactor" /> is less than 0.1.-or- <paramref name="loadFactor" /> is greater than 1.0. </exception>
        [ObsoleteAttribute("Please use Hashtable(int, float, IEqualityComparer) instead.")]
        public Hashtable(int capacity, float loadFactor, IHashCodeProvider hcp, IComparer comparer)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new, empty instance of the <see cref="T:System.Collections.Hashtable" /> class using the specified initial capacity, load factor, and <see cref="T:System.Collections.IEqualityComparer" /> object.</summary><param name="capacity">The approximate number of elements that the <see cref="T:System.Collections.Hashtable" /> object can initially contain. </param><param name="loadFactor">A number in the range from 0.1 through 1.0 that is multiplied by the default value which provides the best performance. The result is the maximum ratio of elements to buckets.</param><param name="equalityComparer">The <see cref="T:System.Collections.IEqualityComparer" /> object that defines the hash code provider and the comparer to use with the <see cref="T:System.Collections.Hashtable" />.-or- null to use the default hash code provider and the default comparer. The default hash code provider is each key's implementation of <see cref="M:System.Object.GetHashCode" /> and the default comparer is each key's implementation of <see cref="M:System.Object.Equals(System.Object)" />. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="capacity" /> is less than zero.-or- <paramref name="loadFactor" /> is less than 0.1.-or- <paramref name="loadFactor" /> is greater than 1.0. </exception>
        public Hashtable(int capacity, float loadFactor, IEqualityComparer equalityComparer)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new, empty instance of the <see cref="T:System.Collections.Hashtable" /> class using the default initial capacity and load factor, and the specified hash code provider and comparer.</summary><param name="hcp">The <see cref="T:System.Collections.IHashCodeProvider" /> object that supplies the hash codes for all keys in the <see cref="T:System.Collections.Hashtable" /> object.-or- null to use the default hash code provider, which is each key's implementation of <see cref="M:System.Object.GetHashCode" />.</param><param name="comparer">The <see cref="T:System.Collections.IComparer" /> object to use to determine whether two keys are equal.-or- null to use the default comparer, which is each key's implementation of <see cref="M:System.Object.Equals(System.Object)" />.</param>
        [ObsoleteAttribute("Please use Hashtable(IEqualityComparer) instead.")]
        public Hashtable(IHashCodeProvider hcp, IComparer comparer)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new, empty instance of the <see cref="T:System.Collections.Hashtable" /> class using the default initial capacity and load factor, and the specified <see cref="T:System.Collections.IEqualityComparer" /> object.</summary><param name="equalityComparer">The <see cref="T:System.Collections.IEqualityComparer" /> object that defines the hash code provider and the comparer to use with the <see cref="T:System.Collections.Hashtable" /> object.-or- null to use the default hash code provider and the default comparer. The default hash code provider is each key's implementation of <see cref="M:System.Object.GetHashCode" /> and the default comparer is each key's implementation of <see cref="M:System.Object.Equals(System.Object)" />. </param>
        public Hashtable(IEqualityComparer equalityComparer)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new, empty instance of the <see cref="T:System.Collections.Hashtable" /> class using the specified initial capacity, hash code provider, comparer, and the default load factor.</summary><param name="capacity">The approximate number of elements that the <see cref="T:System.Collections.Hashtable" /> object can initially contain. </param><param name="hcp">The <see cref="T:System.Collections.IHashCodeProvider" /> object that supplies the hash codes for all keys in the <see cref="T:System.Collections.Hashtable" />.-or- null to use the default hash code provider, which is each key's implementation of <see cref="M:System.Object.GetHashCode" />. </param><param name="comparer">The <see cref="T:System.Collections.IComparer" /> object to use to determine whether two keys are equal.-or- null to use the default comparer, which is each key's implementation of <see cref="M:System.Object.Equals(System.Object)" />. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="capacity" /> is less than zero. </exception>
        [ObsoleteAttribute("Please use Hashtable(int, IEqualityComparer) instead.")]
        public Hashtable(int capacity, IHashCodeProvider hcp, IComparer comparer)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new, empty instance of the <see cref="T:System.Collections.Hashtable" /> class using the specified initial capacity and <see cref="T:System.Collections.IEqualityComparer" />, and the default load factor.</summary><param name="capacity">The approximate number of elements that the <see cref="T:System.Collections.Hashtable" /> object can initially contain. </param><param name="equalityComparer">The <see cref="T:System.Collections.IEqualityComparer" /> object that defines the hash code provider and the comparer to use with the <see cref="T:System.Collections.Hashtable" />.-or- null to use the default hash code provider and the default comparer. The default hash code provider is each key's implementation of <see cref="M:System.Object.GetHashCode" /> and the default comparer is each key's implementation of <see cref="M:System.Object.Equals(System.Object)" />. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="capacity" /> is less than zero. </exception>
        public Hashtable(int capacity, IEqualityComparer equalityComparer)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Collections.Hashtable" /> class by copying the elements from the specified dictionary to the new <see cref="T:System.Collections.Hashtable" /> object. The new <see cref="T:System.Collections.Hashtable" /> object has an initial capacity equal to the number of elements copied, and uses the default load factor, hash code provider, and comparer.</summary><param name="d">The <see cref="T:System.Collections.IDictionary" /> object to copy to a new <see cref="T:System.Collections.Hashtable" /> object. </param><exception cref="T:System.ArgumentNullException"><paramref name="d" /> is null. </exception>
        public Hashtable(IDictionary d)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Collections.Hashtable" /> class by copying the elements from the specified dictionary to the new <see cref="T:System.Collections.Hashtable" /> object. The new <see cref="T:System.Collections.Hashtable" /> object has an initial capacity equal to the number of elements copied, and uses the specified load factor, and the default hash code provider and comparer.</summary><param name="d">The <see cref="T:System.Collections.IDictionary" /> object to copy to a new <see cref="T:System.Collections.Hashtable" /> object.</param><param name="loadFactor">A number in the range from 0.1 through 1.0 that is multiplied by the default value which provides the best performance. The result is the maximum ratio of elements to buckets.</param><exception cref="T:System.ArgumentNullException"><paramref name="d" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="loadFactor" /> is less than 0.1.-or- <paramref name="loadFactor" /> is greater than 1.0. </exception>
        public Hashtable(IDictionary d, float loadFactor)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Collections.Hashtable" /> class by copying the elements from the specified dictionary to the new <see cref="T:System.Collections.Hashtable" /> object. The new <see cref="T:System.Collections.Hashtable" /> object has an initial capacity equal to the number of elements copied, and uses the default load factor, and the specified hash code provider and comparer. This API is obsolete. For an alternative, see <see cref="M:System.Collections.Hashtable.#ctor(System.Collections.IDictionary,System.Collections.IEqualityComparer)" />.</summary><param name="d">The <see cref="T:System.Collections.IDictionary" /> object to copy to a new <see cref="T:System.Collections.Hashtable" /> object.</param><param name="hcp">The <see cref="T:System.Collections.IHashCodeProvider" /> object that supplies the hash codes for all keys in the <see cref="T:System.Collections.Hashtable" />.-or- null to use the default hash code provider, which is each key's implementation of <see cref="M:System.Object.GetHashCode" />. </param><param name="comparer">The <see cref="T:System.Collections.IComparer" /> object to use to determine whether two keys are equal.-or- null to use the default comparer, which is each key's implementation of <see cref="M:System.Object.Equals(System.Object)" />. </param><exception cref="T:System.ArgumentNullException"><paramref name="d" /> is null. </exception>
        [ObsoleteAttribute("Please use Hashtable(IDictionary, IEqualityComparer) instead.")]
        public Hashtable(IDictionary d, IHashCodeProvider hcp, IComparer comparer)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Collections.Hashtable" /> class by copying the elements from the specified dictionary to a new <see cref="T:System.Collections.Hashtable" /> object. The new <see cref="T:System.Collections.Hashtable" /> object has an initial capacity equal to the number of elements copied, and uses the default load factor and the specified <see cref="T:System.Collections.IEqualityComparer" /> object.</summary><param name="d">The <see cref="T:System.Collections.IDictionary" /> object to copy to a new <see cref="T:System.Collections.Hashtable" /> object.</param><param name="equalityComparer">The <see cref="T:System.Collections.IEqualityComparer" /> object that defines the hash code provider and the comparer to use with the <see cref="T:System.Collections.Hashtable" />.-or- null to use the default hash code provider and the default comparer. The default hash code provider is each key's implementation of <see cref="M:System.Object.GetHashCode" /> and the default comparer is each key's implementation of <see cref="M:System.Object.Equals(System.Object)" />. </param><exception cref="T:System.ArgumentNullException"><paramref name="d" /> is null. </exception>
        public Hashtable(IDictionary d, IEqualityComparer equalityComparer)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Collections.Hashtable" /> class by copying the elements from the specified dictionary to the new <see cref="T:System.Collections.Hashtable" /> object. The new <see cref="T:System.Collections.Hashtable" /> object has an initial capacity equal to the number of elements copied, and uses the specified load factor, hash code provider, and comparer.</summary><param name="d">The <see cref="T:System.Collections.IDictionary" /> object to copy to a new <see cref="T:System.Collections.Hashtable" /> object.</param><param name="loadFactor">A number in the range from 0.1 through 1.0 that is multiplied by the default value which provides the best performance. The result is the maximum ratio of elements to buckets.</param><param name="hcp">The <see cref="T:System.Collections.IHashCodeProvider" /> object that supplies the hash codes for all keys in the <see cref="T:System.Collections.Hashtable" />.-or- null to use the default hash code provider, which is each key's implementation of <see cref="M:System.Object.GetHashCode" />. </param><param name="comparer">The <see cref="T:System.Collections.IComparer" /> object to use to determine whether two keys are equal.-or- null to use the default comparer, which is each key's implementation of <see cref="M:System.Object.Equals(System.Object)" />. </param><exception cref="T:System.ArgumentNullException"><paramref name="d" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="loadFactor" /> is less than 0.1.-or- <paramref name="loadFactor" /> is greater than 1.0. </exception>
        [ObsoleteAttribute("Please use Hashtable(IDictionary, float, IEqualityComparer) instead.")]
        public Hashtable(IDictionary d, float loadFactor, IHashCodeProvider hcp, IComparer comparer)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Collections.Hashtable" /> class by copying the elements from the specified dictionary to the new <see cref="T:System.Collections.Hashtable" /> object. The new <see cref="T:System.Collections.Hashtable" /> object has an initial capacity equal to the number of elements copied, and uses the specified load factor and <see cref="T:System.Collections.IEqualityComparer" /> object.</summary><param name="d">The <see cref="T:System.Collections.IDictionary" /> object to copy to a new <see cref="T:System.Collections.Hashtable" /> object.</param><param name="loadFactor">A number in the range from 0.1 through 1.0 that is multiplied by the default value which provides the best performance. The result is the maximum ratio of elements to buckets.</param><param name="equalityComparer">The <see cref="T:System.Collections.IEqualityComparer" /> object that defines the hash code provider and the comparer to use with the <see cref="T:System.Collections.Hashtable" />.-or- null to use the default hash code provider and the default comparer. The default hash code provider is each key's implementation of <see cref="M:System.Object.GetHashCode" /> and the default comparer is each key's implementation of <see cref="M:System.Object.Equals(System.Object)" />. </param><exception cref="T:System.ArgumentNullException"><paramref name="d" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="loadFactor" /> is less than 0.1.-or- <paramref name="loadFactor" /> is greater than 1.0. </exception>
        public Hashtable(IDictionary d, float loadFactor, IEqualityComparer equalityComparer)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new, empty instance of the <see cref="T:System.Collections.Hashtable" /> class that is serializable using the specified <see cref="T:System.Runtime.Serialization.SerializationInfo" /> and <see cref="T:System.Runtime.Serialization.StreamingContext" /> objects.</summary><param name="info">A <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object containing the information required to serialize the <see cref="T:System.Collections.Hashtable" /> object.</param><param name="context">A <see cref="T:System.Runtime.Serialization.StreamingContext" /> object containing the source and destination of the serialized stream associated with the <see cref="T:System.Collections.Hashtable" />. </param><exception cref="T:System.ArgumentNullException"><paramref name="info" /> is null. </exception>
        protected Hashtable(SerializationInfo info, StreamingContext context)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Adds an element with the specified key and value into the <see cref="T:System.Collections.Hashtable" />.</summary><param name="key">The key of the element to add. </param><param name="value">The value of the element to add. The value can be null. </param><exception cref="T:System.ArgumentNullException"><paramref name="key" /> is null. </exception><exception cref="T:System.ArgumentException">An element with the same key already exists in the <see cref="T:System.Collections.Hashtable" />. </exception><exception cref="T:System.NotSupportedException">The <see cref="T:System.Collections.Hashtable" /> is read-only.-or- The <see cref="T:System.Collections.Hashtable" /> has a fixed size. </exception><filterpriority>1</filterpriority>
        public virtual void Add(object key, object value)
        {
             throw new NotImplementedException();
        }
        
        
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.Success)]
        public virtual void Clear()
        {
             throw new NotImplementedException();
        }
        
        
        public virtual object Clone()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether the <see cref="T:System.Collections.Hashtable" /> contains a specific key.</summary><returns>true if the <see cref="T:System.Collections.Hashtable" /> contains an element with the specified key; otherwise, false.</returns><param name="key">The key to locate in the <see cref="T:System.Collections.Hashtable" />. </param><exception cref="T:System.ArgumentNullException"><paramref name="key" /> is null. </exception><filterpriority>1</filterpriority>
        public virtual bool Contains(object key)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether the <see cref="T:System.Collections.Hashtable" /> contains a specific key.</summary><returns>true if the <see cref="T:System.Collections.Hashtable" /> contains an element with the specified key; otherwise, false.</returns><param name="key">The key to locate in the <see cref="T:System.Collections.Hashtable" />. </param><exception cref="T:System.ArgumentNullException"><paramref name="key" /> is null. </exception><filterpriority>1</filterpriority>
        public virtual bool ContainsKey(object key)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether the <see cref="T:System.Collections.Hashtable" /> contains a specific value.</summary><returns>true if the <see cref="T:System.Collections.Hashtable" /> contains an element with the specified <paramref name="value" />; otherwise, false.</returns><param name="value">The value to locate in the <see cref="T:System.Collections.Hashtable" />. The value can be null. </param><filterpriority>1</filterpriority>
        public virtual bool ContainsValue(object value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Copies the <see cref="T:System.Collections.Hashtable" /> elements to a one-dimensional <see cref="T:System.Array" /> instance at the specified index.</summary><param name="array">The one-dimensional <see cref="T:System.Array" /> that is the destination of the <see cref="T:System.Collections.DictionaryEntry" /> objects copied from <see cref="T:System.Collections.Hashtable" />. The <see cref="T:System.Array" /> must have zero-based indexing. </param><param name="arrayIndex">The zero-based index in <paramref name="array" /> at which copying begins. </param><exception cref="T:System.ArgumentNullException"><paramref name="array" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="arrayIndex" /> is less than zero. </exception><exception cref="T:System.ArgumentException"><paramref name="array" /> is multidimensional.-or- The number of elements in the source <see cref="T:System.Collections.Hashtable" /> is greater than the available space from <paramref name="arrayIndex" /> to the end of the destination <paramref name="array" />. </exception><exception cref="T:System.InvalidCastException">The type of the source <see cref="T:System.Collections.Hashtable" /> cannot be cast automatically to the type of the destination <paramref name="array" />. </exception><filterpriority>2</filterpriority>
        public virtual void CopyTo(Array array, int arrayIndex)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual IDictionaryEnumerator GetEnumerator()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the hash code for the specified key.</summary><returns>The hash code for <paramref name="key" />.</returns><param name="key">The <see cref="T:System.Object" /> for which a hash code is to be returned. </param><exception cref="T:System.NullReferenceException"><paramref name="key" /> is null. </exception>
        protected virtual int GetHash(object key)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Compares a specific <see cref="T:System.Object" /> with a specific key in the <see cref="T:System.Collections.Hashtable" />.</summary><returns>true if <paramref name="item" /> and <paramref name="key" /> are equal; otherwise, false.</returns><param name="item">The <see cref="T:System.Object" /> to compare with <paramref name="key" />. </param><param name="key">The key in the <see cref="T:System.Collections.Hashtable" /> to compare with <paramref name="item" />. </param><exception cref="T:System.ArgumentNullException"><paramref name="item" /> is null.-or- <paramref name="key" /> is null. </exception>
        protected virtual bool KeyEquals(object item, object key)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Removes the element with the specified key from the <see cref="T:System.Collections.Hashtable" />.</summary><param name="key">The key of the element to remove. </param><exception cref="T:System.ArgumentNullException"><paramref name="key" /> is null. </exception><exception cref="T:System.NotSupportedException">The <see cref="T:System.Collections.Hashtable" /> is read-only.-or- The <see cref="T:System.Collections.Hashtable" /> has a fixed size. </exception><filterpriority>1</filterpriority>
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.MayFail)]
        public virtual void Remove(object key)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a synchronized (thread-safe) wrapper for the <see cref="T:System.Collections.Hashtable" />.</summary><returns>A synchronized (thread-safe) wrapper for the <see cref="T:System.Collections.Hashtable" />.</returns><param name="table">The <see cref="T:System.Collections.Hashtable" /> to synchronize. </param><exception cref="T:System.ArgumentNullException"><paramref name="table" /> is null. </exception><filterpriority>1</filterpriority>
        public static Hashtable Synchronized(Hashtable table)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Implements the <see cref="T:System.Runtime.Serialization.ISerializable" /> interface and returns the data needed to serialize the <see cref="T:System.Collections.Hashtable" />.</summary><param name="info">A <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object containing the information required to serialize the <see cref="T:System.Collections.Hashtable" />. </param><param name="context">A <see cref="T:System.Runtime.Serialization.StreamingContext" /> object containing the source and destination of the serialized stream associated with the <see cref="T:System.Collections.Hashtable" />. </param><exception cref="T:System.ArgumentNullException"><paramref name="info" /> is null. </exception><exception cref="T:System.InvalidOperationException">The collection was modified.</exception><filterpriority>2</filterpriority>
        [SecurityCriticalAttribute()]
        public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Implements the <see cref="T:System.Runtime.Serialization.ISerializable" /> interface and raises the deserialization event when the deserialization is complete.</summary><param name="sender">The source of the deserialization event. </param><exception cref="T:System.Runtime.Serialization.SerializationException">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object associated with the current <see cref="T:System.Collections.Hashtable" /> is invalid. </exception><filterpriority>2</filterpriority>
        public virtual void OnDeserialization(object sender)
        {
             throw new NotImplementedException();
        }



        object IDictionary.this[object key]
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        ICollection IDictionary.Keys
        {
            get { throw new NotImplementedException(); }
        }

        ICollection IDictionary.Values
        {
            get { throw new NotImplementedException(); }
        }

        bool IDictionary.IsReadOnly
        {
            get { throw new NotImplementedException(); }
        }

        bool IDictionary.IsFixedSize
        {
            get { throw new NotImplementedException(); }
        }

        bool IDictionary.Contains(object key)
        {
            throw new NotImplementedException();
        }

        void IDictionary.Add(object key, object value)
        {
            throw new NotImplementedException();
        }

        void IDictionary.Clear()
        {
            throw new NotImplementedException();
        }

        IDictionaryEnumerator IDictionary.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        void IDictionary.Remove(object key)
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
