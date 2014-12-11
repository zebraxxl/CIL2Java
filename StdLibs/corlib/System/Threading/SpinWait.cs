using System;

namespace System.Threading
{
    /// <summary>Provides support for spin-based waiting.</summary>
    public struct SpinWait
    {
    
        /// <summary>Gets the number of times <see cref="M:System.Threading.SpinWait.SpinOnce" /> has been called on this instance.</summary><returns>Returns an integer that represents the number of times <see cref="M:System.Threading.SpinWait.SpinOnce" /> has been called on this instance.</returns>
        public int Count
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets whether the next call to <see cref="M:System.Threading.SpinWait.SpinOnce" /> will yield the processor, triggering a forced context switch.</summary><returns>Whether the next call to <see cref="M:System.Threading.SpinWait.SpinOnce" /> will yield the processor, triggering a forced context switch.</returns>
        public bool NextSpinWillYield
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public void SpinOnce()
        {
             throw new NotImplementedException();
        }
        
        
        public void Reset()
        {
             throw new NotImplementedException();
        }
        
        
        public static void SpinUntil(Func<bool> condition)
        {
             throw new NotImplementedException();
        }
        
        
        public static bool SpinUntil(Func<bool> condition, TimeSpan timeout)
        {
             throw new NotImplementedException();
        }
        
        
        public static bool SpinUntil(Func<bool> condition, int millisecondsTimeout)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
