using System;

namespace System.Runtime.CompilerServices
{
    /// <summary>Provides a hint to the common language runtime (CLR) indicating how likely a dependency is to be loaded. This class is used in a dependent assembly to indicate what hint should be used when the parent does not specify the <see cref="T:System.Runtime.CompilerServices.DependencyAttribute" /> attribute.  This class cannot be inherited. </summary>
    [Serializable]
    [AttributeUsageAttribute(AttributeTargets.Assembly)]
    public sealed class DefaultDependencyAttribute : Attribute
    {
    
        /// <summary>Gets the <see cref="T:System.Runtime.CompilerServices.LoadHint" /> value that indicates when an assembly loads a dependency.</summary><returns>One of the <see cref="T:System.Runtime.CompilerServices.LoadHint" /> values.</returns>
        public LoadHint LoadHint
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Runtime.CompilerServices.DefaultDependencyAttribute" /> class with the specified <see cref="T:System.Runtime.CompilerServices.LoadHint" /> binding. </summary><param name="loadHintArgument">One of the <see cref="T:System.Runtime.CompilerServices.LoadHint" /> values that indicates the default binding preference.</param>
        public DefaultDependencyAttribute(LoadHint loadHintArgument)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
