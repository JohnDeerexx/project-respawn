using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
namespace ns1
{
	internal static class Class104
	{
		private static readonly char[] char_0 = new char[]
		{
			';'
		};
		[CompilerGenerated]
		private static Func<char, bool> func_0;
		public static void smethod_0(string string_0, int int_0, Action<string[]> action_0)
		{
			List<string> list = File.ReadAllLines(string_0).ToList<string>();
			if (int_0 < 2)
			{
				throw new Exception("A CSV file must contain at least 2 columns");
			}
			foreach (string current in list)
			{
				if (current.Length >= 3 && !current.StartsWith("//"))
				{
					IEnumerable<char> arg_6E_0 = current;
					if (Class104.func_0 == null)
					{
						Class104.func_0 = new Func<char, bool>(Class104.smethod_1);
					}
					if (arg_6E_0.Count(Class104.func_0) == int_0 - 1)
					{
						string[] array = current.Split(Class104.char_0, StringSplitOptions.None);
						if (array.Length != int_0)
						{
							throw new Exception("CSV Parser: Internal error, the CSV file is corrupted...");
						}
						try
						{
							action_0(array);
						}
						catch
						{
						}
					}
				}
			}
		}
		[CompilerGenerated]
		private static bool smethod_1(char char_1)
		{
			return char_1 == ';';
		}
	}
}
