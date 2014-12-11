using System;

namespace System.Runtime.InteropServices.ComTypes
{
    /// <summary>Identifies the constants that define the properties of a variable.</summary>
    [Serializable]
    [FlagsAttribute()]
    public enum VARFLAGS : short
    {
        /// <summary>Assignment to the variable should not be allowed.</summary>
        VARFLAG_FREADONLY = 1,
        /// <summary>The variable returns an object that is a source of events.</summary>
        VARFLAG_FSOURCE = 2,
        /// <summary>The variable supports data binding.</summary>
        VARFLAG_FBINDABLE = 4,
        /// <summary>When set, any attempt to directly change the property results in a call to IPropertyNotifySink::OnRequestEdit. The implementation of OnRequestEdit determines if the change is accepted.</summary>
        VARFLAG_FREQUESTEDIT = 8,
        /// <summary>The variable is displayed to the user as bindable. <see cref="F:System.Runtime.InteropServices.VARFLAGS.VARFLAG_FBINDABLE" /> must also be set.</summary>
        VARFLAG_FDISPLAYBIND = 16,
        /// <summary>The variable is the single property that best represents the object. Only one variable in type information can have this attribute.</summary>
        VARFLAG_FDEFAULTBIND = 32,
        /// <summary>The variable should not be displayed to the user in a browser, although it exists and is bindable.</summary>
        VARFLAG_FHIDDEN = 64,
        /// <summary>The variable should not be accessible from macro languages. This flag is intended for system-level variables or variables that you do not want type browsers to display.</summary>
        VARFLAG_FRESTRICTED = 128,
        /// <summary>Permits an optimization in which the compiler looks for a member named "xyz" on the type of "abc". If such a member is found and is flagged as an accessor function for an element of the default collection, then a call is generated to that member function. Permitted on members in dispinterfaces and interfaces; not permitted on modules.</summary>
        VARFLAG_FDEFAULTCOLLELEM = 256,
        /// <summary>The variable is the default display in the user interface.</summary>
        VARFLAG_FUIDEFAULT = 512,
        /// <summary>The variable appears in an object browser, but not in a properties browser.</summary>
        VARFLAG_FNONBROWSABLE = 1024,
        /// <summary>Tags the interface as having default behaviors.</summary>
        VARFLAG_FREPLACEABLE = 2048,
        /// <summary>The variable is mapped as individual bindable properties.</summary>
        VARFLAG_FIMMEDIATEBIND = 4096
    }
}
