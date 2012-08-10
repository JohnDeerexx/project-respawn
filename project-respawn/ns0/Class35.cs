using System;
using System.IO;
namespace ns0
{
	internal static class Class35
	{
		internal static float smethod_0(this Random random_0, float float_0, float float_1)
		{
			double num = (double)(float_1 - float_0);
			double num2 = random_0.NextDouble() * num;
			return (float)((double)float_0 + num2);
		}
		internal static bool smethod_1(this int int_0, int int_1, int int_2)
		{
			return int_0 <= int_2 && int_0 >= int_1;
		}
		internal static bool smethod_2(this int int_0, int int_1, int int_2)
		{
			return int_0 < int_2 && int_0 > int_1;
		}
		internal static bool smethod_3(this float float_0, float float_1, float float_2)
		{
			return float_0 <= float_2 && float_0 >= float_1;
		}
		internal static bool smethod_4(this float float_0, float float_1, float float_2)
		{
			return float_0 < float_2 && float_0 > float_1;
		}
		internal static float smethod_5(this float float_0, float float_1, float float_2)
		{
			if (float_0 < float_1)
			{
				float_0 = float_1;
			}
			if (float_0 > float_2)
			{
				float_0 = float_2;
			}
			return float_0;
		}
		internal static float smethod_6(this Random random_0, float float_0, float float_1)
		{
			double num = (double)random_0.smethod_0(-float_1, float_1);
			float_0 += (float)num;
			return float_0;
		}
		internal static bool smethod_7(this string string_0)
		{
			bool result = false;
			try
			{
				new FileInfo(string_0);
				result = true;
			}
			catch (ArgumentNullException)
			{
			}
			catch (ArgumentException)
			{
			}
			catch (PathTooLongException)
			{
			}
			catch (NotSupportedException)
			{
			}
			return result;
		}
	}
}
