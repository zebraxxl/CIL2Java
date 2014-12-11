using System.Runtime.InteropServices;

namespace System.CodeDom
{
    [Serializable]
    [ClassInterfaceAttribute(ClassInterfaceType.AutoDispatch)]
    [ComVisibleAttribute(true)]
    public class CodeAttributeArgument
    {
    
        public string Name
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public CodeExpression Value
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public CodeAttributeArgument()
        {
             throw new NotImplementedException();
        }
        
        
        public CodeAttributeArgument(CodeExpression value)
        {
             throw new NotImplementedException();
        }
        
        
        public CodeAttributeArgument(string name, CodeExpression value)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
