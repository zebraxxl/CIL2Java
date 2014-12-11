using System;

namespace System.Threading.Tasks
{
    /// <summary>Provides data for the event that is raised when a faulted <see cref="T:System.Threading.Tasks.Task" />'s exception goes unobserved.</summary>
    public class UnobservedTaskExceptionEventArgs : EventArgs
    {
    
        /// <summary>Gets whether this exception has been marked as "observed."</summary><returns>true if this exception has been marked as "observed"; otherwise false.</returns>
        public bool Observed
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>The Exception that went unobserved.</summary><returns>The Exception that went unobserved.</returns>
        public AggregateException Exception
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Threading.Tasks.UnobservedTaskExceptionEventArgs" /> class with the unobserved exception.</summary><param name="exception">The Exception that has gone unobserved.</param>
        public UnobservedTaskExceptionEventArgs(AggregateException exception)
        {
             throw new NotImplementedException();
        }
        
        
        public void SetObserved()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
