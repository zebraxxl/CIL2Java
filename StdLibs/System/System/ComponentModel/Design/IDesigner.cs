using System.Runtime.InteropServices;
using System;
using System.ComponentModel;

namespace System.ComponentModel.Design
{
    [ComVisibleAttribute(true)]
    public interface IDesigner : IDisposable
    {
        IComponent Component
        {
            get;
        }
    
        DesignerVerbCollection Verbs
        {
            get;
        }
    
    
        void DoDefaultAction();
        
        
        void Initialize(IComponent component);
        
        
    }
}
