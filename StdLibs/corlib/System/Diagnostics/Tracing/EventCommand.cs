using System;

namespace System.Diagnostics.Tracing
{
    /// <summary>Describes the command (<see cref="P:System.Diagnostics.Tracing.EventCommandEventArgs.Command" /> property) that is passed to the <see cref="M:System.Diagnostics.Tracing.EventSource.OnEventCommand(System.Diagnostics.Tracing.EventCommandEventArgs)" /> callback.</summary>
    public enum EventCommand : int
    {
        /// <summary>Update the event.</summary>
        Update = 0,
        /// <summary>Send the manifest.</summary>
        SendManifest = -1,
        /// <summary>Enable the event.</summary>
        Enable = -2,
        /// <summary>Disable the event.</summary>
        Disable = -3
    }
}
