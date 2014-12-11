using System.Runtime.InteropServices;
using System;

namespace System.Reflection
{
    /// <summary>Defines the attributes that can be associated with a property. These attribute values are defined in corhdr.h.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    [FlagsAttribute()]
    public enum PropertyAttributes : int
    {
        /// <summary>Specifies that no attributes are associated with a property.</summary>
        None = 0,
        /// <summary>Specifies that the property is special, with the name describing how the property is special.</summary>
        SpecialName = 512,
        /// <summary>Specifies a flag reserved for runtime use only.</summary>
        ReservedMask = 62464,
        /// <summary>Specifies that the metadata internal APIs check the name encoding.</summary>
        RTSpecialName = 1024,
        /// <summary>Specifies that the property has a default value.</summary>
        HasDefault = 4096,
        /// <summary>Reserved.</summary>
        Reserved2 = 8192,
        /// <summary>Reserved.</summary>
        Reserved3 = 16384,
        /// <summary>Reserved.</summary>
        Reserved4 = 32768
    }
}
