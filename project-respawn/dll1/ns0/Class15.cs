using D3Core;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace ns0
{
	internal sealed class Class15
	{
		[CompilerGenerated]
		private IntPtr intptr_0;
		public IntPtr Ptr
		{
			get;
			private set;
		}
		public Class15(IntPtr intptr_1)
		{
			this.Ptr = intptr_1;
		}
		public float method_0()
		{
			return Helper.ReadFloat(this.Ptr + 0);
		}
		public float method_1()
		{
			return Helper.ReadFloat(this.Ptr + 4);
		}
		public float method_2()
		{
			return Helper.ReadFloat(this.Ptr + 8);
		}
		public float method_3()
		{
			return Helper.ReadFloat(this.Ptr + 12);
		}
		public float method_4()
		{
			return Helper.ReadFloat(this.Ptr + 16);
		}
		public float method_5()
		{
			return Helper.ReadFloat(this.Ptr + 20);
		}
		public Class16.Enum1 method_6()
		{
			return (Class16.Enum1)Marshal.ReadInt16(this.Ptr, 24);
		}
	}
}
