using System.Runtime.InteropServices;
using System.Reflection;
using System;
using System.Globalization;

namespace System.Reflection.Emit
{
    /// <summary>Defines and creates generic type parameters for dynamically defined generic types and methods. This class cannot be inherited. </summary>
    [ComVisibleAttribute(true)]
    public sealed class GenericTypeParameterBuilder : TypeInfo
    {
    
        /// <summary>Gets the generic type definition or generic method definition to which the generic type parameter belongs.</summary><returns>If the type parameter belongs to a generic type, a <see cref="T:System.Type" /> object representing that generic type; if the type parameter belongs to a generic method, a <see cref="T:System.Type" /> object representing that type that declared that generic method.</returns>
        public override Type DeclaringType
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the <see cref="T:System.Type" /> object that was used to obtain the <see cref="T:System.Reflection.Emit.GenericTypeParameterBuilder" />.</summary><returns>The <see cref="T:System.Type" /> object that was used to obtain the <see cref="T:System.Reflection.Emit.GenericTypeParameterBuilder" />.</returns>
        public override Type ReflectedType
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the name of the generic type parameter.</summary><returns>The name of the generic type parameter.</returns>
        public override string Name
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the dynamic module that contains the generic type parameter.</summary><returns>A <see cref="T:System.Reflection.Module" /> object that represents the dynamic module that contains the generic type parameter.</returns>
        public override Module Module
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Not supported for incomplete generic type parameters.</summary><returns>Not supported for incomplete generic type parameters.</returns><exception cref="T:System.NotSupportedException">In all cases. </exception>
        public override Guid GUID
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets an <see cref="T:System.Reflection.Assembly" /> object representing the dynamic assembly that contains the generic type definition the current type parameter belongs to.</summary><returns>An <see cref="T:System.Reflection.Assembly" /> object representing the dynamic assembly that contains the generic type definition the current type parameter belongs to.</returns>
        public override Assembly Assembly
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Not supported for incomplete generic type parameters.</summary><returns>Not supported for incomplete generic type parameters.</returns><exception cref="T:System.NotSupportedException">In all cases.</exception>
        public override RuntimeTypeHandle TypeHandle
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets null in all cases.</summary><returns>A null reference (Nothing in Visual Basic) in all cases.</returns>
        public override string FullName
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets null in all cases.</summary><returns>A null reference (Nothing in Visual Basic) in all cases.</returns>
        public override string Namespace
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets null in all cases.</summary><returns>A null reference (Nothing in Visual Basic) in all cases.</returns>
        public override string AssemblyQualifiedName
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the base type constraint of the current generic type parameter.</summary><returns>A <see cref="T:System.Type" /> object that represents the base type constraint of the generic type parameter, or null if the type parameter has no base type constraint.</returns>
        public override Type BaseType
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the current generic type parameter.</summary><returns>The current <see cref="T:System.Reflection.Emit.GenericTypeParameterBuilder" /> object.</returns>
        public override Type UnderlyingSystemType
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets false in all cases.</summary><returns>false in all cases.</returns>
        public override bool IsGenericTypeDefinition
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Returns false in all cases.</summary><returns>false in all cases.</returns>
        public override bool IsGenericType
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets true in all cases.</summary><returns>true in all cases.</returns>
        public override bool IsGenericParameter
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value that indicates whether this object represents a constructed generic type.</summary><returns>true if this object represents a constructed generic type; otherwise, false.</returns>
        public override bool IsConstructedGenericType
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the position of the type parameter in the type parameter list of the generic type or method that declared the parameter.</summary><returns>The position of the type parameter in the type parameter list of the generic type or method that declared the parameter.</returns>
        public override int GenericParameterPosition
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets true in all cases.</summary><returns>true in all cases.</returns>
        public override bool ContainsGenericParameters
        {
            get { throw new NotImplementedException(); }
        }
    
        /// 
        public override GenericParameterAttributes GenericParameterAttributes
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a <see cref="T:System.Reflection.MethodInfo" /> that represents the declaring method, if the current <see cref="T:System.Reflection.Emit.GenericTypeParameterBuilder" /> represents a type parameter of a generic method.</summary><returns>A <see cref="T:System.Reflection.MethodInfo" /> that represents the declaring method, if the current <see cref="T:System.Reflection.Emit.GenericTypeParameterBuilder" /> represents a type parameter of a generic method; otherwise, null.</returns>
        public override MethodBase DeclaringMethod
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Throws a <see cref="T:System.NotSupportedException" /> exception in all cases.</summary><returns>Throws a <see cref="T:System.NotSupportedException" /> exception in all cases.</returns><param name="typeInfo">The object to test.</param><exception cref="T:System.NotSupportedException">In all cases.</exception>
        public override bool IsAssignableFrom(TypeInfo typeInfo)
        {
             throw new NotImplementedException();
        }
        
        
        public override string ToString()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Tests whether the given object is an instance of EventToken and is equal to the current instance.</summary><returns>Returns true if <paramref name="o" /> is an instance of EventToken and equals the current instance; otherwise, false.</returns><param name="o">The object to be compared with the current instance.</param>
        public override bool Equals(object o)
        {
             throw new NotImplementedException();
        }
        
        
        public override int GetHashCode()
        {
             throw new NotImplementedException();
        }
        
        
        public override Type MakePointerType()
        {
             throw new NotImplementedException();
        }
        
        
        public override Type MakeByRefType()
        {
             throw new NotImplementedException();
        }
        
        
        public override Type MakeArrayType()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the type of an array whose element type is the generic type parameter, with the specified number of dimensions.</summary><returns>A <see cref="T:System.Type" /> object that represents the type of an array whose element type is the generic type parameter, with the specified number of dimensions.</returns><param name="rank">The number of dimensions for the array.</param><exception cref="T:System.IndexOutOfRangeException"><paramref name="rank" /> is not a valid number of dimensions. For example, its value is less than 1.</exception>
        public override Type MakeArrayType(int rank)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Not supported for incomplete generic type parameters.</summary><returns>Not supported for incomplete generic type parameters.</returns><param name="name">Not supported. </param><param name="invokeAttr">Not supported.</param><param name="binder">Not supported.</param><param name="target">Not supported.</param><param name="args">Not supported.</param><param name="modifiers">Not supported.</param><param name="culture">Not supported.</param><param name="namedParameters">Not supported.</param><exception cref="T:System.NotSupportedException">In all cases.</exception>
        public override object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParameters)
        {
             throw new NotImplementedException();
        }
        
        
        protected override ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Not supported for incomplete generic type parameters.</summary><returns>Not supported for incomplete generic type parameters.</returns><param name="bindingAttr">Not supported.</param><exception cref="T:System.NotSupportedException">In all cases. </exception>
        [ComVisibleAttribute(true)]
        public override ConstructorInfo[] GetConstructors(BindingFlags bindingAttr)
        {
             throw new NotImplementedException();
        }
        
        
        protected override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Not supported for incomplete generic type parameters.</summary><returns>Not supported for incomplete generic type parameters.</returns><param name="bindingAttr">Not supported.</param><exception cref="T:System.NotSupportedException">In all cases.</exception>
        public override MethodInfo[] GetMethods(BindingFlags bindingAttr)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Not supported for incomplete generic type parameters.</summary><returns>Not supported for incomplete generic type parameters.</returns><param name="name">Not supported.</param><param name="bindingAttr">Not supported.</param><exception cref="T:System.NotSupportedException">In all cases.</exception>
        public override FieldInfo GetField(string name, BindingFlags bindingAttr)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Not supported for incomplete generic type parameters.</summary><returns>Not supported for incomplete generic type parameters.</returns><param name="bindingAttr">Not supported.</param><exception cref="T:System.NotSupportedException">In all cases.</exception>
        public override FieldInfo[] GetFields(BindingFlags bindingAttr)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Not supported for incomplete generic type parameters.</summary><returns>Not supported for incomplete generic type parameters.</returns><param name="name">The name of the interface.</param><param name="ignoreCase">true to search without regard for case; false to make a case-sensitive search.</param><exception cref="T:System.NotSupportedException">In all cases.</exception>
        public override Type GetInterface(string name, bool ignoreCase)
        {
             throw new NotImplementedException();
        }
        
        
        public override Type[] GetInterfaces()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Not supported for incomplete generic type parameters.</summary><returns>Not supported for incomplete generic type parameters.</returns><param name="name">Not supported.</param><param name="bindingAttr">Not supported. </param><exception cref="T:System.NotSupportedException">In all cases.</exception>
        public override EventInfo GetEvent(string name, BindingFlags bindingAttr)
        {
             throw new NotImplementedException();
        }
        
        
        public override EventInfo[] GetEvents()
        {
             throw new NotImplementedException();
        }
        
        
        protected override PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Not supported for incomplete generic type parameters.</summary><returns>Not supported for incomplete generic type parameters.</returns><param name="bindingAttr">Not supported.</param><exception cref="T:System.NotSupportedException">In all cases.</exception>
        public override PropertyInfo[] GetProperties(BindingFlags bindingAttr)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Not supported for incomplete generic type parameters.</summary><returns>Not supported for incomplete generic type parameters.</returns><param name="bindingAttr">Not supported.</param><exception cref="T:System.NotSupportedException">In all cases.</exception>
        public override Type[] GetNestedTypes(BindingFlags bindingAttr)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Not supported for incomplete generic type parameters.</summary><returns>Not supported for incomplete generic type parameters.</returns><param name="name">Not supported.</param><param name="bindingAttr">Not supported.</param><exception cref="T:System.NotSupportedException">In all cases.</exception>
        public override Type GetNestedType(string name, BindingFlags bindingAttr)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Not supported for incomplete generic type parameters.</summary><returns>Not supported for incomplete generic type parameters.</returns><param name="name">Not supported.</param><param name="type">Not supported.</param><param name="bindingAttr">Not supported.</param><exception cref="T:System.NotSupportedException">In all cases.</exception>
        public override MemberInfo[] GetMember(string name, MemberTypes type, BindingFlags bindingAttr)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Not supported for incomplete generic type parameters.</summary><returns>Not supported for incomplete generic type parameters.</returns><param name="interfaceType">A <see cref="T:System.Type" /> object that represents the interface type for which the mapping is to be retrieved.</param><exception cref="T:System.NotSupportedException">In all cases.</exception>
        [ComVisibleAttribute(true)]
        public override InterfaceMapping GetInterfaceMap(Type interfaceType)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Not supported for incomplete generic type parameters.</summary><returns>Not supported for incomplete generic type parameters.</returns><param name="bindingAttr">Not supported.</param><exception cref="T:System.NotSupportedException">In all cases.</exception>
        public override EventInfo[] GetEvents(BindingFlags bindingAttr)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Not supported for incomplete generic type parameters.</summary><returns>Not supported for incomplete generic type parameters.</returns><param name="bindingAttr">Not supported.</param><exception cref="T:System.NotSupportedException">In all cases.</exception>
        public override MemberInfo[] GetMembers(BindingFlags bindingAttr)
        {
             throw new NotImplementedException();
        }
        
        
        protected override TypeAttributes GetAttributeFlagsImpl()
        {
             throw new NotImplementedException();
        }
        
        
        protected override bool IsArrayImpl()
        {
             throw new NotImplementedException();
        }
        
        
        protected override bool IsByRefImpl()
        {
             throw new NotImplementedException();
        }
        
        
        protected override bool IsPointerImpl()
        {
             throw new NotImplementedException();
        }
        
        
        protected override bool IsPrimitiveImpl()
        {
             throw new NotImplementedException();
        }
        
        
        protected override bool IsCOMObjectImpl()
        {
             throw new NotImplementedException();
        }
        
        
        public override Type GetElementType()
        {
             throw new NotImplementedException();
        }
        
        
        protected override bool HasElementTypeImpl()
        {
             throw new NotImplementedException();
        }
        
        
        public override Type[] GetGenericArguments()
        {
             throw new NotImplementedException();
        }
        
        
        public override Type GetGenericTypeDefinition()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Not valid for incomplete generic type parameters.</summary><returns>This method is invalid for incomplete generic type parameters.</returns><param name="typeArguments">An array of type arguments.</param><exception cref="T:System.InvalidOperationException">In all cases.</exception>
        public override Type MakeGenericType(params  Type[] typeArguments)
        {
             throw new NotImplementedException();
        }
        
        
        protected override bool IsValueTypeImpl()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Throws a <see cref="T:System.NotSupportedException" /> exception in all cases.</summary><returns>Throws a <see cref="T:System.NotSupportedException" /> exception in all cases.</returns><param name="c">The object to test.</param><exception cref="T:System.NotSupportedException">In all cases.</exception>
        public override bool IsAssignableFrom(Type c)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Not supported for incomplete generic type parameters.</summary><returns>Not supported for incomplete generic type parameters.</returns><param name="c">Not supported.</param><exception cref="T:System.NotSupportedException">In all cases.</exception>
        [ComVisibleAttribute(true)]
        public override bool IsSubclassOf(Type c)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Not supported for incomplete generic type parameters.</summary><returns>Not supported for incomplete generic type parameters.</returns><param name="inherit">Specifies whether to search this member's inheritance chain to find the attributes.</param><exception cref="T:System.NotSupportedException">In all cases.</exception>
        public override object[] GetCustomAttributes(bool inherit)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Not supported for incomplete generic type parameters.</summary><returns>Not supported for incomplete generic type parameters.</returns><param name="attributeType">The type of attribute to search for. Only attributes that are assignable to this type are returned.</param><param name="inherit">Specifies whether to search this member's inheritance chain to find the attributes.</param><exception cref="T:System.NotSupportedException">In all cases.</exception>
        public override object[] GetCustomAttributes(Type attributeType, bool inherit)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Not supported for incomplete generic type parameters.</summary><returns>Not supported for incomplete generic type parameters.</returns><param name="attributeType">Not supported.</param><param name="inherit">Not supported.</param><exception cref="T:System.NotSupportedException">In all cases.</exception>
        public override bool IsDefined(Type attributeType, bool inherit)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sets a custom attribute using a specified custom attribute blob.</summary><param name="con">The constructor for the custom attribute.</param><param name="binaryAttribute">A byte blob representing the attribute.</param><exception cref="T:System.ArgumentNullException"><paramref name="con" /> is null.-or-<paramref name="binaryAttribute" /> is a null reference.</exception>
        public void SetCustomAttribute(ConstructorInfo con, byte[] binaryAttribute)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Set a custom attribute using a custom attribute builder.</summary><param name="customBuilder">An instance of a helper class that defines the custom attribute.</param><exception cref="T:System.ArgumentNullException"><paramref name="customBuilder" /> is null.</exception>
        public void SetCustomAttribute(CustomAttributeBuilder customBuilder)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sets the base type that a type must inherit in order to be substituted for the type parameter.</summary><param name="baseTypeConstraint">The <see cref="T:System.Type" /> that must be inherited by any type that is to be substituted for the type parameter.</param>
        public void SetBaseTypeConstraint(Type baseTypeConstraint)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sets the interfaces a type must implement in order to be substituted for the type parameter. </summary><param name="interfaceConstraints">An array of <see cref="T:System.Type" /> objects that represent the interfaces a type must implement in order to be substituted for the type parameter.</param>
        [ComVisibleAttribute(true)]
        public void SetInterfaceConstraints(params  Type[] interfaceConstraints)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sets the variance characteristics and special constraints of the generic parameter, such as the parameterless constructor constraint.</summary><param name="genericParameterAttributes">A bitwise combination of <see cref="T:System.Reflection.GenericParameterAttributes" /> values that represent the variance characteristics and special constraints of the generic type parameter.</param>
        public void SetGenericParameterAttributes(GenericParameterAttributes genericParameterAttributes)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
