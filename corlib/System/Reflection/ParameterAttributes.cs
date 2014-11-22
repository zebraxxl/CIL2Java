using System;
using System.Runtime.InteropServices;

namespace System.Reflection
{
    /// <summary>Defines the attributes that can be associated with a parameter. These are defined in CorHdr.h.</summary>
    [Serializable]
    [FlagsAttribute()]
    [ComVisibleAttribute(true)]
    public enum ParameterAttributes : int
    {
        /// <summary>Specifies that there is no parameter attribute.</summary>
        None = 0,
        /// <summary>Specifies that the parameter is an input parameter.</summary>
        In = 1,
        /// <summary>Specifies that the parameter is an output parameter.</summary>
        Out = 2,
        /// <summary>Specifies that the parameter is a locale identifier (lcid).</summary>
        Lcid = 4,
        /// <summary>Specifies that the parameter is a return value.</summary>
        Retval = 8,
        /// <summary>Specifies that the parameter is optional.</summary>
        Optional = 16,
        /// <summary>Specifies that the parameter is reserved.</summary>
        ReservedMask = 61440,
        /// <summary>Specifies that the parameter has a default value.</summary>
        HasDefault = 4096,
        /// <summary>Specifies that the parameter has field marshaling information.</summary>
        HasFieldMarshal = 8192,
        /// <summary>Reserved.</summary>
        Reserved3 = 16384,
        /// <summary>Reserved.</summary>
        Reserved4 = 32768
    }
}
