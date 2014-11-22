using System;

namespace System.Runtime
{
    /// <summary>Specifies patch band information for targeted patching of the .NET Framework.</summary>
    [AttributeUsageAttribute(AttributeTargets.Assembly, Inherited = false)]
    public sealed class AssemblyTargetedPatchBandAttribute : Attribute
    {
    
        /// <summary>Gets the patch band. </summary><returns>The patch band information.</returns>
        public string TargetedPatchBand
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Runtime.AssemblyTargetedPatchBandAttribute" /> class.</summary><param name="targetedPatchBand">The patch band.</param>
        public AssemblyTargetedPatchBandAttribute(string targetedPatchBand)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
