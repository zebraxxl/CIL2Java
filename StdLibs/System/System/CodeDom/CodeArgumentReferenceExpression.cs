using System.Runtime.InteropServices;

namespace System.CodeDom
{
    [Serializable]
    [ClassInterfaceAttribute(ClassInterfaceType.AutoDispatch)]
    [ComVisibleAttribute(true)]
    public class CodeArgumentReferenceExpression : CodeExpression
    {
    
        public string ParameterName
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public CodeArgumentReferenceExpression()
        {
             throw new NotImplementedException();
        }
        
        
        public CodeArgumentReferenceExpression(string parameterName)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
