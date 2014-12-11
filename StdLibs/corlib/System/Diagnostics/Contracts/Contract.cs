using System;
using System.Diagnostics;
using System.Runtime.ConstrainedExecution;
using System.Collections.Generic;
using System.Security;

namespace System.Diagnostics.Contracts
{
    /// <summary>Contains static methods for representing program contracts such as preconditions, postconditions, and object invariants.</summary>
    public static class Contract
    {
    
        /// <summary>Occurs when a contract fails.</summary>
        public static event EventHandler<ContractFailedEventArgs> ContractFailed;
    
    
        /// <summary>Instructs code analysis tools to assume that the specified condition is true, even if it cannot be statically proven to always be true.</summary><param name="condition">The conditional expression to assume true.</param>
        [ConditionalAttribute("CONTRACTS_FULL")]
        [ConditionalAttribute("DEBUG")]
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.MayFail)]
        public static void Assume(bool condition)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Instructs code analysis tools to assume that a condition is true, even if it cannot be statically proven to always be true, and displays a message if the assumption fails.</summary><param name="condition">The conditional expression to assume true.</param><param name="userMessage">The message to post if the assumption fails.</param>
        [ConditionalAttribute("CONTRACTS_FULL")]
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.MayFail)]
        [ConditionalAttribute("DEBUG")]
        public static void Assume(bool condition, string userMessage)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Checks for a condition; if the condition is false, follows the escalation policy set for the analyzer.</summary><param name="condition">The conditional expression to test.</param>
        [ConditionalAttribute("CONTRACTS_FULL")]
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.MayFail)]
        [ConditionalAttribute("DEBUG")]
        public static void Assert(bool condition)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Checks for a condition; if the condition is false, follows the escalation policy set by the analyzer and displays the specified message.</summary><param name="condition">The conditional expression to test.</param><param name="userMessage">A message to display if the condition is not met.</param>
        [ConditionalAttribute("CONTRACTS_FULL")]
        [ConditionalAttribute("DEBUG")]
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.MayFail)]
        public static void Assert(bool condition, string userMessage)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Specifies a precondition contract for the enclosing method or property.</summary><param name="condition">The conditional expression to test.</param>
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.MayFail)]
        [ConditionalAttribute("CONTRACTS_FULL")]
        public static void Requires(bool condition)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Specifies a precondition contract for the enclosing method or property, and displays a message if the condition for the contract fails.</summary><param name="condition">The conditional expression to test.</param><param name="userMessage">The message to display if the condition is false.</param>
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.MayFail)]
        [ConditionalAttribute("CONTRACTS_FULL")]
        public static void Requires(bool condition, string userMessage)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Specifies a precondition contract for the enclosing method or property.</summary><param name="condition">The conditional expression to test.</param>
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.MayFail)]
        public static void Requires<TException>(bool condition)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Specifies a precondition contract for the enclosing method or property, and displays a message if the condition for the contract fails.</summary><param name="condition">The conditional expression to test.</param><param name="userMessage">The message to display if the condition is false.</param>
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.MayFail)]
        public static void Requires<TException>(bool condition, string userMessage)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Specifies a postcondition contract for the enclosing method or property.</summary><param name="condition">The conditional expression to test. The expression may include <see cref="M:System.Diagnostics.Contracts.Contract.OldValue``1(``0)" />, <see cref="M:System.Diagnostics.Contracts.Contract.ValueAtReturn``1(``0@)" />, and <see cref="M:System.Diagnostics.Contracts.Contract.Result``1" /> values. </param>
        [ConditionalAttribute("CONTRACTS_FULL")]
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.MayFail)]
        public static void Ensures(bool condition)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Specifies a postcondition contract for a provided exit condition and a message to display if the condition is false.</summary><param name="condition">The conditional expression to test. The expression may include <see cref="M:System.Diagnostics.Contracts.Contract.OldValue``1(``0)" /> and <see cref="M:System.Diagnostics.Contracts.Contract.Result``1" /> values. </param><param name="userMessage">The message to display if the expression is not true.</param>
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.MayFail)]
        [ConditionalAttribute("CONTRACTS_FULL")]
        public static void Ensures(bool condition, string userMessage)
        {
             throw new NotImplementedException();
        }
        
        
        [ConditionalAttribute("CONTRACTS_FULL")]
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.MayFail)]
        public static void EnsuresOnThrow<TException>(bool condition)
        {
             throw new NotImplementedException();
        }
        
        
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.MayFail)]
        [ConditionalAttribute("CONTRACTS_FULL")]
        public static void EnsuresOnThrow<TException>(bool condition, string userMessage)
        {
             throw new NotImplementedException();
        }
        
        
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.Success)]
        public static T Result<T>()
        {
             throw new NotImplementedException();
        }
        
        
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.Success)]
        public static T ValueAtReturn<T>(ref T value)
        {
             throw new NotImplementedException();
        }
        
        
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.Success)]
        public static T OldValue<T>(T value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Specifies an invariant contract for the enclosing method or property. </summary><param name="condition">The conditional expression to test.</param>
        [ConditionalAttribute("CONTRACTS_FULL")]
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.MayFail)]
        public static void Invariant(bool condition)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Specifies an invariant contract for the enclosing method or property, and displays a message if the condition for the contract fails.</summary><param name="condition">The conditional expression to test.</param><param name="userMessage">The message to display if the condition is false.</param>
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.MayFail)]
        [ConditionalAttribute("CONTRACTS_FULL")]
        public static void Invariant(bool condition, string userMessage)
        {
             throw new NotImplementedException();
        }
        
        
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.MayFail)]
        public static bool ForAll(int fromInclusive, int toExclusive, Predicate<int> predicate)
        {
             throw new NotImplementedException();
        }
        
        
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.MayFail)]
        public static bool ForAll<T>(IEnumerable<T> collection, Predicate<T> predicate)
        {
             throw new NotImplementedException();
        }
        
        
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.MayFail)]
        public static bool Exists(int fromInclusive, int toExclusive, Predicate<int> predicate)
        {
             throw new NotImplementedException();
        }
        
        
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.MayFail)]
        public static bool Exists<T>(IEnumerable<T> collection, Predicate<T> predicate)
        {
             throw new NotImplementedException();
        }
        
        
        [ConditionalAttribute("CONTRACTS_FULL")]
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.Success)]
        public static void EndContractBlock()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
