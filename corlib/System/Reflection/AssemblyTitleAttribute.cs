using System;
using System.Runtime.InteropServices;

namespace System.Reflection
{
    /// <summary>Specifies a description for an assembly.</summary>
    [AttributeUsageAttribute(AttributeTargets.Assembly, Inherited = false)]
    [ComVisibleAttribute(true)]
    public sealed class AssemblyTitleAttribute : Attribute
    {
    
        /// <summary>Gets assembly title information.</summary><returns>The assembly title. </returns>
        public string Title
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Reflection.AssemblyTitleAttribute" /> class.</summary><param name="title">The assembly title. </param>
        public AssemblyTitleAttribute(string title)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
