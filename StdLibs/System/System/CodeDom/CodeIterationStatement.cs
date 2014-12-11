using System.Runtime.InteropServices;

namespace System.CodeDom
{
    [Serializable]
    [ComVisibleAttribute(true)]
    [ClassInterfaceAttribute(ClassInterfaceType.AutoDispatch)]
    public class CodeIterationStatement : CodeStatement
    {
    
        public CodeStatement InitStatement
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public CodeExpression TestExpression
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public CodeStatement IncrementStatement
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public CodeStatementCollection Statements
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public CodeIterationStatement()
        {
             throw new NotImplementedException();
        }
        
        
        public CodeIterationStatement(CodeStatement initStatement, CodeExpression testExpression, CodeStatement incrementStatement, params  CodeStatement[] statements)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
