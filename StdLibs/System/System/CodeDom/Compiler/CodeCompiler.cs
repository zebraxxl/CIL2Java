using System.CodeDom;

namespace System.CodeDom.Compiler
{
    public abstract class CodeCompiler : CodeGenerator, ICodeCompiler
    {
        protected abstract string FileExtension
        {
            get;
        }
    
        protected abstract string CompilerName
        {
            get;
        }
    
    
        protected virtual CompilerResults FromDom(CompilerParameters options, CodeCompileUnit e)
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual CompilerResults FromFile(CompilerParameters options, string fileName)
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual CompilerResults FromSource(CompilerParameters options, string source)
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual CompilerResults FromDomBatch(CompilerParameters options, CodeCompileUnit[] ea)
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual CompilerResults FromFileBatch(CompilerParameters options, string[] fileNames)
        {
             throw new NotImplementedException();
        }
        
        
        protected abstract void ProcessCompilerOutputLine(CompilerResults results, string line);
        
        
        protected abstract string CmdArgsFromParameters(CompilerParameters options);
        
        
        protected virtual string GetResponseFileCmdArgs(CompilerParameters options, string cmdArgs)
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual CompilerResults FromSourceBatch(CompilerParameters options, string[] sources)
        {
             throw new NotImplementedException();
        }
        
        
        protected static string JoinStringArray(string[] sa, string separator)
        {
             throw new NotImplementedException();
        }
        
        
        protected CodeCompiler()
        {
             throw new NotImplementedException();
        }



        CompilerResults ICodeCompiler.CompileAssemblyFromDom(CompilerParameters options, CodeCompileUnit compilationUnit)
        {
            throw new NotImplementedException();
        }

        CompilerResults ICodeCompiler.CompileAssemblyFromFile(CompilerParameters options, string fileName)
        {
            throw new NotImplementedException();
        }

        CompilerResults ICodeCompiler.CompileAssemblyFromSource(CompilerParameters options, string source)
        {
            throw new NotImplementedException();
        }

        CompilerResults ICodeCompiler.CompileAssemblyFromDomBatch(CompilerParameters options, CodeCompileUnit[] compilationUnits)
        {
            throw new NotImplementedException();
        }

        CompilerResults ICodeCompiler.CompileAssemblyFromFileBatch(CompilerParameters options, string[] fileNames)
        {
            throw new NotImplementedException();
        }

        CompilerResults ICodeCompiler.CompileAssemblyFromSourceBatch(CompilerParameters options, string[] sources)
        {
            throw new NotImplementedException();
        }
    }
}
