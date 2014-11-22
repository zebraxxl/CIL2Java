using System.Runtime.InteropServices;
using System;

namespace System.Runtime.InteropServices.ComTypes
{
    /// <summary>Provides a managed definition of the ITypeLib2 interface.</summary>
    [InterfaceTypeAttribute(ComInterfaceType.InterfaceIsIUnknown)]
    [GuidAttribute("00020411-0000-0000-C000-000000000046")]
    public interface ITypeLib2 : ITypeLib
    {
        new int GetTypeInfoCount();


        new void GetTypeInfo(int index, ref ITypeInfo ppTI);


        new void GetTypeInfoType(int index, ref TYPEKIND pTKind);


        new void GetTypeInfoOfGuid(ref Guid guid, ref ITypeInfo ppTInfo);


        new void GetLibAttr(ref IntPtr ppTLibAttr);


        new void GetTypeComp(ref ITypeComp ppTComp);


        new void GetDocumentation(int index, ref string strName, ref string strDocString, ref int dwHelpContext, ref string strHelpFile);
        
        
        /// <summary>Indicates whether a passed-in string contains the name of a type or member described in the library.</summary><returns>true if <paramref name="szNameBuf" /> was found in the type library; otherwise, false.</returns><param name="szNameBuf">The string to test. </param><param name="lHashVal">The hash value of <paramref name="szNameBuf" />. </param>
        new bool IsName(string szNameBuf, int lHashVal);


        new void FindName(string szNameBuf, int lHashVal, ITypeInfo[] ppTInfo, int[] rgMemId, ref short pcFound);
        
        
        /// <summary>Releases the <see cref="T:System.Runtime.InteropServices.TYPELIBATTR" /> structure originally obtained from the <see cref="M:System.Runtime.InteropServices.ComTypes.ITypeLib.GetLibAttr(System.IntPtr@)" /> method.</summary><param name="pTLibAttr">The TLIBATTR structure to release. </param>
        new void ReleaseTLibAttr(IntPtr pTLibAttr);
        
        
        void GetCustData(ref Guid guid, ref object pVarVal);
        
        
        [LCIDConversionAttribute(1)]
        void GetDocumentation2(int index, ref string pbstrHelpString, ref int pdwHelpStringContext, ref string pbstrHelpStringDll);
        
        
        void GetLibStatistics(IntPtr pcUniqueNames, ref int pcchUniqueNames);
        
        
        /// <summary>Gets all custom data items for the library.</summary><param name="pCustData">A pointer to CUSTDATA, which holds all custom data items. </param>
        void GetAllCustData(IntPtr pCustData);
        
        
    }
}
