using System.Runtime.InteropServices;
using System;
using System.Runtime.CompilerServices;
using System.Collections.Generic;

namespace System.Reflection
{
    /// <summary>Represents type declarations for class types, interface types, array types, value types, enumeration types, type parameters, generic type definitions, and open or closed constructed generic types. </summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    public abstract class TypeInfo : Type, IReflectableType
    {
        /// <summary>Gets an array of the generic parameters of the current type.</summary><returns>An array that contains the current type's generic parameters.</returns>
        public virtual Type[] GenericTypeParameters
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a collection of the constructors declared by the current type.</summary><returns>A collection of the constructors declared by the current type.</returns>
        public virtual IEnumerable<ConstructorInfo> DeclaredConstructors
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a collection of the events defined by the current type.</summary><returns>A collection of the events defined by the current type.</returns>
        public virtual IEnumerable<EventInfo> DeclaredEvents
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a collection of the fields defined by the current type.</summary><returns>A collection of the fields defined by the current type.</returns>
        public virtual IEnumerable<FieldInfo> DeclaredFields
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a collection of the members defined by the current type.</summary><returns>A collection of the members defined by the current type.</returns>
        public virtual IEnumerable<MemberInfo> DeclaredMembers
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a collection of the methods defined by the current type.</summary><returns>A collection of the methods defined by the current type.</returns>
        public virtual IEnumerable<MethodInfo> DeclaredMethods
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a collection of the nested types defined by the current type.</summary><returns>A collection of nested types defined by the current type.</returns>
        public virtual IEnumerable<TypeInfo> DeclaredNestedTypes
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a collection of the properties defined by the current type. </summary><returns>A collection of the properties defined by the current type.</returns>
        public virtual IEnumerable<PropertyInfo> DeclaredProperties
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a collection of the interfaces implemented by the current type.</summary><returns>A collection of the interfaces implemented by the current type.</returns>
        public virtual IEnumerable<Type> ImplementedInterfaces
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public virtual Type AsType()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a value that indicates whether the specified type can be assigned to the current type.</summary><returns>true if the specified type can be assigned to this type; otherwise, false.</returns><param name="typeInfo">The type to check.</param>
        public virtual bool IsAssignableFrom(TypeInfo typeInfo)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns an object that represents the specified public event declared by the current type.</summary><returns>An object that represents the specified event, if found; otherwise, null.</returns><param name="name">The name of the event.</param><exception cref="T:System.ArgumentNullException"><paramref name="name" /> is null. </exception>
        public virtual EventInfo GetDeclaredEvent(string name)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns an object that represents the specified public field declared by the current type.</summary><returns>An object that represents the specified field, if found; otherwise, null.</returns><param name="name">The name of the field.</param><exception cref="T:System.ArgumentNullException"><paramref name="name" /> is null. </exception>
        public virtual FieldInfo GetDeclaredField(string name)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns an object that represents the specified public method declared by the current type.</summary><returns>An object that represents the specified method, if found; otherwise, null.</returns><param name="name">The name of the method.</param><exception cref="T:System.ArgumentNullException"><paramref name="name" /> is null. </exception>
        public virtual MethodInfo GetDeclaredMethod(string name)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a collection that contains all public methods declared on the current type that match the specified name.</summary><returns>A collection that contains methods that match <paramref name="name" />.</returns><param name="name">The method name to search for.</param><exception cref="T:System.ArgumentNullException"><paramref name="name" /> is null. </exception>
        public virtual IEnumerable<MethodInfo> GetDeclaredMethods(string name)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns an object that represents the specified public nested type declared by the current type.</summary><returns>An object that represents the specified nested type, if found; otherwise, null.</returns><param name="name">The name of the nested type.</param><exception cref="T:System.ArgumentNullException"><paramref name="name" /> is null. </exception>
        public virtual TypeInfo GetDeclaredNestedType(string name)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns an object that represents the specified public property declared by the current type.</summary><returns>An object that represents the specified property, if found; otherwise, null.</returns><param name="name">The name of the property.</param><exception cref="T:System.ArgumentNullException"><paramref name="name" /> is null. </exception>
        public virtual PropertyInfo GetDeclaredProperty(string name)
        {
             throw new NotImplementedException();
        }



        TypeInfo IReflectableType.GetTypeInfo()
        {
            throw new NotImplementedException();
        }
    }
}
