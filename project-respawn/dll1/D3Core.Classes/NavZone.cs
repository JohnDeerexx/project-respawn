using System;
using System.Runtime.CompilerServices;
namespace D3Core.Classes
{
	public sealed class NavZone
	{
		[CompilerGenerated]
		private IntPtr intptr_0;
		public IntPtr Ptr
		{
			get;
			private set;
		}
		public NavCellContainer NavCellContainer
		{
			get
			{
				return new NavCellContainer(this.Ptr + 640);
			}
		}
		public NavZone(IntPtr ptr)
		{
			this.Ptr = ptr;
		}
	}
}
