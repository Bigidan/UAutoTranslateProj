﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UAutoTranslate.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.8.1.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfString xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <string>Ubisoft Connect</string>
  <string>NVIDIA GeForce Exirience</string>
  <string>ShadowPlay</string>
</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection AppList {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["AppList"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://raw.githubusercontent.com/Bigidan/LocalizationFileIntoUA/main/LocFiles/Ub" +
            "isoftConnect/uk-UA_loc.txt")]
        public string UbisoftConnectDL {
            get {
                return ((string)(this["UbisoftConnectDL"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://raw.githubusercontent.com/Bigidan/LocalizationFileIntoUA/main/LocFiles/Nv" +
            "idiaGeForceExp/NVIDIA%20GeForce%20Exirience.zip")]
        public string GeForceExperienceDL {
            get {
                return ((string)(this["GeForceExperienceDL"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://raw.githubusercontent.com/Bigidan/LocalizationFileIntoUA/main/LocFiles/Sh" +
            "adowPlay/ru-RU.json")]
        public string ShadowPlayDL {
            get {
                return ((string)(this["ShadowPlayDL"]));
            }
        }
    }
}
