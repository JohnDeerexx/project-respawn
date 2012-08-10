using System;
namespace ns1
{
	internal static class Class156
	{
		private static WeakReference weakReference_0 = new WeakReference(new object());
		private static long long_0 = GC.GetTotalMemory(false);
		internal static bool smethod_0(out int int_0)
		{
			bool result;
			if (!Class156.weakReference_0.IsAlive)
			{
				Class156.weakReference_0 = new WeakReference(new object());
				long totalMemory = GC.GetTotalMemory(false);
				int_0 = (int)(totalMemory - Class156.long_0);
				result = true;
			}
			else
			{
				int_0 = 0;
				result = false;
			}
			return result;
		}
	}
}
