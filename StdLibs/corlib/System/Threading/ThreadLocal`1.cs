using System.Diagnostics;
using System;
using System.Collections.Generic;

namespace System.Threading
{
    /// <summary>Provides thread-local storage of data.</summary><typeparam name="T">Specifies the type of data stored per-thread.</typeparam>
    [DebuggerDisplayAttribute("IsValueCreated={IsValueCreated}, Value={ValueForDebugDisplay}, Count={ValuesCountForDebugDisplay}")]
    public class ThreadLocal<T> : IDisposable
    {
    
        /// <summary>Gets or sets the value of this instance for the current thread.</summary><returns>Returns an instance of the object that this ThreadLocal is responsible for initializing.</returns><exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Threading.ThreadLocal`1" /> instance has been disposed.</exception><exception cref="T:System.InvalidOperationException">The initialization function attempted to reference <see cref="P:System.Threading.ThreadLocal`1.Value" /> recursively.</exception><exception cref="T:System.MissingMemberException">No default constructor is provided and no value factory is supplied.</exception>
        [DebuggerBrowsableAttribute(DebuggerBrowsableState.Never)]
        public T Value
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a list for all of the values currently stored by all of the threads that have accessed this instance.</summary><returns>A list for all of the values currently stored by all of the threads that have accessed this instance.</returns><exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Threading.ThreadLocal`1" /> instance has been disposed.</exception>
        public IList<T> Values
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets whether <see cref="P:System.Threading.ThreadLocal`1.Value" /> is initialized on the current thread.</summary><returns>true if <see cref="P:System.Threading.ThreadLocal`1.Value" /> is initialized on the current thread; otherwise false.</returns><exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Threading.ThreadLocal`1" /> instance has been disposed.</exception>
        public bool IsValueCreated
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public ThreadLocal()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes the <see cref="T:System.Threading.ThreadLocal`1" /> instance.</summary><param name="trackAllValues">Whether to track all values set on the instance and expose them through the <see cref="P:System.Threading.ThreadLocal`1.Values" /> property.</param>
        public ThreadLocal(bool trackAllValues)
        {
             throw new NotImplementedException();
        }
        
        
        public ThreadLocal(Func<T> valueFactory)
        {
             throw new NotImplementedException();
        }
        
        
        public ThreadLocal(Func<T> valueFactory, bool trackAllValues)
        {
             throw new NotImplementedException();
        }
        
        
        ~ThreadLocal()
        {
             throw new NotImplementedException();
        }
        
        
        public void Dispose()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Releases the resources used by this <see cref="T:System.Threading.ThreadLocal`1" /> instance.</summary><param name="disposing">A Boolean value that indicates whether this method is being called due to a call to <see cref="M:System.Threading.ThreadLocal`1.Dispose" />.</param>
        protected virtual void Dispose(bool disposing)
        {
             throw new NotImplementedException();
        }
        
        
        public override string ToString()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
