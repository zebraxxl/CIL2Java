using System.CodeDom;

namespace System.CodeDom.Compiler
{
    public interface ICodeCompiler
    {
        CompilerResults CompileAssemblyFromDom(CompilerParameters options, CodeCompileUnit compilationUnit);
        
        
        CompilerResults CompileAssemblyFromFile(CompilerParameters options, string fileName);
        
        
        CompilerResults CompileAssemblyFromSource(CompilerParameters options, string source);
        
        
        CompilerResults CompileAssemblyFromDomBatch(CompilerParameters options, CodeCompileUnit[] compilationUnits);
        
        
        CompilerResults CompileAssemblyFromFileBatch(CompilerParameters options, string[] fileNames);
        
        
        CompilerResults CompileAssemblyFromSourceBatch(CompilerParameters options, string[] sources);
        
        
    }
}
