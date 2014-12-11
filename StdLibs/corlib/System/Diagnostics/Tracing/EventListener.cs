using System;
using System.Collections.Generic;

namespace System.Diagnostics.Tracing
{
    /// <summary>Provides methods for enabling and disabling events from event sources.</summary>
    public abstract class EventListener : IDisposable
    {
    
    
        protected EventListener()
        {
             throw new NotImplementedException();
        }
        
        
        public virtual void Dispose()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Enables events for the specified event source that has the specified verbosity level or lower.</summary><param name="eventSource">The event source to enable events for.</param><param name="level">The level of events to enable.</param>
        public void EnableEvents(EventSource eventSource, EventLevel level)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Enables events for the specified event source that has the specified verbosity level or lower, and matching keyword flags.</summary><param name="eventSource">The event source to enable events for.</param><param name="level">The level of events to enable.</param><param name="matchAnyKeyword">The keyword flags necessary to enable the events.</param>
        public void EnableEvents(EventSource eventSource, EventLevel level, EventKeywords matchAnyKeyword)
        {
             throw new NotImplementedException();
        }
        
        
        public void EnableEvents(EventSource eventSource, EventLevel level, EventKeywords matchAnyKeyword, IDictionary<string, string> arguments)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Disables all events for the specified event source.</summary><param name="eventSource">The event source to disable events for.</param>
        public void DisableEvents(EventSource eventSource)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Called for all existing event sources when the event listener is created and when a new event source is attached to the listener.</summary><param name="eventSource">The event source.</param>
        protected virtual void OnEventSourceCreated(EventSource eventSource)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Called whenever an event has been written by an event source for which the event listener has enabled events.</summary><param name="eventData">The event arguments that describe the event.</param>
        protected abstract void OnEventWritten(EventWrittenEventArgs eventData);
        
        
        /// <summary>Gets a small non-negative number that represents the specified event source.</summary><returns>A small non-negative number that represents the specified event source.</returns><param name="eventSource">The event source to find the index for.</param>
        protected static int EventSourceIndex(EventSource eventSource)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
