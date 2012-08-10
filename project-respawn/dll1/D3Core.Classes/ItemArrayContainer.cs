using System;
using System.Runtime.InteropServices;
namespace D3Core.Classes
{
	public sealed class ItemArrayContainer
	{
		public IntPtr Ptr;
		public int ItemCount
		{
			get
			{
				return Marshal.ReadInt32(this.Ptr, 8);
			}
		}
		public ItemArrayContainer(IntPtr ptr)
		{
			this.Ptr = ptr;
		}
	}
}
