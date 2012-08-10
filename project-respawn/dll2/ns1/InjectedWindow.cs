using D3Core;
using D3Core.Classes;
using HellBuddy;
using HellBuddy.Scripting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ns1
{
	public class InjectedWindow : Form
	{
		private struct Struct12
		{
			public int int_0;
			public int int_1;
			public int int_2;
			public int int_3;
			public static bool smethod_0(InjectedWindow.Struct12 struct12_0, InjectedWindow.Struct12 struct12_1)
			{
				return struct12_0.int_0 == struct12_1.int_0 && struct12_0.int_2 == struct12_1.int_2 && struct12_0.int_1 == struct12_1.int_1 && struct12_0.int_3 == struct12_1.int_3;
			}
			public static bool smethod_1(InjectedWindow.Struct12 struct12_0, InjectedWindow.Struct12 struct12_1)
			{
				return !InjectedWindow.Struct12.smethod_0(struct12_0, struct12_1);
			}
		}
		private enum Enum3
		{
			const_0,
			const_1,
			const_2
		}
		[CompilerGenerated]
		private sealed class Class84
		{
			public InjectedWindow injectedWindow_0;
			public string string_0;
			public void method_0()
			{
				this.injectedWindow_0.ListBoxLog.Items.Add(this.string_0);
				this.injectedWindow_0.ListBoxLog.TopIndex = this.injectedWindow_0.ListBoxLog.Items.Count - 1;
			}
		}
		[CompilerGenerated]
		private sealed class Class110
		{
			public int int_0;
			public int int_1;
			public InjectedWindow injectedWindow_0;
			public string string_0;
			public void method_0(string[] string_1)
			{
				this.int_1++;
				string text = string_1[1].Trim();
				Class42 @class = new Class42();
				@class.method_1(float.Parse(string_1[2].Trim()));
				if (text.StartsWith("0x"))
				{
					try
					{
						@class.ModelId = Convert.ToInt32(text, 16);
						goto IL_86;
					}
					catch
					{
						this.injectedWindow_0.ListBoxLog.smethod_2("{0}: ERROR in Line {1}".smethod_1(this.string_0, this.int_1));
						return;
					}
				}
				@class.ModelNameSubstring = text;
				IL_86:
				Class48.list_0.Add(@class);
				this.int_0++;
			}
		}
		[CompilerGenerated]
		private sealed class Class106
		{
			public int int_0;
			public int int_1;
			public InjectedWindow injectedWindow_0;
			public string string_0;
			public void method_0(string[] string_1)
			{
				this.int_1++;
				string text = string_1[1].Trim();
				Class42 @class = new Class42();
				@class.method_1(float.Parse(string_1[2].Trim()));
				if (text.StartsWith("0x"))
				{
					try
					{
						@class.ModelId = Convert.ToInt32(text, 16);
						goto IL_86;
					}
					catch
					{
						this.injectedWindow_0.ListBoxLog.smethod_2("{0}: ERROR in Line {1}".smethod_1(this.string_0, this.int_1));
						return;
					}
				}
				@class.ModelNameSubstring = text;
				IL_86:
				Class49.list_0.Add(@class);
				this.int_0++;
			}
		}
		[CompilerGenerated]
		private sealed class Class105
		{
			public int int_0;
			public int int_1;
			public InjectedWindow injectedWindow_0;
			public string string_0;
			public void method_0(string[] string_1)
			{
				this.int_1++;
				string text = string_1[1].Trim();
				Class42 @class = new Class42();
				@class.method_1(float.Parse(string_1[2].Trim()));
				if (text.StartsWith("0x"))
				{
					try
					{
						@class.ModelId = Convert.ToInt32(text, 16);
						goto IL_86;
					}
					catch
					{
						this.injectedWindow_0.ListBoxLog.smethod_2("{0}: ERROR in Line {1}".smethod_1(this.string_0, this.int_1));
						return;
					}
				}
				@class.ModelNameSubstring = text;
				IL_86:
				Class47.list_0.Add(@class);
				this.int_0++;
			}
		}
		[CompilerGenerated]
		private sealed class Class103
		{
			public int int_0;
			public int int_1;
			public InjectedWindow injectedWindow_0;
			public string string_0;
			public void method_0(string[] string_1)
			{
				this.int_1++;
				string text = string_1[1].Trim();
				Class42 @class = new Class42();
				@class.method_1(float.Parse(string_1[2].Trim()));
				if (text.StartsWith("0x"))
				{
					try
					{
						@class.ModelId = Convert.ToInt32(text, 16);
						goto IL_86;
					}
					catch
					{
						this.injectedWindow_0.ListBoxLog.smethod_2("{0}: ERROR in Line {1}".smethod_1(this.string_0, this.int_1));
						return;
					}
				}
				@class.ModelNameSubstring = text;
				IL_86:
				Class45.list_0.Add(@class);
				this.int_0++;
			}
		}
		[CompilerGenerated]
		private sealed class Class124
		{
			public string string_0;
			public void method_0()
			{
				this.string_0 = string.Concat(new string[]
				{
					"World: ",
					Framework.World,
					"\r\nScene: ",
					Framework.Scene,
					"\r\nPosition: "
				});
				if (Framework.Hero != null)
				{
					this.string_0 += Framework.Hero.Position.ToString();
				}
			}
		}
		[CompilerGenerated]
		private sealed class Class125
		{
			public List<D3Spell> list_0;
			public void method_0()
			{
				for (int i = 0; i < 6; i++)
				{
					D3Spell spellIDByIndex = Framework.GetSpellIDByIndex(i);
					this.list_0.Add(spellIDByIndex);
				}
			}
		}
		[CompilerGenerated]
		private sealed class Class126
		{
			public Button button_0;
			public void method_0(object sender, FormClosedEventArgs e)
			{
				this.button_0.Enabled = true;
			}
		}
		[CompilerGenerated]
		private sealed class Class88
		{
			public D3Power d3Power_0;
			public D3Actor d3Actor_0;
			public InjectedWindow injectedWindow_0;
			private static Func<D3Actor, bool> func_0;
			private static Func<D3Actor, float> func_1;
			public void method_0()
			{
				Dictionary<int, D3Spell> activeSpells = Framework.Hero.GetActiveSpells();
				foreach (KeyValuePair<int, D3Spell> current in activeSpells)
				{
					if (current.Value.CanCast)
					{
						this.d3Power_0 = current.Value.D3Power;
					}
				}
			}
			public void method_1()
			{
				IEnumerable<D3Actor> arg_23_0 = Framework.Actors;
				if (InjectedWindow.Class88.func_0 == null)
				{
					InjectedWindow.Class88.func_0 = new Func<D3Actor, bool>(InjectedWindow.Class88.smethod_0);
				}
				IEnumerable<D3Actor> arg_45_0 = arg_23_0.Where(InjectedWindow.Class88.func_0);
				if (InjectedWindow.Class88.func_1 == null)
				{
					InjectedWindow.Class88.func_1 = new Func<D3Actor, float>(InjectedWindow.Class88.smethod_1);
				}
				this.d3Actor_0 = arg_45_0.OrderBy(InjectedWindow.Class88.func_1).FirstOrDefault<D3Actor>();
				if (this.d3Actor_0 != null)
				{
					Framework.UsePower_Position(30588u, this.d3Actor_0.Position);
					Framework.UsePower_Target((uint)this.d3Power_0, this.d3Actor_0);
				}
			}
			public void method_2()
			{
				this.injectedWindow_0.LabelTargetAndSpell.Text = string.Concat(new object[]
				{
					"Target: ",
					(this.d3Actor_0 == null) ? "null" : this.d3Actor_0.Modelname,
					"\r\nSpell: ",
					this.d3Power_0.ToString(),
					" - ",
					Environment.TickCount
				});
			}
			private static bool smethod_0(D3Actor d3Actor_1)
			{
				return d3Actor_1.Team == D3Team.Diablo && d3Actor_1.GetInt((D3Attribute)4294963292u) == 0 && d3Actor_1.GetFloat((D3Attribute)4294963302u) > 0.0011f;
			}
			private static float smethod_1(D3Actor d3Actor_1)
			{
				return d3Actor_1.DistanceToHero();
			}
		}
		[CompilerGenerated]
		private sealed class Class89
		{
			public Vector3? vector3_0;
			public AutoResetEvent autoResetEvent_0;
			public InjectedWindow injectedWindow_0;
			public void method_0()
			{
				if (Framework.Hero != null)
				{
					this.vector3_0 = new Vector3?(Framework.Hero.Position);
					try
					{
						this.autoResetEvent_0.Set();
					}
					catch
					{
					}
				}
			}
		}
		private Process process_0;
		private int int_0;
		private IntPtr intptr_0;
		internal ScriptEditor scriptEditor_0;
		internal Class71 class71_0;
		private InjectedWindow.Struct12 struct12_0;
		private TabPage tabPage_0;
		private Size size_0;
		private Point point_0;
		private Size size_1;
		private bool bool_0;
		private ActorListViewer actorListViewer_0;
		private CurrentSpells currentSpells_0;
		private ItemFactors itemFactors_0;
		private ActorListViewer actorListViewer_1;
		private Point point_1;
		private Point point_2;
		private bool bool_1;
		private IntPtr intptr_1;
		private int int_1;
		private Vector3 vector3_0;
		private float float_0;
		private int int_2;
		private bool bool_2;
		private bool bool_3;
		private bool bool_4;
		private IContainer icontainer_0;
		private Button Btn_General_StartQuest;
		private ComboBox ComboBox_General_Quests;
		private Label label1;
		private TabControl tabControl1;
		private TabPage generalTab;
		private TabPage optionsTab;
		private CheckBox CheckBoxAdvancedOptions;
		private TabPage advancedTab;
		private ListBox ListBoxLog;
		private Panel PanelContent;
		private Label label4;
		private Panel panel1;
		private Label label9;
		private Button BtnToolsLogin;
		private Label LabelAuthStatus;
		private Label label5;
		private CheckBox CheckBoxHoldGameActive;
		private TabPage QuestTab;
		private Button Btn_QuestTools_EditQuest;
		private Button Btn_QuestTools_RenameQuest;
		private Button Btn_QuestToold_DeleteQuest;
		private Button BtnNewQuest;
		private Label label6;
		private ListBox ListBox_QuestTools_AvailableQuests;
		private Label label11;
		private RadioButton radioButton_ResumeScript;
		private RadioButton radioButton_StartQuestScript;
		private RadioButton radioButton_DoNothing;
		private ComboBox comboBox_Profile_StartupQuest;
		private Panel panel2;
		private System.Windows.Forms.Timer timer_0;
		private Label LabelGameState;
		private Button BtnActorViewer;
		private Button BtnPauseResume;
		private Button BtnCurrentSpells;
		private Button BtnDebugLog;
		private CheckBox CheckBox_Profile_UseCustomItemFactors;
		private Button Btn_Profile_ItemFactors;
		private Label label16;
		private CheckBox CheckBoxChangeSpells;
		private ComboBox ComboBox_Profile_MinimumItemQuality;
		private Label label18;
		private Button BtnTestMovement;
		private Label LabelWorldAndScene;
		private Button BtnTestAttack;
		private Label LabelTargetAndSpell;
		private Button BtnTestUI;
		private CheckBox CheckBoxChangeEquip;
		private Button BtnInventoryList;
		private CheckBox CheckBox_SellInsteadOfSalvage;
		private CheckBox CheckBox_AllowTakeItemsFromStash;
		private ComboBox ComboBox_MaximumSellOrSalvageValue;
		private Label label12;
		private NumericUpDown NumericUpDown_RestartOnXDeaths;
		private Label label13;
		private CheckBox CheckBoxToggleSize;
		private CheckBox CheckBox_AutoSnap;
		private System.Windows.Forms.Timer timer_1;
		private Button BtnRefreshView;
		private CheckBox CheckBox_DisableWatchDog;
		private Label Label_WatchDog;
		private ComboBox ComboBox_MinimumStashQuality;
		private Label label7;
		private TabPage StatsPage;
		private Label Label_StatsTimer;
		private System.Windows.Forms.Timer timer_2;
		private Label label2;
		private NumericUpDown NumericUpDown_WatchDogTimeoutSeconds;
		private Label label3;
		private Button BtnResetStats;
		private TableLayoutPanel tableLayoutPanel1;
		private Label Label_StatsB;
		private Label Label_StatsA;
		private Label label10;
		private NumericUpDown numericUpDown_MinimumGold;
		private Label label8;
		private Button BtnLeaveGame;
		private CheckBox CheckboxDontPickPotions;
		[CompilerGenerated]
		private static InjectedWindow injectedWindow_0;
		[CompilerGenerated]
		private static Func<string, string> func_0;
		[CompilerGenerated]
		private static Action action_0;
		[CompilerGenerated]
		private static Action action_1;
		[CompilerGenerated]
		private static Action action_2;
		[CompilerGenerated]
		private static Func<KeyValuePair<D3Attribute, float>, D3Attribute> func_1;
		[CompilerGenerated]
		private static Func<KeyValuePair<D3Attribute, float>, float> func_2;
		[CompilerGenerated]
		private static Action action_3;
		[CompilerGenerated]
		private static Action action_4;
		[CompilerGenerated]
		private static ThreadStart threadStart_0;
		[CompilerGenerated]
		private static Action action_5;
		internal static InjectedWindow Instance
		{
			get;
			private set;
		}
		protected override bool ShowWithoutActivation
		{
			get
			{
				return true;
			}
		}
		public InjectedWindow()
		{
			Action<Script, Script> action = null;
			ThreadStart threadStart = null;
			ThreadStart threadStart2 = null;
			this.scriptEditor_0 = null;
			this.struct12_0 = default(InjectedWindow.Struct12);
			this.actorListViewer_0 = null;
			this.currentSpells_0 = null;
			this.itemFactors_0 = null;
			this.actorListViewer_1 = null;
			this.point_1 = default(Point);
			this.point_2 = default(Point);
			this.bool_1 = false;
			this.float_0 = 30f;
			this.int_2 = 0;
			this.bool_3 = false;
			this.bool_4 = false;
			this.icontainer_0 = null;
			
			try
			{
				InjectedWindow.Instance = this;
				this.process_0 = Process.GetCurrentProcess();
				this.intptr_0 = this.process_0.MainWindowHandle;
				this.int_0 = this.process_0.Id;
				Application.EnableVisualStyles();
				this.InitializeComponent();
				this.tabPage_0 = this.tabControl1.TabPages["advancedTab"];
				this.tabControl1.TabPages.Remove(this.tabPage_0);
				Class91.smethod_0();
				GClass0 arg_10C_0 = GClass0.smethod_0();
				if (action == null)
				{
					action = new Action<Script, Script>(this.method_22);
				}
				arg_10C_0.method_6(action);
				if (threadStart == null)
				{
					threadStart = new ThreadStart(this.method_23);
				}
				new Thread(threadStart).Start();
				if (threadStart2 == null)
				{
					threadStart2 = new ThreadStart(this.method_24);
				}
				Thread thread = new Thread(threadStart2);
				thread.Start();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Exception when initializing the control-panel: " + ex.Message);
			}
		}
		internal void method_0(string string_0)
		{
			InjectedWindow.Class84 @class = new InjectedWindow.Class84();
			@class.string_0 = string_0;
			@class.injectedWindow_0 = this;
			base.BeginInvoke(new MethodInvoker(@class.method_0));
		}
		private void method_1()
		{
			InjectedWindow.GetWindowRect(this.intptr_0, ref this.struct12_0);
			if (this.CheckBoxToggleSize.Checked || this.struct12_0.int_1 >= -10000)
			{
				Point point = new Point(this.struct12_0.int_0 + 12, this.struct12_0.int_1 + 34);
				if (base.Location != point)
				{
					base.Location = point;
				}
			}
		}
		[DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
		public static extern IntPtr GetForegroundWindow();
		[DllImport("user32.dll", SetLastError = true)]
		public static extern IntPtr SetWindowPos(IntPtr intptr_2, int int_3, int int_4, int int_5, int int_6, int int_7, int int_8);
		[DllImport("user32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool GetWindowRect(IntPtr intptr_2, ref InjectedWindow.Struct12 struct12_1);
		[DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
		public static extern int IsWindow(IntPtr intptr_2);
		internal void method_2()
		{
			this.ComboBox_General_Quests.SuspendLayout();
			this.ListBox_QuestTools_AvailableQuests.SuspendLayout();
			this.comboBox_Profile_StartupQuest.SuspendLayout();
			this.ComboBox_General_Quests.Items.Clear();
			this.ListBox_QuestTools_AvailableQuests.Items.Clear();
			this.comboBox_Profile_StartupQuest.Items.Clear();
			IEnumerable<string> arg_87_0 = Directory.EnumerateFiles(Script.ScriptBaseDirectory, "*" + Script.FileExtension);
			if (InjectedWindow.func_0 == null)
			{
				InjectedWindow.func_0 = new Func<string, string>(InjectedWindow.smethod_0);
			}
			string[] array = arg_87_0.Select(InjectedWindow.func_0).ToArray<string>();
			this.ComboBox_General_Quests.Items.AddRange(array);
			this.ListBox_QuestTools_AvailableQuests.Items.AddRange(array);
			this.comboBox_Profile_StartupQuest.Items.AddRange(array);
			if (array.Length > 0)
			{
				this.ComboBox_General_Quests.SelectedIndex = 0;
				this.ListBox_QuestTools_AvailableQuests.SelectedIndex = 0;
				this.comboBox_Profile_StartupQuest.SelectedIndex = 0;
			}
			this.comboBox_Profile_StartupQuest.ResumeLayout();
			this.ListBox_QuestTools_AvailableQuests.ResumeLayout();
			this.ComboBox_General_Quests.ResumeLayout();
		}
		private void CheckBoxAdvancedOptions_CheckedChanged(object sender, EventArgs e)
		{
			if (this.CheckBoxAdvancedOptions.Checked)
			{
				this.tabControl1.TabPages.Insert(this.tabControl1.TabCount, this.tabPage_0);
			}
			else
			{
				this.tabControl1.TabPages.Remove(this.tabPage_0);
			}
			this.class71_0.ShowAdvancedOptions = this.CheckBoxAdvancedOptions.Checked;
			this.class71_0.method_0();
		}
		private void InjectedWindow_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (e.CloseReason == CloseReason.UserClosing)
			{
				e.Cancel = true;
			}
			Process.GetCurrentProcess().Kill();
		}
		private void method_3()
		{
			this.method_4();
			this.method_6();
			this.method_8();
			this.method_10();
			this.method_12();
		}
		private void method_4()
		{
			this.method_5("LootTable_Static.txt");
			this.method_5("LootTable_Global.txt");
			this.method_5("LootTable_{0}.txt".smethod_0(Path.GetFileNameWithoutExtension(this.class71_0.LoadedFromFileName)));
		}
		private void method_5(string string_0)
		{
			InjectedWindow.Class110 @class = new InjectedWindow.Class110();
			@class.string_0 = string_0;
			@class.injectedWindow_0 = this;
			string string_ = Class71.string_3;
			string text = Path.Combine(string_, @class.string_0);
			if (File.Exists(text))
			{
				@class.int_0 = 0;
				@class.int_1 = 0;
				Class104.smethod_0(text, 3, new Action<string[]>(@class.method_0));
				this.ListBoxLog.smethod_2("Loaded {0} definitions from: {1}".smethod_1(@class.int_0, @class.string_0));
				this.ListBoxLog.TopIndex = this.ListBoxLog.Items.Count - 1;
			}
		}
		private void method_6()
		{
			this.method_7("DoorTable_Static.txt");
			this.method_7("DoorTable_Global.txt");
			this.method_7("DoorTable_{0}.txt".smethod_0(Path.GetFileNameWithoutExtension(this.class71_0.LoadedFromFileName)));
		}
		private void method_7(string string_0)
		{
			InjectedWindow.Class106 @class = new InjectedWindow.Class106();
			@class.string_0 = string_0;
			@class.injectedWindow_0 = this;
			string string_ = Class71.string_3;
			string text = Path.Combine(string_, @class.string_0);
			if (File.Exists(text))
			{
				@class.int_0 = 0;
				@class.int_1 = 0;
				Class104.smethod_0(text, 3, new Action<string[]>(@class.method_0));
				this.ListBoxLog.smethod_2("Loaded {0} definitions from: {1}".smethod_1(@class.int_0, @class.string_0));
				this.ListBoxLog.TopIndex = this.ListBoxLog.Items.Count - 1;
			}
		}
		private void method_8()
		{
			this.method_9("ObstacleTable_Static.txt");
			this.method_9("ObstacleTable_Global.txt");
			this.method_9("ObstacleTable_{0}.txt".smethod_0(Path.GetFileNameWithoutExtension(this.class71_0.LoadedFromFileName)));
		}
		private void method_9(string string_0)
		{
			InjectedWindow.Class105 @class = new InjectedWindow.Class105();
			@class.string_0 = string_0;
			@class.injectedWindow_0 = this;
			string string_ = Class71.string_3;
			string text = Path.Combine(string_, @class.string_0);
			if (File.Exists(text))
			{
				@class.int_0 = 0;
				@class.int_1 = 0;
				Class104.smethod_0(text, 3, new Action<string[]>(@class.method_0));
				this.ListBoxLog.smethod_2("Loaded {0} definitions from: {1}".smethod_1(@class.int_0, @class.string_0));
				this.ListBoxLog.TopIndex = this.ListBoxLog.Items.Count - 1;
			}
		}
		private void method_10()
		{
			this.method_11("MonsterTable_Static.txt");
			this.method_11("MonsterTable_Global.txt");
			this.method_11("MonsterTable_{0}.txt".smethod_0(Path.GetFileNameWithoutExtension(this.class71_0.LoadedFromFileName)));
		}
		private void method_11(string string_0)
		{
			InjectedWindow.Class103 @class = new InjectedWindow.Class103();
			@class.string_0 = string_0;
			@class.injectedWindow_0 = this;
			string string_ = Class71.string_3;
			string text = Path.Combine(string_, @class.string_0);
			if (File.Exists(text))
			{
				@class.int_0 = 0;
				@class.int_1 = 0;
				Class104.smethod_0(text, 3, new Action<string[]>(@class.method_0));
				this.ListBoxLog.smethod_2("Loaded {0} definitions from: {1}".smethod_1(@class.int_0, @class.string_0));
				this.ListBoxLog.TopIndex = this.ListBoxLog.Items.Count - 1;
			}
		}
		private void method_12()
		{
			string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(this.class71_0.LoadedFromFileName);
			if (!this.method_13("SpellTable_Wizard_{0}.txt".smethod_0(fileNameWithoutExtension), GClass3.list_0) && !this.method_13("SpellTable_Wizard_Global.txt", GClass3.list_0) && !this.method_13("SpellTable_Wizard_Static.txt", GClass3.list_0))
			{
				GClass0.smethod_0().method_4("No spelltable loaded for Wizard");
			}
			if (!this.method_13("SpellTable_Monk_{0}.txt".smethod_0(fileNameWithoutExtension), GClass3.list_1) && !this.method_13("SpellTable_Monk_Global.txt", GClass3.list_1) && !this.method_13("SpellTable_Monk_Static.txt", GClass3.list_1))
			{
				GClass0.smethod_0().method_4("No spelltable loaded for Monk");
			}
			if (!this.method_13("SpellTable_Barbarian_{0}.txt".smethod_0(fileNameWithoutExtension), GClass3.list_2) && !this.method_13("SpellTable_Barbarian_Global.txt", GClass3.list_2) && !this.method_13("SpellTable_Barbarian_Static.txt", GClass3.list_2))
			{
				GClass0.smethod_0().method_4("No spelltable loaded for Barbarian");
			}
			if (!this.method_13("SpellTable_DemonHunter_{0}.txt".smethod_0(fileNameWithoutExtension), GClass3.list_3) && !this.method_13("SpellTable_DemonHunter_Global.txt", GClass3.list_3) && !this.method_13("SpellTable_DemonHunter_Static.txt", GClass3.list_3))
			{
				GClass0.smethod_0().method_4("No spelltable loaded for DemonHunter");
			}
			if (!this.method_13("SpellTable_WitchDoctor_{0}.txt".smethod_0(fileNameWithoutExtension), GClass3.list_4) && !this.method_13("SpellTable_WitchDoctor_Global.txt", GClass3.list_4) && !this.method_13("SpellTable_WitchDoctor_Static.txt", GClass3.list_4))
			{
				GClass0.smethod_0().method_4("No spelltable loaded for WitchDoctor");
			}
		}
		private bool method_13(string string_0, List<GClass3.GClass2> list_0)
		{
			string string_ = Class71.string_3;
			string path = Path.Combine(string_, string_0);
			bool result;
			if (!File.Exists(path))
			{
				result = false;
			}
			else
			{
				string[] string_2 = File.ReadAllLines(path);
				this.method_14(string_2, list_0, Path.GetFileName(path));
				result = (list_0.Count != 0);
			}
			return result;
		}
		private void method_14(string[] string_0, List<GClass3.GClass2> list_0, string string_1)
		{
			int num = 0;
			bool flag = false;
			int num2 = -1;
			Dictionary<int, GClass3.GClass2> dictionary = new Dictionary<int, GClass3.GClass2>();
			for (int i = 0; i < string_0.Length; i++)
			{
				string text = string_0[i];
				num++;
				string text2 = text.Trim();
				if (!text2.StartsWith("//") && (flag || text2.Length != 0))
				{
					if (text2.Contains(":"))
					{
						flag = true;
						string s = text2.Replace(":", "");
						int num3 = -1;
						try
						{
							num3 = int.Parse(s);
							num2 = num3;
							goto IL_18E;
						}
						catch
						{
							num2 = -1;
							goto IL_18E;
						}
						goto IL_9E;
						IL_18E:
						dictionary[num3] = new GClass3.GClass2
						{
							int_0 = num3,
							list_0 = new List<D3Spell>()
						};
						goto IL_183;
					}
					IL_9E:
					if (num2 != -1 && flag && text2.Length != 0)
					{
						try
						{
							GClass3.GClass2 gClass = dictionary[num2];
							string value = text2.smethod_4(0, text2.IndexOf(','));
							string s2 = text2.smethod_4(text2.IndexOf(',') + 1, text2.Length);
							D3Power d3Power = (D3Power)Enum.Parse(typeof(D3Power), value);
							int rune = int.Parse(s2);
							D3Spell item = new D3Spell(d3Power, rune);
							gClass.list_0.Add(item);
						}
						catch
						{
							GClass0.smethod_0().method_4("SpellSets: Cannot parse line:" + text2);
							this.ListBoxLog.smethod_2("ERROR in {0}: \"{1}\"".smethod_1(string_1, text2));
							this.ListBoxLog.TopIndex = this.ListBoxLog.Items.Count - 1;
						}
					}
				}
				IL_183:;
			}
			num = 0;
			foreach (KeyValuePair<int, GClass3.GClass2> current in dictionary)
			{
				num++;
				list_0.Add(current.Value);
			}
			this.ListBoxLog.smethod_2("Loaded {0} definitions from: {1}".smethod_1(num, string_1));
			this.ListBoxLog.TopIndex = this.ListBoxLog.Items.Count - 1;
		}
		private void InjectedWindow_Load(object sender, EventArgs e)
		{
			try
			{
				this.method_1();
				this.method_2();
				int id = Process.GetCurrentProcess().Id;
				string string_ = Class91.smethod_4(id, "ProfileFile");
				string text = Class91.smethod_4(id, "Email");
				string text2 = Class91.smethod_4(id, "Password");
				this.class71_0 = Class71.smethod_0(string_);
				this.CheckBox_Profile_UseCustomItemFactors.Checked = this.class71_0.UseCustomItemFactors;
				this.CheckBox_AllowTakeItemsFromStash.Checked = this.class71_0.AllowToTakeOutStashItems;
				this.CheckBoxChangeSpells.Checked = this.class71_0.ChangeSpells;
				this.CheckBox_SellInsteadOfSalvage.Checked = this.class71_0.SellInsteadOfSalvage;
				this.CheckBoxChangeEquip.Checked = this.class71_0.ChangeEquip;
				this.CheckBox_AutoSnap.Checked = this.class71_0.AutoSnapToD3Window;
				this.NumericUpDown_RestartOnXDeaths.Value = this.class71_0.RestartOnXDeaths;
				if (this.class71_0.WatchDogTimeout < this.NumericUpDown_WatchDogTimeoutSeconds.Minimum)
				{
					this.class71_0.WatchDogTimeout = (int)this.NumericUpDown_WatchDogTimeoutSeconds.Minimum;
				}
				this.NumericUpDown_WatchDogTimeoutSeconds.Value = this.class71_0.WatchDogTimeout;
				this.CheckBox_DisableWatchDog.Checked = this.class71_0.DisableWatchDog;
				this.numericUpDown_MinimumGold.Value = this.class71_0.MinimumGoldToLoot;
				this.CheckboxDontPickPotions.Checked = this.class71_0.DontPickupPotions;
				int num = this.class71_0.MinimumItemRarity;
				if (num <= 0)
				{
					num = 3;
				}
				int maximumSellOrSalvageValue = this.class71_0.MaximumSellOrSalvageValue;
				int num2 = this.class71_0.MinimumItemQualityToStash;
				if (num2 <= 0)
				{
					num2 = 9;
				}
				try
				{
					this.ComboBox_Profile_MinimumItemQuality.Items.AddRange(Enum.GetNames(typeof(D3ItemRarity)));
					this.ComboBox_Profile_MinimumItemQuality.SelectedIndex = num;
				}
				catch
				{
				}
				try
				{
					this.ComboBox_MaximumSellOrSalvageValue.Items.AddRange(Enum.GetNames(typeof(D3ItemRarity)));
					this.ComboBox_MaximumSellOrSalvageValue.SelectedIndex = maximumSellOrSalvageValue;
				}
				catch
				{
				}
				try
				{
					this.ComboBox_MinimumStashQuality.Items.AddRange(Enum.GetNames(typeof(D3ItemRarity)));
					this.ComboBox_MinimumStashQuality.SelectedIndex = num2;
				}
				catch
				{
				}
				this.method_3();
				if (this.class71_0.StartScriptFileName != null && this.class71_0.StartScriptFileName.Length > 0)
				{
					for (int i = 0; i < this.comboBox_Profile_StartupQuest.Items.Count; i++)
					{
						if (this.comboBox_Profile_StartupQuest.Items[i].ToString() == this.class71_0.StartScriptFileName)
						{
							this.comboBox_Profile_StartupQuest.SelectedIndex = i;
							break;
						}
					}
				}
				if (this.class71_0.StartupAction == 0)
				{
					this.radioButton_DoNothing.Checked = true;
				}
				else
				{
					if (this.class71_0.StartupAction == 1)
					{
						this.radioButton_StartQuestScript.Checked = true;
					}
					else
					{
						if (this.class71_0.StartupAction == 2)
						{
							this.radioButton_ResumeScript.Checked = true;
						}
					}
				}
				this.CheckBoxAdvancedOptions.Checked = this.class71_0.ShowAdvancedOptions;
				if (text != null && text2 != null)
				{
					this.ListBoxLog.Items.Add("Starting Battle.NET logon: " + text);
					this.ListBoxLog.Items.Add("Waiting for Battle.NET to respond...");
					LoginHelper.LoginToAccount(text, text2);
					Task.Factory.StartNew(new Action(this.method_15), TaskCreationOptions.LongRunning);
				}
				else
				{
					this.ListBoxLog.Items.Add("Autologin is disable for this profile");
				}
			}
			catch (Exception ex)
			{
				ContainerA.AddToFileLog("Error: Loading UI failed:" + ex.Message + "\r\nST: " + ex.StackTrace);
			}
		}
		private void method_15()
		{
			MethodInvoker methodInvoker = null;
			DateTime now = DateTime.Now;
			this.ListBoxLog.smethod_2("Waiting maximum " + 25 + " seconds for login");
			while (true)
			{
				Thread.Sleep(500);
				if (Framework.IsConnectedToBattleNet)
				{
					break;
				}
				if ((DateTime.Now - now).TotalSeconds > 25.0)
				{
					this.ListBoxLog.smethod_2("Waited " + 25 + " seconds and not logged in, there must be some kind of error");
					this.ListBoxLog.smethod_2("Terminating...");
					if (methodInvoker == null)
					{
						methodInvoker = new MethodInvoker(this.method_25);
					}
					base.BeginInvoke(methodInvoker);
					Thread.Sleep(3000);
					Process.GetCurrentProcess().Kill();
				}
			}
			this.ListBoxLog.smethod_2("Login complete, inside heroselection now");
			if (this.radioButton_DoNothing.Checked)
			{
				this.ListBoxLog.smethod_2("\"" + this.radioButton_DoNothing.Text + "\" is selected");
			}
			else
			{
				if (this.radioButton_ResumeScript.Checked)
				{
					string text = Path.Combine(Script.ScriptBaseDirectory, this.class71_0.StartScriptFileName);
					Script script = Script.LoadFromFile(text);
					if (script == null)
					{
						this.ListBoxLog.smethod_2("Cannot resume, questscript file is missing!!");
					}
					else
					{
						this.ListBoxLog.smethod_2("Resuming: \"" + Path.GetFileNameWithoutExtension(text) + "\"");
						Thread.Sleep(1000);
						D3CharSelect.Logon_StartNew(script.AssociatedStartQuest, script.QuestStep1, script.QuestStep2);
						GClass0.smethod_0().method_11(script);
					}
				}
				else
				{
					if (this.radioButton_StartQuestScript.Checked)
					{
						string text = Path.Combine(Script.ScriptBaseDirectory, this.class71_0.StartScriptFileName);
						Script script = Script.LoadFromFile(text);
						if (script == null)
						{
							this.ListBoxLog.smethod_2("Cannot start, questscript could not be loaded!!");
						}
						else
						{
							this.ListBoxLog.smethod_2("Autostarting: \"" + Path.GetFileNameWithoutExtension(text) + "\"");
							Thread.Sleep(1000);
							D3CharSelect.Logon_StartNew(script.AssociatedStartQuest, script.QuestStep1, script.QuestStep2);
							GClass0.smethod_0().method_11(script);
						}
					}
				}
			}
		}
		internal void method_16(string string_0)
		{
			this.ListBoxLog.smethod_2(string_0);
		}
		private void BtnToolsLogin_Click(object sender, EventArgs e)
		{
			D3CharSelect.Logon_StartNew(D3Quest.A1_Q1, 4294967040u, 255u);
		}
		private void CheckBoxToggleSize_CheckedChanged(object sender, EventArgs e)
		{
			if (this.CheckBoxToggleSize.Checked)
			{
				this.PanelContent.Visible = false;
				this.point_0 = this.CheckBoxToggleSize.Location;
				this.size_0 = base.Size;
				this.size_1 = this.MinimumSize;
				this.bool_0 = this.class71_0.AutoSnapToD3Window;
				this.class71_0.AutoSnapToD3Window = true;
				base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
				this.MinimumSize = new Size(0, 0);
				base.Size = new Size(58, 20);
				this.CheckBoxToggleSize.Location = new Point(3, 1);
			}
			else
			{
				this.PanelContent.Visible = true;
				base.FormBorderStyle = FormBorderStyle.SizableToolWindow;
				this.MinimumSize = this.size_1;
				base.Size = this.size_0;
				this.CheckBoxToggleSize.Location = this.point_0;
				this.CheckBoxToggleSize.Visible = true;
				this.class71_0.AutoSnapToD3Window = this.bool_0;
			}
		}
		private void CheckBoxHoldGameActive_CheckedChanged(object sender, EventArgs e)
		{
			GClass0.smethod_0().bool_1 = this.CheckBoxHoldGameActive.Checked;
		}
		private void BtnNewQuest_Click(object sender, EventArgs e)
		{
			FormClosedEventHandler formClosedEventHandler = null;
			if (this.scriptEditor_0 != null && !this.scriptEditor_0.IsDisposed)
			{
				this.scriptEditor_0.Visible = true;
			}
			else
			{
				StringQuery stringQuery = new StringQuery("New Quest", "Name of the new quest:");
				if (stringQuery.ShowDialog() == DialogResult.OK)
				{
					for (int i = 0; i < stringQuery.ResultString.Length; i++)
					{
						char c = stringQuery.ResultString[i];
						if (!char.IsLetterOrDigit(c) && !"_- ".Contains(c))
						{
							MessageBox.Show("Filename is invalid!\nOnly letters and digits are allowed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
							return;
						}
					}
					this.scriptEditor_0 = new ScriptEditor(false, stringQuery.ResultString);
					Form arg_B5_0 = this.scriptEditor_0;
					if (formClosedEventHandler == null)
					{
						formClosedEventHandler = new FormClosedEventHandler(this.method_26);
					}
					arg_B5_0.FormClosed += formClosedEventHandler;
					this.scriptEditor_0.Show();
				}
			}
		}
		private void Btn_General_StartQuest_Click(object sender, EventArgs e)
		{
			if (!Framework.IsConnectedToBattleNet)
			{
				MessageBox.Show("Cannot start a game if not in character selection", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			else
			{
				if (Framework.IsIngame)
				{
					if (GClass0.smethod_0().method_10() != null)
					{
						if (Environment.TickCount - Class45.LastRan < 200)
						{
							DialogResult dialogResult = MessageBox.Show("The bot is currently in combat.\r\nInterrupt anyway?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
							if (dialogResult == DialogResult.No)
							{
								return;
							}
						}
						this.ListBoxLog.Items.Add("User request: Stop script");
						GClass0.smethod_0().method_11(null);
						if (InjectedWindow.action_0 == null)
						{
							InjectedWindow.action_0 = new Action(InjectedWindow.smethod_1);
						}
						Framework.RunInD3ContextSynced(InjectedWindow.action_0);
					}
					else
					{
						this.ListBoxLog.Items.Add("User request: Leave game");
						if (InjectedWindow.action_1 == null)
						{
							InjectedWindow.action_1 = new Action(InjectedWindow.smethod_2);
						}
						Framework.RunInD3ContextSynced(InjectedWindow.action_1);
					}
				}
				else
				{
					try
					{
						this.Btn_General_StartQuest.Enabled = false;
						this.ComboBox_General_Quests.Enabled = false;
						string text = this.ComboBox_General_Quests.SelectedItem as string;
						Script script = Script.LoadFromFile(text);
						D3Quest associatedStartQuest = script.AssociatedStartQuest;
						D3CharSelect.Logon_StartNew(associatedStartQuest, script.QuestStep1, script.QuestStep2);
						GClass0.smethod_0().method_9(false);
						GClass0.smethod_0().method_11(script);
						this.ListBoxLog.Items.Add(string.Concat(new string[]
						{
							"Starting quest: \"",
							script.AssociatedStartQuest.ToString(),
							"\", QuestFile: \"",
							text,
							"\""
						}));
					}
					catch (Exception ex)
					{
						MessageBox.Show("Start quest button: Error:" + ex.Message + "\n\n", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					}
				}
			}
		}
		private void Btn_QuestTools_EditQuest_Click(object sender, EventArgs e)
		{
			FormClosedEventHandler formClosedEventHandler = null;
			try
			{
				if (this.scriptEditor_0 != null && !this.scriptEditor_0.IsDisposed)
				{
					this.scriptEditor_0.Visible = true;
				}
				else
				{
					if (this.ListBox_QuestTools_AvailableQuests.Items.Count != 0)
					{
						if (this.ListBox_QuestTools_AvailableQuests.SelectedIndex != -1)
						{
							this.scriptEditor_0 = new ScriptEditor(true, this.ListBox_QuestTools_AvailableQuests.SelectedItem.ToString());
							Form arg_90_0 = this.scriptEditor_0;
							if (formClosedEventHandler == null)
							{
								formClosedEventHandler = new FormClosedEventHandler(this.method_28);
							}
							arg_90_0.FormClosed += formClosedEventHandler;
							this.scriptEditor_0.Show();
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Edit quest button: Error:" + ex.Message + "\n\n", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}
		private void Btn_QuestTools_RenameQuest_Click(object sender, EventArgs e)
		{
			MethodInvoker methodInvoker = null;
			try
			{
				if (this.ListBox_QuestTools_AvailableQuests.SelectedIndex == -1)
				{
					return;
				}
				string str = this.ListBox_QuestTools_AvailableQuests.SelectedItem.ToString();
				if (!File.Exists(Path.Combine(Script.ScriptBaseDirectory, str + Script.FileExtension)))
				{
					return;
				}
				StringQuery stringQuery = new StringQuery("Rename Quest", "New name of the quest:");
				if (stringQuery.ShowDialog() == DialogResult.OK)
				{
					for (int i = 0; i < stringQuery.ResultString.Length; i++)
					{
						char c = stringQuery.ResultString[i];
						if (!char.IsLetterOrDigit(c) && !"_- ".Contains(c))
						{
							MessageBox.Show("Filename is invalid!\nOnly letters and digits are allowed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
							return;
						}
					}
					string text = Path.Combine(Script.ScriptBaseDirectory, str + Script.FileExtension);
					string destFileName = Path.Combine(Script.ScriptBaseDirectory, stringQuery.ResultString + Script.FileExtension);
					if (!File.Exists(text))
					{
						return;
					}
					File.Copy(text, destFileName);
					File.Delete(text);
					this.method_2();
					if (methodInvoker == null)
					{
						methodInvoker = new MethodInvoker(this.method_30);
					}
					base.BeginInvoke(methodInvoker);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Rename quest button: Error:" + ex.Message + "\n\n", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			base.Activate();
		}
		private void Btn_QuestToold_DeleteQuest_Click(object sender, EventArgs e)
		{
			if (this.ListBox_QuestTools_AvailableQuests.SelectedIndex != -1)
			{
				string text = this.ListBox_QuestTools_AvailableQuests.SelectedItem.ToString();
				if (File.Exists(Path.Combine(Script.ScriptBaseDirectory, text + Script.FileExtension)))
				{
					if (MessageBox.Show("Are you sure you want to delete: \"" + text + "\" ??", "Delete Quest", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
					{
						File.Delete(Path.Combine(Script.ScriptBaseDirectory, text + Script.FileExtension));
					}
					this.method_2();
				}
			}
		}
		private void radioButton_StartQuestScript_CheckedChanged(object sender, EventArgs e)
		{
			int num;
			if (this.radioButton_DoNothing.Checked)
			{
				num = 0;
			}
			else
			{
				if (this.radioButton_StartQuestScript.Checked)
				{
					num = 1;
					this.class71_0.StartScriptFileName = (this.comboBox_Profile_StartupQuest.SelectedItem as string);
				}
				else
				{
					num = 2;
					if (GClass0.smethod_0().method_10() != null)
					{
						this.class71_0.StartScriptFileName = GClass0.smethod_0().method_10().LoadedFromFileName;
					}
				}
			}
			this.comboBox_Profile_StartupQuest.Enabled = (num == 1);
			this.class71_0.StartupAction = num;
			this.class71_0.method_0();
		}
		private void comboBox_Profile_StartupQuest_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.class71_0 != null)
			{
				this.class71_0.StartScriptFileName = (this.comboBox_Profile_StartupQuest.SelectedItem as string);
				this.class71_0.method_0();
			}
		}
		private void timer_0_Tick(object sender, EventArgs e)
		{
			InjectedWindow.Class124 @class = new InjectedWindow.Class124();
			if (this.class71_0 != null)
			{
				if (Class92.FirstTimeAuthDone && !Class92.AuthenticationFaulted)
				{
					this.LabelAuthStatus.ForeColor = Color.DarkGreen;
					this.LabelAuthStatus.Text = "Authenticated.";
				}
				else
				{
					this.LabelAuthStatus.ForeColor = SystemColors.ControlDark;
					this.LabelAuthStatus.Text = "Authentication: " + (Class92.FirstTimeAuthDone ? "FA:N " : "FA:D, ") + (Class92.AuthenticationFaulted ? "AF:Y" : "AF:N");
				}
				if (Framework.IsConnectedToBattleNet && !GClass0.bool_4)
				{
					this.Btn_General_StartQuest.Enabled = true;
					this.ComboBox_General_Quests.Enabled = true;
					if (GClass0.smethod_0().method_10() != null)
					{
						this.Btn_General_StartQuest.Text = "Stop";
					}
					else
					{
						this.Btn_General_StartQuest.Text = "Start";
					}
				}
				else
				{
					this.Btn_General_StartQuest.Enabled = false;
					this.ComboBox_General_Quests.Enabled = false;
				}
				this.BtnPauseResume.Enabled = (Framework.IsIngame && GClass0.smethod_0().method_10() != null);
				this.BtnPauseResume.Text = (GClass0.smethod_0().method_8() ? "Resume" : "Pause");
				this.LabelGameState.Text = "GameState: " + (Framework.IsIngame ? "Ingame" : "Not ingame");
				this.LabelGameState.Text = string.Concat(new object[]
				{
					"BattleNet: ",
					Framework.IsConnectedToBattleNet ? "Connected to BNet" : "BNet connection lost",
					", Players in game: ",
					Framework.PlayersInCurrentGame()
				});
				@class.string_0 = "";
				Framework.RunInD3ContextSynced(new Action(@class.method_0));
				this.LabelWorldAndScene.Text = @class.string_0;
				this.LabelTargetAndSpell.Text = string.Concat(new object[]
				{
					"Target: ",
					Class122.string_0,
					"\r\nSpell: ",
					Class113.string_0,
					"\r\nLast Combat: ",
					Class45.LastRan
				});
				string text = "WatchDogTimer: ";
				if (this.class71_0.DisableWatchDog)
				{
					this.Label_WatchDog.ForeColor = Color.Red;
					text += "Disabled in the options";
				}
				else
				{
					if (this.bool_2)
					{
						text += "Paused (waiting in script or not ingame)";
						this.Label_WatchDog.ForeColor = Color.OrangeRed;
					}
					else
					{
						float num = (float)(this.int_2 - Environment.TickCount);
						num *= 0.001f;
						text += "Active ({0:0.0}s)".smethod_0(num);
						this.Label_WatchDog.ForeColor = Color.DarkGreen;
					}
				}
				this.Label_WatchDog.Text = text;
			}
		}
		private void BtnActorViewer_Click(object sender, EventArgs e)
		{
			if (this.actorListViewer_0 != null)
			{
				this.actorListViewer_0.Close();
				this.actorListViewer_0.Dispose();
			}
			this.actorListViewer_0 = new ActorListViewer(false);
			this.actorListViewer_0.Show();
		}
		private void BtnPauseResume_Click(object sender, EventArgs e)
		{
			GClass0.smethod_0().method_9(!GClass0.smethod_0().method_8());
			if (GClass0.smethod_0().method_8())
			{
				if (InjectedWindow.action_2 == null)
				{
					InjectedWindow.action_2 = new Action(InjectedWindow.smethod_3);
				}
				Framework.RunInD3ContextSynced(InjectedWindow.action_2);
			}
		}
		private void BtnCurrentSpells_Click(object sender, EventArgs e)
		{
			InjectedWindow.Class125 @class = new InjectedWindow.Class125();
			if (!Framework.IsIngame)
			{
				MessageBox.Show("Only works ingame...");
			}
			else
			{
				@class.list_0 = new List<D3Spell>();
				Framework.RunInD3ContextSynced(new Action(@class.method_0));
				string text = "Your spells are listed here\r\nYou can write it like this in your spell table:\r\n\r\n";
				for (int i = 0; i < @class.list_0.Count; i++)
				{
					text += "{0},{1}\r\n".smethod_1(@class.list_0[i].D3Power.ToString(), @class.list_0[i].Rune);
				}
				text += "\r\nDon't forget to add the level in front of that list, otherwise the bot won't know on which level he should use those spells. For more information, read the table files.";
				if (this.currentSpells_0 != null)
				{
					this.currentSpells_0.Close();
				}
				this.currentSpells_0 = new CurrentSpells();
				this.currentSpells_0.OutputBox.Text = text;
				this.currentSpells_0.OutputBox.Select(0, 0);
				this.currentSpells_0.Show();
			}
		}
		private void BtnDebugLog_Click(object sender, EventArgs e)
		{
			InjectedWindow.Class126 @class = new InjectedWindow.Class126();
			@class.button_0 = (sender as Button);
			@class.button_0.Enabled = false;
			DebugMessages debugMessages = new DebugMessages();
			debugMessages.FormClosed += new FormClosedEventHandler(@class.method_0);
			debugMessages.Show();
		}
		private void Btn_Profile_ItemFactors_Click(object sender, EventArgs e)
		{
			if (this.itemFactors_0 != null)
			{
				this.itemFactors_0.Close();
				this.itemFactors_0.Dispose();
			}
			this.itemFactors_0 = new ItemFactors(this.class71_0);
			this.itemFactors_0.Show();
		}
		private void CheckBox_Profile_UseCustomItemFactors_CheckedChanged(object sender, EventArgs e)
		{
			if (this.CheckBox_Profile_UseCustomItemFactors.Checked)
			{
				this.class71_0.UseCustomItemFactors = true;
				if (this.class71_0.CustomItemFactors != null)
				{
					IEnumerable<KeyValuePair<D3Attribute, float>> arg_74_0 = this.class71_0.CustomItemFactors;
					if (InjectedWindow.func_1 == null)
					{
						InjectedWindow.func_1 = new Func<KeyValuePair<D3Attribute, float>, D3Attribute>(InjectedWindow.smethod_4);
					}
					Func<KeyValuePair<D3Attribute, float>, D3Attribute> arg_74_1 = InjectedWindow.func_1;
					if (InjectedWindow.func_2 == null)
					{
						InjectedWindow.func_2 = new Func<KeyValuePair<D3Attribute, float>, float>(InjectedWindow.smethod_5);
					}
					Class100.dictionary_1 = arg_74_0.ToDictionary(arg_74_1, InjectedWindow.func_2);
					this.class71_0.method_0();
				}
				else
				{
					this.Btn_Profile_ItemFactors_Click(null, null);
				}
			}
			else
			{
				this.class71_0.UseCustomItemFactors = false;
			}
		}
		private void CheckBoxChangeSpells_CheckedChanged(object sender, EventArgs e)
		{
			this.class71_0.ChangeSpells = this.CheckBoxChangeSpells.Checked;
			Class50.StateActive = this.class71_0.ChangeSpells;
			this.class71_0.method_0();
		}
		private void ComboBox_Profile_MinimumItemQuality_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.ComboBox_Profile_MinimumItemQuality.SelectedIndex > -1)
			{
				this.class71_0.MinimumItemRarity = (int)Enum.Parse(typeof(D3ItemRarity), this.ComboBox_Profile_MinimumItemQuality.Items[this.ComboBox_Profile_MinimumItemQuality.SelectedIndex].ToString());
				Class48.d3ItemRarity_0 = (D3ItemRarity)this.class71_0.MinimumItemRarity;
				this.class71_0.method_0();
			}
		}
		private void BtnTestMovement_Click(object sender, EventArgs e)
		{
			if (InjectedWindow.action_3 == null)
			{
				InjectedWindow.action_3 = new Action(InjectedWindow.smethod_6);
			}
			Framework.RunInD3ContextSynced(InjectedWindow.action_3);
		}
		private void BtnTestAttack_Click(object sender, EventArgs e)
		{
			new Thread(new ThreadStart(this.method_31)).Start();
		}
		private void BtnTestUI_Click(object sender, EventArgs e)
		{
			if (!Framework.IsIngame)
			{
				MessageBox.Show("Only works ingame...");
			}
			else
			{
				if (InjectedWindow.action_4 == null)
				{
					InjectedWindow.action_4 = new Action(InjectedWindow.smethod_7);
				}
				Framework.RunInD3ContextSynced(InjectedWindow.action_4);
			}
		}
		private void CheckBoxChangeEquip_CheckedChanged(object sender, EventArgs e)
		{
			this.class71_0.ChangeEquip = this.CheckBoxChangeEquip.Checked;
			this.class71_0.method_0();
		}
		private void BtnInventoryList_Click(object sender, EventArgs e)
		{
			if (this.actorListViewer_1 != null)
			{
				this.actorListViewer_1.Close();
				this.actorListViewer_1.Dispose();
			}
			this.actorListViewer_1 = new ActorListViewer(true);
			this.actorListViewer_1.Show();
		}
		private void CheckBox_SellInsteadOfSalvage_CheckedChanged(object sender, EventArgs e)
		{
			this.class71_0.SellInsteadOfSalvage = this.CheckBox_SellInsteadOfSalvage.Checked;
			this.class71_0.method_0();
		}
		private void CheckBox_AllowTakeItemsFromStash_CheckedChanged(object sender, EventArgs e)
		{
			this.class71_0.AllowToTakeOutStashItems = this.CheckBox_AllowTakeItemsFromStash.Checked;
			this.class71_0.method_0();
		}
		private void ComboBox_MaximumSellOrSalvageValue_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.ComboBox_MaximumSellOrSalvageValue.SelectedIndex > -1)
			{
				this.class71_0.MaximumSellOrSalvageValue = (int)Enum.Parse(typeof(D3ItemRarity), this.ComboBox_MaximumSellOrSalvageValue.Items[this.ComboBox_MaximumSellOrSalvageValue.SelectedIndex].ToString());
				this.class71_0.method_0();
			}
		}
		private void NumericUpDown_RestartOnXDeaths_ValueChanged(object sender, EventArgs e)
		{
			this.class71_0.RestartOnXDeaths = (int)this.NumericUpDown_RestartOnXDeaths.Value;
			this.class71_0.method_0();
		}
		private void method_17(object sender, EventArgs e)
		{
			this.method_1();
		}
		private void tabControl1_MouseDown(object sender, MouseEventArgs e)
		{
			if (!this.bool_1)
			{
				this.bool_1 = true;
				this.point_1 = base.Location;
				this.point_2 = Cursor.Position;
			}
		}
		private void tabControl1_MouseUp(object sender, MouseEventArgs e)
		{
			this.bool_1 = false;
		}
		private void tabControl1_MouseMove(object sender, MouseEventArgs e)
		{
			if (this.bool_1)
			{
				Point point = new Point(Cursor.Position.X - this.point_2.X, Cursor.Position.Y - this.point_2.Y);
				Point location = new Point(this.point_1.X + point.X, this.point_1.Y + point.Y);
				base.Location = location;
			}
		}
		private void CheckBox_AutoSnap_CheckedChanged(object sender, EventArgs e)
		{
			this.class71_0.AutoSnapToD3Window = this.CheckBox_AutoSnap.Checked;
			this.class71_0.method_0();
		}
		private void InjectedWindow_Shown(object sender, EventArgs e)
		{
			base.TopLevel = true;
			base.TopMost = true;
			base.Activate();
		}
		private void PanelContent_MouseDown(object sender, MouseEventArgs e)
		{
			this.tabControl1_MouseDown(null, null);
		}
		private void PanelContent_MouseUp(object sender, MouseEventArgs e)
		{
			this.tabControl1_MouseUp(null, null);
		}
		private void PanelContent_MouseMove(object sender, MouseEventArgs e)
		{
			this.tabControl1_MouseMove(null, null);
		}
		[DllImport("User32.dll")]
		private static extern void GetWindowThreadProcessId(IntPtr intptr_2, out int int_3);
		private void timer_1_Tick(object sender, EventArgs e)
		{
			if (this.class71_0 != null)
			{
				if (this.class71_0.AutoSnapToD3Window || this.CheckBoxToggleSize.Checked)
				{
					this.method_1();
				}
				bool flag = false;
				IntPtr foregroundWindow = InjectedWindow.GetForegroundWindow();
				if (this.intptr_1 != foregroundWindow)
				{
					flag = true;
				}
				int num = 0;
				InjectedWindow.GetWindowThreadProcessId(foregroundWindow, out num);
				bool flag2 = false;
				if (this.int_1 != num)
				{
					flag2 = true;
				}
				if (flag2 || flag)
				{
					InjectedWindow.Enum3 enum3_;
					if (foregroundWindow == this.intptr_0)
					{
						enum3_ = InjectedWindow.Enum3.const_1;
					}
					else
					{
						if (num == this.int_0)
						{
							enum3_ = InjectedWindow.Enum3.const_0;
						}
						else
						{
							enum3_ = InjectedWindow.Enum3.const_2;
						}
					}
					InjectedWindow.Enum3 enum3_2;
					if (this.intptr_1 == this.intptr_0)
					{
						enum3_2 = InjectedWindow.Enum3.const_0;
					}
					else
					{
						if (this.int_1 == this.int_0)
						{
							enum3_2 = InjectedWindow.Enum3.const_0;
						}
						else
						{
							enum3_2 = InjectedWindow.Enum3.const_2;
						}
					}
					this.method_18(enum3_2, enum3_, foregroundWindow);
					this.intptr_1 = foregroundWindow;
					this.int_1 = num;
				}
			}
		}
		private void method_18(InjectedWindow.Enum3 enum3_0, InjectedWindow.Enum3 enum3_1, IntPtr intptr_2)
		{
			if (enum3_0 == InjectedWindow.Enum3.const_0 && enum3_1 == InjectedWindow.Enum3.const_0)
			{
				if (intptr_2 != base.Handle)
				{
					base.TopMost = false;
					InjectedWindow.SetWindowPos(intptr_2, 0, 0, 0, 0, 0, 67);
				}
			}
			else
			{
				if (enum3_1 == InjectedWindow.Enum3.const_1)
				{
					if (enum3_0 == InjectedWindow.Enum3.const_0)
					{
						base.SendToBack();
						base.BringToFront();
						base.TopMost = true;
					}
					if (enum3_0 == InjectedWindow.Enum3.const_1)
					{
						this.method_19(true, false);
					}
					if (enum3_0 == InjectedWindow.Enum3.const_2)
					{
						base.SendToBack();
						base.BringToFront();
						base.TopMost = true;
					}
				}
				else
				{
					if (enum3_1 == InjectedWindow.Enum3.const_2)
					{
						this.method_19(false, false);
					}
				}
			}
		}
		private void method_19(bool bool_5, bool bool_6)
		{
			if (bool_5)
			{
				this.method_20();
				base.TopMost = true;
				base.SendToBack();
				base.BringToFront();
				if (bool_6)
				{
					base.Activate();
				}
			}
			else
			{
				base.TopMost = false;
				base.SendToBack();
			}
		}
		private void method_20()
		{
			InjectedWindow.SetWindowPos(base.Handle, this.intptr_0.ToInt32(), 0, 0, 0, 0, 67);
		}
		private void BtnRefreshView_Click(object sender, EventArgs e)
		{
			this.method_2();
		}
		private void method_21()
		{
			ThreadStart threadStart = null;
			InjectedWindow.Class89 @class = new InjectedWindow.Class89();
			@class.injectedWindow_0 = this;
			if (!this.bool_3)
			{
				bool flag = false;
				if (this.scriptEditor_0 != null && this.scriptEditor_0.Visible)
				{
					flag = true;
				}
				if (flag != this.bool_4)
				{
					this.bool_4 = flag;
					if (flag)
					{
						this.method_16("WATCHDOG: Disabled because quest editor is open");
					}
					else
					{
						this.method_16("WATCHDOG: Enabled, quest editor is closed");
					}
				}
				if (GClass0.smethod_0().method_10() == null || Environment.TickCount - Class45.LastRan < 1000 || GClass0.smethod_0().method_8() || !Framework.IsIngame || this.class71_0.DisableWatchDog || this.scriptEditor_0 != null)
				{
					this.bool_2 = false;
					this.int_2 = Environment.TickCount + this.class71_0.WatchDogTimeout * 1000;
				}
				else
				{
					if (GClass0.smethod_0().method_10().ScriptIsWaiting && Environment.TickCount - GClass0.smethod_0().method_10().LastRan < 500)
					{
						this.bool_2 = false;
						this.int_2 = Environment.TickCount + this.class71_0.WatchDogTimeout * 1000;
					}
					else
					{
						this.bool_2 = true;
						@class.vector3_0 = null;
						@class.autoResetEvent_0 = new AutoResetEvent(false);
						Framework.BeginRunInD3Context(new Action(@class.method_0));
						try
						{
							if (!@class.autoResetEvent_0.WaitOne(400))
							{
								return;
							}
						}
						catch
						{
							return;
						}
						if (!@class.vector3_0.HasValue)
						{
							this.int_2 = Environment.TickCount + this.class71_0.WatchDogTimeout * 1000;
						}
						else
						{
							float num = Vector3.Distance(@class.vector3_0.Value, this.vector3_0);
							if (num >= this.float_0)
							{
								this.vector3_0 = @class.vector3_0.Value;
								this.int_2 = Environment.TickCount + this.class71_0.WatchDogTimeout * 1000;
							}
							else
							{
								if (this.int_2 < Environment.TickCount)
								{
									this.method_16("WATCHDOG: No movement. Terminating game...");
									if (InjectedWindow.threadStart_0 == null)
									{
										InjectedWindow.threadStart_0 = new ThreadStart(InjectedWindow.smethod_8);
									}
									new Thread(InjectedWindow.threadStart_0).Start();
								}
								else
								{
									int num2 = this.int_2 - Environment.TickCount;
									if (num2 < 11000 && num2 > 6000 && !this.bool_3)
									{
										this.method_16("WATCHDOG: No movement. Trying to pause for 3 seconds.");
										this.bool_3 = true;
										if (threadStart == null)
										{
											threadStart = new ThreadStart(this.method_32);
										}
										new Thread(threadStart).Start();
									}
									if (num2 < 15000)
									{
										if (num2 < 0)
										{
											num2 = 0;
										}
										this.method_16("WATCHDOG: No movement. " + num2 / 1000);
									}
								}
							}
						}
					}
				}
			}
		}
		private void CheckBox_DisableWatchDog_CheckedChanged(object sender, EventArgs e)
		{
			this.class71_0.DisableWatchDog = this.CheckBox_DisableWatchDog.Checked;
			this.class71_0.method_0();
		}
		private void ComboBox_MinimumStashQuality_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.ComboBox_MinimumStashQuality.SelectedIndex > -1)
			{
				this.class71_0.MinimumItemQualityToStash = (int)Enum.Parse(typeof(D3ItemRarity), this.ComboBox_MinimumStashQuality.Items[this.ComboBox_MinimumStashQuality.SelectedIndex].ToString());
				this.class71_0.method_0();
			}
		}
		private void timer_2_Tick(object sender, EventArgs e)
		{
			if (Framework.IsIngame)
			{
				Class111.smethod_1();
				if (Class111.values_0 != null)
				{
					double totalHours = Class111.smethod_0().TotalHours;
					this.Label_StatsTimer.Text = "Recording Time: " + Class111.smethod_0().ToString("hh\\:mm\\:ss");
					this.Label_StatsA.Text = string.Format("Gold: {0}\nXP: {1}\nItems: {2}\nDeaths: {3}".smethod_3(new object[]
					{
						Class111.values_0.TotalLootedGold,
						Class111.values_0.TotalExperience,
						Class111.values_0.TotalLootedItems,
						Class111.values_0.TotalDeaths
					}), new object[0]);
					this.Label_StatsB.Text = string.Format("g/h:\t{0:0}\nxp/h: {1:0}\ni/hs: {2:0}\nd/h: {3:0}".smethod_3(new object[]
					{
						(double)Class111.values_0.TotalLootedGold / totalHours,
						(double)Class111.values_0.TotalExperience / totalHours,
						(double)Class111.values_0.TotalLootedItems / totalHours,
						(double)Class111.values_0.TotalDeaths / totalHours
					}), new object[0]);
				}
			}
			else
			{
				this.Label_StatsTimer.Text = "Only available ingame...";
				this.Label_StatsA.Text = "";
				this.Label_StatsB.Text = "";
			}
		}
		private void NumericUpDown_WatchDogTimeoutSeconds_ValueChanged(object sender, EventArgs e)
		{
			this.class71_0.WatchDogTimeout = (int)this.NumericUpDown_WatchDogTimeoutSeconds.Value;
			this.class71_0.method_0();
		}
		private void BtnResetStats_Click(object sender, EventArgs e)
		{
			string path = Path.Combine(Class71.string_3, Path.GetFileNameWithoutExtension(InjectedWindow.Instance.class71_0.LoadedFromFileName) + ".stats");
			if (File.Exists(path))
			{
				File.Delete(path);
			}
			Class111.smethod_5();
		}
		private void numericUpDown_MinimumGold_ValueChanged(object sender, EventArgs e)
		{
			this.class71_0.MinimumGoldToLoot = (int)this.numericUpDown_MinimumGold.Value;
			this.class71_0.method_0();
		}
		private void BtnLeaveGame_Click(object sender, EventArgs e)
		{
			if (InjectedWindow.action_5 == null)
			{
				InjectedWindow.action_5 = new Action(InjectedWindow.smethod_9);
			}
			Framework.RunInD3ContextSynced(InjectedWindow.action_5);
		}
		private void CheckboxDontPickPotions_CheckedChanged(object sender, EventArgs e)
		{
			this.class71_0.DontPickupPotions = this.CheckboxDontPickPotions.Checked;
			this.class71_0.method_0();
		}
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}
		private void InitializeComponent()
		{
			this.icontainer_0 = new Container();
			this.Btn_General_StartQuest = new Button();
			this.ComboBox_General_Quests = new ComboBox();
			this.label1 = new Label();
			this.tabControl1 = new TabControl();
			this.generalTab = new TabPage();
			this.BtnPauseResume = new Button();
			this.label4 = new Label();
			this.ListBoxLog = new ListBox();
			this.optionsTab = new TabPage();
			this.panel2 = new Panel();
			this.label10 = new Label();
			this.numericUpDown_MinimumGold = new NumericUpDown();
			this.label8 = new Label();
			this.label3 = new Label();
			this.label2 = new Label();
			this.NumericUpDown_WatchDogTimeoutSeconds = new NumericUpDown();
			this.ComboBox_MinimumStashQuality = new ComboBox();
			this.label7 = new Label();
			this.CheckBox_DisableWatchDog = new CheckBox();
			this.NumericUpDown_RestartOnXDeaths = new NumericUpDown();
			this.label13 = new Label();
			this.ComboBox_MaximumSellOrSalvageValue = new ComboBox();
			this.label12 = new Label();
			this.CheckBox_AllowTakeItemsFromStash = new CheckBox();
			this.CheckBox_SellInsteadOfSalvage = new CheckBox();
			this.CheckBoxChangeEquip = new CheckBox();
			this.ComboBox_Profile_MinimumItemQuality = new ComboBox();
			this.label18 = new Label();
			this.CheckBoxChangeSpells = new CheckBox();
			this.label16 = new Label();
			this.Btn_Profile_ItemFactors = new Button();
			this.CheckBox_Profile_UseCustomItemFactors = new CheckBox();
			this.label11 = new Label();
			this.CheckBoxAdvancedOptions = new CheckBox();
			this.comboBox_Profile_StartupQuest = new ComboBox();
			this.radioButton_DoNothing = new RadioButton();
			this.radioButton_ResumeScript = new RadioButton();
			this.radioButton_StartQuestScript = new RadioButton();
			this.QuestTab = new TabPage();
			this.BtnRefreshView = new Button();
			this.Btn_QuestTools_RenameQuest = new Button();
			this.Btn_QuestToold_DeleteQuest = new Button();
			this.BtnNewQuest = new Button();
			this.label6 = new Label();
			this.ListBox_QuestTools_AvailableQuests = new ListBox();
			this.Btn_QuestTools_EditQuest = new Button();
			this.advancedTab = new TabPage();
			this.panel1 = new Panel();
			this.BtnLeaveGame = new Button();
			this.Label_WatchDog = new Label();
			this.BtnInventoryList = new Button();
			this.BtnTestUI = new Button();
			this.LabelTargetAndSpell = new Label();
			this.BtnTestAttack = new Button();
			this.LabelWorldAndScene = new Label();
			this.BtnTestMovement = new Button();
			this.BtnDebugLog = new Button();
			this.BtnCurrentSpells = new Button();
			this.BtnActorViewer = new Button();
			this.LabelGameState = new Label();
			this.label5 = new Label();
			this.CheckBoxHoldGameActive = new CheckBox();
			this.LabelAuthStatus = new Label();
			this.label9 = new Label();
			this.BtnToolsLogin = new Button();
			this.StatsPage = new TabPage();
			this.tableLayoutPanel1 = new TableLayoutPanel();
			this.Label_StatsB = new Label();
			this.Label_StatsTimer = new Label();
			this.Label_StatsA = new Label();
			this.BtnResetStats = new Button();
			this.CheckBox_AutoSnap = new CheckBox();
			this.PanelContent = new Panel();
			this.timer_0 = new System.Windows.Forms.Timer(this.icontainer_0);
			this.CheckBoxToggleSize = new CheckBox();
			this.timer_1 = new System.Windows.Forms.Timer(this.icontainer_0);
			this.timer_2 = new System.Windows.Forms.Timer(this.icontainer_0);
			this.CheckboxDontPickPotions = new CheckBox();
			this.tabControl1.SuspendLayout();
			this.generalTab.SuspendLayout();
			this.optionsTab.SuspendLayout();
			this.panel2.SuspendLayout();
			((ISupportInitialize)this.numericUpDown_MinimumGold).BeginInit();
			((ISupportInitialize)this.NumericUpDown_WatchDogTimeoutSeconds).BeginInit();
			((ISupportInitialize)this.NumericUpDown_RestartOnXDeaths).BeginInit();
			this.QuestTab.SuspendLayout();
			this.advancedTab.SuspendLayout();
			this.panel1.SuspendLayout();
			this.StatsPage.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.PanelContent.SuspendLayout();
			base.SuspendLayout();
			this.Btn_General_StartQuest.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.Btn_General_StartQuest.Enabled = false;
			this.Btn_General_StartQuest.Location = new Point(415, 6);
			this.Btn_General_StartQuest.Name = "Btn_General_StartQuest";
			this.Btn_General_StartQuest.Size = new Size(55, 23);
			this.Btn_General_StartQuest.TabIndex = 1;
			this.Btn_General_StartQuest.Text = "Start";
			this.Btn_General_StartQuest.UseVisualStyleBackColor = true;
			this.Btn_General_StartQuest.Click += new EventHandler(this.Btn_General_StartQuest_Click);
			this.ComboBox_General_Quests.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.ComboBox_General_Quests.DropDownStyle = ComboBoxStyle.DropDownList;
			this.ComboBox_General_Quests.Enabled = false;
			this.ComboBox_General_Quests.FormattingEnabled = true;
			this.ComboBox_General_Quests.Location = new Point(55, 6);
			this.ComboBox_General_Quests.MaxDropDownItems = 20;
			this.ComboBox_General_Quests.Name = "ComboBox_General_Quests";
			this.ComboBox_General_Quests.Size = new Size(354, 21);
			this.ComboBox_General_Quests.TabIndex = 2;
			this.label1.AutoSize = true;
			this.label1.Location = new Point(11, 9);
			this.label1.Name = "label1";
			this.label1.Size = new Size(38, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Quest:";
			this.tabControl1.Controls.Add(this.generalTab);
			this.tabControl1.Controls.Add(this.optionsTab);
			this.tabControl1.Controls.Add(this.QuestTab);
			this.tabControl1.Controls.Add(this.advancedTab);
			this.tabControl1.Controls.Add(this.StatsPage);
			this.tabControl1.Dock = DockStyle.Fill;
			this.tabControl1.ItemSize = new Size(85, 18);
			this.tabControl1.Location = new Point(1, 1);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.Padding = new Point(0, 2);
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new Size(550, 235);
			this.tabControl1.SizeMode = TabSizeMode.Fixed;
			this.tabControl1.TabIndex = 4;
			this.tabControl1.MouseDown += new MouseEventHandler(this.tabControl1_MouseDown);
			this.tabControl1.MouseMove += new MouseEventHandler(this.tabControl1_MouseMove);
			this.tabControl1.MouseUp += new MouseEventHandler(this.tabControl1_MouseUp);
			this.generalTab.Controls.Add(this.BtnPauseResume);
			this.generalTab.Controls.Add(this.ComboBox_General_Quests);
			this.generalTab.Controls.Add(this.label4);
			this.generalTab.Controls.Add(this.ListBoxLog);
			this.generalTab.Controls.Add(this.Btn_General_StartQuest);
			this.generalTab.Controls.Add(this.label1);
			this.generalTab.Location = new Point(4, 22);
			this.generalTab.Name = "generalTab";
			this.generalTab.Padding = new Padding(8, 3, 8, 8);
			this.generalTab.Size = new Size(542, 174);
			this.generalTab.TabIndex = 0;
			this.generalTab.Text = "General";
			this.generalTab.UseVisualStyleBackColor = true;
			this.BtnPauseResume.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.BtnPauseResume.Location = new Point(476, 6);
			this.BtnPauseResume.Name = "BtnPauseResume";
			this.BtnPauseResume.Size = new Size(55, 23);
			this.BtnPauseResume.TabIndex = 10;
			this.BtnPauseResume.Text = "Pause";
			this.BtnPauseResume.UseVisualStyleBackColor = true;
			this.BtnPauseResume.Click += new EventHandler(this.BtnPauseResume_Click);
			this.label4.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.label4.BackColor = Color.WhiteSmoke;
			this.label4.BorderStyle = BorderStyle.FixedSingle;
			this.label4.Location = new Point(11, 147);
			this.label4.Name = "label4";
			this.label4.Padding = new Padding(6, 0, 2, 0);
			this.label4.Size = new Size(520, 18);
			this.label4.TabIndex = 9;
			this.label4.Text = "Status: Ready";
			this.label4.TextAlign = ContentAlignment.MiddleLeft;
			this.ListBoxLog.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.ListBoxLog.FormattingEnabled = true;
			this.ListBoxLog.IntegralHeight = false;
			this.ListBoxLog.Location = new Point(11, 35);
			this.ListBoxLog.Name = "ListBoxLog";
			this.ListBoxLog.Size = new Size(520, 109);
			this.ListBoxLog.TabIndex = 8;
			this.optionsTab.Controls.Add(this.panel2);
			this.optionsTab.Location = new Point(4, 22);
			this.optionsTab.Name = "optionsTab";
			this.optionsTab.Padding = new Padding(4, 4, 4, 3);
			this.optionsTab.Size = new Size(542, 209);
			this.optionsTab.TabIndex = 1;
			this.optionsTab.Text = "Profile";
			this.optionsTab.UseVisualStyleBackColor = true;
			this.panel2.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.panel2.AutoScroll = true;
			this.panel2.BorderStyle = BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.CheckboxDontPickPotions);
			this.panel2.Controls.Add(this.label10);
			this.panel2.Controls.Add(this.numericUpDown_MinimumGold);
			this.panel2.Controls.Add(this.label8);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.NumericUpDown_WatchDogTimeoutSeconds);
			this.panel2.Controls.Add(this.ComboBox_MinimumStashQuality);
			this.panel2.Controls.Add(this.label7);
			this.panel2.Controls.Add(this.CheckBox_DisableWatchDog);
			this.panel2.Controls.Add(this.NumericUpDown_RestartOnXDeaths);
			this.panel2.Controls.Add(this.label13);
			this.panel2.Controls.Add(this.ComboBox_MaximumSellOrSalvageValue);
			this.panel2.Controls.Add(this.label12);
			this.panel2.Controls.Add(this.CheckBox_AllowTakeItemsFromStash);
			this.panel2.Controls.Add(this.CheckBox_SellInsteadOfSalvage);
			this.panel2.Controls.Add(this.CheckBoxChangeEquip);
			this.panel2.Controls.Add(this.ComboBox_Profile_MinimumItemQuality);
			this.panel2.Controls.Add(this.label18);
			this.panel2.Controls.Add(this.CheckBoxChangeSpells);
			this.panel2.Controls.Add(this.label16);
			this.panel2.Controls.Add(this.Btn_Profile_ItemFactors);
			this.panel2.Controls.Add(this.CheckBox_Profile_UseCustomItemFactors);
			this.panel2.Controls.Add(this.label11);
			this.panel2.Controls.Add(this.CheckBoxAdvancedOptions);
			this.panel2.Controls.Add(this.comboBox_Profile_StartupQuest);
			this.panel2.Controls.Add(this.radioButton_DoNothing);
			this.panel2.Controls.Add(this.radioButton_ResumeScript);
			this.panel2.Controls.Add(this.radioButton_StartQuestScript);
			this.panel2.Location = new Point(7, 7);
			this.panel2.Name = "panel2";
			this.panel2.Padding = new Padding(8);
			this.panel2.Size = new Size(528, 196);
			this.panel2.TabIndex = 6;
			this.label10.AutoSize = true;
			this.label10.Location = new Point(11, 525);
			this.label10.Name = "label10";
			this.label10.Size = new Size(285, 13);
			this.label10.TabIndex = 30;
			this.label10.Text = "This will pickup only goldcoins of the above value or higher";
			this.numericUpDown_MinimumGold.Location = new Point(184, 502);
			NumericUpDown arg_D83_0 = this.numericUpDown_MinimumGold;
			int[] array = new int[4];
			array[0] = 400;
			arg_D83_0.Maximum = new decimal(array);
			this.numericUpDown_MinimumGold.Name = "numericUpDown_MinimumGold";
			this.numericUpDown_MinimumGold.Size = new Size(86, 20);
			this.numericUpDown_MinimumGold.TabIndex = 29;
			this.numericUpDown_MinimumGold.ValueChanged += new EventHandler(this.numericUpDown_MinimumGold_ValueChanged);
			this.label8.AutoSize = true;
			this.label8.Location = new Point(11, 504);
			this.label8.Name = "label8";
			this.label8.Size = new Size(167, 13);
			this.label8.TabIndex = 28;
			this.label8.Text = "Minimum gold to loot \"GoldCoins\":";
			this.label3.AutoSize = true;
			this.label3.Location = new Point(201, 134);
			this.label3.Name = "label3";
			this.label3.Size = new Size(47, 13);
			this.label3.TabIndex = 27;
			this.label3.Text = "seconds";
			this.label2.AutoSize = true;
			this.label2.Location = new Point(11, 134);
			this.label2.Name = "label2";
			this.label2.Size = new Size(103, 13);
			this.label2.TabIndex = 26;
			this.label2.Text = "WatchDog Timeout:";
			this.NumericUpDown_WatchDogTimeoutSeconds.Location = new Point(120, 132);
			NumericUpDown arg_F34_0 = this.NumericUpDown_WatchDogTimeoutSeconds;
			array = new int[4];
			array[0] = 2000;
			arg_F34_0.Maximum = new decimal(array);
			NumericUpDown arg_F51_0 = this.NumericUpDown_WatchDogTimeoutSeconds;
			array = new int[4];
			array[0] = 30;
			arg_F51_0.Minimum = new decimal(array);
			this.NumericUpDown_WatchDogTimeoutSeconds.Name = "NumericUpDown_WatchDogTimeoutSeconds";
			this.NumericUpDown_WatchDogTimeoutSeconds.Size = new Size(75, 20);
			this.NumericUpDown_WatchDogTimeoutSeconds.TabIndex = 25;
			NumericUpDown arg_F9F_0 = this.NumericUpDown_WatchDogTimeoutSeconds;
			array = new int[4];
			array[0] = 30;
			arg_F9F_0.Value = new decimal(array);
			this.NumericUpDown_WatchDogTimeoutSeconds.ValueChanged += new EventHandler(this.NumericUpDown_WatchDogTimeoutSeconds_ValueChanged);
			this.ComboBox_MinimumStashQuality.DropDownStyle = ComboBoxStyle.DropDownList;
			this.ComboBox_MinimumStashQuality.FormattingEnabled = true;
			this.ComboBox_MinimumStashQuality.Location = new Point(11, 233);
			this.ComboBox_MinimumStashQuality.Name = "ComboBox_MinimumStashQuality";
			this.ComboBox_MinimumStashQuality.Size = new Size(206, 21);
			this.ComboBox_MinimumStashQuality.TabIndex = 24;
			this.ComboBox_MinimumStashQuality.SelectedIndexChanged += new EventHandler(this.ComboBox_MinimumStashQuality_SelectedIndexChanged);
			this.label7.AutoSize = true;
			this.label7.Location = new Point(11, 217);
			this.label7.Name = "label7";
			this.label7.Size = new Size(179, 13);
			this.label7.TabIndex = 23;
			this.label7.Text = "Stash items of this quality and better:";
			this.CheckBox_DisableWatchDog.AutoSize = true;
			this.CheckBox_DisableWatchDog.Location = new Point(14, 105);
			this.CheckBox_DisableWatchDog.Name = "CheckBox_DisableWatchDog";
			this.CheckBox_DisableWatchDog.Size = new Size(318, 17);
			this.CheckBox_DisableWatchDog.TabIndex = 22;
			this.CheckBox_DisableWatchDog.Text = "Don't use WatchDogTimer (exit game if there is no movement)";
			this.CheckBox_DisableWatchDog.UseVisualStyleBackColor = true;
			this.CheckBox_DisableWatchDog.CheckedChanged += new EventHandler(this.CheckBox_DisableWatchDog_CheckedChanged);
			this.NumericUpDown_RestartOnXDeaths.Location = new Point(11, 335);
			this.NumericUpDown_RestartOnXDeaths.Name = "NumericUpDown_RestartOnXDeaths";
			this.NumericUpDown_RestartOnXDeaths.Size = new Size(99, 20);
			this.NumericUpDown_RestartOnXDeaths.TabIndex = 21;
			this.NumericUpDown_RestartOnXDeaths.ValueChanged += new EventHandler(this.NumericUpDown_RestartOnXDeaths_ValueChanged);
			this.label13.AutoSize = true;
			this.label13.Location = new Point(11, 317);
			this.label13.Name = "label13";
			this.label13.Size = new Size(195, 13);
			this.label13.TabIndex = 20;
			this.label13.Text = "Restart questscript on X deaths (0 is off)";
			this.ComboBox_MaximumSellOrSalvageValue.DropDownStyle = ComboBoxStyle.DropDownList;
			this.ComboBox_MaximumSellOrSalvageValue.FormattingEnabled = true;
			this.ComboBox_MaximumSellOrSalvageValue.Location = new Point(11, 283);
			this.ComboBox_MaximumSellOrSalvageValue.Name = "ComboBox_MaximumSellOrSalvageValue";
			this.ComboBox_MaximumSellOrSalvageValue.Size = new Size(206, 21);
			this.ComboBox_MaximumSellOrSalvageValue.TabIndex = 19;
			this.ComboBox_MaximumSellOrSalvageValue.SelectedIndexChanged += new EventHandler(this.ComboBox_MaximumSellOrSalvageValue_SelectedIndexChanged);
			this.label12.AutoSize = true;
			this.label12.Location = new Point(11, 267);
			this.label12.Name = "label12";
			this.label12.Size = new Size(216, 13);
			this.label12.TabIndex = 18;
			this.label12.Text = "Don't sell/salvage items quality this or better:";
			this.CheckBox_AllowTakeItemsFromStash.AutoSize = true;
			this.CheckBox_AllowTakeItemsFromStash.Location = new Point(11, 436);
			this.CheckBox_AllowTakeItemsFromStash.Name = "CheckBox_AllowTakeItemsFromStash";
			this.CheckBox_AllowTakeItemsFromStash.Size = new Size(237, 17);
			this.CheckBox_AllowTakeItemsFromStash.TabIndex = 17;
			this.CheckBox_AllowTakeItemsFromStash.Text = "Allow the bot to take out items from the stash";
			this.CheckBox_AllowTakeItemsFromStash.UseVisualStyleBackColor = true;
			this.CheckBox_AllowTakeItemsFromStash.CheckedChanged += new EventHandler(this.CheckBox_AllowTakeItemsFromStash_CheckedChanged);
			this.CheckBox_SellInsteadOfSalvage.AutoSize = true;
			this.CheckBox_SellInsteadOfSalvage.Location = new Point(11, 413);
			this.CheckBox_SellInsteadOfSalvage.Name = "CheckBox_SellInsteadOfSalvage";
			this.CheckBox_SellInsteadOfSalvage.Size = new Size(159, 17);
			this.CheckBox_SellInsteadOfSalvage.TabIndex = 16;
			this.CheckBox_SellInsteadOfSalvage.Text = "Sell items instead of salvage";
			this.CheckBox_SellInsteadOfSalvage.UseVisualStyleBackColor = true;
			this.CheckBox_SellInsteadOfSalvage.CheckedChanged += new EventHandler(this.CheckBox_SellInsteadOfSalvage_CheckedChanged);
			this.CheckBoxChangeEquip.AutoSize = true;
			this.CheckBoxChangeEquip.Location = new Point(11, 390);
			this.CheckBoxChangeEquip.Name = "CheckBoxChangeEquip";
			this.CheckBoxChangeEquip.Size = new Size(220, 17);
			this.CheckBoxChangeEquip.TabIndex = 15;
			this.CheckBoxChangeEquip.Text = "Allow to change Equip (by using Formula)";
			this.CheckBoxChangeEquip.UseVisualStyleBackColor = true;
			this.CheckBoxChangeEquip.CheckedChanged += new EventHandler(this.CheckBoxChangeEquip_CheckedChanged);
			this.ComboBox_Profile_MinimumItemQuality.DropDownStyle = ComboBoxStyle.DropDownList;
			this.ComboBox_Profile_MinimumItemQuality.FormattingEnabled = true;
			this.ComboBox_Profile_MinimumItemQuality.Location = new Point(11, 186);
			this.ComboBox_Profile_MinimumItemQuality.Name = "ComboBox_Profile_MinimumItemQuality";
			this.ComboBox_Profile_MinimumItemQuality.Size = new Size(206, 21);
			this.ComboBox_Profile_MinimumItemQuality.TabIndex = 14;
			this.ComboBox_Profile_MinimumItemQuality.SelectedIndexChanged += new EventHandler(this.ComboBox_Profile_MinimumItemQuality_SelectedIndexChanged);
			this.label18.AutoSize = true;
			this.label18.Location = new Point(11, 170);
			this.label18.Name = "label18";
			this.label18.Size = new Size(184, 13);
			this.label18.TabIndex = 13;
			this.label18.Text = "Only loot items of this quality or better:";
			this.CheckBoxChangeSpells.AutoSize = true;
			this.CheckBoxChangeSpells.Location = new Point(11, 367);
			this.CheckBoxChangeSpells.Name = "CheckBoxChangeSpells";
			this.CheckBoxChangeSpells.Size = new Size(237, 17);
			this.CheckBoxChangeSpells.TabIndex = 11;
			this.CheckBoxChangeSpells.Text = "Allow change of spells (by using SpellTables)";
			this.CheckBoxChangeSpells.UseVisualStyleBackColor = true;
			this.CheckBoxChangeSpells.CheckedChanged += new EventHandler(this.CheckBoxChangeSpells_CheckedChanged);
			this.label16.AutoSize = true;
			this.label16.ForeColor = SystemColors.ControlDark;
			this.label16.Location = new Point(8, 590);
			this.label16.Name = "label16";
			this.label16.Size = new Size(275, 26);
			this.label16.TabIndex = 10;
			this.label16.Text = "If this is unchecked, a generic formula will be applied,\r\nthat favors magicfind, vitality, and some other basic stats.";
			this.Btn_Profile_ItemFactors.Location = new Point(156, 564);
			this.Btn_Profile_ItemFactors.Name = "Btn_Profile_ItemFactors";
			this.Btn_Profile_ItemFactors.Size = new Size(159, 23);
			this.Btn_Profile_ItemFactors.TabIndex = 9;
			this.Btn_Profile_ItemFactors.Text = "Open Item Factors";
			this.Btn_Profile_ItemFactors.UseVisualStyleBackColor = true;
			this.Btn_Profile_ItemFactors.Click += new EventHandler(this.Btn_Profile_ItemFactors_Click);
			this.CheckBox_Profile_UseCustomItemFactors.AutoSize = true;
			this.CheckBox_Profile_UseCustomItemFactors.Location = new Point(11, 568);
			this.CheckBox_Profile_UseCustomItemFactors.Name = "CheckBox_Profile_UseCustomItemFactors";
			this.CheckBox_Profile_UseCustomItemFactors.Size = new Size(133, 17);
			this.CheckBox_Profile_UseCustomItemFactors.TabIndex = 8;
			this.CheckBox_Profile_UseCustomItemFactors.Text = "Use custom item rating";
			this.CheckBox_Profile_UseCustomItemFactors.UseVisualStyleBackColor = true;
			this.CheckBox_Profile_UseCustomItemFactors.CheckedChanged += new EventHandler(this.CheckBox_Profile_UseCustomItemFactors_CheckedChanged);
			this.label11.AutoSize = true;
			this.label11.Location = new Point(11, 8);
			this.label11.Name = "label11";
			this.label11.Size = new Size(203, 13);
			this.label11.TabIndex = 1;
			this.label11.Text = "When the game is started with this profile:";
			this.CheckBoxAdvancedOptions.AutoSize = true;
			this.CheckBoxAdvancedOptions.Location = new Point(190, 644);
			this.CheckBoxAdvancedOptions.Name = "CheckBoxAdvancedOptions";
			this.CheckBoxAdvancedOptions.Size = new Size(141, 17);
			this.CheckBoxAdvancedOptions.TabIndex = 0;
			this.CheckBoxAdvancedOptions.Text = "Show advanced options";
			this.CheckBoxAdvancedOptions.CheckedChanged += new EventHandler(this.CheckBoxAdvancedOptions_CheckedChanged);
			this.comboBox_Profile_StartupQuest.DropDownStyle = ComboBoxStyle.DropDownList;
			this.comboBox_Profile_StartupQuest.Enabled = false;
			this.comboBox_Profile_StartupQuest.FormattingEnabled = true;
			this.comboBox_Profile_StartupQuest.Location = new Point(124, 46);
			this.comboBox_Profile_StartupQuest.MaxDropDownItems = 20;
			this.comboBox_Profile_StartupQuest.Name = "comboBox_Profile_StartupQuest";
			this.comboBox_Profile_StartupQuest.Size = new Size(157, 21);
			this.comboBox_Profile_StartupQuest.TabIndex = 5;
			this.comboBox_Profile_StartupQuest.SelectedIndexChanged += new EventHandler(this.comboBox_Profile_StartupQuest_SelectedIndexChanged);
			this.radioButton_DoNothing.AutoSize = true;
			this.radioButton_DoNothing.Checked = true;
			this.radioButton_DoNothing.Location = new Point(14, 24);
			this.radioButton_DoNothing.Name = "radioButton_DoNothing";
			this.radioButton_DoNothing.Size = new Size(77, 17);
			this.radioButton_DoNothing.TabIndex = 2;
			this.radioButton_DoNothing.TabStop = true;
			this.radioButton_DoNothing.Text = "Do nothing";
			this.radioButton_DoNothing.UseVisualStyleBackColor = true;
			this.radioButton_DoNothing.CheckedChanged += new EventHandler(this.radioButton_StartQuestScript_CheckedChanged);
			this.radioButton_ResumeScript.AutoSize = true;
			this.radioButton_ResumeScript.Location = new Point(14, 70);
			this.radioButton_ResumeScript.Name = "radioButton_ResumeScript";
			this.radioButton_ResumeScript.Size = new Size(143, 17);
			this.radioButton_ResumeScript.TabIndex = 4;
			this.radioButton_ResumeScript.Text = "Resume Last Questscript";
			this.radioButton_ResumeScript.UseVisualStyleBackColor = true;
			this.radioButton_ResumeScript.CheckedChanged += new EventHandler(this.radioButton_StartQuestScript_CheckedChanged);
			this.radioButton_StartQuestScript.AutoSize = true;
			this.radioButton_StartQuestScript.Location = new Point(14, 47);
			this.radioButton_StartQuestScript.Name = "radioButton_StartQuestScript";
			this.radioButton_StartQuestScript.Size = new Size(106, 17);
			this.radioButton_StartQuestScript.TabIndex = 3;
			this.radioButton_StartQuestScript.Text = "Start Questscript:";
			this.radioButton_StartQuestScript.UseVisualStyleBackColor = true;
			this.radioButton_StartQuestScript.CheckedChanged += new EventHandler(this.radioButton_StartQuestScript_CheckedChanged);
			this.QuestTab.Controls.Add(this.BtnRefreshView);
			this.QuestTab.Controls.Add(this.Btn_QuestTools_RenameQuest);
			this.QuestTab.Controls.Add(this.Btn_QuestToold_DeleteQuest);
			this.QuestTab.Controls.Add(this.BtnNewQuest);
			this.QuestTab.Controls.Add(this.label6);
			this.QuestTab.Controls.Add(this.ListBox_QuestTools_AvailableQuests);
			this.QuestTab.Controls.Add(this.Btn_QuestTools_EditQuest);
			this.QuestTab.Location = new Point(4, 22);
			this.QuestTab.Name = "QuestTab";
			this.QuestTab.Padding = new Padding(6);
			this.QuestTab.Size = new Size(542, 174);
			this.QuestTab.TabIndex = 3;
			this.QuestTab.Text = "Quest";
			this.QuestTab.UseVisualStyleBackColor = true;
			this.BtnRefreshView.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.BtnRefreshView.Location = new Point(450, 84);
			this.BtnRefreshView.Name = "BtnRefreshView";
			this.BtnRefreshView.Size = new Size(83, 23);
			this.BtnRefreshView.TabIndex = 6;
			this.BtnRefreshView.Text = "Refresh View";
			this.BtnRefreshView.UseVisualStyleBackColor = true;
			this.BtnRefreshView.Click += new EventHandler(this.BtnRefreshView_Click);
			this.Btn_QuestTools_RenameQuest.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.Btn_QuestTools_RenameQuest.Location = new Point(450, 113);
			this.Btn_QuestTools_RenameQuest.Name = "Btn_QuestTools_RenameQuest";
			this.Btn_QuestTools_RenameQuest.Size = new Size(83, 23);
			this.Btn_QuestTools_RenameQuest.TabIndex = 5;
			this.Btn_QuestTools_RenameQuest.Text = "Rename";
			this.Btn_QuestTools_RenameQuest.UseVisualStyleBackColor = true;
			this.Btn_QuestTools_RenameQuest.Click += new EventHandler(this.Btn_QuestTools_RenameQuest_Click);
			this.Btn_QuestToold_DeleteQuest.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.Btn_QuestToold_DeleteQuest.Location = new Point(450, 142);
			this.Btn_QuestToold_DeleteQuest.Name = "Btn_QuestToold_DeleteQuest";
			this.Btn_QuestToold_DeleteQuest.Size = new Size(83, 23);
			this.Btn_QuestToold_DeleteQuest.TabIndex = 4;
			this.Btn_QuestToold_DeleteQuest.Text = "Delete";
			this.Btn_QuestToold_DeleteQuest.UseVisualStyleBackColor = true;
			this.Btn_QuestToold_DeleteQuest.Click += new EventHandler(this.Btn_QuestToold_DeleteQuest_Click);
			this.BtnNewQuest.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.BtnNewQuest.Location = new Point(450, 24);
			this.BtnNewQuest.Name = "BtnNewQuest";
			this.BtnNewQuest.Size = new Size(83, 23);
			this.BtnNewQuest.TabIndex = 3;
			this.BtnNewQuest.Text = "Create New";
			this.BtnNewQuest.UseVisualStyleBackColor = true;
			this.BtnNewQuest.Click += new EventHandler(this.BtnNewQuest_Click);
			this.label6.Location = new Point(5, 8);
			this.label6.Name = "label6";
			this.label6.Size = new Size(146, 13);
			this.label6.TabIndex = 2;
			this.label6.Text = "Available Quests:";
			this.ListBox_QuestTools_AvailableQuests.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.ListBox_QuestTools_AvailableQuests.FormattingEnabled = true;
			this.ListBox_QuestTools_AvailableQuests.IntegralHeight = false;
			this.ListBox_QuestTools_AvailableQuests.Location = new Point(8, 24);
			this.ListBox_QuestTools_AvailableQuests.Name = "ListBox_QuestTools_AvailableQuests";
			this.ListBox_QuestTools_AvailableQuests.Size = new Size(436, 141);
			this.ListBox_QuestTools_AvailableQuests.TabIndex = 1;
			this.Btn_QuestTools_EditQuest.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.Btn_QuestTools_EditQuest.Location = new Point(450, 53);
			this.Btn_QuestTools_EditQuest.Name = "Btn_QuestTools_EditQuest";
			this.Btn_QuestTools_EditQuest.Size = new Size(83, 23);
			this.Btn_QuestTools_EditQuest.TabIndex = 0;
			this.Btn_QuestTools_EditQuest.Text = "Edit";
			this.Btn_QuestTools_EditQuest.UseVisualStyleBackColor = true;
			this.Btn_QuestTools_EditQuest.Click += new EventHandler(this.Btn_QuestTools_EditQuest_Click);
			this.advancedTab.Controls.Add(this.panel1);
			this.advancedTab.Location = new Point(4, 22);
			this.advancedTab.Name = "advancedTab";
			this.advancedTab.Padding = new Padding(2);
			this.advancedTab.Size = new Size(542, 174);
			this.advancedTab.TabIndex = 2;
			this.advancedTab.Text = "Advanced";
			this.advancedTab.UseVisualStyleBackColor = true;
			this.panel1.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.panel1.AutoScroll = true;
			this.panel1.BackColor = SystemColors.Control;
			this.panel1.BorderStyle = BorderStyle.Fixed3D;
			this.panel1.Controls.Add(this.BtnLeaveGame);
			this.panel1.Controls.Add(this.Label_WatchDog);
			this.panel1.Controls.Add(this.BtnInventoryList);
			this.panel1.Controls.Add(this.BtnTestUI);
			this.panel1.Controls.Add(this.LabelTargetAndSpell);
			this.panel1.Controls.Add(this.BtnTestAttack);
			this.panel1.Controls.Add(this.LabelWorldAndScene);
			this.panel1.Controls.Add(this.BtnTestMovement);
			this.panel1.Controls.Add(this.BtnDebugLog);
			this.panel1.Controls.Add(this.BtnCurrentSpells);
			this.panel1.Controls.Add(this.BtnActorViewer);
			this.panel1.Controls.Add(this.LabelGameState);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.CheckBoxHoldGameActive);
			this.panel1.Controls.Add(this.LabelAuthStatus);
			this.panel1.Controls.Add(this.label9);
			this.panel1.Controls.Add(this.BtnToolsLogin);
			this.panel1.Location = new Point(8, 8);
			this.panel1.Margin = new Padding(6);
			this.panel1.Name = "panel1";
			this.panel1.Padding = new Padding(8);
			this.panel1.Size = new Size(526, 158);
			this.panel1.TabIndex = 11;
			this.BtnLeaveGame.Location = new Point(157, 188);
			this.BtnLeaveGame.Name = "BtnLeaveGame";
			this.BtnLeaveGame.Size = new Size(75, 23);
			this.BtnLeaveGame.TabIndex = 36;
			this.BtnLeaveGame.Text = "Leav game";
			this.BtnLeaveGame.UseVisualStyleBackColor = true;
			this.BtnLeaveGame.Click += new EventHandler(this.BtnLeaveGame_Click);
			this.Label_WatchDog.AutoSize = true;
			this.Label_WatchDog.Location = new Point(11, 363);
			this.Label_WatchDog.Name = "Label_WatchDog";
			this.Label_WatchDog.Size = new Size(92, 13);
			this.Label_WatchDog.TabIndex = 35;
			this.Label_WatchDog.Text = "WatchDogStatus:";
			this.BtnInventoryList.Location = new Point(157, 159);
			this.BtnInventoryList.Name = "BtnInventoryList";
			this.BtnInventoryList.Size = new Size(137, 23);
			this.BtnInventoryList.TabIndex = 34;
			this.BtnInventoryList.Text = "Inventory List";
			this.BtnInventoryList.UseVisualStyleBackColor = true;
			this.BtnInventoryList.Click += new EventHandler(this.BtnInventoryList_Click);
			this.BtnTestUI.Location = new Point(157, 217);
			this.BtnTestUI.Name = "BtnTestUI";
			this.BtnTestUI.Size = new Size(137, 23);
			this.BtnTestUI.TabIndex = 33;
			this.BtnTestUI.Text = "Test UI";
			this.BtnTestUI.UseVisualStyleBackColor = true;
			this.BtnTestUI.Click += new EventHandler(this.BtnTestUI_Click);
			this.LabelTargetAndSpell.AutoSize = true;
			this.LabelTargetAndSpell.Location = new Point(11, 391);
			this.LabelTargetAndSpell.Name = "LabelTargetAndSpell";
			this.LabelTargetAndSpell.Size = new Size(69, 39);
			this.LabelTargetAndSpell.TabIndex = 32;
			this.LabelTargetAndSpell.Text = "Target:\r\nSpell:\r\nLast Combat:";
			this.BtnTestAttack.Location = new Point(157, 246);
			this.BtnTestAttack.Name = "BtnTestAttack";
			this.BtnTestAttack.Size = new Size(137, 23);
			this.BtnTestAttack.TabIndex = 31;
			this.BtnTestAttack.Text = "Test Attack";
			this.BtnTestAttack.UseVisualStyleBackColor = true;
			this.BtnTestAttack.Click += new EventHandler(this.BtnTestAttack_Click);
			this.LabelWorldAndScene.AutoSize = true;
			this.LabelWorldAndScene.Location = new Point(11, 444);
			this.LabelWorldAndScene.Name = "LabelWorldAndScene";
			this.LabelWorldAndScene.Size = new Size(47, 39);
			this.LabelWorldAndScene.TabIndex = 30;
			this.LabelWorldAndScene.Text = "World:\r\nScene:\r\nPosition:";
			this.BtnTestMovement.Location = new Point(14, 246);
			this.BtnTestMovement.Name = "BtnTestMovement";
			this.BtnTestMovement.Size = new Size(137, 23);
			this.BtnTestMovement.TabIndex = 29;
			this.BtnTestMovement.Text = "Test Movement";
			this.BtnTestMovement.UseVisualStyleBackColor = true;
			this.BtnTestMovement.Click += new EventHandler(this.BtnTestMovement_Click);
			this.BtnDebugLog.Location = new Point(14, 217);
			this.BtnDebugLog.Name = "BtnDebugLog";
			this.BtnDebugLog.Size = new Size(137, 23);
			this.BtnDebugLog.TabIndex = 28;
			this.BtnDebugLog.Text = "Show Debug Log";
			this.BtnDebugLog.UseVisualStyleBackColor = true;
			this.BtnDebugLog.Click += new EventHandler(this.BtnDebugLog_Click);
			this.BtnCurrentSpells.Location = new Point(14, 188);
			this.BtnCurrentSpells.Name = "BtnCurrentSpells";
			this.BtnCurrentSpells.Size = new Size(137, 23);
			this.BtnCurrentSpells.TabIndex = 27;
			this.BtnCurrentSpells.Text = "⁬Show current spells";
			this.BtnCurrentSpells.UseVisualStyleBackColor = true;
			this.BtnCurrentSpells.Click += new EventHandler(this.BtnCurrentSpells_Click);
			this.BtnActorViewer.Location = new Point(14, 159);
			this.BtnActorViewer.Name = "BtnActorViewer";
			this.BtnActorViewer.Size = new Size(137, 23);
			this.BtnActorViewer.TabIndex = 25;
			this.BtnActorViewer.Text = "Actor List";
			this.BtnActorViewer.UseVisualStyleBackColor = true;
			this.BtnActorViewer.Click += new EventHandler(this.BtnActorViewer_Click);
			this.LabelGameState.AutoSize = true;
			this.LabelGameState.Location = new Point(11, 496);
			this.LabelGameState.Name = "LabelGameState";
			this.LabelGameState.Size = new Size(78, 13);
			this.LabelGameState.TabIndex = 21;
			this.LabelGameState.Text = "GameState: ....";
			this.label5.Location = new Point(30, 116);
			this.label5.Name = "label5";
			this.label5.Size = new Size(228, 30);
			this.label5.TabIndex = 18;
			this.label5.Text = "Override the game's check if it has focus even if the bot is not active.";
			this.CheckBoxHoldGameActive.AutoSize = true;
			this.CheckBoxHoldGameActive.Checked = true;
			this.CheckBoxHoldGameActive.CheckState = CheckState.Checked;
			this.CheckBoxHoldGameActive.Location = new Point(14, 96);
			this.CheckBoxHoldGameActive.Name = "CheckBoxHoldGameActive";
			this.CheckBoxHoldGameActive.Size = new Size(143, 17);
			this.CheckBoxHoldGameActive.TabIndex = 17;
			this.CheckBoxHoldGameActive.Text = "Always hold game active";
			this.CheckBoxHoldGameActive.UseVisualStyleBackColor = true;
			this.CheckBoxHoldGameActive.CheckedChanged += new EventHandler(this.CheckBoxHoldGameActive_CheckedChanged);
			this.LabelAuthStatus.ForeColor = SystemColors.AppWorkspace;
			this.LabelAuthStatus.Location = new Point(11, 518);
			this.LabelAuthStatus.Name = "LabelAuthStatus";
			this.LabelAuthStatus.Size = new Size(299, 18);
			this.LabelAuthStatus.TabIndex = 16;
			this.LabelAuthStatus.Text = "Authenticating...";
			this.label9.AutoSize = true;
			this.label9.Location = new Point(13, 41);
			this.label9.Name = "label9";
			this.label9.Size = new Size(253, 26);
			this.label9.TabIndex = 15;
			this.label9.Text = "Login with a specific quest, only intended for testing.\r\n(might crash the game!)";
			this.BtnToolsLogin.Location = new Point(14, 15);
			this.BtnToolsLogin.Name = "BtnToolsLogin";
			this.BtnToolsLogin.Size = new Size(198, 23);
			this.BtnToolsLogin.TabIndex = 13;
			this.BtnToolsLogin.Text = "Login with: \"The Fallen Star\"";
			this.BtnToolsLogin.UseVisualStyleBackColor = true;
			this.BtnToolsLogin.Click += new EventHandler(this.BtnToolsLogin_Click);
			this.StatsPage.Controls.Add(this.tableLayoutPanel1);
			this.StatsPage.Controls.Add(this.BtnResetStats);
			this.StatsPage.Location = new Point(4, 22);
			this.StatsPage.Name = "StatsPage";
			this.StatsPage.Padding = new Padding(3);
			this.StatsPage.Size = new Size(542, 174);
			this.StatsPage.TabIndex = 4;
			this.StatsPage.Text = "Stats";
			this.StatsPage.UseVisualStyleBackColor = true;
			this.tableLayoutPanel1.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
			this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
			this.tableLayoutPanel1.Controls.Add(this.Label_StatsB, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.Label_StatsTimer, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.Label_StatsA, 0, 1);
			this.tableLayoutPanel1.Location = new Point(6, 6);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35f));
			this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel1.Size = new Size(530, 133);
			this.tableLayoutPanel1.TabIndex = 2;
			this.Label_StatsB.Dock = DockStyle.Fill;
			this.Label_StatsB.Location = new Point(277, 47);
			this.Label_StatsB.Margin = new Padding(12);
			this.Label_StatsB.Name = "Label_StatsB";
			this.Label_StatsB.Size = new Size(241, 74);
			this.Label_StatsB.TabIndex = 2;
			this.Label_StatsB.TextAlign = ContentAlignment.MiddleLeft;
			this.tableLayoutPanel1.SetColumnSpan(this.Label_StatsTimer, 2);
			this.Label_StatsTimer.Dock = DockStyle.Fill;
			this.Label_StatsTimer.Location = new Point(3, 0);
			this.Label_StatsTimer.Name = "Label_StatsTimer";
			this.Label_StatsTimer.Size = new Size(524, 35);
			this.Label_StatsTimer.TabIndex = 0;
			this.Label_StatsTimer.Text = "Stats";
			this.Label_StatsTimer.TextAlign = ContentAlignment.MiddleCenter;
			this.Label_StatsA.Dock = DockStyle.Fill;
			this.Label_StatsA.Location = new Point(12, 47);
			this.Label_StatsA.Margin = new Padding(12);
			this.Label_StatsA.Name = "Label_StatsA";
			this.Label_StatsA.Size = new Size(241, 74);
			this.Label_StatsA.TabIndex = 1;
			this.Label_StatsA.TextAlign = ContentAlignment.MiddleLeft;
			this.BtnResetStats.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.BtnResetStats.Location = new Point(437, 145);
			this.BtnResetStats.Name = "BtnResetStats";
			this.BtnResetStats.Size = new Size(99, 23);
			this.BtnResetStats.TabIndex = 1;
			this.BtnResetStats.Text = "Reset Stats";
			this.BtnResetStats.UseVisualStyleBackColor = true;
			this.BtnResetStats.Click += new EventHandler(this.BtnResetStats_Click);
			this.CheckBox_AutoSnap.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.CheckBox_AutoSnap.AutoSize = true;
			this.CheckBox_AutoSnap.FlatStyle = FlatStyle.Flat;
			this.CheckBox_AutoSnap.Font = new Font("Consolas", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.CheckBox_AutoSnap.Location = new Point(444, 2);
			this.CheckBox_AutoSnap.Name = "CheckBox_AutoSnap";
			this.CheckBox_AutoSnap.Size = new Size(47, 17);
			this.CheckBox_AutoSnap.TabIndex = 35;
			this.CheckBox_AutoSnap.Text = "SNAP";
			this.CheckBox_AutoSnap.UseVisualStyleBackColor = true;
			this.CheckBox_AutoSnap.CheckedChanged += new EventHandler(this.CheckBox_AutoSnap_CheckedChanged);
			this.PanelContent.BackColor = SystemColors.Control;
			this.PanelContent.Controls.Add(this.tabControl1);
			this.PanelContent.Dock = DockStyle.Fill;
			this.PanelContent.Location = new Point(1, 1);
			this.PanelContent.Name = "PanelContent";
			this.PanelContent.Padding = new Padding(1);
			this.PanelContent.Size = new Size(552, 237);
			this.PanelContent.TabIndex = 5;
			this.PanelContent.MouseDown += new MouseEventHandler(this.PanelContent_MouseDown);
			this.PanelContent.MouseMove += new MouseEventHandler(this.PanelContent_MouseMove);
			this.PanelContent.MouseUp += new MouseEventHandler(this.PanelContent_MouseUp);
			this.timer_0.Enabled = true;
			this.timer_0.Interval = 150;
			this.timer_0.Tick += new EventHandler(this.timer_0_Tick);
			this.CheckBoxToggleSize.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.CheckBoxToggleSize.AutoSize = true;
			this.CheckBoxToggleSize.FlatStyle = FlatStyle.Flat;
			this.CheckBoxToggleSize.Font = new Font("Consolas", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.CheckBoxToggleSize.Location = new Point(498, 2);
			this.CheckBoxToggleSize.Name = "CheckBoxToggleSize";
			this.CheckBoxToggleSize.Size = new Size(53, 17);
			this.CheckBoxToggleSize.TabIndex = 11;
			this.CheckBoxToggleSize.Text = "SMALL";
			this.CheckBoxToggleSize.UseVisualStyleBackColor = true;
			this.CheckBoxToggleSize.CheckedChanged += new EventHandler(this.CheckBoxToggleSize_CheckedChanged);
			this.timer_1.Enabled = true;
			this.timer_1.Interval = 30;
			this.timer_1.Tick += new EventHandler(this.timer_1_Tick);
			this.timer_2.Enabled = true;
			this.timer_2.Interval = 150;
			this.timer_2.Tick += new EventHandler(this.timer_2_Tick);
			this.CheckboxDontPickPotions.AutoSize = true;
			this.CheckboxDontPickPotions.Location = new Point(11, 459);
			this.CheckboxDontPickPotions.Name = "CheckboxDontPickPotions";
			this.CheckboxDontPickPotions.Size = new Size(123, 17);
			this.CheckboxDontPickPotions.TabIndex = 31;
			this.CheckboxDontPickPotions.Text = "Don't pickup potions";
			this.CheckboxDontPickPotions.UseVisualStyleBackColor = true;
			this.CheckboxDontPickPotions.CheckedChanged += new EventHandler(this.CheckboxDontPickPotions_CheckedChanged);
			base.AutoScaleDimensions = new SizeF(6f, 13f);
		//	base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = SystemColors.Control;
			base.ClientSize = new Size(554, 239);
			base.ControlBox = false;
			base.Controls.Add(this.CheckBox_AutoSnap);
			base.Controls.Add(this.CheckBoxToggleSize);
			base.Controls.Add(this.PanelContent);
//			base.FormBorderStyle = FormBorderStyle.SizableToolWindow;
			base.HelpButton = true;
			base.MaximizeBox = false;
			this.MaximumSize = new Size(700, 650);
			base.MinimizeBox = false;
			this.MinimumSize = new Size(570, 220);
			base.Name = "InjectedWindow";
			base.Padding = new Padding(1);
			base.ShowInTaskbar = false;
//			base.SizeGripStyle = SizeGripStyle.Hide;
			base.TopMost = true;
			base.FormClosing += new FormClosingEventHandler(this.InjectedWindow_FormClosing);
			base.Load += new EventHandler(this.InjectedWindow_Load);
			base.Shown += new EventHandler(this.InjectedWindow_Shown);
			this.tabControl1.ResumeLayout(false);
			this.generalTab.ResumeLayout(false);
			this.generalTab.PerformLayout();
			this.optionsTab.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((ISupportInitialize)this.numericUpDown_MinimumGold).EndInit();
			((ISupportInitialize)this.NumericUpDown_WatchDogTimeoutSeconds).EndInit();
			((ISupportInitialize)this.NumericUpDown_RestartOnXDeaths).EndInit();
			this.QuestTab.ResumeLayout(false);
			this.advancedTab.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.StatsPage.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.PanelContent.ResumeLayout(false);
			base.ResumeLayout(false);
			base.PerformLayout();
		}
		[CompilerGenerated]
		private void method_22(Script script_0, Script script_1)
		{
			if (script_1 != null)
			{
				int num = -1;
				foreach (object current in this.ComboBox_General_Quests.Items)
				{
					if (current.ToString() == script_1.LoadedFromFileName)
					{
						this.ComboBox_General_Quests.SelectedIndex = num;
						break;
					}
					num++;
				}
			}
		}
		[CompilerGenerated]
		private void method_23()
		{
			InjectedWindow.Struct12 @struct = default(InjectedWindow.Struct12);
			while (this.class71_0 == null)
			{
				Thread.Sleep(100);
			}
			if (this.class71_0.D3Rectangle.Width != 0 && this.class71_0.D3Rectangle.Y > 0)
			{
				InjectedWindow.SetWindowPos(this.intptr_0, 0, this.class71_0.D3Rectangle.X, this.class71_0.D3Rectangle.Y, 0, 0, 277);
			}
			while (InjectedWindow.IsWindow(this.intptr_0) != 0)
			{
				InjectedWindow.GetWindowRect(this.intptr_0, ref @struct);
				Rectangle rectangle = new Rectangle(@struct.int_0, @struct.int_1, @struct.int_2 - @struct.int_0, @struct.int_3 - @struct.int_1);
				if (rectangle.Y > 0)
				{
					Rectangle arg_EC_0 = this.class71_0.D3Rectangle;
					if (rectangle != this.class71_0.D3Rectangle)
					{
						this.class71_0.D3Rectangle = rectangle;
						this.class71_0.method_0();
					}
				}
				Thread.Sleep(250);
			}
			Process.GetCurrentProcess().Kill();
		}
		[CompilerGenerated]
		private void method_24()
		{
			while (this.class71_0 == null)
			{
				Thread.Sleep(200);
			}
			while (true)
			{
				this.method_21();
				Thread.Sleep(500);
			}
		}
		[CompilerGenerated]
		private static string smethod_0(string string_0)
		{
			return Path.GetFileNameWithoutExtension(string_0);
		}
		[CompilerGenerated]
		private void method_25()
		{
			base.Activate();
			base.BringToFront();
		}
		[CompilerGenerated]
		private void method_26(object sender, FormClosedEventArgs e)
		{
			this.scriptEditor_0 = null;
			this.method_2();
			base.BeginInvoke(new MethodInvoker(this.method_27));
		}
		[CompilerGenerated]
		private void method_27()
		{
			base.Activate();
			base.BringToFront();
		}
		[CompilerGenerated]
		private static void smethod_1()
		{
			Framework.LeaveGame();
		}
		[CompilerGenerated]
		private static void smethod_2()
		{
			Framework.LeaveGame();
		}
		[CompilerGenerated]
		private void method_28(object sender, FormClosedEventArgs e)
		{
			this.scriptEditor_0 = null;
			this.method_2();
			base.BeginInvoke(new MethodInvoker(this.method_29));
		}
		[CompilerGenerated]
		private void method_29()
		{
			base.Activate();
			base.BringToFront();
		}
		[CompilerGenerated]
		private void method_30()
		{
			base.Activate();
			base.BringToFront();
		}
		[CompilerGenerated]
		private static void smethod_3()
		{
			Movement.HoldPosition();
		}
		[CompilerGenerated]
		private static D3Attribute smethod_4(KeyValuePair<D3Attribute, float> keyValuePair_0)
		{
			return keyValuePair_0.Key;
		}
		[CompilerGenerated]
		private static float smethod_5(KeyValuePair<D3Attribute, float> keyValuePair_0)
		{
			return keyValuePair_0.Value;
		}
		[CompilerGenerated]
		private static void smethod_6()
		{
			Vector3 position = Framework.Hero.Position + new Vector3(7f, 7f, 0f);
			Framework.UsePower_Position(30588u, position);
		}
		[CompilerGenerated]
		private void method_31()
		{
			int num = Environment.TickCount + 5000;
			while (Environment.TickCount < num)
			{
				Action action = null;
				InjectedWindow.Class88 @class = new InjectedWindow.Class88();
				@class.injectedWindow_0 = this;
				@class.d3Power_0 = D3Power.Invalid;
				Framework.RunInD3ContextSynced(new Action(@class.method_0));
				@class.d3Actor_0 = null;
				if (@class.d3Power_0 != D3Power.Invalid)
				{
					if (action == null)
					{
						action = new Action(@class.method_1);
					}
					Framework.RunInD3ContextSynced(action);
				}
				else
				{
					InjectedWindow.Instance.method_16("TestAttack: there is no spell that can be used...");
				}
				this.LabelTargetAndSpell.BeginInvoke(new MethodInvoker(@class.method_2));
				Thread.Sleep(150);
			}
		}
		[CompilerGenerated]
		private static void smethod_7()
		{
			Framework.CutsceneCancel();
		}
		[CompilerGenerated]
		private static void smethod_8()
		{
			Thread.Sleep(3000);
			Process.GetCurrentProcess().Kill();
		}
		[CompilerGenerated]
		private void method_32()
		{
			GClass0.smethod_0().method_9(true);
			Thread.Sleep(4000);
			GClass0.smethod_0().method_9(false);
			this.bool_3 = false;
		}
		[CompilerGenerated]
		private static void smethod_9()
		{
			Framework.LeaveGame();
		}
	}
}
