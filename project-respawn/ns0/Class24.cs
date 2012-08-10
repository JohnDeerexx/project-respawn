using System;
namespace ns0
{
	internal static class Class24
	{
		public static int smethod_0(this int int_0, int int_1)
		{
			if (int_0 < int_1)
			{
				return int_1;
			}
			return int_0;
		}
		public static int smethod_1(this int int_0, int int_1)
		{
			if (int_0 > int_1)
			{
				return int_1;
			}
			return int_0;
		}
		public static int smethod_2(this int int_0, int int_1, int int_2)
		{
			if (int_0 < int_1)
			{
				return int_1;
			}
			if (int_0 > int_2)
			{
				return int_2;
			}
			return int_0;
		}
	}
}
