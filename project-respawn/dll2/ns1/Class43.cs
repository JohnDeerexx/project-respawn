using System;
namespace ns1
{
	internal static class Class43
	{
		public static string smethod_0(this string string_0, object object_0)
		{
			return string.Format(string_0, object_0);
		}
		public static string smethod_1(this string string_0, object object_0, object object_1)
		{
			return string.Format(string_0, object_0, object_1);
		}
		public static string smethod_2(this string string_0, object object_0, object object_1, object object_2)
		{
			return string.Format(string_0, object_0, object_1, object_2);
		}
		public static string smethod_3(this string string_0, params object[] object_0)
		{
			return string.Format(string_0, object_0);
		}
		public static string smethod_4(this string string_0, int int_0, int int_1)
		{
			string result;
			if (int_1 < int_0)
			{
				result = string.Empty;
			}
			else
			{
				result = string_0.Substring(int_0, int_1 - int_0);
			}
			return result;
		}
		public static int smethod_5(this string string_0, string string_1)
		{
			int num = 0;
			int num2 = 0;
			while ((num2 = string_0.IndexOf(string_1, num2)) != -1)
			{
				num2 += string_1.Length;
				num++;
			}
			return num;
		}
		public static int smethod_6(this string string_0, string string_1, int int_0)
		{
			if (int_0 <= 0)
			{
				throw new Exception("Cannot find a \"0th\" occurence, nTh must be > 0");
			}
			int num = 0;
			int result;
			for (int i = 0; i < int_0; i++)
			{
				num = string_0.IndexOf(string_1, num);
				if (num == -1)
				{
					result = -1;
					return result;
				}
				num++;
			}
			result = num;
			return result;
		}
	}
}
