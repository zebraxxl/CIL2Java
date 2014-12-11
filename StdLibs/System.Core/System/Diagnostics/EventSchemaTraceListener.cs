using System.IO;
using System.Security;
using System;

namespace System.Diagnostics
{
    public class EventSchemaTraceListener : TextWriterTraceListener
    {
    
        public new TextWriter Writer
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public override bool IsThreadSafe
        {
            get { throw new NotImplementedException(); }
        }
    
        public int BufferSize
        {
            get { throw new NotImplementedException(); }
        }
    
        public TraceLogRetentionOption TraceLogRetentionOption
        {
            get { throw new NotImplementedException(); }
        }
    
        public long MaximumFileSize
        {
            get { throw new NotImplementedException(); }
        }
    
        public int MaximumNumberOfFiles
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public EventSchemaTraceListener(string fileName)
        {
             throw new NotImplementedException();
        }
        
        
        public EventSchemaTraceListener(string fileName, string name)
        {
             throw new NotImplementedException();
        }
        
        
        public EventSchemaTraceListener(string fileName, string name, int bufferSize)
        {
             throw new NotImplementedException();
        }
        
        
        public EventSchemaTraceListener(string fileName, string name, int bufferSize, TraceLogRetentionOption logRetentionOption)
        {
             throw new NotImplementedException();
        }
        
        
        public EventSchemaTraceListener(string fileName, string name, int bufferSize, TraceLogRetentionOption logRetentionOption, long maximumFileSize)
        {
             throw new NotImplementedException();
        }
        
        
        public EventSchemaTraceListener(string fileName, string name, int bufferSize, TraceLogRetentionOption logRetentionOption, long maximumFileSize, int maximumNumberOfFiles)
        {
             throw new NotImplementedException();
        }
        
        
        public override void Close()
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        public override void Flush()
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
        
        
        [SecurityCriticalAttribute()]
        public override void TraceEvent(TraceEventCache eventCache, string source, TraceEventType eventType, int id, string format, params  object[] args)
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        public override void TraceEvent(TraceEventCache eventCache, string source, TraceEventType eventType, int id, string message)
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        public override void TraceData(TraceEventCache eventCache, string source, TraceEventType eventType, int id, object data)
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        public override void TraceData(TraceEventCache eventCache, string source, TraceEventType eventType, int id, params  object[] data)
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        public override void TraceTransfer(TraceEventCache eventCache, string source, int id, string message, Guid relatedActivityId)
        {
             throw new NotImplementedException();
        }
        
        
        protected override string[] GetSupportedAttributes()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
