using System;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
namespace ns0
{
	public static class GClass0
	{
		[DllImport("kernel32")]
		public static extern IntPtr CreateRemoteThread(IntPtr intptr_0, IntPtr intptr_1, uint uint_0, UIntPtr uintptr_0, IntPtr intptr_2, uint uint_1, out IntPtr intptr_3);
		[DllImport("kernel32.dll")]
		public static extern IntPtr OpenProcess(uint uint_0, int int_0, int int_1);
		[DllImport("kernel32.dll")]
		public static extern int CloseHandle(IntPtr intptr_0);
		[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
		private static extern bool VirtualFreeEx(IntPtr intptr_0, IntPtr intptr_1, UIntPtr uintptr_0, uint uint_0);
		[DllImport("kernel32.dll", CharSet = CharSet.Ansi, ExactSpelling = true)]
		public static extern UIntPtr GetProcAddress(IntPtr intptr_0, string string_0);
		[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
		private static extern IntPtr VirtualAllocEx(IntPtr intptr_0, IntPtr intptr_1, uint uint_0, uint uint_1, uint uint_2);
		[DllImport("kernel32.dll")]
		private static extern bool WriteProcessMemory(IntPtr intptr_0, IntPtr intptr_1, string string_0, UIntPtr uintptr_0, out IntPtr intptr_2);
		[DllImport("kernel32.dll", CharSet = CharSet.Auto)]
		public static extern IntPtr GetModuleHandle(string string_0);
		[DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
		internal static extern int WaitForSingleObject(IntPtr intptr_0, int int_0);
		private static bool smethod_0(IntPtr intptr_0, string string_0)
		{
			int num = string_0.Length + 1;
			IntPtr intPtr = GClass0.VirtualAllocEx(intptr_0, (IntPtr)null, (uint)num, 4096u, 64u);
			IntPtr intPtr2;
			GClass0.WriteProcessMemory(intptr_0, intPtr, string_0, (UIntPtr)((ulong)((long)num)), out intPtr2);
			UIntPtr procAddress = GClass0.GetProcAddress(GClass0.GetModuleHandle("kernel32.dll"), "LoadLibraryA");
			if (procAddress == UIntPtr.Zero)
			{
				MessageBox.Show("LoadLibraryA Error! Error: " + Marshal.GetLastWin32Error().ToString("X") + "\n");
				return false;
			}
			IntPtr intPtr3 = GClass0.CreateRemoteThread(intptr_0, (IntPtr)null, 0u, procAddress, intPtr, 0u, out intPtr2);
			if (intPtr3 == IntPtr.Zero)
			{
				MessageBox.Show("CreateRemoteThread Error! Error: " + Marshal.GetLastWin32Error().ToString("X") + "\n");
				return false;
			}
			uint num2 = (uint)GClass0.WaitForSingleObject(intPtr3, 10000);
			if ((ulong)num2 != 128uL && (ulong)num2 != 258uL)
			{
				if (num2 != 4294967295u)
				{
					Thread.Sleep(500);
					GClass0.VirtualFreeEx(intptr_0, intPtr, (UIntPtr)0u, 32768u);
					GClass0.CloseHandle(intPtr3);
					return true;
				}
			}
			int lastWin32Error = Marshal.GetLastWin32Error();
			MessageBox.Show("WaitForSingleObject Error! Result: 0x" + num2.ToString("X") + "\nGetLastError: 0x" + lastWin32Error.ToString("X"));
			GClass0.CloseHandle(intPtr3);
			return false;
		}
		public static void smethod_1(string string_0, int int_0)
		{
			if (int_0 >= 0)
			{
				IntPtr intptr_ = GClass0.OpenProcess(2035711u, 1, int_0);
				GClass0.smethod_0(intptr_, string_0);
			}
		}
		public static void smethod_2(string string_0, string string_1)
		{
			Process process = Process.GetProcessesByName(string_1).FirstOrDefault<Process>();
			int num = -1;
			if (process != null)
			{
				num = process.Id;
			}
			else
			{
				MessageBox.Show("Process not found!");
			}
			if (num >= 0)
			{
				IntPtr intptr_ = GClass0.OpenProcess(2035711u, 1, num);
				GClass0.smethod_0(intptr_, string_0);
			}
		}
	}
}
