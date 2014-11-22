using System.Runtime.InteropServices;

namespace System.Runtime.Remoting
{
    /// <summary>Defines the interface for unwrapping marshal-by-value objects from indirection.</summary>
    [InterfaceTypeAttribute(ComInterfaceType.InterfaceIsIUnknown)]
    [ComVisibleAttribute(true)]
    [GuidAttribute("C460E2B4-E199-412a-8456-84DC3E4838C3")]
    public interface IObjectHandle
    {
        object Unwrap();
        
        
    }
}
