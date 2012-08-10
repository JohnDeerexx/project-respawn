using D3Core;
using D3Core.Classes;
using HellBuddy;
using HellBuddy.Core;
using HellBuddy.Scripting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ns1
{
	public class GClass0
	{
		private class Class56
		{
			[CompilerGenerated]
			private string string_0;
			[CompilerGenerated]
			private bool bool_0;
			[CompilerGenerated]
			private int int_0;
			[CompilerGenerated]
			private float float_0;
			public string World
			{
				get;
				set;
			}
			public bool ResetOnWorldChange
			{
				get;
				set;
			}
			public int EndTick
			{
				get;
				set;
			}
			public float Radius
			{
				get;
				set;
			}
		}
		[CompilerGenerated]
		private sealed class Class62
		{
			public GClass0 gclass0_0;
			public string string_0;
			private static Action action_0;
			public void method_0()
			{
				while (Framework.IsIngame)
				{
					this.gclass0_0.method_5("Logging out...");
					if (GClass0.Class62.action_0 == null)
					{
						GClass0.Class62.action_0 = new Action(GClass0.Class62.smethod_0);
					}
					Framework.RunInD3ContextSynced(GClass0.Class62.action_0);
					if (GClass0.bool_3)
					{
						this.gclass0_0.method_5("Aborting quest change");
						GClass0.bool_4 = false;
						return;
					}
					Thread.Sleep(3000);
				}
				this.gclass0_0.method_5("Logged out!");
				Thread.Sleep(1500);
				if (GClass0.bool_3)
				{
					this.gclass0_0.method_5("Aborting quest change");
					GClass0.bool_4 = false;
					return;
				}
				Script script = Script.LoadFromFile(this.string_0);
				bool flag = false;
				DateTime now = DateTime.Now;
				while (!Framework.IsIngame)
				{
					if (DateTime.Now - now > TimeSpan.FromSeconds(30.0))
					{
						for (int i = 0; i < 5; i++)
						{
							InjectedWindow.Instance.method_16("Cannot create a new game!! Exiting...");
						}
						Thread.Sleep(2000);
						Process.GetCurrentProcess().Kill();
					}
					if (GClass0.bool_3)
					{
						GClass0.bool_4 = false;
						return;
					}
					if (!flag)
					{
						flag = true;
						this.gclass0_0.method_5("Starting new game...");
						D3CharSelect.Logon_StartNew(script.AssociatedStartQuest, script.QuestStep1, script.QuestStep2);
					}
					Thread.Sleep(5000);
				}
				this.gclass0_0.method_11(script);
				GClass0.bool_4 = false;
			}
			private static void smethod_0()
			{
				if (Framework.IsIngame)
				{
					Framework.LeaveGame();
				}
			}
		}
		private static GClass0 gclass0_0;
		private Action<string> action_0;
		private Action<string> action_1;
		internal Class60 class60_0;
		internal List<Class44> list_0;
		internal List<Class94> list_1;
		private Action<Script, Script> action_2;
		private bool bool_0 = false;
		private Script script_0 = null;
		internal Class46 class46_0 = null;
		internal List<Class57> list_2 = new List<Class57>();
		private List<Class57> list_3 = new List<Class57>();
		private Stack<Class57> stack_0 = new Stack<Class57>();
		private float float_0 = 40f;
		private GClass0.Class56 class56_0;
		internal bool bool_1 = false;
		internal float float_1 = 18f;
		internal float float_2 = 90f;
		private bool bool_2 = false;
		private object object_0 = null;
		private int int_0 = 0;
		private int int_1 = 0;
		private int int_2 = 0;
		internal static bool bool_3 = false;
		internal static bool bool_4 = false;
		[CompilerGenerated]
		private bool bool_5;
		[CompilerGenerated]
		private Thread thread_0;
		[CompilerGenerated]
		private static string string_0;
		[CompilerGenerated]
		private static string string_1;
		[CompilerGenerated]
		private static ThreadStart threadStart_0;
		[CompilerGenerated]
		private static Func<Class44, int> func_0;
		internal bool GotoTown
		{
			get;
			set;
		}
		public Thread AuthenticationThread
		{
			get;
			private set;
		}
		internal static string CurrentStateName
		{
			get;
			private set;
		}
		internal static string CurrentStateTarget
		{
			get;
			private set;
		}
		private GClass0()
		{
			this.list_0 = new List<Class44>();
			this.list_0.Add(new Class45());
			this.list_0.Add(new Class48());
			this.list_0.Add(new Class51());
			this.list_0.Add(new Class50());
			this.list_0.Add(new Class49());
			this.list_0.Add(new Class54());
			this.list_0.Add(new Class53());
			this.list_0.Add(new Class52());
			this.list_0.Add(new Class47());
			this.list_1 = new List<Class94>();
			this.list_2.Add(new Class58());
			this.method_11(null);
			this.class60_0 = new Class60();
			Action<string> action_ = new Action<string>(this.method_19);
			this.method_0(action_);
			Action<string> action_2 = new Action<string>(this.method_20);
			this.method_2(action_2);
			GClass0.CurrentStateName = "";
			GClass0.CurrentStateTarget = "";
		}
		public static GClass0 smethod_0()
		{
			if (GClass0.gclass0_0 == null)
			{
				GClass0.gclass0_0 = new GClass0();
			}
			return GClass0.gclass0_0;
		}
		public void method_0(Action<string> action_3)
		{
			Action<string> action = this.action_0;
			Action<string> action2;
			do
			{
				action2 = action;
				Action<string> value = (Action<string>)Delegate.Combine(action2, action_3);
				action = Interlocked.CompareExchange<Action<string>>(ref this.action_0, value, action2);
			}
			while (action != action2);
		}
		public void method_1(Action<string> action_3)
		{
			Action<string> action = this.action_0;
			Action<string> action2;
			do
			{
				action2 = action;
				Action<string> value = (Action<string>)Delegate.Remove(action2, action_3);
				action = Interlocked.CompareExchange<Action<string>>(ref this.action_0, value, action2);
			}
			while (action != action2);
		}
		public void method_2(Action<string> action_3)
		{
			Action<string> action = this.action_1;
			Action<string> action2;
			do
			{
				action2 = action;
				Action<string> value = (Action<string>)Delegate.Combine(action2, action_3);
				action = Interlocked.CompareExchange<Action<string>>(ref this.action_1, value, action2);
			}
			while (action != action2);
		}
		public void method_3(Action<string> action_3)
		{
			Action<string> action = this.action_1;
			Action<string> action2;
			do
			{
				action2 = action;
				Action<string> value = (Action<string>)Delegate.Remove(action2, action_3);
				action = Interlocked.CompareExchange<Action<string>>(ref this.action_1, value, action2);
			}
			while (action != action2);
		}
		internal void method_4(string string_2)
		{
			if (this.action_0 != null)
			{
				this.action_0(string_2);
			}
		}
		internal void method_5(string string_2)
		{
			if (this.action_1 != null)
			{
				this.action_1(string_2);
			}
		}
		internal void method_6(Action<Script, Script> action_3)
		{
			Action<Script, Script> action = this.action_2;
			Action<Script, Script> action2;
			do
			{
				action2 = action;
				Action<Script, Script> value = (Action<Script, Script>)Delegate.Combine(action2, action_3);
				action = Interlocked.CompareExchange<Action<Script, Script>>(ref this.action_2, value, action2);
			}
			while (action != action2);
		}
		internal void method_7(Action<Script, Script> action_3)
		{
			Action<Script, Script> action = this.action_2;
			Action<Script, Script> action2;
			do
			{
				action2 = action;
				Action<Script, Script> value = (Action<Script, Script>)Delegate.Remove(action2, action_3);
				action = Interlocked.CompareExchange<Action<Script, Script>>(ref this.action_2, value, action2);
			}
			while (action != action2);
		}
		internal bool method_8()
		{
			return this.bool_0;
		}
		internal void method_9(bool bool_6)
		{
			this.bool_0 = bool_6;
			this.method_5("Core is now " + (this.bool_0 ? "paused" : "running"));
		}
		internal Script method_10()
		{
			return this.script_0;
		}
		internal void method_11(Script script_1)
		{
			this.method_9(false);
			if (this.action_2 != null)
			{
				this.action_2(this.script_0, script_1);
			}
			this.script_0 = script_1;
			if (this.script_0 != null)
			{
				this.script_0.ScriptStartedTime = DateTime.Now;
				Class45.vector3_0 = null;
				this.script_0.DeathCounter = 0;
				this.method_18();
				foreach (Class44 current in this.list_0.ToList<Class44>())
				{
					if (current is Class51)
					{
						this.list_0.Remove(current);
					}
				}
				this.list_0.Add(new Class51());
				this.method_5("Changing script to: " + this.script_0.LoadedFromFileName);
				if (InjectedWindow.Instance != null && InjectedWindow.Instance.class71_0 != null)
				{
					if (InjectedWindow.Instance.class71_0.StartupAction == 2)
					{
						InjectedWindow.Instance.class71_0.StartScriptFileName = this.script_0.LoadedFromFileName;
						InjectedWindow.Instance.class71_0.method_0();
					}
				}
				else
				{
					this.method_4("FatalError: localProfile/MainWindow is not set!!");
				}
				this.script_0.ResetScript();
			}
			else
			{
				this.method_5("Aborting script");
			}
		}
		internal float method_12()
		{
			float radius;
			if (this.class56_0 == null)
			{
				radius = this.float_0;
			}
			else
			{
				if (this.class56_0.EndTick < Environment.TickCount || (this.class56_0.ResetOnWorldChange && this.class56_0.World != Framework.World))
				{
					this.class56_0 = null;
					this.method_5("Old aggrorange expired, reverting to: " + this.float_0 + " units");
				}
				if (this.class56_0 == null)
				{
					radius = this.float_0;
				}
				else
				{
					radius = this.class56_0.Radius;
				}
			}
			return radius;
		}
		internal void method_13()
		{
			ThreadStart threadStart = null;
			if (this.int_1++ < 20)
			{
				ContainerA.AddToFileLog("Frame #" + this.int_1);
			}
			if (this.bool_1)
			{
				Framework.ActivateGame();
			}
			if (this.method_10() != null && !this.method_8() && Framework.IsIngame)
			{
				Framework.ActivateGame();
				if (Framework.IsDisconnected())
				{
					if (threadStart == null)
					{
						threadStart = new ThreadStart(this.method_21);
					}
					new Thread(threadStart).Start();
					if (GClass0.threadStart_0 == null)
					{
						GClass0.threadStart_0 = new ThreadStart(GClass0.smethod_1);
					}
					new Thread(GClass0.threadStart_0).Start();
					this.method_9(true);
					string string_ = "Connection to gameserver lost, terminating game in 5s";
					this.method_5(string_);
					InjectedWindow.Instance.method_16(string_);
				}
				else
				{
					if (Framework.Hero.CurrentHP < 0.005f)
					{
						if (Environment.TickCount - this.int_0 >= 1000)
						{
							this.method_10().DeathCounter++;
							this.method_18();
							int restartOnXDeaths = InjectedWindow.Instance.class71_0.RestartOnXDeaths;
							if (restartOnXDeaths > 0 && this.method_10().DeathCounter >= restartOnXDeaths)
							{
								this.method_17(this.method_10().LoadedFromFileName);
							}
							else
							{
								this.int_0 = Environment.TickCount;
								this.method_5("Reviving at checkpoint...");
								Framework.ReviveAtCheckpointButton();
								this.method_10().RewindToLastSavepoint();
							}
						}
					}
					else
					{
						if (!Framework.IsInAnimation())
						{
							Class96.smethod_3();
							try
							{
								IEnumerable<Class44> arg_1C9_0 = this.list_0;
								if (GClass0.func_0 == null)
								{
									GClass0.func_0 = new Func<Class44, int>(GClass0.smethod_2);
								}
								foreach (Class44 current in arg_1C9_0.OrderBy(GClass0.func_0))
								{
									if (current.vmethod_0())
									{
										if (current != this.object_0)
										{
											this.object_0 = current;
											if (this.bool_2)
											{
												this.method_5(current.ToString());
											}
											return;
										}
										GClass0.CurrentStateName = ((CoreStatePriority)current.vmethod_2()).ToString();
										GClass0.CurrentStateTarget = current.vmethod_3();
										current.vmethod_1();
										return;
									}
								}
							}
							catch (Exception ex)
							{
								MessageBox.Show("Error in Core:\n" + ex.Message);
								Debugger.Break();
							}
							Class94 @class;
							while (true)
							{
								bool flag = false;
								if ((@class = this.list_1.FirstOrDefault<Class94>()) != null)
								{
									break;
								}
								if (!flag)
								{
									
								}
							}
							if (@class.vmethod_1())
							{
								this.list_1.Remove(@class);
							}
							@class.vmethod_0();
							return;
							try
							{
								IL_2D0:
								if (this.class46_0 != null)
								{
									if (this.class46_0.vmethod_0())
									{
										if (this.class46_0 != this.object_0)
										{
											this.object_0 = this.class46_0;
											if (this.bool_2)
											{
												this.method_5(this.class46_0.ToString());
											}
											return;
										}
										this.class46_0.vmethod_1();
										return;
									}
									else
									{
										this.class46_0 = null;
									}
								}
							}
							catch (Exception ex)
							{
								MessageBox.Show("Error in Searcher: " + ex.Message);
								Debugger.Break();
							}
							try
							{
								if (this.stack_0.Count > 0)
								{
									Class57 class2 = this.stack_0.Peek();
									if (class2.vmethod_1())
									{
										if (this.bool_2 && class2 != this.object_0)
										{
											this.object_0 = class2;
											this.method_5(class2.ToString());
										}
										class2.vmethod_2();
										return;
									}
									this.list_2.Remove(class2);
									this.list_2.Add((Class57)Activator.CreateInstance(class2.GetType()));
									this.stack_0.Pop();
									return;
								}
							}
							catch (Exception ex)
							{
								MessageBox.Show("Error in Event: " + ex.Message);
								Debugger.Break();
							}
							try
							{
								if (this.method_10() != null && !this.method_10().ScriptFinished)
								{
									if (this.method_10() != this.object_0)
									{
										this.object_0 = this.method_10();
										if (this.bool_2)
										{
											this.method_5("Script: " + this.method_10().CurrentIndex.ToString());
										}
									}
									else
									{
										GClass0.CurrentStateName = "Script";
										if (this.script_0.CurrentIndex >= 0 && this.script_0.CurrentIndex < this.script_0.ScriptActions.Count)
										{
											string str = "";
											if (Environment.TickCount - this.int_2 > 500)
											{
												this.int_2 = Environment.TickCount;
												Move move = this.script_0.ScriptActions[this.script_0.CurrentIndex] as Move;
												if (move != null)
												{
													float num = Vector3.Distance(move.Target, Framework.Hero.Position);
													str = " (dist: " + num + ")";
												}
											}
											GClass0.CurrentStateTarget = this.script_0.ScriptActions[this.script_0.CurrentIndex].ToString() + str;
										}
										else
										{
											GClass0.CurrentStateTarget = "Script index out of range";
										}
										this.method_10().Run();
									}
								}
							}
							catch (Exception ex)
							{
								MessageBox.Show("Error in Quest: " + ex.Message);
								Debugger.Break();
							}
						}
					}
				}
			}
		}
		internal void method_14()
		{
			this.GotoTown = false;
			this.class46_0 = null;
			this.method_11(null);
			this.stack_0.Clear();
		}
		internal void method_15(Class57 class57_0)
		{
			this.stack_0.Push(class57_0);
		}
		internal void method_16(float float_3, bool bool_6, int int_3)
		{
			this.method_5(string.Concat(new object[]
			{
				"New Aggrorange: ",
				float_3,
				", ",
				bool_6 ? "ROW" : "",
				"Timeout: ",
				int_3
			}));
			this.class56_0 = new GClass0.Class56();
			this.class56_0.ResetOnWorldChange = bool_6;
			this.class56_0.World = Framework.World;
			if (int_3 < 0 || bool_6)
			{
				int_3 = 1440;
			}
			this.class56_0.EndTick = Environment.TickCount + int_3 * 1000;
			this.class56_0.Radius = float_3;
		}
		internal void method_17(string string_2)
		{
			GClass0.Class62 @class = new GClass0.Class62();
			@class.string_0 = string_2;
			@class.gclass0_0 = this;
			if (GClass0.bool_4)
			{
				this.method_4("LogoutAndStartNewQuest:  Questchange is already in progress");
			}
			else
			{
				GClass0.bool_4 = true;
				GClass0.bool_3 = false;
				this.method_11(null);
				this.class46_0 = null;
				Task.Factory.StartNew(new Action(@class.method_0));
			}
		}
		internal void method_18()
		{
			Class48.list_1.Clear();
			Class45.list_3.Clear();
			Class47.list_1.Clear();
		}
		[CompilerGenerated]
		private void method_19(string string_2)
		{
			this.class60_0.method_1(string_2);
		}
		[CompilerGenerated]
		private void method_20(string string_2)
		{
			this.class60_0.method_2(string_2);
		}
		[CompilerGenerated]
		private void method_21()
		{
			Thread.Sleep(5000);
			if (!Framework.IsDisconnected())
			{
				this.method_9(false);
			}
			else
			{
				Process.GetCurrentProcess().Kill();
			}
		}
		[CompilerGenerated]
		private static void smethod_1()
		{
			MessageBox.Show("If the connection is not restored in 5 seconds, the game will terminate.", "Connection lost", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
		[CompilerGenerated]
		private static int smethod_2(Class44 class44_0)
		{
			return class44_0.vmethod_2();
		}
	}
}
