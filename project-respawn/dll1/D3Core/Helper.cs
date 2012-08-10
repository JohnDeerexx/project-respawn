using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
namespace D3Core
{
	public static class Helper
	{
		private static IntPtr intptr_0 = IntPtr.Zero;
		[SuppressUnmanagedCodeSecurity]
		[DllImport("kernel32.dll")]
		internal static extern IntPtr OpenProcess(uint uint_0, bool bool_0, int int_0);
		[SuppressUnmanagedCodeSecurity]
		[DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
		internal static extern bool WriteProcessMemory(IntPtr intptr_1, IntPtr intptr_2, byte[] byte_0, uint uint_0, out int int_0);
		[SuppressUnmanagedCodeSecurity]
		[DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
		public static extern bool ReadProcessMemory(IntPtr hProcess, uint lpBaseAddress, IntPtr lpBuffer, int nSize, out int lpNumberOfBytesRead);
		[DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
		public static extern int VirtualProtect(IntPtr lpAddress, int dwSize, int flNewProtect, ref int lpflOldProtect);
		public static IntPtr GetVFunc(IntPtr pointer, int methIndex)
		{
			IntPtr ptr = Marshal.ReadIntPtr(pointer);
			return Marshal.ReadIntPtr(ptr, methIndex * IntPtr.Size);
		}
		public static T RegisterDelegate<T>(IntPtr ptr) where T : class
		{
			return Marshal.GetDelegateForFunctionPointer(ptr, typeof(T)) as T;
		}
		public static T RegisterDelegate<T>(uint address) where T : class
		{
			IntPtr ptr = new IntPtr((long)((ulong)address));
			return Marshal.GetDelegateForFunctionPointer(ptr, typeof(T)) as T;
		}
		public static float ReadFloat(IntPtr ptr)
		{
			byte[] value = Helper.ReadBytes(ptr, 4);
			return BitConverter.ToSingle(value, 0);
		}
		public static void WriteFloat(IntPtr address, float value)
		{
			byte[] bytes = BitConverter.GetBytes(value);
			Helper.WriteBytes(address, bytes);
		}
		public static int WriteBytes(IntPtr ptr, byte[] bytes)
		{
			if (Helper.intptr_0 == IntPtr.Zero)
			{
				Helper.intptr_0 = Helper.OpenProcess(2035711u, true, Process.GetCurrentProcess().Id);
			}
			int num;
			int result;
			if (Helper.WriteProcessMemory(Helper.intptr_0, ptr, bytes, (uint)bytes.Length, out num))
			{
				result = num;
			}
			else
			{
				result = 0;
			}
			return result;
		}
		[HandleProcessCorruptedStateExceptions]
		public static int ReadRawMemory(IntPtr hProcess, uint dwAddress, IntPtr lpBuffer, int nSize)
		{
			int num = 0;
			int result;
			try
			{
				if (!Helper.ReadProcessMemory(hProcess, dwAddress, lpBuffer, nSize, out num))
				{
					throw new Exception("ReadProcessMemory failed");
				}
				result = num;
			}
			catch
			{
				result = 0;
			}
			return result;
		}
		public static byte[] ReadBytes(uint dwAddress, int nSize)
		{
			if (Helper.intptr_0 == IntPtr.Zero)
			{
				Helper.intptr_0 = Helper.OpenProcess(2035711u, true, Process.GetCurrentProcess().Id);
			}
			IntPtr intPtr = IntPtr.Zero;
			byte[] array;
			byte[] result;
			try
			{
				intPtr = Marshal.AllocHGlobal(nSize);
				int num = Helper.ReadRawMemory(Helper.intptr_0, dwAddress, intPtr, nSize);
				if (num != nSize)
				{
					throw new Exception("ReadProcessMemory error in ReadBytes");
				}
				array = new byte[num];
				Marshal.Copy(intPtr, array, 0, num);
			}
			catch
			{
				result = null;
				return result;
			}
			finally
			{
				if (intPtr != IntPtr.Zero)
				{
					Marshal.FreeHGlobal(intPtr);
				}
			}
			result = array;
			return result;
		}
		public static byte[] ReadBytes(IntPtr address, int size)
		{
			return Helper.ReadBytes((uint)address.ToInt32(), size);
		}
		internal static short smethod_0(uint uint_0)
		{
			return Marshal.ReadInt16(new IntPtr((int)uint_0));
		}
		internal static uint smethod_1(uint uint_0)
		{
			return (uint)Marshal.ReadInt32(new IntPtr((int)uint_0));
		}
		internal static void smethod_2(uint uint_0, int int_0)
		{
			Marshal.WriteInt32(new IntPtr((int)uint_0), int_0);
		}
		internal static void smethod_3(uint uint_0, uint uint_1)
		{
			Marshal.WriteInt32(new IntPtr((int)uint_0), (int)uint_1);
		}
		public static string ReadString(uint stringAddress, Encoding encoding = null)
		{
			byte[] array = Helper.ReadBytes(stringAddress, 200);
			Encoding encoding2;
			if (encoding != null)
			{
				encoding2 = encoding;
			}
			else
			{
				encoding2 = new ASCIIEncoding();
			}
			int num = 0;
			while (num < array.Length && array[num] != 0)
			{
				num++;
			}
			return encoding2.GetString(array, 0, num);
		}
		public static void WriteString(uint address, string data, Encoding encoding = null)
		{
			data += "\0\0";
			Encoding encoding2;
			if (encoding != null)
			{
				encoding2 = encoding;
			}
			else
			{
				encoding2 = new UTF8Encoding();
			}
			List<byte> list = encoding2.GetBytes(data).ToList<byte>();
			list.Add(0);
			list.Add(0);
			Helper.WriteBytes(new IntPtr((long)((ulong)address)), list.ToArray());
		}
		public static uint FindPattern(byte[] searchedBytes, uint startSearch = 4194304u, uint endSearch = 2147483647u)
		{
			if (Helper.intptr_0 == IntPtr.Zero)
			{
				Helper.intptr_0 = Helper.OpenProcess(2035711u, true, Process.GetCurrentProcess().Id);
			}
			uint num = 0u;
			uint num2 = 32768u;
			for (uint num3 = startSearch; num3 < endSearch; num3 += num2)
			{
				byte[] array = Helper.ReadBytes(num3, (int)num2);
				if (array != null)
				{
					int lastWin32Error = Marshal.GetLastWin32Error();
					uint result;
					if (lastWin32Error == 0)
					{
						uint num4 = 0u;
						IL_99:
						while ((ulong)num4 < (ulong)((long)(array.Length - searchedBytes.Length)))
						{
							bool flag = true;
							int i = 0;
							while (i < searchedBytes.Length)
							{
								if (array[(int)checked((IntPtr)unchecked((ulong)num4 + (ulong)((long)i)))] == searchedBytes[i])
								{
									i++;
								}
								else
								{
									flag = false;
									IL_8C:
									if (!flag)
									{
										num4 += 1u;
										goto IL_99;
									}
									num = num4 + num3;
									goto IL_AF;
								}
							}
							
							IL_AF:
							if (num == 0u)
							{
								goto IL_B5;
							}
							goto IL_C9;
						}
						
						IL_C9:
						result = num;
					}
					else
					{
						result = 0u;
					}
					return result;
				}
				IL_B5:;
			}
      return 0;
			
		}
	}
}
