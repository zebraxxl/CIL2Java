using System.Runtime.InteropServices;

namespace System.Runtime.InteropServices.ComTypes
{
    [InterfaceTypeAttribute(ComInterfaceType.InterfaceIsIUnknown)]
    [GuidAttribute("0000010F-0000-0000-C000-000000000046")]
    public interface IAdviseSink
    {
        void OnDataChange(ref FORMATETC format, ref STGMEDIUM stgmedium);
        
        
        void OnViewChange(int aspect, int index);
        
        
        void OnRename(IMoniker moniker);
        
        
        void OnSave();
        
        
        void OnClose();
        
        
    }
}
