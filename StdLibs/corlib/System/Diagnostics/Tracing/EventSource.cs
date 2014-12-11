using System;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
using System.Security;

namespace System.Diagnostics.Tracing
{
    /// <summary>Provides the ability to create events for event tracing for Windows (ETW).</summary>
    public class EventSource : IDisposable
    {
        protected struct EventData
        {
        
            public int Size
            {
                get { throw new NotImplementedException(); }
                set { throw new NotImplementedException(); }
            }
        
            public IntPtr DataPointer
            {
                get { throw new NotImplementedException(); }
                set { throw new NotImplementedException(); }
            }
        
        
        }
    
    
        /// <summary>The friendly name of the class that is derived from the event source.</summary><returns>The friendly name of the derived class.  The default is the simple name of the class.</returns>
        public string Name
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>The unique identifier for the event source.</summary><returns>A unique identifier for the event source.</returns>
        public Guid Guid
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public bool IsEnabled()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether the current event source that has the specified level and keyword is enabled.</summary><returns>true if the event source is enabled; otherwise, false.</returns><param name="level">The level of the event source.</param><param name="keywords">The keyword of the event source.</param>
        public bool IsEnabled(EventLevel level, EventKeywords keywords)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Gets the unique identifier for this implementation of the event source.</summary><returns>A unique identifier for this event source type.</returns><param name="eventSourceType">The type of the event source.</param>
        public static Guid GetGuid(Type eventSourceType)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Gets the friendly name of the event source.</summary><returns>The friendly name of the event source. The default is the simple name of the class.</returns><param name="eventSourceType">The type of the event source.</param>
        public static string GetName(Type eventSourceType)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a string of the XML manifest that is associated with the current event source.</summary><returns>The XML data string.</returns><param name="eventSourceType">The type of the event source.</param><param name="assemblyPathToIncludeInManifest">The path to the .dll file to include in the manifest. </param>
        public static string GenerateManifest(Type eventSourceType, string assemblyPathToIncludeInManifest)
        {
             throw new NotImplementedException();
        }
        
        
        public static IEnumerable<EventSource> GetSources()
        {
             throw new NotImplementedException();
        }
        
        
        public override string ToString()
        {
             throw new NotImplementedException();
        }
        
        
        protected EventSource()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates a new instance of the <see cref="T:System.Diagnostics.Tracing.EventSource" /> class and specifies whether to throw an exception when an error occurs in the underlying Windows code.</summary><param name="throwOnEventWriteErrors">true to throw an exception when an error occurs in the underlying Windows code; otherwise, false.</param>
        protected EventSource(bool throwOnEventWriteErrors)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Called when the current event source is updated by the controller.</summary><param name="command">The arguments for the event.</param>
        protected virtual void OnEventCommand(EventCommandEventArgs command)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes an event by using the provided event identifier.</summary><param name="eventId">The event identifier.</param>
        [SecuritySafeCriticalAttribute()]
        protected void WriteEvent(int eventId)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes an event by using the provided event identifier and 32-bit integer argument.</summary><param name="eventId">The event identifier.</param><param name="arg1">An integer argument.</param>
        [SecuritySafeCriticalAttribute()]
        protected void WriteEvent(int eventId, int arg1)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes an event by using the provided event identifier and 32-bit integer arguments.</summary><param name="eventId">The event identifier.</param><param name="arg1">An integer argument.</param><param name="arg2">An integer argument.</param>
        [SecuritySafeCriticalAttribute()]
        protected void WriteEvent(int eventId, int arg1, int arg2)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes an event by using the provided event identifier and 32-bit integer arguments.</summary><param name="eventId">The event identifier.</param><param name="arg1">An integer argument.</param><param name="arg2">An integer argument.</param><param name="arg3">An integer argument.</param>
        [SecuritySafeCriticalAttribute()]
        protected void WriteEvent(int eventId, int arg1, int arg2, int arg3)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes an event by using the provided event identifier and 64-bit integer argument.</summary><param name="eventId">The event identifier.</param><param name="arg1">A 64 bit integer argument.</param>
        [SecuritySafeCriticalAttribute()]
        protected void WriteEvent(int eventId, long arg1)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes an event by using the provided event identifier and 64-bit arguments.</summary><param name="eventId">The event identifier.</param><param name="arg1">A 64 bit integer argument.</param><param name="arg2">A 64 bit integer argument.</param>
        [SecuritySafeCriticalAttribute()]
        protected void WriteEvent(int eventId, long arg1, long arg2)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes an event by using the provided event identifier and 64-bit arguments.</summary><param name="eventId">The event identifier.</param><param name="arg1">A 64 bit integer argument.</param><param name="arg2">A 64 bit integer argument.</param><param name="arg3">A 64 bit integer argument.</param>
        [SecuritySafeCriticalAttribute()]
        protected void WriteEvent(int eventId, long arg1, long arg2, long arg3)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes an event by using the provided event identifier and string argument.</summary><param name="eventId">The event identifier.</param><param name="arg1">A string argument.</param>
        [SecuritySafeCriticalAttribute()]
        protected void WriteEvent(int eventId, string arg1)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes an event by using the provided event identifier and string arguments.</summary><param name="eventId">The event identifier.</param><param name="arg1">A string argument.</param><param name="arg2">A string argument.</param>
        [SecuritySafeCriticalAttribute()]
        protected void WriteEvent(int eventId, string arg1, string arg2)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes an event by using the provided event identifier and string arguments.</summary><param name="eventId">The event identifier.</param><param name="arg1">A string argument.</param><param name="arg2">A string argument.</param><param name="arg3">A string argument.</param>
        [SecuritySafeCriticalAttribute()]
        protected void WriteEvent(int eventId, string arg1, string arg2, string arg3)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes an event by using the provided event identifier and arguments.</summary><param name="eventId">The event identifier.</param><param name="arg1">A string argument.</param><param name="arg2">A 32 bit integer argument.</param>
        [SecuritySafeCriticalAttribute()]
        protected void WriteEvent(int eventId, string arg1, int arg2)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes an event by using the provided event identifier and arguments.</summary><param name="eventId">The event identifier.</param><param name="arg1">A string argument.</param><param name="arg2">A 32 bit integer argument.</param><param name="arg3">A 32 bit integer argument.</param>
        [SecuritySafeCriticalAttribute()]
        protected void WriteEvent(int eventId, string arg1, int arg2, int arg3)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes an event by using the provided event identifier and arguments.</summary><param name="eventId">The event identifier.</param><param name="arg1">A string argument.</param><param name="arg2">A 64 bit integer argument.</param>
        [SecuritySafeCriticalAttribute()]
        protected void WriteEvent(int eventId, string arg1, long arg2)
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        protected unsafe void WriteEventCore(int eventId, int eventDataCount, EventData* data)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes an event by using the provided event identifier and array of arguments.</summary><param name="eventId">The event identifier.</param><param name="args">An array of objects.</param>
        [SecuritySafeCriticalAttribute()]
        protected void WriteEvent(int eventId, params  object[] args)
        {
             throw new NotImplementedException();
        }
        
        
        public void Dispose()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Releases the unmanaged resources used by the <see cref="T:System.Diagnostics.Tracing.EventSource" /> class and optionally releases the managed resources.</summary><param name="disposing">true to release both managed and unmanaged resources; false to release only unmanaged resources. </param>
        protected virtual void Dispose(bool disposing)
        {
             throw new NotImplementedException();
        }
        
        
        ~EventSource()
        {
             throw new NotImplementedException();
        }
        
        
        public static void SendCommand(EventSource eventSource, EventCommand command, IDictionary<string, string> commandArguments)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
