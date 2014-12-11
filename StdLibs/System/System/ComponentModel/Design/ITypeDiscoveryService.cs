using System.Collections;
using System;

namespace System.ComponentModel.Design
{
    public interface ITypeDiscoveryService
    {
        ICollection GetTypes(Type baseType, bool excludeGlobalTypes);
        
        
    }
}
