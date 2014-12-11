using System.Security;
using System;
using System.Runtime.ConstrainedExecution;

namespace System.Runtime.CompilerServices
{
    /// <summary>Provides a set of static methods and properties that provide support for compilers. This class cannot be inherited.</summary>
    public static class RuntimeHelpers
    {
        public delegate void TryCode(object userData);
    
        public delegate void CleanupCode(object userData, bool exceptionThrown);
    
        /// <summary>Gets the offset, in bytes, to the data in the given string.</summary><returns>The byte offset, from the start of the <see cref="T:System.String" /> object to the first character in the string.</returns>
        public static int OffsetToStringData
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Provides a fast way to initialize an array from data that is stored in a module.</summary><param name="array">The array to be initialized. </param><param name="fldHandle">A field handle that specifies the location of the data used to initialize the array. </param>
        [SecuritySafeCriticalAttribute()]
        public static void InitializeArray(Array array, RuntimeFieldHandle fldHandle)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Boxes a value type.</summary><returns>A boxed copy of <paramref name="obj" /> if it is a value class; otherwise, <paramref name="obj" /> itself.</returns><param name="obj">The value type to be boxed. </param>
        [SecuritySafeCriticalAttribute()]
        public static object GetObjectValue(object obj)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Runs a specified class constructor method.</summary><param name="type">A type handle that specifies the class constructor method to run. </param><exception cref="T:System.TypeInitializationException">The class initializer throws an exception. </exception>
        public static void RunClassConstructor(RuntimeTypeHandle type)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Runs a specified module constructor method.</summary><param name="module">A handle that specifies the module constructor method to run.</param><exception cref="T:System.TypeInitializationException">The module constructor throws an exception. </exception>
        public static void RunModuleConstructor(ModuleHandle module)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Prepares a method for inclusion in a constrained execution region (CER).</summary><param name="method">A handle to the method to prepare.</param><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static void PrepareMethod(RuntimeMethodHandle method)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Prepares a method for inclusion in a constrained execution region (CER) with the specified instantiation.</summary><param name="method">A handle to the method to prepare.</param><param name="instantiation">The instantiation to pass to the method.</param><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static void PrepareMethod(RuntimeMethodHandle method, RuntimeTypeHandle[] instantiation)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Indicates that the specified delegate should be prepared for inclusion in a constrained execution region (CER).</summary><param name="d">The delegate type to prepare.</param><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static void PrepareDelegate(Delegate d)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Provides a way for applications to dynamically prepare <see cref="T:System.AppDomain" /> event delegates.</summary><param name="d">The event delegate to prepare.</param>
        [SecurityCriticalAttribute()]
        public static void PrepareContractedDelegate(Delegate d)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Serves as a hash function for a particular type, suitable for use in hashing algorithms and data structures such as a hash table.</summary><returns>A hash code for the <see cref="T:System.Object" /> identified by the <paramref name="o" /> parameter.</returns><param name="o">An object to retrieve the hash code for. </param>
        [SecuritySafeCriticalAttribute()]
        public static int GetHashCode(object o)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether the specified <see cref="T:System.Object" /> instances are considered equal.</summary><returns>true if the <paramref name="o1" /> parameter is the same instance as the <paramref name="o2" /> parameter, or if both are null, or if o1.Equals(o2) returns true; otherwise, false.</returns><param name="o1">The first object to compare. </param><param name="o2">The second object to compare. </param>
        [SecuritySafeCriticalAttribute()]
        public static new bool Equals(object o1, object o2)
        {
             throw new NotImplementedException();
        }
        
        
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.Success)]
        [SecuritySafeCriticalAttribute()]
        public static void EnsureSufficientExecutionStack()
        {
             throw new NotImplementedException();
        }
        
        
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.MayFail)]
        [SecurityCriticalAttribute()]
        public static void ProbeForSufficientStack()
        {
             throw new NotImplementedException();
        }
        
        
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.MayFail)]
        [SecurityCriticalAttribute()]
        public static void PrepareConstrainedRegions()
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.MayFail)]
        public static void PrepareConstrainedRegionsNoOP()
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        public static void ExecuteCodeWithGuaranteedCleanup(TryCode code, CleanupCode backoutCode, object userData)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
