using System.Runtime.InteropServices;
using System;

namespace System.Reflection
{
    /// <summary>Specifies flags for the attributes of a method implementation.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    public enum MethodImplAttributes : int
    {
        /// <summary>Specifies flags about code type.</summary>
        CodeTypeMask = 3,
        /// <summary>Specifies that the method implementation is in Microsoft intermediate language (MSIL).</summary>
        IL = 0,
        /// <summary>Specifies that the method implementation is native.</summary>
        Native = 1,
        /// <summary>Specifies that the method implementation is in Optimized Intermediate Language (OPTIL).</summary>
        OPTIL = 2,
        /// <summary>Specifies that the method implementation is provided by the runtime.</summary>
        Runtime = 3,
        /// <summary>Specifies whether the method is implemented in managed or unmanaged code.</summary>
        ManagedMask = 4,
        /// <summary>Specifies that the method is implemented in unmanaged code.</summary>
        Unmanaged = 4,
        /// <summary>Specifies that the method is implemented in managed code. </summary>
        Managed = 0,
        /// <summary>Specifies that the method is not defined.</summary>
        ForwardRef = 16,
        /// <summary>Specifies that the method signature is exported exactly as declared.</summary>
        PreserveSig = 128,
        /// <summary>Specifies an internal call.</summary>
        InternalCall = 4096,
        /// <summary>Specifies that the method is single-threaded through the body. Static methods (Shared in Visual Basic) lock on the type, whereas instance methods lock on the instance. You can also use the C# lock statement or the Visual Basic SyncLock statement for this purpose. </summary>
        Synchronized = 32,
        /// <summary>Specifies that the method cannot be inlined.</summary>
        NoInlining = 8,
        /// <summary>Specifies that the method should be inlined wherever possible.</summary>
        AggressiveInlining = 256,
        /// <summary>Specifies that the method is not optimized by the just-in-time (JIT) compiler or by native code generation (see Ngen.exe) when debugging possible code generation problems.</summary>
        NoOptimization = 64,
        /// <summary>Specifies a range check value.</summary>
        MaxMethodImplVal = 65535
    }
}
