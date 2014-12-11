using System;

namespace System.Runtime.InteropServices
{
    /// <summary>Use <see cref="T:System.Runtime.InteropServices.ComTypes.ELEMDESC" /> instead.</summary>
    [ObsoleteAttribute("Use System.Runtime.InteropServices.ComTypes.ELEMDESC instead. http://go.microsoft.com/fwlink/?linkid=14202", false)]
    public struct ELEMDESC
    {
        [ComVisibleAttribute(false)]
        public struct DESCUNION
        {
            public IDLDESC idldesc;
            public PARAMDESC paramdesc;
        
        }
    
        /// <summary>Identifies the type of the element.</summary>
        public TYPEDESC tdesc;
        /// <summary>Contains information about an element.</summary>
        public DESCUNION desc;
    
    }
}
