using System;

namespace System.Runtime.InteropServices
{
    /// <summary>Use <see cref="T:System.Runtime.InteropServices.ComTypes.FUNCDESC" /> instead.</summary>
    [ObsoleteAttribute("Use System.Runtime.InteropServices.ComTypes.FUNCDESC instead. http://go.microsoft.com/fwlink/?linkid=14202", false)]
    public struct FUNCDESC
    {
        /// <summary>Identifies the function member ID.</summary>
        public int memid;
        /// <summary>Stores the count of errors a function can return on a 16-bit system.</summary>
        public IntPtr lprgscode;
        /// <summary>Indicates the size of <see cref="F:System.Runtime.InteropServices.FUNCDESC.cParams" />.</summary>
        public IntPtr lprgelemdescParam;
        /// <summary>Specifies whether the function is virtual, static, or dispatch-only.</summary>
        public FUNCKIND funckind;
        /// <summary>Specifies the type of a property function.</summary>
        public INVOKEKIND invkind;
        /// <summary>Specifies the calling convention of a function.</summary>
        public CALLCONV callconv;
        /// <summary>Counts the total number of parameters.</summary>
        public short cParams;
        /// <summary>Counts the optional parameters.</summary>
        public short cParamsOpt;
        /// <summary>Specifies the offset in the VTBL for <see cref="F:System.Runtime.InteropServices.FUNCKIND.FUNC_VIRTUAL" />.</summary>
        public short oVft;
        /// <summary>Counts the permitted return values.</summary>
        public short cScodes;
        /// <summary>Contains the return type of the function.</summary>
        public ELEMDESC elemdescFunc;
        /// <summary>Indicates the <see cref="T:System.Runtime.InteropServices.FUNCFLAGS" /> of a function.</summary>
        public short wFuncFlags;
    
    }
}
