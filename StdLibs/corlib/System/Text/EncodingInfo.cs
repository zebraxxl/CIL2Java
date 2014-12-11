
namespace System.Text
{
    /// <summary>Provides basic information about an encoding.</summary><filterpriority>2</filterpriority>
    [Serializable]
    public sealed class EncodingInfo
    {
    
        /// <summary>Gets the code page identifier of the encoding.</summary><returns>The code page identifier of the encoding.</returns><filterpriority>2</filterpriority>
        public int CodePage
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the name registered with the Internet Assigned Numbers Authority (IANA) for the encoding.</summary><returns>The IANA name for the encoding. For more information about the IANA, see www.iana.org.</returns><filterpriority>2</filterpriority>
        public string Name
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the human-readable description of the encoding.</summary><returns>The human-readable description of the encoding.</returns><filterpriority>2</filterpriority>
        public string DisplayName
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public Encoding GetEncoding()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Gets a value indicating whether the specified object is equal to the current <see cref="T:System.Text.EncodingInfo" /> object.</summary><returns>true if <paramref name="value" /> is a <see cref="T:System.Text.EncodingInfo" /> object and is equal to the current <see cref="T:System.Text.EncodingInfo" /> object; otherwise, false.</returns><param name="value">An object to compare to the current <see cref="T:System.Text.EncodingInfo" /> object.</param><filterpriority>1</filterpriority>
        public override bool Equals(object value)
        {
             throw new NotImplementedException();
        }
        
        
        public override int GetHashCode()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
