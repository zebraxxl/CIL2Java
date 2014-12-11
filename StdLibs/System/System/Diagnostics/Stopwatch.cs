using System;

namespace System.Diagnostics
{
    public class Stopwatch
    {
        public static readonly long Frequency;
        public static readonly bool IsHighResolution;
    
        public bool IsRunning
        {
            get { throw new NotImplementedException(); }
        }
    
        public TimeSpan Elapsed
        {
            get { throw new NotImplementedException(); }
        }
    
        public long ElapsedMilliseconds
        {
            get { throw new NotImplementedException(); }
        }
    
        public long ElapsedTicks
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public Stopwatch()
        {
             throw new NotImplementedException();
        }
        
        
        public void Start()
        {
             throw new NotImplementedException();
        }
        
        
        public static Stopwatch StartNew()
        {
             throw new NotImplementedException();
        }
        
        
        public void Stop()
        {
             throw new NotImplementedException();
        }
        
        
        public void Reset()
        {
             throw new NotImplementedException();
        }
        
        
        public void Restart()
        {
             throw new NotImplementedException();
        }
        
        
        public static long GetTimestamp()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
