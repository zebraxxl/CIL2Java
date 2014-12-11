using System;

namespace System.Runtime.InteropServices
{
    /// <summary>Describes the original settings of the FUNCFLAGS in the COM type library from where this method was imported.</summary>
    [Serializable]
    [FlagsAttribute()]
    [ComVisibleAttribute(true)]
    public enum TypeLibFuncFlags : int
    {
        /// <summary>This flag is intended for system-level functions or functions that type browsers should not display.</summary>
        FRestricted = 1,
        /// <summary>The function returns an object that is a source of events.</summary>
        FSource = 2,
        /// <summary>The function that supports data binding.</summary>
        FBindable = 4,
        /// <summary>When set, any call to a method that sets the property results first in a call to IPropertyNotifySink::OnRequestEdit.</summary>
        FRequestEdit = 8,
        /// <summary>The function that is displayed to the user as bindable. <see cref="F:System.Runtime.InteropServices.TypeLibFuncFlags.FBindable" /> must also be set.</summary>
        FDisplayBind = 16,
        /// <summary>The function that best represents the object. Only one function in a type information can have this attribute.</summary>
        FDefaultBind = 32,
        /// <summary>The function should not be displayed to the user, although it exists and is bindable.</summary>
        FHidden = 64,
        /// <summary>The function supports GetLastError.</summary>
        FUsesGetLastError = 128,
        /// <summary>Permits an optimization in which the compiler looks for a member named "xyz" on the type "abc". If such a member is found and is flagged as an accessor function for an element of the default collection, then a call is generated to that member function.</summary>
        FDefaultCollelem = 256,
        /// <summary>The type information member is the default member for display in the user interface.</summary>
        FUiDefault = 512,
        /// <summary>The property appears in an object browser, but not in a properties browser.</summary>
        FNonBrowsable = 1024,
        /// <summary>Tags the interface as having default behaviors.</summary>
        FReplaceable = 2048,
        /// <summary>The function is mapped as individual bindable properties.</summary>
        FImmediateBind = 4096
    }
}
