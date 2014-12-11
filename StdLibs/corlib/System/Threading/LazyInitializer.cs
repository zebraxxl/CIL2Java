using System;

namespace System.Threading
{
    /// <summary>Provides lazy initialization routines.</summary>
    public static class LazyInitializer
    {
        public static T EnsureInitialized<T>(ref T target)
        {
             throw new NotImplementedException();
        }
        
        
        public static T EnsureInitialized<T>(ref T target, Func<T> valueFactory)
        {
             throw new NotImplementedException();
        }
        
        
        public static T EnsureInitialized<T>(ref T target, ref bool initialized, ref object syncLock)
        {
             throw new NotImplementedException();
        }
        
        
        public static T EnsureInitialized<T>(ref T target, ref bool initialized, ref object syncLock, Func<T> valueFactory)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
