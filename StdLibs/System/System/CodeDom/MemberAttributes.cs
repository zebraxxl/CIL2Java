using System.Runtime.InteropServices;
using System;

namespace System.CodeDom
{
    [Serializable]
    [ComVisibleAttribute(true)]
    public enum MemberAttributes : int
    {
        Abstract = 1,
        Final = 2,
        Static = 3,
        Override = 4,
        Const = 5,
        New = 16,
        Overloaded = 256,
        Assembly = 4096,
        FamilyAndAssembly = 8192,
        Family = 12288,
        FamilyOrAssembly = 16384,
        Private = 20480,
        Public = 24576,
        AccessMask = 61440,
        ScopeMask = 15,
        VTableMask = 240
    }
}
