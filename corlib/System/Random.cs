using System.Runtime.InteropServices;

namespace System
{
    /// <summary>Represents a pseudo-random number generator, a device that produces a sequence of numbers that meet certain statistical requirements for randomness.</summary><filterpriority>1</filterpriority>
    [Serializable]
    [ComVisibleAttribute(true)]
    public class Random
    {
    
        public Random()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Random" /> class, using the specified seed value.</summary><param name="Seed">A number used to calculate a starting value for the pseudo-random number sequence. If a negative number is specified, the absolute value of the number is used. </param>
        public Random(int Seed)
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual double Sample()
        {
             throw new NotImplementedException();
        }
        
        
        public virtual int Next()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a random number within a specified range.</summary><returns>A 32-bit signed integer greater than or equal to <paramref name="minValue" /> and less than <paramref name="maxValue" />; that is, the range of return values includes <paramref name="minValue" /> but not <paramref name="maxValue" />. If <paramref name="minValue" /> equals <paramref name="maxValue" />, <paramref name="minValue" /> is returned.</returns><param name="minValue">The inclusive lower bound of the random number returned. </param><param name="maxValue">The exclusive upper bound of the random number returned. <paramref name="maxValue" /> must be greater than or equal to <paramref name="minValue" />. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="minValue" /> is greater than <paramref name="maxValue" />. </exception><filterpriority>1</filterpriority>
        public virtual int Next(int minValue, int maxValue)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a nonnegative random number less than the specified maximum.</summary><returns>A 32-bit signed integer greater than or equal to zero, and less than <paramref name="maxValue" />; that is, the range of return values ordinarily includes zero but not <paramref name="maxValue" />. However, if <paramref name="maxValue" /> equals zero, <paramref name="maxValue" /> is returned.</returns><param name="maxValue">The exclusive upper bound of the random number to be generated. <paramref name="maxValue" /> must be greater than or equal to zero. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="maxValue" /> is less than zero. </exception><filterpriority>1</filterpriority>
        public virtual int Next(int maxValue)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual double NextDouble()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Fills the elements of a specified array of bytes with random numbers.</summary><param name="buffer">An array of bytes to contain random numbers. </param><exception cref="T:System.ArgumentNullException"><paramref name="buffer" /> is null. </exception><filterpriority>1</filterpriority>
        public virtual void NextBytes(byte[] buffer)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
