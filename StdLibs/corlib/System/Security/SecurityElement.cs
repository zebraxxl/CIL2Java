using System.Runtime.InteropServices;
using System.Collections;

namespace System.Security
{
    /// <summary>Represents the XML object model for encoding security objects. This class cannot be inherited.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    public sealed class SecurityElement
    {
    
        /// <summary>Gets or sets the tag name of an XML element.</summary><returns>The tag name of an XML element.</returns><exception cref="T:System.ArgumentNullException">The tag is null. </exception><exception cref="T:System.ArgumentException">The tag is not valid in XML. </exception>
        public string Tag
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the attributes of an XML element as name/value pairs.</summary><returns>The <see cref="T:System.Collections.Hashtable" /> object for the attribute values of the XML element.</returns><exception cref="T:System.InvalidCastException">The name or value of the <see cref="T:System.Collections.Hashtable" /> object is invalid. </exception><exception cref="T:System.ArgumentException">The name is not a valid XML attribute name.</exception>
        public Hashtable Attributes
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the text within an XML element.</summary><returns>The value of the text within an XML element.</returns><exception cref="T:System.ArgumentException">The text is not valid in XML. </exception>
        public string Text
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the array of child elements of the XML element.</summary><returns>The ordered child elements of the XML element as security elements.</returns><exception cref="T:System.ArgumentException">A child of the XML parent node is null. </exception>
        public ArrayList Children
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Creates a security element from an XML-encoded string.</summary><returns>A <see cref="T:System.Security.SecurityElement" /> created from the XML.</returns><param name="xml">The XML-encoded string from which to create the security element.</param><exception cref="T:System.Security.XmlSyntaxException"><paramref name="xml" /> contains one or more single quotation mark characters.</exception><exception cref="T:System.ArgumentNullException"><paramref name="xml" /> is null.</exception>
        public static SecurityElement FromString(string xml)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.SecurityElement" /> class with the specified tag.</summary><param name="tag">The tag name of an XML element. </param><exception cref="T:System.ArgumentNullException">The <paramref name="tag" /> parameter is null. </exception><exception cref="T:System.ArgumentException">The <paramref name="tag" /> parameter is invalid in XML. </exception>
        public SecurityElement(string tag)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.SecurityElement" /> class with the specified tag and text.</summary><param name="tag">The tag name of the XML element. </param><param name="text">The text content within the element. </param><exception cref="T:System.ArgumentNullException">The <paramref name="tag" /> parameter is null. </exception><exception cref="T:System.ArgumentException">The <paramref name="tag" /> parameter or <paramref name="text" /> parameter is invalid in XML. </exception>
        public SecurityElement(string tag, string text)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Adds a name/value attribute to an XML element.</summary><param name="name">The name of the attribute. </param><param name="value">The value of the attribute. </param><exception cref="T:System.ArgumentNullException">The <paramref name="name" /> parameter or <paramref name="value" /> parameter is null. </exception><exception cref="T:System.ArgumentException">The <paramref name="name" /> parameter or <paramref name="value" /> parameter is invalid in XML.-or- An attribute with the name specified by the <paramref name="name" /> parameter already exists. </exception>
        public void AddAttribute(string name, string value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Adds a child element to the XML element.</summary><param name="child">The child element to add. </param><exception cref="T:System.ArgumentNullException">The <paramref name="child" /> parameter is null. </exception>
        public void AddChild(SecurityElement child)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Compares two XML element objects for equality.</summary><returns>true if the tag, attribute names and values, child elements, and text fields in the current XML element are identical to their counterparts in the <paramref name="other" /> parameter; otherwise, false.</returns><param name="other">An XML element object to which to compare the current XML element object. </param>
        public bool Equal(SecurityElement other)
        {
             throw new NotImplementedException();
        }
        
        
        [ComVisibleAttribute(false)]
        public SecurityElement Copy()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether a string is a valid tag.</summary><returns>true if the <paramref name="tag" /> parameter is a valid XML tag; otherwise, false.</returns><param name="tag">The tag to test for validity. </param>
        public static bool IsValidTag(string tag)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether a string is valid as text within an XML element.</summary><returns>true if the <paramref name="text" /> parameter is a valid XML text element; otherwise, false.</returns><param name="text">The text to test for validity. </param>
        public static bool IsValidText(string text)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether a string is a valid attribute name.</summary><returns>true if the <paramref name="name" /> parameter is a valid XML attribute name; otherwise, false.</returns><param name="name">The attribute name to test for validity. </param>
        public static bool IsValidAttributeName(string name)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether a string is a valid attribute value.</summary><returns>true if the <paramref name="value" /> parameter is a valid XML attribute value; otherwise, false.</returns><param name="value">The attribute value to test for validity. </param>
        public static bool IsValidAttributeValue(string value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Replaces invalid XML characters in a string with their valid XML equivalent.</summary><returns>The input string with invalid characters replaced.</returns><param name="str">The string within which to escape invalid characters. </param>
        public static string Escape(string str)
        {
             throw new NotImplementedException();
        }
        
        
        public override string ToString()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Finds an attribute by name in an XML element.</summary><returns>The value associated with the named attribute, or null if no attribute with <paramref name="name" /> exists.</returns><param name="name">The name of the attribute for which to search. </param><exception cref="T:System.ArgumentNullException">The <paramref name="name" /> parameter is null. </exception>
        public string Attribute(string name)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Finds a child by its tag name.</summary><returns>The first child XML element with the specified tag value, or null if no child element with <paramref name="tag" /> exists.</returns><param name="tag">The tag for which to search in child elements. </param><exception cref="T:System.ArgumentNullException">The <paramref name="tag" /> parameter is null. </exception>
        public SecurityElement SearchForChildByTag(string tag)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Finds a child by its tag name and returns the contained text.</summary><returns>The text contents of the first child element with the specified tag value.</returns><param name="tag">The tag for which to search in child elements. </param><exception cref="T:System.ArgumentNullException"><paramref name="tag" /> is null. </exception>
        public string SearchForTextOfTag(string tag)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
