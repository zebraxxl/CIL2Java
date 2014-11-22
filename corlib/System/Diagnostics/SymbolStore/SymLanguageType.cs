using System.Runtime.InteropServices;
using System;

namespace System.Diagnostics.SymbolStore
{
    /// <summary>Holds the public GUIDs for language types to be used with the symbol store.</summary>
    [ComVisibleAttribute(true)]
    public class SymLanguageType
    {
        /// <summary>Specifies the GUID of the C language type to be used with the symbol store.</summary>
        public static readonly Guid C;
        /// <summary>Specifies the GUID of the C++ language type to be used with the symbol store.</summary>
        public static readonly Guid CPlusPlus;
        /// <summary>Specifies the GUID of the C# language type to be used with the symbol store.</summary>
        public static readonly Guid CSharp;
        /// <summary>Specifies the GUID of the Basic language type to be used with the symbol store.</summary>
        public static readonly Guid Basic;
        /// <summary>Specifies the GUID of the Java language type to be used with the symbol store.</summary>
        public static readonly Guid Java;
        /// <summary>Specifies the GUID of the Cobol language type to be used with the symbol store.</summary>
        public static readonly Guid Cobol;
        /// <summary>Specifies the GUID of the Pascal language type to be used with the symbol store.</summary>
        public static readonly Guid Pascal;
        /// <summary>Specifies the GUID of the ILAssembly language type to be used with the symbol store.</summary>
        public static readonly Guid ILAssembly;
        /// <summary>Specifies the GUID of the JScript language type to be used with the symbol store.</summary>
        public static readonly Guid JScript;
        /// <summary>Specifies the GUID of the SMC language type to be used with the symbol store.</summary>
        public static readonly Guid SMC;
        /// <summary>Specifies the GUID of the C++ language type to be used with the symbol store.</summary>
        public static readonly Guid MCPlusPlus;
    
        public SymLanguageType()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
