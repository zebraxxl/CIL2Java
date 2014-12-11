
namespace System.Diagnostics
{
    public abstract class TraceFilter
    {
    
        public abstract bool ShouldTrace(TraceEventCache cache, string source, TraceEventType eventType, int id, string formatOrMessage, object[] args, object data1, object[] data);
        
        
        protected TraceFilter()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
