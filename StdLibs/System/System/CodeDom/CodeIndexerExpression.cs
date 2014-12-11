using System.Runtime.InteropServices;

namespace System.CodeDom
{
    [Serializable]
    [ClassInterfaceAttribute(ClassInterfaceType.AutoDispatch)]
    [ComVisibleAttribute(true)]
    public class CodeIndexerExpression : CodeExpression
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
    
    
        public CodeIndexerExpression()
        {
             throw new NotImplementedException();
        }
        
        
        public CodeIndexerExpression(CodeExpression targetObject, params  CodeExpression[] indices)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
