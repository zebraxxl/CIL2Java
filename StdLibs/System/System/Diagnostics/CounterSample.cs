using System;

namespace System.Diagnostics
{
    public struct CounterSample
    {
        public static CounterSample Empty;
    
        public long RawValue
        {
            get { throw new NotImplementedException(); }
        }
    
        public long BaseValue
        {
            get { throw new NotImplementedException(); }
        }
    
        public long SystemFrequency
        {
            get { throw new NotImplementedException(); }
        }
    
        public long CounterFrequency
        {
            get { throw new NotImplementedException(); }
        }
    
        public long CounterTimeStamp
        {
            get { throw new NotImplementedException(); }
        }
    
        public long TimeStamp
        {
            get { throw new NotImplementedException(); }
        }
    
        public long TimeStamp100nSec
        {
            get { throw new NotImplementedException(); }
        }
    
        public PerformanceCounterType CounterType
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public CounterSample(long rawValue, long baseValue, long counterFrequency, long systemFrequency, long timeStamp, long timeStamp100nSec, PerformanceCounterType counterType)
        {
             throw new NotImplementedException();
        }
        
        
        public CounterSample(long rawValue, long baseValue, long counterFrequency, long systemFrequency, long timeStamp, long timeStamp100nSec, PerformanceCounterType counterType, long counterTimeStamp)
        {
             throw new NotImplementedException();
        }
        
        
        public static float Calculate(CounterSample counterSample)
        {
             throw new NotImplementedException();
        }
        
        
        public static float Calculate(CounterSample counterSample, CounterSample nextCounterSample)
        {
             throw new NotImplementedException();
        }
        
        
        public override bool Equals(object o)
        {
             throw new NotImplementedException();
        }
        
        
        public bool Equals(CounterSample sample)
        {
             throw new NotImplementedException();
        }
        
        
        public override int GetHashCode()
        {
             throw new NotImplementedException();
        }
        
        
        public static bool operator ==(CounterSample a, CounterSample b)
        {
             throw new NotImplementedException();
        }
        
        
        public static bool operator !=(CounterSample a, CounterSample b)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
