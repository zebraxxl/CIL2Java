using System;

namespace System.Runtime.InteropServices
{
    /// <summary>Specifies the class identifier of a coclass imported from a type library.</summary>
    [AttributeUsageAttribute(AttributeTargets.Interface, Inherited = false)]
    [ComVisibleAttribute(true)]
    public sealed class CoClassAttribute : Attribute
    {
    
        /// <summary>Gets the class identifier of the original coclass.</summary><returns>A <see cref="T:System.Type" /> containing the class identifier of the original coclass.</returns>
        public Type CoClass
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes new instance of the <see cref="T:System.Runtime.InteropServices.CoClassAttribute" /> with the class identifier of the original coclass.</summary><param name="coClass">A <see cref="T:System.Type" /> that contains the class identifier of the original coclass. </param>
        public CoClassAttribute(Type coClass)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
