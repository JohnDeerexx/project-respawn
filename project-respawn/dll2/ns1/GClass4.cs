using System;
using System.Runtime.InteropServices;
namespace ns1
{
	public static class GClass4
	{
		internal static T smethod_0<T>(uint uint_0) where T : class
		{
			return Marshal.GetDelegateForFunctionPointer(new IntPtr((long)((ulong)uint_0)), typeof(T)) as T;
		}
		internal static uint smethod_1(uint uint_0)
		{
			return (uint)Marshal.ReadInt32(new IntPtr((long)((ulong)uint_0)));
		}
		internal static uint smethod_2(uint uint_0)
		{
			return (uint)Marshal.ReadInt16(new IntPtr((long)((ulong)uint_0)));
		}
	}
}
