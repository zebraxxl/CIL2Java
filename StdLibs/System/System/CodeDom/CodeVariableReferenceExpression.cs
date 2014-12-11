using System.Runtime.InteropServices;

namespace System.CodeDom
{
    [Serializable]
    [ComVisibleAttribute(true)]
    [ClassInterfaceAttribute(ClassInterfaceType.AutoDispatch)]
    public class CodeVariableReferenceExpression : CodeExpression
    {
    
        public string VariableName
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public CodeVariableReferenceExpression()
        {
             throw new NotImplementedException();
        }
        
        
        public CodeVariableReferenceExpression(string variableName)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
