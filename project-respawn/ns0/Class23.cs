using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
namespace ns0
{
	[DefaultMember("Item")]
	internal sealed class Class23
	{
		private static Class23 class23_0;
		private Dictionary<string, string> dictionary_0;
		private Class23()
		{
		}
		public static Class23 smethod_0()
		{
			if (Class23.class23_0 == null)
			{
				Class23.class23_0 = new Class23();
			}
			return Class23.class23_0;
		}
		public void method_0(string string_0)
		{
			string[] array = File.ReadAllLines(string_0);
			string[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				string text = array2[i];
				if (!text.StartsWith("//") && !text.StartsWith("#"))
				{
					string text2 = text.Replace("\\n", "\r\n");
					int num = text2.IndexOf('=');
					if (num != -1)
					{
						string key = text2.Substring(0, num).Trim();
						string value = text2.smethod_4(num + 1, text2.Length);
						this.dictionary_0[key] = value;
					}
				}
			}
		}
		public string method_1(string string_0)
		{
			string result = null;
			if (this.dictionary_0.TryGetValue(string_0.ToLower(), out result))
			{
				return result;
			}
			return "<MISSING TRANSLATION>";
		}
	}
}
