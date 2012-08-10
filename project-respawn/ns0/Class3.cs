using Launcher.Properties;
using Microsoft.Win32;
using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
namespace ns0
{
	internal static class Class3
	{
		[CompilerGenerated]
		private static bool bool_0;
		public static bool ForcePoll
		{
			get;
			set;
		}
		public static string smethod_0()
		{
			string text;
			if (!Class3.ForcePoll)
			{
				text = Class3.smethod_1();
				if (!string.IsNullOrWhiteSpace(text))
				{
					return text;
				}
				text = Class3.smethod_2();
				if (!string.IsNullOrWhiteSpace(text))
				{
					return text;
				}
			}
			Settings.Default.Upgrade();
			text = Settings.Default.D3Path;
			if (!File.Exists(Path.Combine(text, "Diablo III.exe")))
			{
				text = null;
			}
			if (!string.IsNullOrWhiteSpace(text))
			{
				return text;
			}
			MessageBox.Show("The installation path of game could not be found.\r\nPlease select the games executable in the following dialog!", "Installation path", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			OpenFileDialog openFileDialog;
			do
			{
				openFileDialog = new OpenFileDialog();
				openFileDialog.Filter = "Diablo III Main Executable|Diablo III.exe";
				DialogResult dialogResult = openFileDialog.ShowDialog();
				if (dialogResult == DialogResult.OK)
				{
					goto IL_B6;
				}
        goto IL_B6;
			}
			while (MessageBox.Show("The path could not be located. Do you want to try again?", "Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes);
			Environment.Exit(0);
			Thread.CurrentThread.Abort();
			IL_B6:
			text = Path.GetDirectoryName(openFileDialog.FileName);
			Settings.Default.D3Path = text;
			Settings.Default.Save();
			return text;
		}
		private static string smethod_1()
		{
			try
			{
				string name = "SOFTWARE\\Wow6432Node\\Microsoft\\Windows\\CurrentVersion\\Uninstall\\Diablo III";
				string name2 = "InstallLocation";
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(name);
				if (registryKey != null)
				{
					string text = (string)registryKey.GetValue(name2);
					if (!string.IsNullOrEmpty(text))
					{
						return text;
					}
				}
			}
			catch
			{
			}
			return null;
		}
		private static string smethod_2()
		{
			try
			{
				string name = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Uninstall\\Diablo III";
				string name2 = "InstallLocation";
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(name);
				if (registryKey != null)
				{
					string text = (string)registryKey.GetValue(name2);
					if (!string.IsNullOrEmpty(text))
					{
						return text;
					}
				}
			}
			catch
			{
			}
			return null;
		}
	}
}
