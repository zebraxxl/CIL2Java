using System.Runtime.InteropServices;
using System;

namespace System.CodeDom
{
    [Serializable]
    [ClassInterfaceAttribute(ClassInterfaceType.AutoDispatch)]
    [ComVisibleAttribute(true)]
    public class CodeCastExpression : CodeExpression
    {
    
        public CodeTypeReference TargetType
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public CodeExpression Expression
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public CodeCastExpression()
        {
             throw new NotImplementedException();
        }
        
        
        public CodeCastExpression(CodeTypeReference targetType, CodeExpression expression)
        {
             throw new NotImplementedException();
        }
        
        
        public CodeCastExpression(string targetType, CodeExpression expression)
        {
             throw new NotImplementedException();
        }
        
        
        public CodeCastExpression(Type targetType, CodeExpression expression)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
