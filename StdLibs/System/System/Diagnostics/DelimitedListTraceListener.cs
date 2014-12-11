using System.IO;

namespace System.Diagnostics
{
    public class DelimitedListTraceListener : TextWriterTraceListener
    {
    
        public string Delimiter
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public DelimitedListTraceListener(Stream stream)
        {
             throw new NotImplementedException();
        }
        
        
        public DelimitedListTraceListener(Stream stream, string name)
        {
             throw new NotImplementedException();
        }
        
        
        public DelimitedListTraceListener(TextWriter writer)
        {
             throw new NotImplementedException();
        }
        
        
        public DelimitedListTraceListener(TextWriter writer, string name)
        {
             throw new NotImplementedException();
        }
        
        
        public DelimitedListTraceListener(string fileName)
        {
             throw new NotImplementedException();
        }
        
        
        public DelimitedListTraceListener(string fileName, string name)
        {
             throw new NotImplementedException();
        }
        
        
        protected override string[] GetSupportedAttributes()
        {
             throw new NotImplementedException();
        }
        
        
        public override void TraceEvent(TraceEventCache eventCache, string source, TraceEventType eventType, int id, string format, params  object[] args)
        {
             throw new NotImplementedException();
        }
        
        
        public override void TraceEvent(TraceEventCache eventCache, string source, TraceEventType eventType, int id, string message)
        {
             throw new NotImplementedException();
        }
        
        
        public override void TraceData(TraceEventCache eventCache, string source, TraceEventType eventType, int id, object data)
        {
             throw new NotImplementedException();
        }
        
        
        public override void TraceData(TraceEventCache eventCache, string source, TraceEventType eventType, int id, params  object[] data)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
