using System;
using System.Collections.Generic;
namespace ns1
{
	internal static class Class138
	{
		private static HashSet<uint> hashSet_0;
		static Class138()
		{
			Class138.hashSet_0 = new HashSet<uint>();
			Class138.hashSet_0.Add(139741u);
		}
		public static bool smethod_0(uint uint_0)
		{
			return Class138.hashSet_0.Contains(uint_0);
		}
	}
}
