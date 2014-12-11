using System.Runtime.InteropServices;
using System;

namespace System.ComponentModel
{
    [ComVisibleAttribute(true)]
    public enum DesignerSerializationVisibility : int
    {
        Hidden = 0,
        Visible = 1,
        Content = 2
    }
}
