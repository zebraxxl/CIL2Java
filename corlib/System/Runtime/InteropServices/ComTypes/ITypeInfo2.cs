using System.Runtime.InteropServices;
using System;

namespace System.Runtime.InteropServices.ComTypes
{
    /// <summary>Provides the managed definition of the ITypeInfo2 interface.</summary>
    [InterfaceTypeAttribute(ComInterfaceType.InterfaceIsIUnknown)]
    [GuidAttribute("00020412-0000-0000-C000-000000000046")]
    public interface ITypeInfo2 : ITypeInfo
    {
        new void GetTypeAttr(ref IntPtr ppTypeAttr);


        new void GetTypeComp(ref ITypeComp ppTComp);


        new void GetFuncDesc(int index, ref IntPtr ppFuncDesc);


        new void GetVarDesc(int index, ref IntPtr ppVarDesc);


        new void GetNames(int memid, string[] rgBstrNames, int cMaxNames, ref int pcNames);


        new void GetRefTypeOfImplType(int index, ref int href);


        new void GetImplTypeFlags(int index, ref IMPLTYPEFLAGS pImplTypeFlags);
        
        
        /// <summary>Maps between member names and member IDs, and parameter names and parameter IDs.</summary><param name="rgszNames">An array of names to map. </param><param name="cNames">The count of names to map. </param><param name="pMemId">When this method returns, contains a reference to an array in which name mappings are placed. This parameter is passed uninitialized.</param>
        new void GetIDsOfNames(string[] rgszNames, int cNames, int[] pMemId);


        new void Invoke(object pvInstance, int memid, short wFlags, ref DISPPARAMS pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, ref int puArgErr);


        new void GetDocumentation(int index, ref string strName, ref string strDocString, ref int dwHelpContext, ref string strHelpFile);
        
        
        /// <summary>Retrieves a description or specification of an entry point for a function in a DLL.</summary><param name="memid">The ID of the member function whose DLL entry description is to be returned. </param><param name="invKind">One of the <see cref="T:System.Runtime.InteropServices.ComTypes.INVOKEKIND" /> values that specifies the kind of member identified by <paramref name="memid" />. </param><param name="pBstrDllName">If not null, the function sets <paramref name="pBstrDllName" /> to a BSTR that contains the name of the DLL. </param><param name="pBstrName">If not null, the function sets <paramref name="lpbstrName" /> to a BSTR that contains the name of the entry point. </param><param name="pwOrdinal">If not null, and the function is defined by an ordinal, then <paramref name="lpwOrdinal" /> is set to point to the ordinal. </param>
        new void GetDllEntry(int memid, INVOKEKIND invKind, IntPtr pBstrDllName, IntPtr pBstrName, IntPtr pwOrdinal);


        new void GetRefTypeInfo(int hRef, ref ITypeInfo ppTI);


        new void AddressOfMember(int memid, INVOKEKIND invKind, ref IntPtr ppv);


        new void CreateInstance(object pUnkOuter, ref Guid riid, ref object ppvObj);


        new void GetMops(int memid, ref string pBstrMops);


        new void GetContainingTypeLib(ref ITypeLib ppTLB, ref int pIndex);
        
        
        /// <summary>Releases a <see cref="T:System.Runtime.InteropServices.TYPEATTR" /> structure previously returned by the <see cref="M:System.Runtime.InteropServices.ComTypes.ITypeInfo.GetTypeAttr(System.IntPtr@)" /> method.</summary><param name="pTypeAttr">A reference to the TYPEATTR structure to release. </param>
        new void ReleaseTypeAttr(IntPtr pTypeAttr);
        
        
        /// <summary>Releases a <see cref="T:System.Runtime.InteropServices.FUNCDESC" /> structure previously returned by the <see cref="M:System.Runtime.InteropServices.ComTypes.ITypeInfo.GetFuncDesc(System.Int32,System.IntPtr@)" /> method.</summary><param name="pFuncDesc">A reference to the FUNCDESC structure to release. </param>
        new void ReleaseFuncDesc(IntPtr pFuncDesc);
        
        
        /// <summary>Releases a VARDESC structure previously returned by the <see cref="M:System.Runtime.InteropServices.ComTypes.ITypeInfo.GetVarDesc(System.Int32,System.IntPtr@)" /> method.</summary><param name="pVarDesc">A reference to the VARDESC structure to release. </param>
        new void ReleaseVarDesc(IntPtr pVarDesc);
        
        
        void GetTypeKind(ref TYPEKIND pTypeKind);
        
        
        void GetTypeFlags(ref int pTypeFlags);
        
        
        void GetFuncIndexOfMemId(int memid, INVOKEKIND invKind, ref int pFuncIndex);
        
        
        void GetVarIndexOfMemId(int memid, ref int pVarIndex);
        
        
        void GetCustData(ref Guid guid, ref object pVarVal);
        
        
        void GetFuncCustData(int index, ref Guid guid, ref object pVarVal);
        
        
        void GetParamCustData(int indexFunc, int indexParam, ref Guid guid, ref object pVarVal);
        
        
        void GetVarCustData(int index, ref Guid guid, ref object pVarVal);
        
        
        void GetImplTypeCustData(int index, ref Guid guid, ref object pVarVal);
        
        
        [LCIDConversionAttribute(1)]
        void GetDocumentation2(int memid, ref string pbstrHelpString, ref int pdwHelpStringContext, ref string pbstrHelpStringDll);
        
        
        /// <summary>Gets all custom data items for the library.</summary><param name="pCustData">A pointer to CUSTDATA, which holds all custom data items. </param>
        void GetAllCustData(IntPtr pCustData);
        
        
        /// <summary>Gets all custom data from the specified function.</summary><param name="index">The index of the function to get the custom data for. </param><param name="pCustData">A pointer to CUSTDATA, which holds all custom data items. </param>
        void GetAllFuncCustData(int index, IntPtr pCustData);
        
        
        /// <summary>Gets all of the custom data for the specified function parameter.</summary><param name="indexFunc">The index of the function to get the custom data for. </param><param name="indexParam">The index of the parameter of this function to get the custom data for. </param><param name="pCustData">A pointer to CUSTDATA, which holds all custom data items. </param>
        void GetAllParamCustData(int indexFunc, int indexParam, IntPtr pCustData);
        
        
        /// <summary>Gets the variable for the custom data.</summary><param name="index">The index of the variable to get the custom data for. </param><param name="pCustData">A pointer to CUSTDATA, which holds all custom data items. </param>
        void GetAllVarCustData(int index, IntPtr pCustData);
        
        
        /// <summary>Gets all custom data for the specified implementation type.</summary><param name="index">The index of the implementation type for the custom data. </param><param name="pCustData">A pointer to CUSTDATA which holds all custom data items. </param>
        void GetAllImplTypeCustData(int index, IntPtr pCustData);
        
        
    }
}
