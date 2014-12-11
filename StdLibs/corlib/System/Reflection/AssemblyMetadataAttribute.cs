using System;

namespace System.Reflection
{
    /// <summary>Defines a key/value metadata pair for the decorated assembly.</summary>
    [AttributeUsageAttribute(AttributeTargets.Assembly, AllowMultiple = true, Inherited = false)]
    public sealed class AssemblyMetadataAttribute : Attribute
    {
    
        /// <summary>Gets the metadata key.</summary><returns>The metadata key.</returns>
        public string Key
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the metadata value.</summary><returns>The metadata value.</returns>
        public string Value
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Reflection.AssemblyMetadataAttribute" /> class by using the specified metadata key and value.</summary><param name="key">The metadata key.</param><param name="value">The metadata value.</param>
        public AssemblyMetadataAttribute(string key, string value)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
