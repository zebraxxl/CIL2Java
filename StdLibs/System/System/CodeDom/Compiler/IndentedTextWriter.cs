using System.IO;
using System.Text;

namespace System.CodeDom.Compiler
{
    public class IndentedTextWriter : TextWriter
    {
        public const string DefaultTabString = "    ";
    
        public override Encoding Encoding
        {
            get { throw new NotImplementedException(); }
        }
    
        public override string NewLine
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public int Indent
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public TextWriter InnerWriter
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public IndentedTextWriter(TextWriter writer)
        {
             throw new NotImplementedException();
        }
        
        
        public IndentedTextWriter(TextWriter writer, string tabString)
        {
             throw new NotImplementedException();
        }
        
        
        public override void Close()
        {
             throw new NotImplementedException();
        }
        
        
        public override void Flush()
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual void OutputTabs()
        {
             throw new NotImplementedException();
        }
        
        
        public override void Write(string s)
        {
             throw new NotImplementedException();
        }
        
        
        public override void Write(bool value)
        {
             throw new NotImplementedException();
        }
        
        
        public override void Write(char value)
        {
             throw new NotImplementedException();
        }
        
        
        public override void Write(char[] buffer)
        {
             throw new NotImplementedException();
        }
        
        
        public override void Write(char[] buffer, int index, int count)
        {
             throw new NotImplementedException();
        }
        
        
        public override void Write(double value)
        {
             throw new NotImplementedException();
        }
        
        
        public override void Write(float value)
        {
             throw new NotImplementedException();
        }
        
        
        public override void Write(int value)
        {
             throw new NotImplementedException();
        }
        
        
        public override void Write(long value)
        {
             throw new NotImplementedException();
        }
        
        
        public override void Write(object value)
        {
             throw new NotImplementedException();
        }
        
        
        public override void Write(string format, object arg0)
        {
             throw new NotImplementedException();
        }
        
        
        public override void Write(string format, object arg0, object arg1)
        {
             throw new NotImplementedException();
        }
        
        
        public override void Write(string format, params  object[] arg)
        {
             throw new NotImplementedException();
        }
        
        
        public void WriteLineNoTabs(string s)
        {
             throw new NotImplementedException();
        }
        
        
        public override void WriteLine(string s)
        {
             throw new NotImplementedException();
        }
        
        
        public override void WriteLine()
        {
             throw new NotImplementedException();
        }
        
        
        public override void WriteLine(bool value)
        {
             throw new NotImplementedException();
        }
        
        
        public override void WriteLine(char value)
        {
             throw new NotImplementedException();
        }
        
        
        public override void WriteLine(char[] buffer)
        {
             throw new NotImplementedException();
        }
        
        
        public override void WriteLine(char[] buffer, int index, int count)
        {
             throw new NotImplementedException();
        }
        
        
        public override void WriteLine(double value)
        {
             throw new NotImplementedException();
        }
        
        
        public override void WriteLine(float value)
        {
             throw new NotImplementedException();
        }
        
        
        public override void WriteLine(int value)
        {
             throw new NotImplementedException();
        }
        
        
        public override void WriteLine(long value)
        {
             throw new NotImplementedException();
        }
        
        
        public override void WriteLine(object value)
        {
             throw new NotImplementedException();
        }
        
        
        public override void WriteLine(string format, object arg0)
        {
             throw new NotImplementedException();
        }
        
        
        public override void WriteLine(string format, object arg0, object arg1)
        {
             throw new NotImplementedException();
        }
        
        
        public override void WriteLine(string format, params  object[] arg)
        {
             throw new NotImplementedException();
        }
        
        
        public override void WriteLine(uint value)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
