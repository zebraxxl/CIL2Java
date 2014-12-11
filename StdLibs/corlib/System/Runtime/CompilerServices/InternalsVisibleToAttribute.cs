using System;

namespace System.Runtime.CompilerServices
{
    /// <summary>Specifies that types that are ordinarily visible only within the current assembly are visible to a specified assembly.</summary>
    [AttributeUsageAttribute(AttributeTargets.Assembly, AllowMultiple = true, Inherited = false)]
    public sealed class InternalsVisibleToAttribute : Attribute
    {
    
        /// <summary>Gets the name of the friend assembly to which all types and type members that are marked with the internal keyword are to be made visible. </summary><returns>A string that represents the name of the friend assembly.</returns>
        public string AssemblyName
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>This property is not implemented.</summary><returns>This property does not return a value.</returns>
        public bool AllInternalsVisible
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Runtime.CompilerServices.InternalsVisibleToAttribute" /> class with the name of the specified friend assembly. </summary><param name="assemblyName">The name of a friend assembly.</param>
        public InternalsVisibleToAttribute(string assemblyName)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
