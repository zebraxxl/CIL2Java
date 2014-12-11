using System;

namespace System.Runtime.InteropServices
{
    /// <summary>Use <see cref="T:System.Runtime.InteropServices.ComTypes.IEnumConnectionPoints" /> instead. </summary>
    [GuidAttribute("B196B285-BAB4-101A-B69C-00AA00341D07")]
    [ObsoleteAttribute("Use System.Runtime.InteropServices.ComTypes.IEnumConnectionPoints instead. http://go.microsoft.com/fwlink/?linkid=14202", false)]
    [InterfaceTypeAttribute(ComInterfaceType.InterfaceIsIUnknown)]
    public interface UCOMIEnumConnectionPoints
    {
        int Next(int celt, UCOMIConnectionPoint[] rgelt, ref int pceltFetched);
        
        
        /// <summary>Skips over a specified number of items in the enumeration sequence.</summary><returns>S_OK if the number of elements skipped equals the <paramref name="celt" /> parameter; otherwise, S_FALSE.</returns><param name="celt">The number of elements to skip in the enumeration. </param>
        int Skip(int celt);
        
        
        int Reset();
        
        
        void Clone(ref UCOMIEnumConnectionPoints ppenum);
        
        
    }
}
