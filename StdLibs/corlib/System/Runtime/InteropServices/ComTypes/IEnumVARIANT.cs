using System.Runtime.InteropServices;
using System;

namespace System.Runtime.InteropServices.ComTypes
{
    /// <summary>Manages the definition of the IEnumVARIANT interface.</summary>
    [InterfaceTypeAttribute(ComInterfaceType.InterfaceIsIUnknown)]
    [GuidAttribute("00020404-0000-0000-C000-000000000046")]
    public interface IEnumVARIANT
    {
        /// <summary>Retrieves a specified number of items in the enumeration sequence.</summary><returns>S_OK if the <paramref name="pceltFetched" /> parameter equals the <paramref name="celt" /> parameter; otherwise, S_FALSE.</returns><param name="celt">The number of elements to return in <paramref name="rgelt" />. </param><param name="rgVar">When this method returns, contains a reference to the enumerated elements. This parameter is passed uninitialized.</param><param name="pceltFetched">When this method returns, contains a reference to the actual number of elements enumerated in <paramref name="rgelt" />. </param>
        int Next(int celt, object[] rgVar, IntPtr pceltFetched);
        
        
        /// <summary>Skips a specified number of items in the enumeration sequence.</summary><returns>S_OK if the number of elements skipped equals <paramref name="celt" /> parameter; otherwise, S_FALSE.</returns><param name="celt">The number of elements to skip in the enumeration. </param>
        int Skip(int celt);
        
        
        int Reset();
        
        
        IEnumVARIANT Clone();
        
        
    }
}
