using System.Runtime.InteropServices;
using System;

namespace System.Runtime.InteropServices.ComTypes
{
    /// <summary>Manages the definition of the IEnumMoniker interface.</summary>
    [GuidAttribute("00000102-0000-0000-C000-000000000046")]
    [InterfaceTypeAttribute(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IEnumMoniker
    {
        /// <summary>Retrieves a specified number of items in the enumeration sequence.</summary><returns>S_OK if the <paramref name="pceltFetched" /> parameter equals the <paramref name="celt" /> parameter; otherwise, S_FALSE.</returns><param name="celt">The number of monikers to return in <paramref name="rgelt" />. </param><param name="rgelt">When this method returns, contains a reference to the enumerated monikers. This parameter is passed uninitialized.</param><param name="pceltFetched">When this method returns, contains a reference to the actual number of monikers enumerated in <paramref name="rgelt" />. </param>
        int Next(int celt, IMoniker[] rgelt, IntPtr pceltFetched);
        
        
        /// <summary>Skips a specified number of items in the enumeration sequence.</summary><returns>S_OK if the number of elements skipped equals the <paramref name="celt" /> parameter; otherwise, S_FALSE.</returns><param name="celt">The number of elements to skip in the enumeration. </param>
        int Skip(int celt);
        
        
        void Reset();
        
        
        void Clone(ref IEnumMoniker ppenum);
        
        
    }
}
