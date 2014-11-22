using System;
using System.Diagnostics;

namespace System.Diagnostics.Contracts
{
    /// <summary>Enables you to set contract and tool options at assembly, type, or method granularity.</summary>
    [AttributeUsageAttribute(AttributeTargets.All, AllowMultiple = true, Inherited = false)]
    [ConditionalAttribute("CONTRACTS_FULL")]
    public sealed class ContractOptionAttribute : Attribute
    {
    
        /// <summary>Gets the category of the option.</summary><returns>The category of the option.</returns>
        public string Category
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the setting for the option.</summary><returns>The setting for the option.</returns>
        public string Setting
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Determines if an option is enabled.</summary><returns>true if the option is enabled; otherwise, false.</returns>
        public bool Enabled
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the value for the option.</summary><returns>The value for the option.</returns>
        public string Value
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.Contracts.ContractOptionAttribute" /> class by using the provided category, setting, and enable/disable value.</summary><param name="category">The category for the option to be set.</param><param name="setting">The option setting.</param><param name="enabled">true to enable the option; false to disable the option.</param>
        public ContractOptionAttribute(string category, string setting, bool enabled)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.Contracts.ContractOptionAttribute" /> class by using the provided category, setting, and value.</summary><param name="category">The category of the option to be set.</param><param name="setting">The option setting.</param><param name="value">The value for the setting.</param>
        public ContractOptionAttribute(string category, string setting, string value)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
