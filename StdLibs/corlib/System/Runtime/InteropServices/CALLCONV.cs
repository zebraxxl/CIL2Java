using System;

namespace System.Runtime.InteropServices
{
    /// <summary>Use <see cref="T:System.Runtime.InteropServices.ComTypes.CALLCONV" /> instead.</summary>
    [Serializable]
    [ObsoleteAttribute("Use System.Runtime.InteropServices.ComTypes.CALLCONV instead. http://go.microsoft.com/fwlink/?linkid=14202", false)]
    public enum CALLCONV : int
    {
        /// <summary>Indicates that the Cdecl calling convention is used for a method.</summary>
        CC_CDECL = 1,
        /// <summary>Indicates that the Mscpascal calling convention is used for a method.</summary>
        CC_MSCPASCAL = 2,
        /// <summary>Indicates that the Pascal calling convention is used for a method.</summary>
        CC_PASCAL = 2,
        /// <summary>Indicates that the Macpascal calling convention is used for a method.</summary>
        CC_MACPASCAL = 3,
        /// <summary>Indicates that the Stdcall calling convention is used for a method.</summary>
        CC_STDCALL = 4,
        /// <summary>This value is reserved for future use.</summary>
        CC_RESERVED = 5,
        /// <summary>Indicates that the Syscall calling convention is used for a method.</summary>
        CC_SYSCALL = 6,
        /// <summary>Indicates that the Mpwcdecl calling convention is used for a method.</summary>
        CC_MPWCDECL = 7,
        /// <summary>Indicates that the Mpwpascal calling convention is used for a method.</summary>
        CC_MPWPASCAL = 8,
        /// <summary>Indicates the end of the <see cref="T:System.Runtime.InteropServices.CALLCONV" /> enumeration.</summary>
        CC_MAX = 9
    }
}
