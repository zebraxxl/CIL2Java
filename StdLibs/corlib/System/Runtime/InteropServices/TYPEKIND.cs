using System;

namespace System.Runtime.InteropServices
{
    /// <summary>Use <see cref="T:System.Runtime.InteropServices.ComTypes.TYPEKIND" /> instead.</summary>
    [Serializable]
    [ObsoleteAttribute("Use System.Runtime.InteropServices.ComTypes.TYPEKIND instead. http://go.microsoft.com/fwlink/?linkid=14202", false)]
    public enum TYPEKIND : int
    {
        /// <summary>A set of enumerators.</summary>
        TKIND_ENUM = 0,
        /// <summary>A structure with no methods.</summary>
        TKIND_RECORD = 1,
        /// <summary>A module that can only have static functions and data (for example, a DLL).</summary>
        TKIND_MODULE = 2,
        /// <summary>A type that has virtual functions, all of which are pure.</summary>
        TKIND_INTERFACE = 3,
        /// <summary>A set of methods and properties that are accessible through IDispatch::Invoke. By default, dual interfaces return TKIND_DISPATCH.</summary>
        TKIND_DISPATCH = 4,
        /// <summary>A set of implemented components interfaces.</summary>
        TKIND_COCLASS = 5,
        /// <summary>A type that is an alias for another type.</summary>
        TKIND_ALIAS = 6,
        /// <summary>A union of all members that have an offset of zero.</summary>
        TKIND_UNION = 7,
        /// <summary>End of enumeration marker.</summary>
        TKIND_MAX = 8
    }
}
