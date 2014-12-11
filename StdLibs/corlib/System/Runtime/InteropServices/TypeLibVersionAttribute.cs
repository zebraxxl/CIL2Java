using System;

namespace System.Runtime.InteropServices
{
    /// <summary>Specifies the version number of an exported type library.</summary>
    [ComVisibleAttribute(true)]
    [AttributeUsageAttribute(AttributeTargets.Assembly, Inherited = false)]
    public sealed class TypeLibVersionAttribute : Attribute
    {
    
        /// <summary>Gets the major version number of the type library.</summary><returns>The major version number of the type library.</returns>
        public int MajorVersion
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the minor version number of the type library.</summary><returns>The minor version number of the type library.</returns>
        public int MinorVersion
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Runtime.InteropServices.TypeLibVersionAttribute" /> class with the major and minor version numbers of the type library.</summary><param name="major">The major version number of the type library. </param><param name="minor">The minor version number of the type library. </param>
        public TypeLibVersionAttribute(int major, int minor)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
