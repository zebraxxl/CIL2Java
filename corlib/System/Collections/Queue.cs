using System.Diagnostics;
using System.Runtime.InteropServices;
using System;

namespace System.Collections
{
    /// <summary>Represents a first-in, first-out collection of objects.</summary><filterpriority>1</filterpriority>
    [Serializable]
    [DebuggerDisplayAttribute("Count = {Count}")]
    [ComVisibleAttribute(true)]
    public class Queue : ICollection, ICloneable
    {
    
        /// <summary>Gets the number of elements contained in the <see cref="T:System.Collections.Queue" />.</summary><returns>The number of elements contained in the <see cref="T:System.Collections.Queue" />.</returns><filterpriority>2</filterpriority>
        public virtual int Count
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value indicating whether access to the <see cref="T:System.Collections.Queue" /> is synchronized (thread safe).</summary><returns>true if access to the <see cref="T:System.Collections.Queue" /> is synchronized (thread safe); otherwise, false. The default is false.</returns><filterpriority>2</filterpriority>
        public virtual bool IsSynchronized
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets an object that can be used to synchronize access to the <see cref="T:System.Collections.Queue" />.</summary><returns>An object that can be used to synchronize access to the <see cref="T:System.Collections.Queue" />.</returns><filterpriority>2</filterpriority>
        public virtual object SyncRoot
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public Queue()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Collections.Queue" /> class that is empty, has the specified initial capacity, and uses the default growth factor.</summary><param name="capacity">The initial number of elements that the <see cref="T:System.Collections.Queue" /> can contain. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="capacity" /> is less than zero. </exception>
        public Queue(int capacity)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Collections.Queue" /> class that is empty, has the specified initial capacity, and uses the specified growth factor.</summary><param name="capacity">The initial number of elements that the <see cref="T:System.Collections.Queue" /> can contain. </param><param name="growFactor">The factor by which the capacity of the <see cref="T:System.Collections.Queue" /> is expanded. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="capacity" /> is less than zero.-or- <paramref name="growFactor" /> is less than 1.0 or greater than 10.0. </exception>
        public Queue(int capacity, float growFactor)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Collections.Queue" /> class that contains elements copied from the specified collection, has the same initial capacity as the number of elements copied, and uses the default growth factor.</summary><param name="col">The <see cref="T:System.Collections.ICollection" /> to copy elements from. </param><exception cref="T:System.ArgumentNullException"><paramref name="col" /> is null. </exception>
        public Queue(ICollection col)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual object Clone()
        {
             throw new NotImplementedException();
        }
        
        
        public virtual void Clear()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Copies the <see cref="T:System.Collections.Queue" /> elements to an existing one-dimensional <see cref="T:System.Array" />, starting at the specified array index.</summary><param name="array">The one-dimensional <see cref="T:System.Array" /> that is the destination of the elements copied from <see cref="T:System.Collections.Queue" />. The <see cref="T:System.Array" /> must have zero-based indexing. </param><param name="index">The zero-based index in <paramref name="array" /> at which copying begins. </param><exception cref="T:System.ArgumentNullException"><paramref name="array" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> is less than zero. </exception><exception cref="T:System.ArgumentException"><paramref name="array" /> is multidimensional.-or- The number of elements in the source <see cref="T:System.Collections.Queue" /> is greater than the available space from <paramref name="index" /> to the end of the destination <paramref name="array" />. </exception><exception cref="T:System.ArrayTypeMismatchException">The type of the source <see cref="T:System.Collections.Queue" /> cannot be cast automatically to the type of the destination <paramref name="array" />. </exception><filterpriority>2</filterpriority>
        public virtual void CopyTo(Array array, int index)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Adds an object to the end of the <see cref="T:System.Collections.Queue" />.</summary><param name="obj">The object to add to the <see cref="T:System.Collections.Queue" />. The value can be null. </param><filterpriority>2</filterpriority>
        public virtual void Enqueue(object obj)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual IEnumerator GetEnumerator()
        {
             throw new NotImplementedException();
        }
        
        
        public virtual object Dequeue()
        {
             throw new NotImplementedException();
        }
        
        
        public virtual object Peek()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a <see cref="T:System.Collections.Queue" /> wrapper that is synchronized (thread safe).</summary><returns>A <see cref="T:System.Collections.Queue" /> wrapper that is synchronized (thread safe).</returns><param name="queue">The <see cref="T:System.Collections.Queue" /> to synchronize. </param><exception cref="T:System.ArgumentNullException"><paramref name="queue" /> is null. </exception><filterpriority>2</filterpriority>
        public static Queue Synchronized(Queue queue)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether an element is in the <see cref="T:System.Collections.Queue" />.</summary><returns>true if <paramref name="obj" /> is found in the <see cref="T:System.Collections.Queue" />; otherwise, false.</returns><param name="obj">The <see cref="T:System.Object" /> to locate in the <see cref="T:System.Collections.Queue" />. The value can be null. </param><filterpriority>2</filterpriority>
        public virtual bool Contains(object obj)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual object[] ToArray()
        {
             throw new NotImplementedException();
        }
        
        
        public virtual void TrimToSize()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
