using System.Runtime.CompilerServices;
using System;

namespace System.Diagnostics.Tracing
{
    /// <summary>Defines the standard operation codes that the event source attaches to events.</summary>
    public enum EventOpcode : int
    {
        /// <summary>An informational event.</summary>
        Info = 0,
        /// <summary>An event that is published when an application starts a new transaction or activity. This operation code can be embedded within another transaction or activity when multiple events that have the <see cref="F:System.Diagnostics.Tracing.EventOpcode.Start" /> code follow each other without an intervening event that has a <see cref="F:System.Diagnostics.Tracing.EventOpcode.Stop" /> code.</summary>
        Start = 1,
        /// <summary>An event that is published when an activity or a transaction in an application ends. The event corresponds to the last unpaired event that has a <see cref="F:System.Diagnostics.Tracing.EventOpcode.Start" /> operation code.</summary>
        Stop = 2,
        /// <summary>A trace collection start event.</summary>
        DataCollectionStart = 3,
        /// <summary>A trace collection stop event.</summary>
        DataCollectionStop = 4,
        /// <summary>An extension event.</summary>
        Extension = 5,
        /// <summary>An event that is published after an activity in an application replies to an event.</summary>
        Reply = 6,
        /// <summary>An event that is published after an activity in an application resumes from a suspended state. The event should follow an event that has the <see cref="F:System.Diagnostics.Tracing.EventOpcode.Suspend" /> operation code.</summary>
        Resume = 7,
        /// <summary>An event that is published when an activity in an application is suspended.</summary>
        Suspend = 8,
        /// <summary>An event that is published when one activity in an application transfers data or system resources to another activity.</summary>
        Send = 9,
        /// <summary>An event that is published when one activity in an application receives data.</summary>
        Receive = 240
    }
}
