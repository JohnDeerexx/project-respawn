using System;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Security.Cryptography;
using System.Threading;
namespace ns1
{
	internal class Class157
	{
		private static MemoryStream memoryStream_0;
		private static MemoryStream memoryStream_1;
		private static object object_0;
		private static int int_0;
		private static int int_1;
		static Class157()
		{
			Class157.int_0 = 2147483647;
			Class157.int_1 = -2147483648;
			Class157.memoryStream_0 = null;
			Class157.memoryStream_1 = null;
			Class157.object_0 = new object();
		}
		private static string smethod_0(Assembly assembly_0)
		{
			string text = assembly_0.FullName;
			int num = text.IndexOf(',');
			if (num >= 0)
			{
				text = text.Substring(0, num);
			}
			return text;
		}
		private static byte[] smethod_1(Assembly assembly_0)
		{
			try
			{
				string fullName = assembly_0.FullName;
				int num = fullName.IndexOf("PublicKeyToken=");
				if (num < 0)
				{
					num = fullName.IndexOf("publickeytoken=");
				}
				byte[] result;
				if (num < 0)
				{
					result = null;
					return result;
				}
				num += 15;
				if (fullName[num] != 'n')
				{
					if (fullName[num] != 'N')
					{
						string s = fullName.Substring(num, 16);
						long value = long.Parse(s, NumberStyles.HexNumber);
						byte[] bytes = BitConverter.GetBytes(value);
						Array.Reverse(bytes);
						result = bytes;
						return result;
					}
				}
				result = null;
				return result;
			}
			catch
			{
			}
			return null;
		}
		internal static byte[] smethod_2(Stream stream_0)
		{
			object obj;
			Monitor.Enter(obj = Class157.object_0);
			byte[] result;
			try
			{
				Stream stream = stream_0;
				MemoryStream memoryStream = null;
				byte b = (byte)stream_0.ReadByte();
				if ((b & 1) != 0)
				{
					DESCryptoServiceProvider dESCryptoServiceProvider = new DESCryptoServiceProvider();
					byte[] array = new byte[8];
					stream_0.Read(array, 0, 8);
					dESCryptoServiceProvider.IV = array;
					byte[] array2 = new byte[8];
					stream_0.Read(array2, 0, 8);
					bool flag = true;
					byte[] array3 = array2;
					for (int i = 0; i < array3.Length; i++)
					{
						if (array3[i] != 0)
						{
							flag = false;
							IL_7F:
							if (flag)
							{
								array2 = Class157.smethod_1(Assembly.GetExecutingAssembly());
							}
							dESCryptoServiceProvider.Key = array2;
							if (Class157.memoryStream_0 == null)
							{
								if (Class157.int_0 == 2147483647)
								{
									Class157.memoryStream_0 = new MemoryStream((int)stream_0.Length);
								}
								else
								{
									Class157.memoryStream_0 = new MemoryStream(Class157.int_0);
								}
							}
							Class157.memoryStream_0.Position = 0L;
							ICryptoTransform cryptoTransform = dESCryptoServiceProvider.CreateDecryptor();
							int inputBlockSize = cryptoTransform.InputBlockSize;
							int arg_F0_0 = cryptoTransform.OutputBlockSize;
							byte[] array4 = new byte[cryptoTransform.OutputBlockSize];
							byte[] array5 = new byte[cryptoTransform.InputBlockSize];
							int num = (int)stream_0.Position;
							while ((long)(num + inputBlockSize) < stream_0.Length)
							{
								stream_0.Read(array5, 0, inputBlockSize);
								int count = cryptoTransform.TransformBlock(array5, 0, inputBlockSize, array4, 0);
								Class157.memoryStream_0.Write(array4, 0, count);
								num += inputBlockSize;
							}
							stream_0.Read(array5, 0, (int)(stream_0.Length - (long)num));
							byte[] array6 = cryptoTransform.TransformFinalBlock(array5, 0, (int)(stream_0.Length - (long)num));
							Class157.memoryStream_0.Write(array6, 0, array6.Length);
							stream = Class157.memoryStream_0;
							stream.Position = 0L;
							memoryStream = Class157.memoryStream_0;
							goto IL_1AA;
						}
					}
					
				}
				IL_1AA:
				if ((b & 2) != 0)
				{
					try
					{
						if (Class157.memoryStream_1 == null)
						{
							if (Class157.int_1 == -2147483648)
							{
								Class157.memoryStream_1 = new MemoryStream((int)stream.Length * 2);
							}
							else
							{
								Class157.memoryStream_1 = new MemoryStream(Class157.int_1);
							}
						}
						Class157.memoryStream_1.Position = 0L;
						DeflateStream deflateStream = new DeflateStream(stream, CompressionMode.Decompress);
						int num2 = 1000;
						byte[] buffer = new byte[1000];
						int num3;
						do
						{
							num3 = deflateStream.Read(buffer, 0, num2);
							if (num3 > 0)
							{
								Class157.memoryStream_1.Write(buffer, 0, num3);
							}
						}
						while (num3 >= num2);
						memoryStream = Class157.memoryStream_1;
					}
					catch (Exception)
					{
					}
				}
				if (memoryStream != null)
				{
					result = memoryStream.ToArray();
				}
				else
				{
					byte[] array7 = new byte[stream_0.Length - stream_0.Position];
					stream_0.Read(array7, 0, array7.Length);
					result = array7;
				}
			}
			finally
			{
				Monitor.Exit(obj);
			}
			return result;
		}
	}
}
