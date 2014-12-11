using System;

namespace System.Runtime.InteropServices
{
    /// <summary>Use <see cref="T:System.Runtime.InteropServices.ComTypes.FUNCFLAGS" /> instead. </summary>
    [Serializable]
    [ObsoleteAttribute("Use System.Runtime.InteropServices.ComTypes.FUNCFLAGS instead. http://go.microsoft.com/fwlink/?linkid=14202", false)]
    [FlagsAttribute()]
    public enum FUNCFLAGS : short
    {
        /// <summary>The function should not be accessible from macro languages. This flag is intended for system-level functions or functions that type browsers should not display.</summary>
        FUNCFLAG_FRESTRICTED = 1,
        /// <summary>The function returns an object that is a source of events.</summary>
        FUNCFLAG_FSOURCE = 2,
        /// <summary>The function that supports data binding.</summary>
        FUNCFLAG_FBINDABLE = 4,
        /// <summary>When set, any call to a method that sets the property results first in a call to IPropertyNotifySink::OnRequestEdit. The implementation of OnRequestEdit determines if the call is allowed to set the property.</summary>
        FUNCFLAG_FREQUESTEDIT = 8,
        /// <summary>The function that is displayed to the user as bindable. <see cref="F:System.Runtime.InteropServices.FUNCFLAGS.FUNCFLAG_FBINDABLE" /> must also be set.</summary>
        FUNCFLAG_FDISPLAYBIND = 16,
        /// <summary>The function that best represents the object. Only one function in a type information can have this attribute.</summary>
        FUNCFLAG_FDEFAULTBIND = 32,
        /// <summary>The function should not be displayed to the user, although it exists and is bindable.</summary>
        FUNCFLAG_FHIDDEN = 64,
        /// <summary>The function supports GetLastError. If an error occurs during the function, the caller can call GetLastError to retrieve the error code.</summary>
        FUNCFLAG_FUSESGETLASTERROR = 128,
        /// <summary>Permits an optimization in which the compiler looks for a member named "xyz" on the type of "abc". If such a member is found, and is flagged as an accessor function for an element of the default collection, a call is generated to that member function. Permitted on members in dispinterfaces and interfaces; not permitted on modules.</summary>
        FUNCFLAG_FDEFAULTCOLLELEM = 256,
        /// <summary>The type information member is the default member for display in the user interface.</summary>
        FUNCFLAG_FUIDEFAULT = 512,
        /// <summary>The property appears in an object browser, but not in a properties browser.</summary>
        FUNCFLAG_FNONBROWSABLE = 1024,
        /// <summary>Tags the interface as having default behaviors.</summary>
        FUNCFLAG_FREPLACEABLE = 2048,
        /// <summary>Mapped as individual bindable properties.</summary>
        FUNCFLAG_FIMMEDIATEBIND = 4096
    }
}
