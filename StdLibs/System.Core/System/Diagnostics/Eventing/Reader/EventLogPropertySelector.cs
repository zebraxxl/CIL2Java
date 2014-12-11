using System;
using System.Security;
using System.Collections.Generic;

namespace System.Diagnostics.Eventing.Reader
{
    public class EventLogPropertySelector : IDisposable
    {
    
    
        [SecurityCriticalAttribute()]
        public EventLogPropertySelector(IEnumerable<string> propertyQueries)
        {
             throw new NotImplementedException();
        }
        
        
        public void Dispose()
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        protected virtual void Dispose(bool disposing)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
