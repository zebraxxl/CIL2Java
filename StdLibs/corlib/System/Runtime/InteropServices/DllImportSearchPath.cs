using System;

namespace System.Runtime.InteropServices
{
    /// <summary>Specifies the paths that are used to search for DLLs that provide functions for platform invokes. </summary>
    [FlagsAttribute()]
    public enum DllImportSearchPath : int
    {
        /// <summary>Search for the dependencies of a DLL in the folder where the DLL is located before searching other folders. </summary>
        UseDllDirectoryForDependencies = 256,
        /// <summary>Include the application directory in the DLL search path. </summary>
        ApplicationDirectory = 512,
        /// <summary>Include any path that was explicitly added to the process-wide search path by using the Win32 AddDllDirectory function. </summary>
        UserDirectories = 1024,
        /// <summary>Include the %WinDir%\System32 directory in the DLL search path. </summary>
        System32 = 2048,
        /// <summary>Include the application directory, the %WinDir%\System32 directory, and user directories in the DLL search path. </summary>
        SafeDirectories = 4096,
        /// <summary>When searching for assembly dependencies, include the directory that contains the assembly itself, and search that directory first. This value is used by the .NET Framework, before the paths are passed to the Win32 LoadLibraryEx function. </summary>
        AssemblyDirectory = 2,
        /// <summary>Search the application directory, and then call the Win32 LoadLibraryEx function with the LOAD_WITH_ALTERED_SEARCH_PATH flag. This value is ignored if any other value is specified. Operating systems that do not support the <see cref="T:System.Runtime.InteropServices.DefaultDllImportSearchPathsAttribute" /> attribute use this value, and ignore other values. </summary>
        LegacyBehavior = 0
    }
}
