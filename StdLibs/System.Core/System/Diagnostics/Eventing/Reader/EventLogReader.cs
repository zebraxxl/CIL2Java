using System;
using System.Collections.Generic;
using System.Security;
using System.IO;

namespace System.Diagnostics.Eventing.Reader
{
    public class EventLogReader : IDisposable
    {
    
        public int BatchSize
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public IList<EventLogStatus> LogStatus
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public EventLogReader(string path)
        {
             throw new NotImplementedException();
        }
        
        
        public EventLogReader(string path, PathType pathType)
        {
             throw new NotImplementedException();
        }
        
        
        public EventLogReader(EventLogQuery eventQuery)
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        public EventLogReader(EventLogQuery eventQuery, EventBookmark bookmark)
        {
             throw new NotImplementedException();
        }
        
        
        public EventRecord ReadEvent()
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        public EventRecord ReadEvent(TimeSpan timeout)
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
        
        
        public void Seek(EventBookmark bookmark)
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        public void Seek(EventBookmark bookmark, long offset)
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        public void Seek(SeekOrigin origin, long offset)
        {
             throw new NotImplementedException();
        }
        
        
        public void CancelReading()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
