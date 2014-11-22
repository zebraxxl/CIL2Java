using System;

namespace System.Runtime.InteropServices.ComTypes
{
    /// <summary>Describes a variable, constant, or data member.</summary>
    public struct VARDESC
    {
        public struct DESCUNION
        {
            public int oInst;
            public IntPtr lpvarValue;
        
        }
    
        /// <summary>Indicates the member ID of a variable.</summary>
        public int memid;
        /// <summary>This field is reserved for future use.</summary>
        public string lpstrSchema;
        /// <summary>Contains information about a variable.</summary>
        public DESCUNION desc;
        /// <summary>Contains the variable type.</summary>
        public ELEMDESC elemdescVar;
        /// <summary>Defines the properties of a variable.</summary>
        public short wVarFlags;
        /// <summary>Defines how to marshal a variable.</summary>
        public VARKIND varkind;
    
    }
}
