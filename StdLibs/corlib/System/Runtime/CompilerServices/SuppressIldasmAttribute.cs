using System;

namespace System.Runtime.CompilerServices
{
    /// <summary>Prevents the Ildasm.exe (MSIL Disassembler) from disassembling an assembly. This class cannot be inherited.</summary>
    [AttributeUsageAttribute(AttributeTargets.Assembly|AttributeTargets.Module)]
    public sealed class SuppressIldasmAttribute : Attribute
    {
        public SuppressIldasmAttribute()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
