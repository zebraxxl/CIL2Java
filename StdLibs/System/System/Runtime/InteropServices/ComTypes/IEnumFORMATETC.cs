using System.Runtime.InteropServices;

namespace System.Runtime.InteropServices.ComTypes
{
    [InterfaceTypeAttribute(ComInterfaceType.InterfaceIsIUnknown)]
    [GuidAttribute("00000103-0000-0000-C000-000000000046")]
    public interface IEnumFORMATETC
    {
        int Next(int celt, FORMATETC[] rgelt, int[] pceltFetched);
        
        
        int Skip(int celt);
        
        
        int Reset();
        
        
        void Clone(ref IEnumFORMATETC newEnum);
        
        
    }
}
