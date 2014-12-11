
namespace System.Text.RegularExpressions
{
    [Serializable]
    public class Match : Group
    {
    
        public static Match Empty
        {
            get { throw new NotImplementedException(); }
        }
    
        public virtual GroupCollection Groups
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public Match NextMatch()
        {
             throw new NotImplementedException();
        }
        
        
        public virtual string Result(string replacement)
        {
             throw new NotImplementedException();
        }
        
        
        public static Match Synchronized(Match inner)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
