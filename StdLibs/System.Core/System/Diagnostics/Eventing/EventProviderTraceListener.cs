using System.Diagnostics;
using System.Security;
using System;

namespace System.Diagnostics.Eventing
{
    public class EventProviderTraceListener : TraceListener
    {
    
        public string Delimiter
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public override bool IsThreadSafe
        {
            get { throw new NotImplementedException(); }
        }
    
    
        protected override string[] GetSupportedAttributes()
        {
             throw new NotImplementedException();
        }
        
        
        public EventProviderTraceListener(string providerId)
        {
             throw new NotImplementedException();
        }
        
        
        public EventProviderTraceListener(string providerId, string name)
        {
             throw new NotImplementedException();
        }
        
        
        public EventProviderTraceListener(string providerId, string name, string delimiter)
        {
             throw new NotImplementedException();
        }
        
        
        public override void Flush()
        {
             throw new NotImplementedException();
        }
        
        
        public override void Close()
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


        public override void TraceData(TraceEventCache eventCache, string source, TraceEventType eventType, int id, object data)
        {
             throw new NotImplementedException();
        }


        public override void TraceData(TraceEventCache eventCache, string source, TraceEventType eventType, int id, params  object[] data)
        {
             throw new NotImplementedException();
        }


        public override void TraceEvent(TraceEventCache eventCache, string source, TraceEventType eventType, int id)
        {
             throw new NotImplementedException();
        }


        public override void TraceEvent(TraceEventCache eventCache, string source, TraceEventType eventType, int id, string message)
        {
             throw new NotImplementedException();
        }


        public override void TraceEvent(TraceEventCache eventCache, string source, TraceEventType eventType, int id, string format, params  object[] args)
        {
             throw new NotImplementedException();
        }
        
        
        public override void Fail(string message, string detailMessage)
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        public override void TraceTransfer(TraceEventCache eventCache, string source, int id, string message, Guid relatedActivityId)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
