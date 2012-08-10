using System;
using System.Collections.Generic;
namespace ns0
{
	internal static class Class31
	{
		private static HashSet<uint> hashSet_0;
		static Class31()
		{
			Class31.hashSet_0 = new HashSet<uint>();
			Class31.hashSet_0.Add(186130u);
			Class31.hashSet_0.Add(4675u);
			Class31.hashSet_0.Add(85816u);
			Class31.hashSet_0.Add(191239u);
			Class31.hashSet_0.Add(3440u);
			Class31.hashSet_0.Add(4433u);
			Class31.hashSet_0.Add(4434u);
			Class31.hashSet_0.Add(3441u);
			Class31.hashSet_0.Add(361u);
			Class31.hashSet_0.Add(5502u);
			Class31.hashSet_0.Add(5466u);
			Class31.hashSet_0.Add(174900u);
			Class31.hashSet_0.Add(59822u);
			Class31.hashSet_0.Add(72582u);
			Class31.hashSet_0.Add(108012u);
			Class31.hashSet_0.Add(89578u);
			Class31.hashSet_0.Add(4768u);
			Class31.hashSet_0.Add(135083u);
		}
		internal static bool smethod_0(uint uint_0)
		{
			return Class31.hashSet_0.Contains(uint_0);
		}
	}
}
