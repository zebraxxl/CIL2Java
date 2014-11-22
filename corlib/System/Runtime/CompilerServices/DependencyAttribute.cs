using System;

namespace System.Runtime.CompilerServices
{
    /// <summary>Indicates when a dependency is to be loaded by the referring assembly. This class cannot be inherited. </summary>
    [Serializable]
    [AttributeUsageAttribute(AttributeTargets.Assembly, AllowMultiple = true)]
    public sealed class DependencyAttribute : Attribute
    {
    
        /// <summary>Gets the value of the dependent assembly. </summary><returns>The name of the dependent assembly.</returns>
        public string DependentAssembly
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the <see cref="T:System.Runtime.CompilerServices.LoadHint" /> value that indicates when an assembly is to load a dependency. </summary><returns>One of the <see cref="T:System.Runtime.CompilerServices.LoadHint" /> values.</returns>
        public LoadHint LoadHint
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Runtime.CompilerServices.DependencyAttribute" /> class with the specified <see cref="T:System.Runtime.CompilerServices.LoadHint" /> value. </summary><param name="dependentAssemblyArgument">The dependent assembly to bind to.</param><param name="loadHintArgument">One of the <see cref="T:System.Runtime.CompilerServices.LoadHint" /> values.</param>
        public DependencyAttribute(string dependentAssemblyArgument, LoadHint loadHintArgument)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
