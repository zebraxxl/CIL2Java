
namespace System.Diagnostics
{
    public static class Debug
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
    
    
        [ConditionalAttribute("DEBUG")]
        public static void Flush()
        {
             throw new NotImplementedException();
        }
        
        
        [ConditionalAttribute("DEBUG")]
        public static void Close()
        {
             throw new NotImplementedException();
        }
        
        
        [ConditionalAttribute("DEBUG")]
        public static void Assert(bool condition)
        {
             throw new NotImplementedException();
        }
        
        
        [ConditionalAttribute("DEBUG")]
        public static void Assert(bool condition, string message)
        {
             throw new NotImplementedException();
        }
        
        
        [ConditionalAttribute("DEBUG")]
        public static void Assert(bool condition, string message, string detailMessage)
        {
             throw new NotImplementedException();
        }
        
        
        [ConditionalAttribute("DEBUG")]
        public static void Assert(bool condition, string message, string detailMessageFormat, params  object[] args)
        {
             throw new NotImplementedException();
        }
        
        
        [ConditionalAttribute("DEBUG")]
        public static void Fail(string message)
        {
             throw new NotImplementedException();
        }
        
        
        [ConditionalAttribute("DEBUG")]
        public static void Fail(string message, string detailMessage)
        {
             throw new NotImplementedException();
        }
        
        
        [ConditionalAttribute("DEBUG")]
        public static void Print(string message)
        {
             throw new NotImplementedException();
        }
        
        
        [ConditionalAttribute("DEBUG")]
        public static void Print(string format, params  object[] args)
        {
             throw new NotImplementedException();
        }
        
        
        [ConditionalAttribute("DEBUG")]
        public static void Write(string message)
        {
             throw new NotImplementedException();
        }
        
        
        [ConditionalAttribute("DEBUG")]
        public static void Write(object value)
        {
             throw new NotImplementedException();
        }
        
        
        [ConditionalAttribute("DEBUG")]
        public static void Write(string message, string category)
        {
             throw new NotImplementedException();
        }
        
        
        [ConditionalAttribute("DEBUG")]
        public static void Write(object value, string category)
        {
             throw new NotImplementedException();
        }
        
        
        [ConditionalAttribute("DEBUG")]
        public static void WriteLine(string message)
        {
             throw new NotImplementedException();
        }
        
        
        [ConditionalAttribute("DEBUG")]
        public static void WriteLine(object value)
        {
             throw new NotImplementedException();
        }
        
        
        [ConditionalAttribute("DEBUG")]
        public static void WriteLine(string message, string category)
        {
             throw new NotImplementedException();
        }
        
        
        [ConditionalAttribute("DEBUG")]
        public static void WriteLine(object value, string category)
        {
             throw new NotImplementedException();
        }
        
        
        [ConditionalAttribute("DEBUG")]
        public static void WriteLine(string format, params  object[] args)
        {
             throw new NotImplementedException();
        }
        
        
        [ConditionalAttribute("DEBUG")]
        public static void WriteIf(bool condition, string message)
        {
             throw new NotImplementedException();
        }
        
        
        [ConditionalAttribute("DEBUG")]
        public static void WriteIf(bool condition, object value)
        {
             throw new NotImplementedException();
        }
        
        
        [ConditionalAttribute("DEBUG")]
        public static void WriteIf(bool condition, string message, string category)
        {
             throw new NotImplementedException();
        }
        
        
        [ConditionalAttribute("DEBUG")]
        public static void WriteIf(bool condition, object value, string category)
        {
             throw new NotImplementedException();
        }
        
        
        [ConditionalAttribute("DEBUG")]
        public static void WriteLineIf(bool condition, string message)
        {
             throw new NotImplementedException();
        }
        
        
        [ConditionalAttribute("DEBUG")]
        public static void WriteLineIf(bool condition, object value)
        {
             throw new NotImplementedException();
        }
        
        
        [ConditionalAttribute("DEBUG")]
        public static void WriteLineIf(bool condition, string message, string category)
        {
             throw new NotImplementedException();
        }
        
        
        [ConditionalAttribute("DEBUG")]
        public static void WriteLineIf(bool condition, object value, string category)
        {
             throw new NotImplementedException();
        }
        
        
        [ConditionalAttribute("DEBUG")]
        public static void Indent()
        {
             throw new NotImplementedException();
        }
        
        
        [ConditionalAttribute("DEBUG")]
        public static void Unindent()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
