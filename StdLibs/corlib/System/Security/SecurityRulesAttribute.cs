using System;

namespace System.Security
{
    /// <summary>Indicates the set of security rules the common language runtime should enforce for an assembly.  </summary>
    [AttributeUsageAttribute(AttributeTargets.Assembly, AllowMultiple = false)]
    public sealed class SecurityRulesAttribute : Attribute
    {
    
        /// <summary>Determines whether fully trusted transparent code should skip Microsoft intermediate language (MSIL) verification.</summary><returns>true if MSIL verification should be skipped; otherwise, false. The default is false.</returns>
        public bool SkipVerificationInFullTrust
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the rule set to be applied.</summary><returns>One of the enumeration values that specifies the transparency rules to be applied.</returns>
        public SecurityRuleSet RuleSet
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.SecurityRulesAttribute" /> class using the specified rule set value. </summary><param name="ruleSet">One of the enumeration values that specifies the transparency rules set. </param>
        public SecurityRulesAttribute(SecurityRuleSet ruleSet)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
