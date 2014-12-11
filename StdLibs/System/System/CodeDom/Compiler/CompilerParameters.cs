using System.Runtime.Serialization;
using System.Collections.Specialized;
using System.Runtime.InteropServices;
using System;
using Microsoft.Win32.SafeHandles;
using System.Security.Policy;

namespace System.CodeDom.Compiler
{
    [Serializable]
    public class CompilerParameters
    {
    
        public string CoreAssemblyFileName
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public bool GenerateExecutable
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public bool GenerateInMemory
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public StringCollection ReferencedAssemblies
        {
            get { throw new NotImplementedException(); }
        }
    
        public string MainClass
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public string OutputAssembly
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public TempFileCollection TempFiles
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public bool IncludeDebugInformation
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public bool TreatWarningsAsErrors
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public int WarningLevel
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public string CompilerOptions
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public string Win32Resource
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        [ComVisibleAttribute(false)]
        public StringCollection EmbeddedResources
        {
            get { throw new NotImplementedException(); }
        }
    
        [ComVisibleAttribute(false)]
        public StringCollection LinkedResources
        {
            get { throw new NotImplementedException(); }
        }
    
        public IntPtr UserToken
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        [ObsoleteAttribute("CAS policy is obsolete and will be removed in a future release of the .NET Framework. Please see http://go2.microsoft.com/fwlink/?LinkId=131738 for more information.")]
        public Evidence Evidence
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public CompilerParameters()
        {
             throw new NotImplementedException();
        }
        
        
        public CompilerParameters(string[] assemblyNames)
        {
             throw new NotImplementedException();
        }
        
        
        public CompilerParameters(string[] assemblyNames, string outputName)
        {
             throw new NotImplementedException();
        }
        
        
        public CompilerParameters(string[] assemblyNames, string outputName, bool includeDebugInformation)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
