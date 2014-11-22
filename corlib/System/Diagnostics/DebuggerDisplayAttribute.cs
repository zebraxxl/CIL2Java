using System.Runtime.InteropServices;
using System;

namespace System.Diagnostics
{
    /// <summary>Determines how a class or field is displayed in the debugger variable windows.</summary><filterpriority>1</filterpriority>
    [ComVisibleAttribute(true)]
    [AttributeUsageAttribute(AttributeTargets.Assembly|AttributeTargets.Class|AttributeTargets.Struct|AttributeTargets.Enum|AttributeTargets.Property|AttributeTargets.Field|AttributeTargets.Delegate, AllowMultiple = true)]
    public sealed class DebuggerDisplayAttribute : Attribute
    {
    
        /// <summary>Gets the string to display in the value column of the debugger variable windows.</summary><returns>The string to display in the value column of the debugger variable.</returns><filterpriority>2</filterpriority>
        public string Value
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the name to display in the debugger variable windows.</summary><returns>The name to display in the debugger variable windows.</returns><filterpriority>2</filterpriority>
        public string Name
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the string to display in the type column of the debugger variable windows.</summary><returns>The string to display in the type column of the debugger variable windows.</returns><filterpriority>2</filterpriority>
        public string Type
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the type of the attribute's target.</summary><returns>The attribute's target type.</returns><exception cref="T:System.ArgumentNullException"><see cref="P:System.Diagnostics.DebuggerDisplayAttribute.Target" /> is set to null.</exception><filterpriority>2</filterpriority>
        public Type Target
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the type name of the attribute's target.</summary><returns>The name of the attribute's target type.</returns><filterpriority>2</filterpriority>
        public string TargetTypeName
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.DebuggerDisplayAttribute" /> class. </summary><param name="value">The string to be displayed in the value column for instances of the type; an empty string ("") causes the value column to be hidden.</param>
        public DebuggerDisplayAttribute(string value)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
