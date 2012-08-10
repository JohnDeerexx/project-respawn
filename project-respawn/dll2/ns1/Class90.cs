using D3Core;
using HellBuddy;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ns1
{
	internal class Class90
	{
		private bool bool_0 = false;
		private string string_0 = "";
		private string string_1 = "";
		private Thread thread_0;
		private Form form_0 = null;
		private object object_0 = new object();
		[CompilerGenerated]
		private static EventHandler<EventArgs<string>> eventHandler_0;
		[CompilerGenerated]
		private static Action<Task> action_0;
		[CompilerGenerated]
		private static Action action_1;
		internal Class90()
		{
			Framework.Pulse += new EventHandler(this.method_0);
			if (Class90.eventHandler_0 == null)
			{
				Class90.eventHandler_0 = new EventHandler<EventArgs<string>>(Class90.smethod_0);
			}
			Framework.FileLog += Class90.eventHandler_0;
			ContainerA.AddToFileLog("initialize core now...");
			Framework.Initialize();
			ContainerA.AddToFileLog("core is initialized");
			this.method_1();
		}
		private void method_0(object sender, EventArgs e)
		{
			GClass0.smethod_0().method_13();
			if (this.string_0 != GClass0.CurrentStateName || this.string_1 != GClass0.CurrentStateTarget)
			{
				this.string_0 = GClass0.CurrentStateName;
				this.string_1 = GClass0.CurrentStateTarget;
				GClass0.smethod_0().method_5("Doing: " + this.string_0);
				GClass0.smethod_0().method_5("Taget: " + this.string_1);
			}
			if (Class92.AuthenticationFaulted && !this.bool_0)
			{
				this.bool_0 = true;
			}
		}
		internal void method_1()
		{
			ThreadStart threadStart = null;
			lock (this.object_0)
			{
				if (this.form_0 == null)
				{
					if (threadStart == null)
					{
						threadStart = new ThreadStart(this.method_2);
					}
					this.thread_0 = new Thread(threadStart);
					Task task = new Task(new Action(Class92.smethod_0), TaskCreationOptions.LongRunning);
					Task arg_6F_0 = task;
					if (Class90.action_0 == null)
					{
						Class90.action_0 = new Action<Task>(Class90.smethod_1);
					}
					arg_6F_0.ContinueWith(Class90.action_0, TaskContinuationOptions.None);
					task.Start();
					this.thread_0.IsBackground = true;
					this.thread_0.Start();
				}
			}
		}
		[CompilerGenerated]
		private static void smethod_0(object sender, EventArgs<string> e)
		{
			ContainerA.AddToFileLog(e.Value);
		}
		[CompilerGenerated]
		private void method_2()
		{
			ContainerA.AddToFileLog("Creating UI");
			this.form_0 = new InjectedWindow();
			ContainerA.AddToFileLog("Showing UI");
			this.form_0.ShowDialog();
		}
		[CompilerGenerated]
		private static void smethod_1(Task task_0)
		{
			Random random = new Random(Environment.TickCount);
			Thread.Sleep(10000 + random.Next(10000));
			TaskFactory arg_43_0 = Task.Factory;
			if (Class90.action_1 == null)
			{
				Class90.action_1 = new Action(Class90.smethod_2);
			}
			arg_43_0.StartNew(Class90.action_1);
			Thread.Sleep(25000 + random.Next(25000));
			Process.GetCurrentProcess().Kill();
		}
		[CompilerGenerated]
		private static void smethod_2()
		{
			MessageBox.Show("Internal error...", "Diablo III", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}
	}
}
