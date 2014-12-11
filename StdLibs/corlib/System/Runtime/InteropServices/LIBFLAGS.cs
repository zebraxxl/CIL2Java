using System;

namespace System.Runtime.InteropServices
{
    /// <summary>Use <see cref="T:System.Runtime.InteropServices.ComTypes.LIBFLAGS" /> instead.</summary>
    [Serializable]
    [ObsoleteAttribute("Use System.Runtime.InteropServices.ComTypes.LIBFLAGS instead. http://go.microsoft.com/fwlink/?linkid=14202", false)]
    [FlagsAttribute()]
    public enum LIBFLAGS : short
    {
        /// <summary>The type library is restricted, and should not be displayed to users.</summary>
        LIBFLAG_FRESTRICTED = 1,
        /// <summary>The type library describes controls, and should not be displayed in type browsers intended for nonvisual objects.</summary>
        LIBFLAG_FCONTROL = 2,
        /// <summary>The type library should not be displayed to users, although its use is not restricted. Should be used by controls. Hosts should create a new type library that wraps the control with extended properties.</summary>
        LIBFLAG_FHIDDEN = 4,
        /// <summary>The type library exists in a persisted form on disk.</summary>
        LIBFLAG_FHASDISKIMAGE = 8
    }
}
