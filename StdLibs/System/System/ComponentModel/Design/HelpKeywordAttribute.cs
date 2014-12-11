using System;

namespace System.ComponentModel.Design
{
    [Serializable]
    [AttributeUsageAttribute(AttributeTargets.All, AllowMultiple = false, Inherited = false)]
    public sealed class HelpKeywordAttribute : Attribute
    {
        public static readonly HelpKeywordAttribute Default;
    
        public string HelpKeyword
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public HelpKeywordAttribute()
        {
             throw new NotImplementedException();
        }
        
        
        public HelpKeywordAttribute(string keyword)
        {
             throw new NotImplementedException();
        }
        
        
        public HelpKeywordAttribute(Type t)
        {
             throw new NotImplementedException();
        }
        
        
        public override bool Equals(object obj)
        {
             throw new NotImplementedException();
        }
        
        
        public override int GetHashCode()
        {
             throw new NotImplementedException();
        }
        
        
        public override bool IsDefaultAttribute()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
