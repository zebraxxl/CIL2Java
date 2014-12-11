using System.Runtime.InteropServices;
using System;

namespace System.ComponentModel
{
    [ComVisibleAttribute(true)]
    public interface ISite : IServiceProvider
    {
        IComponent Component
        {
            get;
        }
    
        IContainer Container
        {
            get;
        }
    
        bool DesignMode
        {
            get;
        }
    
        string Name
        {
            get;
            set;
        }
    
    
    }
}
