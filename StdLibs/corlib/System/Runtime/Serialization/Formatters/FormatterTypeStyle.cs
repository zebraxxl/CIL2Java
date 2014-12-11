using System.Runtime.InteropServices;
using System;

namespace System.Runtime.Serialization.Formatters
{
    /// <summary>Indicates the format in which type descriptions are laid out in the serialized stream.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    public enum FormatterTypeStyle : int
    {
        /// <summary>Indicates that types can be stated only for arrays of objects, object members of type <see cref="T:System.Object" />, and <see cref="T:System.Runtime.Serialization.ISerializable" /> non-primitive value types.</summary>
        TypesWhenNeeded = 0,
        /// <summary>Indicates that types can be given to all object members and <see cref="T:System.Runtime.Serialization.ISerializable" /> object members.</summary>
        TypesAlways = 1,
        /// <summary>Indicates that strings can be given in the XSD format rather than SOAP. No string IDs are transmitted. </summary>
        XsdString = 2
    }
}
