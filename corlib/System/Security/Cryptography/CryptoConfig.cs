using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Security;
using System;

namespace System.Security.Cryptography
{
    /// <summary>Accesses the cryptography configuration information.</summary>
    [ComVisibleAttribute(true)]
    public class CryptoConfig
    {
    
        /// <summary>Indicates whether the runtime should enforce the policy to create only Federal Information Processing Standard (FIPS) certified algorithms.</summary><returns>true to enforce the policy; otherwise, false. </returns>
        public static bool AllowOnlyFipsAlgorithms
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Adds a set of names to algorithm mappings to be used for the current application domain.  </summary><param name="algorithm">The algorithm to map to.</param><param name="names">An array of names to map to the algorithm.</param><exception cref="T:System.ArgumentNullException">The<paramref name=" algorithm" /> or <paramref name="names" /> parameter is null.</exception><exception cref="T:System.ArgumentException"><paramref name="algorithm" /> cannot be accessed from outside the assembly.-or-One of the entries in the <paramref name="names" /> parameter is empty or null.</exception>
        [SecurityCriticalAttribute()]
        public static void AddAlgorithm(Type algorithm, params  string[] names)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates a new instance of the specified cryptographic object with the specified arguments.</summary><returns>A new instance of the specified cryptographic object.</returns><param name="name">The simple name of the cryptographic object of which to create an instance. </param><param name="args">The arguments used to create the specified cryptographic object. </param><exception cref="T:System.ArgumentNullException">The <paramref name="name" /> parameter is null. </exception><exception cref="T:System.Reflection.TargetInvocationException">The algorithm described by the <paramref name="name" /> parameter was used with Federal Information Processing Standards (FIPS) mode enabled, but is not FIPS compatible.</exception>
        [SecuritySafeCriticalAttribute()]
        public static object CreateFromName(string name, params  object[] args)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates a new instance of the specified cryptographic object.</summary><returns>A new instance of the specified cryptographic object.</returns><param name="name">The simple name of the cryptographic object of which to create an instance. </param><exception cref="T:System.ArgumentNullException">The <paramref name="name" /> parameter is null. </exception><exception cref="T:System.Reflection.TargetInvocationException">The algorithm described by the <paramref name="name" /> parameter was used with Federal Information Processing Standards (FIPS) mode enabled, but is not FIPS compatible.</exception>
        public static object CreateFromName(string name)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Adds a set of names to object identifier (OID) mappings to be used for the current application domain.  </summary><param name="oid">The object identifier (OID) to map to.</param><param name="names">An array of names to map to the OID.</param><exception cref="T:System.ArgumentNullException">The<paramref name=" oid" /> or <paramref name="names" /> parameter is null.</exception><exception cref="T:System.ArgumentException">One of the entries in the <paramref name="names" /> parameter is empty or null.</exception>
        [SecurityCriticalAttribute()]
        public static void AddOID(string oid, params  string[] names)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Gets the object identifier (OID) of the algorithm corresponding to the specified simple name.</summary><returns>The OID of the specified algorithm.</returns><param name="name">The simple name of the algorithm for which to get the OID. </param><exception cref="T:System.ArgumentNullException">The <paramref name="name" /> parameter is null. </exception>
        public static string MapNameToOID(string name)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Encodes the specified object identifier (OID).</summary><returns>A byte array containing the encoded OID.</returns><param name="str">The OID to encode. </param><exception cref="T:System.ArgumentNullException">The <paramref name="str" /> parameter is null. </exception><exception cref="T:System.Security.Cryptography.CryptographicUnexpectedOperationException">An error occurred while encoding the OID. </exception>
        public static byte[] EncodeOID(string str)
        {
             throw new NotImplementedException();
        }
        
        
        public CryptoConfig()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
