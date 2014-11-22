using System;

namespace System.Runtime.InteropServices
{
    /// <summary>Use <see cref="T:System.Runtime.InteropServices.ComTypes.IEnumString" /> instead.</summary>
    [ObsoleteAttribute("Use System.Runtime.InteropServices.ComTypes.IEnumString instead. http://go.microsoft.com/fwlink/?linkid=14202", false)]
    [InterfaceTypeAttribute(ComInterfaceType.InterfaceIsIUnknown)]
    [GuidAttribute("00000101-0000-0000-C000-000000000046")]
    public interface UCOMIEnumString
    {
        int Next(int celt, string[] rgelt, ref int pceltFetched);
        
        
        /// <summary>Skips over a specified number of items in the enumeration sequence.</summary><returns>S_OK if the number of elements skipped equals the <paramref name="celt" /> parameter; otherwise, S_FALSE.</returns><param name="celt">The number of elements to skip in the enumeration. </param>
        int Skip(int celt);
        
        
        int Reset();
        
        
        void Clone(ref UCOMIEnumString ppenum);
        
        
    }
}
