﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MongoDb.Data {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")]
    internal sealed partial class dbSetting : global::System.Configuration.ApplicationSettingsBase {
        
        private static dbSetting defaultInstance = ((dbSetting)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new dbSetting())));
        
        public static dbSetting Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("mongodb://127.0.0.1/ElectronicStoreSystemData")]
        public string MONGOLAB_URI {
            get {
                return ((string)(this["MONGOLAB_URI"]));
            }
        }
    }
}
