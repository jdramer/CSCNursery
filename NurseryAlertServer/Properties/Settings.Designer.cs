﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.296
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NurseryAlertServer.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Black")]
        public global::System.Drawing.Color ProjectionBackColor {
            get {
                return ((global::System.Drawing.Color)(this["ProjectionBackColor"]));
            }
            set {
                this["ProjectionBackColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("White")]
        public global::System.Drawing.Color ProjectionMasterFontColor {
            get {
                return ((global::System.Drawing.Color)(this["ProjectionMasterFontColor"]));
            }
            set {
                this["ProjectionMasterFontColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("500")]
        public int ProjectionFadeTime {
            get {
                return ((int)(this["ProjectionFadeTime"]));
            }
            set {
                this["ProjectionFadeTime"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int ProjectionOutlineSize {
            get {
                return ((int)(this["ProjectionOutlineSize"]));
            }
            set {
                this["ProjectionOutlineSize"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Black")]
        public global::System.Drawing.Color ProjectionOutlineColor {
            get {
                return ((global::System.Drawing.Color)(this["ProjectionOutlineColor"]));
            }
            set {
                this["ProjectionOutlineColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Calibri, 50.25pt, style=Bold")]
        public global::System.Drawing.Font ProjectionMasterFont {
            get {
                return ((global::System.Drawing.Font)(this["ProjectionMasterFont"]));
            }
            set {
                this["ProjectionMasterFont"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int ProjectionMasterLineSpacing {
            get {
                return ((int)(this["ProjectionMasterLineSpacing"]));
            }
            set {
                this["ProjectionMasterLineSpacing"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("COM1")]
        public string TallyComPort {
            get {
                return ((string)(this["TallyComPort"]));
            }
            set {
                this["TallyComPort"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("8080")]
        public int WebPort {
            get {
                return ((int)(this["WebPort"]));
            }
            set {
                this["WebPort"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("C:\\Program Files (x86)\\CSCNursery\\baby_cry_short.wav")]
        public string NotificationSound {
            get {
                return ((string)(this["NotificationSound"]));
            }
            set {
                this["NotificationSound"] = value;
            }
        }
    }
}
