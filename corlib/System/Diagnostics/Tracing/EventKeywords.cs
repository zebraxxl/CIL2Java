using System;

namespace System.Diagnostics.Tracing
{
    /// <summary>Defines the standard keywords that apply to events.</summary>
    [FlagsAttribute()]
    public enum EventKeywords : long
    {
        /// <summary>No filtering on keywords is performed when the event is published.</summary>
        None = 0,
        /// <summary>Attached to all Windows Diagnostics Infrastructure (WDI) context events.</summary>
        WdiContext = 562949953421312,
        /// <summary>Attached to all Windows Diagnostics Infrastructure (WDI) diagnostic events.</summary>
        WdiDiagnostic = 1125899906842624,
        /// <summary>Attached to all Service Quality Mechanism (SQM) events.</summary>
        Sqm = 2251799813685248,
        /// <summary>Attached to all failed security audit events. Use this keyword only  for events in the security log.</summary>
        AuditFailure = 4503599627370496,
        /// <summary>Attached to all successful security audit events. Use this keyword only for events in the security log.</summary>
        AuditSuccess = 9007199254740992,
        /// <summary>Attached to transfer events where the related activity ID (correlation ID) is a computed value and is not guaranteed to be unique (that is, it is not a real GUID).</summary>
        CorrelationHint = 4503599627370496,
        /// <summary>Attached to events that are raised by using the RaiseEvent function.</summary>
        EventLogClassic = 36028797018963968
    }
}
