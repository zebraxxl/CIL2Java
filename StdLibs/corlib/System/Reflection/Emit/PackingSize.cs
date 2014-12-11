using System.Runtime.InteropServices;
using System;

namespace System.Reflection.Emit
{
    /// <summary>Specifies one of two factors that determine the memory alignment of fields when a type is marshaled.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    public enum PackingSize : int
    {
        /// <summary>The packing size is not specified.</summary>
        Unspecified = 0,
        /// <summary>The packing size is 1 byte.</summary>
        Size1 = 1,
        /// <summary>The packing size is 2 bytes.</summary>
        Size2 = 2,
        /// <summary>The packing size is 4 bytes.</summary>
        Size4 = 4,
        /// <summary>The packing size is 8 bytes.</summary>
        Size8 = 8,
        /// <summary>The packing size is 16 bytes.</summary>
        Size16 = 16,
        /// <summary>The packing size is 32 bytes.</summary>
        Size32 = 32,
        /// <summary>The packing size is 64 bytes.</summary>
        Size64 = 64,
        /// <summary>The packing size is 128 bytes.</summary>
        Size128 = 128
    }
}
