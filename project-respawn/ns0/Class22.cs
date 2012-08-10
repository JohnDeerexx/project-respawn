using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml.Linq;
namespace ns0
{
	internal sealed class Class22
	{
		public enum Enum1
		{
			const_0,
			const_1,
			const_2
		}
		private static string string_0 = "http://forum.hellbuddy.com/interface/licenses.php";
		private string string_1 = "";
		private int int_0 = -1;
		private bool bool_0;
		private Dictionary<string, string> dictionary_0;
		[CompilerGenerated]
		private string string_2;
		[CompilerGenerated]
		private static Func<XElement, bool> func_0;
		public string ExtendedInformation
		{
			get;
			private set;
		}
		public Class22(string string_3)
		{
			this.string_1 = string_3;
		}
		public bool method_0()
		{
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			dictionary["key"] = this.string_1;
			try
			{
				string string_ = Class22.smethod_1(Class22.string_0, "activate", dictionary);
				Class22.smethod_0(string_, ref dictionary);
				if (!dictionary.ContainsKey("RESPONSE"))
				{
					bool result = false;
					return result;
				}
				if (dictionary["RESPONSE"] == "OKAY")
				{
					this.int_0 = int.Parse(dictionary["USAGE_ID"]);
					bool result = true;
					return result;
				}
			}
			catch
			{
				bool result = false;
				return result;
			}
			return false;
		}
		public Class22.Enum1 method_1()
		{
			if (this.int_0 == -1)
			{
				this.ExtendedInformation = "Usage ID was -1";
				return Class22.Enum1.const_2;
			}
			Class22.Enum1 result;
			try
			{
				Dictionary<string, string> dictionary = new Dictionary<string, string>();
				dictionary["key"] = this.string_1;
				dictionary["usage_id"] = this.int_0.ToString();
				string string_ = Class22.smethod_1(Class22.string_0, "check", dictionary);
				Class22.smethod_0(string_, ref dictionary);
				if (dictionary["STATUS"] == "ACTIVE")
				{
					int num = int.Parse(dictionary["USES"]);
					if (num == this.int_0)
					{
						result = Class22.Enum1.const_0;
						return result;
					}
					this.ExtendedInformation = "Key has beeen activated elsewhere";
				}
				else
				{
					this.ExtendedInformation = "Key status was not active";
				}
				result = Class22.Enum1.const_2;
			}
			catch (Exception ex)
			{
				this.ExtendedInformation = "Exception: " + ex.Message + "\n\nStackTrace: " + ex.StackTrace;
				result = Class22.Enum1.const_1;
			}
			return result;
		}
		public Dictionary<string, string> method_2()
		{
			if (this.dictionary_0 != null)
			{
				return this.dictionary_0;
			}
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			dictionary["key"] = this.string_1;
			string string_ = Class22.smethod_1(Class22.string_0, "info", dictionary);
			Class22.smethod_0(string_, ref dictionary);
			this.dictionary_0 = dictionary;
			return this.dictionary_0;
		}
		public string method_3()
		{
			Dictionary<string, string> dictionary = this.method_2();
			string result = "";
			dictionary.TryGetValue("purchase_name", out result);
			return result;
		}
		private static void smethod_0(string string_3, ref Dictionary<string, string> dictionary_1)
		{
			XDocument xDocument = null;
			try
			{
				xDocument = XDocument.Parse(string_3);
			}
			catch
			{
				dictionary_1 = null;
				return;
			}
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			string text = null;
			IEnumerable<XElement> arg_3F_0 = xDocument.Descendants();
			if (Class22.func_0 == null)
			{
				Class22.func_0 = new Func<XElement, bool>(Class22.smethod_2);
			}
			foreach (XElement current in arg_3F_0.Where(Class22.func_0))
			{
				int num = 0;
				string key = current.Name.LocalName;
				while (dictionary.ContainsKey(key))
				{
					key = current.Name.LocalName + "_" + num++;
				}
				if (text == null)
				{
					text = current.Value;
				}
				else
				{
					dictionary.Add(text, current.Value);
					text = null;
				}
			}
			dictionary_1 = dictionary;
		}
		private static string smethod_1(string string_3, string string_4, Dictionary<string, string> dictionary_1)
		{
			StringBuilder stringBuilder = new StringBuilder(1000);
			stringBuilder.AppendLine("<?xml version=\"1.0\" encoding=\"UTF-8\" ?>");
			stringBuilder.AppendLine("<methodCall>");
			stringBuilder.AppendLine("<methodName>" + string_4 + "</methodName>");
			stringBuilder.AppendLine("<params>");
			stringBuilder.AppendLine("<param>");
			stringBuilder.AppendLine("<value>");
			stringBuilder.AppendLine("<struct>");
			foreach (KeyValuePair<string, string> current in dictionary_1)
			{
				stringBuilder.AppendLine("<member>");
				stringBuilder.AppendLine("<name>" + current.Key + "</name>");
				stringBuilder.AppendFormat("<value><string>" + current.Value + "</string></value>", new object[0]);
				stringBuilder.AppendLine("</member>");
			}
			stringBuilder.AppendLine("</struct>");
			stringBuilder.AppendLine("</value>");
			stringBuilder.AppendLine("</param>");
			stringBuilder.AppendLine("</params>");
			stringBuilder.AppendLine("</methodCall>");
			string s = stringBuilder.ToString();
			string result = null;
			string result2;
			try
			{
				WebRequest webRequest = WebRequest.Create(string_3);
				webRequest.Method = "POST";
				webRequest.ContentType = "text/xml";
				byte[] bytes = Encoding.UTF8.GetBytes(s);
				webRequest.ContentLength = (long)bytes.Length;
				webRequest.GetRequestStream().Write(bytes, 0, bytes.Length);
				using (HttpWebResponse httpWebResponse = (HttpWebResponse)webRequest.GetResponse())
				{
					using (Stream responseStream = httpWebResponse.GetResponseStream())
					{
						using (StreamReader streamReader = new StreamReader(responseStream, Encoding.ASCII))
						{
							result = streamReader.ReadToEnd();
						}
					}
				}
				return result;
			}
			catch
			{
				result2 = "";
			}
			return result2;
		}
		[CompilerGenerated]
		private static bool smethod_2(XElement xelement_0)
		{
			return !xelement_0.HasElements;
		}
	}
}
