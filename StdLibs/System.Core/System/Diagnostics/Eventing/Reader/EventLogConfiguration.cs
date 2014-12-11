using System;
using System.Collections.Generic;
using System.Security;

namespace System.Diagnostics.Eventing.Reader
{
    public class EventLogConfiguration : IDisposable
    {
    
        public string LogName
        {
            get { throw new NotImplementedException(); }
        }
    
        public EventLogType LogType
        {
            get { throw new NotImplementedException(); }
        }
    
        public EventLogIsolation LogIsolation
        {
            get { throw new NotImplementedException(); }
        }
    
        public bool IsEnabled
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public bool IsClassicLog
        {
            get { throw new NotImplementedException(); }
        }
    
        public string SecurityDescriptor
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public string LogFilePath
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public long MaximumSizeInBytes
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public EventLogMode LogMode
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public string OwningProviderName
        {
            get { throw new NotImplementedException(); }
        }
    
        public IEnumerable<string> ProviderNames
        {
            get { throw new NotImplementedException(); }
        }
    
        public Nullable<int> ProviderLevel
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public Nullable<long> ProviderKeywords
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public Nullable<int> ProviderBufferSize
        {
            get { throw new NotImplementedException(); }
        }
    
        public Nullable<int> ProviderMinimumNumberOfBuffers
        {
            get { throw new NotImplementedException(); }
        }
    
        public Nullable<int> ProviderMaximumNumberOfBuffers
        {
            get { throw new NotImplementedException(); }
        }
    
        public Nullable<int> ProviderLatency
        {
            get { throw new NotImplementedException(); }
        }
    
        public Nullable<Guid> ProviderControlGuid
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public EventLogConfiguration(string logName)
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        public EventLogConfiguration(string logName, EventLogSession session)
        {
             throw new NotImplementedException();
        }
        
        
        public void SaveChanges()
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
