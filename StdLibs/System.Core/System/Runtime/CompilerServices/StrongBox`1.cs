
namespace System.Runtime.CompilerServices
{
    public class StrongBox<T> : IStrongBox
    {
        public T Value;
    
    
        public StrongBox()
        {
             throw new NotImplementedException();
        }
        
        
        public StrongBox(T value)
        {
             throw new NotImplementedException();
        }



        object IStrongBox.Value
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
