using System.Runtime.InteropServices;
using System;

namespace System.Reflection
{
    /// <summary>Defines a copyright custom attribute for an assembly manifest.</summary>
    [ComVisibleAttribute(true)]
    [AttributeUsageAttribute(AttributeTargets.Assembly, Inherited = false)]
    public sealed class AssemblyCopyrightAttribute : Attribute
    {
    
        /// <summary>Gets copyright information.</summary><returns>A string containing the copyright information.</returns>
        public string Copyright
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Reflection.AssemblyCopyrightAttribute" /> class.</summary><param name="copyright">The copyright information. </param>
        public AssemblyCopyrightAttribute(string copyright)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
