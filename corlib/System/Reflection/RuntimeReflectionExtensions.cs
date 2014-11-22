using System.Collections.Generic;
using System;

namespace System.Reflection
{
    /// <summary>Provides methods that retrieve information about types at run time.</summary>
    public static class RuntimeReflectionExtensions
    {
    
        /// <summary>Retrieves a collection that represents all the properties defined on a specified type.</summary><returns>A collection of properties for the specified type.</returns><param name="type">The type that contains the properties.</param>
        public static IEnumerable<PropertyInfo> GetRuntimeProperties(this Type type)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Retrieves a collection that represents all the events defined on a specified type.</summary><returns>A collection of events for the specified type.</returns><param name="type">The type that contains the events.</param>
        public static IEnumerable<EventInfo> GetRuntimeEvents(this Type type)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Retrieves a collection that represents all methods defined on a specified type.</summary><returns>A collection of methods for the specified type.</returns><param name="type">The type that contains the methods.</param>
        public static IEnumerable<MethodInfo> GetRuntimeMethods(this Type type)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Retrieves a collection that represents all the fields defined on a specified type.</summary><returns>A collection of fields for the specified type.</returns><param name="type">The type that contains the fields.</param>
        public static IEnumerable<FieldInfo> GetRuntimeFields(this Type type)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Retrieves an object that represents a specified property.</summary><returns>An object that represents the specified property, or null if the property is not found.</returns><param name="type">The type that contains the property.</param><param name="name">The name of the property.</param>
        public static PropertyInfo GetRuntimeProperty(this Type type, string name)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Retrieves an object that represents the specified event.</summary><returns>An object that represents the specified event, or null if the event is not found.</returns><param name="type">The type that contains the event.</param><param name="name">The name of the event.</param>
        public static EventInfo GetRuntimeEvent(this Type type, string name)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Retrieves an object that represents a specified method.</summary><returns>An object that represents the specified method, or null if the method is not found.</returns><param name="type">The type that contains the method.</param><param name="name">The name of the method.</param><param name="parameters">An array that contains the method's parameters.</param>
        public static MethodInfo GetRuntimeMethod(this Type type, string name, Type[] parameters)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Retrieves an object that represents a specified field.</summary><returns>An object that represents the specified field, or null if the field is not found.</returns><param name="type">The type that contains the field.</param><param name="name">The name of the field.</param>
        public static FieldInfo GetRuntimeField(this Type type, string name)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Retrieves an object that represents the specified method on the direct or indirect base class where the method was first declared.</summary><returns>An object that represents the specified method's initial declaration on a base class.</returns><param name="method">The method to retrieve information about.</param>
        public static MethodInfo GetRuntimeBaseDefinition(this MethodInfo method)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns an interface mapping for the specified type and the specified interface.</summary><returns>An object that represents the interface mapping for the specified interface and type.</returns><param name="typeInfo">The type to retrieve a mapping for.</param><param name="interfaceType">The interface to retrieve a mapping for.</param>
        public static InterfaceMapping GetRuntimeInterfaceMap(this TypeInfo typeInfo, Type interfaceType)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Gets an object that represents the method represented by the specified delegate.</summary><returns>An object that represents the method.</returns><param name="del">The delegate to examine.</param>
        public static MethodInfo GetMethodInfo(this Delegate del)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
