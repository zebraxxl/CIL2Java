using System;

namespace System.Runtime.InteropServices
{
    /// <summary>Use <see cref="T:System.Runtime.InteropServices.ComTypes.IEnumVARIANT" /> instead.</summary>
    [ObsoleteAttribute("Use System.Runtime.InteropServices.ComTypes.IEnumVARIANT instead. http://go.microsoft.com/fwlink/?linkid=14202", false)]
    [GuidAttribute("00020404-0000-0000-C000-000000000046")]
    [InterfaceTypeAttribute(ComInterfaceType.InterfaceIsIUnknown)]
    public interface UCOMIEnumVARIANT
    {
        /// <summary>Retrieves a specified number of items in the enumeration sequence.</summary><returns>S_OK if the <paramref name="pceltFetched" /> parameter equals the <paramref name="celt" /> parameter; otherwise, S_FALSE.</returns><param name="celt">The number of elements to return in <paramref name="rgelt" />. </param><param name="rgvar">On successful return, a reference to the enumerated elements. </param><param name="pceltFetched">On successful return, a reference to the actual number of elements enumerated in <paramref name="rgelt" />. </param>
        int Next(int celt, int rgvar, int pceltFetched);
        
        
        /// <summary>Skips over a specified number of items in the enumeration sequence.</summary><returns>S_OK if the number of elements skipped equals <paramref name="celt" /> parameter; otherwise, S_FALSE.</returns><param name="celt">The number of elements to skip in the enumeration. </param>
        int Skip(int celt);
        
        
        int Reset();
        
        
        /// <summary>Creates another enumerator that contains the same enumeration state as the current one.</summary><param name="ppenum">On successful return, a reference to the newly created enumerator. </param>
        void Clone(int ppenum);
        
        
    }
}
