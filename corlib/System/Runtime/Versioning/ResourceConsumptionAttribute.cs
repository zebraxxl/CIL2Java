using System;
using System.Diagnostics;

namespace System.Runtime.Versioning
{
    /// <summary>Specifies the resource consumed by the member of a class. This class cannot be inherited.</summary>
    [AttributeUsageAttribute(AttributeTargets.Constructor|AttributeTargets.Method|AttributeTargets.Property, Inherited = false)]
    [ConditionalAttribute("RESOURCE_ANNOTATION_WORK")]
    public sealed class ResourceConsumptionAttribute : Attribute
    {
    
        /// <summary>Gets the resource scope for the consumed resource.</summary><returns>A <see cref="T:System.Runtime.Versioning.ResourceScope" /> object specifying the resource scope of the consumed member.</returns>
        public ResourceScope ResourceScope
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the consumption scope for this member.</summary><returns>A <see cref="T:System.Runtime.Versioning.ResourceScope" /> object specifying the resource scope used by this member.</returns>
        public ResourceScope ConsumptionScope
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Runtime.Versioning.ResourceConsumptionAttribute" /> class specifying the scope of the consumed resource. </summary><param name="resourceScope">The <see cref="T:System.Runtime.Versioning.ResourceScope" /> for the consumed resource.</param>
        public ResourceConsumptionAttribute(ResourceScope resourceScope)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Runtime.Versioning.ResourceConsumptionAttribute" /> class specifying the scope of the consumed resource and the scope of how it is consumed.</summary><param name="resourceScope">The <see cref="T:System.Runtime.Versioning.ResourceScope" /> for the consumed resource.</param><param name="consumptionScope">The <see cref="T:System.Runtime.Versioning.ResourceScope" /> used by this member.</param>
        public ResourceConsumptionAttribute(ResourceScope resourceScope, ResourceScope consumptionScope)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
