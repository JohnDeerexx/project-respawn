using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
namespace D3Core
{
	public sealed class Hook
	{
		private IntPtr intptr_0;
		private IntPtr intptr_1;
		private IntPtr intptr_2;
		private List<byte> list_0;
		private List<byte> list_1;
		private List<byte> list_2;
		private int int_0;
		private bool bool_0 = false;
		public bool IsApplied
		{
			get
			{
				return this.bool_0;
			}
		}
		public Hook(int addressToHook, int additionalBytes, Action replacementFunction, bool ApplyNow = false)
		{
			this.int_0 = additionalBytes;
			this.intptr_0 = new IntPtr(addressToHook);
			this.intptr_1 = Marshal.GetFunctionPointerForDelegate(replacementFunction);
			this.list_1 = new List<byte>();
			this.list_1.AddRange(Helper.ReadBytes(this.intptr_0, 6 + this.int_0));
			this.intptr_2 = Hook.VirtualAlloc(0u, 32, 12288, 64);
			this.list_0 = new List<byte>();
			this.list_0.Add(104);
			this.list_0.AddRange(BitConverter.GetBytes(this.intptr_2.ToInt32()));
			this.list_0.Add(195);
			for (int i = 0; i < this.int_0; i++)
			{
				this.list_0.Add(144);
			}
			this.list_2 = new List<byte>();
			this.list_2.Add(96);
			this.list_2.Add(156);
			this.list_2.Add(232);
			this.list_2.AddRange(BitConverter.GetBytes(this.intptr_1.ToInt32() - (this.intptr_2.ToInt32() + 7)));
			this.list_2.Add(157);
			this.list_2.Add(97);
			this.list_2.AddRange(this.list_1);
			this.list_2.Add(104);
			this.list_2.AddRange(BitConverter.GetBytes(addressToHook + this.list_0.Count));
			this.list_2.Add(195);
			int flNewProtect = 0;
			Hook.VirtualProtect(this.intptr_2, this.list_2.Count, 64, ref flNewProtect);
			Helper.WriteBytes(this.intptr_2, this.list_2.ToArray());
			int num = 0;
			Hook.VirtualProtect(this.intptr_2, this.list_2.Count, flNewProtect, ref num);
			if (ApplyNow)
			{
				this.Apply();
			}
		}
		[DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
		public static extern int VirtualProtect(IntPtr lpAddress, int dwSize, int flNewProtect, ref int lpflOldProtect);
		[DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
		public static extern IntPtr VirtualAlloc(uint preferedBase, int regionSize, int allocType, int protection);
		public void Apply()
		{
			try
			{
				int flNewProtect = 0;
				Hook.VirtualProtect(this.intptr_0, this.list_0.Count, 64, ref flNewProtect);
				Helper.WriteBytes(this.intptr_0, this.list_0.ToArray());
				int num = 0;
				Hook.VirtualProtect(this.intptr_0, this.list_0.Count, flNewProtect, ref num);
				this.bool_0 = true;
			}
			catch (Exception)
			{
			}
		}
		public void Remove()
		{
			try
			{
				int flNewProtect = 0;
				Hook.VirtualProtect(this.intptr_0, 6, 64, ref flNewProtect);
				Helper.WriteBytes(this.intptr_0, this.list_1.ToArray());
				int num = 0;
				Hook.VirtualProtect(this.intptr_0, 6, flNewProtect, ref num);
				this.bool_0 = false;
			}
			catch (Exception)
			{
			}
		}
	}
}
