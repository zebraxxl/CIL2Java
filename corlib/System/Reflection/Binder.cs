using System.Runtime.InteropServices;
using System.Globalization;
using System;

namespace System.Reflection
{
    /// <summary>Selects a member from a list of candidates, and performs type conversion from actual argument type to formal argument type. </summary>
    [Serializable]
    [ClassInterfaceAttribute(ClassInterfaceType.AutoDual)]
    [ComVisibleAttribute(true)]
    public abstract class Binder
    {
        public abstract MethodBase BindToMethod(BindingFlags bindingAttr, MethodBase[] match, ref object args, ParameterModifier[] modifiers, CultureInfo culture, string[] names, ref object state);
        
        
        /// <summary>Selects a field from the given set of fields, based on the specified criteria.</summary><returns>The matching field. </returns><param name="bindingAttr">A bitwise combination of <see cref="T:System.Reflection.BindingFlags" /> values. </param><param name="match">The set of fields that are candidates for matching. For example, when a <see cref="T:System.Reflection.Binder" /> object is used by <see cref="Overload:System.Type.InvokeMember" />, this parameter specifies the set of fields that reflection has determined to be possible matches, typically because they have the correct member name. The default implementation provided by <see cref="P:System.Type.DefaultBinder" /> changes the order of this array.</param><param name="value">The field value used to locate a matching field. </param><param name="culture">An instance of <see cref="T:System.Globalization.CultureInfo" /> that is used to control the coercion of data types, in binder implementations that coerce types. If <paramref name="culture" /> is null, the <see cref="T:System.Globalization.CultureInfo" /> for the current thread is used.Note   For example, if a binder implementation allows coercion of string values to numeric types, this parameter is necessary to convert a String that represents 1000 to a Double value, because 1000 is represented differently by different cultures. The default binder does not do such string coercions.</param><exception cref="T:System.Reflection.AmbiguousMatchException">For the default binder, <paramref name="bindingAttr" /> includes <see cref="F:System.Reflection.BindingFlags.SetField" />, and <paramref name="match" /> contains multiple fields that are equally good matches for <paramref name="value" />. For example, <paramref name="value" /> contains a MyClass object that implements the IMyClass interface, and <paramref name="match" /> contains a field of type MyClass and a field of type IMyClass. </exception><exception cref="T:System.MissingFieldException">For the default binder, <paramref name="bindingAttr" /> includes <see cref="F:System.Reflection.BindingFlags.SetField" />, and <paramref name="match" /> contains no fields that can accept <paramref name="value" />.</exception><exception cref="T:System.NullReferenceException">For the default binder, <paramref name="bindingAttr" /> includes <see cref="F:System.Reflection.BindingFlags.SetField" />, and <paramref name="match" /> is null or an empty array.-or-<paramref name="bindingAttr" /> includes <see cref="F:System.Reflection.BindingFlags.SetField" />, and <paramref name="value" /> is null.</exception>
        public abstract FieldInfo BindToField(BindingFlags bindingAttr, FieldInfo[] match, object value, CultureInfo culture);
        
        
        /// <summary>Selects a method from the given set of methods, based on the argument type.</summary><returns>The matching method, if found; otherwise, null.</returns><param name="bindingAttr">A bitwise combination of <see cref="T:System.Reflection.BindingFlags" /> values. </param><param name="match">The set of methods that are candidates for matching. For example, when a <see cref="T:System.Reflection.Binder" /> object is used by <see cref="Overload:System.Type.InvokeMember" />, this parameter specifies the set of methods that reflection has determined to be possible matches, typically because they have the correct member name. The default implementation provided by <see cref="P:System.Type.DefaultBinder" /> changes the order of this array.</param><param name="types">The parameter types used to locate a matching method. </param><param name="modifiers">An array of parameter modifiers that enable binding to work with parameter signatures in which the types have been modified. </param><exception cref="T:System.Reflection.AmbiguousMatchException">For the default binder, <paramref name="match" /> contains multiple methods that are equally good matches for the parameter types described by <paramref name="types" />. For example, the array in <paramref name="types" /> contains a <see cref="T:System.Type" /> object for MyClass and the array in <paramref name="match" /> contains a method that takes a base class of MyClass and a method that takes an interface that MyClass implements. </exception><exception cref="T:System.ArgumentException">For the default binder, <paramref name="match" /> is null or an empty array.-or-An element of <paramref name="types" /> derives from <see cref="T:System.Type" />, but is not of type RuntimeType.</exception>
        public abstract MethodBase SelectMethod(BindingFlags bindingAttr, MethodBase[] match, Type[] types, ParameterModifier[] modifiers);
        
        
        /// <summary>Selects a property from the given set of properties, based on the specified criteria.</summary><returns>The matching property.</returns><param name="bindingAttr">A bitwise combination of <see cref="T:System.Reflection.BindingFlags" /> values. </param><param name="match">The set of properties that are candidates for matching. For example, when a <see cref="T:System.Reflection.Binder" /> object is used by <see cref="Overload:System.Type.InvokeMember" />, this parameter specifies the set of properties that reflection has determined to be possible matches, typically because they have the correct member name. The default implementation provided by <see cref="P:System.Type.DefaultBinder" /> changes the order of this array.</param><param name="returnType">The return value the matching property must have. </param><param name="indexes">The index types of the property being searched for. Used for index properties such as the indexer for a class. </param><param name="modifiers">An array of parameter modifiers that enable binding to work with parameter signatures in which the types have been modified. </param><exception cref="T:System.Reflection.AmbiguousMatchException">For the default binder, <paramref name="match" /> contains multiple properties that are equally good matches for <paramref name="returnType" /> and <paramref name="indexes" />. </exception><exception cref="T:System.ArgumentException">For the default binder, <paramref name="match" /> is null or an empty array. </exception>
        public abstract PropertyInfo SelectProperty(BindingFlags bindingAttr, PropertyInfo[] match, Type returnType, Type[] indexes, ParameterModifier[] modifiers);
        
        
        /// <summary>Changes the type of the given Object to the given Type.</summary><returns>An object that contains the given value as the new type. </returns><param name="value">The object to change into a new Type. </param><param name="type">The new Type that <paramref name="value" /> will become. </param><param name="culture">An instance of <see cref="T:System.Globalization.CultureInfo" /> that is used to control the coercion of data types. If <paramref name="culture" /> is null, the <see cref="T:System.Globalization.CultureInfo" /> for the current thread is used.Note   For example, this parameter is necessary to convert a String that represents 1000 to a Double value, because 1000 is represented differently by different cultures. </param>
        public abstract object ChangeType(object value, Type type, CultureInfo culture);
        
        
        public abstract void ReorderArgumentArray(ref object args, object state);
        
        
        protected Binder()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
