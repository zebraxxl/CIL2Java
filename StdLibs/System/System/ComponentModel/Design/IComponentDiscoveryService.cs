using System.Collections;
using System;

namespace System.ComponentModel.Design
{
    public interface IComponentDiscoveryService
    {
        ICollection GetComponentTypes(IDesignerHost designerHost, Type baseType);
        
        
    }
}
