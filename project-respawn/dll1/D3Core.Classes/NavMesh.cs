using D3Core.Classes.Navigation;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
namespace D3Core.Classes
{
	public sealed class NavMesh
	{
		[CompilerGenerated]
		private IntPtr intptr_0;
		public IntPtr Ptr
		{
			get;
			private set;
		}
		public NavZone NavZone
		{
			get
			{
				IntPtr intPtr = Marshal.ReadIntPtr(new IntPtr(22855608));
				if (intPtr == IntPtr.Zero)
				{
					MessageBox.Show("Some pointer is invalid! Update!");
					throw new Exception("Pointer out of date!");
				}
				IntPtr ptr = Navi.GetNavZone(intPtr, Marshal.ReadIntPtr(this.Ptr, 8), 0);
				return new NavZone(ptr);
			}
		}
		public NavMesh(IntPtr ptr)
		{
			this.Ptr = ptr;
		}
	}
}
