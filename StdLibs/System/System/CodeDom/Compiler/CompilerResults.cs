using System;
using System.Security.Policy;
using System.Reflection;
using System.Collections.Specialized;

namespace System.CodeDom.Compiler
{
    [Serializable]
    public class CompilerResults
    {
    
        public TempFileCollection TempFiles
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
    
        public Assembly CompiledAssembly
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public CompilerErrorCollection Errors
        {
            get { throw new NotImplementedException(); }
        }
    
        public StringCollection Output
        {
            get { throw new NotImplementedException(); }
        }
    
        public string PathToAssembly
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public int NativeCompilerReturnValue
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public CompilerResults(TempFileCollection tempFiles)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
