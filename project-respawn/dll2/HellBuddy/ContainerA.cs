using ns1;
using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace HellBuddy
{
	internal static class ContainerA
	{
		private static FileStream debugLog;
		private static StreamWriter debugLogWriter;
		private static Class90 _Bot;
		private static bool AlreadyInDump = false;
		private static string profilePath = "";
		internal static void AddToFileLog(string text)
		{
			if (ContainerA.debugLogWriter != null)
			{
				lock (ContainerA.debugLogWriter)
				{
					ContainerA.debugLogWriter.WriteLine(text);
				}
			}
		}
		public static int EntryPoint(string args)
		{
			try
			{
				ContainerA.debugLog = new FileStream("core_log.txt", FileMode.Create, FileAccess.Write, FileShare.None);
				ContainerA.debugLogWriter = new StreamWriter(ContainerA.debugLog);
				ContainerA.debugLogWriter.AutoFlush = true;
				ContainerA.debugLogWriter.WriteLine("EntryPoint");
				ContainerA.debugLogWriter.WriteLine("Setting up crashlogger");
			}
			catch
			{
			}
			ContainerA.smethod_0();
			ContainerA.AddToFileLog("Registering Exception handler");
			TaskScheduler.UnobservedTaskException += delegate(object sender, UnobservedTaskExceptionEventArgs e)
			{
				if (GClass0.smethod_0() != null)
				{
					GClass0.smethod_0().method_4("UnobservedTaskException: " + e.Exception.Message);
				}
				ContainerA.WriteCrashDump(e.Exception, false, true);
				e.SetObserved();
			};
			ContainerA._Bot = new Class90();
			GClass0.smethod_0().method_14();
			ContainerA.AddToFileLog("End of entrypoint");
			return 0;
		}
		[HandleProcessCorruptedStateExceptions]
		private static void smethod_0()
		{
			try
			{
				Class91.smethod_0();
				string text = null;
				int num = 0;
				while (text == null && num <= 20)
				{
					num++;
					text = Class91.smethod_4(Process.GetCurrentProcess().Id, "ProfileFile");
					if (text == null)
					{
						Thread.Sleep(200);
					}
				}
				if (text == null)
				{
					MessageBox.Show("Cannot open profile file!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
				else
				{
					ContainerA.profilePath = Path.GetFullPath(text);
					AppDomain.CurrentDomain.UnhandledException += delegate(object sender, UnhandledExceptionEventArgs e)
					{
						ContainerA.WriteCrashDump(e.ExceptionObject as Exception, e.IsTerminating, false);
					};
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error setting up the crashlogger: " + ex.Message);
			}
		}
		private static void WriteCrashDump(Exception exception, bool critical, bool Silent = false)
		{
			if (!ContainerA.AlreadyInDump)
			{
				ContainerA.AlreadyInDump = true;
				StringBuilder stringBuilder = new StringBuilder(10000);
				try
				{
					stringBuilder.AppendFormat("DatetimeUTC: " + DateTime.UtcNow.ToLongDateString() + ", TimeUTC: " + DateTime.UtcNow.ToLongTimeString(), new object[0]);
					stringBuilder.AppendFormat("DatetimeUTC: " + DateTime.Now.ToLongDateString() + ", TimeUTC: " + DateTime.Now.ToLongTimeString(), new object[0]);
				}
				catch (Exception ex)
				{
					stringBuilder.AppendLine("Cannot get time: " + ex.Message);
				}
				try
				{
					stringBuilder.AppendFormat("D3 MD5: " + Class102.smethod_0(Process.GetCurrentProcess().MainModule.FileName), new object[0]);
				}
				catch (Exception ex)
				{
					stringBuilder.AppendLine("Cannot get d3md5: " + ex.Message);
				}
				try
				{
					if (exception != null && exception.Message != null)
					{
						stringBuilder.AppendLine("Triggering Exception: " + exception.Message);
						stringBuilder.AppendLine("Exception is: " + (critical ? "critical" : "non-critical"));
					}
				}
				catch (Exception ex)
				{
					stringBuilder.AppendLine("Cannot get the exception, nested exception: " + ex.Message);
				}
				try
				{
					stringBuilder.AppendLine("Stacktrace: " + new StackTrace().ToString());
				}
				catch (Exception ex)
				{
					stringBuilder.AppendLine("Cannot get stacktrace: " + ex.Message);
				}
				try
				{
					stringBuilder.AppendLine("Modules: ");
					foreach (ProcessModule processModule in Process.GetCurrentProcess().Modules)
					{
						if (processModule != null)
						{
							string str = "";
							try
							{
								str = Class102.smethod_0(processModule.FileName);
							}
							catch (Exception)
							{
								str = "Unable to get md5";
							}
							stringBuilder.AppendLine(processModule.FileName + ", MD5: " + str);
						}
					}
				}
				catch (Exception ex)
				{
					stringBuilder.AppendLine("Cannot get modules: " + ex.Message);
				}
				try
				{
					if (GClass0.smethod_0() == null)
					{
						stringBuilder.AppendLine("Engine == null");
					}
					else
					{
						if (GClass0.smethod_0().method_10() == null)
						{
							stringBuilder.AppendLine("Script == null");
						}
						else
						{
							if (GClass0.smethod_0().method_10().LoadedFromFileName == null)
							{
								stringBuilder.AppendLine("ScriptName == null");
							}
							else
							{
								stringBuilder.AppendLine("Used script name: " + GClass0.smethod_0().method_10().LoadedFromFileName);
							}
						}
					}
				}
				catch (Exception ex)
				{
					stringBuilder.AppendLine("Cannot get script: " + ex.Message);
				}
				string str2 = "CrashLog - ";
				int num = 1;
				string text;
				do
				{
					text = str2 + num.ToString() + ".txt";
					num++;
				}
				while (File.Exists(text));
				File.WriteAllText(text, stringBuilder.ToString());
				DialogResult dialogResult = DialogResult.Yes;
				if (!Silent)
				{
					dialogResult = MessageBox.Show("A unhandled exception occured.\r\nA crashlog has been saved in your profiles folder.\r\nIts name is: " + text + "\r\n\r\nPlease report this crash in the forums at forum.hellbuddy.com, and upload the crashlog file.\r\nIt will help us to fix this problem.\r\n\r\nDo you want to try to continue? (Not adviced)", "Unhandled Exception", MessageBoxButtons.YesNo, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button2);
				}
				ContainerA.AlreadyInDump = false;
				if (dialogResult != DialogResult.Yes)
				{
					Process.GetCurrentProcess().Kill();
				}
			}
		}
	}
}
