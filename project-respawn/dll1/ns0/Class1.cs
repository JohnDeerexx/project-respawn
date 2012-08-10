using System;
namespace ns0
{
	internal static class Class1
	{
		public static int smethod_0(this int int_0, int int_1, int int_2)
		{
			int result;
			if (int_0 < int_1)
			{
				result = int_1;
			}
			else
			{
				if (int_0 > int_2)
				{
					result = int_2;
				}
				else
				{
					result = int_0;
				}
			}
			return result;
		}
	}
}
