using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
namespace Launcher.Properties
{
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0"), CompilerGenerated]
	internal sealed class Settings : ApplicationSettingsBase
	{
		private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
		public static Settings Default
		{
			get
			{
				return Settings.defaultInstance;
			}
		}
		[DefaultSettingValue(""), UserScopedSetting, DebuggerNonUserCode]
		public string D3Path
		{
			get
			{
				return (string)this["D3Path"];
			}
			set
			{
				this["D3Path"] = value;
			}
		}
		[DefaultSettingValue(""), UserScopedSetting, DebuggerNonUserCode]
		public string LastUserName
		{
			get
			{
				return (string)this["LastUserName"];
			}
			set
			{
				this["LastUserName"] = value;
			}
		}
		[DefaultSettingValue(""), UserScopedSetting, DebuggerNonUserCode]
		public string LastPassword
		{
			get
			{
				return (string)this["LastPassword"];
			}
			set
			{
				this["LastPassword"] = value;
			}
		}
		[DefaultSettingValue(""), UserScopedSetting, DebuggerNonUserCode]
		public string ProfileFolder
		{
			get
			{
				return (string)this["ProfileFolder"];
			}
			set
			{
				this["ProfileFolder"] = value;
			}
		}
		[DefaultSettingValue(""), UserScopedSetting, DebuggerNonUserCode]
		public string LastUsedKeys
		{
			get
			{
				return (string)this["LastUsedKeys"];
			}
			set
			{
				this["LastUsedKeys"] = value;
			}
		}
		[DefaultSettingValue("False"), UserScopedSetting, DebuggerNonUserCode]
		public bool TryAutoLogin
		{
			get
			{
				return (bool)this["TryAutoLogin"];
			}
			set
			{
				this["TryAutoLogin"] = value;
			}
		}
	}
}
