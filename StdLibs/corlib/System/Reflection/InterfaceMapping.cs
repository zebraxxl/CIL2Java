using System.Runtime.InteropServices;
using System;

namespace System.Reflection
{
    /// <summary>Retrieves the mapping of an interface into the actual methods on a class that implements that interface.</summary>
    [ComVisibleAttribute(true)]
    public struct InterfaceMapping
    {
        /// <summary>Represents the type that was used to create the interface mapping.</summary>
        [ComVisibleAttribute(true)]
        public Type TargetType;
        /// <summary>Shows the type that represents the interface.</summary>
        [ComVisibleAttribute(true)]
        public Type InterfaceType;
        /// <summary>Shows the methods that implement the interface.</summary>
        [ComVisibleAttribute(true)]
        public MethodInfo[] TargetMethods;
        /// <summary>Shows the methods that are defined on the interface.</summary>
        [ComVisibleAttribute(true)]
        public MethodInfo[] InterfaceMethods;
    
    }
}
