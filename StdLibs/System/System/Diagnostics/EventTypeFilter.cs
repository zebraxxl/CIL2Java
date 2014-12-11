
namespace System.Diagnostics
{
    public class EventTypeFilter : TraceFilter
    {
    
        public SourceLevels EventType
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public EventTypeFilter(SourceLevels level)
        {
             throw new NotImplementedException();
        }
        
        
        public override bool ShouldTrace(TraceEventCache cache, string source, TraceEventType eventType, int id, string formatOrMessage, object[] args, object data1, object[] data)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
