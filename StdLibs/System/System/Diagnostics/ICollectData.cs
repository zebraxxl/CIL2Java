using System.Runtime.InteropServices;
using System;

namespace System.Diagnostics
{
    [GuidAttribute("73386977-D6FD-11D2-BED5-00C04F79E3AE")]
    [InterfaceTypeAttribute(ComInterfaceType.InterfaceIsIUnknown)]
    public interface ICollectData
    {
        void CollectData(int id, IntPtr valueName, IntPtr data, int totalBytes, ref IntPtr res);
        
        
        void CloseData();
        
        
    }
}
