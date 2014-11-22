using System;

namespace System.Runtime.InteropServices.ComTypes
{
    /// <summary>Contains attributes of a UCOMITypeInfo.</summary>
    public struct TYPEATTR
    {
        /// <summary>A constant used with the <see cref="F:System.Runtime.InteropServices.TYPEATTR.memidConstructor" /> and <see cref="F:System.Runtime.InteropServices.TYPEATTR.memidDestructor" /> fields.</summary>
        public const int MEMBER_ID_NIL = -1;
        /// <summary>The GUID of the type information.</summary>
        public Guid guid;
        /// <summary>Locale of member names and documentation strings.</summary>
        public int lcid;
        /// <summary>Reserved for future use.</summary>
        public int dwReserved;
        /// <summary>ID of constructor, or <see cref="F:System.Runtime.InteropServices.TYPEATTR.MEMBER_ID_NIL" /> if none.</summary>
        public int memidConstructor;
        /// <summary>ID of destructor, or <see cref="F:System.Runtime.InteropServices.TYPEATTR.MEMBER_ID_NIL" /> if none.</summary>
        public int memidDestructor;
        /// <summary>Reserved for future use.</summary>
        public IntPtr lpstrSchema;
        /// <summary>The size of an instance of this type.</summary>
        public int cbSizeInstance;
        /// <summary>A <see cref="T:System.Runtime.InteropServices.TYPEKIND" /> value describing the type this information describes.</summary>
        public TYPEKIND typekind;
        /// <summary>Indicates the number of functions on the interface this structure describes.</summary>
        public short cFuncs;
        /// <summary>Indicates the number of variables and data fields on the interface described by this structure.</summary>
        public short cVars;
        /// <summary>Indicates the number of implemented interfaces on the interface this structure describes.</summary>
        public short cImplTypes;
        /// <summary>The size of this type's virtual method table (VTBL).</summary>
        public short cbSizeVft;
        /// <summary>Specifies the byte alignment for an instance of this type.</summary>
        public short cbAlignment;
        /// <summary>A <see cref="T:System.Runtime.InteropServices.TYPEFLAGS" /> value describing this information.</summary>
        public TYPEFLAGS wTypeFlags;
        /// <summary>Major version number.</summary>
        public short wMajorVerNum;
        /// <summary>Minor version number.</summary>
        public short wMinorVerNum;
        /// <summary>If <see cref="F:System.Runtime.InteropServices.TYPEATTR.typekind" /> == <see cref="F:System.Runtime.InteropServices.TYPEKIND.TKIND_ALIAS" />, specifies the type for which this type is an alias.</summary>
        public TYPEDESC tdescAlias;
        /// <summary>IDL attributes of the described type.</summary>
        public IDLDESC idldescType;
    
    }
}
