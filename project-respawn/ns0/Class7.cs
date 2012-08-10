using System;
using System.IO;
using System.Security.Cryptography;
namespace ns0
{
	internal sealed class Class7
	{
		public static string smethod_0(string string_0)
		{
			FileStream fileStream = File.OpenRead(string_0);
			string result;
			try
			{
				MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
				byte[] value = mD5CryptoServiceProvider.ComputeHash(fileStream);
				string text = BitConverter.ToString(value).Replace("-", "");
				result = text;
			}
			finally
			{
				fileStream.Close();
			}
			return result;
		}
	}
}
