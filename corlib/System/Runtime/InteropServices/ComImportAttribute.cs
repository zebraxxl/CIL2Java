using System;

namespace System.Runtime.InteropServices
{
    /// <summary>Indicates that the attributed type was previously defined in COM.</summary>
    [ComVisibleAttribute(true)]
    [AttributeUsageAttribute(AttributeTargets.Class|AttributeTargets.Interface, Inherited = false)]
    public sealed class ComImportAttribute : Attribute
    {
        public ComImportAttribute()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
