using System;
using System.Runtime.ConstrainedExecution;
using System.Diagnostics;
using System.Diagnostics.Contracts;

namespace System.Diagnostics.Contracts.Internal
{
    /// <summary>Provides methods that the binary rewriter uses to handle contract failures.</summary>
    [ObsoleteAttribute("Use the ContractHelper class in the System.Runtime.CompilerServices namespace instead.")]
    public static class ContractHelper
    {
        /// <summary>Used by the binary rewriter to activate the default failure behavior.</summary><returns>A null reference (Nothing in Visual Basic) if the event was handled and should not trigger a failure; otherwise, returns the localized failure message.</returns><param name="failureKind">The type of failure.</param><param name="userMessage">Additional user information.</param><param name="conditionText">The description of the condition that caused the failure.</param><param name="innerException">The inner exception that caused the current exception.</param><exception cref="T:System.ArgumentException"><paramref name="failureKind" /> is not a valid <see cref="T:System.Diagnostics.Contracts.ContractFailureKind" /> value.</exception>
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.MayFail)]
        [DebuggerNonUserCodeAttribute()]
        public static string RaiseContractFailedEvent(ContractFailureKind failureKind, string userMessage, string conditionText, Exception innerException)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Triggers the default failure behavior.</summary><param name="kind">The type of failure.</param><param name="displayMessage">The message to display.</param><param name="userMessage">Additional user information.</param><param name="conditionText">The description of the condition that caused the failure.</param><param name="innerException">The inner exception that caused the current exception.</param>
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.Success)]
        [DebuggerNonUserCodeAttribute()]
        public static void TriggerFailure(ContractFailureKind kind, string displayMessage, string userMessage, string conditionText, Exception innerException)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
