using System.Runtime.InteropServices;
using System;

namespace System.Runtime.InteropServices.ComTypes
{
    /// <summary>Provides the managed definition of the ITypeLib interface.</summary>
    [InterfaceTypeAttribute(ComInterfaceType.InterfaceIsIUnknown)]
    [GuidAttribute("00020402-0000-0000-C000-000000000046")]
    public interface ITypeLib
    {
        int GetTypeInfoCount();
        
        
        void GetTypeInfo(int index, ref ITypeInfo ppTI);
        
        
        void GetTypeInfoType(int index, ref TYPEKIND pTKind);
        
        
        void GetTypeInfoOfGuid(ref Guid guid, ref ITypeInfo ppTInfo);
        
        
        void GetLibAttr(ref IntPtr ppTLibAttr);
        
        
        void GetTypeComp(ref ITypeComp ppTComp);
        
        
        void GetDocumentation(int index, ref string strName, ref string strDocString, ref int dwHelpContext, ref string strHelpFile);
        
        
        /// <summary>Indicates whether a passed-in string contains the name of a type or member described in the library.</summary><returns>true if <paramref name="szNameBuf" /> was found in the type library; otherwise, false.</returns><param name="szNameBuf">The string to test. This is an in/out parameter.</param><param name="lHashVal">The hash value of <paramref name="szNameBuf" />. </param>
        bool IsName(string szNameBuf, int lHashVal);
        
        
        void FindName(string szNameBuf, int lHashVal, ITypeInfo[] ppTInfo, int[] rgMemId, ref short pcFound);
        
        
        /// <summary>Releases the <see cref="T:System.Runtime.InteropServices.TYPELIBATTR" /> structure originally obtained from the <see cref="M:System.Runtime.InteropServices.ComTypes.ITypeLib.GetLibAttr(System.IntPtr@)" /> method.</summary><param name="pTLibAttr">The TLIBATTR structure to release. </param>
        void ReleaseTLibAttr(IntPtr pTLibAttr);
        
        
    }
}
