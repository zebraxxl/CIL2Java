using System;

namespace System.Runtime.InteropServices.ComTypes
{
    /// <summary>Contains the arguments passed to a method or property by IDispatch::Invoke.</summary>
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
