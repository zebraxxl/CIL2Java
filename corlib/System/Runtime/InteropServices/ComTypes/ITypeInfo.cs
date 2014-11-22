using System.Runtime.InteropServices;
using System;

namespace System.Runtime.InteropServices.ComTypes
{
    /// <summary>Provides the managed definition of the Component Automation ITypeInfo interface.</summary>
    [GuidAttribute("00020401-0000-0000-C000-000000000046")]
    [InterfaceTypeAttribute(ComInterfaceType.InterfaceIsIUnknown)]
    public interface ITypeInfo
    {
        void GetTypeAttr(ref IntPtr ppTypeAttr);
        
        
        void GetTypeComp(ref ITypeComp ppTComp);
        
        
        void GetFuncDesc(int index, ref IntPtr ppFuncDesc);
        
        
        void GetVarDesc(int index, ref IntPtr ppVarDesc);
        
        
        void GetNames(int memid, string[] rgBstrNames, int cMaxNames, ref int pcNames);
        
        
        void GetRefTypeOfImplType(int index, ref int href);
        
        
        void GetImplTypeFlags(int index, ref IMPLTYPEFLAGS pImplTypeFlags);
        
        
        /// <summary>Maps between member names and member IDs, and parameter names and parameter IDs.</summary><param name="rgszNames">An array of names to map. </param><param name="cNames">The count of names to map. </param><param name="pMemId">When this method returns, contains a reference to an array in which name mappings are placed. This parameter is passed uninitialized.</param>
        void GetIDsOfNames(string[] rgszNames, int cNames, int[] pMemId);
        
        
        void Invoke(object pvInstance, int memid, short wFlags, ref DISPPARAMS pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, ref int puArgErr);
        
        
        void GetDocumentation(int index, ref string strName, ref string strDocString, ref int dwHelpContext, ref string strHelpFile);
        
        
        /// <summary>Retrieves a description or specification of an entry point for a function in a DLL.</summary><param name="memid">The ID of the member function whose DLL entry description is to be returned. </param><param name="invKind">One of the <see cref="T:System.Runtime.InteropServices.ComTypes.INVOKEKIND" /> values that specifies the kind of member identified by <paramref name="memid" />. </param><param name="pBstrDllName">If not null, the function sets <paramref name="pBstrDllName" /> to a BSTR that contains the name of the DLL. </param><param name="pBstrName">If not null, the function sets <paramref name="lpbstrName" /> to a BSTR that contains the name of the entry point. </param><param name="pwOrdinal">If not null, and the function is defined by an ordinal, then <paramref name="lpwOrdinal" /> is set to point to the ordinal. </param>
        void GetDllEntry(int memid, INVOKEKIND invKind, IntPtr pBstrDllName, IntPtr pBstrName, IntPtr pwOrdinal);
        
        
        void GetRefTypeInfo(int hRef, ref ITypeInfo ppTI);
        
        
        void AddressOfMember(int memid, INVOKEKIND invKind, ref IntPtr ppv);
        
        
        void CreateInstance(object pUnkOuter, ref Guid riid, ref object ppvObj);
        
        
        void GetMops(int memid, ref string pBstrMops);
        
        
        void GetContainingTypeLib(ref ITypeLib ppTLB, ref int pIndex);
        
        
        /// <summary>Releases a <see cref="T:System.Runtime.InteropServices.TYPEATTR" /> structure previously returned by the <see cref="M:System.Runtime.InteropServices.ComTypes.ITypeInfo.GetTypeAttr(System.IntPtr@)" /> method.</summary><param name="pTypeAttr">A reference to the TYPEATTR structure to release. </param>
        void ReleaseTypeAttr(IntPtr pTypeAttr);
        
        
        /// <summary>Releases a <see cref="T:System.Runtime.InteropServices.FUNCDESC" /> structure previously returned by the <see cref="M:System.Runtime.InteropServices.ComTypes.ITypeInfo.GetFuncDesc(System.Int32,System.IntPtr@)" /> method.</summary><param name="pFuncDesc">A reference to the FUNCDESC structure to release. </param>
        void ReleaseFuncDesc(IntPtr pFuncDesc);
        
        
        /// <summary>Releases a VARDESC structure previously returned by the <see cref="M:System.Runtime.InteropServices.ComTypes.ITypeInfo.GetVarDesc(System.Int32,System.IntPtr@)" /> method.</summary><param name="pVarDesc">A reference to the VARDESC structure to release. </param>
        void ReleaseVarDesc(IntPtr pVarDesc);
        
        
    }
}
