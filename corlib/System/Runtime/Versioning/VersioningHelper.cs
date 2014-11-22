using System.Security;
using System;

namespace System.Runtime.Versioning
{
    /// <summary>Provides methods to aid developers in writing version-safe code. This class cannot be inherited.</summary>
    public static class VersioningHelper
    {
    
        /// <summary>Returns a version-safe name based on the specified resource name and the intended resource consumption source.</summary><returns>A version-safe name.</returns><param name="name">The name of the resource.</param><param name="from">The scope of the resource.</param><param name="to">The desired resource consumption scope.</param>
        public static string MakeVersionSafeName(string name, ResourceScope from, ResourceScope to)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a version-safe name based on the specified resource name, the intended resource consumption scope, and the type using the resource.</summary><returns>A version-safe name.</returns><param name="name">The name of the resource.</param><param name="from">The beginning of the scope range.</param><param name="to">The end of the scope range.</param><param name="type">The <see cref="T:System.Type" /> of the resource.</param><exception cref="T:System.ArgumentException">The values for <paramref name="from " />and <paramref name="to " />are invalid. The resource type in the <see cref="T:System.Runtime.Versioning.ResourceScope" />  enumeration is going from a more restrictive resource type to a more general resource type.</exception><exception cref="T:System.ArgumentNullException"><paramref name="type " />is null.</exception>
        [SecuritySafeCriticalAttribute()]
        public static string MakeVersionSafeName(string name, ResourceScope from, ResourceScope to, Type type)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
