using System.Runtime.InteropServices;
using System;

namespace System.Globalization
{
    /// <summary>Specifies the culture-specific display of digits.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    public enum DigitShapes : int
    {
        /// <summary>The digit shape depends on the previous text in the same output. European digits follow Latin scripts; Arabic-Indic digits follow Arabic text; and Thai digits follow Thai text.</summary>
        Context = 0,
        /// <summary>The digit shape is not changed. Full Unicode compatibility is maintained.</summary>
        None = 1,
        /// <summary>The digit shape is the native equivalent of the digits from 0 through 9. ASCII digits from 0 through 9 are replaced by equivalent native national digits.</summary>
        NativeNational = 2
    }
}
