using System.Runtime.InteropServices;

namespace System.Runtime.InteropServices.ComTypes
{
    /// <summary>Provides the managed definition of the IRunningObjectTable interface.</summary>
    [InterfaceTypeAttribute(ComInterfaceType.InterfaceIsIUnknown)]
    [GuidAttribute("00000010-0000-0000-C000-000000000046")]
    public interface IRunningObjectTable
    {
        /// <summary>Registers that the supplied object has entered the running state.</summary><returns>A value that can be used to identify this ROT entry in subsequent calls to <see cref="M:System.Runtime.InteropServices.ComTypes.IRunningObjectTable.Revoke(System.Int32)" /> or <see cref="M:System.Runtime.InteropServices.ComTypes.IRunningObjectTable.NoteChangeTime(System.Int32,System.Runtime.InteropServices.ComTypes.FILETIME@)" />.</returns><param name="grfFlags">Specifies whether the Running Object Table's (ROT) reference to <paramref name="punkObject" /> is weak or strong, and controls access to the object through its entry in the ROT. </param><param name="punkObject">A reference to the object being registered as running. </param><param name="pmkObjectName">A reference to the moniker that identifies <paramref name="punkObject" />. </param>
        int Register(int grfFlags, object punkObject, IMoniker pmkObjectName);
        
        
        /// <summary>Unregisters the specified object from the Running Object Table (ROT).</summary><param name="dwRegister">The Running Object Table (ROT) entry to revoke. </param>
        void Revoke(int dwRegister);
        
        
        /// <summary>Determines whether the specified moniker is currently registered in the Running Object Table (ROT).</summary><returns>An HRESULT value that indicates the success or failure of the operation.</returns><param name="pmkObjectName">A reference to the moniker to search for in the Running Object Table (ROT). </param>
        int IsRunning(IMoniker pmkObjectName);
        
        
        int GetObject(IMoniker pmkObjectName, ref object ppunkObject);
        
        
        void NoteChangeTime(int dwRegister, ref FILETIME pfiletime);
        
        
        int GetTimeOfLastChange(IMoniker pmkObjectName, ref FILETIME pfiletime);
        
        
        void EnumRunning(ref IEnumMoniker ppenumMoniker);
        
        
    }
}
