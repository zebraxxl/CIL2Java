using System.Runtime.InteropServices;
using System;

namespace System.ComponentModel.Design
{
    [ComVisibleAttribute(true)]
    public enum ViewTechnology : int
    {
        Passthrough = 0,
        WindowsForms = 1,
        Default = 2
    }
}
