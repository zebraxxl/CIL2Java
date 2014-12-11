using System.ComponentModel;
using System;

namespace System.ComponentModel.Design
{
    public interface IReferenceService
    {
        IComponent GetComponent(object reference);
        
        
        object GetReference(string name);
        
        
        string GetName(object reference);
        
        
        object[] GetReferences();
        
        
        object[] GetReferences(Type baseType);
        
        
    }
}
