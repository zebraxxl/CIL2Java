using System;

namespace System.Runtime.InteropServices.ComTypes
{
    /// <summary>Identifies a particular type library and provides localization support for member names.</summary>
    [Serializable]
    public struct TYPELIBATTR
    {
        /// <summary>Represents a globally unique library ID of a type library.</summary>
        public Guid guid;
        /// <summary>Represents a locale ID of a type library.</summary>
        public int lcid;
        /// <summary>Represents the target hardware platform of a type library.</summary>
        public SYSKIND syskind;
        /// <summary>Represents the major version number of a type library.</summary>
        public short wMajorVerNum;
        /// <summary>Represents the minor version number of a type library.</summary>
        public short wMinorVerNum;
        /// <summary>Represents library flags.</summary>
        public LIBFLAGS wLibFlags;
    
    }
}
