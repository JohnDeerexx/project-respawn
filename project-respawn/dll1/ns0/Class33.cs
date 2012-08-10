using D3Core;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
namespace ns0
{
	internal static class Class33
	{
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void Delegate24(IntPtr instance);
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate int Delegate26(IntPtr instance, uint adapter, uint deviceType, IntPtr focusWindow, uint behaviorFlags, [In] ref Class33.Struct10 presentationParameters, out IntPtr returnedDeviceInterface);
		[UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Unicode, SetLastError = true)]
		public delegate int Delegate25(IntPtr device);
		private struct Struct10
		{
			public readonly uint uint_0;
			public readonly uint uint_1;
			public uint uint_2;
			public readonly uint uint_3;
			public readonly uint uint_4;
			public readonly uint uint_5;
			public uint uint_6;
			public readonly IntPtr intptr_0;
			[MarshalAs(UnmanagedType.Bool)]
			public bool bool_0;
			[MarshalAs(UnmanagedType.Bool)]
			public readonly bool bool_1;
			public readonly uint uint_7;
			public readonly uint uint_8;
			public readonly uint uint_9;
			public readonly uint uint_10;
		}
		[DllImport("d3d9.dll")]
		private static extern IntPtr Direct3DCreate9(uint uint_0);
		public static IntPtr smethod_0()
		{
			Form form = new Form();
			IntPtr intPtr = Class33.Direct3DCreate9(32u);
			if (intPtr == IntPtr.Zero)
			{
				throw new Exception("Cannot create DirectX context");
			}
			Class33.Struct10 @struct = new Class33.Struct10
			{
				bool_0 = true,
				uint_6 = 1u,
				uint_2 = 0u
			};
			Class33.Delegate26 @delegate = Helper.RegisterDelegate<Class33.Delegate26>(Helper.GetVFunc(intPtr, 16));
			IntPtr intPtr2;
			if (@delegate(intPtr, 0u, 1u, form.Handle, 32u, ref @struct, out intPtr2) < 0)
			{
				throw new Exception("Cannot create a DirectX device");
			}
			IntPtr vFunc = Helper.GetVFunc(intPtr2, 42);
			Class33.Delegate24 delegate2 = Helper.RegisterDelegate<Class33.Delegate24>(Helper.GetVFunc(intPtr2, 2));
			Class33.Delegate24 delegate3 = Helper.RegisterDelegate<Class33.Delegate24>(Helper.GetVFunc(intPtr, 2));
			delegate2(intPtr2);
			delegate3(intPtr);
			form.Dispose();
			return vFunc;
		}
	}
}
