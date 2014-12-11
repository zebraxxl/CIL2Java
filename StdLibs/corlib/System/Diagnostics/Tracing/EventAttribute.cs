using System;
using System.Runtime.CompilerServices;

namespace System.Diagnostics.Tracing
{
    /// <summary>Specifies additional event schema information for an event.</summary>
    [AttributeUsageAttribute(AttributeTargets.Method)]
    public sealed class EventAttribute : Attribute
    {
    
        /// <summary>Gets or sets the identifier for the event.</summary><returns>The event identifier.</returns>
        public int EventId
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the level for the event.</summary><returns>One of the enumeration values that specifies the level for the event.</returns>
        public EventLevel Level
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the keywords for the event.</summary><returns>A bitwise combination of the enumeration values.</returns>
        public EventKeywords Keywords
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the operation code for the event.</summary><returns>One of the enumeration values that specifies the operation code.</returns>
        public EventOpcode Opcode
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the task for the event.</summary><returns>The task for the event.</returns>
        public EventTask Task
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the version of the event.</summary><returns>The version of the event.</returns>
        public byte Version
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the message for the event.</summary><returns>The message for the event.</returns>
        public string Message
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.Tracing.EventAttribute" /> class with the specified event identifier.</summary><param name="eventId">The event identifier for the event.</param>
        public EventAttribute(int eventId)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
