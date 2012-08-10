using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace D3Core.Classes
{
	public sealed class NavCellContainer
	{
		[CompilerGenerated]
		private IntPtr intptr_0;
		public IntPtr Ptr
		{
			get;
			private set;
		}
		public int CellCount
		{
			get
			{
				return Marshal.ReadInt32(this.Ptr);
			}
		}
		public IntPtr FirstCell
		{
			get
			{
				return Marshal.ReadIntPtr(this.Ptr, 8);
			}
		}
		public NavCellContainer(IntPtr ptr)
		{
			this.Ptr = ptr;
		}
	}
}
