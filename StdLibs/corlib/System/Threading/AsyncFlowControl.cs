using System;
using System.Security;

namespace System.Threading
{
    /// <summary>Provides the functionality to restore the migration, or flow, of the execution context between threads.  </summary><filterpriority>2</filterpriority>
    public struct AsyncFlowControl : IDisposable
    {
    
        public void Dispose()
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public void Undo()
        {
             throw new NotImplementedException();
        }
        
        
        public override int GetHashCode()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether the specified object is equal to the current <see cref="T:System.Threading.AsyncFlowControl" /> structure. </summary><returns>true if <paramref name="obj" /> is an <see cref="T:System.Threading.AsyncFlowControl" /> structure and is equal to the current <see cref="T:System.Threading.AsyncFlowControl" /> structure; otherwise, false. </returns><param name="obj">An object to compare with the current structure.</param>
        public override bool Equals(object obj)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether the specified <see cref="T:System.Threading.AsyncFlowControl" /> structure is equal to the current <see cref="T:System.Threading.AsyncFlowControl" /> structure.</summary><returns>true if <paramref name="obj" /> is equal to the current <see cref="T:System.Threading.AsyncFlowControl" /> structure; otherwise, false.</returns><param name="obj">An <see cref="T:System.Threading.AsyncFlowControl" /> structure to compare with the current structure.</param>
        public bool Equals(AsyncFlowControl obj)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Compares two <see cref="T:System.Threading.AsyncFlowControl" /> structures to determine whether they are equal. </summary><returns>true if the two structures are equal; otherwise, false. </returns><param name="a">An <see cref="T:System.Threading.AsyncFlowControl" /> structure.</param><param name="b">An <see cref="T:System.Threading.AsyncFlowControl" /> structure.</param>
        /// <summary>Compares two <see cref="T:System.Threading.AsyncFlowControl" /> structures to determine whether they are equal. </summary><returns>true if the two structures are equal; otherwise, false. </returns><param name="a">An <see cref="T:System.Threading.AsyncFlowControl" /> structure.</param><param name="b">An <see cref="T:System.Threading.AsyncFlowControl" /> structure.</param>
        public static bool operator ==(AsyncFlowControl a, AsyncFlowControl b)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Compares two <see cref="T:System.Threading.AsyncFlowControl" /> structures to determine whether they are not equal. </summary><returns>true if the structures are not equal; otherwise, false. </returns><param name="a">An <see cref="T:System.Threading.AsyncFlowControl" /> structure.</param><param name="b">An <see cref="T:System.Threading.AsyncFlowControl" /> structure.</param>
        /// <summary>Compares two <see cref="T:System.Threading.AsyncFlowControl" /> structures to determine whether they are not equal. </summary><returns>true if the structures are not equal; otherwise, false. </returns><param name="a">An <see cref="T:System.Threading.AsyncFlowControl" /> structure.</param><param name="b">An <see cref="T:System.Threading.AsyncFlowControl" /> structure.</param>
        public static bool operator !=(AsyncFlowControl a, AsyncFlowControl b)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
