using System.Runtime.InteropServices;
using System;

namespace System.Diagnostics.SymbolStore
{
    /// <summary>Holds the public GUIDs for language vendors to be used with the symbol store.</summary>
    [ComVisibleAttribute(true)]
    public class SymLanguageVendor
    {
        /// <summary>Specifies the GUID of the Microsoft language vendor.</summary>
        public static readonly Guid Microsoft;
    
        public SymLanguageVendor()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
