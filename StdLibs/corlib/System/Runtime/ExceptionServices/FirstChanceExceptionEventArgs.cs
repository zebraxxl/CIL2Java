using System;
using System.Runtime.ConstrainedExecution;

namespace System.Runtime.ExceptionServices
{
    /// <summary>Provides data for the notification event that is raised when a managed exception first occurs, before the common language runtime begins searching for event handlers.</summary>
    public class FirstChanceExceptionEventArgs : EventArgs
    {
    
        /// <summary>The managed exception object that corresponds to the exception thrown in managed code.</summary><returns>The newly thrown exception.</returns>
        public Exception Exception
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Runtime.ExceptionServices.FirstChanceExceptionEventArgs" /> class with a specified exception.</summary><param name="exception">The exception that was just thrown by managed code, and that will be examined by the <see cref="E:System.AppDomain.UnhandledException" /> event. </param>
        public FirstChanceExceptionEventArgs(Exception exception)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
