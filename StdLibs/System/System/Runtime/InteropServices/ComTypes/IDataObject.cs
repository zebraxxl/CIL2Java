using System.Runtime.InteropServices;

namespace System.Runtime.InteropServices.ComTypes
{
    [InterfaceTypeAttribute(ComInterfaceType.InterfaceIsIUnknown)]
    [GuidAttribute("0000010E-0000-0000-C000-000000000046")]
    public interface IDataObject
    {
        void GetData(ref FORMATETC format, ref STGMEDIUM medium);
        
        
        void GetDataHere(ref FORMATETC format, ref STGMEDIUM medium);
        
        
        int QueryGetData(ref FORMATETC format);
        
        
        int GetCanonicalFormatEtc(ref FORMATETC formatIn, ref FORMATETC formatOut);
        
        
        void SetData(ref FORMATETC formatIn, ref STGMEDIUM medium, bool release);
        
        
        IEnumFORMATETC EnumFormatEtc(DATADIR direction);
        
        
        int DAdvise(ref FORMATETC pFormatetc, ADVF advf, IAdviseSink adviseSink, ref int connection);
        
        
        void DUnadvise(int connection);
        
        
        int EnumDAdvise(ref IEnumSTATDATA enumAdvise);
        
        
    }
}
