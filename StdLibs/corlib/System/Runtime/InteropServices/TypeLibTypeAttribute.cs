using System;

namespace System.Runtime.InteropServices
{
    /// <summary>Contains the <see cref="T:System.Runtime.InteropServices.TYPEFLAGS" /> that were originally imported for this type from the COM type library.</summary>
    [AttributeUsageAttribute(AttributeTargets.Class|AttributeTargets.Struct|AttributeTargets.Enum|AttributeTargets.Interface, Inherited = false)]
    [ComVisibleAttribute(true)]
    public sealed class TypeLibTypeAttribute : Attribute
    {
    
        /// <summary>Gets the <see cref="T:System.Runtime.InteropServices.TypeLibTypeFlags" /> value for this type.</summary><returns>The <see cref="T:System.Runtime.InteropServices.TypeLibTypeFlags" /> value for this type.</returns>
        public TypeLibTypeFlags Value
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the TypeLibTypeAttribute class with the specified <see cref="T:System.Runtime.InteropServices.TypeLibTypeFlags" /> value.</summary><param name="flags">The <see cref="T:System.Runtime.InteropServices.TypeLibTypeFlags" /> value for the attributed type as found in the type library it was imported from. </param>
        public TypeLibTypeAttribute(TypeLibTypeFlags flags)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the TypeLibTypeAttribute class with the specified <see cref="T:System.Runtime.InteropServices.TypeLibTypeFlags" /> value.</summary><param name="flags">The <see cref="T:System.Runtime.InteropServices.TypeLibTypeFlags" /> value for the attributed type as found in the type library it was imported from. </param>
        public TypeLibTypeAttribute(short flags)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
