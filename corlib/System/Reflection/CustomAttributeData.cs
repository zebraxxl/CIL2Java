using System.Runtime.InteropServices;
using System;
using System.Collections.Generic;

namespace System.Reflection
{
    /// <summary>Provides access to custom attribute data for assemblies, modules, types, members and parameters that are loaded into the reflection-only context.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    public class CustomAttributeData
    {
    
        /// <summary>Gets the type of the attribute.</summary><returns>The type of the attribute.</returns>
        public Type AttributeType
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a <see cref="T:System.Reflection.ConstructorInfo" /> object that represents the constructor that would have initialized the custom attribute.</summary><returns>An object that represents the constructor that would have initialized the custom attribute represented by the current instance of the <see cref="T:System.Reflection.CustomAttributeData" /> class.</returns>
        [ComVisibleAttribute(true)]
        public virtual ConstructorInfo Constructor
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the list of positional arguments specified for the attribute instance represented by the <see cref="T:System.Reflection.CustomAttributeData" /> object.</summary><returns>A collection of structures that represent the positional arguments specified for the custom attribute instance.</returns>
        [ComVisibleAttribute(true)]
        public virtual IList<CustomAttributeTypedArgument> ConstructorArguments
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the list of named arguments specified for the attribute instance represented by the <see cref="T:System.Reflection.CustomAttributeData" /> object.</summary><returns>A collection of structures that represent the named arguments specified for the custom attribute instance.</returns>
        public virtual IList<CustomAttributeNamedArgument> NamedArguments
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Returns a list of <see cref="T:System.Reflection.CustomAttributeData" /> objects representing data about the attributes that have been applied to the target member.</summary><returns>A list of objects that represent data about the attributes that have been applied to the target member.</returns><param name="target">The member whose attribute data is to be retrieved.</param><exception cref="T:System.ArgumentNullException"><paramref name="target" /> is null.</exception>
        public static IList<CustomAttributeData> GetCustomAttributes(MemberInfo target)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a list of <see cref="T:System.Reflection.CustomAttributeData" /> objects representing data about the attributes that have been applied to the target module.</summary><returns>A list of objects that represent data about the attributes that have been applied to the target module.</returns><param name="target">The module whose custom attribute data is to be retrieved.</param><exception cref="T:System.ArgumentNullException"><paramref name="target" /> is null.</exception>
        public static IList<CustomAttributeData> GetCustomAttributes(Module target)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a list of <see cref="T:System.Reflection.CustomAttributeData" /> objects representing data about the attributes that have been applied to the target assembly.</summary><returns>A list of objects that represent data about the attributes that have been applied to the target assembly.</returns><param name="target">The assembly whose custom attribute data is to be retrieved.</param><exception cref="T:System.ArgumentNullException"><paramref name="target" /> is null.</exception>
        public static IList<CustomAttributeData> GetCustomAttributes(Assembly target)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a list of <see cref="T:System.Reflection.CustomAttributeData" /> objects representing data about the attributes that have been applied to the target parameter.</summary><returns>A list of objects that represent data about the attributes that have been applied to the target parameter.</returns><param name="target">The parameter whose attribute data is to be retrieved.</param><exception cref="T:System.ArgumentNullException"><paramref name="target" /> is null.</exception>
        public static IList<CustomAttributeData> GetCustomAttributes(ParameterInfo target)
        {
             throw new NotImplementedException();
        }
        
        
        protected CustomAttributeData()
        {
             throw new NotImplementedException();
        }
        
        
        public override string ToString()
        {
             throw new NotImplementedException();
        }
        
        
        public override int GetHashCode()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a value that indicates whether this instance is equal to a specified object.</summary><returns>true if <paramref name="obj" /> is equal to the current instance; otherwise, false.</returns><param name="obj">An object to compare with this instance, or null.</param>
        public override bool Equals(object obj)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
