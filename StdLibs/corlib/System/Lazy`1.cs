using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Threading;

namespace System
{
    /// <summary>Provides support for lazy initialization.</summary><typeparam name="T">Specifies the type of object that is being lazily initialized.</typeparam>
    [Serializable]
    [DebuggerDisplayAttribute("ThreadSafetyMode={Mode}, IsValueCreated={IsValueCreated}, IsValueFaulted={IsValueFaulted}, Value={ValueForDebugDisplay}")]
    [ComVisibleAttribute(false)]
    public class Lazy<T>
    {
    
        /// <summary>Gets a value that indicates whether a value has been created for this <see cref="T:System.Lazy`1" /> instance.</summary><returns>true if a value has been created for this <see cref="T:System.Lazy`1" /> instance; otherwise, false.</returns>
        public bool IsValueCreated
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the lazily initialized value of the current <see cref="T:System.Lazy`1" /> instance.</summary><returns>The lazily initialized value of the current <see cref="T:System.Lazy`1" /> instance.</returns><exception cref="T:System.MemberAccessException">The <see cref="T:System.Lazy`1" /> instance is initialized to use the default constructor of the type that is being lazily initialized, and permissions to access the constructor are missing.</exception><exception cref="T:System.MissingMemberException">The <see cref="T:System.Lazy`1" /> instance is initialized to use the default constructor of the type that is being lazily initialized, and that type does not have a public, parameterless constructor.</exception><exception cref="T:System.InvalidOperationException">The initialization function tries to access <see cref="P:System.Lazy`1.Value" /> on this instance.</exception>
        [DebuggerBrowsableAttribute(DebuggerBrowsableState.Never)]
        public T Value
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public Lazy()
        {
             throw new NotImplementedException();
        }
        
        
        public Lazy(Func<T> valueFactory)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Lazy`1" /> class. When lazy initialization occurs, the default constructor of the target type and the specified initialization mode are used.</summary><param name="isThreadSafe">true to make this instance usable concurrently by multiple threads; false to make the instance usable by only one thread at a time. </param>
        public Lazy(bool isThreadSafe)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Lazy`1" /> class that uses the default constructor of <paramref name="T" /> and the specified thread-safety mode.</summary><param name="mode">One of the enumeration values that specifies the thread safety mode. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="mode" /> contains an invalid value.</exception>
        public Lazy(LazyThreadSafetyMode mode)
        {
             throw new NotImplementedException();
        }
        
        
        public Lazy(Func<T> valueFactory, bool isThreadSafe)
        {
             throw new NotImplementedException();
        }
        
        
        public Lazy(Func<T> valueFactory, LazyThreadSafetyMode mode)
        {
             throw new NotImplementedException();
        }
        
        
        public override string ToString()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
