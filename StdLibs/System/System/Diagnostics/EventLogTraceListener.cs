using System.Runtime.InteropServices;

namespace System.Diagnostics
{
    public sealed class EventLogTraceListener : TraceListener
    {
    
        public EventLog EventLog
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public override string Name
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public EventLogTraceListener()
        {
             throw new NotImplementedException();
        }
        
        
        public EventLogTraceListener(EventLog eventLog)
        {
             throw new NotImplementedException();
        }
        
        
        public EventLogTraceListener(string source)
        {
             throw new NotImplementedException();
        }
        
        
        public override void Close()
        {
             throw new NotImplementedException();
        }
        
        
        protected override void Dispose(bool disposing)
        {
             throw new NotImplementedException();
        }
        
        
        public override void Write(string message)
        {
             throw new NotImplementedException();
        }
        
        
        public override void WriteLine(string message)
        {
             throw new NotImplementedException();
        }
        
        
        [ComVisibleAttribute(false)]
        public override void TraceEvent(TraceEventCache eventCache, string source, TraceEventType severity, int id, string format, params  object[] args)
        {
             throw new NotImplementedException();
        }
        
        
        [ComVisibleAttribute(false)]
        public override void TraceEvent(TraceEventCache eventCache, string source, TraceEventType severity, int id, string message)
        {
             throw new NotImplementedException();
        }
        
        
        [ComVisibleAttribute(false)]
        public override void TraceData(TraceEventCache eventCache, string source, TraceEventType severity, int id, object data)
        {
             throw new NotImplementedException();
        }
        
        
        [ComVisibleAttribute(false)]
        public override void TraceData(TraceEventCache eventCache, string source, TraceEventType severity, int id, params  object[] data)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
