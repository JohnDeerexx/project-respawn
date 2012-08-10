using System;
using System.Diagnostics;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading;
namespace ns1
{
	internal static class Class92
	{
		private static DateTime dateTime_0;
		private static readonly TimeSpan timeSpan_0;
		private static readonly TimeSpan timeSpan_1;
		private static readonly TimeSpan timeSpan_2;
		[CompilerGenerated]
		private static bool bool_0;
		[CompilerGenerated]
		private static DateTime dateTime_1;
		[CompilerGenerated]
		private static DateTime dateTime_2;
		[CompilerGenerated]
		private static bool bool_1;
		public static bool FirstTimeAuthDone
		{
			get;
			private set;
		}
		public static DateTime LastAuth
		{
			get;
			private set;
		}
		public static DateTime TimeStarted
		{
			get;
			private set;
		}
		public static bool AuthenticationFaulted
		{
			get;
			private set;
		}
		static Class92()
		{
			Class92.timeSpan_0 = TimeSpan.FromSeconds(20.0);
			Class92.timeSpan_1 = TimeSpan.FromMinutes(2.0);
			Class92.timeSpan_2 = TimeSpan.FromMinutes(5.0);
			Class92.dateTime_0 = DateTime.Now;
			Class92.LastAuth = DateTime.Now;
			Class92.TimeStarted = DateTime.Now;
			Class92.AuthenticationFaulted = false;
		}
		internal static void smethod_0()
		{
			while (true)
			{
				Thread.Sleep(1000);
				if (DateTime.Now - Class92.LastAuth > Class92.timeSpan_2)
				{
					goto IL_21;
				}
				IL_03:
				if (DateTime.Now < Class92.dateTime_0)
				{
					continue;
				}
				try
				{
					Class92.smethod_1();
					continue;
				}
				catch
				{
					continue;
				}
				IL_21:
				Class92.AuthenticationFaulted = true;
				goto IL_03;
			}
		}
		private static void smethod_1()
		{
			if (!Class92.AuthenticationFaulted)
			{
				string text = Class91.smethod_2("SessionHost");
				string text2 = Class91.smethod_2("SessionPort");
				string text3 = Class91.smethod_2("SessionID");
				if (string.IsNullOrWhiteSpace(text) || string.IsNullOrWhiteSpace(text2) || string.IsNullOrWhiteSpace(text3))
				{
					Class92.AuthenticationFaulted = true;
				}
				else
				{
					text = text.Replace("\r", "").Replace("\n", "");
					text2 = text2.Replace("\r", "").Replace("\n", "");
					text3 = text3.Replace("\r", "").Replace("\n", "");
					int int_ = 0;
					if (!int.TryParse(text2, out int_))
					{
						Class92.AuthenticationFaulted = true;
					}
					else
					{
						TcpClient tcpClient = new TcpClient();
						tcpClient.ReceiveTimeout = 10000;
						tcpClient.SendTimeout = 10000;
						try
						{
							if (!tcpClient.smethod_7(text, int_, 10000))
							{
								Class92.dateTime_0 = DateTime.Now + Class92.timeSpan_0;
							}
							else
							{
								NetworkStream stream = tcpClient.GetStream();
								if (!Class92.FirstTimeAuthDone)
								{
									stream.smethod_5(0);
								}
								else
								{
									stream.smethod_5(1);
								}
								stream.smethod_3(text3);
								stream.smethod_5(Process.GetCurrentProcess().Id);
								int num = stream.smethod_4();
								if (num == 0)
								{
									Class92.AuthenticationFaulted = true;
								}
								else
								{
									if (num == 1)
									{
										Class92.FirstTimeAuthDone = true;
										Class92.LastAuth = DateTime.Now;
										Class92.dateTime_0 = DateTime.Now + Class92.timeSpan_1;
									}
								}
							}
						}
						finally
						{
							tcpClient.Close();
						}
					}
				}
			}
		}
	}
}
