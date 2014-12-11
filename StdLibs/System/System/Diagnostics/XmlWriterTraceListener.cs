using System.IO;
using System;

namespace System.Diagnostics
{
    public class XmlWriterTraceListener : TextWriterTraceListener
    {
    
        public XmlWriterTraceListener(Stream stream)
        {
             throw new NotImplementedException();
        }
        
        
        public XmlWriterTraceListener(Stream stream, string name)
        {
             throw new NotImplementedException();
        }
        
        
        public XmlWriterTraceListener(TextWriter writer)
        {
             throw new NotImplementedException();
        }
        
        
        public XmlWriterTraceListener(TextWriter writer, string name)
        {
             throw new NotImplementedException();
        }
        
        
        public XmlWriterTraceListener(string filename)
        {
             throw new NotImplementedException();
        }
        
        
        public XmlWriterTraceListener(string filename, string name)
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
        
        
        public override void Fail(string message, string detailMessage)
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
        
        
        public override void Close()
        {
             throw new NotImplementedException();
        }
        
        
        public override void TraceTransfer(TraceEventCache eventCache, string source, int id, string message, Guid relatedActivityId)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
