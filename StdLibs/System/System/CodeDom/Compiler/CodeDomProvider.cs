using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System;
using System.IO;
using System.CodeDom;

namespace System.CodeDom.Compiler
{
    [ToolboxItemAttribute(false)]
    [ComVisibleAttribute(true)]
    public abstract class CodeDomProvider : Component
    {
        public virtual string FileExtension
        {
            get { throw new NotImplementedException(); }
        }
    
        public virtual LanguageOptions LanguageOptions
        {
            get { throw new NotImplementedException(); }
        }
    
    
        [ComVisibleAttribute(false)]
        public static CodeDomProvider CreateProvider(string language, IDictionary<string, string> providerOptions)
        {
             throw new NotImplementedException();
        }
        
        
        [ComVisibleAttribute(false)]
        public static CodeDomProvider CreateProvider(string language)
        {
             throw new NotImplementedException();
        }
        
        
        [ComVisibleAttribute(false)]
        public static string GetLanguageFromExtension(string extension)
        {
             throw new NotImplementedException();
        }
        
        
        [ComVisibleAttribute(false)]
        public static bool IsDefinedLanguage(string language)
        {
             throw new NotImplementedException();
        }
        
        
        [ComVisibleAttribute(false)]
        public static bool IsDefinedExtension(string extension)
        {
             throw new NotImplementedException();
        }
        
        
        [ComVisibleAttribute(false)]
        public static CompilerInfo GetCompilerInfo(string language)
        {
             throw new NotImplementedException();
        }
        
        
        [ComVisibleAttribute(false)]
        public static CompilerInfo[] GetAllCompilerInfo()
        {
             throw new NotImplementedException();
        }
        
        
        [ObsoleteAttribute("Callers should not use the ICodeGenerator interface and should instead use the methods directly on the CodeDomProvider class. Those inheriting from CodeDomProvider must still implement this interface, and should exclude this warning or also obsolete this method.")]
        public abstract ICodeGenerator CreateGenerator();
        
        
        public virtual ICodeGenerator CreateGenerator(TextWriter output)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual ICodeGenerator CreateGenerator(string fileName)
        {
             throw new NotImplementedException();
        }
        
        
        [ObsoleteAttribute("Callers should not use the ICodeCompiler interface and should instead use the methods directly on the CodeDomProvider class. Those inheriting from CodeDomProvider must still implement this interface, and should exclude this warning or also obsolete this method.")]
        public abstract ICodeCompiler CreateCompiler();
        
        
        [ObsoleteAttribute("Callers should not use the ICodeParser interface and should instead use the methods directly on the CodeDomProvider class. Those inheriting from CodeDomProvider must still implement this interface, and should exclude this warning or also obsolete this method.")]
        public virtual ICodeParser CreateParser()
        {
             throw new NotImplementedException();
        }
        
        
        public virtual TypeConverter GetConverter(Type type)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual CompilerResults CompileAssemblyFromDom(CompilerParameters options, params  CodeCompileUnit[] compilationUnits)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual CompilerResults CompileAssemblyFromFile(CompilerParameters options, params  string[] fileNames)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual CompilerResults CompileAssemblyFromSource(CompilerParameters options, params  string[] sources)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual bool IsValidIdentifier(string value)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual string CreateEscapedIdentifier(string value)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual string CreateValidIdentifier(string value)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual string GetTypeOutput(CodeTypeReference type)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual bool Supports(GeneratorSupport generatorSupport)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual void GenerateCodeFromExpression(CodeExpression expression, TextWriter writer, CodeGeneratorOptions options)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual void GenerateCodeFromStatement(CodeStatement statement, TextWriter writer, CodeGeneratorOptions options)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual void GenerateCodeFromNamespace(CodeNamespace codeNamespace, TextWriter writer, CodeGeneratorOptions options)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual void GenerateCodeFromCompileUnit(CodeCompileUnit compileUnit, TextWriter writer, CodeGeneratorOptions options)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual void GenerateCodeFromType(CodeTypeDeclaration codeType, TextWriter writer, CodeGeneratorOptions options)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual void GenerateCodeFromMember(CodeTypeMember member, TextWriter writer, CodeGeneratorOptions options)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual CodeCompileUnit Parse(TextReader codeStream)
        {
             throw new NotImplementedException();
        }
        
        
        protected CodeDomProvider()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
