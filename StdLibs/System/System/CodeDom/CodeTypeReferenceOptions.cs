using System.Runtime.InteropServices;
using System;

namespace System.CodeDom
{
    [Serializable]
    [ComVisibleAttribute(true)]
    [FlagsAttribute()]
    public enum CodeTypeReferenceOptions : int
    {
        GlobalReference = 1,
        GenericTypeParameter = 2
    }
}
