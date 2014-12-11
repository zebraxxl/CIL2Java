using System;
using System.Runtime.InteropServices;

namespace System.Diagnostics
{
    /// <summary>Indicates to compilers that a method call or attribute should be ignored unless a specified conditional compilation symbol is defined.</summary><filterpriority>1</filterpriority>
    [Serializable]
    [AttributeUsageAttribute(AttributeTargets.Class|AttributeTargets.Method, AllowMultiple = true)]
    [ComVisibleAttribute(true)]
    public sealed class ConditionalAttribute : Attribute
    {
    
        /// <summary>Gets the conditional compilation symbol that is associated with the <see cref="T:System.Diagnostics.ConditionalAttribute" /> attribute.</summary><returns>A string that specifies the case-sensitive conditional compilation symbol that is associated with the <see cref="T:System.Diagnostics.ConditionalAttribute" /> attribute.</returns><filterpriority>2</filterpriority>
        public string ConditionString
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.ConditionalAttribute" /> class.</summary><param name="conditionString">A string that specifies the case-sensitive conditional compilation symbol that is associated with the attribute. </param>
        public ConditionalAttribute(string conditionString)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
