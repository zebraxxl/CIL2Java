using System.Security;
using System;

namespace System.Runtime.InteropServices
{
    /// <summary>Provides methods that enable .NET Framework delegates that handle events to be added and removed from COM objects.</summary>
    public static class ComEventsHelper
    {
        /// <summary>Adds a delegate to the invocation list of events originating from a COM object.</summary><param name="rcw">The COM object that triggers the events the caller would like to respond to.</param><param name="iid">The identifier of the source interface used by the COM object to trigger events. </param><param name="dispid">The dispatch identifier of the method on the source interface.</param><param name="d">The delegate to invoke when the COM event is fired.</param>
        [SecurityCriticalAttribute()]
        public static void Combine(object rcw, Guid iid, int dispid, Delegate d)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Removes a delegate from the invocation list of events originating from a COM object.</summary><returns>The delegate that was removed from the invocation list.</returns><param name="rcw">The COM object the delegate is attached to.</param><param name="iid">The identifier of the source interface used by the COM object to trigger events. </param><param name="dispid">The dispatch identifier of the method on the source interface.</param><param name="d">The delegate to remove from the invocation list.</param>
        [SecurityCriticalAttribute()]
        public static Delegate Remove(object rcw, Guid iid, int dispid, Delegate d)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
