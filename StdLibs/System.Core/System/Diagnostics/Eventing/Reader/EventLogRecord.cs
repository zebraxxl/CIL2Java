using System.Security;
using System;
using System.Security.Principal;
using System.Collections.Generic;

namespace System.Diagnostics.Eventing.Reader
{
    public class EventLogRecord : EventRecord
    {
    
        public override int Id
        {
            get { throw new NotImplementedException(); }
        }
    
        public override Nullable<byte> Version
        {
            get { throw new NotImplementedException(); }
        }
    
        public override Nullable<int> Qualifiers
        {
            get { throw new NotImplementedException(); }
        }
    
        public override Nullable<byte> Level
        {
            get { throw new NotImplementedException(); }
        }
    
        public override Nullable<int> Task
        {
            get { throw new NotImplementedException(); }
        }
    
        public override Nullable<short> Opcode
        {
            get { throw new NotImplementedException(); }
        }
    
        public override Nullable<long> Keywords
        {
            get { throw new NotImplementedException(); }
        }
    
        public override Nullable<long> RecordId
        {
            get { throw new NotImplementedException(); }
        }
    
        public override string ProviderName
        {
            get { throw new NotImplementedException(); }
        }
    
        public override Nullable<Guid> ProviderId
        {
            get { throw new NotImplementedException(); }
        }
    
        public override string LogName
        {
            get { throw new NotImplementedException(); }
        }
    
        public override Nullable<int> ProcessId
        {
            get { throw new NotImplementedException(); }
        }
    
        public override Nullable<int> ThreadId
        {
            get { throw new NotImplementedException(); }
        }
    
        public override string MachineName
        {
            get { throw new NotImplementedException(); }
        }
    
        public override SecurityIdentifier UserId
        {
            get { throw new NotImplementedException(); }
        }
    
        public override Nullable<DateTime> TimeCreated
        {
            get { throw new NotImplementedException(); }
        }
    
        public override Nullable<Guid> ActivityId
        {
            get { throw new NotImplementedException(); }
        }
    
        public override Nullable<Guid> RelatedActivityId
        {
            get { throw new NotImplementedException(); }
        }
    
        public string ContainerLog
        {
            get { throw new NotImplementedException(); }
        }
    
        public IEnumerable<int> MatchedQueryIds
        {
            get { throw new NotImplementedException(); }
        }
    
        public override EventBookmark Bookmark
        {
            get { throw new NotImplementedException(); }
        }
    
        public override string LevelDisplayName
        {
            get { throw new NotImplementedException(); }
        }
    
        public override string OpcodeDisplayName
        {
            get { throw new NotImplementedException(); }
        }
    
        public override string TaskDisplayName
        {
            get { throw new NotImplementedException(); }
        }
    
        public override IEnumerable<string> KeywordsDisplayNames
        {
            get { throw new NotImplementedException(); }
        }
    
        public override IList<EventProperty> Properties
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public override string FormatDescription()
        {
             throw new NotImplementedException();
        }
        
        
        public override string FormatDescription(IEnumerable<object> values)
        {
             throw new NotImplementedException();
        }
        
        
        public IList<object> GetPropertyValues(EventLogPropertySelector propertySelector)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public override string ToXml()
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        protected override void Dispose(bool disposing)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
