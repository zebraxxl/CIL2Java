using System.Runtime.InteropServices;

namespace System.CodeDom
{
    [Serializable]
    [ComVisibleAttribute(true)]
    [ClassInterfaceAttribute(ClassInterfaceType.AutoDispatch)]
    public class CodePrimitiveExpression : CodeExpression
    {
    
        public object Value
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public CodePrimitiveExpression()
        {
             throw new NotImplementedException();
        }
        
        
        public CodePrimitiveExpression(object value)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
