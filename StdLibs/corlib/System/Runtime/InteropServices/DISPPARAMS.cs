using System;

namespace System.Runtime.InteropServices
{
    /// <summary>Use <see cref="T:System.Runtime.InteropServices.ComTypes.DISPPARAMS" /> instead.</summary>
    [ObsoleteAttribute("Use System.Runtime.InteropServices.ComTypes.DISPPARAMS instead. http://go.microsoft.com/fwlink/?linkid=14202", false)]
    public struct DISPPARAMS
    {
        /// <summary>Represents a reference to the array of arguments.</summary>
        public IntPtr rgvarg;
        /// <summary>Represents the dispatch IDs of named arguments.</summary>
        public IntPtr rgdispidNamedArgs;
        /// <summary>Represents the count of arguments.</summary>
        public int cArgs;
        /// <summary>Represents the count of named arguments </summary>
        public int cNamedArgs;
    
    }
}
