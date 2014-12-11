using System.Runtime.InteropServices;
using System;

namespace System.ComponentModel
{
    [ComVisibleAttribute(true)]
    public interface ITypeDescriptorContext : IServiceProvider
    {
        IContainer Container
        {
            get;
        }
    
        object Instance
        {
            get;
        }
    
        PropertyDescriptor PropertyDescriptor
        {
            get;
        }
    
    
        bool OnComponentChanging();
        
        
        void OnComponentChanged();
        
        
    }
}
