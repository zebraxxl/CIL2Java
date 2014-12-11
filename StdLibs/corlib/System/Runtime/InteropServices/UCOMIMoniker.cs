using System;

namespace System.Runtime.InteropServices
{
    /// <summary>Use <see cref="T:System.Runtime.InteropServices.ComTypes.IMoniker" /> instead.</summary>
    [ObsoleteAttribute("Use System.Runtime.InteropServices.ComTypes.IMoniker instead. http://go.microsoft.com/fwlink/?linkid=14202", false)]
    [GuidAttribute("0000000f-0000-0000-C000-000000000046")]
    [InterfaceTypeAttribute(ComInterfaceType.InterfaceIsIUnknown)]
    public interface UCOMIMoniker
    {
        void GetClassID(ref Guid pClassID);
        
        
        int IsDirty();
        
        
        /// <summary>Initializes an object from the stream where it was previously saved.</summary><param name="pStm">Stream from which the object is loaded. </param>
        void Load(UCOMIStream pStm);
        
        
        /// <summary>Saves an object to the specified stream.</summary><param name="pStm">The stream into which the object is saved. </param><param name="fClearDirty">Indicates whether to clear the modified flag after the save is complete. </param>
        void Save(UCOMIStream pStm, bool fClearDirty);
        
        
        void GetSizeMax(ref long pcbSize);
        
        
        void BindToObject(UCOMIBindCtx pbc, UCOMIMoniker pmkToLeft, ref Guid riidResult, ref object ppvResult);
        
        
        void BindToStorage(UCOMIBindCtx pbc, UCOMIMoniker pmkToLeft, ref Guid riid, ref object ppvObj);
        
        
        void Reduce(UCOMIBindCtx pbc, int dwReduceHowFar, ref UCOMIMoniker ppmkToLeft, ref UCOMIMoniker ppmkReduced);
        
        
        void ComposeWith(UCOMIMoniker pmkRight, bool fOnlyIfNotGeneric, ref UCOMIMoniker ppmkComposite);
        
        
        void Enum(bool fForward, ref UCOMIEnumMoniker ppenumMoniker);
        
        
        /// <summary>Compares this moniker with a specified moniker and indicates whether they are identical.</summary><param name="pmkOtherMoniker">A reference to the moniker to be used for comparison. </param>
        void IsEqual(UCOMIMoniker pmkOtherMoniker);
        
        
        void Hash(ref int pdwHash);
        
        
        /// <summary>Determines whether the object that is identified by this moniker is currently loaded and running.</summary><param name="pbc">A reference to the bind context to be used in this binding operation. </param><param name="pmkToLeft">A reference to the moniker to the left of this moniker if this moniker is part of a composite. </param><param name="pmkNewlyRunning">A reference to the moniker most recently added to the Running Object Table. </param>
        void IsRunning(UCOMIBindCtx pbc, UCOMIMoniker pmkToLeft, UCOMIMoniker pmkNewlyRunning);
        
        
        void GetTimeOfLastChange(UCOMIBindCtx pbc, UCOMIMoniker pmkToLeft, ref FILETIME pFileTime);
        
        
        void Inverse(ref UCOMIMoniker ppmk);
        
        
        void CommonPrefixWith(UCOMIMoniker pmkOther, ref UCOMIMoniker ppmkPrefix);
        
        
        void RelativePathTo(UCOMIMoniker pmkOther, ref UCOMIMoniker ppmkRelPath);
        
        
        void GetDisplayName(UCOMIBindCtx pbc, UCOMIMoniker pmkToLeft, ref string ppszDisplayName);
        
        
        void ParseDisplayName(UCOMIBindCtx pbc, UCOMIMoniker pmkToLeft, string pszDisplayName, ref int pchEaten, ref UCOMIMoniker ppmkOut);
        
        
        void IsSystemMoniker(ref int pdwMksys);
        
        
    }
}
