using System;
using System.Diagnostics;

namespace System.Diagnostics.CodeAnalysis
{
    /// <summary>Suppresses reporting of a specific static analysis tool rule violation, allowing multiple suppressions on a single code artifact.</summary>
    [AttributeUsageAttribute(AttributeTargets.All, Inherited = false, AllowMultiple = true)]
    [ConditionalAttribute("CODE_ANALYSIS")]
    public sealed class SuppressMessageAttribute : Attribute
    {
    
        /// <summary>Gets the category identifying the classification of the attribute.</summary><returns>The category identifying the attribute.</returns>
        public string Category
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the identifier of the static analysis tool rule to be suppressed.</summary><returns>The identifier of the static analysis tool rule to be suppressed.</returns>
        public string CheckId
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the scope of the code that is relevant for the attribute.</summary><returns>The scope of the code that is relevant for the attribute.</returns>
        public string Scope
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets a fully qualified path that represents the target of the attribute.</summary><returns>A fully qualified path that represents the target of the attribute.</returns>
        public string Target
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets an optional argument expanding on exclusion criteria.</summary><returns>A string containing the expanded exclusion criteria.</returns>
        public string MessageId
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the justification for suppressing the code analysis message.</summary><returns>The justification for suppressing the message.</returns>
        public string Justification
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.CodeAnalysis.SuppressMessageAttribute" /> class, specifying the category of the static analysis tool and the identifier for an analysis rule. </summary><param name="category">The category for the attribute.</param><param name="checkId">The identifier of the analysis tool rule the attribute applies to.</param>
        public SuppressMessageAttribute(string category, string checkId)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
