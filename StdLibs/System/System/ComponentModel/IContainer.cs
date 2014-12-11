using System.Runtime.InteropServices;
using System;

namespace System.ComponentModel
{
    [ComVisibleAttribute(true)]
    public interface IContainer : IDisposable
    {
        ComponentCollection Components
        {
            get;
        }
    
    
        void Add(IComponent component);
        
        
        void Add(IComponent component, string name);
        
        
        void Remove(IComponent component);
        
        
    }
}
