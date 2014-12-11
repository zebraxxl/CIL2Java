using System.Runtime.InteropServices;
using System.Security;
using System;

namespace System.Reflection.Emit
{
    /// <summary>Provides a fast way to swap method body implementation given a method of a class.</summary>
    [ComVisibleAttribute(true)]
    [ClassInterfaceAttribute(ClassInterfaceType.None)]
    [ComDefaultInterfaceAttribute(typeof(_MethodRental))]
    public sealed class MethodRental : _MethodRental
    {
        /// <summary>Specifies that the method should be just-in-time (JIT) compiled when needed.</summary>
        public const int JitOnDemand = 0;
        /// <summary>Specifies that the method should be just-in-time (JIT) compiled immediately.</summary>
        public const int JitImmediate = 1;
    
        /// <summary>Swaps the body of a method.</summary><param name="cls">The class containing the method. </param><param name="methodtoken">The token for the method. </param><param name="rgIL">A pointer to the method. This should include the method header. </param><param name="methodSize">The size of the new method body in bytes. </param><param name="flags">Flags that control the swapping. See the definitions of the constants. </param><exception cref="T:System.ArgumentNullException"><paramref name="cls" /> is null. </exception><exception cref="T:System.NotSupportedException">The type <paramref name="cls" /> is not complete. </exception><exception cref="T:System.ArgumentException"><paramref name="methodSize" /> is less than one or greater than 4128767 (3effff hex).</exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public static void SwapMethodBody(Type cls, int methodtoken, IntPtr rgIL, int methodSize, int flags)
        {
             throw new NotImplementedException();
        }



        void _MethodRental.GetTypeInfoCount(ref uint pcTInfo)
        {
            throw new NotImplementedException();
        }

        void _MethodRental.GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo)
        {
            throw new NotImplementedException();
        }

        void _MethodRental.GetIDsOfNames(ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId)
        {
            throw new NotImplementedException();
        }

        void _MethodRental.Invoke(uint dispIdMember, ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr)
        {
            throw new NotImplementedException();
        }
    }
}
