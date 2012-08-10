using System;
namespace ns1
{
	internal static class Class146
	{
		public static bool smethod_0(this DateTime dateTime_0)
		{
			return DateTime.Now < dateTime_0;
		}
		public static bool smethod_1(this DateTime dateTime_0)
		{
			return dateTime_0 < DateTime.Now;
		}
		public static bool smethod_2(this DateTime dateTime_0, DateTime dateTime_1, DateTime dateTime_2)
		{
			return !(dateTime_0 < dateTime_1) && !(dateTime_0 > dateTime_2);
		}
	}
}
