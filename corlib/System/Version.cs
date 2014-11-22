using System.Runtime.InteropServices;

namespace System
{
    /// <summary>Represents the version number of an assembly, operating system, or the common language runtime. This class cannot be inherited.</summary><filterpriority>1</filterpriority>
    [Serializable]
    [ComVisibleAttribute(true)]
    public sealed class Version : ICloneable, IComparable, IComparable<Version>, IEquatable<Version>
    {
    
        /// <summary>Gets the value of the major component of the version number for the current <see cref="T:System.Version" /> object.</summary><returns>The major version number.</returns><filterpriority>1</filterpriority>
        public int Major
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the value of the minor component of the version number for the current <see cref="T:System.Version" /> object.</summary><returns>The minor version number.</returns><filterpriority>1</filterpriority>
        public int Minor
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the value of the build component of the version number for the current <see cref="T:System.Version" /> object.</summary><returns>The build number, or -1 if the build number is undefined.</returns><filterpriority>1</filterpriority>
        public int Build
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the value of the revision component of the version number for the current <see cref="T:System.Version" /> object.</summary><returns>The revision number, or -1 if the revision number is undefined.</returns><filterpriority>1</filterpriority>
        public int Revision
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the high 16 bits of the revision number.</summary><returns>A 16-bit signed integer.</returns>
        public short MajorRevision
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the low 16 bits of the revision number.</summary><returns>A 16-bit signed integer.</returns>
        public short MinorRevision
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Version" /> class with the specified major, minor, build, and revision numbers.</summary><param name="major">The major version number. </param><param name="minor">The minor version number. </param><param name="build">The build number. </param><param name="revision">The revision number. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="major" />, <paramref name="minor" />, <paramref name="build" />, or <paramref name="revision" /> is less than zero. </exception>
        public Version(int major, int minor, int build, int revision)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Version" /> class using the specified major, minor, and build values.</summary><param name="major">The major version number. </param><param name="minor">The minor version number. </param><param name="build">The build number. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="major" />, <paramref name="minor" />, or <paramref name="build" /> is less than zero. </exception>
        public Version(int major, int minor, int build)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Version" /> class using the specified major and minor values.</summary><param name="major">The major version number. </param><param name="minor">The minor version number. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="major" /> or <paramref name="minor" /> is less than zero. </exception>
        public Version(int major, int minor)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Version" /> class using the specified string.</summary><param name="version">A string containing the major, minor, build, and revision numbers, where each number is delimited with a period character ('.'). </param><exception cref="T:System.ArgumentException"><paramref name="version" /> has fewer than two components or more than four components. </exception><exception cref="T:System.ArgumentNullException"><paramref name="version" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException">A major, minor, build, or revision component is less than zero. </exception><exception cref="T:System.FormatException">At least one component of <paramref name="version" /> does not parse to an integer. </exception><exception cref="T:System.OverflowException">At least one component of <paramref name="version" /> represents a number greater than <see cref="F:System.Int32.MaxValue" />.</exception>
        public Version(string version)
        {
             throw new NotImplementedException();
        }
        
        
        public Version()
        {
             throw new NotImplementedException();
        }
        
        
        public object Clone()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Compares the current <see cref="T:System.Version" /> object to a specified object and returns an indication of their relative values.</summary><returns>A signed integer that indicates the relative values of the two objects, as shown in the following table.Return value Meaning Less than zero The current <see cref="T:System.Version" /> object is a version before <paramref name="version" />. Zero The current <see cref="T:System.Version" /> object is the same version as <paramref name="version" />. Greater than zero The current <see cref="T:System.Version" /> object is a version subsequent to <paramref name="version" />.-or- <paramref name="version" /> is null. </returns><param name="version">An object to compare, or null. </param><exception cref="T:System.ArgumentException"><paramref name="version" /> is not of type <see cref="T:System.Version" />. </exception><filterpriority>1</filterpriority>
        public int CompareTo(object version)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Compares the current <see cref="T:System.Version" /> object to a specified <see cref="T:System.Version" /> object and returns an indication of their relative values.</summary><returns>A signed integer that indicates the relative values of the two objects, as shown in the following table.Return value Meaning Less than zero The current <see cref="T:System.Version" /> object is a version before <paramref name="value" />. Zero The current <see cref="T:System.Version" /> object is the same version as <paramref name="value" />. Greater than zero The current <see cref="T:System.Version" /> object is a version subsequent to <paramref name="value" />. -or-<paramref name="value" /> is null.</returns><param name="value">A <see cref="T:System.Version" /> object to compare to the current <see cref="T:System.Version" /> object, or null.</param><filterpriority>1</filterpriority>
        public int CompareTo(Version value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a value indicating whether the current <see cref="T:System.Version" /> object is equal to a specified object.</summary><returns>true if the current <see cref="T:System.Version" /> object and <paramref name="obj" /> are both <see cref="T:System.Version" /> objects, and every component of the current <see cref="T:System.Version" /> object matches the corresponding component of <paramref name="obj" />; otherwise, false.</returns><param name="obj">An object to compare with the current <see cref="T:System.Version" /> object, or null. </param><filterpriority>1</filterpriority>
        public override bool Equals(object obj)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a value indicating whether the current <see cref="T:System.Version" /> object and a specified <see cref="T:System.Version" /> object represent the same value.</summary><returns>true if every component of the current <see cref="T:System.Version" /> object matches the corresponding component of the <paramref name="obj" /> parameter; otherwise, false.</returns><param name="obj">A <see cref="T:System.Version" /> object to compare to the current <see cref="T:System.Version" /> object, or null.</param><filterpriority>1</filterpriority>
        public bool Equals(Version obj)
        {
             throw new NotImplementedException();
        }
        
        
        public override int GetHashCode()
        {
             throw new NotImplementedException();
        }
        
        
        public override string ToString()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Converts the value of the current <see cref="T:System.Version" /> object to its equivalent <see cref="T:System.String" /> representation. A specified count indicates the number of components to return.</summary><returns>The <see cref="T:System.String" /> representation of the values of the major, minor, build, and revision components of the current <see cref="T:System.Version" /> object, each separated by a period character ('.'). The <paramref name="fieldCount" /> parameter determines how many components are returned.fieldCount Return Value 0 An empty string (""). 1 major 2 major.minor 3 major.minor.build 4 major.minor.build.revision For example, if you create <see cref="T:System.Version" /> object using the constructor Version(1,3,5), ToString(2) returns "1.3" and ToString(4) throws an exception.</returns><param name="fieldCount">The number of components to return. The <paramref name="fieldCount" /> ranges from 0 to 4. </param><exception cref="T:System.ArgumentException"><paramref name="fieldCount" /> is less than 0, or more than 4.-or- <paramref name="fieldCount" /> is more than the number of components defined in the current <see cref="T:System.Version" /> object. </exception><filterpriority>1</filterpriority>
        public string ToString(int fieldCount)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Converts the string representation of a version number to an equivalent <see cref="T:System.Version" /> object.</summary><returns>An object that is equivalent to the version number specified in the <paramref name="input" /> parameter.</returns><param name="input">A string that contains a version number to convert.</param><exception cref="T:System.ArgumentNullException"><paramref name="input" /> is null.</exception><exception cref="T:System.ArgumentException"><paramref name="input" /> has fewer than two or more than four version components.</exception><exception cref="T:System.ArgumentOutOfRangeException">At least one component in <paramref name="input" /> is less than zero.</exception><exception cref="T:System.FormatException">At least one component in <paramref name="input" /> is not an integer.</exception><exception cref="T:System.OverflowException">At least one component in <paramref name="input" /> represents a number that is greater than <see cref="F:System.Int32.MaxValue" />.</exception>
        public static Version Parse(string input)
        {
             throw new NotImplementedException();
        }
        
        
        public static bool TryParse(string input, ref Version result)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether two specified <see cref="T:System.Version" /> objects are equal.</summary><returns>true if <paramref name="v1" /> equals <paramref name="v2" />; otherwise, false.</returns><param name="v1">The first <see cref="T:System.Version" /> object. </param><param name="v2">The second <see cref="T:System.Version" /> object. </param><filterpriority>3</filterpriority>
        /// <summary>Determines whether two specified <see cref="T:System.Version" /> objects are equal.</summary><returns>true if <paramref name="v1" /> equals <paramref name="v2" />; otherwise, false.</returns><param name="v1">The first <see cref="T:System.Version" /> object. </param><param name="v2">The second <see cref="T:System.Version" /> object. </param><filterpriority>3</filterpriority>
        public static bool operator ==(Version v1, Version v2)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether two specified <see cref="T:System.Version" /> objects are not equal.</summary><returns>true if <paramref name="v1" /> does not equal <paramref name="v2" />; otherwise, false.</returns><param name="v1">The first <see cref="T:System.Version" /> object. </param><param name="v2">The second <see cref="T:System.Version" /> object. </param><filterpriority>3</filterpriority>
        /// <summary>Determines whether two specified <see cref="T:System.Version" /> objects are not equal.</summary><returns>true if <paramref name="v1" /> does not equal <paramref name="v2" />; otherwise, false.</returns><param name="v1">The first <see cref="T:System.Version" /> object. </param><param name="v2">The second <see cref="T:System.Version" /> object. </param><filterpriority>3</filterpriority>
        public static bool operator !=(Version v1, Version v2)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether the first specified <see cref="T:System.Version" /> object is less than the second specified <see cref="T:System.Version" /> object.</summary><returns>true if <paramref name="v1" /> is less than <paramref name="v2" />; otherwise, false.</returns><param name="v1">The first <see cref="T:System.Version" /> object. </param><param name="v2">The second <see cref="T:System.Version" /> object. </param><exception cref="T:System.ArgumentNullException"><paramref name="v1" /> is null. </exception><filterpriority>3</filterpriority>
        /// <summary>Determines whether the first specified <see cref="T:System.Version" /> object is less than the second specified <see cref="T:System.Version" /> object.</summary><returns>true if <paramref name="v1" /> is less than <paramref name="v2" />; otherwise, false.</returns><param name="v1">The first <see cref="T:System.Version" /> object. </param><param name="v2">The second <see cref="T:System.Version" /> object. </param><exception cref="T:System.ArgumentNullException"><paramref name="v1" /> is null. </exception><filterpriority>3</filterpriority>
        public static bool operator <(Version v1, Version v2)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether the first specified <see cref="T:System.Version" /> object is less than or equal to the second <see cref="T:System.Version" /> object.</summary><returns>true if <paramref name="v1" /> is less than or equal to <paramref name="v2" />; otherwise, false.</returns><param name="v1">The first <see cref="T:System.Version" /> object. </param><param name="v2">The second <see cref="T:System.Version" /> object. </param><exception cref="T:System.ArgumentNullException"><paramref name="v1" /> is null. </exception><filterpriority>3</filterpriority>
        /// <summary>Determines whether the first specified <see cref="T:System.Version" /> object is less than or equal to the second <see cref="T:System.Version" /> object.</summary><returns>true if <paramref name="v1" /> is less than or equal to <paramref name="v2" />; otherwise, false.</returns><param name="v1">The first <see cref="T:System.Version" /> object. </param><param name="v2">The second <see cref="T:System.Version" /> object. </param><exception cref="T:System.ArgumentNullException"><paramref name="v1" /> is null. </exception><filterpriority>3</filterpriority>
        public static bool operator <=(Version v1, Version v2)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether the first specified <see cref="T:System.Version" /> object is greater than the second specified <see cref="T:System.Version" /> object.</summary><returns>true if <paramref name="v1" /> is greater than <paramref name="v2" />; otherwise, false.</returns><param name="v1">The first <see cref="T:System.Version" /> object. </param><param name="v2">The second <see cref="T:System.Version" /> object. </param><filterpriority>3</filterpriority>
        /// <summary>Determines whether the first specified <see cref="T:System.Version" /> object is greater than the second specified <see cref="T:System.Version" /> object.</summary><returns>true if <paramref name="v1" /> is greater than <paramref name="v2" />; otherwise, false.</returns><param name="v1">The first <see cref="T:System.Version" /> object. </param><param name="v2">The second <see cref="T:System.Version" /> object. </param><filterpriority>3</filterpriority>
        public static bool operator >(Version v1, Version v2)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether the first specified <see cref="T:System.Version" /> object is greater than or equal to the second specified <see cref="T:System.Version" /> object.</summary><returns>true if <paramref name="v1" /> is greater than or equal to <paramref name="v2" />; otherwise, false.</returns><param name="v1">The first <see cref="T:System.Version" /> object. </param><param name="v2">The second <see cref="T:System.Version" /> object. </param><filterpriority>3</filterpriority>
        /// <summary>Determines whether the first specified <see cref="T:System.Version" /> object is greater than or equal to the second specified <see cref="T:System.Version" /> object.</summary><returns>true if <paramref name="v1" /> is greater than or equal to <paramref name="v2" />; otherwise, false.</returns><param name="v1">The first <see cref="T:System.Version" /> object. </param><param name="v2">The second <see cref="T:System.Version" /> object. </param><filterpriority>3</filterpriority>
        public static bool operator >=(Version v1, Version v2)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
