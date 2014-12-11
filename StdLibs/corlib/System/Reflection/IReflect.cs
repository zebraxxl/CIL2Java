using System.Runtime.InteropServices;
using System;
using System.Globalization;

namespace System.Reflection
{
    /// <summary>Interoperates with the IDispatch interface.</summary>
    [GuidAttribute("AFBF15E5-C37C-11d2-B88E-00A0C9B471B8")]
    [ComVisibleAttribute(true)]
    public interface IReflect
    {
        /// <summary>Gets the underlying type that represents the <see cref="T:System.Reflection.IReflect" /> object.</summary><returns>The underlying type that represents the <see cref="T:System.Reflection.IReflect" /> object.</returns>
        Type UnderlyingSystemType
        {
            get;
        }
    
    
        /// <summary>Retrieves a <see cref="T:System.Reflection.MethodInfo" /> object corresponding to a specified method, using a <see cref="T:System.Type" /> array to choose from among overloaded methods.</summary><returns>The requested method that matches all the specified parameters.</returns><param name="name">The name of the member to find. </param><param name="bindingAttr">The binding attributes used to control the search. </param><param name="binder">An object that implements <see cref="T:System.Reflection.Binder" />, containing properties related to this method. </param><param name="types">An array used to choose among overloaded methods. </param><param name="modifiers">An array of parameter modifiers used to make binding work with parameter signatures in which the types have been modified. </param><exception cref="T:System.Reflection.AmbiguousMatchException">The object implements multiple methods with the same name. </exception>
        MethodInfo GetMethod(string name, BindingFlags bindingAttr, Binder binder, Type[] types, ParameterModifier[] modifiers);
        
        
        /// <summary>Retrieves a <see cref="T:System.Reflection.MethodInfo" /> object that corresponds to a specified method under specified search constraints.</summary><returns>A <see cref="T:System.Reflection.MethodInfo" /> object containing the method information, with the match being based on the method name and search constraints specified in <paramref name="bindingAttr" />.</returns><param name="name">The name of the member to find. </param><param name="bindingAttr">The binding attributes used to control the search. </param><exception cref="T:System.Reflection.AmbiguousMatchException">The object implements multiple methods with the same name. </exception>
        MethodInfo GetMethod(string name, BindingFlags bindingAttr);
        
        
        /// <summary>Retrieves an array of <see cref="T:System.Reflection.MethodInfo" /> objects with all public methods or all methods of the current class.</summary><returns>An array of <see cref="T:System.Reflection.MethodInfo" /> objects containing all the methods defined for this reflection object that meet the search constraints specified in <paramref name="bindingAttr" />.</returns><param name="bindingAttr">The binding attributes used to control the search. </param>
        MethodInfo[] GetMethods(BindingFlags bindingAttr);
        
        
        /// <summary>Returns the <see cref="T:System.Reflection.FieldInfo" /> object that corresponds to the specified field and binding flag.</summary><returns>A <see cref="T:System.Reflection.FieldInfo" /> object containing the field information for the named object that meets the search constraints specified in <paramref name="bindingAttr" />.</returns><param name="name">The name of the field to find. </param><param name="bindingAttr">The binding attributes used to control the search. </param><exception cref="T:System.Reflection.AmbiguousMatchException">The object implements multiple fields with the same name. </exception>
        FieldInfo GetField(string name, BindingFlags bindingAttr);
        
        
        /// <summary>Returns an array of <see cref="T:System.Reflection.FieldInfo" /> objects that correspond to all fields of the current class.</summary><returns>An array of <see cref="T:System.Reflection.FieldInfo" /> objects containing all the field information for this reflection object that meets the search constraints specified in <paramref name="bindingAttr" />.</returns><param name="bindingAttr">The binding attributes used to control the search. </param>
        FieldInfo[] GetFields(BindingFlags bindingAttr);
        
        
        /// <summary>Retrieves a <see cref="T:System.Reflection.PropertyInfo" /> object corresponding to a specified property under specified search constraints.</summary><returns>A <see cref="T:System.Reflection.PropertyInfo" /> object for the located property that meets the search constraints specified in <paramref name="bindingAttr" />, or null if the property was not located.</returns><param name="name">The name of the property to find. </param><param name="bindingAttr">The binding attributes used to control the search. </param><exception cref="T:System.Reflection.AmbiguousMatchException">The object implements multiple fields with the same name. </exception>
        PropertyInfo GetProperty(string name, BindingFlags bindingAttr);
        
        
        /// <summary>Retrieves a <see cref="T:System.Reflection.PropertyInfo" /> object that corresponds to a specified property with specified search constraints.</summary><returns>A <see cref="T:System.Reflection.PropertyInfo" /> object for the located property, if a property with the specified name was located in this reflection object, or null if the property was not located.</returns><param name="name">The name of the member to find. </param><param name="bindingAttr">The binding attribute used to control the search. </param><param name="binder">An object that implements <see cref="T:System.Reflection.Binder" />, containing properties related to this method. </param><param name="returnType">The type of the property. </param><param name="types">An array used to choose among overloaded methods with the same name. </param><param name="modifiers">An array used to choose the parameter modifiers. </param>
        PropertyInfo GetProperty(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers);
        
        
        /// <summary>Retrieves an array of <see cref="T:System.Reflection.PropertyInfo" /> objects corresponding to all public properties or to all properties of the current class.</summary><returns>An array of <see cref="T:System.Reflection.PropertyInfo" /> objects for all the properties defined on the reflection object.</returns><param name="bindingAttr">The binding attribute used to control the search. </param>
        PropertyInfo[] GetProperties(BindingFlags bindingAttr);
        
        
        /// <summary>Retrieves an array of <see cref="T:System.Reflection.MemberInfo" /> objects corresponding to all public members or to all members that match a specified name.</summary><returns>An array of <see cref="T:System.Reflection.MemberInfo" /> objects matching the <paramref name="name" /> parameter.</returns><param name="name">The name of the member to find. </param><param name="bindingAttr">The binding attributes used to control the search. </param>
        MemberInfo[] GetMember(string name, BindingFlags bindingAttr);
        
        
        /// <summary>Retrieves an array of <see cref="T:System.Reflection.MemberInfo" /> objects that correspond either to all public members or to all members of the current class.</summary><returns>An array of <see cref="T:System.Reflection.MemberInfo" /> objects containing all the member information for this reflection object.</returns><param name="bindingAttr">The binding attributes used to control the search. </param>
        MemberInfo[] GetMembers(BindingFlags bindingAttr);
        
        
        /// <summary>Invokes a specified member.</summary><returns>The specified member.</returns><param name="name">The name of the member to find. </param><param name="invokeAttr">One of the <see cref="T:System.Reflection.BindingFlags" /> invocation attributes. The <paramref name="invokeAttr" /> parameter may be a constructor, method, property, or field. A suitable invocation attribute must be specified. Invoke the default member of a class by passing the empty string ("") as the name of the member. </param><param name="binder">One of the <see cref="T:System.Reflection.BindingFlags" /> bit flags. Implements <see cref="T:System.Reflection.Binder" />, containing properties related to this method. </param><param name="target">The object on which to invoke the specified member. This parameter is ignored for static members. </param><param name="args">An array of objects that contains the number, order, and type of the parameters of the member to be invoked. This is an empty array if there are no parameters. </param><param name="modifiers">An array of <see cref="T:System.Reflection.ParameterModifier" /> objects. This array has the same length as the <paramref name="args" /> parameter, representing the invoked member's argument attributes in the metadata. A parameter can have the following attributes: pdIn, pdOut, pdRetval, pdOptional, and pdHasDefault. These represent [In], [Out], [retval], [optional], and a default parameter, respectively. These attributes are used by various interoperability services. </param><param name="culture">An instance of <see cref="T:System.Globalization.CultureInfo" /> used to govern the coercion of types. For example, <paramref name="culture" /> converts a String that represents 1000 to a Double value, since 1000 is represented differently by different cultures. If this parameter is null, the <see cref="T:System.Globalization.CultureInfo" /> for the current thread is used. </param><param name="namedParameters">A String array of parameters. </param><exception cref="T:System.ArgumentException"><paramref name="invokeAttr" /> is <see cref="F:System.Reflection.BindingFlags.CreateInstance" /> and another bit flag is also set. </exception><exception cref="T:System.ArgumentException"><paramref name="invokeAttr" /> is not <see cref="F:System.Reflection.BindingFlags.CreateInstance" /> and <paramref name="name" /> is null. </exception><exception cref="T:System.ArgumentException"><paramref name="invokeAttr" /> is not an invocation attribute from <see cref="T:System.Reflection.BindingFlags" />. </exception><exception cref="T:System.ArgumentException"><paramref name="invokeAttr" /> specifies both get and set for a property or field. </exception><exception cref="T:System.ArgumentException"><paramref name="invokeAttr" /> specifies both a field set and an Invoke method. <paramref name="args" /> are provided for a field get. </exception><exception cref="T:System.ArgumentException">More than one argument is specified for a field set. </exception><exception cref="T:System.MissingFieldException">The field or property cannot be found. </exception><exception cref="T:System.MissingMethodException">The method cannot be found. </exception><exception cref="T:System.Security.SecurityException">A private member is invoked without the necessary <see cref="T:System.Security.Permissions.ReflectionPermission" />. </exception>
        object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParameters);
        
        
    }
}
