using System.Runtime.InteropServices;
using System;

namespace System.CodeDom
{
    [Serializable]
    [ComVisibleAttribute(true)]
    public enum FieldDirection : int
    {
        In = 0,
        Out = 1,
        Ref = 2
    }
}
