using Microsoft.Win32.SafeHandles;

namespace System.Security.Authentication.ExtendedProtection
{
    public abstract class ChannelBinding : SafeHandleZeroOrMinusOneIsInvalid
    {
        public abstract int Size
        {
            get;
        }
    
    
        protected ChannelBinding()
            : base(false)
        {
             throw new NotImplementedException();
        }
        
        
        protected ChannelBinding(bool ownsHandle)
            : base(ownsHandle)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
