using System;

namespace System.Runtime.InteropServices
{
    /// <summary>Use <see cref="T:System.Runtime.InteropServices.ComTypes.ITypeLib" /> instead.</summary>
    [ObsoleteAttribute("Use System.Runtime.InteropServices.ComTypes.ITypeLib instead. http://go.microsoft.com/fwlink/?linkid=14202", false)]
    [GuidAttribute("00020402-0000-0000-C000-000000000046")]
    [InterfaceTypeAttribute(ComInterfaceType.InterfaceIsIUnknown)]
    public interface UCOMITypeLib
    {
        int GetTypeInfoCount();
        
        
        void GetTypeInfo(int index, ref UCOMITypeInfo ppTI);
        
        
        void GetTypeInfoType(int index, ref TYPEKIND pTKind);
        
        
        void GetTypeInfoOfGuid(ref Guid guid, ref UCOMITypeInfo ppTInfo);
        
        
        void GetLibAttr(ref IntPtr ppTLibAttr);
        
        
        void GetTypeComp(ref UCOMITypeComp ppTComp);
        
        
        void GetDocumentation(int index, ref string strName, ref string strDocString, ref int dwHelpContext, ref string strHelpFile);
        
        
        /// <summary>Indicates whether a passed-in string contains the name of a type or member described in the library.</summary><returns>true if <paramref name="szNameBuf" /> was found in the type library; otherwise false.</returns><param name="szNameBuf">The string to test. </param><param name="lHashVal">The hash value of <paramref name="szNameBuf" />. </param>
        bool IsName(string szNameBuf, int lHashVal);
        
        
        void FindName(string szNameBuf, int lHashVal, UCOMITypeInfo[] ppTInfo, int[] rgMemId, ref short pcFound);
        
        
        /// <summary>Releases the <see cref="T:System.Runtime.InteropServices.TYPELIBATTR" /> originally obtained from <see cref="M:System.Runtime.InteropServices.UCOMITypeLib.GetLibAttr(System.IntPtr@)" />.</summary><param name="pTLibAttr">The TLIBATTR to release. </param>
        void ReleaseTLibAttr(IntPtr pTLibAttr);
        
        
    }
}
