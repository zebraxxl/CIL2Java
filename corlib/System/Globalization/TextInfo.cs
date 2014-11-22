using System.Runtime.InteropServices;
using System;
using System.Runtime.Serialization;
using System.Security;

namespace System.Globalization
{
    /// <summary>Defines text properties and behaviors, such as casing, that are specific to a writing system. </summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    public class TextInfo : ICloneable, IDeserializationCallback
    {
    
        /// <summary>Gets the American National Standards Institute (ANSI) code page used by the writing system represented by the current <see cref="T:System.Globalization.TextInfo" />.</summary><returns>The ANSI code page used by the writing system represented by the current <see cref="T:System.Globalization.TextInfo" />.</returns>
        public virtual int ANSICodePage
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the original equipment manufacturer (OEM) code page used by the writing system represented by the current <see cref="T:System.Globalization.TextInfo" />.</summary><returns>The OEM code page used by the writing system represented by the current <see cref="T:System.Globalization.TextInfo" />.</returns>
        public virtual int OEMCodePage
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the Macintosh code page used by the writing system represented by the current <see cref="T:System.Globalization.TextInfo" />.</summary><returns>The Macintosh code page used by the writing system represented by the current <see cref="T:System.Globalization.TextInfo" />.</returns>
        public virtual int MacCodePage
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the Extended Binary Coded Decimal Interchange Code (EBCDIC) code page used by the writing system represented by the current <see cref="T:System.Globalization.TextInfo" />.</summary><returns>The EBCDIC code page used by the writing system represented by the current <see cref="T:System.Globalization.TextInfo" />.</returns>
        public virtual int EBCDICCodePage
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the culture identifier for the culture associated with the current <see cref="T:System.Globalization.TextInfo" /> object.</summary><returns>A number that identifies the culture from which the current <see cref="T:System.Globalization.TextInfo" /> object was created.</returns>
        [ComVisibleAttribute(false)]
        public int LCID
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the name of the culture associated with the current <see cref="T:System.Globalization.TextInfo" /> object.</summary><returns>The name of a culture. </returns>
        [ComVisibleAttribute(false)]
        public string CultureName
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value indicating whether the current <see cref="T:System.Globalization.TextInfo" /> object is read-only.</summary><returns>true if the current <see cref="T:System.Globalization.TextInfo" /> object is read-only; otherwise, false.</returns>
        [ComVisibleAttribute(false)]
        public bool IsReadOnly
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the string that separates items in a list.</summary><returns>The string that separates items in a list.</returns><exception cref="T:System.ArgumentNullException">The value in a set operation is null.</exception><exception cref="T:System.InvalidOperationException">In a set operation, the current <see cref="T:System.Globalization.TextInfo" /> object is read-only.</exception>
        public virtual string ListSeparator
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value indicating whether the current <see cref="T:System.Globalization.TextInfo" /> object represents a writing system where text flows from right to left.</summary><returns>true if text flows from right to left; otherwise, false.</returns>
        [ComVisibleAttribute(false)]
        public bool IsRightToLeft
        {
            get { throw new NotImplementedException(); }
        }
    
    
        [ComVisibleAttribute(false)]
        public virtual object Clone()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a read-only version of the specified <see cref="T:System.Globalization.TextInfo" /> object.</summary><returns>The <see cref="T:System.Globalization.TextInfo" /> object specified by the <paramref name="textInfo" /> parameter, if <paramref name="textInfo" /> is read-only.-or-A read-only memberwise clone of the <see cref="T:System.Globalization.TextInfo" /> object specified by <paramref name="textInfo" />, if <paramref name="textInfo" /> is not read-only.</returns><param name="textInfo">A <see cref="T:System.Globalization.TextInfo" /> object.</param><exception cref="T:System.ArgumentNullException"><paramref name="textInfo" /> is null.</exception>
        [ComVisibleAttribute(false)]
        public static TextInfo ReadOnly(TextInfo textInfo)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Converts the specified character to lowercase.</summary><returns>The specified character converted to lowercase.</returns><param name="c">The character to convert to lowercase. </param>
        [SecuritySafeCriticalAttribute()]
        public virtual char ToLower(char c)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Converts the specified string to lowercase.</summary><returns>The specified string converted to lowercase.</returns><param name="str">The string to convert to lowercase. </param><exception cref="T:System.ArgumentNullException"><paramref name="str" /> is null. </exception>
        [SecuritySafeCriticalAttribute()]
        public virtual string ToLower(string str)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Converts the specified character to uppercase.</summary><returns>The specified character converted to uppercase.</returns><param name="c">The character to convert to uppercase. </param>
        [SecuritySafeCriticalAttribute()]
        public virtual char ToUpper(char c)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Converts the specified string to uppercase.</summary><returns>The specified string converted to uppercase.</returns><param name="str">The string to convert to uppercase. </param><exception cref="T:System.ArgumentNullException"><paramref name="str" /> is null. </exception>
        [SecuritySafeCriticalAttribute()]
        public virtual string ToUpper(string str)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether the specified object represents the same writing system as the current <see cref="T:System.Globalization.TextInfo" /> object.</summary><returns>true if <paramref name="obj" /> represents the same writing system as the current <see cref="T:System.Globalization.TextInfo" />; otherwise, false.</returns><param name="obj">The object to compare with the current <see cref="T:System.Globalization.TextInfo" />. </param>
        public override bool Equals(object obj)
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
        
        
        /// <summary>Converts the specified string to titlecase.</summary><returns>The specified string converted to titlecase.</returns><param name="str">The string to convert to titlecase. </param><exception cref="T:System.ArgumentNullException"><paramref name="str" /> is null. </exception>
        public string ToTitleCase(string str)
        {
             throw new NotImplementedException();
        }



        void IDeserializationCallback.OnDeserialization(object sender)
        {
            throw new NotImplementedException();
        }
    }
}
