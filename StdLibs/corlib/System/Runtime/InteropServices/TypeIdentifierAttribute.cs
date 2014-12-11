using System;

namespace System.Runtime.InteropServices
{
    /// <summary>Provides support for type equivalence.</summary>
    [AttributeUsageAttribute(AttributeTargets.Struct|AttributeTargets.Enum|AttributeTargets.Interface|AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
    [ComVisibleAttribute(false)]
    public sealed class TypeIdentifierAttribute : Attribute
    {
    
        /// <summary>Gets the value of the <paramref name="scope" /> parameter that was passed to the <see cref="M:System.Runtime.InteropServices.TypeIdentifierAttribute.#ctor(System.String,System.String)" /> constructor.</summary><returns>The value of the constructor's <paramref name="scope" /> parameter.</returns>
        public string Scope
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the value of the <paramref name="identifier" /> parameter that was passed to the <see cref="M:System.Runtime.InteropServices.TypeIdentifierAttribute.#ctor(System.String,System.String)" /> constructor.</summary><returns>The value of the constructor's <paramref name="identifier" /> parameter.</returns>
        public string Identifier
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public TypeIdentifierAttribute()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates a new instance of the <see cref="T:System.Runtime.InteropServices.TypeIdentifierAttribute" /> class with the specified scope and identifier. </summary><param name="scope">The first type equivalence string.</param><param name="identifier">The second type equivalence string.</param>
        public TypeIdentifierAttribute(string scope, string identifier)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
