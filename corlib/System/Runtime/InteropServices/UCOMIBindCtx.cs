using System;

namespace System.Runtime.InteropServices
{
    /// <summary>Use <see cref="T:System.Runtime.InteropServices.ComTypes.BIND_OPTS" /> instead.</summary>
    [ObsoleteAttribute("Use System.Runtime.InteropServices.ComTypes.IBindCtx instead. http://go.microsoft.com/fwlink/?linkid=14202", false)]
    [GuidAttribute("0000000e-0000-0000-C000-000000000046")]
    [InterfaceTypeAttribute(ComInterfaceType.InterfaceIsIUnknown)]
    public interface UCOMIBindCtx
    {
        /// <summary>Register the passed object as one of the objects that has been bound during a moniker operation and which should be released when it is complete.</summary><param name="punk">The object to register for release. </param>
        void RegisterObjectBound(object punk);
        
        
        /// <summary>Removes the object from the set of registered objects that need to be released.</summary><param name="punk">The object to unregister for release. </param>
        void RevokeObjectBound(object punk);
        
        
        void ReleaseBoundObjects();
        
        
        void SetBindOptions(ref BIND_OPTS pbindopts);
        
        
        void GetBindOptions(ref BIND_OPTS pbindopts);
        
        
        void GetRunningObjectTable(ref UCOMIRunningObjectTable pprot);
        
        
        /// <summary>Register the given object pointer under the specified name in the internally-maintained table of object pointers.</summary><param name="pszKey">The name to register <paramref name="punk" /> with. </param><param name="punk">The object to register. </param>
        void RegisterObjectParam(string pszKey, object punk);
        
        
        void GetObjectParam(string pszKey, ref object ppunk);
        
        
        void EnumObjectParam(ref UCOMIEnumString ppenum);
        
        
        /// <summary>Revoke the registration of the object currently found under this key in the internally-maintained table of contextual object parameters, if any such key is currently registered.</summary><param name="pszKey">The key to unregister. </param>
        void RevokeObjectParam(string pszKey);
        
        
    }
}
