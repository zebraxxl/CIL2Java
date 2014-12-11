using System.Runtime.InteropServices;
using System.Reflection;
using System.Security;

namespace System
{
    /// <summary>Represents the base class for custom attributes.</summary><filterpriority>1</filterpriority>
    [Serializable]
    [ClassInterfaceAttribute(ClassInterfaceType.None)]
    [ComDefaultInterfaceAttribute(typeof(_Attribute))]
    [ComVisibleAttribute(true)]
    [AttributeUsageAttribute(AttributeTargets.All, Inherited = true, AllowMultiple = false)]
    public abstract class Attribute : _Attribute
    {
        /// <summary>When implemented in a derived class, gets a unique identifier for this <see cref="T:System.Attribute" />.</summary><returns>An <see cref="T:System.Object" /> that is a unique identifier for the attribute.</returns><filterpriority>2</filterpriority>
        public virtual object TypeId
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Retrieves an array of the custom attributes applied to a member of a type. Parameters specify the member, and the type of the custom attribute to search for.</summary><returns>An <see cref="T:System.Attribute" /> array that contains the custom attributes of type <paramref name="type" /> applied to <paramref name="element" />, or an empty array if no such custom attributes exist.</returns><param name="element">An object derived from the <see cref="T:System.Reflection.MemberInfo" /> class that describes a constructor, event, field, method, or property member of a class. </param><param name="type">The type, or a base type, of the custom attribute to search for.</param><exception cref="T:System.ArgumentNullException"><paramref name="element" /> or <paramref name="type" /> is null. </exception><exception cref="T:System.ArgumentException"><paramref name="type" /> is not derived from <see cref="T:System.Attribute" />. </exception><exception cref="T:System.NotSupportedException"><paramref name="element" /> is not a constructor, method, property, event, type, or field. </exception><exception cref="T:System.TypeLoadException">A custom attribute type cannot be loaded. </exception><filterpriority>1</filterpriority>
        public static Attribute[] GetCustomAttributes(MemberInfo element, Type type)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Retrieves an array of the custom attributes applied to a member of a type. Parameters specify the member, the type of the custom attribute to search for, and whether to search ancestors of the member.</summary><returns>An <see cref="T:System.Attribute" /> array that contains the custom attributes of type <paramref name="type" /> applied to <paramref name="element" />, or an empty array if no such custom attributes exist.</returns><param name="element">An object derived from the <see cref="T:System.Reflection.MemberInfo" /> class that describes a constructor, event, field, method, or property member of a class. </param><param name="type">The type, or a base type, of the custom attribute to search for.</param><param name="inherit">If true, specifies to also search the ancestors of <paramref name="element" /> for custom attributes. </param><exception cref="T:System.ArgumentNullException"><paramref name="element" /> or <paramref name="type" /> is null. </exception><exception cref="T:System.ArgumentException"><paramref name="type" /> is not derived from <see cref="T:System.Attribute" />. </exception><exception cref="T:System.NotSupportedException"><paramref name="element" /> is not a constructor, method, property, event, type, or field. </exception><exception cref="T:System.TypeLoadException">A custom attribute type cannot be loaded. </exception><filterpriority>1</filterpriority>
        public static Attribute[] GetCustomAttributes(MemberInfo element, Type type, bool inherit)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Retrieves an array of the custom attributes applied to a member of a type. A parameter specifies the member.</summary><returns>An <see cref="T:System.Attribute" /> array that contains the custom attributes applied to <paramref name="element" />, or an empty array if no such custom attributes exist.</returns><param name="element">An object derived from the <see cref="T:System.Reflection.MemberInfo" /> class that describes a constructor, event, field, method, or property member of a class. </param><exception cref="T:System.ArgumentNullException"><paramref name="element" /> is null. </exception><exception cref="T:System.NotSupportedException"><paramref name="element" /> is not a constructor, method, property, event, type, or field. </exception><exception cref="T:System.TypeLoadException">A custom attribute type cannot be loaded. </exception><filterpriority>1</filterpriority>
        public static Attribute[] GetCustomAttributes(MemberInfo element)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Retrieves an array of the custom attributes applied to a member of a type. Parameters specify the member, the type of the custom attribute to search for, and whether to search ancestors of the member.</summary><returns>An <see cref="T:System.Attribute" /> array that contains the custom attributes applied to <paramref name="element" />, or an empty array if no such custom attributes exist.</returns><param name="element">An object derived from the <see cref="T:System.Reflection.MemberInfo" /> class that describes a constructor, event, field, method, or property member of a class. </param><param name="inherit">If true, specifies to also search the ancestors of <paramref name="element" /> for custom attributes. </param><exception cref="T:System.ArgumentNullException"><paramref name="element" /> is null. </exception><exception cref="T:System.NotSupportedException"><paramref name="element" /> is not a constructor, method, property, event, type, or field. </exception><exception cref="T:System.TypeLoadException">A custom attribute type cannot be loaded. </exception><filterpriority>1</filterpriority>
        public static Attribute[] GetCustomAttributes(MemberInfo element, bool inherit)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether any custom attributes are applied to a member of a type. Parameters specify the member, and the type of the custom attribute to search for.</summary><returns>true if a custom attribute of type <paramref name="attributeType" /> is applied to <paramref name="element" />; otherwise, false.</returns><param name="element">An object derived from the <see cref="T:System.Reflection.MemberInfo" /> class that describes a constructor, event, field, method, type, or property member of a class. </param><param name="attributeType">The type, or a base type, of the custom attribute to search for.</param><exception cref="T:System.ArgumentNullException"><paramref name="element" /> or <paramref name="attributeType" /> is null. </exception><exception cref="T:System.ArgumentException"><paramref name="attributeType" /> is not derived from <see cref="T:System.Attribute" />. </exception><exception cref="T:System.NotSupportedException"><paramref name="element" /> is not a constructor, method, property, event, type, or field. </exception><filterpriority>1</filterpriority>
        public static bool IsDefined(MemberInfo element, Type attributeType)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether any custom attributes are applied to a member of a type. Parameters specify the member, the type of the custom attribute to search for, and whether to search ancestors of the member.</summary><returns>true if a custom attribute of type <paramref name="attributeType" /> is applied to <paramref name="element" />; otherwise, false.</returns><param name="element">An object derived from the <see cref="T:System.Reflection.MemberInfo" /> class that describes a constructor, event, field, method, type, or property member of a class. </param><param name="attributeType">The type, or a base type, of the custom attribute to search for.</param><param name="inherit">If true, specifies to also search the ancestors of <paramref name="element" /> for custom attributes. </param><exception cref="T:System.ArgumentNullException"><paramref name="element" /> or <paramref name="attributeType" /> is null. </exception><exception cref="T:System.ArgumentException"><paramref name="attributeType" /> is not derived from <see cref="T:System.Attribute" />. </exception><exception cref="T:System.NotSupportedException"><paramref name="element" /> is not a constructor, method, property, event, type, or field. </exception><filterpriority>1</filterpriority>
        public static bool IsDefined(MemberInfo element, Type attributeType, bool inherit)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Retrieves a custom attribute applied to a member of a type. Parameters specify the member, and the type of the custom attribute to search for.</summary><returns>A reference to the single custom attribute of type <paramref name="attributeType" /> that is applied to <paramref name="element" />, or null if there is no such attribute.</returns><param name="element">An object derived from the <see cref="T:System.Reflection.MemberInfo" /> class that describes a constructor, event, field, method, or property member of a class. </param><param name="attributeType">The type, or a base type, of the custom attribute to search for.</param><exception cref="T:System.ArgumentNullException"><paramref name="element" /> or <paramref name="attributeType" /> is null. </exception><exception cref="T:System.ArgumentException"><paramref name="attributeType" /> is not derived from <see cref="T:System.Attribute" />. </exception><exception cref="T:System.NotSupportedException"><paramref name="element" /> is not a constructor, method, property, event, type, or field. </exception><exception cref="T:System.Reflection.AmbiguousMatchException">More than one of the requested attributes was found. </exception><exception cref="T:System.TypeLoadException">A custom attribute type cannot be loaded. </exception><filterpriority>1</filterpriority>
        public static Attribute GetCustomAttribute(MemberInfo element, Type attributeType)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Retrieves a custom attribute applied to a member of a type. Parameters specify the member, the type of the custom attribute to search for, and whether to search ancestors of the member.</summary><returns>A reference to the single custom attribute of type <paramref name="attributeType" /> that is applied to <paramref name="element" />, or null if there is no such attribute.</returns><param name="element">An object derived from the <see cref="T:System.Reflection.MemberInfo" /> class that describes a constructor, event, field, method, or property member of a class. </param><param name="attributeType">The type, or a base type, of the custom attribute to search for.</param><param name="inherit">If true, specifies to also search the ancestors of <paramref name="element" /> for custom attributes. </param><exception cref="T:System.ArgumentNullException"><paramref name="element" /> or <paramref name="attributeType" /> is null. </exception><exception cref="T:System.ArgumentException"><paramref name="attributeType" /> is not derived from <see cref="T:System.Attribute" />. </exception><exception cref="T:System.NotSupportedException"><paramref name="element" /> is not a constructor, method, property, event, type, or field. </exception><exception cref="T:System.Reflection.AmbiguousMatchException">More than one of the requested attributes was found. </exception><exception cref="T:System.TypeLoadException">A custom attribute type cannot be loaded. </exception><filterpriority>1</filterpriority>
        public static Attribute GetCustomAttribute(MemberInfo element, Type attributeType, bool inherit)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Retrieves an array of the custom attributes applied to a method parameter. A parameter specifies the method parameter.</summary><returns>An <see cref="T:System.Attribute" /> array that contains the custom attributes applied to <paramref name="element" />, or an empty array if no such custom attributes exist.</returns><param name="element">An object derived from the <see cref="T:System.Reflection.ParameterInfo" /> class that describes a parameter of a member of a class. </param><exception cref="T:System.ArgumentNullException"><paramref name="element" /> is null. </exception><exception cref="T:System.TypeLoadException">A custom attribute type cannot be loaded. </exception><filterpriority>1</filterpriority>
        public static Attribute[] GetCustomAttributes(ParameterInfo element)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Retrieves an array of the custom attributes applied to a method parameter. Parameters specify the method parameter, and the type of the custom attribute to search for.</summary><returns>An <see cref="T:System.Attribute" /> array that contains the custom attributes of type <paramref name="attributeType" /> applied to <paramref name="element" />, or an empty array if no such custom attributes exist.</returns><param name="element">An object derived from the <see cref="T:System.Reflection.ParameterInfo" /> class that describes a parameter of a member of a class. </param><param name="attributeType">The type, or a base type, of the custom attribute to search for.</param><exception cref="T:System.ArgumentNullException"><paramref name="element" /> or <paramref name="attributeType" /> is null. </exception><exception cref="T:System.ArgumentException"><paramref name="attributeType" /> is not derived from <see cref="T:System.Attribute" />. </exception><exception cref="T:System.TypeLoadException">A custom attribute type cannot be loaded. </exception><filterpriority>1</filterpriority>
        public static Attribute[] GetCustomAttributes(ParameterInfo element, Type attributeType)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Retrieves an array of the custom attributes applied to a method parameter. Parameters specify the method parameter, the type of the custom attribute to search for, and whether to search ancestors of the method parameter.</summary><returns>An <see cref="T:System.Attribute" /> array that contains the custom attributes of type <paramref name="attributeType" /> applied to <paramref name="element" />, or an empty array if no such custom attributes exist.</returns><param name="element">An object derived from the <see cref="T:System.Reflection.ParameterInfo" /> class that describes a parameter of a member of a class. </param><param name="attributeType">The type, or a base type, of the custom attribute to search for.</param><param name="inherit">If true, specifies to also search the ancestors of <paramref name="element" /> for custom attributes. </param><exception cref="T:System.ArgumentNullException"><paramref name="element" /> or <paramref name="attributeType" /> is null. </exception><exception cref="T:System.ArgumentException"><paramref name="attributeType" /> is not derived from <see cref="T:System.Attribute" />. </exception><exception cref="T:System.TypeLoadException">A custom attribute type cannot be loaded. </exception><filterpriority>1</filterpriority>
        public static Attribute[] GetCustomAttributes(ParameterInfo element, Type attributeType, bool inherit)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Retrieves an array of the custom attributes applied to a method parameter. Parameters specify the method parameter, and whether to search ancestors of the method parameter.</summary><returns>An <see cref="T:System.Attribute" /> array that contains the custom attributes applied to <paramref name="element" />, or an empty array if no such custom attributes exist.</returns><param name="element">An object derived from the <see cref="T:System.Reflection.ParameterInfo" /> class that describes a parameter of a member of a class. </param><param name="inherit">If true, specifies to also search the ancestors of <paramref name="element" /> for custom attributes. </param><exception cref="T:System.ArgumentException">The <see cref="P:System.Reflection.ParameterInfo.Member" /> property of <paramref name="element" /> is null. </exception><exception cref="T:System.ArgumentNullException"><paramref name="element" /> is null. </exception><exception cref="T:System.TypeLoadException">A custom attribute type cannot be loaded. </exception><filterpriority>1</filterpriority>
        public static Attribute[] GetCustomAttributes(ParameterInfo element, bool inherit)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether any custom attributes are applied to a method parameter. Parameters specify the method parameter, and the type of the custom attribute to search for.</summary><returns>true if a custom attribute of type <paramref name="attributeType" /> is applied to <paramref name="element" />; otherwise, false.</returns><param name="element">An object derived from the <see cref="T:System.Reflection.ParameterInfo" /> class that describes a parameter of a member of a class. </param><param name="attributeType">The type, or a base type, of the custom attribute to search for.</param><exception cref="T:System.ArgumentNullException"><paramref name="element" /> or <paramref name="attributeType" /> is null. </exception><exception cref="T:System.ArgumentException"><paramref name="attributeType" /> is not derived from <see cref="T:System.Attribute" />. </exception><filterpriority>1</filterpriority>
        public static bool IsDefined(ParameterInfo element, Type attributeType)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether any custom attributes are applied to a method parameter. Parameters specify the method parameter, the type of the custom attribute to search for, and whether to search ancestors of the method parameter.</summary><returns>true if a custom attribute of type <paramref name="attributeType" /> is applied to <paramref name="element" />; otherwise, false.</returns><param name="element">An object derived from the <see cref="T:System.Reflection.ParameterInfo" /> class that describes a parameter of a member of a class. </param><param name="attributeType">The type, or a base type, of the custom attribute to search for.</param><param name="inherit">If true, specifies to also search the ancestors of <paramref name="element" /> for custom attributes. </param><exception cref="T:System.ArgumentNullException"><paramref name="element" /> or <paramref name="attributeType" /> is null. </exception><exception cref="T:System.ArgumentException"><paramref name="attributeType" /> is not derived from <see cref="T:System.Attribute" />. </exception><exception cref="T:System.ExecutionEngineException"><paramref name="element" /> is not a method, constructor, or type. </exception><filterpriority>1</filterpriority>
        public static bool IsDefined(ParameterInfo element, Type attributeType, bool inherit)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Retrieves a custom attribute applied to a method parameter. Parameters specify the method parameter, and the type of the custom attribute to search for.</summary><returns>A reference to the single custom attribute of type <paramref name="attributeType" /> that is applied to <paramref name="element" />, or null if there is no such attribute.</returns><param name="element">An object derived from the <see cref="T:System.Reflection.ParameterInfo" /> class that describes a parameter of a member of a class. </param><param name="attributeType">The type, or a base type, of the custom attribute to search for.</param><exception cref="T:System.ArgumentNullException"><paramref name="element" /> or <paramref name="attributeType" /> is null. </exception><exception cref="T:System.ArgumentException"><paramref name="attributeType" /> is not derived from <see cref="T:System.Attribute" />. </exception><exception cref="T:System.Reflection.AmbiguousMatchException">More than one of the requested attributes was found. </exception><exception cref="T:System.TypeLoadException">A custom attribute type cannot be loaded. </exception><filterpriority>1</filterpriority>
        public static Attribute GetCustomAttribute(ParameterInfo element, Type attributeType)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Retrieves a custom attribute applied to a method parameter. Parameters specify the method parameter, the type of the custom attribute to search for, and whether to search ancestors of the method parameter.</summary><returns>A reference to the single custom attribute of type <paramref name="attributeType" /> that is applied to <paramref name="element" />, or null if there is no such attribute.</returns><param name="element">An object derived from the <see cref="T:System.Reflection.ParameterInfo" /> class that describes a parameter of a member of a class. </param><param name="attributeType">The type, or a base type, of the custom attribute to search for.</param><param name="inherit">If true, specifies to also search the ancestors of <paramref name="element" /> for custom attributes. </param><exception cref="T:System.ArgumentNullException"><paramref name="element" /> or <paramref name="attributeType" /> is null. </exception><exception cref="T:System.ArgumentException"><paramref name="attributeType" /> is not derived from <see cref="T:System.Attribute" />. </exception><exception cref="T:System.Reflection.AmbiguousMatchException">More than one of the requested attributes was found. </exception><exception cref="T:System.TypeLoadException">A custom attribute type cannot be loaded. </exception><filterpriority>1</filterpriority>
        public static Attribute GetCustomAttribute(ParameterInfo element, Type attributeType, bool inherit)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Retrieves an array of the custom attributes applied to a module. Parameters specify the module, and the type of the custom attribute to search for.</summary><returns>An <see cref="T:System.Attribute" /> array that contains the custom attributes of type <paramref name="attributeType" /> applied to <paramref name="element" />, or an empty array if no such custom attributes exist.</returns><param name="element">An object derived from the <see cref="T:System.Reflection.Module" /> class that describes a portable executable file. </param><param name="attributeType">The type, or a base type, of the custom attribute to search for.</param><exception cref="T:System.ArgumentNullException"><paramref name="element" /> or <paramref name="attributeType" /> is null. </exception><exception cref="T:System.ArgumentException"><paramref name="attributeType" /> is not derived from <see cref="T:System.Attribute" />. </exception><filterpriority>1</filterpriority>
        public static Attribute[] GetCustomAttributes(Module element, Type attributeType)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Retrieves an array of the custom attributes applied to a module. A parameter specifies the module.</summary><returns>An <see cref="T:System.Attribute" /> array that contains the custom attributes applied to <paramref name="element" />, or an empty array if no such custom attributes exist.</returns><param name="element">An object derived from the <see cref="T:System.Reflection.Module" /> class that describes a portable executable file. </param><exception cref="T:System.ArgumentNullException"><paramref name="element" /> is null. </exception><filterpriority>1</filterpriority>
        public static Attribute[] GetCustomAttributes(Module element)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Retrieves an array of the custom attributes applied to a module. Parameters specify the module, and an ignored search option.</summary><returns>An <see cref="T:System.Attribute" /> array that contains the custom attributes applied to <paramref name="element" />, or an empty array if no such custom attributes exist.</returns><param name="element">An object derived from the <see cref="T:System.Reflection.Module" /> class that describes a portable executable file. </param><param name="inherit">This parameter is ignored, and does not affect the operation of this method. </param><exception cref="T:System.ArgumentNullException"><paramref name="element" /> or <paramref name="attributeType" /> is null. </exception><filterpriority>1</filterpriority>
        public static Attribute[] GetCustomAttributes(Module element, bool inherit)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Retrieves an array of the custom attributes applied to a module. Parameters specify the module, the type of the custom attribute to search for, and an ignored search option.</summary><returns>An <see cref="T:System.Attribute" /> array that contains the custom attributes of type <paramref name="attributeType" /> applied to <paramref name="element" />, or an empty array if no such custom attributes exist.</returns><param name="element">An object derived from the <see cref="T:System.Reflection.Module" /> class that describes a portable executable file. </param><param name="attributeType">The type, or a base type, of the custom attribute to search for.</param><param name="inherit">This parameter is ignored, and does not affect the operation of this method. </param><exception cref="T:System.ArgumentNullException"><paramref name="element" /> or <paramref name="attributeType" /> is null. </exception><exception cref="T:System.ArgumentException"><paramref name="attributeType" /> is not derived from <see cref="T:System.Attribute" />. </exception><filterpriority>1</filterpriority>
        public static Attribute[] GetCustomAttributes(Module element, Type attributeType, bool inherit)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether any custom attributes of a specified type are applied to a module. Parameters specify the module, and the type of the custom attribute to search for.</summary><returns>true if a custom attribute of type <paramref name="attributeType" /> is applied to <paramref name="element" />; otherwise, false.</returns><param name="element">An object derived from the <see cref="T:System.Reflection.Module" /> class that describes a portable executable file. </param><param name="attributeType">The type, or a base type, of the custom attribute to search for.</param><exception cref="T:System.ArgumentNullException"><paramref name="element" /> or <paramref name="attributeType" /> is null. </exception><exception cref="T:System.ArgumentException"><paramref name="attributeType" /> is not derived from <see cref="T:System.Attribute" />. </exception><filterpriority>1</filterpriority>
        public static bool IsDefined(Module element, Type attributeType)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether any custom attributes are applied to a module. Parameters specify the module, the type of the custom attribute to search for, and an ignored search option. </summary><returns>true if a custom attribute of type <paramref name="attributeType" /> is applied to <paramref name="element" />; otherwise, false.</returns><param name="element">An object derived from the <see cref="T:System.Reflection.Module" /> class that describes a portable executable file. </param><param name="attributeType">The type, or a base type, of the custom attribute to search for.</param><param name="inherit">This parameter is ignored, and does not affect the operation of this method. </param><exception cref="T:System.ArgumentNullException"><paramref name="element" /> or <paramref name="attributeType" /> is null. </exception><exception cref="T:System.ArgumentException"><paramref name="attributeType" /> is not derived from <see cref="T:System.Attribute" />. </exception><filterpriority>1</filterpriority>
        public static bool IsDefined(Module element, Type attributeType, bool inherit)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Retrieves a custom attribute applied to a module. Parameters specify the module, and the type of the custom attribute to search for.</summary><returns>A reference to the single custom attribute of type <paramref name="attributeType" /> that is applied to <paramref name="element" />, or null if there is no such attribute.</returns><param name="element">An object derived from the <see cref="T:System.Reflection.Module" /> class that describes a portable executable file. </param><param name="attributeType">The type, or a base type, of the custom attribute to search for.</param><exception cref="T:System.ArgumentNullException"><paramref name="element" /> or <paramref name="attributeType" /> is null. </exception><exception cref="T:System.ArgumentException"><paramref name="attributeType" /> is not derived from <see cref="T:System.Attribute" />. </exception><exception cref="T:System.Reflection.AmbiguousMatchException">More than one of the requested attributes was found. </exception><filterpriority>1</filterpriority>
        public static Attribute GetCustomAttribute(Module element, Type attributeType)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Retrieves a custom attribute applied to a module. Parameters specify the module, the type of the custom attribute to search for, and an ignored search option.</summary><returns>A reference to the single custom attribute of type <paramref name="attributeType" /> that is applied to <paramref name="element" />, or null if there is no such attribute.</returns><param name="element">An object derived from the <see cref="T:System.Reflection.Module" /> class that describes a portable executable file. </param><param name="attributeType">The type, or a base type, of the custom attribute to search for.</param><param name="inherit">This parameter is ignored, and does not affect the operation of this method. </param><exception cref="T:System.ArgumentNullException"><paramref name="element" /> or <paramref name="attributeType" /> is null. </exception><exception cref="T:System.ArgumentException"><paramref name="attributeType" /> is not derived from <see cref="T:System.Attribute" />. </exception><exception cref="T:System.Reflection.AmbiguousMatchException">More than one of the requested attributes was found. </exception><filterpriority>1</filterpriority>
        public static Attribute GetCustomAttribute(Module element, Type attributeType, bool inherit)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Retrieves an array of the custom attributes applied to an assembly. Parameters specify the assembly, and the type of the custom attribute to search for.</summary><returns>An <see cref="T:System.Attribute" /> array that contains the custom attributes of type <paramref name="attributeType" /> applied to <paramref name="element" />, or an empty array if no such custom attributes exist.</returns><param name="element">An object derived from the <see cref="T:System.Reflection.Assembly" /> class that describes a reusable collection of modules. </param><param name="attributeType">The type, or a base type, of the custom attribute to search for.</param><exception cref="T:System.ArgumentNullException"><paramref name="element" /> or <paramref name="attributeType" /> is null. </exception><exception cref="T:System.ArgumentException"><paramref name="attributeType" /> is not derived from <see cref="T:System.Attribute" />. </exception><filterpriority>1</filterpriority>
        public static Attribute[] GetCustomAttributes(Assembly element, Type attributeType)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Retrieves an array of the custom attributes applied to an assembly. Parameters specify the assembly, the type of the custom attribute to search for, and an ignored search option.</summary><returns>An <see cref="T:System.Attribute" /> array that contains the custom attributes of type <paramref name="attributeType" /> applied to <paramref name="element" />, or an empty array if no such custom attributes exist.</returns><param name="element">An object derived from the <see cref="T:System.Reflection.Assembly" /> class that describes a reusable collection of modules. </param><param name="attributeType">The type, or a base type, of the custom attribute to search for.</param><param name="inherit">This parameter is ignored, and does not affect the operation of this method. </param><exception cref="T:System.ArgumentNullException"><paramref name="element" /> or <paramref name="attributeType" /> is null. </exception><exception cref="T:System.ArgumentException"><paramref name="attributeType" /> is not derived from <see cref="T:System.Attribute" />. </exception><filterpriority>1</filterpriority>
        public static Attribute[] GetCustomAttributes(Assembly element, Type attributeType, bool inherit)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Retrieves an array of the custom attributes applied to an assembly. A parameter specifies the assembly.</summary><returns>An <see cref="T:System.Attribute" /> array that contains the custom attributes applied to <paramref name="element" />, or an empty array if no such custom attributes exist.</returns><param name="element">An object derived from the <see cref="T:System.Reflection.Assembly" /> class that describes a reusable collection of modules. </param><exception cref="T:System.ArgumentNullException"><paramref name="element" /> is null. </exception><filterpriority>1</filterpriority>
        public static Attribute[] GetCustomAttributes(Assembly element)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Retrieves an array of the custom attributes applied to an assembly. Parameters specify the assembly, and an ignored search option.</summary><returns>An <see cref="T:System.Attribute" /> array that contains the custom attributes applied to <paramref name="element" />, or an empty array if no such custom attributes exist.</returns><param name="element">An object derived from the <see cref="T:System.Reflection.Assembly" /> class that describes a reusable collection of modules. </param><param name="inherit">This parameter is ignored, and does not affect the operation of this method. </param><exception cref="T:System.ArgumentNullException"><paramref name="element" /> or <paramref name="attributeType" /> is null. </exception><filterpriority>1</filterpriority>
        public static Attribute[] GetCustomAttributes(Assembly element, bool inherit)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether any custom attributes are applied to an assembly. Parameters specify the assembly, and the type of the custom attribute to search for.</summary><returns>true if a custom attribute of type <paramref name="attributeType" /> is applied to <paramref name="element" />; otherwise, false.</returns><param name="element">An object derived from the <see cref="T:System.Reflection.Assembly" /> class that describes a reusable collection of modules. </param><param name="attributeType">The type, or a base type, of the custom attribute to search for.</param><exception cref="T:System.ArgumentNullException"><paramref name="element" /> or <paramref name="attributeType" /> is null. </exception><exception cref="T:System.ArgumentException"><paramref name="attributeType" /> is not derived from <see cref="T:System.Attribute" />. </exception><filterpriority>1</filterpriority>
        public static bool IsDefined(Assembly element, Type attributeType)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether any custom attributes are applied to an assembly. Parameters specify the assembly, the type of the custom attribute to search for, and an ignored search option.</summary><returns>true if a custom attribute of type <paramref name="attributeType" /> is applied to <paramref name="element" />; otherwise, false.</returns><param name="element">An object derived from the <see cref="T:System.Reflection.Assembly" /> class that describes a reusable collection of modules. </param><param name="attributeType">The type, or a base type, of the custom attribute to search for.</param><param name="inherit">This parameter is ignored, and does not affect the operation of this method. </param><exception cref="T:System.ArgumentNullException"><paramref name="element" /> or <paramref name="attributeType" /> is null. </exception><exception cref="T:System.ArgumentException"><paramref name="attributeType" /> is not derived from <see cref="T:System.Attribute" />. </exception><filterpriority>1</filterpriority>
        public static bool IsDefined(Assembly element, Type attributeType, bool inherit)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Retrieves a custom attribute applied to a specified assembly. Parameters specify the assembly and the type of the custom attribute to search for.</summary><returns>A reference to the single custom attribute of type <paramref name="attributeType" /> that is applied to <paramref name="element" />, or null if there is no such attribute.</returns><param name="element">An object derived from the <see cref="T:System.Reflection.Assembly" /> class that describes a reusable collection of modules. </param><param name="attributeType">The type, or a base type, of the custom attribute to search for.</param><exception cref="T:System.ArgumentNullException"><paramref name="element" /> or <paramref name="attributeType" /> is null. </exception><exception cref="T:System.ArgumentException"><paramref name="attributeType" /> is not derived from <see cref="T:System.Attribute" />. </exception><exception cref="T:System.Reflection.AmbiguousMatchException">More than one of the requested attributes was found. </exception><filterpriority>1</filterpriority>
        public static Attribute GetCustomAttribute(Assembly element, Type attributeType)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Retrieves a custom attribute applied to an assembly. Parameters specify the assembly, the type of the custom attribute to search for, and an ignored search option.</summary><returns>A reference to the single custom attribute of type <paramref name="attributeType" /> that is applied to <paramref name="element" />, or null if there is no such attribute.</returns><param name="element">An object derived from the <see cref="T:System.Reflection.Assembly" /> class that describes a reusable collection of modules. </param><param name="attributeType">The type, or a base type, of the custom attribute to search for.</param><param name="inherit">This parameter is ignored, and does not affect the operation of this method. </param><exception cref="T:System.ArgumentNullException"><paramref name="element" /> or <paramref name="attributeType" /> is null. </exception><exception cref="T:System.ArgumentException"><paramref name="attributeType" /> is not derived from <see cref="T:System.Attribute" />. </exception><exception cref="T:System.Reflection.AmbiguousMatchException">More than one of the requested attributes was found. </exception><filterpriority>1</filterpriority>
        public static Attribute GetCustomAttribute(Assembly element, Type attributeType, bool inherit)
        {
             throw new NotImplementedException();
        }
        
        
        protected Attribute()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a value that indicates whether this instance is equal to a specified object.</summary><returns>true if <paramref name="obj" /> equals the type and value of this instance; otherwise, false.</returns><param name="obj">An <see cref="T:System.Object" /> to compare with this instance or null. </param><filterpriority>2</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public override bool Equals(object obj)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public override int GetHashCode()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>When overridden in a derived class, returns a value that indicates whether this instance equals a specified object.</summary><returns>true if this instance equals <paramref name="obj" />; otherwise, false.</returns><param name="obj">An <see cref="T:System.Object" /> to compare with this instance of <see cref="T:System.Attribute" />. </param><filterpriority>2</filterpriority>
        public virtual bool Match(object obj)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual bool IsDefaultAttribute()
        {
             throw new NotImplementedException();
        }



        void _Attribute.GetTypeInfoCount(ref uint pcTInfo)
        {
            throw new NotImplementedException();
        }

        void _Attribute.GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo)
        {
            throw new NotImplementedException();
        }

        void _Attribute.GetIDsOfNames(ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId)
        {
            throw new NotImplementedException();
        }

        void _Attribute.Invoke(uint dispIdMember, ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr)
        {
            throw new NotImplementedException();
        }
    }
}
