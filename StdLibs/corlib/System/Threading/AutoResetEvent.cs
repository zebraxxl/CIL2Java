using System.Runtime.InteropServices;

namespace System.Threading
{
    /// <summary>Notifies a waiting thread that an event has occurred. This class cannot be inherited.</summary><filterpriority>2</filterpriority>
    [ComVisibleAttribute(true)]
    public sealed class AutoResetEvent : EventWaitHandle
    {
        /// <summary>Initializes a new instance of the <see cref="T:System.Threading.AutoResetEvent" /> class with a Boolean value indicating whether to set the initial state to signaled.</summary><param name="initialState">true to set the initial state to signaled; false to set the initial state to non-signaled. </param>
        public AutoResetEvent(bool initialState)
            : base(initialState, EventResetMode.AutoReset)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
