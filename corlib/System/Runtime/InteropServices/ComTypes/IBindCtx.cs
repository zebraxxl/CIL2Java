using System.Runtime.InteropServices;

namespace System.Runtime.InteropServices.ComTypes
{
    /// <summary>Provides the managed definition of the IBindCtx interface.</summary>
    [InterfaceTypeAttribute(ComInterfaceType.InterfaceIsIUnknown)]
    [GuidAttribute("0000000e-0000-0000-C000-000000000046")]
    public interface IBindCtx
    {
        /// <summary>Registers the passed object as one of the objects that has been bound during a moniker operation and that should be released when the operation is complete.</summary><param name="punk">The object to register for release. </param>
        void RegisterObjectBound(object punk);
        
        
        /// <summary>Removes the object from the set of registered objects that need to be released.</summary><param name="punk">The object to unregister for release. </param>
        void RevokeObjectBound(object punk);
        
        
        void ReleaseBoundObjects();
        
        
        void SetBindOptions(ref BIND_OPTS pbindopts);
        
        
        void GetBindOptions(ref BIND_OPTS pbindopts);
        
        
        void GetRunningObjectTable(ref IRunningObjectTable pprot);
        
        
        /// <summary>Registers the specified object pointer under the specified name in the internally maintained table of object pointers.</summary><param name="pszKey">The name to register <paramref name="punk" /> with. </param><param name="punk">The object to register. </param>
        void RegisterObjectParam(string pszKey, object punk);
        
        
        void GetObjectParam(string pszKey, ref object ppunk);
        
        
        void EnumObjectParam(ref IEnumString ppenum);
        
        
        /// <summary>Revokes the registration of the object currently found under the specified key in the internally maintained table of contextual object parameters, if that key is currently registered.</summary><returns>An S_OKHRESULT value if the specified key was successfully removed from the table; otherwise, an S_FALSEHRESULT value.</returns><param name="pszKey">The key to unregister. </param>
        int RevokeObjectParam(string pszKey);
        
        
    }
}
