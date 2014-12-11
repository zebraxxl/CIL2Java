using System.Runtime.InteropServices;
using System;
using System.Runtime.Serialization;
using System.Security;

namespace System.Globalization
{
    /// <summary>Provides information about a specific culture (called a locale for unmanaged code development). The information includes the names for the culture, the writing system, the calendar used, and formatting for dates and sort strings.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    public class CultureInfo : ICloneable, IFormatProvider
    {
    
        /// <summary>Gets the <see cref="T:System.Globalization.CultureInfo" /> object that represents the culture used by the current thread.</summary><returns>An object that represents the culture used by the current thread.</returns>
        public static CultureInfo CurrentCulture
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the <see cref="T:System.Globalization.CultureInfo" /> object that represents the current user interface culture used by the Resource Manager to look up culture-specific resources at run time.</summary><returns>The culture used by the Resource Manager to look up culture-specific resources at run time.</returns><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        public static CultureInfo CurrentUICulture
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the <see cref="T:System.Globalization.CultureInfo" /> that represents the culture installed with the operating system.</summary><returns>The <see cref="T:System.Globalization.CultureInfo" /> that represents the culture installed with the operating system.</returns><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        public static CultureInfo InstalledUICulture
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the default culture for threads in the current application domain.</summary><returns>The default culture for threads in the current application domain, or null if the current system culture is the default thread culture in the application domain.</returns>
        public static CultureInfo DefaultThreadCurrentCulture
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the default UI culture for threads in the current application domain.</summary><returns>The default UI culture for threads in the current application domain, or null if the current system UI culture is the default thread UI culture in the application domain.</returns><exception cref="T:System.ArgumentException">In a set operation, the <see cref="P:System.Globalization.CultureInfo.Name" /> property value is invalid. </exception>
        public static CultureInfo DefaultThreadCurrentUICulture
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the <see cref="T:System.Globalization.CultureInfo" /> object that is culture-independent (invariant).</summary><returns>The object that is culture-independent (invariant).</returns>
        public static CultureInfo InvariantCulture
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the <see cref="T:System.Globalization.CultureInfo" /> that represents the parent culture of the current <see cref="T:System.Globalization.CultureInfo" />.</summary><returns>The <see cref="T:System.Globalization.CultureInfo" /> that represents the parent culture of the current <see cref="T:System.Globalization.CultureInfo" />.</returns><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        public virtual CultureInfo Parent
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the culture identifier for the current <see cref="T:System.Globalization.CultureInfo" />.</summary><returns>The culture identifier for the current <see cref="T:System.Globalization.CultureInfo" />.</returns>
        public virtual int LCID
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the active input locale identifier.</summary><returns>A 32-bit signed number that specifies an input locale identifier.</returns>
        [ComVisibleAttribute(false)]
        public virtual int KeyboardLayoutId
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the culture name in the format languagecode2-country/regioncode2.</summary><returns>The culture name in the format languagecode2-country/regioncode2, where languagecode2 is a lowercase two-letter code derived from ISO 639-1 and country/regioncode2 is an uppercase two-letter code derived from ISO 3166.</returns>
        public virtual string Name
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Deprecated. Gets the RFC 4646 standard identification for a language. </summary><returns>A string that is the RFC 4646 standard identification for a language.</returns>
        [ComVisibleAttribute(false)]
        public string IetfLanguageTag
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the full localized culture name. </summary><returns>The full localized culture name in the format languagefull [country/regionfull], where languagefull is the full name of the language and country/regionfull is the full name of the country/region.</returns>
        public virtual string DisplayName
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the culture name, consisting of the language, the country/region, and the optional script, that the culture is set to display.</summary><returns>The culture name. consisting of the full name of the language, the full name of the country/region, and the optional script. The format is discussed in the description of the <see cref="T:System.Globalization.CultureInfo" /> class.</returns>
        public virtual string NativeName
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the culture name in the format languagefull [country/regionfull] in English.</summary><returns>The culture name in the format languagefull [country/regionfull] in English, where languagefull is the full name of the language and country/regionfull is the full name of the country/region.</returns>
        public virtual string EnglishName
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the ISO 639-1 two-letter code for the language of the current <see cref="T:System.Globalization.CultureInfo" />.</summary><returns>The ISO 639-1 two-letter code for the language of the current <see cref="T:System.Globalization.CultureInfo" />.</returns>
        public virtual string TwoLetterISOLanguageName
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the ISO 639-2 three-letter code for the language of the current <see cref="T:System.Globalization.CultureInfo" />.</summary><returns>The ISO 639-2 three-letter code for the language of the current <see cref="T:System.Globalization.CultureInfo" />.</returns>
        public virtual string ThreeLetterISOLanguageName
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the three-letter code for the language as defined in the Windows API.</summary><returns>The three-letter code for the language as defined in the Windows API.</returns>
        public virtual string ThreeLetterWindowsLanguageName
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the <see cref="T:System.Globalization.CompareInfo" /> that defines how to compare strings for the culture.</summary><returns>The <see cref="T:System.Globalization.CompareInfo" /> that defines how to compare strings for the culture.</returns><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        public virtual CompareInfo CompareInfo
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the <see cref="T:System.Globalization.TextInfo" /> that defines the writing system associated with the culture.</summary><returns>The <see cref="T:System.Globalization.TextInfo" /> that defines the writing system associated with the culture.</returns><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        public virtual TextInfo TextInfo
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value indicating whether the current <see cref="T:System.Globalization.CultureInfo" /> represents a neutral culture.</summary><returns>true if the current <see cref="T:System.Globalization.CultureInfo" /> represents a neutral culture; otherwise, false.</returns>
        public virtual bool IsNeutralCulture
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the culture types that pertain to the current <see cref="T:System.Globalization.CultureInfo" /> object.</summary><returns>A bitwise combination of one or more <see cref="T:System.Globalization.CultureTypes" /> values. There is no default value.</returns>
        [ComVisibleAttribute(false)]
        public CultureTypes CultureTypes
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets a <see cref="T:System.Globalization.NumberFormatInfo" /> that defines the culturally appropriate format of displaying numbers, currency, and percentage.</summary><returns>A <see cref="T:System.Globalization.NumberFormatInfo" /> that defines the culturally appropriate format of displaying numbers, currency, and percentage.</returns><exception cref="T:System.ArgumentNullException">The property is set to null. </exception><exception cref="T:System.InvalidOperationException">The <see cref="P:System.Globalization.CultureInfo.NumberFormat" /> property or any of the <see cref="T:System.Globalization.NumberFormatInfo" /> properties is set, and the <see cref="T:System.Globalization.CultureInfo" /> is read-only. </exception>
        public virtual NumberFormatInfo NumberFormat
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets a <see cref="T:System.Globalization.DateTimeFormatInfo" /> that defines the culturally appropriate format of displaying dates and times.</summary><returns>A <see cref="T:System.Globalization.DateTimeFormatInfo" /> that defines the culturally appropriate format of displaying dates and times.</returns><exception cref="T:System.ArgumentNullException">The property is set to null. </exception><exception cref="T:System.InvalidOperationException">The <see cref="P:System.Globalization.CultureInfo.DateTimeFormat" /> property or any of the <see cref="T:System.Globalization.DateTimeFormatInfo" /> properties is set, and the <see cref="T:System.Globalization.CultureInfo" /> is read-only. </exception>
        public virtual DateTimeFormatInfo DateTimeFormat
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the default calendar used by the culture.</summary><returns>A <see cref="T:System.Globalization.Calendar" /> that represents the default calendar used by the culture.</returns>
        public virtual Calendar Calendar
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the list of calendars that can be used by the culture.</summary><returns>An array of type <see cref="T:System.Globalization.Calendar" /> that represents the calendars that can be used by the culture represented by the current <see cref="T:System.Globalization.CultureInfo" />.</returns>
        public virtual Calendar[] OptionalCalendars
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value indicating whether the current <see cref="T:System.Globalization.CultureInfo" /> uses the user-selected culture settings.</summary><returns>true if the current <see cref="T:System.Globalization.CultureInfo" /> uses the user-selected culture settings; otherwise, false.</returns>
        public bool UseUserOverride
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value indicating whether the current <see cref="T:System.Globalization.CultureInfo" /> is read-only.</summary><returns>true if the current <see cref="T:System.Globalization.CultureInfo" /> is read-only; otherwise, false. The default is false.</returns>
        public bool IsReadOnly
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Globalization.CultureInfo" /> class based on the culture specified by name.</summary><param name="name">A predefined <see cref="T:System.Globalization.CultureInfo" /> name, <see cref="P:System.Globalization.CultureInfo.Name" /> of an existing <see cref="T:System.Globalization.CultureInfo" />, or Windows-only culture name. <paramref name="name" /> is not case-sensitive.</param><exception cref="T:System.ArgumentNullException"><paramref name="name" /> is null. </exception><exception cref="T:System.Globalization.CultureNotFoundException"><paramref name="name" /> is not a valid culture name.</exception>
        public CultureInfo(string name)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Globalization.CultureInfo" /> class based on the culture specified by name and on the Boolean that specifies whether to use the user-selected culture settings from the system.</summary><param name="name">A predefined <see cref="T:System.Globalization.CultureInfo" /> name, <see cref="P:System.Globalization.CultureInfo.Name" /> of an existing <see cref="T:System.Globalization.CultureInfo" />, or Windows-only culture name. <paramref name="name" /> is not case-sensitive.</param><param name="useUserOverride">A Boolean that denotes whether to use the user-selected culture settings (true) or the default culture settings (false). </param><exception cref="T:System.ArgumentNullException"><paramref name="name" /> is null. </exception><exception cref="T:System.Globalization.CultureNotFoundException"><paramref name="name" /> is not a valid culture name.</exception>
        public CultureInfo(string name, bool useUserOverride)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Globalization.CultureInfo" /> class based on the culture specified by the culture identifier.</summary><param name="culture">A predefined <see cref="T:System.Globalization.CultureInfo" /> identifier, <see cref="P:System.Globalization.CultureInfo.LCID" /> property of an existing <see cref="T:System.Globalization.CultureInfo" /> object, or Windows-only culture identifier. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="culture" /> is less than zero. </exception><exception cref="T:System.Globalization.CultureNotFoundException"><paramref name="culture" /> is not a valid culture identifier. </exception>
        public CultureInfo(int culture)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Globalization.CultureInfo" /> class based on the culture specified by the culture identifier and on the Boolean that specifies whether to use the user-selected culture settings from the system.</summary><param name="culture">A predefined <see cref="T:System.Globalization.CultureInfo" /> identifier, <see cref="P:System.Globalization.CultureInfo.LCID" /> property of an existing <see cref="T:System.Globalization.CultureInfo" /> object, or Windows-only culture identifier. </param><param name="useUserOverride">A Boolean that denotes whether to use the user-selected culture settings (true) or the default culture settings (false). </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="culture" /> is less than zero. </exception><exception cref="T:System.Globalization.CultureNotFoundException"><paramref name="culture" /> is not a valid culture identifier.</exception>
        public CultureInfo(int culture, bool useUserOverride)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates a <see cref="T:System.Globalization.CultureInfo" /> that represents the specific culture that is associated with the specified name.</summary><returns>A <see cref="T:System.Globalization.CultureInfo" /> object that represents:The invariant culture, if <paramref name="name" /> is an empty string ("").-or- The specific culture associated with <paramref name="name" />, if <paramref name="name" /> is a neutral culture.-or- The culture specified by <paramref name="name" />, if <paramref name="name" /> is already a specific culture.</returns><param name="name">A predefined <see cref="T:System.Globalization.CultureInfo" /> name or the name of an existing <see cref="T:System.Globalization.CultureInfo" /> object. <paramref name="name" /> is not case-sensitive.</param><exception cref="T:System.Globalization.CultureNotFoundException"><paramref name="name" /> is not a valid culture name.-or- The culture specified by <paramref name="name" /> does not have a specific culture associated with it. </exception><exception cref="T:System.NullReferenceException"><paramref name="name" /> is null. </exception>
        public static CultureInfo CreateSpecificCulture(string name)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Gets the list of supported cultures filtered by the specified <see cref="T:System.Globalization.CultureTypes" /> parameter.</summary><returns>An array that contains the cultures specified by the <paramref name="types" /> parameter. The array of cultures is unsorted.</returns><param name="types">A bitwise combination of the enumeration values that filter the cultures to retrieve. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="types" /> specifies an invalid combination of <see cref="T:System.Globalization.CultureTypes" /> values.</exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        public static CultureInfo[] GetCultures(CultureTypes types)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether the specified object is the same culture as the current <see cref="T:System.Globalization.CultureInfo" />.</summary><returns>true if <paramref name="value" /> is the same culture as the current <see cref="T:System.Globalization.CultureInfo" />; otherwise, false.</returns><param name="value">The object to compare with the current <see cref="T:System.Globalization.CultureInfo" />. </param>
        public override bool Equals(object value)
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
        
        
        /// <summary>Gets an object that defines how to format the specified type.</summary><returns>The value of the <see cref="P:System.Globalization.CultureInfo.NumberFormat" /> property, which is a <see cref="T:System.Globalization.NumberFormatInfo" /> containing the default number format information for the current <see cref="T:System.Globalization.CultureInfo" />, if <paramref name="formatType" /> is the <see cref="T:System.Type" /> object for the <see cref="T:System.Globalization.NumberFormatInfo" /> class.-or- The value of the <see cref="P:System.Globalization.CultureInfo.DateTimeFormat" /> property, which is a <see cref="T:System.Globalization.DateTimeFormatInfo" /> containing the default date and time format information for the current <see cref="T:System.Globalization.CultureInfo" />, if <paramref name="formatType" /> is the <see cref="T:System.Type" /> object for the <see cref="T:System.Globalization.DateTimeFormatInfo" /> class.-or- null, if <paramref name="formatType" /> is any other object.</returns><param name="formatType">The <see cref="T:System.Type" /> for which to get a formatting object. This method only supports the <see cref="T:System.Globalization.NumberFormatInfo" /> and <see cref="T:System.Globalization.DateTimeFormatInfo" /> types. </param>
        public virtual object GetFormat(Type formatType)
        {
             throw new NotImplementedException();
        }
        
        
        public void ClearCachedData()
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        [ComVisibleAttribute(false)]
        public CultureInfo GetConsoleFallbackUICulture()
        {
             throw new NotImplementedException();
        }
        
        
        public virtual object Clone()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a read-only wrapper around the specified <see cref="T:System.Globalization.CultureInfo" />.</summary><returns>A read-only <see cref="T:System.Globalization.CultureInfo" /> wrapper around <paramref name="ci" />.</returns><param name="ci">The <see cref="T:System.Globalization.CultureInfo" /> to wrap. </param><exception cref="T:System.ArgumentNullException"><paramref name="ci" /> is null. </exception>
        public static CultureInfo ReadOnly(CultureInfo ci)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Retrieves a cached, read-only instance of a culture by using the specified culture identifier.</summary><returns>A read-only <see cref="T:System.Globalization.CultureInfo" /> object.</returns><param name="culture">A locale identifier (LCID).</param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="culture" /> is less than zero.</exception><exception cref="T:System.Globalization.CultureNotFoundException"><paramref name="culture" /> specifies a culture that is not supported.</exception>
        public static CultureInfo GetCultureInfo(int culture)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Retrieves a cached, read-only instance of a culture using the specified culture name. </summary><returns>A read-only <see cref="T:System.Globalization.CultureInfo" /> object.</returns><param name="name">The name of a culture. <paramref name="name" /> is not case-sensitive.</param><exception cref="T:System.ArgumentNullException"><paramref name="name" /> is null.</exception><exception cref="T:System.Globalization.CultureNotFoundException"><paramref name="name" /> specifies a culture that is not supported.</exception>
        public static CultureInfo GetCultureInfo(string name)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Retrieves a cached, read-only instance of a culture. Parameters specify a culture that is initialized with the <see cref="T:System.Globalization.TextInfo" /> and <see cref="T:System.Globalization.CompareInfo" /> objects specified by another culture.</summary><returns>A read-only <see cref="T:System.Globalization.CultureInfo" /> object.</returns><param name="name">The name of a culture. <paramref name="name" /> is not case-sensitive.</param><param name="altName">The name of a culture that supplies the <see cref="T:System.Globalization.TextInfo" /> and <see cref="T:System.Globalization.CompareInfo" /> objects used to initialize <paramref name="name" />. <paramref name="altName" /> is not case-sensitive.</param><exception cref="T:System.ArgumentNullException"><paramref name="name" /> or <paramref name="altName" /> is null.</exception><exception cref="T:System.Globalization.CultureNotFoundException"><paramref name="name" /> or <paramref name="altName" /> specifies a culture that is not supported.</exception>
        public static CultureInfo GetCultureInfo(string name, string altName)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Deprecated. Retrieves a read-only <see cref="T:System.Globalization.CultureInfo" /> object having linguistic characteristics that are identified by the specified RFC 4646 language tag.</summary><returns>A read-only <see cref="T:System.Globalization.CultureInfo" /> object.</returns><param name="name">The name of a language as specified by the RFC 4646 standard.</param><exception cref="T:System.ArgumentNullException"><paramref name="name" /> is null.</exception><exception cref="T:System.Globalization.CultureNotFoundException"><paramref name="name" /> does not correspond to a supported culture.</exception>
        public static CultureInfo GetCultureInfoByIetfLanguageTag(string name)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
