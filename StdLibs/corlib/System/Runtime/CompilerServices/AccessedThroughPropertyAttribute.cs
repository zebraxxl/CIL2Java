using System.Runtime.InteropServices;
using System;

namespace System.Runtime.CompilerServices
{
    /// <summary>Specifies the name of the property that accesses the attributed field.</summary>
    [ComVisibleAttribute(true)]
    [AttributeUsageAttribute(AttributeTargets.Field)]
    public sealed class AccessedThroughPropertyAttribute : Attribute
    {
    
        /// <summary>Gets the name of the property used to access the attributed field.</summary><returns>The name of the property used to access the attributed field.</returns>
        public string PropertyName
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the AccessedThroughPropertyAttribute class with the name of the property used to access the attributed field.</summary><param name="propertyName">The name of the property used to access the attributed field. </param>
        public AccessedThroughPropertyAttribute(string propertyName)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
