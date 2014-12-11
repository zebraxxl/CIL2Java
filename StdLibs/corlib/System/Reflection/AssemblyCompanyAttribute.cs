using System.Runtime.InteropServices;
using System;

namespace System.Reflection
{
    /// <summary>Defines a company name custom attribute for an assembly manifest.</summary>
    [ComVisibleAttribute(true)]
    [AttributeUsageAttribute(AttributeTargets.Assembly, Inherited = false)]
    public sealed class AssemblyCompanyAttribute : Attribute
    {
    
        /// <summary>Gets company name information.</summary><returns>A string containing the company name.</returns>
        public string Company
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Reflection.AssemblyCompanyAttribute" /> class.</summary><param name="company">The company name information. </param>
        public AssemblyCompanyAttribute(string company)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
