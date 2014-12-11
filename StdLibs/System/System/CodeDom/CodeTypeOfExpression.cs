using System.Runtime.InteropServices;
using System;

namespace System.CodeDom
{
    [Serializable]
    [ClassInterfaceAttribute(ClassInterfaceType.AutoDispatch)]
    [ComVisibleAttribute(true)]
    public class CodeTypeOfExpression : CodeExpression
    {
    
        public CodeTypeReference Type
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public CodeTypeOfExpression()
        {
             throw new NotImplementedException();
        }
        
        
        public CodeTypeOfExpression(CodeTypeReference type)
        {
             throw new NotImplementedException();
        }
        
        
        public CodeTypeOfExpression(string type)
        {
             throw new NotImplementedException();
        }
        
        
        public CodeTypeOfExpression(Type type)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
