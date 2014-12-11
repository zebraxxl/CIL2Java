using System;

namespace System.Runtime.InteropServices
{
    /// <summary>Indicates to a COM client that all classes in the current version of an assembly are compatible with classes in an earlier version of the assembly.</summary>
    [AttributeUsageAttribute(AttributeTargets.Assembly, Inherited = false)]
    [ComVisibleAttribute(true)]
    public sealed class ComCompatibleVersionAttribute : Attribute
    {
    
        /// <summary>Gets the major version number of the assembly.</summary><returns>The major version number of the assembly.</returns>
        public int MajorVersion
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the minor version number of the assembly.</summary><returns>The minor version number of the assembly.</returns>
        public int MinorVersion
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the build number of the assembly.</summary><returns>The build number of the assembly.</returns>
        public int BuildNumber
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the revision number of the assembly.</summary><returns>The revision number of the assembly.</returns>
        public int RevisionNumber
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Runtime.InteropServices.ComCompatibleVersionAttribute" /> class with the major version, minor version, build, and revision numbers of the assembly.</summary><param name="major">The major version number of the assembly. </param><param name="minor">The minor version number of the assembly. </param><param name="build">The build number of the assembly. </param><param name="revision">The revision number of the assembly. </param>
        public ComCompatibleVersionAttribute(int major, int minor, int build, int revision)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
