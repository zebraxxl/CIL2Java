using System;
using System.Security;
using System.Collections.Generic;

namespace System.Runtime.InteropServices.WindowsRuntime
{
    /// <summary>Provides an event for resolving reflection-only type requests for types that are provided by Windows Metadata files, and methods for performing the resolution. </summary>
    public static class WindowsRuntimeMetadata
    {
    
        /// <summary>Occurs when the resolution of a Windows Metadata file fails in the reflection-only context. </summary>
        public static event EventHandler<NamespaceResolveEventArgs> ReflectionOnlyNamespaceResolve;
    
        /// <summary>Occurs when the resolution of a Windows Metadata file fails in the design environment. </summary>
        public static event EventHandler<DesignerNamespaceResolveEventArgs> DesignerNamespaceResolve;
    
    
        [SecurityCriticalAttribute()]
        public static IEnumerable<string> ResolveNamespace(string namespaceName, IEnumerable<string> packageGraphFilePaths)
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        public static IEnumerable<string> ResolveNamespace(string namespaceName, string windowsSdkFilePath, IEnumerable<string> packageGraphFilePaths)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
