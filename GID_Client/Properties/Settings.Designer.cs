﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GID_Client.Properties {
    
    
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
        [global::System.Configuration.DefaultSettingValueAttribute("https://dluzbackend.avtotest.uz:28443/api/v1/cards")]
        public string RegisterCardAPI {
            get {
                return ((string)(this["RegisterCardAPI"]));
            }
            set {
                this["RegisterCardAPI"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://dluzbackend.avtotest.uz:28443/api/v1/cards/{0}/certificate ")]
        public string GetCertificate {
            get {
                return ((string)(this["GetCertificate"]));
            }
            set {
                this["GetCertificate"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("activator")]
        public string LoginActivation {
            get {
                return ((string)(this["LoginActivation"]));
            }
            set {
                this["LoginActivation"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("activator")]
        public string PasswordActivation {
            get {
                return ((string)(this["PasswordActivation"]));
            }
            set {
                this["PasswordActivation"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://dluzbackend.avtotest.uz:28443/api/v1/activate/dl")]
        public string ActivationDLApi {
            get {
                return ((string)(this["ActivationDLApi"]));
            }
            set {
                this["ActivationDLApi"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://dluzbackend.avtotest.uz:28443/api/v1/activate/vl")]
        public string ActivationVRApi {
            get {
                return ((string)(this["ActivationVRApi"]));
            }
            set {
                this["ActivationVRApi"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://dluzbackend.avtotest.uz:28443/api/v1/login")]
        public string LoginApi {
            get {
                return ((string)(this["LoginApi"]));
            }
            set {
                this["LoginApi"] = value;
            }
        }
    }
}
