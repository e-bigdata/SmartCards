﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SmartCardDesc.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("HP\\SQLEXPRESS")]
        public string DB_DataSource {
            get {
                return ((string)(this["DB_DataSource"]));
            }
            set {
                this["DB_DataSource"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("SmartCardDB")]
        public string DB_Database {
            get {
                return ((string)(this["DB_Database"]));
            }
            set {
                this["DB_Database"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public string DB_IntegratedSecurity {
            get {
                return ((string)(this["DB_IntegratedSecurity"]));
            }
            set {
                this["DB_IntegratedSecurity"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("sa")]
        public string DB_UserId {
            get {
                return ((string)(this["DB_UserId"]));
            }
            set {
                this["DB_UserId"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("123")]
        public string DB_Password {
            get {
                return ((string)(this["DB_Password"]));
            }
            set {
                this["DB_Password"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("asdqwe123")]
        public string KeyMD5 {
            get {
                return ((string)(this["KeyMD5"]));
            }
            set {
                this["KeyMD5"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=HP\\SQLEXPRESS;Initial Catalog=SmartCardDB;Integrated Security=True")]
        public string SmartCardDBConnectionString {
            get {
                return ((string)(this["SmartCardDBConnectionString"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("C:\\RADSOFT\\Projects\\SmartCardDesc\\PrinterFiles\\Photo")]
        public string CardPhotoPath {
            get {
                return ((string)(this["CardPhotoPath"]));
            }
            set {
                this["CardPhotoPath"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("SmartCardTemplate")]
        public string CA_TemplateName {
            get {
                return ((string)(this["CA_TemplateName"]));
            }
            set {
                this["CA_TemplateName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://ips.gov.uz:443")]
        public string ServiceUrl {
            get {
                return ((string)(this["ServiceUrl"]));
            }
            set {
                this["ServiceUrl"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("192.168.211.2")]
        public string CAServerIpAndName {
            get {
                return ((string)(this["CAServerIpAndName"]));
            }
            set {
                this["CAServerIpAndName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("12345678")]
        public string AdminPINLogin {
            get {
                return ((string)(this["AdminPINLogin"]));
            }
            set {
                this["AdminPINLogin"] = value;
            }
        }
    }
}
