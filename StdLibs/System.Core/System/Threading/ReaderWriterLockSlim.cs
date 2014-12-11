using System;

namespace System.Threading
{
    public class ReaderWriterLockSlim : IDisposable
    {
    
        public bool IsReadLockHeld
        {
            get { throw new NotImplementedException(); }
        }
    
        public bool IsUpgradeableReadLockHeld
        {
            get { throw new NotImplementedException(); }
        }
    
        public bool IsWriteLockHeld
        {
            get { throw new NotImplementedException(); }
        }
    
        public LockRecursionPolicy RecursionPolicy
        {
            get { throw new NotImplementedException(); }
        }
    
        public int CurrentReadCount
        {
            get { throw new NotImplementedException(); }
        }
    
        public int RecursiveReadCount
        {
            get { throw new NotImplementedException(); }
        }
    
        public int RecursiveUpgradeCount
        {
            get { throw new NotImplementedException(); }
        }
    
        public int RecursiveWriteCount
        {
            get { throw new NotImplementedException(); }
        }
    
        public int WaitingReadCount
        {
            get { throw new NotImplementedException(); }
        }
    
        public int WaitingUpgradeCount
        {
            get { throw new NotImplementedException(); }
        }
    
        public int WaitingWriteCount
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public ReaderWriterLockSlim()
        {
             throw new NotImplementedException();
        }
        
        
        public ReaderWriterLockSlim(LockRecursionPolicy recursionPolicy)
        {
             throw new NotImplementedException();
        }
        
        
        public void EnterReadLock()
        {
             throw new NotImplementedException();
        }
        
        
        public bool TryEnterReadLock(TimeSpan timeout)
        {
             throw new NotImplementedException();
        }
        
        
        public bool TryEnterReadLock(int millisecondsTimeout)
        {
             throw new NotImplementedException();
        }
        
        
        public void EnterWriteLock()
        {
             throw new NotImplementedException();
        }
        
        
        public bool TryEnterWriteLock(TimeSpan timeout)
        {
             throw new NotImplementedException();
        }
        
        
        public bool TryEnterWriteLock(int millisecondsTimeout)
        {
             throw new NotImplementedException();
        }
        
        
        public void EnterUpgradeableReadLock()
        {
             throw new NotImplementedException();
        }
        
        
        public bool TryEnterUpgradeableReadLock(TimeSpan timeout)
        {
             throw new NotImplementedException();
        }
        
        
        public bool TryEnterUpgradeableReadLock(int millisecondsTimeout)
        {
             throw new NotImplementedException();
        }
        
        
        public void ExitReadLock()
        {
             throw new NotImplementedException();
        }
        
        
        public void ExitWriteLock()
        {
             throw new NotImplementedException();
        }
        
        
        public void ExitUpgradeableReadLock()
        {
             throw new NotImplementedException();
        }
        
        
        public void Dispose()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
