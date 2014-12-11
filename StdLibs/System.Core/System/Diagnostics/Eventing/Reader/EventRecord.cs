using System;
using System.Security.Principal;
using System.Collections.Generic;

namespace System.Diagnostics.Eventing.Reader
{
    public abstract class EventRecord : IDisposable
    {
        public abstract int Id
        {
            get;
        }
    
        public abstract Nullable<byte> Version
        {
            get;
        }
    
        public abstract Nullable<byte> Level
        {
            get;
        }
    
        public abstract Nullable<int> Task
        {
            get;
        }
    
        public abstract Nullable<short> Opcode
        {
            get;
        }
    
        public abstract Nullable<long> Keywords
        {
            get;
        }
    
        public abstract Nullable<long> RecordId
        {
            get;
        }
    
        public abstract string ProviderName
        {
            get;
        }
    
        public abstract Nullable<Guid> ProviderId
        {
            get;
        }
    
        public abstract string LogName
        {
            get;
        }
    
        public abstract Nullable<int> ProcessId
        {
            get;
        }
    
        public abstract Nullable<int> ThreadId
        {
            get;
        }
    
        public abstract string MachineName
        {
            get;
        }
    
        public abstract SecurityIdentifier UserId
        {
            get;
        }
    
        public abstract Nullable<DateTime> TimeCreated
        {
            get;
        }
    
        public abstract Nullable<Guid> ActivityId
        {
            get;
        }
    
        public abstract Nullable<Guid> RelatedActivityId
        {
            get;
        }
    
        public abstract Nullable<int> Qualifiers
        {
            get;
        }
    
        public abstract string LevelDisplayName
        {
            get;
        }
    
        public abstract string OpcodeDisplayName
        {
            get;
        }
    
        public abstract string TaskDisplayName
        {
            get;
        }
    
        public abstract IEnumerable<string> KeywordsDisplayNames
        {
            get;
        }
    
        public abstract EventBookmark Bookmark
        {
            get;
        }
    
        public abstract IList<EventProperty> Properties
        {
            get;
        }
    
    
        public abstract string FormatDescription();
        
        
        public abstract string FormatDescription(IEnumerable<object> values);
        
        
        public abstract string ToXml();
        
        
        public void Dispose()
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual void Dispose(bool disposing)
        {
             throw new NotImplementedException();
        }
        
        
        protected EventRecord()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
