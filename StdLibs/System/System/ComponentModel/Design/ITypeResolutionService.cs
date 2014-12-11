using System.Reflection;
using System;

namespace System.ComponentModel.Design
{
    public interface ITypeResolutionService
    {
        Assembly GetAssembly(AssemblyName name);
        
        
        Assembly GetAssembly(AssemblyName name, bool throwOnError);
        
        
        Type GetType(string name);
        
        
        Type GetType(string name, bool throwOnError);
        
        
        Type GetType(string name, bool throwOnError, bool ignoreCase);
        
        
        void ReferenceAssembly(AssemblyName name);
        
        
        string GetPathOfAssembly(AssemblyName name);
        
        
    }
}
