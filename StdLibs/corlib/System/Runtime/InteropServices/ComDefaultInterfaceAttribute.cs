using System;

namespace System.Runtime.InteropServices
{
    /// <summary>Specifies a default interface to expose to COM. This class cannot be inherited.</summary>
    [AttributeUsageAttribute(AttributeTargets.Class, Inherited = false)]
    [ComVisibleAttribute(true)]
    public sealed class ComDefaultInterfaceAttribute : Attribute
    {
    
        /// <summary>Gets the <see cref="T:System.Type" /> object that specifies the default interface to expose to COM.</summary><returns>The <see cref="T:System.Type" /> object that specifies the default interface to expose to COM.</returns>
        public Type Value
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Runtime.InteropServices.ComDefaultInterfaceAttribute" /> class with the specified <see cref="T:System.Type" /> object as the default interface exposed to COM.</summary><param name="defaultInterface">A <see cref="T:System.Type" /> value indicating the default interface to expose to COM. </param>
        public ComDefaultInterfaceAttribute(Type defaultInterface)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
