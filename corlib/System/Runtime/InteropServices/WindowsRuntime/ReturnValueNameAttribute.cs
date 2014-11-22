using System;

namespace System.Runtime.InteropServices.WindowsRuntime
{
    /// <summary>Specifies the name of the return value of a method in a Windows Runtime component. </summary>
    [AttributeUsageAttribute(AttributeTargets.Delegate|AttributeTargets.ReturnValue, AllowMultiple = false, Inherited = false)]
    public sealed class ReturnValueNameAttribute : Attribute
    {
    
        /// <summary>Gets the name that was specified for the return value of a method in a Windows Runtime component.</summary><returns>The name of the method's return value. </returns>
        public string Name
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Runtime.InteropServices.WindowsRuntime.ReturnValueNameAttribute" /> class, and specifies the name of the return value.</summary><param name="name">The name of the return value. </param>
        public ReturnValueNameAttribute(string name)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
