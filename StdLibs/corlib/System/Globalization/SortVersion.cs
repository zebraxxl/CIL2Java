using System;

namespace System.Globalization
{
    /// <summary>Provides information about the version of Unicode used to compare and order strings.</summary>
    [Serializable]
    public sealed class SortVersion : IEquatable<SortVersion>
    {
    
        /// <summary>Gets the full version number of the <see cref="T:System.Globalization.SortVersion" /> object.</summary><returns>The version number of this <see cref="T:System.Globalization.SortVersion" /> object.</returns>
        public int FullVersion
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a globally unique identifier for this <see cref="T:System.Globalization.SortVersion" /> object.</summary><returns>A globally unique identifier for this <see cref="T:System.Globalization.SortVersion" /> object.</returns>
        public Guid SortId
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Creates a new instance of the <see cref="T:System.Globalization.SortVersion" /> class.</summary><param name="fullVersion">A version number.</param><param name="sortId">A sort ID.</param>
        public SortVersion(int fullVersion, Guid sortId)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a value that indicates whether this <see cref="T:System.Globalization.SortVersion" /> instance is equal to a specified object.</summary><returns>true if <paramref name="obj" /> is a <see cref="T:System.Globalization.SortVersion" /> object that represents the same version as this instance; otherwise, false.</returns><param name="obj">An object to compare with this instance.</param>
        public override bool Equals(object obj)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a value that indicates whether this <see cref="T:System.Globalization.SortVersion" /> instance is equal to a specified <see cref="T:System.Globalization.SortVersion" /> object.</summary><returns>true if <paramref name="other" /> represents the same version as this instance; otherwise, false.</returns><param name="other">The object to compare with this instance.</param>
        public bool Equals(SortVersion other)
        {
             throw new NotImplementedException();
        }
        
        
        public override int GetHashCode()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Indicates whether two <see cref="T:System.Globalization.SortVersion" /> instances are equal.</summary><returns>true if the values of <paramref name="left" /> and <paramref name="right" /> are equal; otherwise, false.</returns><param name="left">The first instance to compare.</param><param name="right">The second instance to compare.</param>
        /// <summary>Indicates whether two <see cref="T:System.Globalization.SortVersion" /> instances are equal.</summary><returns>true if the values of <paramref name="left" /> and <paramref name="right" /> are equal; otherwise, false.</returns><param name="left">The first instance to compare.</param><param name="right">The second instance to compare.</param>
        public static bool operator ==(SortVersion left, SortVersion right)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Indicates whether two <see cref="T:System.Globalization.SortVersion" /> instances are not equal.</summary><returns>true if the values of <paramref name="left" /> and <paramref name="right" /> are not equal; otherwise, false.</returns><param name="left">The first instance to compare.</param><param name="right">The second instance to compare.</param>
        /// <summary>Indicates whether two <see cref="T:System.Globalization.SortVersion" /> instances are not equal.</summary><returns>true if the values of <paramref name="left" /> and <paramref name="right" /> are not equal; otherwise, false.</returns><param name="left">The first instance to compare.</param><param name="right">The second instance to compare.</param>
        public static bool operator !=(SortVersion left, SortVersion right)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
