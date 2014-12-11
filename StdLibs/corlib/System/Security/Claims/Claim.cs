using System.Collections.Generic;

namespace System.Security.Claims
{
    /// <summary>Represents a claim.</summary>
    [Serializable]
    public class Claim
    {
    
        /// <summary>Gets the issuer of the claim.</summary><returns>A name that refers to the issuer of the claim.</returns>
        public string Issuer
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the original issuer of the claim. </summary><returns>A name that refers to the original issuer of the claim.</returns>
        public string OriginalIssuer
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a dictionary that contains additional properties associated with this claim.</summary><returns>A dictionary that contains additional properties associated with the claim. The properties are represented as name-value pairs.</returns>
        public IDictionary<string, string> Properties
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the subject of the claim.</summary><returns>The subject of the claim.</returns>
        public ClaimsIdentity Subject
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the claim type of the claim.</summary><returns>The claim type.</returns>
        public string Type
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the value of the claim.</summary><returns>The claim value.</returns>
        public string Value
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the value type of the claim.</summary><returns>The claim value type.</returns>
        public string ValueType
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Claims.Claim" /> class with the specified claim type, and value.</summary><param name="type">The claim type.</param><param name="value">The claim value.</param><exception cref="T:System.ArgumentNullException"><paramref name="type" /> or <paramref name="value" /> is null.</exception>
        public Claim(string type, string value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Claims.Claim" /> class with the specified claim type, value, and value type.</summary><param name="type">The claim type.</param><param name="value">The claim value.</param><param name="valueType">The claim value type. If this parameter is null, then <see cref="F:System.Security.Claims.ClaimValueTypes.String" /> is used.</param><exception cref="T:System.ArgumentNullException"><paramref name="type" /> or <paramref name="value" /> is null.</exception>
        public Claim(string type, string value, string valueType)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Claims.Claim" /> class with the specified claim type, value, value type, and issuer.</summary><param name="type">The claim type.</param><param name="value">The claim value.</param><param name="valueType">The claim value type. If this parameter is null, then <see cref="F:System.Security.Claims.ClaimValueTypes.String" /> is used.</param><param name="issuer">The claim issuer. If this parameter is empty or null, then <see cref="F:System.Security.Claims.ClaimsIdentity.DefaultIssuer" /> is used.</param><exception cref="T:System.ArgumentNullException"><paramref name="type" /> or <paramref name="value" /> is null.</exception>
        public Claim(string type, string value, string valueType, string issuer)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Claims.Claim" /> class with the specified claim type, value, value type, issuer,  and original issuer.</summary><param name="type">The claim type.</param><param name="value">The claim value.</param><param name="valueType">The claim value type. If this parameter is null, then <see cref="F:System.Security.Claims.ClaimValueTypes.String" /> is used.</param><param name="issuer">The claim issuer. If this parameter is empty or null, then <see cref="F:System.Security.Claims.ClaimsIdentity.DefaultIssuer" /> is used.</param><param name="originalIssuer">The original issuer of the claim. If this parameter is empty or null, then the <see cref="P:System.Security.Claims.Claim.OriginalIssuer" /> property is set to the value of the <see cref="P:System.Security.Claims.Claim.Issuer" /> property.</param><exception cref="T:System.ArgumentNullException"><paramref name="type" /> or <paramref name="value" /> is null.</exception>
        public Claim(string type, string value, string valueType, string issuer, string originalIssuer)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Claims.Claim" /> class with the specified claim type, value, value type, issuer, original issuer and subject.</summary><param name="type">The claim type.</param><param name="value">The claim value.</param><param name="valueType">The claim value type. If this parameter is null, then <see cref="F:System.Security.Claims.ClaimValueTypes.String" /> is used.</param><param name="issuer">The claim issuer. If this parameter is empty or null, then <see cref="F:System.Security.Claims.ClaimsIdentity.DefaultIssuer" /> is used.</param><param name="originalIssuer">The original issuer of the claim. If this parameter is empty or null, then the <see cref="P:System.Security.Claims.Claim.OriginalIssuer" /> property is set to the value of the <see cref="P:System.Security.Claims.Claim.Issuer" /> property.</param><param name="subject">The subject that this claim describes.</param><exception cref="T:System.ArgumentNullException"><paramref name="type" /> or <paramref name="value" /> is null.</exception>
        public Claim(string type, string value, string valueType, string issuer, string originalIssuer, ClaimsIdentity subject)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual Claim Clone()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a new <see cref="T:System.Security.Claims.Claim" /> object copied from this object. The subject of the new claim is set to the specified ClaimsIdentity.</summary><returns>The new claim object.</returns><param name="identity">The intended subject of the new claim.</param>
        public virtual Claim Clone(ClaimsIdentity identity)
        {
             throw new NotImplementedException();
        }
        
        
        public override string ToString()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
