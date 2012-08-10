using System;
using System.Collections.Generic;
namespace ns1
{
	internal static class Class148
	{
		internal static T smethod_0<T>(this Random random_0, IList<T> ilist_0)
		{
			return ilist_0[random_0.Next(ilist_0.Count)];
		}
	}
}
