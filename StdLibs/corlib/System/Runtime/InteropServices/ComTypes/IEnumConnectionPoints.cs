using System.Runtime.InteropServices;
using System;

namespace System.Runtime.InteropServices.ComTypes
{
    /// <summary>Manages the definition of the IEnumConnectionPoints interface.</summary>
    [InterfaceTypeAttribute(ComInterfaceType.InterfaceIsIUnknown)]
    [GuidAttribute("B196B285-BAB4-101A-B69C-00AA00341D07")]
    public interface IEnumConnectionPoints
    {
        /// <summary>Retrieves a specified number of items in the enumeration sequence.</summary><returns>S_OK if the <paramref name="pceltFetched" /> parameter equals the <paramref name="celt" /> parameter; otherwise, S_FALSE.</returns><param name="celt">The number of IConnectionPoint references to return in <paramref name="rgelt" />. </param><param name="rgelt">When this method returns, contains a reference to the enumerated connections. This parameter is passed uninitialized.</param><param name="pceltFetched">When this method returns, contains a reference to the actual number of connections enumerated in <paramref name="rgelt" />. </param>
        int Next(int celt, IConnectionPoint[] rgelt, IntPtr pceltFetched);
        
        
        /// <summary>Skips a specified number of items in the enumeration sequence.</summary><returns>S_OK if the number of elements skipped equals the <paramref name="celt" /> parameter; otherwise, S_FALSE.</returns><param name="celt">The number of elements to skip in the enumeration. </param>
        int Skip(int celt);
        
        
        void Reset();
        
        
        void Clone(ref IEnumConnectionPoints ppenum);
        
        
    }
}
