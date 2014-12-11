using System;
using System.Collections.Specialized;
using System.Runtime.InteropServices;

namespace System.Diagnostics
{
    public abstract class TraceListener : MarshalByRefObject, IDisposable
    {
    
        public StringDictionary Attributes
        {
            get { throw new NotImplementedException(); }
        }
    
        public virtual string Name
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public virtual bool IsThreadSafe
        {
            get { throw new NotImplementedException(); }
        }
    
        public int IndentLevel
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public int IndentSize
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        [ComVisibleAttribute(false)]
        public TraceFilter Filter
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        protected bool NeedIndent
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        [ComVisibleAttribute(false)]
        public TraceOptions TraceOutputOptions
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        protected TraceListener()
        {
             throw new NotImplementedException();
        }
        
        
        protected TraceListener(string name)
        {
             throw new NotImplementedException();
        }
        
        
        public void Dispose()
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual void Dispose(bool disposing)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual void Close()
        {
             throw new NotImplementedException();
        }
        
        
        public virtual void Flush()
        {
             throw new NotImplementedException();
        }
        
        
        public virtual void Fail(string message)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual void Fail(string message, string detailMessage)
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual string[] GetSupportedAttributes()
        {
             throw new NotImplementedException();
        }
        
        
        public abstract void Write(string message);
        
        
        public virtual void Write(object o)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual void Write(string message, string category)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual void Write(object o, string category)
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual void WriteIndent()
        {
             throw new NotImplementedException();
        }
        
        
        public abstract void WriteLine(string message);
        
        
        public virtual void WriteLine(object o)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual void WriteLine(string message, string category)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual void WriteLine(object o, string category)
        {
             throw new NotImplementedException();
        }
        
        
        [ComVisibleAttribute(false)]
        public virtual void TraceData(TraceEventCache eventCache, string source, TraceEventType eventType, int id, object data)
        {
             throw new NotImplementedException();
        }
        
        
        [ComVisibleAttribute(false)]
        public virtual void TraceData(TraceEventCache eventCache, string source, TraceEventType eventType, int id, params  object[] data)
        {
             throw new NotImplementedException();
        }
        
        
        [ComVisibleAttribute(false)]
        public virtual void TraceEvent(TraceEventCache eventCache, string source, TraceEventType eventType, int id)
        {
             throw new NotImplementedException();
        }
        
        
        [ComVisibleAttribute(false)]
        public virtual void TraceEvent(TraceEventCache eventCache, string source, TraceEventType eventType, int id, string message)
        {
             throw new NotImplementedException();
        }
        
        
        [ComVisibleAttribute(false)]
        public virtual void TraceEvent(TraceEventCache eventCache, string source, TraceEventType eventType, int id, string format, params  object[] args)
        {
             throw new NotImplementedException();
        }
        
        
        [ComVisibleAttribute(false)]
        public virtual void TraceTransfer(TraceEventCache eventCache, string source, int id, string message, Guid relatedActivityId)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
