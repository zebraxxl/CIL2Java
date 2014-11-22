using System.Runtime.InteropServices;
using System.Reflection;
using System;

namespace System.Runtime.InteropServices.Expando
{
    /// <summary>Enables modification of objects by adding and removing members, represented by <see cref="T:System.Reflection.MemberInfo" /> objects.</summary>
    [GuidAttribute("AFBF15E6-C37C-11d2-B88E-00A0C9B471B8")]
    [ComVisibleAttribute(true)]
    public interface IExpando : IReflect
    {
        /// <summary>Adds the named field to the Reflection object.</summary><returns>A <see cref="T:System.Reflection.FieldInfo" /> object representing the added field.</returns><param name="name">The name of the field. </param><exception cref="T:System.NotSupportedException">The IExpando object does not support this method. </exception>
        FieldInfo AddField(string name);
        
        
        /// <summary>Adds the named property to the Reflection object.</summary><returns>A PropertyInfo object representing the added property.</returns><param name="name">The name of the property. </param><exception cref="T:System.NotSupportedException">The IExpando object does not support this method. </exception>
        PropertyInfo AddProperty(string name);
        
        
        /// <summary>Adds the named method to the Reflection object.</summary><returns>A MethodInfo object representing the added method.</returns><param name="name">The name of the method. </param><param name="method">The delegate to the method. </param><exception cref="T:System.NotSupportedException">The IExpando object does not support this method. </exception>
        MethodInfo AddMethod(string name, Delegate method);
        
        
        /// <summary>Removes the specified member.</summary><param name="m">The member to remove. </param><exception cref="T:System.NotSupportedException">The IExpando object does not support this method. </exception>
        void RemoveMember(MemberInfo m);
        
        
    }
}
