using System;

namespace System.Diagnostics.Contracts
{
    /// <summary>Specifies the type of contract that failed. </summary>
    public enum ContractFailureKind : int
    {
        /// <summary>A <see cref="Overload:System.Diagnostics.Contracts.Contract.Requires" /> contract failed.</summary>
        Precondition = 0,
        /// <summary>An <see cref="Overload:System.Diagnostics.Contracts.Contract.Ensures" /> contract failed. </summary>
        Postcondition = 1,
        /// <summary>An <see cref="Overload:System.Diagnostics.Contracts.Contract.EnsuresOnThrow" /> contract failed.</summary>
        PostconditionOnException = 2,
        /// <summary>An <see cref="Overload:System.Diagnostics.Contracts.Contract.Invariant" /> contract failed.</summary>
        Invariant = 3,
        /// <summary>An <see cref="Overload:System.Diagnostics.Contracts.Contract.Assert" /> contract failed.</summary>
        Assert = 4,
        /// <summary>An <see cref="Overload:System.Diagnostics.Contracts.Contract.Assume" /> contract failed.</summary>
        Assume = 5
    }
}
