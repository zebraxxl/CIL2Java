using System.Runtime.InteropServices;

namespace System.CodeDom
{
    [Serializable]
    [ComVisibleAttribute(true)]
    [ClassInterfaceAttribute(ClassInterfaceType.AutoDispatch)]
    public class CodeTypeDelegate : CodeTypeDeclaration
    {
    
        public CodeTypeReference ReturnType
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public CodeParameterDeclarationExpressionCollection Parameters
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public CodeTypeDelegate()
        {
             throw new NotImplementedException();
        }
        
        
        public CodeTypeDelegate(string name)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
