using System;
using System.Runtime.InteropServices;

namespace System.ComponentModel.Design
{
    [FlagsAttribute()]
    [ComVisibleAttribute(true)]
    public enum SelectionTypes : int
    {
        Auto = 1,
        Normal = 1,
        Replace = 2,
        MouseDown = 4,
        MouseUp = 8,
        Click = 16,
        Primary = 16,
        Toggle = 32,
        Add = 64,
        Remove = 128,
        Valid = 31
    }
}
