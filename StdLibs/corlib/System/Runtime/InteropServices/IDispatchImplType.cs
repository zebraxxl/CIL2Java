using System;

namespace System.Runtime.InteropServices
{
    /// <summary>Indicates which IDispatch implementation to use for a particular class.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    [ObsoleteAttribute("The IDispatchImplAttribute is deprecated.", false)]
    public enum IDispatchImplType : int
    {
        /// <summary>Specifies that the common language runtime decides which IDispatch implementation to use.</summary>
        SystemDefinedImpl = 0,
        /// <summary>Specifies that the IDispatch implemenation is supplied by the runtime.</summary>
        InternalImpl = 1,
        /// <summary>Specifies that the IDispatch implementation is supplied by passing the type information for the object to the COM CreateStdDispatch API method.</summary>
        CompatibleImpl = 2
    }
}
