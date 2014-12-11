using System.Runtime.InteropServices;
using System;

namespace System.CodeDom
{
    [Serializable]
    [ComVisibleAttribute(true)]
    [ClassInterfaceAttribute(ClassInterfaceType.AutoDispatch)]
    public class CodeObjectCreateExpression : CodeExpression
    {
    
        public CodeTypeReference CreateType
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public CodeExpressionCollection Parameters
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public CodeObjectCreateExpression()
        {
             throw new NotImplementedException();
        }
        
        
        public CodeObjectCreateExpression(CodeTypeReference createType, params  CodeExpression[] parameters)
        {
             throw new NotImplementedException();
        }
        
        
        public CodeObjectCreateExpression(string createType, params  CodeExpression[] parameters)
        {
             throw new NotImplementedException();
        }
        
        
        public CodeObjectCreateExpression(Type createType, params  CodeExpression[] parameters)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
