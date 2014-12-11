using System;

namespace System.Runtime.InteropServices
{
    /// <summary>Provides custom wrappers for handling method calls.</summary>
    [ComVisibleAttribute(true)]
    public interface ICustomMarshaler
    {
        /// <summary>Converts the unmanaged data to managed data.</summary><returns>An object that represents the managed view of the COM data.</returns><param name="pNativeData">A pointer to the unmanaged data to be wrapped. </param>
        object MarshalNativeToManaged(IntPtr pNativeData);
        
        
        /// <summary>Converts the managed data to unmanaged data.</summary><returns>A pointer to the COM view of the managed object.</returns><param name="ManagedObj">The managed object to be converted. </param>
        IntPtr MarshalManagedToNative(object ManagedObj);
        
        
        /// <summary>Performs necessary cleanup of the unmanaged data when it is no longer needed.</summary><param name="pNativeData">A pointer to the unmanaged data to be destroyed. </param>
        void CleanUpNativeData(IntPtr pNativeData);
        
        
        /// <summary>Performs necessary cleanup of the managed data when it is no longer needed.</summary><param name="ManagedObj">The managed object to be destroyed. </param>
        void CleanUpManagedData(object ManagedObj);
        
        
        int GetNativeDataSize();
        
        
    }
}
