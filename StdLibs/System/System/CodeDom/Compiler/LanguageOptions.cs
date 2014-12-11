using System;

namespace System.CodeDom.Compiler
{
    [Serializable]
    [FlagsAttribute()]
    public enum LanguageOptions : int
    {
        None = 0,
        CaseInsensitive = 1
    }
}
