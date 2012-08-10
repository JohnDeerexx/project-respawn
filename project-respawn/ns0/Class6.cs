using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
namespace ns0
{
	internal static class Class6
	{
		public static byte[] smethod_0(this NetworkStream networkStream_0, int int_0)
		{
			byte[] array = new byte[int_0];
			for (int i = 0; i < int_0; i += networkStream_0.Read(array, i, int_0 - i))
			{
			}
			return array;
		}
		public static void smethod_1(this NetworkStream networkStream_0, int int_0, Action<int, int, byte[], int> action_0, int int_1 = 100)
		{
			byte[] array = new byte[int_1];
			int i = 0;
			while (i < int_0)
			{
				int num = networkStream_0.Read(array, 0, int_1);
				i += num;
				action_0(i, int_0, array, num);
			}
		}
		public static string smethod_2(this NetworkStream networkStream_0)
		{
			int num = networkStream_0.smethod_4();
			byte[] bytes = networkStream_0.smethod_0(num);
			return Encoding.Unicode.GetString(bytes, 0, num);
		}
		public static void smethod_3(this NetworkStream networkStream_0, string string_0)
		{
			byte[] bytes = Encoding.Unicode.GetBytes(string_0);
			networkStream_0.smethod_5(bytes.Length);
			networkStream_0.Write(bytes, 0, bytes.Length);
		}
		public static int smethod_4(this NetworkStream networkStream_0)
		{
			byte[] value = networkStream_0.smethod_0(4);
			return BitConverter.ToInt32(value, 0);
		}
		public static void smethod_5(this NetworkStream networkStream_0, int int_0)
		{
			byte[] bytes = BitConverter.GetBytes(int_0);
			networkStream_0.Write(bytes, 0, 4);
		}
		public static void smethod_6(this NetworkStream networkStream_0, byte[] byte_0)
		{
			networkStream_0.Write(byte_0, 0, byte_0.Length);
		}
		public static bool smethod_7(this TcpClient tcpClient_0, string string_0, int int_0, int int_1)
		{
			IAsyncResult asyncResult = tcpClient_0.BeginConnect(string_0, int_0, null, null);
			WaitHandle asyncWaitHandle = asyncResult.AsyncWaitHandle;
			bool result;
			try
			{
				if (asyncWaitHandle.WaitOne(int_1))
				{
					tcpClient_0.EndConnect(asyncResult);
					result = true;
				}
				else
				{
					tcpClient_0.Close();
					result = false;
				}
			}
			catch (SocketException)
			{
				result = false;
			}
			finally
			{
				asyncWaitHandle.Close();
			}
			return result;
		}
		public static string smethod_8(this TcpClient tcpClient_0)
		{
			return ((IPEndPoint)tcpClient_0.Client.RemoteEndPoint).Address.ToString();
		}
	}
}
