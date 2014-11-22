using System.Security;
using System;

namespace System.Runtime.InteropServices.WindowsRuntime
{
    /// <summary>Provides helper methods for marshaling data between the .NET Framework and the Windows Runtime.</summary>
    public static class WindowsRuntimeMarshal
    {
        [SecurityCriticalAttribute()]
        public static void AddEventHandler<T>(Func<T, EventRegistrationToken> addMethod, Action<EventRegistrationToken> removeMethod, T handler)
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        public static void RemoveEventHandler<T>(Action<EventRegistrationToken> removeMethod, T handler)
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        public static void RemoveAllEventHandlers(Action<EventRegistrationToken> removeMethod)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns an object that implements the activation factory interface for the specified Windows Runtime type. </summary><returns>An object that implements the activation factory interface. </returns><param name="type">The Windows Runtime type to get the activation factory interface for. </param><exception cref="T:System.ArgumentException"><paramref name="type" /> does not represent a Windows Runtime type (that is, belonging to the Windows Runtime itself or defined in a Windows Runtime component). -or-The object specified for <paramref name="type" /> was not provided by the common language runtime type system. </exception><exception cref="T:System.ArgumentNullException"><paramref name="type" /> is null. </exception><exception cref="T:System.TypeLoadException">The specified Windows Runtime class is not properly registered. For example, the .winmd file was located, but the Windows Runtime failed to locate the implementation. </exception>
        [SecurityCriticalAttribute()]
        public static IActivationFactory GetActivationFactory(Type type)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Allocates a Windows Runtime HSTRING and copies the specified managed string to it. </summary><returns>An unmanaged pointer to the new HSTRING, or <see cref="F:System.IntPtr.Zero" /> if <paramref name="s" /> is <see cref="F:System.String.Empty" />. </returns><param name="s">The managed string to copy. </param><exception cref="T:System.PlatformNotSupportedException">The Windows Runtime is not supported on the current version of the operating system. </exception><exception cref="T:System.ArgumentNullException"><paramref name="s" /> is null. </exception>
        [SecurityCriticalAttribute()]
        public static IntPtr StringToHString(string s)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a managed string that contains a copy of the specified Windows Runtime HSTRING. </summary><returns>A managed string that contains a copy of the HSTRING if <paramref name="ptr" /> is not <see cref="F:System.IntPtr.Zero" />; otherwise, <see cref="F:System.String.Empty" />. </returns><param name="ptr">An unmanaged pointer to the HSTRING to copy. </param><exception cref="T:System.PlatformNotSupportedException">The Windows Runtime is not supported on the current version of the operating system. </exception>
        [SecurityCriticalAttribute()]
        public static string PtrToStringHString(IntPtr ptr)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Frees the specified Windows Runtime HSTRING. </summary><param name="ptr">The address of the HSTRING to free.</param><exception cref="T:System.PlatformNotSupportedException">The Windows Runtime is not supported on the current version of the operating system. </exception>
        [SecurityCriticalAttribute()]
        public static void FreeHString(IntPtr ptr)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
