using System;

namespace System.Runtime.InteropServices
{
    /// <summary>Use <see cref="T:System.Runtime.InteropServices.ComTypes.VARDESC" /> instead.</summary>
    [ObsoleteAttribute("Use System.Runtime.InteropServices.ComTypes.VARDESC instead. http://go.microsoft.com/fwlink/?linkid=14202", false)]
    public struct VARDESC
    {
        [ComVisibleAttribute(false)]
        public struct DESCUNION
        {
            public int oInst;
            public IntPtr lpvarValue;
        
        }
    
        /// <summary>Indicates the member ID of a variable.</summary>
        public int memid;
        /// <summary>This field is reserved for future use.</summary>
        public string lpstrSchema;
        /// <summary>Contains the variable type.</summary>
        public ELEMDESC elemdescVar;
        /// <summary>Defines the properties of a variable.</summary>
        public short wVarFlags;
        /// <summary>Defines how a variable should be marshaled.</summary>
        public VarEnum varkind;
    
    }
}
