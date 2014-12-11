using System.Runtime.InteropServices;
using System;

namespace System.CodeDom
{
    [Serializable]
    [ComVisibleAttribute(true)]
    public enum CodeRegionMode : int
    {
        None = 0,
        Start = 1,
        End = 2
    }
}
