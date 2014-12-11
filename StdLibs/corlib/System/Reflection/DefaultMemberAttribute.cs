using System;
using System.Runtime.InteropServices;

namespace System.Reflection
{
    /// <summary>Defines the member of a type that is the default member used by <see cref="M:System.Type.InvokeMember(System.String,System.Reflection.BindingFlags,System.Reflection.Binder,System.Object,System.Object[],System.Reflection.ParameterModifier[],System.Globalization.CultureInfo,System.String[])" />. </summary>
    [Serializable]
    [AttributeUsageAttribute(AttributeTargets.Class|AttributeTargets.Struct|AttributeTargets.Interface)]
    [ComVisibleAttribute(true)]
    public sealed class DefaultMemberAttribute : Attribute
    {
    
        /// <summary>Gets the name from the attribute.</summary><returns>A string representing the member name.</returns>
        public string MemberName
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Reflection.DefaultMemberAttribute" /> class.</summary><param name="memberName">A String containing the name of the member to invoke. This may be a constructor, method, property, or field. A suitable invocation attribute must be specified when the member is invoked. The default member of a class can be specified by passing an empty String as the name of the member.The default member of a type is marked with the DefaultMemberAttribute custom attribute or marked in COM in the usual way. </param>
        public DefaultMemberAttribute(string memberName)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
