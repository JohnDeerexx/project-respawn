using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
namespace ns1
{
	internal sealed class Class60
	{
		internal sealed class Class59
		{
			[CompilerGenerated]
			private string string_0;
			[CompilerGenerated]
			private DateTime dateTime_0;
			[CompilerGenerated]
			private bool bool_0;
			public string Text
			{
				get;
				private set;
			}
			public DateTime Time
			{
				get;
				private set;
			}
			public bool IsError
			{
				get;
				private set;
			}
			public Class59(string string_1, bool bool_1)
			{
				this.Text = string_1;
				this.Time = DateTime.Now;
				this.IsError = bool_1;
			}
			public override string ToString()
			{
				return this.Time.ToString("HH:mm:ss") + ": {0} {1}".smethod_1(this.IsError ? "[ERROR]" : "", this.Text);
			}
		}
		private List<Class60.Class59> list_0 = new List<Class60.Class59>();
		private StreamWriter streamWriter_0;
		private void method_0()
		{
			try
			{
				if (this.streamWriter_0 == null || !this.streamWriter_0.BaseStream.CanWrite)
				{
					string path = Path.Combine(Path.GetTempPath(), "HellBuddy");
					string text = "DebugAndErrorLog_";
					foreach (string current in Directory.EnumerateFiles(".", text + "*.txt", SearchOption.TopDirectoryOnly))
					{
						try
						{
							if (current.StartsWith(text))
							{
								TimeSpan t = DateTime.Now - new FileInfo(current).CreationTime;
								if (t > TimeSpan.FromDays(7.0))
								{
									File.Delete(current);
								}
							}
						}
						catch
						{
						}
					}
					DateTime now = DateTime.Now;
					string str = "{0}.{1}.{2}.{3}.txt".smethod_3(new object[]
					{
						now.Hour,
						now.Minute,
						now.Second,
						now.Millisecond
					});
					string path2 = Path.Combine(path, text + str);
					FileStream stream = new FileStream(path2, FileMode.Create, FileAccess.Write);
					this.streamWriter_0 = new StreamWriter(stream);
					this.streamWriter_0.AutoFlush = true;
					this.streamWriter_0.WriteLine("=== THIS FILE WILL BE DELETED AUTOMATICALLY AFTER 7 DAYS ===");
				}
			}
			catch
			{
			}
		}
		private static string smethod_0()
		{
			DateTime now = DateTime.Now;
			return string.Format("{0:00}:{1:00}:{2:00}.{3:000}: ", new object[]
			{
				now.Hour,
				now.Minute,
				now.Second,
				now.Millisecond
			});
		}
		internal void method_1(string string_0)
		{
			bool flag = false;
			try
			{
				Monitor.Enter(this, ref flag);
				if (this.streamWriter_0 == null)
				{
					this.method_0();
				}
				Class60.Class59 @class = new Class60.Class59(string_0, true);
				if (this.streamWriter_0 != null)
				{
					this.streamWriter_0.WriteLine(Class60.smethod_0() + @class.Text);
				}
				this.list_0.Add(@class);
			}
			finally
			{
				if (flag)
				{
					Monitor.Exit(this);
				}
			}
		}
		internal void method_2(string string_0)
		{
			bool flag = false;
			try
			{
				Monitor.Enter(this, ref flag);
				if (this.streamWriter_0 == null)
				{
					this.method_0();
				}
				Class60.Class59 @class = new Class60.Class59(string_0, false);
				if (this.streamWriter_0 != null)
				{
					this.streamWriter_0.WriteLine(Class60.smethod_0() + @class.ToString());
				}
				this.list_0.Add(@class);
			}
			finally
			{
				if (flag)
				{
					Monitor.Exit(this);
				}
			}
		}
		internal ReadOnlyCollection<Class60.Class59> method_3()
		{
			bool flag = false;
			ReadOnlyCollection<Class60.Class59> result;
			try
			{
				Monitor.Enter(this, ref flag);
				result = this.list_0.AsReadOnly();
			}
			finally
			{
				if (flag)
				{
					Monitor.Exit(this);
				}
			}
			return result;
		}
	}
}
