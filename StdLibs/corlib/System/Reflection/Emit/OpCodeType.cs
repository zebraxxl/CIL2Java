using System.Runtime.InteropServices;
using System;

namespace System.Reflection.Emit
{
    /// <summary>Describes the types of the Microsoft intermediate language (MSIL) instructions.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    public enum OpCodeType : int
    {
        /// <summary>This enumerator value is reserved and should not be used.</summary>
        Annotation = 0,
        /// <summary>These are Microsoft intermediate language (MSIL) instructions that are used as a synonym for other MSIL instructions. For example, ldarg.0 represents the ldarg instruction with an argument of 0.</summary>
        Macro = 1,
        /// <summary>Describes a reserved Microsoft intermediate language (MSIL) instruction.</summary>
        Nternal = 2,
        /// <summary>Describes a Microsoft intermediate language (MSIL) instruction that applies to objects.</summary>
        Objmodel = 3,
        /// <summary>Describes a prefix instruction that modifies the behavior of the following instruction.</summary>
        Prefix = 4,
        /// <summary>Describes a built-in instruction.</summary>
        Primitive = 5
    }
}
