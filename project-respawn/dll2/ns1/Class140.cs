using System;
using System.IO;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
namespace ns1
{
	internal static class Class140
	{
		private class Class143
		{
			[CompilerGenerated]
			private NetworkStream networkStream_0;
			[CompilerGenerated]
			private int int_0;
			[CompilerGenerated]
			private byte[] byte_0;
			[CompilerGenerated]
			private Action<NetworkStream, byte[]> action_0;
			[CompilerGenerated]
			private Action<NetworkStream, Exception> action_1;
			public NetworkStream Stream
			{
				get;
				set;
			}
			public int CurrentPosition
			{
				get;
				set;
			}
			public byte[] Buffer
			{
				get;
				set;
			}
			public Action<NetworkStream, byte[]> OnSuccess
			{
				get;
				set;
			}
			public Action<NetworkStream, Exception> OnException
			{
				get;
				set;
			}
		}
		[CompilerGenerated]
		private sealed class Class141
		{
			public NetworkStream networkStream_0;
			public Action<NetworkStream> action_0;
			public void method_0(IAsyncResult iasyncResult_0)
			{
				this.networkStream_0.EndWrite(iasyncResult_0);
				this.action_0(this.networkStream_0);
			}
		}
		[CompilerGenerated]
		private sealed class Class144
		{
			public Action<NetworkStream, int> action_0;
			public void method_0(NetworkStream networkStream_0, byte[] byte_0)
			{
				this.action_0(networkStream_0, BitConverter.ToInt32(byte_0, 0));
			}
		}
		[CompilerGenerated]
		private sealed class Class145
		{
			public NetworkStream networkStream_0;
			public Action<NetworkStream, string> action_0;
			public Action<NetworkStream, Exception> action_1;
			public void method_0(NetworkStream networkStream_1, int int_0)
			{
				this.networkStream_0.smethod_0(int_0, new Action<NetworkStream, byte[]>(this.method_1), this.action_1);
			}
			public void method_1(NetworkStream networkStream_1, byte[] byte_0)
			{
				this.action_0(networkStream_1, Encoding.UTF8.GetString(byte_0));
			}
		}
		[CompilerGenerated]
		private sealed class Class142
		{
			public NetworkStream networkStream_0;
			public string string_0;
			public Action<NetworkStream> action_0;
			public Action<NetworkStream, Exception> action_1;
			public void method_0(NetworkStream networkStream_1)
			{
				this.networkStream_0.smethod_2(Encoding.UTF8.GetBytes(this.string_0), this.action_0, this.action_1);
			}
		}
		internal static void smethod_0(this NetworkStream networkStream_0, int int_0, Action<NetworkStream, byte[]> action_0, Action<NetworkStream, Exception> action_1)
		{
			if (action_0 == null || action_1 == null)
			{
				throw new Exception("Callback cannot be null");
			}
			Class140.Class143 @class = new Class140.Class143();
			@class.Buffer = new byte[int_0];
			@class.CurrentPosition = 0;
			@class.Stream = networkStream_0;
			@class.OnSuccess = action_0;
			@class.OnException = action_1;
			try
			{
				networkStream_0.BeginRead(@class.Buffer, 0, int_0, new AsyncCallback(Class140.smethod_1), @class);
			}
			catch (Exception arg)
			{
				action_1(networkStream_0, arg);
			}
		}
		private static void smethod_1(IAsyncResult iasyncResult_0)
		{
			Class140.Class143 @class = iasyncResult_0.AsyncState as Class140.Class143;
			try
			{
				int num = @class.Stream.EndRead(iasyncResult_0);
				if (num == 0)
				{
					throw new IOException("Connection closed");
				}
				@class.CurrentPosition += num;
				if (@class.CurrentPosition < @class.Buffer.Length)
				{
					@class.Stream.BeginRead(@class.Buffer, @class.CurrentPosition, @class.Buffer.Length - @class.CurrentPosition, new AsyncCallback(Class140.smethod_1), @class);
				}
				else
				{
					@class.OnSuccess(@class.Stream, @class.Buffer);
				}
			}
			catch (Exception arg)
			{
				@class.OnException(@class.Stream, arg);
			}
		}
		internal static void smethod_2(this NetworkStream networkStream_0, byte[] byte_0, Action<NetworkStream> action_0, Action<NetworkStream, Exception> action_1)
		{
			AsyncCallback asyncCallback = null;
			Class140.Class141 @class = new Class140.Class141();
			@class.networkStream_0 = networkStream_0;
			@class.action_0 = action_0;
			if (@class.action_0 == null)
			{
				throw new Exception("OnSuccess cannot be null");
			}
			if (byte_0 == null)
			{
				throw new Exception("Buffer cannot be null");
			}
			try
			{
				Stream arg_60_0 = @class.networkStream_0;
				int arg_60_2 = 0;
				int arg_60_3 = byte_0.Length;
				if (asyncCallback == null)
				{
					asyncCallback = new AsyncCallback(@class.method_0);
				}
				arg_60_0.BeginWrite(byte_0, arg_60_2, arg_60_3, asyncCallback, null);
			}
			catch (Exception arg)
			{
				action_1(@class.networkStream_0, arg);
			}
		}
		internal static void smethod_3(this NetworkStream networkStream_0, Action<NetworkStream, int> action_0, Action<NetworkStream, Exception> action_1)
		{
			Class140.Class144 @class = new Class140.Class144();
			@class.action_0 = action_0;
			networkStream_0.smethod_0(4, new Action<NetworkStream, byte[]>(@class.method_0), action_1);
		}
		internal static void smethod_4(this NetworkStream networkStream_0, Action<NetworkStream, string> action_0, Action<NetworkStream, Exception> action_1)
		{
			Class140.Class145 @class = new Class140.Class145();
			@class.networkStream_0 = networkStream_0;
			@class.action_0 = action_0;
			@class.action_1 = action_1;
			@class.networkStream_0.smethod_3(new Action<NetworkStream, int>(@class.method_0), @class.action_1);
		}
		internal static void smethod_5(this NetworkStream networkStream_0, int int_0, Action<NetworkStream> action_0, Action<NetworkStream, Exception> action_1)
		{
			networkStream_0.smethod_2(BitConverter.GetBytes(int_0), action_0, action_1);
		}
		internal static void smethod_6(this NetworkStream networkStream_0, string string_0, Action<NetworkStream> action_0, Action<NetworkStream, Exception> action_1)
		{
			Class140.Class142 @class = new Class140.Class142();
			@class.networkStream_0 = networkStream_0;
			@class.string_0 = string_0;
			@class.action_0 = action_0;
			@class.action_1 = action_1;
			@class.networkStream_0.smethod_5(@class.string_0.Length, new Action<NetworkStream>(@class.method_0), @class.action_1);
		}
	}
}
