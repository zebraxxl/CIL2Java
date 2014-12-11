using System.Runtime.InteropServices;
using System;

namespace System.Runtime.InteropServices.ComTypes
{
    /// <summary>Provides the managed definition of the IPersistFile interface, with functionality from IPersist.</summary>
    [InterfaceTypeAttribute(ComInterfaceType.InterfaceIsIUnknown)]
    [GuidAttribute("0000010b-0000-0000-C000-000000000046")]
    public interface IPersistFile
    {
        void GetClassID(ref Guid pClassID);
        
        
        int IsDirty();
        
        
        /// <summary>Opens the specified file and initializes an object from the file contents.</summary><param name="pszFileName">A zero-terminated string containing the absolute path of the file to open. </param><param name="dwMode">A combination of values from the STGM enumeration to indicate the access mode in which to open <paramref name="pszFileName" />. </param>
        void Load(string pszFileName, int dwMode);
        
        
        /// <summary>Saves a copy of the object into the specified file.</summary><param name="pszFileName">A zero-terminated string containing the absolute path of the file to which the object is saved. </param><param name="fRemember">true to used the <paramref name="pszFileName" /> parameter as the current working file; otherwise false. </param>
        void Save(string pszFileName, bool fRemember);
        
        
        /// <summary>Notifies the object that it can write to its file.</summary><param name="pszFileName">The absolute path of the file where the object was previously saved. </param>
        void SaveCompleted(string pszFileName);
        
        
        void GetCurFile(ref string ppszFileName);
        
        
    }
}
