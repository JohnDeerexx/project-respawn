using System;
namespace ns0
{
	internal static class Class44
	{
		private static WeakReference weakReference_0 = new WeakReference(new object());
		private static long long_0 = GC.GetTotalMemory(false);
		internal static bool smethod_0(out int int_0)
		{
			if (!Class44.weakReference_0.IsAlive)
			{
				Class44.weakReference_0 = new WeakReference(new object());
				long totalMemory = GC.GetTotalMemory(false);
				int_0 = (int)(totalMemory - Class44.long_0);
				return true;
			}
			int_0 = 0;
			return false;
		}
	}
}
