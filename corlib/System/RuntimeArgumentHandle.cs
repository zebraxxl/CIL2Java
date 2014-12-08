using CIL2Java.Attributes;
using System.Runtime.InteropServices;

namespace System
{
    /// <summary>References a variable-length argument list.</summary><filterpriority>2</filterpriority>
    [ComVisibleAttribute(true)]
    public struct RuntimeArgumentHandle
    {
        internal object[] varArgParams;

        [AlwaysCompile]
        internal RuntimeArgumentHandle(object[] varArgParams)
        {
            this.varArgParams = varArgParams;
        }
    }
}
