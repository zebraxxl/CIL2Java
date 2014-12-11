using System;

namespace System.Security
{
    /// <summary>Specifies that an assembly cannot cause an elevation of privilege. </summary>
    [AttributeUsageAttribute(AttributeTargets.Assembly, AllowMultiple = false, Inherited = false)]
    public sealed class SecurityTransparentAttribute : Attribute
    {
        public SecurityTransparentAttribute()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
