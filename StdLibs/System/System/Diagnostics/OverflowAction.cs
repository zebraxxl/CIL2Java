using System;

namespace System.Diagnostics
{
    public enum OverflowAction : int
    {
        DoNotOverwrite = -1,
        OverwriteAsNeeded = 0,
        OverwriteOlder = 1
    }
}
