using System;
using System.Runtime.ConstrainedExecution;
using System.Security;

namespace System.Diagnostics.Contracts
{
    /// <summary>Provides methods and data for the <see cref="E:System.Diagnostics.Contracts.Contract.ContractFailed" /> event.</summary>
    public sealed class ContractFailedEventArgs : EventArgs
    {
    
        /// <summary>Gets the message that describes the <see cref="E:System.Diagnostics.Contracts.Contract.ContractFailed" /> event.</summary><returns>The message that describes the event.</returns>
        public string Message
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the condition for the failure of the contract.</summary><returns>The condition for the failure.</returns>
        public string Condition
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the type of contract that failed.</summary><returns>One of the enumeration values that specifies the type of contract that failed.</returns>
        public ContractFailureKind FailureKind
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the original exception that caused the <see cref="E:System.Diagnostics.Contracts.Contract.ContractFailed" /> event.</summary><returns>The exception that caused the event.</returns>
        public Exception OriginalException
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Indicates whether the <see cref="E:System.Diagnostics.Contracts.Contract.ContractFailed" /> event has been handled.</summary><returns>true if the event has been handled; otherwise, false. </returns>
        public bool Handled
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Indicates whether the code contract escalation policy should be applied.</summary><returns>true to apply the escalation policy; otherwise, false. The default is false.</returns>
        public bool Unwind
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Provides data for the <see cref="E:System.Diagnostics.Contracts.Contract.ContractFailed" /> event.</summary><param name="failureKind">One of the enumeration values that specifies the contract that failed.</param><param name="message">The message for the event.</param><param name="condition">The condition for the event.</param><param name="originalException">The exception that caused the event.</param>
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.MayFail)]
        public ContractFailedEventArgs(ContractFailureKind failureKind, string message, string condition, Exception originalException)
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        public void SetHandled()
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        public void SetUnwind()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
