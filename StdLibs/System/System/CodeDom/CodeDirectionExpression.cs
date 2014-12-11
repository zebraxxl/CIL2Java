using System.Runtime.InteropServices;

namespace System.CodeDom
{
    [Serializable]
    [ComVisibleAttribute(true)]
    [ClassInterfaceAttribute(ClassInterfaceType.AutoDispatch)]
    public class CodeDirectionExpression : CodeExpression
    {
    
        public CodeExpression Expression
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public FieldDirection Direction
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public CodeDirectionExpression()
        {
             throw new NotImplementedException();
        }
        
        
        public CodeDirectionExpression(FieldDirection direction, CodeExpression expression)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
