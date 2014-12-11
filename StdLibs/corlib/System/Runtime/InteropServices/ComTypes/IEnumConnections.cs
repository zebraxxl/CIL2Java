using System.Runtime.InteropServices;
using System;

namespace System.Runtime.InteropServices.ComTypes
{
    /// <summary>Manages the definition of the IEnumConnections interface.</summary>
    [GuidAttribute("B196B287-BAB4-101A-B69C-00AA00341D07")]
    [InterfaceTypeAttribute(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IEnumConnections
    {
        /// <summary>Retrieves a specified number of items in the enumeration sequence.</summary><returns>S_OK if the <paramref name="pceltFetched" /> parameter equals the <paramref name="celt" /> parameter; otherwise, S_FALSE.</returns><param name="celt">The number of <see cref="T:System.Runtime.InteropServices.CONNECTDATA" /> structures to return in <paramref name="rgelt" />. </param><param name="rgelt">When this method returns, contains a reference to the enumerated connections. This parameter is passed uninitialized.</param><param name="pceltFetched">When this method returns, contains a reference to the actual number of connections enumerated in <paramref name="rgelt" />. </param>
        int Next(int celt, CONNECTDATA[] rgelt, IntPtr pceltFetched);
        
        
        /// <summary>Skips a specified number of items in the enumeration sequence.</summary><returns>S_OK if the number of elements skipped equals the <paramref name="celt" /> parameter; otherwise, S_FALSE.</returns><param name="celt">The number of elements to skip in the enumeration. </param>
        int Skip(int celt);
        
        
        void Reset();
        
        
        void Clone(ref IEnumConnections ppenum);
        
        
    }
}
