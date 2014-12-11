using System;

namespace System.Runtime.InteropServices
{
    /// <summary>Use <see cref="T:System.Runtime.InteropServices.ComTypes.IRunningObjectTable" /> instead.</summary>
    [GuidAttribute("00000010-0000-0000-C000-000000000046")]
    [ObsoleteAttribute("Use System.Runtime.InteropServices.ComTypes.IRunningObjectTable instead. http://go.microsoft.com/fwlink/?linkid=14202", false)]
    [InterfaceTypeAttribute(ComInterfaceType.InterfaceIsIUnknown)]
    public interface UCOMIRunningObjectTable
    {
        void Register(int grfFlags, object punkObject, UCOMIMoniker pmkObjectName, ref int pdwRegister);
        
        
        /// <summary>Unregisters the specified object from the ROT.</summary><param name="dwRegister">The ROT entry to revoke. </param>
        void Revoke(int dwRegister);
        
        
        /// <summary>Determines if the specified moniker is currently registered in the Running Object Table.</summary><param name="pmkObjectName">Reference to the moniker to search for in the Running Object Table. </param>
        void IsRunning(UCOMIMoniker pmkObjectName);
        
        
        void GetObject(UCOMIMoniker pmkObjectName, ref object ppunkObject);
        
        
        void NoteChangeTime(int dwRegister, ref FILETIME pfiletime);
        
        
        void GetTimeOfLastChange(UCOMIMoniker pmkObjectName, ref FILETIME pfiletime);
        
        
        void EnumRunning(ref UCOMIEnumMoniker ppenumMoniker);
        
        
    }
}
