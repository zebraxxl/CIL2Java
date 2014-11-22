using System.Runtime.InteropServices;
using System.Diagnostics;
using System;

namespace System.Collections
{
    /// <summary>Represents a simple last-in-first-out (LIFO) non-generic collection of objects.</summary><filterpriority>1</filterpriority>
    [Serializable]
    [ComVisibleAttribute(true)]
    [DebuggerDisplayAttribute("Count = {Count}")]
    public class Stack : ICollection, ICloneable
    {
    
        /// <summary>Gets the number of elements contained in the <see cref="T:System.Collections.Stack" />.</summary><returns>The number of elements contained in the <see cref="T:System.Collections.Stack" />.</returns><filterpriority>2</filterpriority>
        public virtual int Count
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value indicating whether access to the <see cref="T:System.Collections.Stack" /> is synchronized (thread safe).</summary><returns>true, if access to the <see cref="T:System.Collections.Stack" /> is synchronized (thread safe); otherwise, false. The default is false.</returns><filterpriority>2</filterpriority>
        public virtual bool IsSynchronized
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets an object that can be used to synchronize access to the <see cref="T:System.Collections.Stack" />.</summary><returns>An <see cref="T:System.Object" /> that can be used to synchronize access to the <see cref="T:System.Collections.Stack" />.</returns><filterpriority>2</filterpriority>
        public virtual object SyncRoot
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public Stack()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Collections.Stack" /> class that is empty and has the specified initial capacity or the default initial capacity, whichever is greater.</summary><param name="initialCapacity">The initial number of elements that the <see cref="T:System.Collections.Stack" /> can contain. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="initialCapacity" /> is less than zero. </exception>
        public Stack(int initialCapacity)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Collections.Stack" /> class that contains elements copied from the specified collection and has the same initial capacity as the number of elements copied.</summary><param name="col">The <see cref="T:System.Collections.ICollection" /> to copy elements from. </param><exception cref="T:System.ArgumentNullException"><paramref name="col" /> is null. </exception>
        public Stack(ICollection col)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual void Clear()
        {
             throw new NotImplementedException();
        }
        
        
        public virtual object Clone()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether an element is in the <see cref="T:System.Collections.Stack" />.</summary><returns>true, if <paramref name="obj" /> is found in the <see cref="T:System.Collections.Stack" />; otherwise, false.</returns><param name="obj">The <see cref="T:System.Object" /> to locate in the <see cref="T:System.Collections.Stack" />. The value can be null. </param><filterpriority>2</filterpriority>
        public virtual bool Contains(object obj)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Copies the <see cref="T:System.Collections.Stack" /> to an existing one-dimensional <see cref="T:System.Array" />, starting at the specified array index.</summary><param name="array">The one-dimensional <see cref="T:System.Array" /> that is the destination of the elements copied from <see cref="T:System.Collections.Stack" />. The <see cref="T:System.Array" /> must have zero-based indexing. </param><param name="index">The zero-based index in <paramref name="array" /> at which copying begins. </param><exception cref="T:System.ArgumentNullException"><paramref name="array" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> is less than zero. </exception><exception cref="T:System.ArgumentException"><paramref name="array" /> is multidimensional.-or- The number of elements in the source <see cref="T:System.Collections.Stack" /> is greater than the available space from <paramref name="index" /> to the end of the destination <paramref name="array" />. </exception><exception cref="T:System.InvalidCastException">The type of the source <see cref="T:System.Collections.Stack" /> cannot be cast automatically to the type of the destination <paramref name="array" />. </exception><filterpriority>2</filterpriority>
        public virtual void CopyTo(Array array, int index)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual IEnumerator GetEnumerator()
        {
             throw new NotImplementedException();
        }
        
        
        public virtual object Peek()
        {
             throw new NotImplementedException();
        }
        
        
        public virtual object Pop()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Inserts an object at the top of the <see cref="T:System.Collections.Stack" />.</summary><param name="obj">The <see cref="T:System.Object" /> to push onto the <see cref="T:System.Collections.Stack" />. The value can be null. </param><filterpriority>2</filterpriority>
        public virtual void Push(object obj)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a synchronized (thread safe) wrapper for the <see cref="T:System.Collections.Stack" />.</summary><returns>A synchronized wrapper around the <see cref="T:System.Collections.Stack" />.</returns><param name="stack">The <see cref="T:System.Collections.Stack" /> to synchronize. </param><exception cref="T:System.ArgumentNullException"><paramref name="stack" /> is null. </exception><filterpriority>2</filterpriority>
        public static Stack Synchronized(Stack stack)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual object[] ToArray()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
