using System.Runtime.InteropServices;
using System;
using System.Collections;

namespace System.ComponentModel.Design
{
    [ComVisibleAttribute(true)]
    public interface ISelectionService
    {
        event EventHandler SelectionChanged;
    
        event EventHandler SelectionChanging;
    
    
        object PrimarySelection
        {
            get;
        }
    
        int SelectionCount
        {
            get;
        }
    
    
        bool GetComponentSelected(object component);
        
        
        ICollection GetSelectedComponents();
        
        
        void SetSelectedComponents(ICollection components);
        
        
        void SetSelectedComponents(ICollection components, SelectionTypes selectionType);
        
        
    }
}
