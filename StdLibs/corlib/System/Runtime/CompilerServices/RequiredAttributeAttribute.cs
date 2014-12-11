using System;
using System.Runtime.InteropServices;

namespace System.Runtime.CompilerServices
{
    /// <summary>Specifies that an importing compiler must fully understand the semantics of a type definition, or refuse to use it.  This class cannot be inherited. </summary>
    [Serializable]
    [AttributeUsageAttribute(AttributeTargets.Class|AttributeTargets.Struct|AttributeTargets.Enum|AttributeTargets.Interface, AllowMultiple = true, Inherited = false)]
    [ComVisibleAttribute(true)]
    public sealed class RequiredAttributeAttribute : Attribute
    {
    
        /// <summary>Gets a type that an importing compiler must fully understand.</summary><returns>A type that an importing compiler must fully understand. </returns>
        public Type RequiredContract
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Runtime.CompilerServices.RequiredAttributeAttribute" /> class.</summary><param name="requiredContract">A type that an importing compiler must fully understand.This parameter is not supported in the .NET Framework version 2.0 and later. </param>
        public RequiredAttributeAttribute(Type requiredContract)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
