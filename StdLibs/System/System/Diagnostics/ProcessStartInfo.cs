using System.ComponentModel;
using System.Collections.Specialized;
using System.Text;
using System.Security;
using System;

namespace System.Diagnostics
{
    [TypeConverterAttribute(typeof(ExpandableObjectConverter))]
    public sealed class ProcessStartInfo
    {
    
        [NotifyParentPropertyAttribute(true)]
        [DefaultValueAttribute("")]
        [TypeConverterAttribute("System.Diagnostics.Design.VerbConverter, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
        [MonitoringDescriptionAttribute("ProcessVerb")]
        public string Verb
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        [SettingsBindableAttribute(true)]
        [DefaultValueAttribute("")]
        [MonitoringDescriptionAttribute("ProcessArguments")]
        [TypeConverterAttribute("System.Diagnostics.Design.StringValueConverter, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
        [NotifyParentPropertyAttribute(true)]
        public string Arguments
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        [DefaultValueAttribute(false)]
        [MonitoringDescriptionAttribute("ProcessCreateNoWindow")]
        [NotifyParentPropertyAttribute(true)]
        public bool CreateNoWindow
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        [EditorAttribute("System.Diagnostics.Design.StringDictionaryEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [DefaultValueAttribute(null)]
        [MonitoringDescriptionAttribute("ProcessEnvironmentVariables")]
        [NotifyParentPropertyAttribute(true)]
        public StringDictionary EnvironmentVariables
        {
            get { throw new NotImplementedException(); }
        }
    
        [DefaultValueAttribute(false)]
        [MonitoringDescriptionAttribute("ProcessRedirectStandardInput")]
        [NotifyParentPropertyAttribute(true)]
        public bool RedirectStandardInput
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        [MonitoringDescriptionAttribute("ProcessRedirectStandardOutput")]
        [DefaultValueAttribute(false)]
        [NotifyParentPropertyAttribute(true)]
        public bool RedirectStandardOutput
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        [MonitoringDescriptionAttribute("ProcessRedirectStandardError")]
        [DefaultValueAttribute(false)]
        [NotifyParentPropertyAttribute(true)]
        public bool RedirectStandardError
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public Encoding StandardErrorEncoding
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public Encoding StandardOutputEncoding
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        [DefaultValueAttribute(true)]
        [MonitoringDescriptionAttribute("ProcessUseShellExecute")]
        [NotifyParentPropertyAttribute(true)]
        public bool UseShellExecute
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        [BrowsableAttribute(false)]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        public string[] Verbs
        {
            get { throw new NotImplementedException(); }
        }
    
        [NotifyParentPropertyAttribute(true)]
        public string UserName
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public SecureString Password
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        [NotifyParentPropertyAttribute(true)]
        public string Domain
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        [NotifyParentPropertyAttribute(true)]
        public bool LoadUserProfile
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        [NotifyParentPropertyAttribute(true)]
        [DefaultValueAttribute("")]
        [EditorAttribute("System.Diagnostics.Design.StartFileNameEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
        [MonitoringDescriptionAttribute("ProcessFileName")]
        [SettingsBindableAttribute(true)]
        [TypeConverterAttribute("System.Diagnostics.Design.StringValueConverter, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
        public string FileName
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        [TypeConverterAttribute("System.Diagnostics.Design.StringValueConverter, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
        [NotifyParentPropertyAttribute(true)]
        [DefaultValueAttribute("")]
        [MonitoringDescriptionAttribute("ProcessWorkingDirectory")]
        [EditorAttribute("System.Diagnostics.Design.WorkingDirectoryEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
        [SettingsBindableAttribute(true)]
        public string WorkingDirectory
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        [DefaultValueAttribute(false)]
        [NotifyParentPropertyAttribute(true)]
        [MonitoringDescriptionAttribute("ProcessErrorDialog")]
        public bool ErrorDialog
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        [BrowsableAttribute(false)]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        public IntPtr ErrorDialogParentHandle
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        //[DefaultValueAttribute(Mono.Cecil.CustomAttributeArgument)]
        [MonitoringDescriptionAttribute("ProcessWindowStyle")]
        [NotifyParentPropertyAttribute(true)]
        public ProcessWindowStyle WindowStyle
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public ProcessStartInfo()
        {
             throw new NotImplementedException();
        }
        
        
        public ProcessStartInfo(string fileName)
        {
             throw new NotImplementedException();
        }
        
        
        public ProcessStartInfo(string fileName, string arguments)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
