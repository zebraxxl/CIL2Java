using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Reflection;
using System.Security;

namespace System.Diagnostics
{
    /// <summary>Provides information about a <see cref="T:System.Diagnostics.StackFrame" />, which represents a function call on the call stack for the current thread.</summary><filterpriority>2</filterpriority>
    [Serializable]
    [ComVisibleAttribute(true)]
    public class StackFrame
    {
        /// <summary>Defines the value that is returned from the <see cref="M:System.Diagnostics.StackFrame.GetNativeOffset" /> or <see cref="M:System.Diagnostics.StackFrame.GetILOffset" /> method when the native or Microsoft intermediate language (MSIL) offset is unknown. This field is constant.</summary><filterpriority>1</filterpriority>
        public const int OFFSET_UNKNOWN = -1;
    
        public StackFrame()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.StackFrame" /> class, optionally capturing source information.</summary><param name="fNeedFileInfo">true to capture the file name, line number, and column number of the stack frame; otherwise, false. </param>
        public StackFrame(bool fNeedFileInfo)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.StackFrame" /> class that corresponds to a frame above the current stack frame.</summary><param name="skipFrames">The number of frames up the stack to skip. </param>
        public StackFrame(int skipFrames)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.StackFrame" /> class that corresponds to a frame above the current stack frame, optionally capturing source information.</summary><param name="skipFrames">The number of frames up the stack to skip. </param><param name="fNeedFileInfo">true to capture the file name, line number, and column number of the stack frame; otherwise, false. </param>
        public StackFrame(int skipFrames, bool fNeedFileInfo)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.StackFrame" /> class that contains only the given file name and line number.</summary><param name="fileName">The file name. </param><param name="lineNumber">The line number in the specified file. </param>
        public StackFrame(string fileName, int lineNumber)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.StackFrame" /> class that contains only the given file name, line number, and column number.</summary><param name="fileName">The file name. </param><param name="lineNumber">The line number in the specified file. </param><param name="colNumber">The column number in the specified file. </param>
        public StackFrame(string fileName, int lineNumber, int colNumber)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual MethodBase GetMethod()
        {
             throw new NotImplementedException();
        }
        
        
        public virtual int GetNativeOffset()
        {
             throw new NotImplementedException();
        }
        
        
        public virtual int GetILOffset()
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public virtual string GetFileName()
        {
             throw new NotImplementedException();
        }
        
        
        public virtual int GetFileLineNumber()
        {
             throw new NotImplementedException();
        }
        
        
        public virtual int GetFileColumnNumber()
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public override string ToString()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
