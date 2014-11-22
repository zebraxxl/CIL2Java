using System.Security;
using System.Collections.Generic;
using System.Reflection;
using System;

namespace System.Runtime.DesignerServices
{
    /// <summary>Provides customized assembly binding for designers that are used to create Windows Store apps. </summary>
    public sealed class WindowsRuntimeDesignerContext
    {
    
        /// <summary>Gets the name of the designer binding context. </summary><returns>The name of the context. </returns>
        public string Name
        {
            get { throw new NotImplementedException(); }
        }
    
    
        [SecurityCriticalAttribute()]
        public WindowsRuntimeDesignerContext(IEnumerable<string> paths, string name)
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        public static void InitializeSharedContext(IEnumerable<string> paths)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sets a context to handle iterations of assembly binding requests, as assemblies are recompiled during the design process. </summary><param name="context">The context that handles iterations of assembly binding requests. </param><exception cref="T:System.NotSupportedException">The current application domain is not the default application domain. </exception><exception cref="T:System.ArgumentNullException"><paramref name="context" /> is null.</exception>
        [SecurityCriticalAttribute()]
        public static void SetIterationContext(WindowsRuntimeDesignerContext context)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Loads the specified assembly from the current context. </summary><returns>The assembly, if it is found in the current context; otherwise, null. </returns><param name="assemblyName">The full name of the assembly to load. For a description of full assembly names, see the <see cref="P:System.Reflection.Assembly.FullName" /> property. </param>
        [SecurityCriticalAttribute()]
        public Assembly GetAssembly(string assemblyName)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Loads the specified type from the current context. </summary><returns>The type, if it is found in the current context; otherwise, null. </returns><param name="typeName">The assembly-qualified name of the type to load. For a description of assembly-qualified names, see the <see cref="P:System.Type.AssemblyQualifiedName" /> property. </param>
        [SecurityCriticalAttribute()]
        public Type GetType(string typeName)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
