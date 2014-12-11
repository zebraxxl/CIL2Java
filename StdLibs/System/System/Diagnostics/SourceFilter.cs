
namespace System.Diagnostics
{
    public class SourceFilter : TraceFilter
    {
    
        public string Source
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public SourceFilter(string source)
        {
             throw new NotImplementedException();
        }
        
        
        public override bool ShouldTrace(TraceEventCache cache, string source, TraceEventType eventType, int id, string formatOrMessage, object[] args, object data1, object[] data)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
