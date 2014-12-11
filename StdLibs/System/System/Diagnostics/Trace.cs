
namespace System.Diagnostics
{
    public sealed class Trace
    {
    
        public static TraceListenerCollection Listeners
        {
            get { throw new NotImplementedException(); }
        }
    
        public static bool AutoFlush
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public static bool UseGlobalLock
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public static CorrelationManager CorrelationManager
        {
            get { throw new NotImplementedException(); }
        }
    
        public static int IndentLevel
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public static int IndentSize
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        [ConditionalAttribute("TRACE")]
        public static void Flush()
        {
             throw new NotImplementedException();
        }
        
        
        [ConditionalAttribute("TRACE")]
        public static void Close()
        {
             throw new NotImplementedException();
        }
        
        
        [ConditionalAttribute("TRACE")]
        public static void Assert(bool condition)
        {
             throw new NotImplementedException();
        }
        
        
        [ConditionalAttribute("TRACE")]
        public static void Assert(bool condition, string message)
        {
             throw new NotImplementedException();
        }
        
        
        [ConditionalAttribute("TRACE")]
        public static void Assert(bool condition, string message, string detailMessage)
        {
             throw new NotImplementedException();
        }
        
        
        [ConditionalAttribute("TRACE")]
        public static void Fail(string message)
        {
             throw new NotImplementedException();
        }
        
        
        [ConditionalAttribute("TRACE")]
        public static void Fail(string message, string detailMessage)
        {
             throw new NotImplementedException();
        }
        
        
        public static void Refresh()
        {
             throw new NotImplementedException();
        }
        
        
        [ConditionalAttribute("TRACE")]
        public static void TraceInformation(string message)
        {
             throw new NotImplementedException();
        }
        
        
        [ConditionalAttribute("TRACE")]
        public static void TraceInformation(string format, params  object[] args)
        {
             throw new NotImplementedException();
        }
        
        
        [ConditionalAttribute("TRACE")]
        public static void TraceWarning(string message)
        {
             throw new NotImplementedException();
        }
        
        
        [ConditionalAttribute("TRACE")]
        public static void TraceWarning(string format, params  object[] args)
        {
             throw new NotImplementedException();
        }
        
        
        [ConditionalAttribute("TRACE")]
        public static void TraceError(string message)
        {
             throw new NotImplementedException();
        }
        
        
        [ConditionalAttribute("TRACE")]
        public static void TraceError(string format, params  object[] args)
        {
             throw new NotImplementedException();
        }
        
        
        [ConditionalAttribute("TRACE")]
        public static void Write(string message)
        {
             throw new NotImplementedException();
        }
        
        
        [ConditionalAttribute("TRACE")]
        public static void Write(object value)
        {
             throw new NotImplementedException();
        }
        
        
        [ConditionalAttribute("TRACE")]
        public static void Write(string message, string category)
        {
             throw new NotImplementedException();
        }
        
        
        [ConditionalAttribute("TRACE")]
        public static void Write(object value, string category)
        {
             throw new NotImplementedException();
        }
        
        
        [ConditionalAttribute("TRACE")]
        public static void WriteLine(string message)
        {
             throw new NotImplementedException();
        }
        
        
        [ConditionalAttribute("TRACE")]
        public static void WriteLine(object value)
        {
             throw new NotImplementedException();
        }
        
        
        [ConditionalAttribute("TRACE")]
        public static void WriteLine(string message, string category)
        {
             throw new NotImplementedException();
        }
        
        
        [ConditionalAttribute("TRACE")]
        public static void WriteLine(object value, string category)
        {
             throw new NotImplementedException();
        }
        
        
        [ConditionalAttribute("TRACE")]
        public static void WriteIf(bool condition, string message)
        {
             throw new NotImplementedException();
        }
        
        
        [ConditionalAttribute("TRACE")]
        public static void WriteIf(bool condition, object value)
        {
             throw new NotImplementedException();
        }
        
        
        [ConditionalAttribute("TRACE")]
        public static void WriteIf(bool condition, string message, string category)
        {
             throw new NotImplementedException();
        }
        
        
        [ConditionalAttribute("TRACE")]
        public static void WriteIf(bool condition, object value, string category)
        {
             throw new NotImplementedException();
        }
        
        
        [ConditionalAttribute("TRACE")]
        public static void WriteLineIf(bool condition, string message)
        {
             throw new NotImplementedException();
        }
        
        
        [ConditionalAttribute("TRACE")]
        public static void WriteLineIf(bool condition, object value)
        {
             throw new NotImplementedException();
        }
        
        
        [ConditionalAttribute("TRACE")]
        public static void WriteLineIf(bool condition, string message, string category)
        {
             throw new NotImplementedException();
        }
        
        
        [ConditionalAttribute("TRACE")]
        public static void WriteLineIf(bool condition, object value, string category)
        {
             throw new NotImplementedException();
        }
        
        
        [ConditionalAttribute("TRACE")]
        public static void Indent()
        {
             throw new NotImplementedException();
        }
        
        
        [ConditionalAttribute("TRACE")]
        public static void Unindent()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
