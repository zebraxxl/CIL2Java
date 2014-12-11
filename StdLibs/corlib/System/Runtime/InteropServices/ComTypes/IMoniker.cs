using System.Runtime.InteropServices;
using System;

namespace System.Runtime.InteropServices.ComTypes
{
    /// <summary>Provides the managed definition of the IMoniker interface, with COM functionality from IPersist and IPersistStream.</summary>
    [GuidAttribute("0000000f-0000-0000-C000-000000000046")]
    [InterfaceTypeAttribute(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IMoniker
    {
        void GetClassID(ref Guid pClassID);
        
        
        int IsDirty();
        
        
        /// <summary>Initializes an object from the stream where it was previously saved.</summary><param name="pStm">The stream that the object is loaded from. </param>
        void Load(IStream pStm);
        
        
        /// <summary>Saves an object to the specified stream.</summary><param name="pStm">The stream to which the object is saved. </param><param name="fClearDirty">true to clear the modified flag after the save is complete; otherwise false</param>
        void Save(IStream pStm, bool fClearDirty);
        
        
        void GetSizeMax(ref long pcbSize);
        
        
        void BindToObject(IBindCtx pbc, IMoniker pmkToLeft, ref Guid riidResult, ref object ppvResult);
        
        
        void BindToStorage(IBindCtx pbc, IMoniker pmkToLeft, ref Guid riid, ref object ppvObj);
        
        
        void Reduce(IBindCtx pbc, int dwReduceHowFar, ref IMoniker ppmkToLeft, ref IMoniker ppmkReduced);
        
        
        void ComposeWith(IMoniker pmkRight, bool fOnlyIfNotGeneric, ref IMoniker ppmkComposite);
        
        
        void Enum(bool fForward, ref IEnumMoniker ppenumMoniker);
        
        
        /// <summary>Compares the current moniker with a specified moniker and indicates whether they are identical.</summary><returns>An S_OKHRESULT value if the monikers are identical; otherwise, an S_FALSEHRESULT value.  </returns><param name="pmkOtherMoniker">A reference to the moniker to use for comparison. </param>
        int IsEqual(IMoniker pmkOtherMoniker);
        
        
        void Hash(ref int pdwHash);
        
        
        /// <summary>Determines whether the object that is identified by the current moniker is currently loaded and running.</summary><returns>An S_OKHRESULT value if the moniker is running; an S_FALSEHRESULT value if the moniker is not running; or an E_UNEXPECTEDHRESULT value.</returns><param name="pbc">A reference to the bind context to use in this binding operation. </param><param name="pmkToLeft">A reference to the moniker to the left of the current moniker if the current moniker is part of a composite. </param><param name="pmkNewlyRunning">A reference to the moniker most recently added to the Running Object Table (ROT). </param>
        int IsRunning(IBindCtx pbc, IMoniker pmkToLeft, IMoniker pmkNewlyRunning);
        
        
        void GetTimeOfLastChange(IBindCtx pbc, IMoniker pmkToLeft, ref FILETIME pFileTime);
        
        
        void Inverse(ref IMoniker ppmk);
        
        
        void CommonPrefixWith(IMoniker pmkOther, ref IMoniker ppmkPrefix);
        
        
        void RelativePathTo(IMoniker pmkOther, ref IMoniker ppmkRelPath);
        
        
        void GetDisplayName(IBindCtx pbc, IMoniker pmkToLeft, ref string ppszDisplayName);
        
        
        void ParseDisplayName(IBindCtx pbc, IMoniker pmkToLeft, string pszDisplayName, ref int pchEaten, ref IMoniker ppmkOut);
        
        
        int IsSystemMoniker(ref int pdwMksys);
        
        
    }
}
