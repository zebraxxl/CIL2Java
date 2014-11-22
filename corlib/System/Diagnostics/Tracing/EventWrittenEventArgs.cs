using System;
using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;

namespace System.Diagnostics.Tracing
{
    /// <summary>Provides data for the <see cref="M:System.Diagnostics.Tracing.EventListener.OnEventWritten(System.Diagnostics.Tracing.EventWrittenEventArgs)" /> callback.</summary>
    public class EventWrittenEventArgs : EventArgs
    {
    
        /// <summary>Gets the event identifier.</summary><returns>The event identifier.</returns>
        public int EventId
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the payload for the event.</summary><returns>The payload for the event.</returns>
        public ReadOnlyCollection<object> Payload
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the event source object.</summary><returns>The event source object.</returns>
        public EventSource EventSource
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the keywords for the event.</summary><returns>The keywords for the event.</returns>
        public EventKeywords Keywords
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the operation code for the event.</summary><returns>The operation code for the event.</returns>
        public EventOpcode Opcode
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the task for the event.</summary><returns>The task for the event.</returns>
        public EventTask Task
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the message for the event.</summary><returns>The message for the event.</returns>
        public string Message
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the version of the event.</summary><returns>The version of the event.</returns>
        public byte Version
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the level of the event.</summary><returns>The level of the event.</returns>
        public EventLevel Level
        {
            get { throw new NotImplementedException(); }
        }
    
    
    }
}
