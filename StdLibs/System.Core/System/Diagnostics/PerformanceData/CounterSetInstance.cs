using System;
using System.Security;

namespace System.Diagnostics.PerformanceData
{
    public sealed class CounterSetInstance : IDisposable
    {
    
        public CounterSetInstanceCounterDataSet Counters
        {
            get { throw new NotImplementedException(); }
        }
    
    
        [SecurityCriticalAttribute()]
        public void Dispose()
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        ~CounterSetInstance()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
