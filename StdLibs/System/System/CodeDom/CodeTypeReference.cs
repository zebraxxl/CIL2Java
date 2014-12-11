using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System;

namespace System.CodeDom
{
    [Serializable]
    [ComVisibleAttribute(true)]
    [ClassInterfaceAttribute(ClassInterfaceType.AutoDispatch)]
    public class CodeTypeReference : CodeObject
    {
    
        public CodeTypeReference ArrayElementType
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public int ArrayRank
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public string BaseType
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        [ComVisibleAttribute(false)]
        public CodeTypeReferenceOptions Options
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        [ComVisibleAttribute(false)]
        public CodeTypeReferenceCollection TypeArguments
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public CodeTypeReference()
        {
             throw new NotImplementedException();
        }
        
        
        public CodeTypeReference(Type type)
        {
             throw new NotImplementedException();
        }
        
        
        public CodeTypeReference(Type type, CodeTypeReferenceOptions codeTypeReferenceOption)
        {
             throw new NotImplementedException();
        }
        
        
        public CodeTypeReference(string typeName, CodeTypeReferenceOptions codeTypeReferenceOption)
        {
             throw new NotImplementedException();
        }
        
        
        public CodeTypeReference(string typeName)
        {
             throw new NotImplementedException();
        }
        
        
        public CodeTypeReference(string typeName, params  CodeTypeReference[] typeArguments)
        {
             throw new NotImplementedException();
        }
        
        
        public CodeTypeReference(CodeTypeParameter typeParameter)
        {
             throw new NotImplementedException();
        }
        
        
        public CodeTypeReference(string baseType, int rank)
        {
             throw new NotImplementedException();
        }
        
        
        public CodeTypeReference(CodeTypeReference arrayType, int rank)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
