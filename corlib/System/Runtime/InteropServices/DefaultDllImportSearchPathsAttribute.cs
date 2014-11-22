using System;

namespace System.Runtime.InteropServices
{
    /// <summary>Specifies the paths that are used to search for DLLs that provide functions for platform invokes. </summary>
    [ComVisibleAttribute(false)]
    [AttributeUsageAttribute(AttributeTargets.Assembly|AttributeTargets.Method, AllowMultiple = false)]
    public sealed class DefaultDllImportSearchPathsAttribute : Attribute
    {
    
        /// <summary>Gets a bitwise combination of enumeration values that specify the paths that the LoadLibraryEx function searches during platform invokes. </summary><returns>A bitwise combination of enumeration values that specify search paths for platform invokes. </returns>
        public DllImportSearchPath Paths
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Runtime.InteropServices.DefaultDllImportSearchPathsAttribute" /> class, specifying the paths to use when searching for the targets of platform invokes. </summary><param name="paths">A bitwise combination of enumeration values that specify the paths that the LoadLibraryEx function searches during platform invokes. </param>
        public DefaultDllImportSearchPathsAttribute(DllImportSearchPath paths)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
