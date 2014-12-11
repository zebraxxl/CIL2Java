using System.Runtime.InteropServices;
using System;
using System.Threading;

namespace System.Diagnostics
{
    /// <summary>Represents a stack trace, which is an ordered collection of one or more stack frames.</summary><filterpriority>2</filterpriority>
    [Serializable]
    [ComVisibleAttribute(true)]
    public class StackTrace
    {
        /// <summary>Defines the default for the number of methods to omit from the stack trace. This field is constant.</summary><filterpriority>1</filterpriority>
        public const int METHODS_TO_SKIP = 0;
    
        /// <summary>Gets the number of frames in the stack trace.</summary><returns>The number of frames in the stack trace. </returns><filterpriority>2</filterpriority>
        public virtual int FrameCount
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public StackTrace()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.StackTrace" /> class from the caller's frame, optionally capturing source information.</summary><param name="fNeedFileInfo">true to capture the file name, line number, and column number; otherwise, false. </param>
        public StackTrace(bool fNeedFileInfo)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.StackTrace" /> class from the caller's frame, skipping the specified number of frames.</summary><param name="skipFrames">The number of frames up the stack from which to start the trace. </param><exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="skipFrames" /> parameter is negative. </exception>
        public StackTrace(int skipFrames)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.StackTrace" /> class from the caller's frame, skipping the specified number of frames and optionally capturing source information.</summary><param name="skipFrames">The number of frames up the stack from which to start the trace. </param><param name="fNeedFileInfo">true to capture the file name, line number, and column number; otherwise, false. </param><exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="skipFrames" /> parameter is negative. </exception>
        public StackTrace(int skipFrames, bool fNeedFileInfo)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.StackTrace" /> class using the provided exception object.</summary><param name="e">The exception object from which to construct the stack trace. </param><exception cref="T:System.ArgumentNullException">The parameter <paramref name="e" /> is null. </exception>
        public StackTrace(Exception e)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.StackTrace" /> class, using the provided exception object and optionally capturing source information.</summary><param name="e">The exception object from which to construct the stack trace. </param><param name="fNeedFileInfo">true to capture the file name, line number, and column number; otherwise, false. </param><exception cref="T:System.ArgumentNullException">The parameter <paramref name="e" /> is null. </exception>
        public StackTrace(Exception e, bool fNeedFileInfo)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.StackTrace" /> class using the provided exception object and skipping the specified number of frames.</summary><param name="e">The exception object from which to construct the stack trace. </param><param name="skipFrames">The number of frames up the stack from which to start the trace. </param><exception cref="T:System.ArgumentNullException">The parameter <paramref name="e" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="skipFrames" /> parameter is negative. </exception>
        public StackTrace(Exception e, int skipFrames)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.StackTrace" /> class using the provided exception object, skipping the specified number of frames and optionally capturing source information.</summary><param name="e">The exception object from which to construct the stack trace. </param><param name="skipFrames">The number of frames up the stack from which to start the trace. </param><param name="fNeedFileInfo">true to capture the file name, line number, and column number; otherwise, false. </param><exception cref="T:System.ArgumentNullException">The parameter <paramref name="e" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="skipFrames" /> parameter is negative. </exception>
        public StackTrace(Exception e, int skipFrames, bool fNeedFileInfo)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.StackTrace" /> class that contains a single frame.</summary><param name="frame">The frame that the <see cref="T:System.Diagnostics.StackTrace" /> object should contain. </param>
        public StackTrace(StackFrame frame)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.StackTrace" /> class for a specific thread, optionally capturing source information. Do not use this constructor overload.</summary><param name="targetThread">The thread whose stack trace is requested. </param><param name="needFileInfo">true to capture the file name, line number, and column number; otherwise, false. </param><exception cref="T:System.Threading.ThreadStateException">The thread <paramref name="targetThread" /> is not suspended. </exception>
        [ObsoleteAttribute("This constructor has been deprecated.  Please use a constructor that does not require a Thread parameter.  http://go.microsoft.com/fwlink/?linkid=14202")]
        public StackTrace(Thread targetThread, bool needFileInfo)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Gets the specified stack frame.</summary><returns>The specified stack frame.</returns><param name="index">The index of the stack frame requested. </param><filterpriority>2</filterpriority>
        public virtual StackFrame GetFrame(int index)
        {
             throw new NotImplementedException();
        }
        
        
        [ComVisibleAttribute(false)]
        public virtual StackFrame[] GetFrames()
        {
             throw new NotImplementedException();
        }
        
        
        public override string ToString()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
