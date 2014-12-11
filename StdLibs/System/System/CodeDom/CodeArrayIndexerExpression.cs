using System.Runtime.InteropServices;

namespace System.CodeDom
{
    [Serializable]
    [ClassInterfaceAttribute(ClassInterfaceType.AutoDispatch)]
    [ComVisibleAttribute(true)]
    public class CodeArrayIndexerExpression : CodeExpression
    {
    
        public CodeExpression TargetObject
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public CodeExpressionCollection Indices
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public CodeArrayIndexerExpression()
        {
             throw new NotImplementedException();
        }
        
        
        public CodeArrayIndexerExpression(CodeExpression targetObject, params  CodeExpression[] indices)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
