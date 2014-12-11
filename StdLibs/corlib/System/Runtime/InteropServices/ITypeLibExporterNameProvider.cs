
namespace System.Runtime.InteropServices
{
    /// <summary>Provides control over the casing of names when exported to a type library.</summary>
    [GuidAttribute("FA1F3615-ACB9-486d-9EAC-1BEF87E36B09")]
    [ComVisibleAttribute(true)]
    [InterfaceTypeAttribute(ComInterfaceType.InterfaceIsIUnknown)]
    public interface ITypeLibExporterNameProvider
    {
        string[] GetNames();
        
        
    }
}
