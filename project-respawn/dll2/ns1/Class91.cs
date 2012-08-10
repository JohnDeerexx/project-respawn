using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
namespace ns1
{
	internal static class Class91
	{
		private const int int_0 = 0;
		private const int int_1 = 10;
		private static string string_0;
		private static Random random_0 = new Random(Environment.TickCount);
		private static bool bool_0 = false;
		public static void smethod_0()
		{
			if (!Class91.bool_0)
			{
				try
				{
					string text = Path.Combine(Path.GetTempPath(), "HellBuddy");
					if (!Directory.Exists(text))
					{
						Directory.CreateDirectory(text);
					}
					Class91.string_0 = Path.Combine(text, "SharedSettings.txt");
					if (!File.Exists(Class91.string_0))
					{
						FileStream fileStream = File.Create(Class91.string_0);
						fileStream.Close();
					}
					File.SetAttributes(Class91.string_0, FileAttributes.Hidden);
					Class91.bool_0 = true;
				}
				catch
				{
					MessageBox.Show("Cannot open or create settings file!!");
				}
			}
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal static void smethod_1(string string_1, string string_2)
		{
			if (!Class91.bool_0)
			{
				throw new Exception("Settings must be initialized before usage!");
			}
			if (!File.Exists(Class91.string_0))
			{
				MessageBox.Show("Error: Settings file has been deleted!", "HellBuddy Bot", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				Process.GetCurrentProcess().Kill();
			}
			FileStream fileStream;
			while (true)
			{
				fileStream = null;
				try
				{
					fileStream = File.Open(Class91.string_0, FileMode.Open, FileAccess.ReadWrite, FileShare.None);
					break;
				}
				catch
				{
					Thread.Sleep(Class91.random_0.Next(10));
				}
			}
			try
			{
				StreamReader streamReader = new StreamReader(fileStream, new UTF8Encoding());
				string text = streamReader.ReadToEnd();
				text = Class91.smethod_7(text);
				List<string> list = text.Split(new char[]
				{
					'\n'
				}, StringSplitOptions.RemoveEmptyEntries).ToList<string>();
				string text2 = "Global-" + string_1 + ": ";
				int num = -1;
				for (int i = 0; i < list.Count; i++)
				{
					if (list[i].StartsWith(text2))
					{
						num = i;
						IL_E3:
						string text3 = text2 + string_2;
						if (num > -1)
						{
							list[num] = text3;
						}
						else
						{
							list.Add(text3);
						}
						fileStream.Seek(0L, SeekOrigin.Begin);
						StreamWriter streamWriter = new StreamWriter(fileStream, new UTF8Encoding());
						StringBuilder stringBuilder = new StringBuilder(3000);
						for (i = 0; i < list.Count; i++)
						{
							list[i] = list[i].Replace("\r", "");
							stringBuilder.AppendLine(list[i]);
						}
						string value = Class91.smethod_6(stringBuilder.ToString());
						streamWriter.Write(value);
						fileStream.SetLength(fileStream.Position);
						streamWriter.Flush();
						fileStream.Flush();
						fileStream.Close();
						return;
					}
				}
				
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error saving to setting file: " + ex.Message);
				Process.GetCurrentProcess().Kill();
			}
			finally
			{
				if (fileStream != null)
				{
					fileStream.Close();
				}
			}
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal static string smethod_2(string string_1)
		{
			if (!Class91.bool_0)
			{
				throw new Exception("Settings must be initialized before usage!");
			}
			if (!File.Exists(Class91.string_0))
			{
				MessageBox.Show("Error: Settings file has been deleted!", "HellBuddy Bot", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				Process.GetCurrentProcess().Kill();
			}
			FileStream fileStream;
			while (true)
			{
				fileStream = null;
				try
				{
					fileStream = File.Open(Class91.string_0, FileMode.Open, FileAccess.ReadWrite, FileShare.None);
					break;
				}
				catch
				{
					Thread.Sleep(Class91.random_0.Next(10));
				}
			}
			string result;
			try
			{
				StreamReader streamReader = new StreamReader(fileStream, new UTF8Encoding());
				string text = streamReader.ReadToEnd();
				text = Class91.smethod_7(text);
				List<string> list = text.Split(new char[]
				{
					'\n'
				}, StringSplitOptions.RemoveEmptyEntries).ToList<string>();
				string value = "Global-" + string_1 + ": ";
				int num = -1;
				int i = 0;
				while (i < list.Count)
				{
					if (!list[i].StartsWith(value))
					{
						i++;
					}
					else
					{
						num = i;
						IL_E3:
						if (num > -1)
						{
							result = list[num].Remove(0, list[num].IndexOf(':') + 2).Trim();
							return result;
						}
						result = null;
						return result;
					}
				}
				
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error saving to setting file: " + ex.Message);
				Process.GetCurrentProcess().Kill();
			}
			finally
			{
				if (fileStream != null)
				{
					fileStream.Close();
				}
			}
			result = null;
			return result;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal static void smethod_3(int int_2, string string_1, string string_2)
		{
			if (!Class91.bool_0)
			{
				throw new Exception("Settings must be initialized before usage!");
			}
			if (!File.Exists(Class91.string_0))
			{
				MessageBox.Show("Error: Settings file has been deleted!", "HellBuddy Bot", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				Process.GetCurrentProcess().Kill();
			}
			FileStream fileStream;
			while (true)
			{
				fileStream = null;
				try
				{
					fileStream = File.Open(Class91.string_0, FileMode.Open, FileAccess.ReadWrite, FileShare.None);
					break;
				}
				catch (Exception ex)
				{
					Thread.Sleep(Class91.random_0.Next(10));
				}
			}
			try
			{
				StreamReader streamReader = new StreamReader(fileStream, new UTF8Encoding());
				string text = streamReader.ReadToEnd();
				text = Class91.smethod_7(text);
				List<string> list = text.Split(new char[]
				{
					'\n'
				}, StringSplitOptions.RemoveEmptyEntries).ToList<string>();
				string text2 = int_2.ToString("00000") + "-" + string_1 + ": ";
				int num = -1;
				for (int i = 0; i < list.Count; i++)
				{
					if (list[i].StartsWith(text2))
					{
						num = i;
						IL_F2:
						string text3 = text2 + string_2;
						if (num > -1)
						{
							list[num] = text3;
						}
						else
						{
							list.Add(text3);
						}
						fileStream.Seek(0L, SeekOrigin.Begin);
						StreamWriter streamWriter = new StreamWriter(fileStream, new UTF8Encoding());
						StringBuilder stringBuilder = new StringBuilder(3000);
						for (i = 0; i < list.Count; i++)
						{
							list[i] = list[i].Replace("\r", "");
							stringBuilder.AppendLine(list[i]);
						}
						string value = Class91.smethod_6(stringBuilder.ToString());
						streamWriter.Write(value);
						streamWriter.Flush();
						fileStream.Flush();
						fileStream.SetLength(fileStream.Position);
						fileStream.Close();
						return;
					}
				}
				
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error saving to setting file: " + ex.Message);
				Process.GetCurrentProcess().Kill();
			}
			finally
			{
				if (fileStream != null)
				{
					fileStream.Close();
				}
			}
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal static string smethod_4(int int_2, string string_1)
		{
			if (!Class91.bool_0)
			{
				throw new Exception("Settings must be initialized before usage!");
			}
			if (!File.Exists(Class91.string_0))
			{
				MessageBox.Show("Error: Settings file has been deleted!", "HellBuddy Bot", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				Process.GetCurrentProcess().Kill();
			}
			string result;
			while (true)
			{
				FileStream fileStream = null;
				try
				{
					fileStream = File.Open(Class91.string_0, FileMode.Open, FileAccess.ReadWrite, FileShare.None);
				}
				catch
				{
					Thread.Sleep(Class91.random_0.Next(10));
					continue;
				}
				try
				{
					StreamReader streamReader = new StreamReader(fileStream, new UTF8Encoding());
					string text = streamReader.ReadToEnd();
					text = Class91.smethod_7(text);
					text = text.Replace('\r', '\n');
					List<string> list = text.Split(new char[]
					{
						'\n'
					}, StringSplitOptions.RemoveEmptyEntries).ToList<string>();
					string value = int_2.ToString("00000") + "-" + string_1 + ": ";
					int num = -1;
					int i = 0;
					while (i < list.Count)
					{
						if (!list[i].StartsWith(value))
						{
							i++;
						}
						else
						{
							num = i;
							IL_FF:
							if (num > -1)
							{
								result = list[num].Remove(0, list[num].IndexOf(':') + 2).Trim();
								return result;
							}
							result = null;
							return result;
						}
					}
					
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error saving to setting file: " + ex.Message);
					Process.GetCurrentProcess().Kill();
				}
				finally
				{
					if (fileStream != null)
					{
						fileStream.Close();
					}
				}
			}
			return result;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal static void smethod_5()
		{
			if (!Class91.bool_0)
			{
				throw new Exception("Settings must be initialized before usage!");
			}
			FileStream fileStream;
			while (true)
			{
				fileStream = null;
				try
				{
					fileStream = new FileStream(Class91.string_0, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);
					break;
				}
				catch
				{
					Thread.Sleep(Class91.random_0.Next(10));
				}
			}
			StreamReader streamReader = new StreamReader(fileStream, new UTF8Encoding());
			string text = streamReader.ReadToEnd();
			text = Class91.smethod_7(text);
			List<string> list = text.Split("\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToList<string>();
			List<string> list2 = new List<string>(list.Count);
			for (int i = 0; i < list.Count; i++)
			{
				if (list[i].StartsWith("Global-"))
				{
					list2.Add(list[i]);
				}
				else
				{
					string s = list[i].Substring(0, 5);
					int processId = int.Parse(s);
					Process process = null;
					try
					{
						process = Process.GetProcessById(processId);
					}
					catch
					{
						process = null;
						goto IL_F2;
					}
					if (process != null && !process.HasExited)
					{
						list2.Add(list[i]);
					}
				}
				IL_F2:;
			}
			fileStream.Seek(0L, SeekOrigin.Begin);
			StreamWriter streamWriter = new StreamWriter(fileStream, new UTF8Encoding());
			StringBuilder stringBuilder = new StringBuilder(3000);
			foreach (string current in list2)
			{
				string value = current.Replace("\r", "");
				stringBuilder.AppendLine(value);
			}
			string value2 = Class91.smethod_6(stringBuilder.ToString());
			streamWriter.Write(value2);
			streamWriter.Flush();
			fileStream.Flush();
			fileStream.SetLength(fileStream.Position);
			fileStream.Close();
		}
		private static string smethod_6(string string_1)
		{
			byte[] bytes = Encoding.UTF8.GetBytes(string_1);
			Class91.smethod_8(ref bytes);
			return Convert.ToBase64String(bytes);
		}
		private static string smethod_7(string string_1)
		{
			byte[] bytes = Convert.FromBase64String(string_1);
			Class91.smethod_9(ref bytes);
			return Encoding.UTF8.GetString(bytes);
		}
		private static void smethod_8(ref byte[] byte_0)
		{
			byte b = 239;
			byte b2 = 231;
			for (int i = 0; i < byte_0.Length; i++)
			{
				byte[] expr_18_cp_0 = byte_0;
				int expr_18_cp_1 = i;
				expr_18_cp_0[expr_18_cp_1] += b;
				byte[] expr_2E_cp_0 = byte_0;
				int expr_2E_cp_1 = i;
				expr_2E_cp_0[expr_2E_cp_1] ^= b2;
			}
		}
		private static void smethod_9(ref byte[] byte_0)
		{
			byte b = 239;
			byte b2 = 231;
			for (int i = 0; i < byte_0.Length; i++)
			{
				byte[] expr_18_cp_0 = byte_0;
				int expr_18_cp_1 = i;
				expr_18_cp_0[expr_18_cp_1] ^= b2;
				byte[] expr_2E_cp_0 = byte_0;
				int expr_2E_cp_1 = i;
				expr_2E_cp_0[expr_2E_cp_1] -= b;
			}
		}
	}
}
