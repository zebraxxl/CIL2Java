using System.Security;
using System;
using System.Runtime.ConstrainedExecution;
using System.Reflection;
using System.Threading;
using System.Runtime.InteropServices.ComTypes;

namespace System.Runtime.InteropServices
{
    /// <summary>Provides a collection of methods for allocating unmanaged memory, copying unmanaged memory blocks, and converting managed to unmanaged types, as well as other miscellaneous methods used when interacting with unmanaged code.</summary>
    public static class Marshal
    {
        /// <summary>Represents the default character size on the system; the default is 2 for Unicode systems and 1 for ANSI systems. This field is read-only.</summary>
        public static readonly int SystemDefaultCharSize;
        /// <summary>Represents the maximum size of a double byte character set (DBCS) size, in bytes, for the current operating system. This field is read-only.</summary>
        public static readonly int SystemMaxDBCSCharSize;
    
        /// <summary>Copies all characters up to the first null character from an unmanaged ANSI string to a managed <see cref="T:System.String" />, and widens each ANSI character to Unicode.</summary><returns>A managed string that holds a copy of the unmanaged ANSI string. If <paramref name="ptr" /> is null, the method returns a null string.</returns><param name="ptr">The address of the first character of the unmanaged string.</param><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static string PtrToStringAnsi(IntPtr ptr)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Allocates a managed <see cref="T:System.String" />, copies a specified number of characters from an unmanaged ANSI string into it, and widens each ANSI character to Unicode.</summary><returns>A managed string that holds a copy of the native ANSI string if the value of the <paramref name="ptr" /> parameter is not null; otherwise, this method returns null.</returns><param name="ptr">The address of the first character of the unmanaged string.</param><param name="len">The byte count of the input string to copy.</param><exception cref="T:System.ArgumentException"><paramref name="len" /> is less than zero.</exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static string PtrToStringAnsi(IntPtr ptr, int len)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Allocates a managed <see cref="T:System.String" /> and copies a specified number of characters from an unmanaged Unicode string into it.</summary><returns>A managed string that holds a copy of the unmanaged string if the value of the <paramref name="ptr" /> parameter is not null; otherwise, this method returns null.</returns><param name="ptr">The address of the first character of the unmanaged string.</param><param name="len">The number of Unicode characters to copy.</param><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static string PtrToStringUni(IntPtr ptr, int len)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Allocates a managed <see cref="T:System.String" /> and copies the specified number of characters from a string stored in unmanaged memory into it.</summary><returns>A managed string that holds a copy of the native string if the value of the <paramref name="ptr" /> parameter is not null; otherwise, this method returns null.</returns><param name="ptr">For Unicode platforms, the address of the first Unicode character.-or- For ANSI plaforms, the address of the first ANSI character.</param><param name="len">The number of characters to copy.</param><exception cref="T:System.ArgumentException"><paramref name="len" /> is less than zero.</exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static string PtrToStringAuto(IntPtr ptr, int len)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Allocates a managed <see cref="T:System.String" /> and copies all characters up to the first null character from an unmanaged Unicode string into it.</summary><returns>A managed string that holds a copy of the unmanaged string if the value of the <paramref name="ptr" /> parameter is not null; otherwise, this method returns null.</returns><param name="ptr">The address of the first character of the unmanaged string.</param><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static string PtrToStringUni(IntPtr ptr)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Allocates a managed <see cref="T:System.String" /> and copies all characters up to the first null character from a string stored in unmanaged memory into it.</summary><returns>A managed string that holds a copy of the unmanaged string if the value of the <paramref name="ptr" /> parameter is not null; otherwise, this method returns null.</returns><param name="ptr">For Unicode platforms, the address of the first Unicode character.-or- For ANSI plaforms, the address of the first ANSI character.</param><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static string PtrToStringAuto(IntPtr ptr)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the unmanaged size of an object in bytes.</summary><returns>The size of the specified object in unmanaged code.</returns><param name="structure">The object whose size is to be returned.</param><exception cref="T:System.ArgumentNullException">The <paramref name="structure" /> parameter is null.</exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [ComVisibleAttribute(true)]
        public static int SizeOf(object structure)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the size of an unmanaged type in bytes.</summary><returns>The size of the specified type in unmanaged code.</returns><param name="t">The type whose size is to be returned.</param><exception cref="T:System.ArgumentException">The <paramref name="t" /> parameter is a generic type.</exception><exception cref="T:System.ArgumentNullException">The <paramref name="t" /> parameter is null.</exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        public static int SizeOf(Type t)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the field offset of the unmanaged form of the managed class.</summary><returns>The offset, in bytes, for the <paramref name="fieldName" /> parameter within the specified class that is declared by platform invoke.</returns><param name="t">A value type or formatted reference type that specifies the managed class. You must apply the <see cref="T:System.Runtime.InteropServices.StructLayoutAttribute" /> to the class.</param><param name="fieldName">The field within the <paramref name="t" /> parameter.</param><exception cref="T:System.ArgumentException">The class cannot be exported as a structure or the field is nonpublic. Beginning with the .NET Framework version 2.0, the field may be private.</exception><exception cref="T:System.ArgumentNullException">The <paramref name="t" /> parameter is null.</exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        public static IntPtr OffsetOf(Type t, string fieldName)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Gets the address of the element at the specified index inside the specified array.</summary><returns>The address of <paramref name="index" /> inside <paramref name="arr" />.</returns><param name="arr">The array that contains the desired element.</param><param name="index">The index in the <paramref name="arr" /> parameter of the desired element.</param><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static IntPtr UnsafeAddrOfPinnedArrayElement(Array arr, int index)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Copies data from a one-dimensional, managed 32-bit signed integer array to an unmanaged memory pointer.</summary><param name="source">The one-dimensional array to copy from.</param><param name="startIndex">The zero-based index in the source array where copying should start.</param><param name="destination">The memory pointer to copy to.</param><param name="length">The number of array elements to copy.</param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="startIndex" /> and <paramref name="length" /> are not valid.</exception><exception cref="T:System.ArgumentNullException"><paramref name="startIndex" /> or <paramref name="length" /> is null.</exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static void Copy(int[] source, int startIndex, IntPtr destination, int length)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Copies data from a one-dimensional, managed character array to an unmanaged memory pointer.</summary><param name="source">The one-dimensional array to copy from.</param><param name="startIndex">The zero-based index in the source array where copying should start.</param><param name="destination">The memory pointer to copy to.</param><param name="length">The number of array elements to copy.</param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="startIndex" /> and <paramref name="length" /> are not valid.</exception><exception cref="T:System.ArgumentNullException"><paramref name="startIndex" />, <paramref name="destination" />, or <paramref name="length" /> is null.</exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static void Copy(char[] source, int startIndex, IntPtr destination, int length)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Copies data from a one-dimensional, managed 16-bit signed integer array to an unmanaged memory pointer.</summary><param name="source">The one-dimensional array to copy from.</param><param name="startIndex">The zero-based index in the source array where copying should start.</param><param name="destination">The memory pointer to copy to.</param><param name="length">The number of array elements to copy.</param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="startIndex" /> and <paramref name="length" /> are not valid.</exception><exception cref="T:System.ArgumentNullException"><paramref name="source" />, <paramref name="startIndex" />, <paramref name="destination" />, or <paramref name="length" /> is null.</exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static void Copy(short[] source, int startIndex, IntPtr destination, int length)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Copies data from a one-dimensional, managed 64-bit signed integer array to an unmanaged memory pointer.</summary><param name="source">The one-dimensional array to copy from.</param><param name="startIndex">The zero-based index in the source array where copying should start.</param><param name="destination">The memory pointer to copy to.</param><param name="length">The number of array elements to copy.</param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="startIndex" /> and <paramref name="length" /> are not valid.</exception><exception cref="T:System.ArgumentNullException"><paramref name="source" />, <paramref name="startIndex" />, <paramref name="destination" />, or <paramref name="length" /> is null.</exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static void Copy(long[] source, int startIndex, IntPtr destination, int length)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Copies data from a one-dimensional, managed single-precision floating-point number array to an unmanaged memory pointer.</summary><param name="source">The one-dimensional array to copy from. </param><param name="startIndex">The zero-based index in the source array where copying should start. </param><param name="destination">The memory pointer to copy to. </param><param name="length">The number of array elements to copy. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="startIndex" /> and <paramref name="length" /> are not valid. </exception><exception cref="T:System.ArgumentNullException"><paramref name="source" />, <paramref name="startIndex" />, <paramref name="destination" />, or <paramref name="length" /> is null. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static void Copy(float[] source, int startIndex, IntPtr destination, int length)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Copies data from a one-dimensional, managed double-precision floating-point number array to an unmanaged memory pointer.</summary><param name="source">The one-dimensional array to copy from.</param><param name="startIndex">The zero-based index in the source array where copying should start.</param><param name="destination">The memory pointer to copy to.</param><param name="length">The number of array elements to copy.</param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="startIndex" /> and <paramref name="length" /> are not valid.</exception><exception cref="T:System.ArgumentNullException"><paramref name="source" />, <paramref name="startIndex" />, <paramref name="destination" />, or <paramref name="length" /> is null.</exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static void Copy(double[] source, int startIndex, IntPtr destination, int length)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Copies data from a one-dimensional, managed 8-bit unsigned integer array to an unmanaged memory pointer.</summary><param name="source">The one-dimensional array to copy from.</param><param name="startIndex">The zero-based index in the source array where copying should start.</param><param name="destination">The memory pointer to copy to.</param><param name="length">The number of array elements to copy.</param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="startIndex" /> and <paramref name="length" /> are not valid.</exception><exception cref="T:System.ArgumentNullException"><paramref name="source" />, <paramref name="startIndex" />, <paramref name="destination" />, or <paramref name="length" /> is null.</exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static void Copy(byte[] source, int startIndex, IntPtr destination, int length)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Copies data from a one-dimensional, managed <see cref="T:System.IntPtr" /> array to an unmanaged memory pointer.</summary><param name="source">The one-dimensional array to copy from.</param><param name="startIndex">The zero-based index in the source array where copying should start.</param><param name="destination">The memory pointer to copy to.</param><param name="length">The number of array elements to copy.</param><exception cref="T:System.ArgumentNullException"><paramref name="source" />, <paramref name="destination" />, <paramref name="startIndex" />, or <paramref name="length" /> is null.</exception>
        [SecurityCriticalAttribute()]
        public static void Copy(IntPtr[] source, int startIndex, IntPtr destination, int length)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Copies data from an unmanaged memory pointer to a managed 32-bit signed integer array.</summary><param name="source">The memory pointer to copy from.</param><param name="destination">The array to copy to.</param><param name="startIndex">The zero-based index in the destination array where copying should start.</param><param name="length">The number of array elements to copy.</param><exception cref="T:System.ArgumentNullException"><paramref name="source" />, <paramref name="destination" />, <paramref name="startIndex" />, or <paramref name="length" /> is null.</exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static void Copy(IntPtr source, int[] destination, int startIndex, int length)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Copies data from an unmanaged memory pointer to a managed character array.</summary><param name="source">The memory pointer to copy from.</param><param name="destination">The array to copy to.</param><param name="startIndex">The zero-based index in the destination array where copying should start.</param><param name="length">The number of array elements to copy.</param><exception cref="T:System.ArgumentNullException"><paramref name="source" />, <paramref name="destination" />, <paramref name="startIndex" />, or <paramref name="length" /> is null.</exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static void Copy(IntPtr source, char[] destination, int startIndex, int length)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Copies data from an unmanaged memory pointer to a managed 16-bit signed integer array.</summary><param name="source">The memory pointer to copy from.</param><param name="destination">The array to copy to.</param><param name="startIndex">The zero-based index in the destination array where copying should start.</param><param name="length">The number of array elements to copy.</param><exception cref="T:System.ArgumentNullException"><paramref name="source" />, <paramref name="destination" />, <paramref name="startIndex" />, or <paramref name="length" /> is null.</exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static void Copy(IntPtr source, short[] destination, int startIndex, int length)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Copies data from an unmanaged memory pointer to a managed 64-bit signed integer array.</summary><param name="source">The memory pointer to copy from.</param><param name="destination">The array to copy to.</param><param name="startIndex">The zero-based index in the destination array where copying should start.</param><param name="length">The number of array elements to copy.</param><exception cref="T:System.ArgumentNullException"><paramref name="source" />, <paramref name="destination" />, <paramref name="startIndex" />, or <paramref name="length" /> is null.</exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static void Copy(IntPtr source, long[] destination, int startIndex, int length)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Copies data from an unmanaged memory pointer to a managed single-precision floating-point number array.</summary><param name="source">The memory pointer to copy from. </param><param name="destination">The array to copy to. </param><param name="startIndex">The zero-based index in the destination array where copying should start. </param><param name="length">The number of array elements to copy. </param><exception cref="T:System.ArgumentNullException"><paramref name="source" />, <paramref name="destination" />, <paramref name="startIndex" />, or <paramref name="length" /> is null. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static void Copy(IntPtr source, float[] destination, int startIndex, int length)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Copies data from an unmanaged memory pointer to a managed double-precision floating-point number array.</summary><param name="source">The memory pointer to copy from.</param><param name="destination">The array to copy to.</param><param name="startIndex">The zero-based index in the destination array where copying should start.</param><param name="length">The number of array elements to copy.</param><exception cref="T:System.ArgumentNullException"><paramref name="source" />, <paramref name="destination" />, <paramref name="startIndex" />, or <paramref name="length" /> is null.</exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static void Copy(IntPtr source, double[] destination, int startIndex, int length)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Copies data from an unmanaged memory pointer to a managed 8-bit unsigned integer array.</summary><param name="source">The memory pointer to copy from.</param><param name="destination">The array to copy to.</param><param name="startIndex">The zero-based index in the destination array where copying should start.</param><param name="length">The number of array elements to copy.</param><exception cref="T:System.ArgumentNullException"><paramref name="source" />, <paramref name="destination" />, <paramref name="startIndex" />, or <paramref name="length" /> is null.</exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static void Copy(IntPtr source, byte[] destination, int startIndex, int length)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Copies data from an unmanaged memory pointer to a managed <see cref="T:System.IntPtr" /> array.</summary><param name="source">The memory pointer to copy from. </param><param name="destination">The array to copy to.</param><param name="startIndex">The zero-based index in the destination array where copying should start.</param><param name="length">The number of array elements to copy.</param><exception cref="T:System.ArgumentNullException"><paramref name="source" />, <paramref name="destination" />, <paramref name="startIndex" />, or <paramref name="length" /> is null.</exception>
        [SecurityCriticalAttribute()]
        public static void Copy(IntPtr source, IntPtr[] destination, int startIndex, int length)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Reads a single byte at a given offset (or index) from unmanaged memory. </summary><returns>The byte read from unmanaged memory at the given offset.</returns><param name="ptr">The base address in unmanaged memory of the source object.</param><param name="ofs">An additional byte offset, which is added to the <paramref name="ptr" /> parameter before reading.</param><exception cref="T:System.AccessViolationException">Base address (<paramref name="ptr" />) plus offset byte (<paramref name="ofs" />) produces a null or invalid address.</exception><exception cref="T:System.ArgumentException"><paramref name="ptr" /> is an <see cref="T:System.Runtime.InteropServices.ArrayWithOffset" /> object. This method does not accept <see cref="T:System.Runtime.InteropServices.ArrayWithOffset" /> parameters.</exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SuppressUnmanagedCodeSecurityAttribute()]
        [SecurityCriticalAttribute()]
        public static byte ReadByte(object ptr, int ofs)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Reads a single byte at a given offset (or index) from unmanaged memory.</summary><returns>The byte read from unmanaged memory at the given offset.</returns><param name="ptr">The base address in unmanaged memory from which to read.</param><param name="ofs">An additional byte offset, which is added to the <paramref name="ptr" /> parameter before reading.</param><exception cref="T:System.AccessViolationException">Base address (<paramref name="ptr" />) plus offset byte (<paramref name="ofs" />) produces a null or invalid address.</exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static byte ReadByte(IntPtr ptr, int ofs)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Reads a single byte from unmanaged memory.</summary><returns>The byte read from unmanaged memory.</returns><param name="ptr">The address in unmanaged memory from which to read.</param><exception cref="T:System.AccessViolationException"><paramref name="ptr" /> is not a recognized format.-or-<paramref name="ptr" /> is null. -or-<paramref name="ptr" /> is invalid.</exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static byte ReadByte(IntPtr ptr)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Reads a 16-bit signed integer at a given offset from unmanaged memory.</summary><returns>The 16-bit signed integer read from unmanaged memory at the given offset.</returns><param name="ptr">The base address in unmanaged memory of the source object.</param><param name="ofs">An additional byte offset, which is added to the <paramref name="ptr" /> parameter before reading.</param><exception cref="T:System.AccessViolationException">Base address (<paramref name="ptr" />) plus offset byte (<paramref name="ofs" />) produces a null or invalid address.</exception><exception cref="T:System.ArgumentException"><paramref name="ptr" /> is an <see cref="T:System.Runtime.InteropServices.ArrayWithOffset" /> object. This method does not accept <see cref="T:System.Runtime.InteropServices.ArrayWithOffset" /> parameters.</exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SuppressUnmanagedCodeSecurityAttribute()]
        [SecurityCriticalAttribute()]
        public static short ReadInt16(object ptr, int ofs)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Reads a 16-bit signed integer at a given offset from unmanaged memory.</summary><returns>The 16-bit signed integer read from unmanaged memory at the given offset.</returns><param name="ptr">The base address in unmanaged memory from which to read.</param><param name="ofs">An additional byte offset, which is added to the <paramref name="ptr" /> parameter before reading.</param><exception cref="T:System.AccessViolationException">Base address (<paramref name="ptr" />) plus offset byte (<paramref name="ofs" />) produces a null or invalid address.</exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static short ReadInt16(IntPtr ptr, int ofs)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Reads a 16-bit signed integer from unmanaged memory.</summary><returns>The 16-bit signed integer read from unmanaged memory.</returns><param name="ptr">The address in unmanaged memory from which to read.</param><exception cref="T:System.AccessViolationException"><paramref name="ptr" /> is not a recognized format.-or-<paramref name="ptr" /> is null.-or-<paramref name="ptr" /> is invalid.</exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static short ReadInt16(IntPtr ptr)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Reads a 32-bit signed integer at a given offset from unmanaged memory.</summary><returns>The 32-bit signed integer read from unmanaged memory at the given offset.</returns><param name="ptr">The base address in unmanaged memory of the source object.</param><param name="ofs">An additional byte offset, which is added to the <paramref name="ptr" /> parameter before reading.</param><exception cref="T:System.AccessViolationException">Base address (<paramref name="ptr" />) plus offset byte (<paramref name="ofs" />) produces a null or invalid address.</exception><exception cref="T:System.ArgumentException"><paramref name="ptr" /> is an <see cref="T:System.Runtime.InteropServices.ArrayWithOffset" /> object. This method does not accept <see cref="T:System.Runtime.InteropServices.ArrayWithOffset" /> parameters.</exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecurityCriticalAttribute()]
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.Success)]
        [SuppressUnmanagedCodeSecurityAttribute()]
        public static int ReadInt32(object ptr, int ofs)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Reads a 32-bit signed integer at a given offset from unmanaged memory.</summary><returns>The 32-bit signed integer read from unmanaged memory.</returns><param name="ptr">The base address in unmanaged memory from which to read.</param><param name="ofs">An additional byte offset, which is added to the <paramref name="ptr" /> parameter before reading.</param><exception cref="T:System.AccessViolationException">Base address (<paramref name="ptr" />) plus offset byte (<paramref name="ofs" />) produces a null or invalid address.</exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecurityCriticalAttribute()]
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.Success)]
        public static int ReadInt32(IntPtr ptr, int ofs)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Reads a 32-bit signed integer from unmanaged memory.</summary><returns>The 32-bit signed integer read from unmanaged memory.</returns><param name="ptr">The address in unmanaged memory from which to read.</param><exception cref="T:System.AccessViolationException"><paramref name="ptr" /> is not a recognized format.-or-<paramref name="ptr" /> is null.-or-<paramref name="ptr" /> is invalid.</exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.Success)]
        [SecurityCriticalAttribute()]
        public static int ReadInt32(IntPtr ptr)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Reads a processor native sized integer from unmanaged memory.</summary><returns>The integer read from unmanaged memory at the given offset.</returns><param name="ptr">The base address in unmanaged memory of the source object.</param><param name="ofs">An additional byte offset, which is added to the <paramref name="ptr" /> parameter before reading.</param><exception cref="T:System.AccessViolationException">Base address (<paramref name="ptr" />) plus offset byte (<paramref name="ofs" />) produces a null or invalid address.</exception><exception cref="T:System.ArgumentException"><paramref name="ptr" /> is an <see cref="T:System.Runtime.InteropServices.ArrayWithOffset" /> object. This method does not accept <see cref="T:System.Runtime.InteropServices.ArrayWithOffset" /> parameters.</exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.Success)]
        [SecurityCriticalAttribute()]
        public static IntPtr ReadIntPtr(object ptr, int ofs)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Reads a processor native sized integer at a given offset from unmanaged memory.</summary><returns>The integer read from unmanaged memory at the given offset.</returns><param name="ptr">The base address in unmanaged memory from which to read.</param><param name="ofs">An additional byte offset, which is added to the <paramref name="ptr" /> parameter before reading.</param><exception cref="T:System.AccessViolationException">Base address (<paramref name="ptr" />) plus offset byte (<paramref name="ofs" />) produces a null or invalid address.</exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.Success)]
        [SecurityCriticalAttribute()]
        public static IntPtr ReadIntPtr(IntPtr ptr, int ofs)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Reads a processor native-sized integer from unmanaged memory.</summary><returns>The integer read from unmanaged memory. A 32 bit integer is returned on 32 bit machines and a 64 bit integer is returned on 64 bit machines.</returns><param name="ptr">The address in unmanaged memory from which to read.</param><exception cref="T:System.AccessViolationException"><paramref name="ptr" /> is not a recognized format.-or-<paramref name="ptr" /> is null. -or-<paramref name="ptr" /> is invalid.</exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecurityCriticalAttribute()]
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.Success)]
        public static IntPtr ReadIntPtr(IntPtr ptr)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Reads a 64-bit signed integer at a given offset from unmanaged memory.</summary><returns>The 64-bit signed integer read from unmanaged memory at the given offset.</returns><param name="ptr">The base address in unmanaged memory of the source object.</param><param name="ofs">An additional byte offset, which is added to the <paramref name="ptr" /> parameter before reading.</param><exception cref="T:System.AccessViolationException">Base address (<paramref name="ptr" />) plus offset byte (<paramref name="ofs" />) produces a null or invalid address.</exception><exception cref="T:System.ArgumentException"><paramref name="ptr" /> is an <see cref="T:System.Runtime.InteropServices.ArrayWithOffset" /> object. This method does not accept <see cref="T:System.Runtime.InteropServices.ArrayWithOffset" /> parameters.</exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecurityCriticalAttribute()]
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.Success)]
        [SuppressUnmanagedCodeSecurityAttribute()]
        public static long ReadInt64(object ptr, int ofs)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Reads a 64-bit signed integer at a given offset from unmanaged memory.</summary><returns>The 64-bit signed integer read from unmanaged memory at the given offset.</returns><param name="ptr">The base address in unmanaged memory from which to read.</param><param name="ofs">An additional byte offset, which is added to the <paramref name="ptr" /> parameter before reading.</param><exception cref="T:System.AccessViolationException">Base address (<paramref name="ptr" />) plus offset byte (<paramref name="ofs" />) produces a null or invalid address.</exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static long ReadInt64(IntPtr ptr, int ofs)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Reads a 64-bit signed integer from unmanaged memory.</summary><returns>The 64-bit signed integer read from unmanaged memory.</returns><param name="ptr">The address in unmanaged memory from which to read.</param><exception cref="T:System.AccessViolationException"><paramref name="ptr" /> is not a recognized format.-or-<paramref name="ptr" /> is null.-or-<paramref name="ptr" /> is invalid.</exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecurityCriticalAttribute()]
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.Success)]
        public static long ReadInt64(IntPtr ptr)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes a single byte value to unmanaged memory at a specified offset.</summary><param name="ptr">The base address in unmanaged memory to write to.</param><param name="ofs">An additional byte offset, which is added to the <paramref name="ptr" /> parameter before writing.</param><param name="val">The value to write.</param><exception cref="T:System.AccessViolationException">Base address (<paramref name="ptr" />) plus offset byte (<paramref name="ofs" />) produces a null or invalid address.</exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static void WriteByte(IntPtr ptr, int ofs, byte val)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes a single byte value to unmanaged memory at a specified offset.</summary><param name="ptr">The base address in unmanaged memory of the target object.</param><param name="ofs">An additional byte offset, which is added to the <paramref name="ptr" /> parameter before writing.</param><param name="val">The value to write.</param><exception cref="T:System.AccessViolationException">Base address (<paramref name="ptr" />) plus offset byte (<paramref name="ofs" />) produces a null or invalid address.</exception><exception cref="T:System.ArgumentException"><paramref name="ptr" /> is an <see cref="T:System.Runtime.InteropServices.ArrayWithOffset" /> object. This method does not accept <see cref="T:System.Runtime.InteropServices.ArrayWithOffset" /> parameters.</exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecurityCriticalAttribute()]
        [SuppressUnmanagedCodeSecurityAttribute()]
        public static void WriteByte(object ptr, int ofs, byte val)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes a single byte value to unmanaged memory.</summary><param name="ptr">The address in unmanaged memory to write to.</param><param name="val">The value to write.</param><exception cref="T:System.AccessViolationException"><paramref name="ptr" /> is not a recognized format.-or-<paramref name="ptr" /> is null.-or-<paramref name="ptr" /> is invalid.</exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static void WriteByte(IntPtr ptr, byte val)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes a 16-bit signed integer value into unmanaged memory at a specified offset.</summary><param name="ptr">The base address in unmanaged memory to write to.</param><param name="ofs">An additional byte offset, which is added to the <paramref name="ptr" /> parameter before writing.</param><param name="val">The value to write.</param><exception cref="T:System.AccessViolationException">Base address (<paramref name="ptr" />) plus offset byte (<paramref name="ofs" />) produces a null or invalid address.</exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static void WriteInt16(IntPtr ptr, int ofs, short val)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes a 16-bit signed integer value to unmanaged memory at a specified offset.</summary><param name="ptr">The base address in unmanaged memory of the target object.</param><param name="ofs">An additional byte offset, which is added to the <paramref name="ptr" /> parameter before writing. </param><param name="val">The value to write.</param><exception cref="T:System.AccessViolationException">Base address (<paramref name="ptr" />) plus offset byte (<paramref name="ofs" />) produces a null or invalid address.</exception><exception cref="T:System.ArgumentException"><paramref name="ptr" /> is an <see cref="T:System.Runtime.InteropServices.ArrayWithOffset" /> object. This method does not accept <see cref="T:System.Runtime.InteropServices.ArrayWithOffset" /> parameters.</exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SuppressUnmanagedCodeSecurityAttribute()]
        [SecurityCriticalAttribute()]
        public static void WriteInt16(object ptr, int ofs, short val)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes a 16-bit integer value to unmanaged memory.</summary><param name="ptr">The address in unmanaged memory to write to.</param><param name="val">The value to write.</param><exception cref="T:System.AccessViolationException"><paramref name="ptr" /> is not a recognized format.-or-<paramref name="ptr" /> is null.-or-<paramref name="ptr" /> is invalid.</exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static void WriteInt16(IntPtr ptr, short val)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes a 16-bit signed integer value to unmanaged memory at a specified offset.</summary><param name="ptr">The base address in the native heap to write to.</param><param name="ofs">An additional byte offset, which is added to the <paramref name="ptr" /> parameter before writing.</param><param name="val">The value to write.</param><exception cref="T:System.AccessViolationException">Base address (<paramref name="ptr" />) plus offset byte (<paramref name="ofs" />) produces a null or invalid address.</exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static void WriteInt16(IntPtr ptr, int ofs, char val)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes a 16-bit signed integer value to unmanaged memory at a specified offset.</summary><param name="ptr">The base address in unmanaged memory of the target object.</param><param name="ofs">An additional byte offset, which is added to the <paramref name="ptr" /> parameter before writing.</param><param name="val">The value to write.</param><exception cref="T:System.AccessViolationException">Base address (<paramref name="ptr" />) plus offset byte (<paramref name="ofs" />) produces a null or invalid address.</exception><exception cref="T:System.ArgumentException"><paramref name="ptr" /> is an <see cref="T:System.Runtime.InteropServices.ArrayWithOffset" /> object. This method does not accept <see cref="T:System.Runtime.InteropServices.ArrayWithOffset" /> parameters.</exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static void WriteInt16(object ptr, int ofs, char val)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes a character as a 16-bit integer value to unmanaged memory.</summary><param name="ptr">The address in unmanaged memory to write to.</param><param name="val">The value to write.</param><exception cref="T:System.AccessViolationException"><paramref name="ptr" /> is not a recognized format.-or-<paramref name="ptr" /> is null.-or-<paramref name="ptr" /> is invalid.</exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static void WriteInt16(IntPtr ptr, char val)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes a 32-bit signed integer value into unmanaged memory at a specified offset.</summary><param name="ptr">The base address in unmanaged memory to write to.</param><param name="ofs">An additional byte offset, which is added to the <paramref name="ptr" /> parameter before writing.</param><param name="val">The value to write.</param><exception cref="T:System.AccessViolationException">Base address (<paramref name="ptr" />) plus offset byte (<paramref name="ofs" />) produces a null or invalid address.</exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static void WriteInt32(IntPtr ptr, int ofs, int val)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes a 32-bit signed integer value to unmanaged memory at a specified offset.</summary><param name="ptr">The base address in unmanaged memory of the target object.</param><param name="ofs">An additional byte offset, which is added to the <paramref name="ptr" /> parameter before writing.</param><param name="val">The value to write.</param><exception cref="T:System.AccessViolationException">Base address (<paramref name="ptr" />) plus offset byte (<paramref name="ofs" />) produces a null or invalid address.</exception><exception cref="T:System.ArgumentException"><paramref name="ptr" /> is an <see cref="T:System.Runtime.InteropServices.ArrayWithOffset" /> object. This method does not accept <see cref="T:System.Runtime.InteropServices.ArrayWithOffset" /> parameters.</exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SuppressUnmanagedCodeSecurityAttribute()]
        [SecurityCriticalAttribute()]
        public static void WriteInt32(object ptr, int ofs, int val)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes a 32-bit signed integer value to unmanaged memory.</summary><param name="ptr">The address in unmanaged memory to write to.</param><param name="val">The value to write.</param><exception cref="T:System.AccessViolationException"><paramref name="ptr" /> is not a recognized format.-or-<paramref name="ptr" /> is null. -or-<paramref name="ptr" /> is invalid.</exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static void WriteInt32(IntPtr ptr, int val)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes a processor native-sized integer value to unmanaged memory at a specified offset.</summary><param name="ptr">The base address in unmanaged memory to write to.</param><param name="ofs">An additional byte offset, which is added to the <paramref name="ptr" /> parameter before writing.</param><param name="val">The value to write.</param><exception cref="T:System.AccessViolationException">Base address (<paramref name="ptr" />) plus offset byte (<paramref name="ofs" />) produces a null or invalid address.</exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static void WriteIntPtr(IntPtr ptr, int ofs, IntPtr val)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes a processor native sized integer value to unmanaged memory.</summary><param name="ptr">The base address in unmanaged memory of the target object.</param><param name="ofs">An additional byte offset, which is added to the <paramref name="ptr" /> parameter before writing.</param><param name="val">The value to write.</param><exception cref="T:System.AccessViolationException">Base address (<paramref name="ptr" />) plus offset byte (<paramref name="ofs" />) produces a null or invalid address.</exception><exception cref="T:System.ArgumentException"><paramref name="ptr" /> is an <see cref="T:System.Runtime.InteropServices.ArrayWithOffset" /> object. This method does not accept <see cref="T:System.Runtime.InteropServices.ArrayWithOffset" /> parameters.</exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static void WriteIntPtr(object ptr, int ofs, IntPtr val)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes a processor native sized integer value into unmanaged memory.</summary><param name="ptr">The address in unmanaged memory to write to.</param><param name="val">The value to write.</param><exception cref="T:System.AccessViolationException"><paramref name="ptr" /> is not a recognized format.-or-<paramref name="ptr" /> is null.-or-<paramref name="ptr" /> is invalid.</exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static void WriteIntPtr(IntPtr ptr, IntPtr val)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes a 64-bit signed integer value to unmanaged memory at a specified offset.</summary><param name="ptr">The base address in unmanaged memory to write.</param><param name="ofs">An additional byte offset, which is added to the <paramref name="ptr" /> parameter before writing.</param><param name="val">The value to write.</param><exception cref="T:System.AccessViolationException">Base address (<paramref name="ptr" />) plus offset byte (<paramref name="ofs" />) produces a null or invalid address.</exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static void WriteInt64(IntPtr ptr, int ofs, long val)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes a 64-bit signed integer value to unmanaged memory at a specified offset.</summary><param name="ptr">The base address in unmanaged memory of the target object.</param><param name="ofs">An additional byte offset, which is added to the <paramref name="ptr" /> parameter before writing.</param><param name="val">The value to write.</param><exception cref="T:System.AccessViolationException">Base address (<paramref name="ptr" />) plus offset byte (<paramref name="ofs" />) produces a null or invalid address.</exception><exception cref="T:System.ArgumentException"><paramref name="ptr" /> is an <see cref="T:System.Runtime.InteropServices.ArrayWithOffset" /> object. This method does not accept <see cref="T:System.Runtime.InteropServices.ArrayWithOffset" /> parameters.</exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SuppressUnmanagedCodeSecurityAttribute()]
        [SecurityCriticalAttribute()]
        public static void WriteInt64(object ptr, int ofs, long val)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Writes a 64-bit signed integer value to unmanaged memory.</summary><param name="ptr">The address in unmanaged memory to write to.</param><param name="val">The value to write.</param><exception cref="T:System.AccessViolationException"><paramref name="ptr" /> is not a recognized format.-or-<paramref name="ptr" /> is null.-or-<paramref name="ptr" /> is invalid.</exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static void WriteInt64(IntPtr ptr, long val)
        {
             throw new NotImplementedException();
        }
        
        
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.Success)]
        [SecurityCriticalAttribute()]
        public static int GetLastWin32Error()
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.Success)]
        public static int GetHRForLastWin32Error()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Executes one-time method setup tasks without calling the method.</summary><param name="m">The method to be checked.</param><exception cref="T:System.ArgumentNullException">The <paramref name="m" /> parameter is null.</exception><exception cref="T:System.ArgumentException">The <paramref name="m" /> parameter is not a <see cref="T:System.Reflection.MethodInfo" /> object.</exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static void Prelink(MethodInfo m)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Performs a pre-link check for all methods on a class.</summary><param name="c">The class whose methods are to be checked.</param><exception cref="T:System.ArgumentNullException">The <paramref name="c" /> parameter is null.</exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static void PrelinkAll(Type c)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Calculates the number of bytes in unmanaged memory that are required to hold the parameters for the specified method.</summary><returns>The number of bytes required to represent the method parameters in unmanaged memory.</returns><param name="m">The method to be checked.</param><exception cref="T:System.ArgumentNullException">The <paramref name="m" /> parameter is null.</exception><exception cref="T:System.ArgumentException">The <paramref name="m" /> parameter is not a <see cref="T:System.Reflection.MethodInfo" /> object.</exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static int NumParamBytes(MethodInfo m)
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        [ComVisibleAttribute(true)]
        public static IntPtr GetExceptionPointers()
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        public static int GetExceptionCode()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Marshals data from a managed object to an unmanaged block of memory.</summary><param name="structure">A managed object that holds the data to be marshaled. This object must be a structure or an instance of a formatted class. </param><param name="ptr">A pointer to an unmanaged block of memory, which must be allocated before this method is called.</param><param name="fDeleteOld">true to call the <see cref="M:System.Runtime.InteropServices.Marshal.DestroyStructure(System.IntPtr,System.Type)" /> method on the <paramref name="ptr" /> parameter before this method copies the data. The block must contain valid data. Note that passing false when the memory block already contains data can lead to a memory leak.</param><exception cref="T:System.ArgumentException"><paramref name="structure" /> is a reference type that is not a formatted class. -or-<paramref name="structure" /> is a generic type. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.MayFail)]
        [SecurityCriticalAttribute()]
        [ComVisibleAttribute(true)]
        public static void StructureToPtr(object structure, IntPtr ptr, bool fDeleteOld)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Marshals data from an unmanaged block of memory to a managed object.</summary><param name="ptr">A pointer to an unmanaged block of memory.</param><param name="structure">The object to which the data is to be copied. This must be an instance of a formatted class.</param><exception cref="T:System.ArgumentException">Structure layout is not sequential or explicit.-or- Structure is a boxed value type.</exception><PermissionSet><IPermission class="System.Security.Permissions.ReflectionPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="MemberAccess" /><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecurityCriticalAttribute()]
        [ComVisibleAttribute(true)]
        public static void PtrToStructure(IntPtr ptr, object structure)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Marshals data from an unmanaged block of memory to a newly allocated managed object of the specified type.</summary><returns>A managed object containing the data pointed to by the <paramref name="ptr" /> parameter.</returns><param name="ptr">A pointer to an unmanaged block of memory.</param><param name="structureType">The type of object to be created. This object must represent a formatted class or a structure.</param><exception cref="T:System.ArgumentException">The <paramref name="structureType" /> parameter layout is not sequential or explicit.-or-The <paramref name="structureType" /> parameter is a generic type.</exception><exception cref="T:System.ArgumentNullException"><paramref name="structureType" /> is null.</exception><PermissionSet><IPermission class="System.Security.Permissions.ReflectionPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="MemberAccess" /><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [ComVisibleAttribute(true)]
        [SecurityCriticalAttribute()]
        public static object PtrToStructure(IntPtr ptr, Type structureType)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Frees all substructures that the specified unmanaged memory block points to.</summary><param name="ptr">A pointer to an unmanaged block of memory. </param><param name="structuretype">Type of a formatted class. This provides the layout information necessary to delete the buffer in the <paramref name="ptr" /> parameter.</param><exception cref="T:System.ArgumentException"><paramref name="structureType" /> has an automatic layout. Use sequential or explicit instead.</exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [ComVisibleAttribute(true)]
        [SecurityCriticalAttribute()]
        public static void DestroyStructure(IntPtr ptr, Type structuretype)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the instance handle (HINSTANCE) for the specified module.</summary><returns>The HINSTANCE for <paramref name="m" />; or -1 if the module does not have an HINSTANCE.</returns><param name="m">The module whose HINSTANCE is desired.</param><exception cref="T:System.ArgumentNullException">The <paramref name="m" /> parameter is null.</exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static IntPtr GetHINSTANCE(Module m)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Throws an exception with a specific failure HRESULT value.</summary><param name="errorCode">The HRESULT corresponding to the desired exception.</param><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static void ThrowExceptionForHR(int errorCode)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Throws an exception with a specific failure HRESULT, based on the specified IErrorInfo Interface interface.</summary><param name="errorCode">The HRESULT corresponding to the desired exception.</param><param name="errorInfo">A pointer to the IErrorInfo interface that provides more information about the error. You can specify IntPtr(0) to use the current IErrorInfo interface, or IntPtr(-1) to ignore the current IErrorInfo interface and construct the exception just from the error code.</param><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static void ThrowExceptionForHR(int errorCode, IntPtr errorInfo)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Converts the specified HRESULT error code to a corresponding <see cref="T:System.Exception" /> object.</summary><returns>An object that represents the converted HRESULT.</returns><param name="errorCode">The HRESULT to be converted.</param><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static Exception GetExceptionForHR(int errorCode)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Converts the specified HRESULT error code to a corresponding <see cref="T:System.Exception" /> object, with additional error information passed in an IErrorInfo interface for the exception object.</summary><returns>An object that represents the converted HRESULT and information obtained from <paramref name="errorInfo" />.</returns><param name="errorCode">The HRESULT to be converted.</param><param name="errorInfo">A pointer to the IErrorInfo interface that provides more information about the error. You can specify IntPtr(0) to use the current IErrorInfo interface, or IntPtr(-1) to ignore the current IErrorInfo interface and construct the exception just from the error code. </param><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static Exception GetExceptionForHR(int errorCode, IntPtr errorInfo)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Converts the specified exception to an HRESULT.</summary><returns>The HRESULT mapped to the supplied exception.</returns><param name="e">The exception to convert to an HRESULT.</param><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static int GetHRForException(Exception e)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Gets a pointer to a runtime-generated function that marshals a call from unmanaged to managed code.</summary><returns>A pointer to a function that will marshal a call from <paramref name="pfnMethodToWrap" /> to managed code.</returns><param name="pfnMethodToWrap">A pointer to the method to marshal.</param><param name="pbSignature">A pointer to the method signature.</param><param name="cbSignature">The number of bytes in <paramref name="pbSignature" />.</param><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecurityCriticalAttribute()]
        [ObsoleteAttribute("The GetUnmanagedThunkForManagedMethodPtr method has been deprecated and will be removed in a future release.", false)]
        public static IntPtr GetUnmanagedThunkForManagedMethodPtr(IntPtr pfnMethodToWrap, IntPtr pbSignature, int cbSignature)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Gets a pointer to a runtime-generated function that marshals a call from managed to unmanaged code.</summary><returns>A pointer to the function that will marshal a call from the <paramref name="pfnMethodToWrap" /> parameter to unmanaged code.</returns><param name="pfnMethodToWrap">A pointer to the method to marshal.</param><param name="pbSignature">A pointer to the method signature.</param><param name="cbSignature">The number of bytes in <paramref name="pbSignature" />.</param><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [ObsoleteAttribute("The GetManagedThunkForUnmanagedMethodPtr method has been deprecated and will be removed in a future release.", false)]
        [SecurityCriticalAttribute()]
        public static IntPtr GetManagedThunkForUnmanagedMethodPtr(IntPtr pfnMethodToWrap, IntPtr pbSignature, int cbSignature)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Converts a fiber cookie into the corresponding <see cref="T:System.Threading.Thread" /> instance.</summary><returns>A thread that corresponds to the <paramref name="cookie" /> parameter.</returns><param name="cookie">An integer that represents a fiber cookie.</param><exception cref="T:System.ArgumentException">The <paramref name="cookie" /> parameter is 0.</exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [ObsoleteAttribute("The GetThreadFromFiberCookie method has been deprecated.  Use the hosting API to perform this operation.", false)]
        [SecurityCriticalAttribute()]
        public static Thread GetThreadFromFiberCookie(int cookie)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Allocates memory from the unmanaged memory of the process by using the pointer to the specified number of bytes.</summary><returns>A pointer to the newly allocated memory. This memory must be released using the <see cref="M:System.Runtime.InteropServices.Marshal.FreeHGlobal(System.IntPtr)" /> method.</returns><param name="cb">The required number of bytes in memory.</param><exception cref="T:System.OutOfMemoryException">There is insufficient memory to satisfy the request.</exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.MayFail)]
        [SecurityCriticalAttribute()]
        public static IntPtr AllocHGlobal(IntPtr cb)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Allocates memory from the unmanaged memory of the process by using the specified number of bytes.</summary><returns>A pointer to the newly allocated memory. This memory must be released using the <see cref="M:System.Runtime.InteropServices.Marshal.FreeHGlobal(System.IntPtr)" /> method.</returns><param name="cb">The required number of bytes in memory.</param><exception cref="T:System.OutOfMemoryException">There is insufficient memory to satisfy the request.</exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecurityCriticalAttribute()]
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.MayFail)]
        public static IntPtr AllocHGlobal(int cb)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Frees memory previously allocated from the unmanaged memory of the process.</summary><param name="hglobal">The handle returned by the original matching call to <see cref="M:System.Runtime.InteropServices.Marshal.AllocHGlobal(System.IntPtr)" />. </param><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecurityCriticalAttribute()]
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.Success)]
        public static void FreeHGlobal(IntPtr hglobal)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Resizes a block of memory previously allocated with <see cref="M:System.Runtime.InteropServices.Marshal.AllocHGlobal(System.IntPtr)" />.</summary><returns>A pointer to the reallocated memory. This memory must be released using <see cref="M:System.Runtime.InteropServices.Marshal.FreeHGlobal(System.IntPtr)" />.</returns><param name="pv">A pointer to memory allocated with <see cref="M:System.Runtime.InteropServices.Marshal.AllocHGlobal(System.IntPtr)" />.</param><param name="cb">The new size of the allocated block. This is not a pointer; it is the byte count you are requesting, cast to type <see cref="T:System.IntPtr" />. If you pass a pointer, it is treated as a size.</param><exception cref="T:System.OutOfMemoryException">There is insufficient memory to satisfy the request.</exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static IntPtr ReAllocHGlobal(IntPtr pv, IntPtr cb)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Copies the contents of a managed <see cref="T:System.String" /> into unmanaged memory, converting into ANSI format as it copies.</summary><returns>The address, in unmanaged memory, to where <paramref name="s" /> was copied, or 0 if <paramref name="s" /> is null.</returns><param name="s">A managed string to be copied.</param><exception cref="T:System.OutOfMemoryException">There is insufficient memory available.</exception><exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="s" /> parameter exceeds the maximum length allowed by the operating system.</exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static IntPtr StringToHGlobalAnsi(string s)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Copies the contents of a managed <see cref="T:System.String" /> into unmanaged memory.</summary><returns>The address, in unmanaged memory, to where the <paramref name="s" /> was copied, or 0 if <paramref name="s" /> is null.</returns><param name="s">A managed string to be copied.</param><exception cref="T:System.OutOfMemoryException">The method could not allocate enough native heap memory.</exception><exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="s" /> parameter exceeds the maximum length allowed by the operating system.</exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static IntPtr StringToHGlobalUni(string s)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Copies the contents of a managed <see cref="T:System.String" /> into unmanaged memory, converting into ANSI format if required.</summary><returns>The address, in unmanaged memory, to where the string was copied, or 0 if <paramref name="s" /> is null.</returns><param name="s">A managed string to be copied.</param><exception cref="T:System.OutOfMemoryException">There is insufficient memory available.</exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static IntPtr StringToHGlobalAuto(string s)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Retrieves the name of a type library.</summary><returns>The name of the type library that the <paramref name="pTLB" /> parameter points to.</returns><param name="pTLB">The type library whose name is to be retrieved.</param><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecurityCriticalAttribute()]
        [ObsoleteAttribute("Use System.Runtime.InteropServices.Marshal.GetTypeLibName(ITypeLib pTLB) instead. http://go.microsoft.com/fwlink/?linkid=14202&ID=0000011.", false)]
        public static string GetTypeLibName(UCOMITypeLib pTLB)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Retrieves the name of a type library.</summary><returns>The name of the type library that the <paramref name="typelib" /> parameter points to.</returns><param name="typelib">The type library whose name is to be retrieved.</param><exception cref="T:System.ArgumentNullException">The <paramref name="typelib" /> parameter is null.</exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static string GetTypeLibName(ITypeLib typelib)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Retrieves the library identifier (LIBID) of a type library.</summary><returns>The LIBID of the type library that the <paramref name="pTLB" /> parameter points to.</returns><param name="pTLB">The type library whose LIBID is to be retrieved. </param><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [ObsoleteAttribute("Use System.Runtime.InteropServices.Marshal.GetTypeLibGuid(ITypeLib pTLB) instead. http://go.microsoft.com/fwlink/?linkid=14202&ID=0000011.", false)]
        [SecurityCriticalAttribute()]
        public static Guid GetTypeLibGuid(UCOMITypeLib pTLB)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Retrieves the library identifier (LIBID) of a type library.</summary><returns>The LIBID of the specified type library.</returns><param name="typelib">The type library whose LIBID is to be retrieved.</param><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static Guid GetTypeLibGuid(ITypeLib typelib)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Retrieves the LCID of a type library.</summary><returns>The LCID of the type library that the <paramref name="pTLB" /> parameter points to.</returns><param name="pTLB">The type library whose LCID is to be retrieved.</param><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecurityCriticalAttribute()]
        [ObsoleteAttribute("Use System.Runtime.InteropServices.Marshal.GetTypeLibLcid(ITypeLib pTLB) instead. http://go.microsoft.com/fwlink/?linkid=14202&ID=0000011.", false)]
        public static int GetTypeLibLcid(UCOMITypeLib pTLB)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Retrieves the LCID of a type library.</summary><returns>The LCID of the type library that the <paramref name="typelib" /> parameter points to.</returns><param name="typelib">The type library whose LCID is to be retrieved.</param><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static int GetTypeLibLcid(ITypeLib typelib)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Retrieves the library identifier (LIBID) that is assigned to a type library when it was exported from the specified assembly.</summary><returns>The LIBID that is assigned to a type library when it is exported from the specified assembly.</returns><param name="asm">The assembly from which the type library was exported.</param><exception cref="T:System.ArgumentNullException"><paramref name="asm" /> is null.</exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static Guid GetTypeLibGuidForAssembly(Assembly asm)
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        public static void GetTypeLibVersionForAssembly(Assembly inputAssembly, ref int majorVersion, ref int minorVersion)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Retrieves the name of the type represented by an ITypeInfo object.</summary><returns>The name of the type that the <paramref name="pTI" /> parameter points to.</returns><param name="pTI">An object that represents an ITypeInfo pointer. </param><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecurityCriticalAttribute()]
        [ObsoleteAttribute("Use System.Runtime.InteropServices.Marshal.GetTypeInfoName(ITypeInfo pTLB) instead. http://go.microsoft.com/fwlink/?linkid=14202&ID=0000011.", false)]
        public static string GetTypeInfoName(UCOMITypeInfo pTI)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Retrieves the name of the type represented by an ITypeInfo object.</summary><returns>The name of the type that the <paramref name="typeInfo" /> parameter points to.</returns><param name="typeInfo">An object that represents an ITypeInfo pointer.</param><exception cref="T:System.ArgumentNullException">The <paramref name="typeInfo" /> parameter is null.</exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static string GetTypeInfoName(ITypeInfo typeInfo)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Converts an unmanaged ITypeInfo object into a managed <see cref="T:System.Type" /> object.</summary><returns>A managed type that represents the unmanaged ITypeInfo object.</returns><param name="piTypeInfo">The ITypeInfo interface to marshal. </param><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /><IPermission class="System.Security.Permissions.ReflectionPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="MemberAccess" /><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static Type GetTypeForITypeInfo(IntPtr piTypeInfo)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the type associated with the specified class identifier (CLSID). </summary><returns>System.__ComObject regardless of whether the CLSID is valid. </returns><param name="clsid">The CLSID of the type to return. </param>
        [SecuritySafeCriticalAttribute()]
        public static Type GetTypeFromCLSID(Guid clsid)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a <see cref="T:System.Runtime.InteropServices.ComTypes.ITypeInfo" /> interface from a managed type.</summary><returns>A pointer to the ITypeInfo interface for the <paramref name="t" /> parameter.</returns><param name="t">The type whose ITypeInfo interface is being requested.</param><exception cref="T:System.ArgumentException"><paramref name="t" /> is not a visible type to COM.</exception><exception cref="T:System.Runtime.InteropServices.COMException">A type library is registered for the assembly that contains the type, but the type definition cannot be found.</exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static IntPtr GetITypeInfoForType(Type t)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns an IUnknown interface from a managed object.</summary><returns>The IUnknown pointer for the <paramref name="o" /> parameter.</returns><param name="o">The object whose IUnknown interface is requested.</param><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static IntPtr GetIUnknownForObject(object o)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns an IUnknown interface from a managed object, if the caller is in the same context as that object.</summary><returns>The IUnknown pointer for the specified object, or null if the caller is not in the same context as the specified object.</returns><param name="o">The object whose IUnknown interface is requested.</param><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static IntPtr GetIUnknownForObjectInContext(object o)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns an IDispatch interface from a managed object.</summary><returns>The IDispatch pointer for the <paramref name="o" /> parameter.</returns><param name="o">The object whose IDispatch interface is requested.</param><exception cref="T:System.InvalidCastException"><paramref name="o" /> does not support the requested interface.</exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static IntPtr GetIDispatchForObject(object o)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns an IDispatch interface pointer from a managed object, if the caller is in the same context as that object.</summary><returns>The IDispatch interface pointer for the specified object, or null if the caller is not in the same context as the specified object.</returns><param name="o">The object whose IDispatch interface is requested.</param><exception cref="T:System.InvalidCastException"><paramref name="o" /> does not support the requested interface.</exception><exception cref="T:System.ArgumentNullException"><paramref name="o" /> is null.</exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static IntPtr GetIDispatchForObjectInContext(object o)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a pointer to an IUnknown interface that represents the specified interface on the specified object. Custom query interface access is enabled by default.</summary><returns>The interface pointer that represents the specified interface for the object.</returns><param name="o">The object that provides the interface. </param><param name="T">The type of interface that is requested. </param><exception cref="T:System.ArgumentException">The <paramref name="T" /> parameter is not an interface.-or- The type is not visible to COM. -or-The <paramref name="T" /> parameter is a generic type.</exception><exception cref="T:System.InvalidCastException">The <paramref name="o" /> parameter does not support the requested interface. </exception><exception cref="T:System.ArgumentNullException">The <paramref name="o" /> parameter is null.-or- The <paramref name="T" /> parameter is null.</exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static IntPtr GetComInterfaceForObject(object o, Type T)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a pointer to an IUnknown interface that represents the specified interface on the specified object. Custom query interface access is controlled by the specified customization mode.</summary><returns>The interface pointer that represents the interface for the object.</returns><param name="o">The object that provides the interface.</param><param name="T">The type of interface that is requested.</param><param name="mode">One of the enumeration values that indicates whether to apply an IUnknown::QueryInterface customization that is supplied by an <see cref="T:System.Runtime.InteropServices.ICustomQueryInterface" />.</param><exception cref="T:System.ArgumentException">The <paramref name="T" /> parameter is not an interface.-or- The type is not visible to COM.-or-The <paramref name="T" /> parameter is a generic type.</exception><exception cref="T:System.InvalidCastException">The object <paramref name="o" /> does not support the requested interface.</exception><exception cref="T:System.ArgumentNullException">The <paramref name="o" /> parameter is null.-or- The <paramref name="T" /> parameter is null.</exception>
        [SecurityCriticalAttribute()]
        public static IntPtr GetComInterfaceForObject(object o, Type T, CustomQueryInterfaceMode mode)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns an interface pointer that represents the specified interface for an object, if the caller is in the same context as that object.</summary><returns>The interface pointer specified by <paramref name="t" /> that represents the interface for the specified object, or null if the caller is not in the same context as the object.</returns><param name="o">The object that provides the interface.</param><param name="t">The type of interface that is requested.</param><exception cref="T:System.ArgumentException"><paramref name="t" /> is not an interface.-or- The type is not visible to COM.</exception><exception cref="T:System.InvalidCastException"><paramref name="o" /> does not support the requested interface.</exception><exception cref="T:System.ArgumentNullException"><paramref name="o" /> is null.-or- <paramref name="t" /> is null.</exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static IntPtr GetComInterfaceForObjectInContext(object o, Type t)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns an instance of a type that represents a COM object by a pointer to its IUnknown interface.</summary><returns>An object that represents the specified unmanaged COM object.</returns><param name="pUnk">A pointer to the IUnknown interface. </param><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static object GetObjectForIUnknown(IntPtr pUnk)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates a unique Runtime Callable Wrapper (RCW) object for a given IUnknown interface.</summary><returns>A unique RCW for the specified IUnknown interface.</returns><param name="unknown">A managed pointer to an IUnknown interface.</param>
        [SecurityCriticalAttribute()]
        public static object GetUniqueObjectForIUnknown(IntPtr unknown)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a managed object of a specified type that represents a COM object.</summary><returns>An instance of the class corresponding to the <see cref="T:System.Type" /> object that represents the requested unmanaged COM object.</returns><param name="pUnk">A pointer to the IUnknown interface of the unmanaged object.</param><param name="t">The type of the requested managed class.</param><exception cref="T:System.ArgumentException"><paramref name="t" /> is not attributed with <see cref="T:System.Runtime.InteropServices.ComImportAttribute" />.</exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static object GetTypedObjectForIUnknown(IntPtr pUnk, Type t)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Aggregates a managed object with the specified COM object.</summary><returns>The inner IUnknown pointer of the managed object.</returns><param name="pOuter">The outer IUnknown pointer.</param><param name="o">An object to aggregate.</param>
        [SecurityCriticalAttribute()]
        public static IntPtr CreateAggregatedObject(IntPtr pOuter, object o)
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        public static void CleanupUnusedObjectsInCurrentContext()
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        public static bool AreComObjectsAvailableForCleanup()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Indicates whether a specified object represents a COM object.</summary><returns>true if the <paramref name="o" /> parameter is a COM type; otherwise, false.</returns><param name="o">The object to check.</param><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public static bool IsComObject(object o)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Allocates a block of memory of specified size from the COM task memory allocator.</summary><returns>An integer representing the address of the block of memory allocated. This memory must be released with <see cref="M:System.Runtime.InteropServices.Marshal.FreeCoTaskMem(System.IntPtr)" />.</returns><param name="cb">The size of the block of memory to be allocated.</param><exception cref="T:System.OutOfMemoryException">There is insufficient memory to satisfy the request.</exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static IntPtr AllocCoTaskMem(int cb)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Copies the contents of a managed <see cref="T:System.String" /> to a block of memory allocated from the unmanaged COM task allocator.</summary><returns>An integer representing a pointer to the block of memory allocated for the string, or 0 if s is null.</returns><param name="s">A managed string to be copied.</param><exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="s" /> parameter exceeds the maximum length allowed by the operating system.</exception><exception cref="T:System.OutOfMemoryException">There is insufficient memory available.</exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static IntPtr StringToCoTaskMemUni(string s)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Copies the contents of a managed <see cref="T:System.String" /> to a block of memory allocated from the unmanaged COM task allocator.</summary><returns>The allocated memory block, or 0 if <paramref name="s" /> is null.</returns><param name="s">A managed string to be copied.</param><exception cref="T:System.OutOfMemoryException">There is insufficient memory available.</exception><exception cref="T:System.ArgumentOutOfRangeException">The length for <paramref name="s" /> is out of range.</exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static IntPtr StringToCoTaskMemAuto(string s)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Copies the contents of a managed <see cref="T:System.String" /> to a block of memory allocated from the unmanaged COM task allocator.</summary><returns>An integer representing a pointer to the block of memory allocated for the string, or 0 if <paramref name="s" /> is null.</returns><param name="s">A managed string to be copied.</param><exception cref="T:System.OutOfMemoryException">There is insufficient memory available.</exception><exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="s" /> parameter exceeds the maximum length allowed by the operating system.</exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static IntPtr StringToCoTaskMemAnsi(string s)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Frees a block of memory allocated by the unmanaged COM task memory allocator.</summary><param name="ptr">The address of the memory to be freed. </param><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static void FreeCoTaskMem(IntPtr ptr)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Decrements the reference count of the specified Runtime Callable Wrapper (RCW) associated with the specified COM object.</summary><returns>The new value of the reference count of the RCW associated with <paramref name="o" />. This value is typically zero since the RCW keeps just one reference to the wrapped COM object regardless of the number of managed clients calling it.</returns><param name="o">The COM object to release.</param><exception cref="T:System.ArgumentException"><paramref name="o" /> is not a valid COM object.</exception><exception cref="T:System.NullReferenceException"><paramref name="o" /> is null.</exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static int ReleaseComObject(object o)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Releases all references to a Runtime Callable Wrapper (RCW) by setting its reference count to 0.</summary><returns>The new value of the reference count of the RCW associated with the <paramref name="o" />parameter, which is 0 (zero) if the release is successful.</returns><param name="o">The RCW to be released.</param><exception cref="T:System.ArgumentException"><paramref name="o" /> is not a valid COM object.</exception><exception cref="T:System.ArgumentNullException"><paramref name="o" /> is null.</exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static int FinalReleaseComObject(object o)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Retrieves data that is referenced by the specified key from the specified COM object.</summary><returns>The data represented by the <paramref name="key" /> parameter in the internal hash table of the <paramref name="obj" /> parameter.</returns><param name="obj">The COM object that contains the data that you want.</param><param name="key">The key in the internal hash table of <paramref name="obj" /> to retrieve the data from.</param><exception cref="T:System.ArgumentNullException"><paramref name="obj" /> is null.-or- <paramref name="key" /> is null.</exception><exception cref="T:System.ArgumentException"><paramref name="obj" /> is not a COM object.</exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static object GetComObjectData(object obj, object key)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sets data referenced by the specified key in the specified COM object.</summary><returns>true if the data was set successfully; otherwise, false.</returns><param name="obj">The COM object in which to store the data.</param><param name="key">The key in the internal hash table of the COM object in which to store the data.</param><param name="data">The data to set.</param><exception cref="T:System.ArgumentNullException"><paramref name="obj" /> is null.-or- <paramref name="key" /> is null.</exception><exception cref="T:System.ArgumentException"><paramref name="obj" /> is not a COM object.</exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static bool SetComObjectData(object obj, object key, object data)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Wraps the specified COM object in an object of the specified type.</summary><returns>The newly wrapped object that is an instance of the desired type.</returns><param name="o">The object to be wrapped. </param><param name="t">The type of wrapper to create. </param><exception cref="T:System.ArgumentException"><paramref name="t" /> must derive from __ComObject. </exception><exception cref="T:System.ArgumentNullException">The <paramref name="t" /> parameter is null.</exception><exception cref="T:System.InvalidCastException"><paramref name="o" /> cannot be converted to the destination type because it does not support all required interfaces. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static object CreateWrapperOfType(object o, Type t)
        {
             throw new NotImplementedException();
        }
        
        
        [ObsoleteAttribute("This API did not perform any operation and will be removed in future versions of the CLR.", false)]
        [SecurityCriticalAttribute()]
        public static void ReleaseThreadCache()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Indicates whether a type is visible to COM clients.</summary><returns>true if the type is visible to COM; otherwise, false.</returns><param name="t">The type to check for COM visibility.</param><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public static bool IsTypeVisibleFromCom(Type t)
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        public static int QueryInterface(IntPtr pUnk, ref Guid iid, ref IntPtr ppv)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Increments the reference count on the specified interface.</summary><returns>The new value of the reference count on the <paramref name="pUnk" /> parameter.</returns><param name="pUnk">The interface reference count to increment.</param><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static int AddRef(IntPtr pUnk)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Decrements the reference count on the specified interface.</summary><returns>The new value of the reference count on the interface specified by the <paramref name="pUnk" /> parameter.</returns><param name="pUnk">The interface to release.</param><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.Success)]
        [SecurityCriticalAttribute()]
        public static int Release(IntPtr pUnk)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Resizes a block of memory previously allocated with <see cref="M:System.Runtime.InteropServices.Marshal.AllocCoTaskMem(System.Int32)" />.</summary><returns>An integer representing the address of the reallocated block of memory. This memory must be released with <see cref="M:System.Runtime.InteropServices.Marshal.FreeCoTaskMem(System.IntPtr)" />.</returns><param name="pv">A pointer to memory allocated with <see cref="M:System.Runtime.InteropServices.Marshal.AllocCoTaskMem(System.Int32)" />.</param><param name="cb">The new size of the allocated block.</param><exception cref="T:System.OutOfMemoryException">There is insufficient memory to satisfy the request.</exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static IntPtr ReAllocCoTaskMem(IntPtr pv, int cb)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Frees a BSTR using the COM SysFreeString function.</summary><param name="ptr">The address of the BSTR to be freed. </param><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static void FreeBSTR(IntPtr ptr)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Allocates a BSTR Data Type and copies the contents of a managed <see cref="T:System.String" /> into it.</summary><returns>An unmanaged pointer to the BSTR, or 0 if <paramref name="s" /> is null.</returns><param name="s">The managed string to be copied.</param><exception cref="T:System.OutOfMemoryException">There is insufficient memory available.</exception><exception cref="T:System.ArgumentOutOfRangeException">The length for <paramref name="s" /> is out of range.</exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static IntPtr StringToBSTR(string s)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Allocates a managed <see cref="T:System.String" /> and copies a BSTR Data Type string stored in unmanaged memory into it.</summary><returns>A managed string that holds a copy of the unmanaged string if the value of the <paramref name="ptr" /> parameter is not null; otherwise, this method returns null.</returns><param name="ptr">The address of the first character of the unmanaged string.</param><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static string PtrToStringBSTR(IntPtr ptr)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Converts an object to a COM VARIANT.</summary><param name="obj">The object for which to get a COM VARIANT.</param><param name="pDstNativeVariant">A pointer to receive the VARIANT that corresponds to the <paramref name="obj" /> parameter.</param><exception cref="T:System.ArgumentException">The <paramref name="obj" /> parameter is a generic type.</exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static void GetNativeVariantForObject(object obj, IntPtr pDstNativeVariant)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Converts a COM VARIANT to an object.</summary><returns>An object that corresponds to the <paramref name="pSrcNativeVariant" /> parameter.</returns><param name="pSrcNativeVariant">A pointer to a COM VARIANT.</param><exception cref="T:System.Runtime.InteropServices.InvalidOleVariantTypeException"><paramref name="pSrcNativeVariant" /> is not a valid VARIANT type.</exception><exception cref="T:System.NotSupportedException"><paramref name="pSrcNativeVariant" /> has an unsupported type.</exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static object GetObjectForNativeVariant(IntPtr pSrcNativeVariant)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Converts an array of COM VARIANTs to an array of objects. </summary><returns>An object array that corresponds to <paramref name="aSrcNativeVariant" />.</returns><param name="aSrcNativeVariant">A pointer to the first element of an array of COM VARIANTs.</param><param name="cVars">The count of COM VARIANTs in <paramref name="aSrcNativeVariant" />.</param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="cVars" /> is a negative number.</exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static object[] GetObjectsForNativeVariants(IntPtr aSrcNativeVariant, int cVars)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Gets the first slot in the virtual function table (v-table or VTBL) that contains user-defined methods.</summary><returns>The first VTBL slot that contains user-defined methods. The first slot is 3 if the interface is based on IUnknown, and 7 if the interface is based on IDispatch.</returns><param name="t">A type that represents an interface.</param><exception cref="T:System.ArgumentException"><paramref name="t" /> is not visible from COM.</exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static int GetStartComSlot(Type t)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Retrieves the last slot in the virtual function table (v-table or VTBL) of a type when exposed to COM.</summary><returns>The last VTBL slot of the interface when exposed to COM. If the <paramref name="t" /> parameter is a class, the returned VTBL slot is the last slot in the interface that is generated from the class.</returns><param name="t">A type that represents an interface or class.</param><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static int GetEndComSlot(Type t)
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        public static MemberInfo GetMethodInfoForComSlot(Type t, int slot, ref ComMemberType memberType)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Retrieves the virtual function table (v-table or VTBL) slot for a specified <see cref="T:System.Reflection.MemberInfo" /> type when that type is exposed to COM.</summary><returns>The VTBL slot <paramref name="m" /> identifier when it is exposed to COM.</returns><param name="m">An object that represents an interface method.</param><exception cref="T:System.ArgumentNullException">The <paramref name="m" /> parameter is null.</exception><exception cref="T:System.ArgumentException">The <paramref name="m" /> parameter is not a <see cref="T:System.Reflection.MemberInfo" /> object.-or-The <paramref name="m" /> parameter is not an interface method.</exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static int GetComSlotForMethodInfo(MemberInfo m)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the globally unique identifier (GUID) for the specified type, or generates a GUID using the algorithm used by the Type Library Exporter (Tlbexp.exe).</summary><returns>An identifier for the specified type.</returns><param name="type">The type to generate a GUID for. </param><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static Guid GenerateGuidForType(Type type)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a programmatic identifier (ProgID) for the specified type.</summary><returns>The ProgID of the specified type.</returns><param name="type">The type to get a ProgID for. </param><exception cref="T:System.ArgumentException">The <paramref name="type" /> parameter is not a class that can be create by COM. The class must be public, have a public default constructor, and be COM visible. </exception><exception cref="T:System.ArgumentNullException">The <paramref name="type" /> parameter is null.</exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static string GenerateProgIdForType(Type type)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Gets an interface pointer identified by the specified moniker.</summary><returns>An object containing a reference to the interface pointer identified by the <paramref name="monikerName" /> parameter. A moniker is a name, and in this case, the moniker is defined by an interface.</returns><param name="monikerName">The moniker corresponding to the desired interface pointer.</param><exception cref="T:System.Runtime.InteropServices.COMException">An unrecognized HRESULT was returned by the unmanaged BindToMoniker method.</exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static object BindToMoniker(string monikerName)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Obtains a running instance of the specified object from the running object table (ROT).</summary><returns>The object that was requested; otherwise null. You can cast this object to any COM interface that it supports.</returns><param name="progID">The programmatic identifier (ProgID) of the object that was requested.</param><exception cref="T:System.Runtime.InteropServices.COMException">The object was not found.</exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static object GetActiveObject(string progID)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Changes the strength of an object's COM Callable Wrapper (CCW) handle.</summary><param name="otp">The object whose CCW holds a reference counted handle. The handle is strong if the reference count on the CCW is greater than zero; otherwise, it is weak.</param><param name="fIsWeak">true to change the strength of the handle on the <paramref name="otp" /> parameter to weak, regardless of its reference count; false to reset the handle strength on <paramref name="otp" /> to be reference counted.</param><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static void ChangeWrapperHandleStrength(object otp, bool fIsWeak)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Converts an unmanaged function pointer to a delegate.</summary><returns>A delegate instance that can be cast to the appropriate delegate type.</returns><param name="ptr">The unmanaged function pointer to be converted.</param><param name="t">The type of the delegate to be returned.</param><exception cref="T:System.ArgumentException">The <paramref name="t" /> parameter is not a delegate or is generic.</exception><exception cref="T:System.ArgumentNullException">The <paramref name="ptr" /> parameter is null.-or-The <paramref name="t" /> parameter is null.</exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static Delegate GetDelegateForFunctionPointer(IntPtr ptr, Type t)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Converts a delegate into a function pointer that is callable from unmanaged code.</summary><returns>A value that can be passed to unmanaged code, which, in turn, can use it to call the underlying managed delegate. </returns><param name="d">The delegate to be passed to unmanaged code.</param><exception cref="T:System.ArgumentException">The <paramref name="d" /> parameter is a generic type.</exception><exception cref="T:System.ArgumentNullException">The <paramref name="d" /> parameter is null.</exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static IntPtr GetFunctionPointerForDelegate(Delegate d)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Allocates a BSTR Data Type and copies the contents of a managed <see cref="T:System.Security.SecureString" /> object into it.</summary><returns>The address, in unmanaged memory, where the <paramref name="s" /> parameter was copied to, or 0 if a null object was supplied.</returns><param name="s">The managed object to copy.</param><exception cref="T:System.ArgumentNullException">The <paramref name="s" /> parameter is null.</exception><exception cref="T:System.NotSupportedException">The current computer is not running Windows 2000 Service Pack 3 or later.</exception><exception cref="T:System.OutOfMemoryException">There is insufficient memory available.</exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static IntPtr SecureStringToBSTR(SecureString s)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Copies the contents of a managed <see cref="T:System.Security.SecureString" /> object to a block of memory allocated from the unmanaged COM task allocator.</summary><returns>The address, in unmanaged memory, where the <paramref name="s" /> parameter was copied to, or 0 if a null object was supplied.</returns><param name="s">The managed object to copy.</param><exception cref="T:System.ArgumentNullException">The <paramref name="s" /> parameter is null.</exception><exception cref="T:System.NotSupportedException">The current computer is not running Windows 2000 Service Pack 3 or later.</exception><exception cref="T:System.OutOfMemoryException">There is insufficient memory available.</exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static IntPtr SecureStringToCoTaskMemAnsi(SecureString s)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Copies the contents of a managed <see cref="T:System.Security.SecureString" /> object to a block of memory allocated from the unmanaged COM task allocator.</summary><returns>The address, in unmanaged memory, where the <paramref name="s" /> parameter was copied to, or 0 if a null object was supplied.</returns><param name="s">The managed object to copy.</param><exception cref="T:System.ArgumentNullException">The <paramref name="s" /> parameter is null.</exception><exception cref="T:System.NotSupportedException">The current computer is not running Windows 2000 Service Pack 3 or later.</exception><exception cref="T:System.OutOfMemoryException">There is insufficient memory available.</exception>
        [SecurityCriticalAttribute()]
        public static IntPtr SecureStringToCoTaskMemUnicode(SecureString s)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Frees a BSTR Data Type pointer that was allocated using the <see cref="M:System.Runtime.InteropServices.Marshal.SecureStringToBSTR(System.Security.SecureString)" /> method.</summary><param name="s">The address of the BSTR to free.</param><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static void ZeroFreeBSTR(IntPtr s)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Frees an unmanaged string pointer that was allocated using the <see cref="M:System.Runtime.InteropServices.Marshal.SecureStringToCoTaskMemAnsi(System.Security.SecureString)" /> method.</summary><param name="s">The address of the unmanaged string to free.</param><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static void ZeroFreeCoTaskMemAnsi(IntPtr s)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Frees an unmanaged string pointer that was allocated using the <see cref="M:System.Runtime.InteropServices.Marshal.SecureStringToCoTaskMemUnicode(System.Security.SecureString)" /> method.</summary><param name="s">The address of the unmanaged string to free.</param>
        [SecurityCriticalAttribute()]
        public static void ZeroFreeCoTaskMemUnicode(IntPtr s)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Copies the contents of a managed <see cref="T:System.Security.SecureString" /> into unmanaged memory, converting into ANSI format as it copies.</summary><returns>The address, in unmanaged memory, to where the <paramref name="s" /> parameter was copied, or 0 if a null object was supplied.</returns><param name="s">The managed object to copy.</param><exception cref="T:System.ArgumentNullException">The <paramref name="s" /> parameter is null.</exception><exception cref="T:System.NotSupportedException">The current computer is not running Windows 2000 Service Pack 3 or later.</exception><exception cref="T:System.OutOfMemoryException">There is insufficient memory available.</exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static IntPtr SecureStringToGlobalAllocAnsi(SecureString s)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Copies the contents of a managed <see cref="T:System.Security.SecureString" /> object into unmanaged memory.</summary><returns>The address, in unmanaged memory, where <paramref name="s" /> was copied, or 0 if <paramref name="s" /> is a <see cref="T:System.Security.SecureString" /> object whose length is 0.</returns><param name="s">The managed object to copy.</param><exception cref="T:System.ArgumentNullException">The <paramref name="s" /> parameter is null.</exception><exception cref="T:System.NotSupportedException">The current computer is not running Windows 2000 Service Pack 3 or later.</exception><exception cref="T:System.OutOfMemoryException">There is insufficient memory available.</exception>
        [SecurityCriticalAttribute()]
        public static IntPtr SecureStringToGlobalAllocUnicode(SecureString s)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Frees an unmanaged string pointer that was allocated using the <see cref="M:System.Runtime.InteropServices.Marshal.SecureStringToGlobalAllocAnsi(System.Security.SecureString)" /> method.</summary><param name="s">The address of the unmanaged string to free.</param><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static void ZeroFreeGlobalAllocAnsi(IntPtr s)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Frees an unmanaged string pointer that was allocated using the <see cref="M:System.Runtime.InteropServices.Marshal.SecureStringToGlobalAllocUnicode(System.Security.SecureString)" /> method.</summary><param name="s">The address of the unmanaged string to free.</param>
        [SecurityCriticalAttribute()]
        public static void ZeroFreeGlobalAllocUnicode(IntPtr s)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
