using System;
using System.Security;

namespace System.Diagnostics.PerformanceData
{
    public sealed class CounterSetInstanceCounterDataSet : IDisposable
    {
    
        public CounterData this[int counterId]
        {
            get { throw new NotImplementedException(); }
        }
    
        public CounterData this[string counterName]
        {
            get { throw new NotImplementedException(); }
        }
    
    
        [SecurityCriticalAttribute()]
        public void Dispose()
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        ~CounterSetInstanceCounterDataSet()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
