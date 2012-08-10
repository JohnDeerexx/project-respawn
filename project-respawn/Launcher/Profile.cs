using AdvancedDebugging;
using Microsoft.Win32;
using Newtonsoft.Json;
using ns0;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
namespace Launcher
{
	[JsonObject(MemberSerialization.OptIn)]
	internal sealed class Profile
	{
		public enum RegionOverride
		{
			NoOverride,
			America,
			Europe,
			Asia
		}
		[JsonObject(MemberSerialization = MemberSerialization.OptOut)]
		public sealed class Class1
		{
			public TimeSpan timeSpan_0;
			public TimeSpan timeSpan_1;
			public override string ToString()
			{
				return string.Concat(new string[]
				{
					"Active from \"",
					this.timeSpan_0.ToString("hh\\:mm"),
					"\" to \"",
					this.timeSpan_1.ToString("hh\\:mm"),
					"\""
				});
			}
		}
		public struct Struct0
		{
			public int int_0;
			public int int_1;
			public int int_2;
			public int int_3;
		}
		private delegate bool Delegate0(IntPtr hWnd, IntPtr lParam);
		private enum Enum0
		{
			const_0 = 1,
			const_1,
			const_2
		}
		[CompilerGenerated]
		private sealed class Class5
		{
			public List<IntPtr> list_0;
			public bool method_0(IntPtr intptr_0, IntPtr intptr_1)
			{
				this.list_0.Add(intptr_0);
				return true;
			}
		}
		private const string string_0 = "o34f57heaniow8qq";
		private const string string_1 = "aniow8qqaniow8qqaniow8qqaniow8qq";
		internal const string string_2 = ".hbp";
		private const uint HookAddress = 8444230u;
		private int AMinuteBeforeMidnight = (int)new TimeSpan(23, 59, 0).TotalSeconds;
		private bool _profileActive;
		public AdvancedDebugger debugger;
		private AutoResetEvent readyToInject;
		private int HookExecuteCount;
		internal static readonly string ProfileFolder;
		private DateTime lastStartProfileFailedBecauseOfRecentlyStartedError = DateTime.Now - TimeSpan.FromHours(100.0);
		private List<char> alphabet = "abcdefghijklmnopqrstuvwxyz1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZ_ -".ToList<char>();
		[JsonProperty]
		public string ProfileName
		{
			get;
			set;
		}
		[JsonProperty]
		public string AccountName
		{
			get;
			set;
		}
		[JsonProperty]
		public string Password
		{
			get;
			set;
		}
		[JsonProperty]
		public bool AutoLogin
		{
			get;
			set;
		}
		[JsonProperty]
		public string Parameters
		{
			get;
			set;
		}
		[JsonProperty]
		public bool StartMinimized
		{
			get;
			set;
		}
		[JsonProperty]
		public string D3Executable
		{
			get;
			set;
		}
		[JsonProperty]
		public bool AutoStartThisProfile
		{
			get;
			set;
		}
		[JsonProperty]
		public Profile.RegionOverride Region
		{
			get;
			set;
		}
		[JsonProperty]
		public bool UseSchedule
		{
			get;
			set;
		}
		[JsonProperty]
		public List<Profile.Class1> Schedule
		{
			get;
			set;
		}
		[JsonProperty]
		public int ForceRestartTimeoutMinutes
		{
			get;
			set;
		}
		public bool ProfileActive
		{
			get
			{
				return this._profileActive;
			}
			set
			{
				if (this._profileActive != value)
				{
					this._profileActive = value;
					try
					{
            ProfileManager.Instance.Invoke((MethodInvoker)delegate
						{
							try
							{
								ProfileManager.Instance.method_2();
								ProfileManager.Instance.method_1();
							}
							catch
							{
							}
						});
					}
					catch
					{
					}
				}
			}
		}
		internal bool Schedule_IsInActiveFrame
		{
			get
			{
				foreach (Profile.Class1 current in this.Schedule)
				{
					DateTime dateTime_ = DateTime.Today + current.timeSpan_0;
					DateTime dateTime_2 = DateTime.Today + current.timeSpan_1;
					if (DateTime.Now.smethod_2(dateTime_, dateTime_2))
					{
						bool result = true;
						return result;
					}
					if ((DateTime.Now - DateTime.Today).TotalSeconds > (double)this.AMinuteBeforeMidnight)
					{
						bool result = true;
						return result;
					}
				}
				return false;
			}
		}
		internal bool GameShouldBeRunning
		{
			get
			{
				return this.ProfileActive && (!this.UseSchedule || this.Schedule_IsInActiveFrame);
			}
		}
		public string LoadedFromFileName
		{
			get;
			set;
		}
		public Process D3Process
		{
			get;
			set;
		}
		public bool IsCurrentlyRunning
		{
			get
			{
				return this.D3Process != null && !this.D3Process.HasExited && this.D3Process.ProcessName == "Diablo III";
			}
		}
		static Profile()
		{
			Profile.ProfileFolder = Path.Combine(Path.GetTempPath(), "HellBuddy\\Profiles\\");
			if (!Directory.Exists(Profile.ProfileFolder))
			{
				Directory.CreateDirectory(Profile.ProfileFolder);
			}
		}
		[JsonConstructor]
		internal Profile()
		{
			this.Schedule = new List<Profile.Class1>();
			this.AccountName = "";
			this.Password = "";
		}
		internal void Update()
		{
			if (this.D3Process != null)
			{
				if (!(this.D3Process.ProcessName != Path.GetFileNameWithoutExtension(this.D3Executable)) && !this.D3Process.HasExited)
				{
					if (this.ForceRestartTimeoutMinutes > 0 && (DateTime.Now - this.D3Process.StartTime).TotalMinutes > (double)this.ForceRestartTimeoutMinutes)
					{
						this.D3Process.Kill();
					}
				}
				else
				{
					this.D3Process = null;
					ProfileManager.Instance.Invoke((MethodInvoker)delegate
					{
						try
						{
							ProfileManager.Instance.method_1();
							ProfileManager.Instance.method_2();
						}
						catch
						{
						}
					});
				}
			}
			if ((this.ProfileActive && !this.UseSchedule) || (this.ProfileActive && this.UseSchedule && this.Schedule_IsInActiveFrame))
			{
				if (this.D3Process == null)
				{
					try
					{
						this.SaveToFile();
					}
					catch
					{
						MessageBox.Show("Cannot start the profile, because there was an error saving it!", "HellBuddy Bot", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
						this.ProfileActive = false;
						return;
					}
					this.StartProfile();
					return;
				}
			}
			else
			{
				if (this.D3Process != null && !this.D3Process.HasExited && this.D3Process.ProcessName == Path.GetFileNameWithoutExtension(this.D3Executable))
				{
					this.D3Process.Kill();
					this.D3Process = null;
          Form.ActiveForm.Invoke((MethodInvoker)delegate
					{
						try
						{
							(Form.ActiveForm as ProfileManager).method_1();
							(Form.ActiveForm as ProfileManager).method_2();
						}
						catch
						{
						}
					});
				}
			}
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void StartProfile()
		{
			int num = (
				from p in ProfileManager.Instance.list_0
				where p.IsCurrentlyRunning
				select p).Count<Profile>();
			if (this.IsCurrentlyRunning || num >= ProfileManager.maxClients)
			{
				return;
			}
			int num2 = (
				from p in ProfileManager.Instance.list_0
				where p != this
				where p.IsCurrentlyRunning
				where DateTime.Now - p.D3Process.StartTime < TimeSpan.FromSeconds(12.0)
				select p).Count<Profile>();
			if (num2 > 0)
			{
				this.lastStartProfileFailedBecauseOfRecentlyStartedError = DateTime.Now;
				ProfileManager.Instance.method_1();
				return;
			}
			this.ProfileActive = true;
			this.HookExecuteCount = 0;
			bool flag = true;
			if (this.debugger != null)
			{
				this.debugger.Terminate();
			}
			this.debugger = new AdvancedDebugger();
			this.debugger.OnCreateThread += new Action<Native.CreateThreadDebugInfo, uint>(this.dbg_ThreadCreated);
			this.D3Process = Process.Start(this.D3Executable, "-launch -window " + this.Parameters);
			Thread.Sleep(600);
			Class4.smethod_5();
			if (!this.debugger.Attach(this.D3Process.Id, false))
			{
				this.ProfileActive = false;
				flag = false;
				try
				{
					this.D3Process.Kill();
				}
				catch
				{
				}
			}
			if (!flag)
			{
				this.D3Process.Kill();
				this.ProfileActive = false;
				MessageBox.Show("Could not attach to the game.\nThe game has been closed for security.\nFor more information, visit the forum", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return;
			}
      ProfileManager.Instance.Invoke((MethodInvoker)delegate
			{
				try
				{
					ProfileManager.Instance.method_1();
					ProfileManager.Instance.method_2();
				}
				catch
				{
				}
			});
			Class4.smethod_5();
			this.readyToInject = new AutoResetEvent(false);
			new Thread((ThreadStart)delegate
			{
				Process d3Process = this.D3Process;
				try
				{
					if (!this.readyToInject.WaitOne(TimeSpan.FromSeconds(40.0)))
					{
						if (!d3Process.HasExited)
						{
							try
							{
								d3Process.Kill();
							}
							catch
							{
							}
						}
					}
					else
					{
						if (d3Process != null && !d3Process.HasExited)
						{
							Thread.Sleep(200);
							this.debugger.KillOnDetach = false;
							this.debugger.RequestDetach();
							bool arg_77_0 = this.StartMinimized;
							Class4.smethod_3(this.D3Process.Id, "ProfileFile", Path.Combine(Profile.ProfileFolder, this.GetFileName()));
							if (this.AutoLogin)
							{
								Class4.smethod_3(this.D3Process.Id, "Email", this.AccountName);
								Class4.smethod_3(this.D3Process.Id, "Password", this.Password);
							}
							if (this.Region != Profile.RegionOverride.NoOverride)
							{
								try
								{
									RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Blizzard Entertainment\\Battle.net\\D3", true);
									switch (this.Region)
									{
									case Profile.RegionOverride.America:
										registryKey.SetValue("RegionURL", "us.actual.battle.net", RegistryValueKind.String);
										break;
									case Profile.RegionOverride.Europe:
										registryKey.SetValue("RegionURL", "eu.actual.battle.net", RegistryValueKind.String);
										break;
									case Profile.RegionOverride.Asia:
										registryKey.SetValue("RegionURL", "kr.actual.battle.net", RegistryValueKind.String);
										break;
									}
								}
								catch (Exception ex)
								{
									MessageBox.Show(ex.Message);
								}
							}
							Thread.Sleep(500);
							GClass0.smethod_1(Path.Combine(ProfileManager.smethod_0(), ProfileManager.smethod_1()), this.D3Process.Id);
							this.HookExecuteCount = 0;
						}
					}
				}
				catch
				{
				}
			})
			{
				IsBackground = true
			}.Start();
		}
		[DllImport("psapi.dll", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
		public static extern int EnumProcessModules(IntPtr hProcess, [Out] IntPtr lphModule, uint cb, out uint lpcbNeeded);
		[DllImport("psapi.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
		private static extern uint GetModuleFileNameEx(IntPtr hProcess, IntPtr hModule, [Out] StringBuilder lpBaseName, uint nSize);
		private uint GetModuleFunctionAddress_Native(string moduleName, string functionName)
		{
			IntPtr moduleHandle = Native.LoadLibrary(moduleName);
			uint num = (uint)Native.GetProcAddress(moduleHandle, functionName).ToInt32();
			if (num == 0u)
			{
				return 0u;
			}
			uint num2 = 0u;
			IntPtr[] array = new IntPtr[1024];
			GCHandle gCHandle = GCHandle.Alloc(array, GCHandleType.Pinned);
			IntPtr lphModule = gCHandle.AddrOfPinnedObject();
			uint cb = (uint)(Marshal.SizeOf(typeof(IntPtr)) * array.Length);
			uint num3 = 0u;
			if (Profile.EnumProcessModules(this.D3Process.Handle, lphModule, cb, out num3) == 1)
			{
				int num4 = (int)((ulong)num3 / (ulong)((long)Marshal.SizeOf(typeof(IntPtr))));
				for (int i = 0; i < num4; i++)
				{
					StringBuilder stringBuilder = new StringBuilder(1024);
					Profile.GetModuleFileNameEx(this.D3Process.Handle, array[i], stringBuilder, (uint)stringBuilder.Capacity);
					if (stringBuilder.ToString() == moduleName)
					{
						num2 = (uint)array[i].ToInt32();
						break;
					}
				}
			}
			gCHandle.Free();
			return num2 + num;
		}
		private void dbg_ThreadCreated(Native.CreateThreadDebugInfo info, uint threadId)
		{
			uint address = 0u;
			try
			{
				address = this.debugger.GetModuleFunctionAddress("Kernel32.dll", "CreateFileW");
			}
			catch (Exception)
			{
				try
				{
					address = this.GetModuleFunctionAddress_Native("Kernel32.dll", "CreateFileW");
				}
				catch
				{
					try
					{
						this.D3Process.Kill();
					}
					catch
					{
					}
					return;
				}
			}
			int num = 0;
			while (!this.debugger.SetHardwareBreakpoint(threadId, address, BreakpointType.Execute, BreakpointSize.Size1, new BreakpointHandler(this.dbg_CreateFileWCallback)))
			{
				Marshal.GetLastWin32Error();
				num++;
				if (num >= 100)
				{
					break;
				}
			}
			if (this.HookExecuteCount == 0 && !this.debugger.SetHardwareBreakpoint(threadId, 8444230u, BreakpointType.Execute, BreakpointSize.Size1, new BreakpointHandler(this.dbg_OnExecuteHook)))
			{
				if (!this.ProfileActive)
				{
					return;
				}
				try
				{
					this.D3Process.Kill();
				}
				catch
				{
				}
			}
		}
		private void dbg_CreateFileWCallback(AdvancedDebugger debugger, ref Context ctx, HardwareBreakpoint bp, int threadHandle)
		{
			int address = ctx.Esp + 4;
			int address2 = debugger.Memory.ReadInt(address);
			string text = debugger.Memory.ReadString(address2, 240, Encoding.Unicode);
			text = text.ToLower();
			if (text.EndsWith(".mpq"))
			{
				debugger.Memory.WriteInt((uint)(ctx.Esp + 12), 3);
			}
		}
		private void dbg_OnExecuteHook(AdvancedDebugger debugger, ref Context ctx, HardwareBreakpoint bp, int threadHandle)
		{
			this.HookExecuteCount++;
			if (this.HookExecuteCount < 10)
			{
				return;
			}
			this.readyToInject.Set();
			debugger.RemoveBreakpointsWhere((HardwareBreakpoint b) => b.Address == 8444230u && b.BreakpointType == BreakpointType.Execute);
		}
		private void WaitForD3Opened(Process p)
		{
			IntPtr d3Window;
			do
			{
				Thread.Sleep(100);
				if (p == null)
				{
					goto IL_2D;
				}
				if (p.HasExited)
				{
					goto IL_33;
				}
				d3Window = Profile.GetD3Window(p.Id);
			}
			while (d3Window == IntPtr.Zero);
			this.readyToInject.Set();
			return;
			IL_2D:
			throw new Exception();
			IL_33:
			throw new Exception();
		}
		[DllImport("user32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool GetWindowRect(IntPtr hWnd, ref Profile.Struct0 lpRect);
		private static IntPtr GetD3Window(int pid)
		{
			IEnumerable<IntPtr> enumerable = Profile.EnumerateProcessWindowHandles(pid);
			Profile.Struct0 @struct = default(Profile.Struct0);
			foreach (IntPtr current in enumerable)
			{
				Profile.GetWindowRect(current, ref @struct);
				int num = @struct.int_3 - @struct.int_1;
				int num2 = @struct.int_2 - @struct.int_0;
				if (num > 374 || num2 > 565)
				{
					return current;
				}
			}
			return IntPtr.Zero;
		}
		[DllImport("user32.dll")]
		private static extern bool EnumThreadWindows(int dwThreadId, Profile.Delegate0 lpfn, IntPtr lParam);
		private static IEnumerable<IntPtr> EnumerateProcessWindowHandles(int processId)
		{
			Profile.Delegate0 @delegate = null;
			Profile.Class5 @class = new Profile.Class5();
			@class.list_0 = new List<IntPtr>();
			foreach (ProcessThread processThread in Process.GetProcessById(processId).Threads)
			{
				int arg_4F_0 = processThread.Id;
				if (@delegate == null)
				{
					@delegate = new Profile.Delegate0(@class.method_0);
				}
				Profile.EnumThreadWindows(arg_4F_0, @delegate, IntPtr.Zero);
			}
			return @class.list_0;
		}
		[DllImport("user32.dll")]
		private static extern bool ShowWindowAsync(IntPtr hWnd, Profile.Enum0 nCmdShow);
		internal static Profile LoadFromFile(string fileName)
		{
			Profile result;
			try
			{
				using (FileStream fileStream = new FileStream(Path.Combine(Profile.ProfileFolder, fileName), FileMode.Open))
				{
					Rijndael rijndael = Rijndael.Create();
					ICryptoTransform transform = rijndael.CreateDecryptor(Encoding.ASCII.GetBytes("aniow8qqaniow8qqaniow8qqaniow8qq"), Encoding.ASCII.GetBytes("o34f57heaniow8qq"));
					using (CryptoStream cryptoStream = new CryptoStream(fileStream, transform, CryptoStreamMode.Read))
					{
						using (Stream stream = new GZipStream(cryptoStream, CompressionMode.Decompress))
						{
							using (StreamReader streamReader = new StreamReader(stream, new UTF8Encoding()))
							{
								string value = streamReader.ReadToEnd();
								Profile profile = JsonConvert.DeserializeObject<Profile>(value);
								profile.LoadedFromFileName = fileName;
								result = profile;
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading Profile: " + ex.Message, "HellBuddy Bot", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				throw;
			}
			return result;
		}
		internal void SaveToFile()
		{
			string fileName = this.GetFileName();
			if (fileName == null)
			{
				MessageBox.Show("Profile cannot be saved because it has an invalid name!", "HellBuddy Bot", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				throw new Exception();
			}
			try
			{
				if (this.LoadedFromFileName != null)
				{
					string path = Path.Combine(Profile.ProfileFolder, this.LoadedFromFileName);
					if (fileName != this.LoadedFromFileName && File.Exists(path))
					{
						File.Delete(path);
					}
				}
				this.LoadedFromFileName = fileName;
				using (FileStream fileStream = new FileStream(Path.Combine(Profile.ProfileFolder, fileName), FileMode.Create))
				{
					Rijndael rijndael = Rijndael.Create();
					ICryptoTransform transform = rijndael.CreateEncryptor(Encoding.ASCII.GetBytes("aniow8qqaniow8qqaniow8qqaniow8qq"), Encoding.ASCII.GetBytes("o34f57heaniow8qq"));
					using (CryptoStream cryptoStream = new CryptoStream(fileStream, transform, CryptoStreamMode.Write))
					{
						using (Stream stream = new GZipStream(cryptoStream, CompressionMode.Compress))
						{
							using (StreamWriter streamWriter = new StreamWriter(stream, new UTF8Encoding()))
							{
								string value = JsonConvert.SerializeObject(this, Formatting.None);
								streamWriter.Write(value);
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error saving Profile: \"" + this.ProfileName + "\": " + ex.Message, "HellBuddy Bot", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}
		public override string ToString()
		{
			string text = this.ProfileName;
			bool flag = false;
			if (DateTime.Now - this.lastStartProfileFailedBecauseOfRecentlyStartedError < TimeSpan.FromSeconds(2.0))
			{
				flag = true;
			}
			if (this.UseSchedule)
			{
				if (this.Schedule_IsInActiveFrame)
				{
					if (flag)
					{
						text += " - Schedule: Waiting...";
					}
					else
					{
						text += " - Schedule: Active";
					}
				}
				else
				{
					text += " - Scheduled...";
				}
			}
			else
			{
				if (this.ProfileActive)
				{
					if (flag)
					{
						text += " - Waiting...";
					}
					else
					{
						text += " - Active";
					}
				}
			}
			if (this.ForceRestartTimeoutMinutes > 0)
			{
				object obj = text;
				text = string.Concat(new object[]
				{
					obj,
					" (",
					this.ForceRestartTimeoutMinutes,
					" min limit)"
				});
			}
			if (this.D3Process != null && !flag && !this.D3Process.HasExited)
			{
				text = text + ", PID: 0x" + this.D3Process.Id.ToString("X");
			}
			return text;
		}
		internal string GetFileName()
		{
			List<char> list = this.ProfileName.ToCharArray().ToList<char>();
			for (int i = 0; i < list.Count; i++)
			{
				if (!this.alphabet.Contains(list[i]))
				{
					list.RemoveAt(i--);
				}
			}
			if (list.Count == 0)
			{
				return null;
			}
			list.AddRange(".hbp");
			return new string(list.ToArray());
		}
	}
}
