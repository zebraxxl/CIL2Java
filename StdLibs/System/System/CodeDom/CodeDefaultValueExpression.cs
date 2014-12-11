using System.Runtime.InteropServices;

namespace System.CodeDom
{
    [Serializable]
    [ComVisibleAttribute(true)]
    [ClassInterfaceAttribute(ClassInterfaceType.AutoDispatch)]
    public class CodeDefaultValueExpression : CodeExpression
    {
    
        public CodeTypeReference Type
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public CodeDefaultValueExpression()
        {
             throw new NotImplementedException();
        }
        
        
        public CodeDefaultValueExpression(CodeTypeReference type)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
