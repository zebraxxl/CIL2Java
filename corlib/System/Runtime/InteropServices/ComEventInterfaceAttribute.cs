using System;

namespace System.Runtime.InteropServices
{
    /// <summary>Identifies the source interface and the class that implements the methods of the event interface that is generated when a coclass is imported from a COM type library.</summary>
    [AttributeUsageAttribute(AttributeTargets.Interface, Inherited = false)]
    [ComVisibleAttribute(true)]
    public sealed class ComEventInterfaceAttribute : Attribute
    {
    
        /// <summary>Gets the original source interface from the type library.</summary><returns>A <see cref="T:System.Type" /> containing the source interface.</returns>
        public Type SourceInterface
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the class that implements the methods of the event interface.</summary><returns>A <see cref="T:System.Type" /> that contains the class that implements the methods of the event interface.</returns>
        public Type EventProvider
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Runtime.InteropServices.ComEventInterfaceAttribute" /> class with the source interface and event provider class.</summary><param name="SourceInterface">A <see cref="T:System.Type" /> that contains the original source interface from the type library. COM uses this interface to call back to the managed class. </param><param name="EventProvider">A <see cref="T:System.Type" /> that contains the class that implements the methods of the event interface. </param>
        public ComEventInterfaceAttribute(Type SourceInterface, Type EventProvider)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
