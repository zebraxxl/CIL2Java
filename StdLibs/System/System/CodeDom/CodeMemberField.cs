using System.Runtime.InteropServices;
using System;

namespace System.CodeDom
{
    [Serializable]
    [ComVisibleAttribute(true)]
    [ClassInterfaceAttribute(ClassInterfaceType.AutoDispatch)]
    public class CodeMemberField : CodeTypeMember
    {
    
        public CodeTypeReference Type
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public CodeExpression InitExpression
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public CodeMemberField()
        {
             throw new NotImplementedException();
        }
        
        
        public CodeMemberField(CodeTypeReference type, string name)
        {
             throw new NotImplementedException();
        }
        
        
        public CodeMemberField(string type, string name)
        {
             throw new NotImplementedException();
        }
        
        
        public CodeMemberField(Type type, string name)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
