using System;

namespace System.Runtime.InteropServices
{
    /// <summary>Allows the user to specify the ProgID of a class.</summary>
    [ComVisibleAttribute(true)]
    [AttributeUsageAttribute(AttributeTargets.Class, Inherited = false)]
    public sealed class ProgIdAttribute : Attribute
    {
    
        /// <summary>Gets the ProgID of the class.</summary><returns>The ProgID of the class.</returns>
        public string Value
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the ProgIdAttribute with the specified ProgID.</summary><param name="progId">The ProgID to be assigned to the class. </param>
        public ProgIdAttribute(string progId)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
