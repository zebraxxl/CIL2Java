using System.Security;

namespace System.Diagnostics.PerformanceData
{
    public sealed class CounterData
    {
    
        public long Value
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public long RawValue
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        [SecurityCriticalAttribute()]
        public void Increment()
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        public void Decrement()
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        public void IncrementBy(long value)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
