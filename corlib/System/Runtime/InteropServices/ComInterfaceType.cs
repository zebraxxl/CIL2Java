using System;

namespace System.Runtime.InteropServices
{
    /// <summary>Identifies how to expose an interface to COM.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    public enum ComInterfaceType : int
    {
        /// <summary>Indicates that the interface is exposed to COM as a dual interface, which enables both early and late binding. <see cref="F:System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual" /> is the default value.</summary>
        InterfaceIsDual = 0,
        /// <summary>Indicates that an interface is exposed to COM as an interface that is derived from IUnknown, which enables only early binding.</summary>
        InterfaceIsIUnknown = 1,
        /// <summary>Indicates that an interface is exposed to COM as a dispinterface, which enables late binding only.</summary>
        InterfaceIsIDispatch = 2,
        /// <summary>Indicates that an interface is exposed to COM as a Windows Runtime interface. </summary>
        InterfaceIsIInspectable = 3
    }
}
