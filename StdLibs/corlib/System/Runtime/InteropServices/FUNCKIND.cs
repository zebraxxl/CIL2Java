using System;

namespace System.Runtime.InteropServices
{
    /// <summary>Use <see cref="T:System.Runtime.InteropServices.ComTypes.FUNCKIND" /> instead.</summary>
    [Serializable]
    [ObsoleteAttribute("Use System.Runtime.InteropServices.ComTypes.FUNCKIND instead. http://go.microsoft.com/fwlink/?linkid=14202", false)]
    public enum FUNCKIND : int
    {
        /// <summary>The function is accessed the same as <see cref="F:System.Runtime.InteropServices.FUNCKIND.FUNC_PUREVIRTUAL" />, except the function has an implementation.</summary>
        FUNC_VIRTUAL = 0,
        /// <summary>The function is accessed through the virtual function table (VTBL), and takes an implicit this pointer.</summary>
        FUNC_PUREVIRTUAL = 1,
        /// <summary>The function is accessed by static address and takes an implicit this pointer.</summary>
        FUNC_NONVIRTUAL = 2,
        /// <summary>The function is accessed by static address and does not take an implicit this pointer.</summary>
        FUNC_STATIC = 3,
        /// <summary>The function can be accessed only through IDispatch.</summary>
        FUNC_DISPATCH = 4
    }
}
