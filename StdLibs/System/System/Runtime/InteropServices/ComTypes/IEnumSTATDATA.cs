using System.Runtime.InteropServices;

namespace System.Runtime.InteropServices.ComTypes
{
    [GuidAttribute("00000103-0000-0000-C000-000000000046")]
    [InterfaceTypeAttribute(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IEnumSTATDATA
    {
        int Next(int celt, STATDATA[] rgelt, int[] pceltFetched);
        
        
        int Skip(int celt);
        
        
        int Reset();
        
        
        void Clone(ref IEnumSTATDATA newEnum);
        
        
    }
}
