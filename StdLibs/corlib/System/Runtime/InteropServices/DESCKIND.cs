using System;

namespace System.Runtime.InteropServices
{
    /// <summary>Use <see cref="T:System.Runtime.InteropServices.ComTypes.DESCKIND" /> instead.</summary>
    [Serializable]
    [ObsoleteAttribute("Use System.Runtime.InteropServices.ComTypes.DESCKIND instead. http://go.microsoft.com/fwlink/?linkid=14202", false)]
    public enum DESCKIND : int
    {
        /// <summary>Indicates that no match was found.</summary>
        DESCKIND_NONE = 0,
        /// <summary>Indicates that a <see cref="T:System.Runtime.InteropServices.FUNCDESC" /> was returned.</summary>
        DESCKIND_FUNCDESC = 1,
        /// <summary>Indicates that a VARDESC was returned.</summary>
        DESCKIND_VARDESC = 2,
        /// <summary>Indicates that a TYPECOMP was returned.</summary>
        DESCKIND_TYPECOMP = 3,
        /// <summary>Indicates that an IMPLICITAPPOBJ was returned.</summary>
        DESCKIND_IMPLICITAPPOBJ = 4,
        /// <summary>Indicates an end of enumeration marker.</summary>
        DESCKIND_MAX = 5
    }
}
