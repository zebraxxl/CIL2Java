using System;

namespace System.Linq.Expressions
{
    public enum GotoExpressionKind : int
    {
        Goto = 0,
        Return = 1,
        Break = 2,
        Continue = 3
    }
}
