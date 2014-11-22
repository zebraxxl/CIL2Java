using System;

namespace System.Runtime.InteropServices
{
    /// <summary>Use <see cref="T:System.Runtime.InteropServices.ComTypes.ITypeInfo" /> instead.</summary>
    [ObsoleteAttribute("Use System.Runtime.InteropServices.ComTypes.ITypeInfo instead. http://go.microsoft.com/fwlink/?linkid=14202", false)]
    [InterfaceTypeAttribute(ComInterfaceType.InterfaceIsIUnknown)]
    [GuidAttribute("00020401-0000-0000-C000-000000000046")]
    public interface UCOMITypeInfo
    {
        void GetTypeAttr(ref IntPtr ppTypeAttr);
        
        
        void GetTypeComp(ref UCOMITypeComp ppTComp);
        
        
        void GetFuncDesc(int index, ref IntPtr ppFuncDesc);
        
        
        void GetVarDesc(int index, ref IntPtr ppVarDesc);
        
        
        void GetNames(int memid, string[] rgBstrNames, int cMaxNames, ref int pcNames);
        
        
        void GetRefTypeOfImplType(int index, ref int href);
        
        
        void GetImplTypeFlags(int index, ref int pImplTypeFlags);
        
        
        /// <summary>Maps between member names and member IDs, and parameter names and parameter IDs.</summary><param name="rgszNames">On succesful return, an array of names to map. </param><param name="cNames">Count of names to map. </param><param name="pMemId">Reference to an array in which name mappings are placed. </param>
        void GetIDsOfNames(string[] rgszNames, int cNames, int[] pMemId);
        
        
        void Invoke(object pvInstance, int memid, short wFlags, ref DISPPARAMS pDispParams, ref object pVarResult, ref EXCEPINFO pExcepInfo, ref int puArgErr);
        
        
        void GetDocumentation(int index, ref string strName, ref string strDocString, ref int dwHelpContext, ref string strHelpFile);
        
        
        void GetDllEntry(int memid, INVOKEKIND invKind, ref string pBstrDllName, ref string pBstrName, ref short pwOrdinal);
        
        
        void GetRefTypeInfo(int hRef, ref UCOMITypeInfo ppTI);
        
        
        void AddressOfMember(int memid, INVOKEKIND invKind, ref IntPtr ppv);
        
        
        void CreateInstance(object pUnkOuter, ref Guid riid, ref object ppvObj);
        
        
        void GetMops(int memid, ref string pBstrMops);
        
        
        void GetContainingTypeLib(ref UCOMITypeLib ppTLB, ref int pIndex);
        
        
        /// <summary>Releases a <see cref="T:System.Runtime.InteropServices.TYPEATTR" /> previously returned by <see cref="M:System.Runtime.InteropServices.UCOMITypeInfo.GetTypeAttr(System.IntPtr@)" />.</summary><param name="pTypeAttr">Reference to the TYPEATTR to release. </param>
        void ReleaseTypeAttr(IntPtr pTypeAttr);
        
        
        /// <summary>Releases a <see cref="T:System.Runtime.InteropServices.FUNCDESC" /> previously returned by <see cref="M:System.Runtime.InteropServices.UCOMITypeInfo.GetFuncDesc(System.Int32,System.IntPtr@)" />.</summary><param name="pFuncDesc">Reference to the FUNCDESC to release. </param>
        void ReleaseFuncDesc(IntPtr pFuncDesc);
        
        
        /// <summary>Releases a VARDESC previously returned by <see cref="M:System.Runtime.InteropServices.UCOMITypeInfo.GetVarDesc(System.Int32,System.IntPtr@)" />.</summary><param name="pVarDesc">Reference to the VARDESC to release. </param>
        void ReleaseVarDesc(IntPtr pVarDesc);
        
        
    }
}
