using System.Runtime.Serialization;
using System.Security;
using System.Collections.ObjectModel;

namespace System
{
    /// <summary>Represents any time zone in the world.</summary>
    [Serializable]
    public sealed class TimeZoneInfo : IEquatable<TimeZoneInfo>, ISerializable, IDeserializationCallback
    {
        [Serializable]
        public sealed class AdjustmentRule : IEquatable<AdjustmentRule>, ISerializable, IDeserializationCallback
        {
        
            public DateTime DateStart
            {
                get { throw new NotImplementedException(); }
            }
        
            public DateTime DateEnd
            {
                get { throw new NotImplementedException(); }
            }
        
            public TimeSpan DaylightDelta
            {
                get { throw new NotImplementedException(); }
            }
        
            public TransitionTime DaylightTransitionStart
            {
                get { throw new NotImplementedException(); }
            }
        
            public TransitionTime DaylightTransitionEnd
            {
                get { throw new NotImplementedException(); }
            }
        
        
            public bool Equals(AdjustmentRule other)
            {
                 throw new NotImplementedException();
            }
            
            
            public override int GetHashCode()
            {
                 throw new NotImplementedException();
            }
            
            
            public static AdjustmentRule CreateAdjustmentRule(DateTime dateStart, DateTime dateEnd, TimeSpan daylightDelta, TransitionTime daylightTransitionStart, TransitionTime daylightTransitionEnd)
            {
                 throw new NotImplementedException();
            }



            void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
            {
                throw new NotImplementedException();
            }

            void IDeserializationCallback.OnDeserialization(object sender)
            {
                throw new NotImplementedException();
            }
        }
    
        [Serializable]
        public struct TransitionTime : IEquatable<TransitionTime>, ISerializable, IDeserializationCallback
        {
        
            public DateTime TimeOfDay
            {
                get { throw new NotImplementedException(); }
            }
        
            public int Month
            {
                get { throw new NotImplementedException(); }
            }
        
            public int Week
            {
                get { throw new NotImplementedException(); }
            }
        
            public int Day
            {
                get { throw new NotImplementedException(); }
            }
        
            public DayOfWeek DayOfWeek
            {
                get { throw new NotImplementedException(); }
            }
        
            public bool IsFixedDateRule
            {
                get { throw new NotImplementedException(); }
            }
        
        
            public override bool Equals(object obj)
            {
                 throw new NotImplementedException();
            }
            
            
            public static bool operator ==(TransitionTime t1, TransitionTime t2)
            {
                 throw new NotImplementedException();
            }
            
            
            public static bool operator !=(TransitionTime t1, TransitionTime t2)
            {
                 throw new NotImplementedException();
            }
            
            
            public bool Equals(TransitionTime other)
            {
                 throw new NotImplementedException();
            }
            
            
            public override int GetHashCode()
            {
                 throw new NotImplementedException();
            }
            
            
            public static TransitionTime CreateFixedDateRule(DateTime timeOfDay, int month, int day)
            {
                 throw new NotImplementedException();
            }
            
            
            public static TransitionTime CreateFloatingDateRule(DateTime timeOfDay, int month, int week, DayOfWeek dayOfWeek)
            {
                 throw new NotImplementedException();
            }



            void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
            {
                throw new NotImplementedException();
            }

            void IDeserializationCallback.OnDeserialization(object sender)
            {
                throw new NotImplementedException();
            }
        }
    
    
        /// <summary>Gets the time zone identifier.</summary><returns>The time zone identifier.</returns>
        public string Id
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the localized general display name that represents the time zone.</summary><returns>The time zone's localized general display name.</returns>
        public string DisplayName
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the localized display name for the time zone's standard time.</summary><returns>The localized display name of the time zone's standard time.</returns>
        public string StandardName
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the localized display name for the current time zone's daylight saving time.</summary><returns>The display name for the time zone's localized daylight saving time.</returns>
        public string DaylightName
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the time difference between the current time zone's standard time and Coordinated Universal Time (UTC).</summary><returns>An object that indicates the time difference between the current time zone's standard time and Coordinated Universal Time (UTC).</returns>
        public TimeSpan BaseUtcOffset
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value indicating whether the time zone has any daylight saving time rules.</summary><returns>true if the time zone supports daylight saving time; otherwise, false.</returns>
        public bool SupportsDaylightSavingTime
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a <see cref="T:System.TimeZoneInfo" /> object that represents the local time zone.</summary><returns>An object that represents the local time zone.</returns>
        public static TimeZoneInfo Local
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a <see cref="T:System.TimeZoneInfo" /> object that represents the Coordinated Universal Time (UTC) zone.</summary><returns>An object that represents the Coordinated Universal Time (UTC) zone.</returns>
        public static TimeZoneInfo Utc
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public AdjustmentRule[] GetAdjustmentRules()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns information about the possible dates and times that an ambiguous date and time can be mapped to.</summary><returns>An array of objects that represents possible Coordinated Universal Time (UTC) offsets that a particular date and time can be mapped to.</returns><param name="dateTimeOffset">A date and time.</param><exception cref="T:System.ArgumentException"><paramref name="dateTime" /> is not an ambiguous time.</exception><filterpriority>2</filterpriority>
        public TimeSpan[] GetAmbiguousTimeOffsets(DateTimeOffset dateTimeOffset)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns information about the possible dates and times that an ambiguous date and time can be mapped to.</summary><returns>An array of objects that represents possible Coordinated Universal Time (UTC) offsets that a particular date and time can be mapped to.</returns><param name="dateTime">A date and time.</param><exception cref="T:System.ArgumentException"><paramref name="dateTime" /> is not an ambiguous time.</exception><filterpriority>2</filterpriority>
        public TimeSpan[] GetAmbiguousTimeOffsets(DateTime dateTime)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Calculates the offset or difference between the time in this time zone and Coordinated Universal Time (UTC) for a particular date and time.</summary><returns>An object that indicates the time difference between Coordinated Universal Time (UTC) and the current time zone.</returns><param name="dateTimeOffset">The date and time to determine the offset for.</param>
        public TimeSpan GetUtcOffset(DateTimeOffset dateTimeOffset)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Calculates the offset or difference between the time in this time zone and Coordinated Universal Time (UTC) for a particular date and time.</summary><returns>An object that indicates the time difference between the two time zones.</returns><param name="dateTime">The date and time to determine the offset for.   </param>
        public TimeSpan GetUtcOffset(DateTime dateTime)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether a particular date and time in a particular time zone is ambiguous and can be mapped to two or more Coordinated Universal Time (UTC) times.</summary><returns>true if the <paramref name="dateTimeOffset" /> parameter is ambiguous in the current time zone; otherwise, false.</returns><param name="dateTimeOffset">A date and time.</param><filterpriority>2</filterpriority>
        public bool IsAmbiguousTime(DateTimeOffset dateTimeOffset)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether a particular date and time in a particular time zone is ambiguous and can be mapped to two or more Coordinated Universal Time (UTC) times.</summary><returns>true if the <paramref name="dateTime" /> parameter is ambiguous; otherwise, false.</returns><param name="dateTime">A date and time value.   </param><exception cref="T:System.ArgumentException">The <see cref="P:System.DateTime.Kind" /> property of the <paramref name="dateTime" /> value is <see cref="F:System.DateTimeKind.Local" /> and <paramref name="dateTime" /> is an invalid time.</exception><filterpriority>2</filterpriority>
        public bool IsAmbiguousTime(DateTime dateTime)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Indicates whether a specified date and time falls in the range of daylight saving time for the time zone of the current <see cref="T:System.TimeZoneInfo" /> object.</summary><returns>true if the <paramref name="dateTimeOffset" /> parameter is a daylight saving time; otherwise, false.</returns><param name="dateTimeOffset">A date and time value.</param>
        public bool IsDaylightSavingTime(DateTimeOffset dateTimeOffset)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Indicates whether a specified date and time falls in the range of daylight saving time for the time zone of the current <see cref="T:System.TimeZoneInfo" /> object.</summary><returns>true if the <paramref name="dateTime" /> parameter is a daylight saving time; otherwise, false.</returns><param name="dateTime">A date and time value.   </param><exception cref="T:System.ArgumentException">The <see cref="P:System.DateTime.Kind" /> property of the <paramref name="dateTime" /> value is <see cref="F:System.DateTimeKind.Local" /> and <paramref name="dateTime" /> is an invalid time.</exception>
        public bool IsDaylightSavingTime(DateTime dateTime)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Indicates whether a particular date and time is invalid.</summary><returns>true if <paramref name="dateTime" /> is invalid; otherwise, false.</returns><param name="dateTime">A date and time value.   </param><filterpriority>2</filterpriority>
        public bool IsInvalidTime(DateTime dateTime)
        {
             throw new NotImplementedException();
        }
        
        
        public static void ClearCachedData()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Converts a time to the time in another time zone based on the time zone's identifier.</summary><returns>The date and time in the destination time zone.</returns><param name="dateTimeOffset">The date and time to convert.</param><param name="destinationTimeZoneId">The identifier of the destination time zone.</param><exception cref="T:System.ArgumentNullException"><paramref name="destinationTimeZoneId" /> is null.</exception><exception cref="T:System.InvalidTimeZoneException">The time zone identifier was found but the registry data is corrupted.</exception><exception cref="T:System.Security.SecurityException">The process does not have the permissions required to read from the registry key that contains the time zone information.</exception><exception cref="T:System.TimeZoneNotFoundException">The <paramref name="destinationTimeZoneId" /> identifier was not found on the local system.</exception>
        public static DateTimeOffset ConvertTimeBySystemTimeZoneId(DateTimeOffset dateTimeOffset, string destinationTimeZoneId)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Converts a time to the time in another time zone based on the time zone's identifier.</summary><returns>The date and time in the destination time zone.</returns><param name="dateTime">The date and time to convert.</param><param name="destinationTimeZoneId">The identifier of the destination time zone.</param><exception cref="T:System.ArgumentNullException"><paramref name="destinationTimeZoneId" /> is null.</exception><exception cref="T:System.InvalidTimeZoneException">The time zone identifier was found, but the registry data is corrupted.</exception><exception cref="T:System.Security.SecurityException">The process does not have the permissions required to read from the registry key that contains the time zone information.</exception><exception cref="T:System.TimeZoneNotFoundException">The <paramref name="destinationTimeZoneId" /> identifier was not found on the local system.</exception>
        public static DateTime ConvertTimeBySystemTimeZoneId(DateTime dateTime, string destinationTimeZoneId)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Converts a time from one time zone to another based on time zone identifiers.</summary><returns>The date and time in the destination time zone that corresponds to the <paramref name="dateTime" /> parameter in the source time zone.</returns><param name="dateTime">The date and time to convert.</param><param name="sourceTimeZoneId">The identifier of the source time zone. </param><param name="destinationTimeZoneId">The identifier of the destination time zone.</param><exception cref="T:System.ArgumentException">The <see cref="P:System.DateTime.Kind" /> property of the <paramref name="dateTime" /> parameter does not correspond to the source time zone.-or-<paramref name="dateTime" /> is an invalid time in the source time zone.</exception><exception cref="T:System.ArgumentNullException"><paramref name="sourceTimeZoneId" /> is null.-or-<paramref name="destinationTimeZoneId" /> is null.</exception><exception cref="T:System.InvalidTimeZoneException">The time zone identifiers were found, but the registry data is corrupted.</exception><exception cref="T:System.Security.SecurityException">The process does not have the permissions required to read from the registry key that contains the time zone information.</exception><exception cref="T:System.TimeZoneNotFoundException">The <paramref name="sourceTimeZoneId" /> identifier was not found on the local system.-or-The <paramref name="destinationTimeZoneId" /> identifier was not found on the local system.</exception><exception cref="T:System.Security.SecurityException">The user does not have the permissions required to read from the registry keys that hold time zone data.</exception>
        public static DateTime ConvertTimeBySystemTimeZoneId(DateTime dateTime, string sourceTimeZoneId, string destinationTimeZoneId)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Converts a time to the time in a particular time zone.</summary><returns>The date and time in the destination time zone.</returns><param name="dateTimeOffset">The date and time to convert.   </param><param name="destinationTimeZone">The time zone to convert <paramref name="dateTime" /> to.</param><exception cref="T:System.ArgumentNullException">The value of the <paramref name="destinationTimeZone" /> parameter is null.</exception>
        public static DateTimeOffset ConvertTime(DateTimeOffset dateTimeOffset, TimeZoneInfo destinationTimeZone)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Converts a time to the time in a particular time zone.</summary><returns>The date and time in the destination time zone.</returns><param name="dateTime">The date and time to convert.   </param><param name="destinationTimeZone">The time zone to convert <paramref name="dateTime" /> to.</param><exception cref="T:System.ArgumentException">The value of the <paramref name="dateTime" /> parameter represents an invalid time.</exception><exception cref="T:System.ArgumentNullException">The value of the <paramref name="destinationTimeZone" /> parameter is null.</exception>
        public static DateTime ConvertTime(DateTime dateTime, TimeZoneInfo destinationTimeZone)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Converts a time from one time zone to another.</summary><returns>The date and time in the destination time zone that corresponds to the <paramref name="dateTime" /> parameter in the source time zone.</returns><param name="dateTime">The date and time to convert.</param><param name="sourceTimeZone">The time zone of <paramref name="dateTime" />.</param><param name="destinationTimeZone">The time zone to convert <paramref name="dateTime" /> to.</param><exception cref="T:System.ArgumentException">The <see cref="P:System.DateTime.Kind" /> property of the <paramref name="dateTime" /> parameter is <see cref="F:System.DateTimeKind.Local" />, but the <paramref name="sourceTimeZone" /> parameter does not equal <see cref="F:System.DateTimeKind.Local" />.-or-The <see cref="P:System.DateTime.Kind" /> property of the <paramref name="dateTime" /> parameter is <see cref="F:System.DateTimeKind.Utc" />, but the <paramref name="sourceTimeZone" /> parameter does not equal <see cref="P:System.TimeZoneInfo.Utc" />.-or-The <paramref name="dateTime" /> parameter is an invalid time (that is, it represents a time that does not exist because of a time zone's adjustment rules).</exception><exception cref="T:System.ArgumentNullException">The <paramref name="sourceTimeZone" /> parameter is null.-or-The <paramref name="destinationTimeZone" /> parameter is null.</exception>
        public static DateTime ConvertTime(DateTime dateTime, TimeZoneInfo sourceTimeZone, TimeZoneInfo destinationTimeZone)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Converts a Coordinated Universal Time (UTC) to the time in a specified time zone.</summary><returns>The date and time in the destination time zone. Its <see cref="P:System.DateTime.Kind" /> property is <see cref="F:System.DateTimeKind.Utc" /> if <paramref name="destinationTimeZone" /> is <see cref="P:System.TimeZoneInfo.Utc" />; otherwise, its <see cref="P:System.DateTime.Kind" /> property is <see cref="F:System.DateTimeKind.Unspecified" />.</returns><param name="dateTime">The Coordinated Universal Time (UTC).</param><param name="destinationTimeZone">The time zone to convert <paramref name="dateTime" /> to.</param><exception cref="T:System.ArgumentException">The <see cref="P:System.DateTime.Kind" /> property of <paramref name="dateTime" /> is <see cref="F:System.DateTimeKind.Local" />.</exception><exception cref="T:System.ArgumentNullException"><paramref name="destinationTimeZone" /> is null.</exception>
        public static DateTime ConvertTimeFromUtc(DateTime dateTime, TimeZoneInfo destinationTimeZone)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Converts the current date and time to Coordinated Universal Time (UTC).</summary><returns>The Coordinated Universal Time (UTC) that corresponds to the <paramref name="dateTime" /> parameter. The <see cref="T:System.DateTime" /> value's <see cref="P:System.DateTime.Kind" /> property is always set to <see cref="F:System.DateTimeKind.Utc" />.</returns><param name="dateTime">The date and time to convert.</param><exception cref="T:System.ArgumentException">TimeZoneInfo.Local.IsInvalidDateTime(<paramref name="dateTime" />) returns true.</exception>
        public static DateTime ConvertTimeToUtc(DateTime dateTime)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Converts the time in a specified time zone to Coordinated Universal Time (UTC).</summary><returns>The Coordinated Universal Time (UTC) that corresponds to the <paramref name="dateTime" /> parameter. The <see cref="T:System.DateTime" /> object's <see cref="P:System.DateTime.Kind" /> property is always set to <see cref="F:System.DateTimeKind.Utc" />.</returns><param name="dateTime">The date and time to convert.</param><param name="sourceTimeZone">The time zone of <paramref name="dateTime" />.</param><exception cref="T:System.ArgumentException"><paramref name="dateTime" />.Kind is <see cref="F:System.DateTimeKind.Utc" /> and <paramref name="sourceTimeZone" /> does not equal <see cref="P:System.TimeZoneInfo.Utc" />.-or-<paramref name="dateTime" />.Kind is <see cref="F:System.DateTimeKind.Local" /> and <paramref name="sourceTimeZone" /> does not equal <see cref="P:System.TimeZoneInfo.Local" />.-or-<paramref name="sourceTimeZone" />.IsInvalidDateTime(<paramref name="dateTime" />) returns true.</exception><exception cref="T:System.ArgumentNullException"><paramref name="sourceTimeZone" /> is null.</exception>
        public static DateTime ConvertTimeToUtc(DateTime dateTime, TimeZoneInfo sourceTimeZone)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether the current <see cref="T:System.TimeZoneInfo" /> object and another <see cref="T:System.TimeZoneInfo" /> object are equal.</summary><returns>true if the two <see cref="T:System.TimeZoneInfo" /> objects are equal; otherwise, false.</returns><param name="other">A second object to compare with the current object.  </param><filterpriority>2</filterpriority>
        public bool Equals(TimeZoneInfo other)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether the current <see cref="T:System.TimeZoneInfo" /> object and another object are equal.</summary><returns>true if <paramref name="obj" /> is a <see cref="T:System.TimeZoneInfo" /> object that is equal to the current instance; otherwise, false.</returns><param name="obj">A second object to compare with the current object.  </param>
        public override bool Equals(object obj)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Deserializes a string to re-create an original serialized <see cref="T:System.TimeZoneInfo" /> object.</summary><returns>The original serialized object.</returns><param name="source">The string representation of the serialized <see cref="T:System.TimeZoneInfo" /> object.   </param><exception cref="T:System.ArgumentException">The <paramref name="source" /> parameter is <see cref="F:System.String.Empty" />.</exception><exception cref="T:System.ArgumentNullException">The <paramref name="source" /> parameter is a null string.</exception><exception cref="T:System.Runtime.Serialization.SerializationException">The source parameter cannot be deserialized back into a <see cref="T:System.TimeZoneInfo" /> object.</exception>
        public static TimeZoneInfo FromSerializedString(string source)
        {
             throw new NotImplementedException();
        }
        
        
        public override int GetHashCode()
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public static ReadOnlyCollection<TimeZoneInfo> GetSystemTimeZones()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Indicates whether the current object and another <see cref="T:System.TimeZoneInfo" /> object have the same adjustment rules.</summary><returns>true if the two time zones have identical adjustment rules and an identical base offset; otherwise, false.</returns><param name="other">A second object to compare with the current <see cref="T:System.TimeZoneInfo" /> object.   </param><exception cref="T:System.ArgumentNullException">The <paramref name="other" /> parameter is null.</exception>
        public bool HasSameRules(TimeZoneInfo other)
        {
             throw new NotImplementedException();
        }
        
        
        public string ToSerializedString()
        {
             throw new NotImplementedException();
        }
        
        
        public override string ToString()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates a custom time zone with a specified identifier, an offset from Coordinated Universal Time (UTC), a display name, and a standard time display name.</summary><returns>The new time zone.</returns><param name="id">The time zone's identifier.</param><param name="baseUtcOffset">An object that represents the time difference between this time zone and Coordinated Universal Time (UTC).</param><param name="displayName">The display name of the new time zone.   </param><param name="standardDisplayName">The name of the new time zone's standard time.</param><exception cref="T:System.ArgumentNullException">The <paramref name="id" /> parameter is null.</exception><exception cref="T:System.ArgumentException">The <paramref name="id" /> parameter is an empty string ("").-or-The <paramref name="baseUtcOffset" /> parameter does not represent a whole number of minutes.</exception><exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="baseUtcOffset" /> parameter is greater than 14 hours or less than -14 hours.</exception><filterpriority>2</filterpriority>
        public static TimeZoneInfo CreateCustomTimeZone(string id, TimeSpan baseUtcOffset, string displayName, string standardDisplayName)
        {
             throw new NotImplementedException();
        }
        
        
        public static TimeZoneInfo CreateCustomTimeZone(string id, TimeSpan baseUtcOffset, string displayName, string standardDisplayName, string daylightDisplayName, AdjustmentRule[] adjustmentRules)
        {
             throw new NotImplementedException();
        }
        
        
        public static TimeZoneInfo CreateCustomTimeZone(string id, TimeSpan baseUtcOffset, string displayName, string standardDisplayName, string daylightDisplayName, AdjustmentRule[] adjustmentRules, bool disableDaylightSavingTime)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Retrieves a <see cref="T:System.TimeZoneInfo" /> object from the registry based on its identifier.</summary><returns>An object whose identifier is the value of the <paramref name="id" /> parameter.</returns><param name="id">The time zone identifier, which corresponds to the <see cref="P:System.TimeZoneInfo.Id" /> property.      </param><exception cref="T:System.OutOfMemoryException">The system does not have enough memory to hold information about the time zone.</exception><exception cref="T:System.ArgumentNullException">The <paramref name="id" /> parameter is null.</exception><exception cref="T:System.TimeZoneNotFoundException">The time zone identifier specified by <paramref name="id" /> was not found. This means that a registry key whose name matches <paramref name="id" /> does not exist, or that the key exists but does not contain any time zone data.</exception><exception cref="T:System.Security.SecurityException">The process does not have the permissions required to read from the registry key that contains the time zone information.</exception><exception cref="T:System.InvalidTimeZoneException">The time zone identifier was found, but the registry data is corrupted.</exception>
        public static TimeZoneInfo FindSystemTimeZoneById(string id)
        {
             throw new NotImplementedException();
        }



        void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }

        void IDeserializationCallback.OnDeserialization(object sender)
        {
            throw new NotImplementedException();
        }
    }
}
