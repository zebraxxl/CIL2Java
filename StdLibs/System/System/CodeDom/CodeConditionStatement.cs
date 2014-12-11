using System.Runtime.InteropServices;

namespace System.CodeDom
{
    [Serializable]
    [ClassInterfaceAttribute(ClassInterfaceType.AutoDispatch)]
    [ComVisibleAttribute(true)]
    public class CodeConditionStatement : CodeStatement
    {
    
        public CodeExpression Condition
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public CodeStatementCollection TrueStatements
        {
            get { throw new NotImplementedException(); }
        }
    
        public CodeStatementCollection FalseStatements
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public CodeConditionStatement()
        {
             throw new NotImplementedException();
        }
        
        
        public CodeConditionStatement(CodeExpression condition, params  CodeStatement[] trueStatements)
        {
             throw new NotImplementedException();
        }
        
        
        public CodeConditionStatement(CodeExpression condition, CodeStatement[] trueStatements, CodeStatement[] falseStatements)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
