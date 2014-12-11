using System.Runtime.InteropServices;

namespace System.CodeDom
{
    [Serializable]
    [ComVisibleAttribute(true)]
    [ClassInterfaceAttribute(ClassInterfaceType.AutoDispatch)]
    public class CodeTryCatchFinallyStatement : CodeStatement
    {
    
        public CodeStatementCollection TryStatements
        {
            get { throw new NotImplementedException(); }
        }
    
        public CodeCatchClauseCollection CatchClauses
        {
            get { throw new NotImplementedException(); }
        }
    
        public CodeStatementCollection FinallyStatements
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public CodeTryCatchFinallyStatement()
        {
             throw new NotImplementedException();
        }
        
        
        public CodeTryCatchFinallyStatement(CodeStatement[] tryStatements, CodeCatchClause[] catchClauses)
        {
             throw new NotImplementedException();
        }
        
        
        public CodeTryCatchFinallyStatement(CodeStatement[] tryStatements, CodeCatchClause[] catchClauses, CodeStatement[] finallyStatements)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
