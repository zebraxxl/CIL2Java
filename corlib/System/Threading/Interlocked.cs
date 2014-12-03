using System.Runtime.ConstrainedExecution;
using System.Security;
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace System.Threading
{
    /// <summary>
    /// Provides atomic operations for variables that are shared by multiple threads.
    /// </summary>
    /// <filterpriority>2</filterpriority>
    public static class Interlocked
    {
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.Success)]
        public static int Increment(ref int location)
        {
             throw new NotImplementedException();
        }
        
        
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.Success)]
        public static long Increment(ref long location)
        {
             throw new NotImplementedException();
        }
        
        
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.Success)]
        public static int Decrement(ref int location)
        {
             throw new NotImplementedException();
        }
        
        
        public static long Decrement(ref long location)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.Success)]
        public static int Exchange(ref int location1, int value)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public static long Exchange(ref long location1, long value)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public static float Exchange(ref float location1, float value)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public static double Exchange(ref double location1, double value)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.Success)]
        public static object Exchange(ref object location1, object value)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.Success)]
        public static IntPtr Exchange(ref IntPtr location1, IntPtr value)
        {
             throw new NotImplementedException();
        }
        
        
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.Success)]
        [ComVisibleAttribute(false)]
        [SecuritySafeCriticalAttribute()]
        public static T Exchange<T>(ref T location1, T value)
        {
             throw new NotImplementedException();
        }
        
        
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.Success)]
        [SecuritySafeCriticalAttribute()]
        public static int CompareExchange(ref int location1, int value, int comparand)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public static long CompareExchange(ref long location1, long value, long comparand)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public static float CompareExchange(ref float location1, float value, float comparand)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public static double CompareExchange(ref double location1, double value, double comparand)
        {
             throw new NotImplementedException();
        }
        
        
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.Success)]
        [SecuritySafeCriticalAttribute()]
        public static object CompareExchange(ref object location1, object value, object comparand)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.Success)]
        public static IntPtr CompareExchange(ref IntPtr location1, IntPtr value, IntPtr comparand)
        {
             throw new NotImplementedException();
        }
        
        
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.Success)]
        [ComVisibleAttribute(false)]
        [SecuritySafeCriticalAttribute()]
        [MethodImpl(MethodImplOptions.Synchronized)]
        public static T CompareExchange<T>(ref T location1, T value, T comparand)
        {
            T orig = location1;

            if (((location1 == null) && (comparand == null)) || (location1.Equals(comparand)))
                location1 = value;

            return orig;
        }
        
        
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.Success)]
        public static int Add(ref int location1, int value)
        {
             throw new NotImplementedException();
        }
        
        
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.Success)]
        public static long Add(ref long location1, long value)
        {
             throw new NotImplementedException();
        }
        
        
        public static long Read(ref long location)
        {
             throw new NotImplementedException();
        }
        
        
        public static void MemoryBarrier()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
