using System;

namespace System.Threading
{
    /// <summary>Represents a callback delegate that has been registered with a <see cref="T:System.Threading.CancellationToken" />. </summary>
    public struct CancellationTokenRegistration : IEquatable<CancellationTokenRegistration>, IDisposable
    {
    
        public void Dispose()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether two <see cref="T:System.Threading.CancellationTokenRegistration" /> instances are equal.</summary><returns>True if the instances are equal; otherwise, false.</returns><param name="left">The first instance.</param><param name="right">The second instance.</param>
        /// <summary>Determines whether two <see cref="T:System.Threading.CancellationTokenRegistration" /> instances are equal.</summary><returns>True if the instances are equal; otherwise, false.</returns><param name="left">The first instance.</param><param name="right">The second instance.</param>
        public static bool operator ==(CancellationTokenRegistration left, CancellationTokenRegistration right)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether two <see cref="T:System.Threading.CancellationTokenRegistration" /> instances are not equal.</summary><returns>True if the instances are not equal; otherwise, false.</returns><param name="left">The first instance.</param><param name="right">The second instance.</param>
        /// <summary>Determines whether two <see cref="T:System.Threading.CancellationTokenRegistration" /> instances are not equal.</summary><returns>True if the instances are not equal; otherwise, false.</returns><param name="left">The first instance.</param><param name="right">The second instance.</param>
        public static bool operator !=(CancellationTokenRegistration left, CancellationTokenRegistration right)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether the current <see cref="T:System.Threading.CancellationTokenRegistration" /> instance is equal to the specified <see cref="T:System.Threading.CancellationTokenRegistration" />.</summary><returns>True, if both this and <paramref name="obj" /> are equal. False, otherwise.Two <see cref="T:System.Threading.CancellationTokenRegistration" /> instances are equal if they both refer to the output of a single call to the same Register method of a <see cref="T:System.Threading.CancellationToken" />.</returns><param name="obj">The other object to which to compare this instance.</param>
        public override bool Equals(object obj)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether the current <see cref="T:System.Threading.CancellationTokenRegistration" /> instance is equal to the specified <see cref="T:System.Threading.CancellationTokenRegistration" />.</summary><returns>True, if both this and <paramref name="other" /> are equal. False, otherwise. Two <see cref="T:System.Threading.CancellationTokenRegistration" /> instances are equal if they both refer to the output of a single call to the same Register method of a <see cref="T:System.Threading.CancellationToken" />.</returns><param name="other">The other <see cref="T:System.Threading.CancellationTokenRegistration" /> to which to compare this instance.</param>
        public bool Equals(CancellationTokenRegistration other)
        {
             throw new NotImplementedException();
        }
        
        
        public override int GetHashCode()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
