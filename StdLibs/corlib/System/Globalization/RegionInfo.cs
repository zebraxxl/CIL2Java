using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;

namespace System.Globalization
{
    /// <summary>Contains information about the country/region.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    public class RegionInfo
    {
    
        /// <summary>Gets the <see cref="T:System.Globalization.RegionInfo" /> that represents the country/region used by the current thread.</summary><returns>The <see cref="T:System.Globalization.RegionInfo" /> that represents the country/region used by the current thread.</returns>
        public static RegionInfo CurrentRegion
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the name or ISO 3166 two-letter country/region code for the current <see cref="T:System.Globalization.RegionInfo" /> object.</summary><returns>The value specified by the <paramref name="name" /> parameter of the <see cref="M:System.Globalization.RegionInfo.#ctor(System.String)" /> constructor. The return value is in uppercase.-or-The two-letter code defined in ISO 3166 for the country/region specified by the <paramref name="culture" /> parameter of the <see cref="M:System.Globalization.RegionInfo.#ctor(System.Int32)" /> constructor. The return value is in uppercase.</returns>
        public virtual string Name
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the full name of the country/region in English.</summary><returns>The full name of the country/region in English.</returns>
        public virtual string EnglishName
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the full name of the country/region in the language of the localized version of .NET Framework.</summary><returns>The full name of the country/region in the language of the localized version of .NET Framework.</returns>
        public virtual string DisplayName
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the name of a country/region formatted in the native language of the country/region.</summary><returns>The native name of the country/region formatted in the language associated with the ISO 3166 country/region code. </returns>
        [ComVisibleAttribute(false)]
        public virtual string NativeName
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the two-letter code defined in ISO 3166 for the country/region.</summary><returns>The two-letter code defined in ISO 3166 for the country/region.</returns>
        public virtual string TwoLetterISORegionName
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the three-letter code defined in ISO 3166 for the country/region.</summary><returns>The three-letter code defined in ISO 3166 for the country/region.</returns>
        public virtual string ThreeLetterISORegionName
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the three-letter code assigned by Windows to the country/region represented by this <see cref="T:System.Globalization.RegionInfo" />.</summary><returns>The three-letter code assigned by Windows to the country/region represented by this <see cref="T:System.Globalization.RegionInfo" />.</returns>
        public virtual string ThreeLetterWindowsRegionName
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value indicating whether the country/region uses the metric system for measurements.</summary><returns>true if the country/region uses the metric system for measurements; otherwise, false.</returns>
        public virtual bool IsMetric
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a unique identification number for a geographical region, country, city, or location.</summary><returns>A 32-bit signed number that uniquely identifies a geographical location.</returns>
        [ComVisibleAttribute(false)]
        public virtual int GeoId
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the name, in English, of the currency used in the country/region.</summary><returns>The name, in English, of the currency used in the country/region.</returns>
        [ComVisibleAttribute(false)]
        public virtual string CurrencyEnglishName
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the name of the currency used in the country/region, formatted in the native language of the country/region. </summary><returns>The native name of the currency used in the country/region, formatted in the language associated with the ISO 3166 country/region code. </returns>
        [ComVisibleAttribute(false)]
        public virtual string CurrencyNativeName
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the currency symbol associated with the country/region.</summary><returns>The currency symbol associated with the country/region.</returns>
        public virtual string CurrencySymbol
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the three-character ISO 4217 currency symbol associated with the country/region.</summary><returns>The three-character ISO 4217 currency symbol associated with the country/region.</returns>
        public virtual string ISOCurrencySymbol
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Globalization.RegionInfo" /> class based on the country/region or specific culture, specified by name.</summary><param name="name">A string that contains a two-letter code defined in ISO 3166 for country/region.-or-A string that contains the culture name for a specific culture, custom culture, or Windows-only culture. If the culture name is not in RFC 4646 format, your application should specify the entire culture name instead of just the country/region. </param><exception cref="T:System.ArgumentNullException"><paramref name="name" /> is null.</exception><exception cref="T:System.ArgumentException"><paramref name="name" /> is not a valid country/region name or specific culture name.</exception>
        [SecuritySafeCriticalAttribute()]
        public RegionInfo(string name)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Globalization.RegionInfo" /> class based on the country/region associated with the specified culture identifier.</summary><param name="culture">A culture identifier. </param><exception cref="T:System.ArgumentException"><paramref name="culture" /> specifies either an invariant, custom, or neutral culture.</exception>
        [SecuritySafeCriticalAttribute()]
        public RegionInfo(int culture)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether the specified object is the same instance as the current <see cref="T:System.Globalization.RegionInfo" />.</summary><returns>true if the <paramref name="value" /> parameter is a <see cref="T:System.Globalization.RegionInfo" /> object and its <see cref="P:System.Globalization.RegionInfo.Name" /> property is the same as the <see cref="P:System.Globalization.RegionInfo.Name" /> property of the current <see cref="T:System.Globalization.RegionInfo" /> object; otherwise, false.</returns><param name="value">The object to compare with the current <see cref="T:System.Globalization.RegionInfo" />. </param>
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
        
        
    }
}
