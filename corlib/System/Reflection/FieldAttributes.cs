using System.Runtime.InteropServices;
using System;

namespace System.Reflection
{
    /// <summary>Specifies flags that describe the attributes of a field.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    [FlagsAttribute()]
    public enum FieldAttributes : int
    {
        /// <summary>Specifies the access level of a given field.</summary>
        FieldAccessMask = 7,
        /// <summary>Specifies that the field cannot be referenced.</summary>
        PrivateScope = 0,
        /// <summary>Specifies that the field is accessible only by the parent type.</summary>
        Private = 1,
        /// <summary>Specifies that the field is accessible only by subtypes in this assembly.</summary>
        FamANDAssem = 2,
        /// <summary>Specifies that the field is accessible throughout the assembly.</summary>
        Assembly = 3,
        /// <summary>Specifies that the field is accessible only by type and subtypes.</summary>
        Family = 4,
        /// <summary>Specifies that the field is accessible by subtypes anywhere, as well as throughout this assembly.</summary>
        FamORAssem = 5,
        /// <summary>Specifies that the field is accessible by any member for whom this scope is visible.</summary>
        Public = 6,
        /// <summary>Specifies that the field represents the defined type, or else it is per-instance.</summary>
        Static = 16,
        /// <summary>Specifies that the field is initialized only, and can be set only in the body of a constructor. </summary>
        InitOnly = 32,
        /// <summary>Specifies that the field's value is a compile-time (static or early bound) constant. Any attempt to set it throws a <see cref="T:System.FieldAccessException" />.</summary>
        Literal = 64,
        /// <summary>Specifies that the field does not have to be serialized when the type is remoted.</summary>
        NotSerialized = 128,
        /// <summary>Specifies a special method, with the name describing how the method is special.</summary>
        SpecialName = 512,
        /// <summary>Reserved for future use.</summary>
        PinvokeImpl = 8192,
        /// <summary>Reserved.</summary>
        ReservedMask = 38144,
        /// <summary>Specifies that the common language runtime (metadata internal APIs) should check the name encoding.</summary>
        RTSpecialName = 1024,
        /// <summary>Specifies that the field has marshaling information.</summary>
        HasFieldMarshal = 4096,
        /// <summary>Specifies that the field has a default value.</summary>
        HasDefault = 32768,
        /// <summary>Specifies that the field has a relative virtual address (RVA). The RVA is the location of the method body in the current image, as an address relative to the start of the image file in which it is located.</summary>
        HasFieldRVA = 256
    }
}
