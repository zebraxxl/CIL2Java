using System;
using Microsoft.Win32.SafeHandles;
using System.Security;

namespace System.Security.Cryptography
{
    public sealed class CngKey : IDisposable
    {
    
        public CngAlgorithmGroup AlgorithmGroup
        {
            get { throw new NotImplementedException(); }
        }
    
        public CngAlgorithm Algorithm
        {
            get { throw new NotImplementedException(); }
        }
    
        public CngExportPolicies ExportPolicy
        {
            get { throw new NotImplementedException(); }
        }
    
        public SafeNCryptKeyHandle Handle
        {
            get { throw new NotImplementedException(); }
        }
    
        public bool IsEphemeral
        {
            get { throw new NotImplementedException(); }
        }
    
        public bool IsMachineKey
        {
            get { throw new NotImplementedException(); }
        }
    
        public string KeyName
        {
            get { throw new NotImplementedException(); }
        }
    
        public int KeySize
        {
            get { throw new NotImplementedException(); }
        }
    
        public CngKeyUsages KeyUsage
        {
            get { throw new NotImplementedException(); }
        }
    
        public IntPtr ParentWindowHandle
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public CngProvider Provider
        {
            get { throw new NotImplementedException(); }
        }
    
        public SafeNCryptProviderHandle ProviderHandle
        {
            get { throw new NotImplementedException(); }
        }
    
        public string UniqueName
        {
            get { throw new NotImplementedException(); }
        }
    
        public CngUIPolicy UIPolicy
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public static CngKey Create(CngAlgorithm algorithm)
        {
             throw new NotImplementedException();
        }
        
        
        public static CngKey Create(CngAlgorithm algorithm, string keyName)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public static CngKey Create(CngAlgorithm algorithm, string keyName, CngKeyCreationParameters creationParameters)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public void Delete()
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public void Dispose()
        {
             throw new NotImplementedException();
        }
        
        
        public static bool Exists(string keyName)
        {
             throw new NotImplementedException();
        }
        
        
        public static bool Exists(string keyName, CngProvider provider)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public static bool Exists(string keyName, CngProvider provider, CngKeyOpenOptions options)
        {
             throw new NotImplementedException();
        }
        
        
        public static CngKey Import(byte[] keyBlob, CngKeyBlobFormat format)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public static CngKey Import(byte[] keyBlob, CngKeyBlobFormat format, CngProvider provider)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public byte[] Export(CngKeyBlobFormat format)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public CngProperty GetProperty(string name, CngPropertyOptions options)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public bool HasProperty(string name, CngPropertyOptions options)
        {
             throw new NotImplementedException();
        }
        
        
        public static CngKey Open(string keyName)
        {
             throw new NotImplementedException();
        }
        
        
        public static CngKey Open(string keyName, CngProvider provider)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public static CngKey Open(string keyName, CngProvider provider, CngKeyOpenOptions openOptions)
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        public static CngKey Open(SafeNCryptKeyHandle keyHandle, CngKeyHandleOpenOptions keyHandleOpenOptions)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public void SetProperty(CngProperty property)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
