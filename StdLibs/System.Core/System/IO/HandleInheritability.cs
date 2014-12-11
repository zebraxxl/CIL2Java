using System;

namespace System.IO
{
    [Serializable]
    public enum HandleInheritability : int
    {
        None = 0,
        Inheritable = 1
    }
}
