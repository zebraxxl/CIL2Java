using System;
using System.Configuration;
using System.Xml;

namespace System.Diagnostics
{
    [ObsoleteAttribute("This class has been deprecated.  http://go.microsoft.com/fwlink/?linkid=14202")]
    public class DiagnosticsConfigurationHandler : IConfigurationSectionHandler
    {
        public virtual object Create(object parent, object configContext, XmlNode section)
        {
             throw new NotImplementedException();
        }
        
        
        public DiagnosticsConfigurationHandler()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
