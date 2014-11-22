using System;

namespace System.Runtime.InteropServices
{
    /// <summary>Use <see cref="T:System.Runtime.InteropServices.ComTypes.IEnumMoniker" /> instead.</summary>
    [InterfaceTypeAttribute(ComInterfaceType.InterfaceIsIUnknown)]
    [ObsoleteAttribute("Use System.Runtime.InteropServices.ComTypes.IEnumMoniker instead. http://go.microsoft.com/fwlink/?linkid=14202", false)]
    [GuidAttribute("00000102-0000-0000-C000-000000000046")]
    public interface UCOMIEnumMoniker
    {
        int Next(int celt, UCOMIMoniker[] rgelt, ref int pceltFetched);
        
        
        /// <summary>Skips over a specified number of items in the enumeration sequence.</summary><returns>S_OK if the number of elements skipped equals the <paramref name="celt" /> parameter; otherwise, S_FALSE.</returns><param name="celt">The number of elements to skip in the enumeration. </param>
        int Skip(int celt);
        
        
        int Reset();
        
        
        void Clone(ref UCOMIEnumMoniker ppenum);
        
        
    }
}
