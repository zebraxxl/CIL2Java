
namespace System.Runtime.InteropServices.WindowsRuntime
{
    /// <summary>Stores mappings between delegates and event tokens, to support the implementation of a Windows Runtime event in managed code.</summary><typeparam name="T">The type of the event handler delegate for a particular event. </typeparam>
    public sealed class EventRegistrationTokenTable<T>
    {
    
        /// <summary>Gets or sets a delegate of type <paramref name="T" /> whose invocation list includes all the event handler delegates that have been added, and that have not yet been removed. Invoking this delegate invokes all the event handlers. </summary><returns>A delegate of type <paramref name="T" /> that represents all the event handler delegates that are currently registered for an event. </returns>
        public T InvocationList
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public EventRegistrationTokenTable()
        {
             throw new NotImplementedException();
        }
        
        
        public EventRegistrationToken AddEventHandler(T handler)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Removes the event handler that is associated with the specified token from the table and the invocation list. </summary><param name="token">The token that was returned when the event handler was added. </param>
        public void RemoveEventHandler(EventRegistrationToken token)
        {
             throw new NotImplementedException();
        }
        
        
        public void RemoveEventHandler(T handler)
        {
             throw new NotImplementedException();
        }
        
        
        public static EventRegistrationTokenTable<T> GetOrCreateEventRegistrationTokenTable(ref EventRegistrationTokenTable<T> refEventTable)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
