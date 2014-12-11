using System.Collections.Specialized;
using System;

namespace System.Diagnostics
{
    public class TraceSource
    {
    
        public StringDictionary Attributes
        {
            get { throw new NotImplementedException(); }
        }
    
        public string Name
        {
            get { throw new NotImplementedException(); }
        }
    
        public TraceListenerCollection Listeners
        {
            get { throw new NotImplementedException(); }
        }
    
        public SourceSwitch Switch
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public TraceSource(string name)
        {
             throw new NotImplementedException();
        }
        
        
        public TraceSource(string name, SourceLevels defaultLevel)
        {
             throw new NotImplementedException();
        }
        
        
        public void Close()
        {
             throw new NotImplementedException();
        }
        
        
        public void Flush()
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual string[] GetSupportedAttributes()
        {
             throw new NotImplementedException();
        }
        
        
        [ConditionalAttribute("TRACE")]
        public void TraceEvent(TraceEventType eventType, int id)
        {
             throw new NotImplementedException();
        }
        
        
        [ConditionalAttribute("TRACE")]
        public void TraceEvent(TraceEventType eventType, int id, string message)
        {
             throw new NotImplementedException();
        }
        
        
        [ConditionalAttribute("TRACE")]
        public void TraceEvent(TraceEventType eventType, int id, string format, params  object[] args)
        {
             throw new NotImplementedException();
        }
        
        
        [ConditionalAttribute("TRACE")]
        public void TraceData(TraceEventType eventType, int id, object data)
        {
             throw new NotImplementedException();
        }
        
        
        [ConditionalAttribute("TRACE")]
        public void TraceData(TraceEventType eventType, int id, params  object[] data)
        {
             throw new NotImplementedException();
        }
        
        
        [ConditionalAttribute("TRACE")]
        public void TraceInformation(string message)
        {
             throw new NotImplementedException();
        }
        
        
        [ConditionalAttribute("TRACE")]
        public void TraceInformation(string format, params  object[] args)
        {
             throw new NotImplementedException();
        }
        
        
        [ConditionalAttribute("TRACE")]
        public void TraceTransfer(int id, string message, Guid relatedActivityId)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
