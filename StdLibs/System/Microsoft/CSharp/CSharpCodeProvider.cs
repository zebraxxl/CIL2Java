using System.CodeDom.Compiler;
using System.Collections.Generic;
using System;
using System.ComponentModel;
using System.CodeDom;
using System.IO;

namespace Microsoft.CSharp
{
    public class CSharpCodeProvider : CodeDomProvider
    {
    
        public override string FileExtension
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public CSharpCodeProvider()
        {
             throw new NotImplementedException();
        }
        
        
        public CSharpCodeProvider(IDictionary<string, string> providerOptions)
        {
             throw new NotImplementedException();
        }
        
        
        [ObsoleteAttribute("Callers should not use the ICodeGenerator interface and should instead use the methods directly on the CodeDomProvider class.")]
        public override ICodeGenerator CreateGenerator()
        {
             throw new NotImplementedException();
        }
        
        
        [ObsoleteAttribute("Callers should not use the ICodeCompiler interface and should instead use the methods directly on the CodeDomProvider class.")]
        public override ICodeCompiler CreateCompiler()
        {
             throw new NotImplementedException();
        }
        
        
        public override TypeConverter GetConverter(Type type)
        {
             throw new NotImplementedException();
        }
        
        
        public override void GenerateCodeFromMember(CodeTypeMember member, TextWriter writer, CodeGeneratorOptions options)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
