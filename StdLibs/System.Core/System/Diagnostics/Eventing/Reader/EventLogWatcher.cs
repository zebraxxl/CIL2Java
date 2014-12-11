using System;
using System.Security;

namespace System.Diagnostics.Eventing.Reader
{
    public class EventLogWatcher : IDisposable
    {
    
#pragma warning disable 0067
        public event EventHandler<EventRecordWrittenEventArgs> EventRecordWritten;
#pragma warning restore 0067

        public bool Enabled
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public EventLogWatcher(string path)
        {
             throw new NotImplementedException();
        }
        
        
        public EventLogWatcher(EventLogQuery eventQuery)
        {
             throw new NotImplementedException();
        }
        
        
        public EventLogWatcher(EventLogQuery eventQuery, EventBookmark bookmark)
        {
             throw new NotImplementedException();
        }
        
        
        public EventLogWatcher(EventLogQuery eventQuery, EventBookmark bookmark, bool readExistingEvents)
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
