using System.Runtime.InteropServices;

namespace System.Reflection
{
    /// <summary>Provides access to manifest resources, which are XML files that describe application dependencies.  </summary>
    [ComVisibleAttribute(true)]
    public class ManifestResourceInfo
    {
    
        /// <summary>Gets the containing assembly for the manifest resource. </summary><returns>The manifest resource's containing assembly.</returns>
        public virtual Assembly ReferencedAssembly
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the name of the file that contains the manifest resource, if it is not the same as the manifest file.  </summary><returns>The manifest resource's file name.</returns>
        public virtual string FileName
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the manifest resource's location. </summary><returns>A bitwise combination of <see cref="T:System.Reflection.ResourceLocation" /> flags that indicates the location of the manifest resource. </returns>
        public virtual ResourceLocation ResourceLocation
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Reflection.ManifestResourceInfo" /> class for a resource that is contained by the specified assembly and file, and that has the specified location.</summary><param name="containingAssembly">The assembly that contains the manifest resource.</param><param name="containingFileName">The name of the file that contains the manifest resource, if the file is not the same as the manifest file.</param><param name="resourceLocation">A bitwise combination of enumeration values that provides information about the location of the manifest resource. </param>
        public ManifestResourceInfo(Assembly containingAssembly, string containingFileName, ResourceLocation resourceLocation)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
