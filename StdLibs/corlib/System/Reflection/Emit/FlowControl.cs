using System.Runtime.InteropServices;
using System;

namespace System.Reflection.Emit
{
    /// <summary>Describes how an instruction alters the flow of control.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    public enum FlowControl : int
    {
        /// <summary>Branch instruction.</summary>
        Branch = 0,
        /// <summary>Break instruction.</summary>
        Break = 1,
        /// <summary>Call instruction.</summary>
        Call = 2,
        /// <summary>Conditional branch instruction.</summary>
        Cond_Branch = 3,
        /// <summary>Provides information about a subsequent instruction. For example, the Unaligned instruction of Reflection.Emit.Opcodes has FlowControl.Meta and specifies that the subsequent pointer instruction might be unaligned.</summary>
        Meta = 4,
        /// <summary>Normal flow of control.</summary>
        Next = 5,
        /// <summary>This enumerator value is reserved and should not be used.</summary>
        Phi = 6,
        /// <summary>Return instruction.</summary>
        Return = 7,
        /// <summary>Exception throw instruction.</summary>
        Throw = 8
    }
}
