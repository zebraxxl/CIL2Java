using System;
using System.Collections.Generic;

namespace System.Reflection
{
    /// <summary>Contains static methods for retrieving custom attributes.</summary>
    public static class CustomAttributeExtensions
    {
        /// <summary>Retrieves a custom attribute of a specified type that is applied to a specified assembly.</summary><returns>A custom attribute that matches <paramref name="attributeType" />, or null if no such attribute is found.</returns><param name="element">The assembly to inspect.</param><param name="attributeType">The type of attribute to search for.</param>
        public static Attribute GetCustomAttribute(this Assembly element, Type attributeType)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Retrieves a custom attribute of a specified type that is applied to a specified module.</summary><returns>A custom attribute that matches <paramref name="attributeType" />, or null if no such attribute is found.</returns><param name="element">The module to inspect.</param><param name="attributeType">The type of attribute to search for.</param>
        public static Attribute GetCustomAttribute(this Module element, Type attributeType)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Retrieves a custom attribute of a specified type that is applied to a specified member.</summary><returns>A custom attribute that matches <paramref name="attributeType" />, or null if no such attribute is found.</returns><param name="element">The member to inspect.</param><param name="attributeType">The type of attribute to search for.</param>
        public static Attribute GetCustomAttribute(this MemberInfo element, Type attributeType)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Retrieves a custom attribute of a specified type that is applied to a specified parameter.</summary><returns>A custom attribute that matches <paramref name="attributeType" />, or null if no such attribute is found.</returns><param name="element">The parameter to inspect.</param><param name="attributeType">The type of attribute to search for.</param>
        public static Attribute GetCustomAttribute(this ParameterInfo element, Type attributeType)
        {
             throw new NotImplementedException();
        }
        
        
        public static T GetCustomAttribute<T>(this Assembly element)
        {
             throw new NotImplementedException();
        }
        
        
        public static T GetCustomAttribute<T>(this Module element)
        {
             throw new NotImplementedException();
        }
        
        
        public static T GetCustomAttribute<T>(this MemberInfo element)
        {
             throw new NotImplementedException();
        }
        
        
        public static T GetCustomAttribute<T>(this ParameterInfo element)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Retrieves a custom attribute of a specified type that is applied to a specified member, and optionally inspects the ancestors of that member.</summary><returns>A custom attribute that matches <paramref name="attributeType" />, or null if no such attribute is found.</returns><param name="element">The member to inspect.</param><param name="attributeType">The type of attribute to search for.</param><param name="inherit">true to inspect the ancestors of <paramref name="element" />; otherwise, false. </param>
        public static Attribute GetCustomAttribute(this MemberInfo element, Type attributeType, bool inherit)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Retrieves a custom attribute of a specified type that is applied to a specified parameter, and optionally inspects the ancestors of that parameter.</summary><returns>A custom attribute matching <paramref name="attributeType" />, or null if no such attribute is found.</returns><param name="element">The parameter to inspect.</param><param name="attributeType">The type of attribute to search for.</param><param name="inherit">true to inspect the ancestors of <paramref name="element" />; otherwise, false. </param>
        public static Attribute GetCustomAttribute(this ParameterInfo element, Type attributeType, bool inherit)
        {
             throw new NotImplementedException();
        }
        
        
        public static T GetCustomAttribute<T>(this MemberInfo element, bool inherit)
        {
             throw new NotImplementedException();
        }
        
        
        public static T GetCustomAttribute<T>(this ParameterInfo element, bool inherit)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Retrieves a collection of custom attributes that are applied to a specified assembly.</summary><returns>A collection of the custom attributes that are applied to <paramref name="element" />, or an empty collection if no such attributes exist.</returns><param name="element">The assembly to inspect.</param>
        public static IEnumerable<Attribute> GetCustomAttributes(this Assembly element)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Retrieves a collection of custom attributes that are applied to a specified module.</summary><returns>A collection of the custom attributes that are applied to <paramref name="element" />, or an empty collection if no such attributes exist.</returns><param name="element">The module to inspect.</param>
        public static IEnumerable<Attribute> GetCustomAttributes(this Module element)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Retrieves a collection of custom attributes that are applied to a specified member.</summary><returns>A collection of the custom attributes that are applied to <paramref name="element" />, or an empty collection if no such attributes exist.</returns><param name="element">The member to inspect.</param>
        public static IEnumerable<Attribute> GetCustomAttributes(this MemberInfo element)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Retrieves a collection of custom attributes that are applied to a specified parameter.</summary><returns>A collection of the custom attributes that are applied to <paramref name="element" />, or an empty collection if no such attributes exist.</returns><param name="element">The parameter to inspect.</param>
        public static IEnumerable<Attribute> GetCustomAttributes(this ParameterInfo element)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Retrieves a collection of custom attributes that are applied to a specified member, and optionally inspects the ancestors of that member.</summary><returns>A collection of the custom attributes that are applied to <paramref name="element" /> that match the specified criteria, or an empty collection if no such attributes exist.</returns><param name="element">The member to inspect.</param><param name="inherit">true to inspect the ancestors of <paramref name="element" />; otherwise, false. </param>
        public static IEnumerable<Attribute> GetCustomAttributes(this MemberInfo element, bool inherit)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Retrieves a collection of custom attributes that are applied to a specified parameter, and optionally inspects the ancestors of that parameter.</summary><returns>A collection of the custom attributes that are applied to <paramref name="element" />, or an empty collection if no such attributes exist.</returns><param name="element">The parameter to inspect.</param><param name="inherit">true to inspect the ancestors of <paramref name="element" />; otherwise, false. </param>
        public static IEnumerable<Attribute> GetCustomAttributes(this ParameterInfo element, bool inherit)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Retrieves a collection of custom attributes of a specified type that are applied to a specified assembly.</summary><returns>A collection of the custom attributes that are applied to <paramref name="element" /> and that match <paramref name="attributeType" />, or an empty collection if no such attributes exist.</returns><param name="element">The assembly to inspect.</param><param name="attributeType">The type of attribute to search for.</param>
        public static IEnumerable<Attribute> GetCustomAttributes(this Assembly element, Type attributeType)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Retrieves a collection of custom attributes of a specified type that are applied to a specified module.</summary><returns>A collection of the custom attributes that are applied to <paramref name="element" /> and that match <paramref name="attributeType" />, or an empty collection if no such attributes exist.</returns><param name="element">The module to inspect.</param><param name="attributeType">The type of attribute to search for.</param>
        public static IEnumerable<Attribute> GetCustomAttributes(this Module element, Type attributeType)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Retrieves a collection of custom attributes of a specified type that are applied to a specified member.</summary><returns>A collection of the custom attributes that are applied to <paramref name="element" /> and that match <paramref name="attributeType" />, or an empty collection if no such attributes exist.</returns><param name="element">The member to inspect.</param><param name="attributeType">The type of attribute to search for.</param>
        public static IEnumerable<Attribute> GetCustomAttributes(this MemberInfo element, Type attributeType)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Retrieves a collection of custom attributes of a specified type that are applied to a specified parameter.</summary><returns>A collection of the custom attributes that are applied to <paramref name="element" /> and that match <paramref name="attributeType" />, or an empty collection if no such attributes exist.</returns><param name="element">The parameter to inspect.</param><param name="attributeType">The type of attribute to search for.</param>
        public static IEnumerable<Attribute> GetCustomAttributes(this ParameterInfo element, Type attributeType)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Retrieves a collection of custom attributes that are applied to a specified assembly.</summary><returns>A collection of the custom attributes that are applied to <paramref name="element" />, or an empty collection if no such attributes exist.</returns><param name="element">The assembly to inspect.</param>
        public static IEnumerable<T> GetCustomAttributes<T>(this Assembly element)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Retrieves a collection of custom attributes that are applied to a specified module.</summary><returns>A collection of the custom attributes that are applied to <paramref name="element" />, or an empty collection if no such attributes exist.</returns><param name="element">The module to inspect.</param>
        public static IEnumerable<T> GetCustomAttributes<T>(this Module element)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Retrieves a collection of custom attributes that are applied to a specified member.</summary><returns>A collection of the custom attributes that are applied to <paramref name="element" />, or an empty collection if no such attributes exist.</returns><param name="element">The member to inspect.</param>
        public static IEnumerable<T> GetCustomAttributes<T>(this MemberInfo element)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Retrieves a collection of custom attributes that are applied to a specified parameter.</summary><returns>A collection of the custom attributes that are applied to <paramref name="element" />, or an empty collection if no such attributes exist.</returns><param name="element">The parameter to inspect.</param>
        public static IEnumerable<T> GetCustomAttributes<T>(this ParameterInfo element)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Retrieves a collection of custom attributes of a specified type that are applied to a specified member, and optionally inspects the ancestors of that member.</summary><returns>A collection of the custom attributes that are applied to <paramref name="element" /> and that match <paramref name="attributeType" />, or an empty collection if no such attributes exist.</returns><param name="element">The member to inspect.</param><param name="attributeType">The type of attribute to search for.</param><param name="inherit">true to inspect the ancestors of <paramref name="element" />; otherwise, false. </param>
        public static IEnumerable<Attribute> GetCustomAttributes(this MemberInfo element, Type attributeType, bool inherit)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Retrieves a collection of custom attributes of a specified type that are applied to a specified parameter, and optionally inspects the ancestors of that parameter.</summary><returns>A collection of the custom attributes that are applied to <paramref name="element" /> and that match <paramref name="attributeType" />, or an empty collection if no such attributes exist.</returns><param name="element">The parameter to inspect.</param><param name="attributeType">The type of attribute to search for.</param><param name="inherit">true to inspect the ancestors of <paramref name="element" />; otherwise, false. </param>
        public static IEnumerable<Attribute> GetCustomAttributes(this ParameterInfo element, Type attributeType, bool inherit)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Retrieves a collection of custom attributes that are applied to a specified member, and optionally inspects the ancestors of that member.</summary><returns>A collection of the custom attributes that are applied to <paramref name="element" /> that match the specified criteria, or an empty collection if no such attributes exist.</returns><param name="element">The member to inspect.</param><param name="inherit">true to inspect the ancestors of <paramref name="element" />; otherwise, false. </param>
        public static IEnumerable<T> GetCustomAttributes<T>(this MemberInfo element, bool inherit)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Retrieves a collection of custom attributes that are applied to a specified parameter, and optionally inspects the ancestors of that parameter.</summary><returns>A collection of the custom attributes that are applied to <paramref name="element" />, or an empty collection if no such attributes exist.</returns><param name="element">The parameter to inspect.</param><param name="inherit">true to inspect the ancestors of <paramref name="element" />; otherwise, false. </param>
        public static IEnumerable<T> GetCustomAttributes<T>(this ParameterInfo element, bool inherit)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Indicates whether custom attributes of a specified type are applied to a specified assembly.</summary><returns>true if an attribute of the specified type is applied to <paramref name="element" />; otherwise, false.</returns><param name="element">The assembly to inspect.</param><param name="attributeType">The type of the attribute to search for.</param>
        public static bool IsDefined(this Assembly element, Type attributeType)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Indicates whether custom attributes of a specified type are applied to a specified module.</summary><returns>true if an attribute of the specified type is applied to <paramref name="element" />; otherwise, false.</returns><param name="element">The module to inspect.</param><param name="attributeType">The type of attribute to search for.</param>
        public static bool IsDefined(this Module element, Type attributeType)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Indicates whether custom attributes of a specified type are applied to a specified member.</summary><returns>true if an attribute of the specified type is applied to <paramref name="element" />; otherwise, false.</returns><param name="element">The member to inspect.</param><param name="attributeType">The type of attribute to search for.</param>
        public static bool IsDefined(this MemberInfo element, Type attributeType)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Indicates whether custom attributes of a specified type are applied to a specified parameter.</summary><returns>true if an attribute of the specified type is applied to <paramref name="element" />; otherwise, false.</returns><param name="element">The parameter to inspect.</param><param name="attributeType">The type of attribute to search for.</param>
        public static bool IsDefined(this ParameterInfo element, Type attributeType)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Indicates whether custom attributes of a specified type are applied to a specified member, and, optionally, applied to its ancestors.</summary><returns>true if an attribute of the specified type is applied to <paramref name="element" />; otherwise, false.</returns><param name="element">The member to inspect.</param><param name="attributeType">The type of the attribute to search for.</param><param name="inherit">true to inspect the ancestors of <paramref name="element" />; otherwise, false. </param>
        public static bool IsDefined(this MemberInfo element, Type attributeType, bool inherit)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Indicates whether custom attributes of a specified type are applied to a specified parameter, and, optionally, applied to its ancestors.</summary><returns>true if an attribute of the specified type is applied to <paramref name="element" />; otherwise, false.</returns><param name="element">The parameter to inspect.</param><param name="attributeType">The type of attribute to search for.</param><param name="inherit">true to inspect the ancestors of <paramref name="element" />; otherwise, false. </param>
        public static bool IsDefined(this ParameterInfo element, Type attributeType, bool inherit)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
