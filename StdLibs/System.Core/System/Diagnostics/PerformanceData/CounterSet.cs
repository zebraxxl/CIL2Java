using System;
using System.Security;

namespace System.Diagnostics.PerformanceData
{
    public class CounterSet : IDisposable
    {
    
        [SecuritySafeCriticalAttribute()]
        public CounterSet(Guid providerGuid, Guid counterSetGuid, CounterSetInstanceType instanceType)
        {
             throw new NotImplementedException();
        }
        
        
        public void Dispose()
        {
             throw new NotImplementedException();
        }
        
        
        ~CounterSet()
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        protected virtual void Dispose(bool disposing)
        {
             throw new NotImplementedException();
        }
        
        
        public void AddCounter(int counterId, CounterType counterType)
        {
             throw new NotImplementedException();
        }
        
        
        public void AddCounter(int counterId, CounterType counterType, string counterName)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public CounterSetInstance CreateCounterSetInstance(string instanceName)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
