using D3Core;
using D3Core.Classes;
using HellBuddy.Scripting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
namespace ns1
{
	public class ScriptEditor : Form
	{
		[CompilerGenerated]
		private sealed class Class72
		{
			public ScriptEditor scriptEditor_0;
			public int int_0;
			public void method_0()
			{
				this.scriptEditor_0.listBox1.SelectedIndex = this.int_0;
			}
		}
		[CompilerGenerated]
		private sealed class Class73
		{
			public ScriptEditor scriptEditor_0;
			public bool bool_0;
			public void method_0()
			{
				this.scriptEditor_0.Text = "Questscript Editor - ";
				if (this.bool_0)
				{
					ScriptEditor expr_21 = this.scriptEditor_0;
					expr_21.Text += "Editting: \"";
				}
				else
				{
					ScriptEditor expr_3E = this.scriptEditor_0;
					expr_3E.Text += "Creating: \"";
				}
				ScriptEditor expr_59 = this.scriptEditor_0;
				expr_59.Text = expr_59.Text + this.scriptEditor_0.script_0.LoadedFromFileName + "\"";
				this.scriptEditor_0.listBox1.SuspendLayout();
				this.scriptEditor_0.listBox1.Items.Clear();
				foreach (ScriptActionBase current in this.scriptEditor_0.script_0.ScriptActions)
				{
					this.scriptEditor_0.listBox1.Items.Add(current);
				}
				this.scriptEditor_0.listBox1.ResumeLayout();
				D3Quest associatedStartQuest = this.scriptEditor_0.script_0.AssociatedStartQuest;
				this.scriptEditor_0.questStep1.Text = "0x" + this.scriptEditor_0.script_0.QuestStep1.ToString("X8");
				this.scriptEditor_0.questStep2.Text = "0x" + this.scriptEditor_0.script_0.QuestStep2.ToString("X8");
				string[] names = Enum.GetNames(typeof(D3Quest));
				this.scriptEditor_0.ComboBoxAssociatedQuest.Sorted = true;
				this.scriptEditor_0.ComboBoxAssociatedQuest.Items.AddRange(names);
				this.scriptEditor_0.ComboBoxAssociatedQuest.SelectedIndex = 0;
				for (int i = 0; i < this.scriptEditor_0.ComboBoxAssociatedQuest.Items.Count; i++)
				{
					string b = associatedStartQuest.ToString();
					if (this.scriptEditor_0.ComboBoxAssociatedQuest.Items[i].ToString() == b)
					{
						this.scriptEditor_0.ComboBoxAssociatedQuest.SelectedIndex = i;
						IL_23C:
						this.scriptEditor_0.script_0.OnScriptActionIndexChanged += new Action<int>(this.scriptEditor_0.method_1);
						return;
					}
				}
				
			}
		}
		[CompilerGenerated]
		private sealed class Class81
		{
			public Move move_0;
			public void method_0()
			{
				this.move_0.Target = Framework.Hero.Position;
			}
		}
		[CompilerGenerated]
		private sealed class Class75
		{
			public D3Actor d3Actor_0;
			public float float_0;
			public void method_0()
			{
				foreach (D3Actor current in Framework.Actors)
				{
					if (current.IsD3Object && current.Guid != Framework.Hero.Guid && (current.Team == D3Team.HoverableNeutral || current.Team == D3Team.Friendly))
					{
						float num = current.DistanceToHero();
						if (num < this.float_0)
						{
							this.d3Actor_0 = current;
							this.float_0 = num;
						}
					}
				}
			}
		}
		[CompilerGenerated]
		private sealed class Class76
		{
			public D3Actor d3Actor_0;
			private static Func<D3Actor, bool> func_0;
			public void method_0()
			{
				IEnumerable<D3Actor> arg_23_0 = Framework.Actors;
				if (ScriptEditor.Class76.func_0 == null)
				{
					ScriptEditor.Class76.func_0 = new Func<D3Actor, bool>(ScriptEditor.Class76.smethod_0);
				}
				this.d3Actor_0 = arg_23_0.FirstOrDefault(ScriptEditor.Class76.func_0);
			}
			private static bool smethod_0(D3Actor d3Actor_1)
			{
				return d3Actor_1.Modelname.StartsWith("Waypoint");
			}
		}
		[CompilerGenerated]
		private sealed class Class80
		{
			public string string_0;
			public Vector3 vector3_0;
			public Vector3 vector3_1;
			private static Func<Scene, bool> func_0;
			public void method_0()
			{
				this.string_0 = Framework.Scene;
				IEnumerable<Scene> arg_32_0 = Framework.Navigator.LoadedScenes;
				if (ScriptEditor.Class80.func_0 == null)
				{
					ScriptEditor.Class80.func_0 = new Func<Scene, bool>(ScriptEditor.Class80.smethod_0);
				}
				Scene scene = arg_32_0.FirstOrDefault(ScriptEditor.Class80.func_0);
				this.vector3_0 = scene.Center;
				this.vector3_1 = Framework.Hero.Position;
			}
			private static bool smethod_0(Scene scene_0)
			{
				return scene_0.SceneId == Framework.Hero.CurrentSceneId;
			}
		}
		[CompilerGenerated]
		private sealed class Class74
		{
			public D3Actor d3Actor_0;
			private static Func<D3Actor, bool> func_0;
			public void method_0()
			{
				IEnumerable<D3Actor> arg_23_0 = Framework.Actors;
				if (ScriptEditor.Class74.func_0 == null)
				{
					ScriptEditor.Class74.func_0 = new Func<D3Actor, bool>(ScriptEditor.Class74.smethod_0);
				}
				this.d3Actor_0 = arg_23_0.FirstOrDefault(ScriptEditor.Class74.func_0);
			}
			private static bool smethod_0(D3Actor d3Actor_1)
			{
				return d3Actor_1.Guid == Framework.LastHoverGUID;
			}
		}
		private Script script_0;
		private string string_0;
		private bool bool_0;
		private bool bool_1;
		private ActorListViewer actorListViewer_0 = null;
		private IContainer icontainer_0 = null;
		private ListBox listBox1;
		private Button executeBtn;
		private GroupBox groupBox1;
		private Button deleteBtn;
		private ErrorProvider errorProvider_0;
		private GroupBox groupBox4;
		private Button abortScript;
		private Button nextScriptBtn;
		private Button interactSubstringBtn;
		private Button deltaPositionBtn;
		private Button eventScriptBtn;
		private Button cancelCutsceneBtn;
		private Button findBtn;
		private Button townPortalBtn;
		private Button teleportBtn;
		private NumericUpDown waitTimeSelector;
		private Button recordSleepBtn;
		private Button recordePositionBtn;
		private Button interactHoverBtn;
		private Button interactObjectBtn;
		private Button BtnSaveAndClose;
		private Button BtnAbort;
		private ComboBox ComboBoxAssociatedQuest;
		private GroupBox groupBox2;
		private Label label2;
		private Button Btn_AwaitTransition;
		private RadioButton RadioBtn_AwaitBoth;
		private RadioButton RadioBtn_AwaitQuest;
		private RadioButton RadioBtn_AwaitWorld;
		private Button BtnBeginTransition;
		private Panel panel1;
		private Button BtnComment;
		private Button BtnFocusMob;
		private Button BtnAggroRangeOverride;
		private Button BtnLogoutAndStartQuest;
		private Label label4;
		private Label label3;
		private Label label1;
		private Label label5;
		private Button BtnQuestStepGet;
		private TextBox questStep2;
		private TextBox questStep1;
		private Label label6;
		private Button BtnTownStuff;
		private Button BtnSavepoint;
		private Button BtnMoveUp;
		private Button BtnMoveDown;
		private Button BtnUnitList;
		private Button BtnSave;
		public ScriptEditor(bool bool_2, string string_1)
		{
			this.InitializeComponent();
			this.bool_0 = bool_2;
			this.string_0 = string_1;
			this.bool_1 = bool_2;
			if (bool_2)
			{
				if (GClass0.smethod_0().method_10() == null || !(GClass0.smethod_0().method_10().LoadedFromFileName == string_1))
				{
				}
				this.script_0 = Script.LoadFromFile(string_1);
			}
			else
			{
				this.script_0 = new Script();
				this.script_0.LoadedFromFileName = string_1;
			}
		}
		internal void method_0(Script script_1, Script script_2)
		{
			try
			{
				try
				{
					if (script_1 != null)
					{
						script_1.OnScriptActionIndexChanged -= new Action<int>(this.method_1);
					}
				}
				catch
				{
				}
				if (script_2 != null)
				{
					this.string_0 = script_2.LoadedFromFileName;
					this.script_0 = script_2;
					this.method_2(false);
					InjectedWindow.Instance.method_16("ScriptEditor: Loaded new Questfile: " + script_2.LoadedFromFileName);
				}
			}
			catch
			{
			}
		}
		internal void method_1(int int_0)
		{
			MethodInvoker methodInvoker = null;
			ScriptEditor.Class72 @class = new ScriptEditor.Class72();
			@class.int_0 = int_0;
			@class.scriptEditor_0 = this;
			try
			{
				Control arg_2D_0 = this.listBox1;
				if (methodInvoker == null)
				{
					methodInvoker = new MethodInvoker(@class.method_0);
				}
				arg_2D_0.BeginInvoke(methodInvoker);
			}
			catch
			{
			}
		}
		private void method_2(bool bool_2)
		{
			ScriptEditor.Class73 @class = new ScriptEditor.Class73();
			@class.bool_0 = bool_2;
			@class.scriptEditor_0 = this;
			if (this.script_0 != null)
			{
				base.BeginInvoke(new MethodInvoker(@class.method_0));
			}
		}
		private void recordePositionBtn_Click(object sender, EventArgs e)
		{
			ScriptEditor.Class81 @class = new ScriptEditor.Class81();
			@class.move_0 = new Move();
			Framework.RunInD3ContextSynced(new Action(@class.method_0));
			this.method_3(@class.move_0);
		}
		private void deleteBtn_Click(object sender, EventArgs e)
		{
			int num = this.listBox1.SelectedIndex;
			if (num != -1)
			{
				this.script_0.ScriptActions.RemoveAt(num);
			}
			num--;
			if (num >= 0)
			{
				this.listBox1.SelectedIndex = num;
			}
			this.listBox1.TopIndex = this.listBox1.SelectedIndex + 1;
			this.listBox1.Items.Clear();
			foreach (ScriptActionBase current in this.script_0.ScriptActions)
			{
				this.listBox1.Items.Add(current);
			}
		}
		private void executeBtn_Click(object sender, EventArgs e)
		{
			int currentIndex = 0;
			if (this.listBox1.SelectedIndex >= 0 && this.listBox1.SelectedIndex < this.script_0.ScriptActions.Count)
			{
				currentIndex = this.listBox1.SelectedIndex;
			}
			GClass0.smethod_0().method_11(this.script_0);
			this.script_0.CurrentIndex = currentIndex;
		}
		private void ScriptEditor_FormClosing(object sender, FormClosingEventArgs e)
		{
			GClass0.smethod_0().method_7(new Action<Script, Script>(this.method_0));
			try
			{
				if (this.script_0 != null)
				{
					this.script_0.OnScriptActionIndexChanged -= new Action<int>(this.method_1);
				}
			}
			catch
			{
			}
			this.abortScript_Click(null, null);
			this.script_0 = null;
			GClass0.smethod_0().method_11(null);
		}
		private void recordSleepBtn_Click(object sender, EventArgs e)
		{
			float waitSeconds = (float)this.waitTimeSelector.Value;
			this.method_3(new Wait
			{
				WaitSeconds = waitSeconds,
				ScriptTime = true
			});
		}
		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (GClass0.smethod_0().method_10() == null)
			{
				this.script_0.CurrentIndex = this.listBox1.SelectedIndex;
			}
		}
		private void interactObjectBtn_Click(object sender, EventArgs e)
		{
			ScriptEditor.Class75 @class = new ScriptEditor.Class75();
			@class.d3Actor_0 = null;
			@class.float_0 = 3.40282347E+38f;
			Framework.RunInD3ContextSynced(new Action(@class.method_0));
			if (@class.d3Actor_0 != null)
			{
				this.method_3(new Interact
				{
					AllowFail = true,
					TargetSubstring = @class.d3Actor_0.Modelname.Substring(0, @class.d3Actor_0.Modelname.IndexOf('-'))
				});
			}
		}
		private void teleportBtn_Click(object sender, EventArgs e)
		{
			ScriptEditor.Class76 @class = new ScriptEditor.Class76();
			@class.d3Actor_0 = null;
			Framework.RunInD3ContextSynced(new Action(@class.method_0));
			if (@class.d3Actor_0 != null)
			{
				UseTeleporter useTeleporter = new UseTeleporter();
				StringQuery stringQuery = new StringQuery("Use Teleporter", "Which target should be used? (First Button = 0, Second Button = 1, ...)");
				if (stringQuery.ShowDialog() == DialogResult.OK)
				{
					int teleportIndex;
					if (int.TryParse(stringQuery.ResultString, out teleportIndex))
					{
						useTeleporter.TeleportIndex = teleportIndex;
						this.method_3(useTeleporter);
					}
					else
					{
						MessageBox.Show("Cannot convert \"" + stringQuery.ResultString + "\" to a number");
					}
				}
			}
			else
			{
				MessageBox.Show("The next teleporter is too far away.", "Error", MessageBoxButtons.OK);
			}
		}
		private void method_3(ScriptActionBase scriptActionBase_0)
		{
			this.listBox1.BeginUpdate();
			if (this.listBox1.SelectedIndex == -1)
			{
				this.listBox1.SelectedIndex = this.listBox1.Items.Count - 1;
			}
			this.script_0.ScriptActions.Insert(this.listBox1.SelectedIndex + 1, scriptActionBase_0);
			int selectedIndex = this.listBox1.SelectedIndex;
			this.listBox1.Items.Clear();
			foreach (ScriptActionBase current in this.script_0.ScriptActions)
			{
				this.listBox1.Items.Add(current);
			}
			this.listBox1.SelectedIndex = selectedIndex + 1;
			this.listBox1.TopIndex = this.listBox1.Items.Count - 1;
			this.listBox1.EndUpdate();
		}
		private void abortScript_Click(object sender, EventArgs e)
		{
			GClass0.smethod_0().method_14();
			GClass0.bool_3 = true;
		}
		private void townPortalBtn_Click(object sender, EventArgs e)
		{
			this.method_3(new TownPortal());
		}
		private void findBtn_Click(object sender, EventArgs e)
		{
			SelectTargetScene selectTargetScene = new SelectTargetScene();
			selectTargetScene.ShowDialog();
			if (selectTargetScene.DialogResult == DialogResult.OK)
			{
				Find find = new Find();
				find.ActorNameSubstring = selectTargetScene.ActorName;
				find.SceneNameSubstring = selectTargetScene.SceneName;
				if (find.SceneNameSubstring.Length != 0 || find.ActorNameSubstring.Length != 0)
				{
					this.method_3(find);
				}
			}
		}
		private void cancelCutsceneBtn_Click(object sender, EventArgs e)
		{
			this.method_3(new CancelCutscene());
		}
		private void deltaPositionBtn_Click(object sender, EventArgs e)
		{
			ScriptEditor.Class80 @class = new ScriptEditor.Class80();
			@class.string_0 = "";
			@class.vector3_0 = Vector3.Zero;
			@class.vector3_1 = Vector3.Zero;
			Framework.RunInD3ContextSynced(new Action(@class.method_0));
			Vector3 centerOffset = @class.vector3_1 - @class.vector3_0;
			this.method_3(new RelativeMove
			{
				CenterOffset = centerOffset,
				SceneName = @class.string_0
			});
		}
		private void interactHoverBtn_Click(object sender, EventArgs e)
		{
			ScriptEditor.Class74 @class = new ScriptEditor.Class74();
			@class.d3Actor_0 = null;
			Framework.RunInD3ContextSynced(new Action(@class.method_0));
			if (@class.d3Actor_0 != null)
			{
				this.method_3(new Interact
				{
					AllowFail = true,
					TargetSubstring = @class.d3Actor_0.Modelname.Substring(0, @class.d3Actor_0.Modelname.IndexOf('-'))
				});
			}
		}
		private void interactSubstringBtn_Click(object sender, EventArgs e)
		{
			SelectTargetActor selectTargetActor = new SelectTargetActor();
			selectTargetActor.ShowDialog();
			Interact interact = null;
			if (selectTargetActor.DialogResult == DialogResult.OK && selectTargetActor.DialogResultString.Length > 0)
			{
				interact = new Interact();
				interact.TargetSubstring = selectTargetActor.DialogResultString;
				interact.ExactMatch = selectTargetActor.DialogResultMustBeExactMatch;
				interact.AllowFail = selectTargetActor.DialogResultIgnoreErrors;
				interact.SkipBeginAwait = selectTargetActor.DialogResultSkipBeginAwait;
			}
			if (interact != null)
			{
				this.method_3(interact);
			}
		}
		private void eventScriptBtn_Click(object sender, EventArgs e)
		{
			SelectEventScript selectEventScript = new SelectEventScript();
			DialogResult dialogResult = selectEventScript.ShowDialog();
			if (dialogResult == DialogResult.OK)
			{
				this.method_3(new DispatchEventScript
				{
					EventScriptName = selectEventScript.comboBox1.SelectedItem.ToString()
				});
			}
		}
		private void nextScriptBtn_Click(object sender, EventArgs e)
		{
			StringQuery stringQuery = new StringQuery("Load Questfile", "Name of the next questfile:");
			DialogResult dialogResult = stringQuery.ShowDialog();
			if (dialogResult == DialogResult.OK)
			{
				this.method_3(new LoadNextScript
				{
					ScriptFileName = stringQuery.ResultString
				});
			}
		}
		private void ComboBoxAssociatedQuest_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				this.script_0.AssociatedStartQuest = (D3Quest)Enum.Parse(typeof(D3Quest), this.ComboBoxAssociatedQuest.SelectedItem.ToString());
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error:" + ex.Message + "\n\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				this.script_0.AssociatedStartQuest = D3Quest.A1_Q1;
			}
		}
		private void BtnAbort_Click(object sender, EventArgs e)
		{
			base.Close();
		}
		private void BtnSaveAndClose_Click(object sender, EventArgs e)
		{
			try
			{
				this.script_0.QuestStep1 = Convert.ToUInt32(this.questStep1.Text, 16);
				this.script_0.QuestStep2 = Convert.ToUInt32(this.questStep2.Text, 16);
			}
			catch
			{
				MessageBox.Show("Quest step number is invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			this.script_0.AssociatedStartQuest = (D3Quest)Enum.Parse(typeof(D3Quest), this.ComboBoxAssociatedQuest.SelectedItem as string);
			this.script_0.SaveToFile(this.string_0);
			base.Close();
		}
		private void BtnBeginTransition_Click(object sender, EventArgs e)
		{
			this.method_3(new BeginTransition());
		}
		private void Btn_AwaitTransition_Click(object sender, EventArgs e)
		{
			TransitionAwait transitionAwait = new TransitionAwait();
			if (this.RadioBtn_AwaitWorld.Checked)
			{
				transitionAwait.Type = TransitionAwait.TransitionType.World;
			}
			else
			{
				if (this.RadioBtn_AwaitQuest.Checked)
				{
					transitionAwait.Type = TransitionAwait.TransitionType.Quest;
				}
				else
				{
					transitionAwait.Type = TransitionAwait.TransitionType.Both;
				}
			}
			this.method_3(transitionAwait);
		}
		private void ScriptEditor_Load(object sender, EventArgs e)
		{
			this.script_0.OnScriptActionIndexChanged += new Action<int>(this.method_1);
			GClass0.smethod_0().method_6(new Action<Script, Script>(this.method_0));
			this.method_2(!this.bool_1);
		}
		private void BtnComment_Click(object sender, EventArgs e)
		{
			StringQuery stringQuery = new StringQuery("Enter comment", "Enter the comment you want to place");
			if (stringQuery.ShowDialog() == DialogResult.OK)
			{
				this.method_3(new ScriptComment
				{
					Text = stringQuery.ResultString
				});
			}
		}
		private void BtnFocusMob_Click(object sender, EventArgs e)
		{
			StringQuery stringQuery = new StringQuery("Enter substring", "Enter the substring of the mob, the focus should be set on");
			if (stringQuery.ShowDialog() == DialogResult.OK)
			{
				this.method_3(new SetFocusTarget
				{
					TargetSubstring = stringQuery.ResultString
				});
			}
		}
		private void BtnAggroRangeOverride_Click(object sender, EventArgs e)
		{
			OverrideAggroRangeQuery overrideAggroRangeQuery = new OverrideAggroRangeQuery();
			if (overrideAggroRangeQuery.ShowDialog() == DialogResult.OK)
			{
				this.method_3(new OverrideAggroRange
				{
					MaximumOverrideTimeSeconds = (int)overrideAggroRangeQuery.time.Value,
					NewRange = (float)((int)overrideAggroRangeQuery.newRange.Value),
					ResetOnWorldChange = overrideAggroRangeQuery.doAutoReset.Checked
				});
			}
		}
		private Color method_4(int int_0)
		{
			Color result;
			if (this.script_0 == null || int_0 == -1 || int_0 >= this.script_0.ScriptActions.Count)
			{
				result = Color.White;
			}
			else
			{
				ScriptActionBase scriptActionBase = this.script_0.ScriptActions[int_0];
				if (scriptActionBase is BeginTransition)
				{
					result = Class83.smethod_1();
				}
				else
				{
					if (scriptActionBase is TransitionAwait)
					{
						result = Class83.smethod_1();
					}
					else
					{
						if (scriptActionBase is ScriptComment)
						{
							result = Class83.smethod_6();
						}
						else
						{
							if (scriptActionBase is LogoutAndStartNewQuest)
							{
								result = Class83.smethod_12();
							}
							else
							{
								bool flag = false;
								for (int i = 0; i < int_0; i++)
								{
									if (this.script_0.ScriptActions[i] is BeginTransition)
									{
										flag = true;
									}
									if (this.script_0.ScriptActions[i] is TransitionAwait)
									{
										flag = false;
									}
								}
								if (flag)
								{
									result = Class82.smethod_2();
								}
								else
								{
									result = Color.White;
								}
							}
						}
					}
				}
			}
			return result;
		}
		private void listBox1_DrawItem(object sender, DrawItemEventArgs e)
		{
			if (e.Index >= 0)
			{
				Color color = Color.White;
				try
				{
					if (e.State.HasFlag(DrawItemState.Selected))
					{
						color = SystemColors.HotTrack;
					}
					else
					{
						color = this.method_4(e.Index);
					}
				}
				catch
				{
				}
				e.Graphics.FillRectangle(new SolidBrush(color), e.Bounds);
				e.Graphics.DrawString(this.listBox1.Items[e.Index].ToString(), e.Font, Brushes.Black, e.Bounds);
			}
		}
		private void listBox1_MouseDown(object sender, MouseEventArgs e)
		{
		}
		private void BtnLogoutAndStartQuest_Click(object sender, EventArgs e)
		{
			LogoutAndStartNewQuest logoutAndStartNewQuest = new LogoutAndStartNewQuest();
			StringQuery stringQuery = new StringQuery("Next Quest", "Enter the name of the next quest script that you want to start");
			if (stringQuery.ShowDialog() == DialogResult.OK)
			{
				logoutAndStartNewQuest.NewScriptFile = stringQuery.ResultString;
				this.method_3(logoutAndStartNewQuest);
			}
		}
		private void BtnQuestStepGet_Click(object sender, EventArgs e)
		{
			int associatedStartQuest;
			int num;
			int num2;
			D3CharSelect.GetQuestValues(out associatedStartQuest, out num, out num2);
			this.script_0.AssociatedStartQuest = (D3Quest)associatedStartQuest;
			this.script_0.QuestStep1 = (uint)num;
			this.script_0.QuestStep2 = (uint)num2;
			this.questStep1.Text = "0x" + num.ToString("X8");
			this.questStep2.Text = "0x" + num2.ToString("X8");
		}
		private void BtnTownStuff_Click(object sender, EventArgs e)
		{
			ForceTownState scriptActionBase_ = new ForceTownState();
			this.method_3(scriptActionBase_);
		}
		private void BtnSavepoint_Click(object sender, EventArgs e)
		{
			DeathSavePoint scriptActionBase_ = new DeathSavePoint();
			this.method_3(scriptActionBase_);
		}
		private void BtnMoveDown_Click(object sender, EventArgs e)
		{
			int selectedIndex = this.listBox1.SelectedIndex;
			if (selectedIndex >= 0 && selectedIndex < this.listBox1.Items.Count - 1)
			{
				ScriptActionBase item = this.script_0.ScriptActions[selectedIndex];
				this.script_0.ScriptActions.RemoveAt(selectedIndex);
				this.script_0.ScriptActions.Insert(selectedIndex + 1, item);
				this.listBox1.BeginUpdate();
				this.listBox1.Items.Clear();
				foreach (ScriptActionBase current in this.script_0.ScriptActions)
				{
					this.listBox1.Items.Add(current);
				}
				this.listBox1.EndUpdate();
				this.listBox1.SelectedIndex = selectedIndex + 1;
			}
		}
		private void BtnMoveUp_Click(object sender, EventArgs e)
		{
			int selectedIndex = this.listBox1.SelectedIndex;
			if (selectedIndex > 0 && selectedIndex <= this.listBox1.Items.Count)
			{
				ScriptActionBase item = this.script_0.ScriptActions[selectedIndex];
				this.script_0.ScriptActions.RemoveAt(selectedIndex);
				this.script_0.ScriptActions.Insert(selectedIndex - 1, item);
				this.listBox1.BeginUpdate();
				this.listBox1.Items.Clear();
				foreach (ScriptActionBase current in this.script_0.ScriptActions)
				{
					this.listBox1.Items.Add(current);
				}
				this.listBox1.EndUpdate();
				this.listBox1.SelectedIndex = selectedIndex - 1;
			}
		}
		private void BtnUnitList_Click(object sender, EventArgs e)
		{
			if (this.actorListViewer_0 != null)
			{
				this.actorListViewer_0.Close();
				this.actorListViewer_0.Dispose();
			}
			this.actorListViewer_0 = new ActorListViewer(false);
			this.actorListViewer_0.Show();
		}
		private void BtnSave_Click(object sender, EventArgs e)
		{
			try
			{
				this.script_0.QuestStep1 = Convert.ToUInt32(this.questStep1.Text, 16);
				this.script_0.QuestStep2 = Convert.ToUInt32(this.questStep2.Text, 16);
			}
			catch
			{
				MessageBox.Show("Quest step number is invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			this.script_0.AssociatedStartQuest = (D3Quest)Enum.Parse(typeof(D3Quest), this.ComboBoxAssociatedQuest.SelectedItem as string);
			this.script_0.SaveToFile(this.string_0);
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
			this.groupBox4 = new GroupBox();
			this.BtnMoveUp = new Button();
			this.BtnMoveDown = new Button();
			this.executeBtn = new Button();
			this.abortScript = new Button();
			this.listBox1 = new ListBox();
			this.deleteBtn = new Button();
			this.groupBox1 = new GroupBox();
			this.panel1 = new Panel();
			this.BtnSavepoint = new Button();
			this.BtnTownStuff = new Button();
			this.label5 = new Label();
			this.label4 = new Label();
			this.label3 = new Label();
			this.label1 = new Label();
			this.recordePositionBtn = new Button();
			this.deltaPositionBtn = new Button();
			this.BtnLogoutAndStartQuest = new Button();
			this.findBtn = new Button();
			this.BtnAggroRangeOverride = new Button();
			this.townPortalBtn = new Button();
			this.BtnFocusMob = new Button();
			this.teleportBtn = new Button();
			this.BtnComment = new Button();
			this.Btn_AwaitTransition = new Button();
			this.RadioBtn_AwaitBoth = new RadioButton();
			this.recordSleepBtn = new Button();
			this.RadioBtn_AwaitQuest = new RadioButton();
			this.interactObjectBtn = new Button();
			this.RadioBtn_AwaitWorld = new RadioButton();
			this.waitTimeSelector = new NumericUpDown();
			this.BtnBeginTransition = new Button();
			this.nextScriptBtn = new Button();
			this.interactSubstringBtn = new Button();
			this.interactHoverBtn = new Button();
			this.cancelCutsceneBtn = new Button();
			this.eventScriptBtn = new Button();
			this.errorProvider_0 = new ErrorProvider(this.icontainer_0);
			this.BtnSaveAndClose = new Button();
			this.BtnAbort = new Button();
			this.ComboBoxAssociatedQuest = new ComboBox();
			this.groupBox2 = new GroupBox();
			this.BtnQuestStepGet = new Button();
			this.questStep2 = new TextBox();
			this.questStep1 = new TextBox();
			this.label6 = new Label();
			this.label2 = new Label();
			this.BtnUnitList = new Button();
			this.BtnSave = new Button();
			this.groupBox4.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.panel1.SuspendLayout();
			((ISupportInitialize)this.waitTimeSelector).BeginInit();
			((ISupportInitialize)this.errorProvider_0).BeginInit();
			this.groupBox2.SuspendLayout();
			base.SuspendLayout();
			this.groupBox4.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.groupBox4.Controls.Add(this.BtnMoveUp);
			this.groupBox4.Controls.Add(this.BtnMoveDown);
			this.groupBox4.Controls.Add(this.executeBtn);
			this.groupBox4.Controls.Add(this.abortScript);
			this.groupBox4.Controls.Add(this.listBox1);
			this.groupBox4.Controls.Add(this.deleteBtn);
			this.groupBox4.Location = new Point(12, 70);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new Size(302, 461);
			this.groupBox4.TabIndex = 11;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Controls";
			this.BtnMoveUp.Location = new Point(246, 18);
			this.BtnMoveUp.Name = "BtnMoveUp";
			this.BtnMoveUp.Size = new Size(50, 24);
			this.BtnMoveUp.TabIndex = 8;
			this.BtnMoveUp.Text = "Up";
			this.BtnMoveUp.UseCompatibleTextRendering = true;
			this.BtnMoveUp.UseVisualStyleBackColor = true;
			this.BtnMoveUp.Click += new EventHandler(this.BtnMoveUp_Click);
			this.BtnMoveDown.Location = new Point(190, 18);
			this.BtnMoveDown.Name = "BtnMoveDown";
			this.BtnMoveDown.Size = new Size(50, 24);
			this.BtnMoveDown.TabIndex = 7;
			this.BtnMoveDown.Text = "Down";
			this.BtnMoveDown.UseCompatibleTextRendering = true;
			this.BtnMoveDown.UseVisualStyleBackColor = true;
			this.BtnMoveDown.Click += new EventHandler(this.BtnMoveDown_Click);
			this.executeBtn.Location = new Point(6, 19);
			this.executeBtn.Name = "executeBtn";
			this.executeBtn.Size = new Size(50, 24);
			this.executeBtn.TabIndex = 0;
			this.executeBtn.Text = "Play";
			this.executeBtn.UseVisualStyleBackColor = true;
			this.executeBtn.Click += new EventHandler(this.executeBtn_Click);
			this.abortScript.Location = new Point(62, 19);
			this.abortScript.Name = "abortScript";
			this.abortScript.Size = new Size(50, 24);
			this.abortScript.TabIndex = 6;
			this.abortScript.Text = "Stop";
			this.abortScript.UseVisualStyleBackColor = true;
			this.abortScript.Click += new EventHandler(this.abortScript_Click);
			this.listBox1.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.listBox1.BorderStyle = BorderStyle.FixedSingle;
			this.listBox1.DrawMode = DrawMode.OwnerDrawFixed;
			this.listBox1.Font = new Font("Consolas", 6.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.listBox1.FormattingEnabled = true;
			this.listBox1.IntegralHeight = false;
			this.listBox1.ItemHeight = 10;
			this.listBox1.Location = new Point(6, 48);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new Size(290, 407);
			this.listBox1.TabIndex = 1;
			this.listBox1.DrawItem += new DrawItemEventHandler(this.listBox1_DrawItem);
			this.listBox1.SelectedIndexChanged += new EventHandler(this.listBox1_SelectedIndexChanged);
			this.listBox1.MouseDown += new MouseEventHandler(this.listBox1_MouseDown);
			this.deleteBtn.Location = new Point(118, 19);
			this.deleteBtn.Name = "deleteBtn";
			this.deleteBtn.Size = new Size(50, 24);
			this.deleteBtn.TabIndex = 5;
			this.deleteBtn.Text = "Delete";
			this.deleteBtn.UseVisualStyleBackColor = true;
			this.deleteBtn.Click += new EventHandler(this.deleteBtn_Click);
			this.groupBox1.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right);
			this.groupBox1.Controls.Add(this.panel1);
			this.groupBox1.Location = new Point(320, 70);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new Padding(6);
			this.groupBox1.Size = new Size(242, 461);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Actions";
			this.panel1.BackColor = Color.WhiteSmoke;
			this.panel1.Controls.Add(this.BtnSavepoint);
			this.panel1.Controls.Add(this.BtnTownStuff);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.recordePositionBtn);
			this.panel1.Controls.Add(this.deltaPositionBtn);
			this.panel1.Controls.Add(this.BtnLogoutAndStartQuest);
			this.panel1.Controls.Add(this.findBtn);
			this.panel1.Controls.Add(this.BtnAggroRangeOverride);
			this.panel1.Controls.Add(this.townPortalBtn);
			this.panel1.Controls.Add(this.BtnFocusMob);
			this.panel1.Controls.Add(this.teleportBtn);
			this.panel1.Controls.Add(this.BtnComment);
			this.panel1.Controls.Add(this.Btn_AwaitTransition);
			this.panel1.Controls.Add(this.RadioBtn_AwaitBoth);
			this.panel1.Controls.Add(this.recordSleepBtn);
			this.panel1.Controls.Add(this.RadioBtn_AwaitQuest);
			this.panel1.Controls.Add(this.interactObjectBtn);
			this.panel1.Controls.Add(this.RadioBtn_AwaitWorld);
			this.panel1.Controls.Add(this.waitTimeSelector);
			this.panel1.Controls.Add(this.BtnBeginTransition);
			this.panel1.Controls.Add(this.nextScriptBtn);
			this.panel1.Controls.Add(this.interactSubstringBtn);
			this.panel1.Controls.Add(this.interactHoverBtn);
			this.panel1.Controls.Add(this.cancelCutsceneBtn);
			this.panel1.Controls.Add(this.eventScriptBtn);
			this.panel1.Dock = DockStyle.Fill;
			this.panel1.Location = new Point(6, 19);
			this.panel1.Name = "panel1";
			this.panel1.Padding = new Padding(8);
			this.panel1.Size = new Size(230, 436);
			this.panel1.TabIndex = 7;
			this.BtnSavepoint.FlatAppearance.BorderColor = SystemColors.ButtonFace;
			this.BtnSavepoint.FlatStyle = FlatStyle.Popup;
			this.BtnSavepoint.Location = new Point(117, 265);
			this.BtnSavepoint.Name = "BtnSavepoint";
			this.BtnSavepoint.Size = new Size(100, 20);
			this.BtnSavepoint.TabIndex = 36;
			this.BtnSavepoint.Text = "Savepoint";
			this.BtnSavepoint.UseCompatibleTextRendering = true;
			this.BtnSavepoint.UseVisualStyleBackColor = true;
			this.BtnSavepoint.Click += new EventHandler(this.BtnSavepoint_Click);
			this.BtnTownStuff.FlatAppearance.BorderColor = SystemColors.ButtonFace;
			this.BtnTownStuff.FlatStyle = FlatStyle.Popup;
			this.BtnTownStuff.Location = new Point(117, 81);
			this.BtnTownStuff.Name = "BtnTownStuff";
			this.BtnTownStuff.Size = new Size(100, 20);
			this.BtnTownStuff.TabIndex = 35;
			this.BtnTownStuff.Text = "Salvage / Repair";
			this.BtnTownStuff.UseCompatibleTextRendering = true;
			this.BtnTownStuff.UseVisualStyleBackColor = true;
			this.BtnTownStuff.Click += new EventHandler(this.BtnTownStuff_Click);
			this.label5.AutoSize = true;
			this.label5.Location = new Point(11, 336);
			this.label5.Name = "label5";
			this.label5.Size = new Size(43, 13);
			this.label5.TabIndex = 34;
			this.label5.Text = "Control:";
			this.label4.AutoSize = true;
			this.label4.Location = new Point(8, 194);
			this.label4.Name = "label4";
			this.label4.Size = new Size(71, 13);
			this.label4.TabIndex = 33;
			this.label4.Text = "Quest / Misc:";
			this.label3.AutoSize = true;
			this.label3.Location = new Point(11, 115);
			this.label3.Name = "label3";
			this.label3.Size = new Size(60, 13);
			this.label3.TabIndex = 32;
			this.label3.Text = "Interaction:";
			this.label1.AutoSize = true;
			this.label1.Location = new Point(11, 11);
			this.label1.Name = "label1";
			this.label1.Size = new Size(60, 13);
			this.label1.TabIndex = 31;
			this.label1.Text = "Movement:";
			this.recordePositionBtn.FlatAppearance.BorderColor = SystemColors.ButtonFace;
			this.recordePositionBtn.FlatStyle = FlatStyle.Popup;
			this.recordePositionBtn.Location = new Point(11, 29);
			this.recordePositionBtn.Name = "recordePositionBtn";
			this.recordePositionBtn.Size = new Size(100, 20);
			this.recordePositionBtn.TabIndex = 2;
			this.recordePositionBtn.Text = "Position";
			this.recordePositionBtn.UseCompatibleTextRendering = true;
			this.recordePositionBtn.UseVisualStyleBackColor = true;
			this.recordePositionBtn.Click += new EventHandler(this.recordePositionBtn_Click);
			this.deltaPositionBtn.FlatAppearance.BorderColor = SystemColors.ButtonFace;
			this.deltaPositionBtn.FlatStyle = FlatStyle.Popup;
			this.deltaPositionBtn.Location = new Point(117, 29);
			this.deltaPositionBtn.Name = "deltaPositionBtn";
			this.deltaPositionBtn.Size = new Size(100, 20);
			this.deltaPositionBtn.TabIndex = 17;
			this.deltaPositionBtn.Text = "Position Relative";
			this.deltaPositionBtn.UseCompatibleTextRendering = true;
			this.deltaPositionBtn.UseVisualStyleBackColor = true;
			this.deltaPositionBtn.Click += new EventHandler(this.deltaPositionBtn_Click);
			this.BtnLogoutAndStartQuest.FlatAppearance.BorderColor = SystemColors.ButtonFace;
			this.BtnLogoutAndStartQuest.FlatStyle = FlatStyle.Popup;
			this.BtnLogoutAndStartQuest.Location = new Point(11, 265);
			this.BtnLogoutAndStartQuest.Name = "BtnLogoutAndStartQuest";
			this.BtnLogoutAndStartQuest.Size = new Size(100, 20);
			this.BtnLogoutAndStartQuest.TabIndex = 30;
			this.BtnLogoutAndStartQuest.Text = "Start other Quest";
			this.BtnLogoutAndStartQuest.UseCompatibleTextRendering = true;
			this.BtnLogoutAndStartQuest.UseVisualStyleBackColor = true;
			this.BtnLogoutAndStartQuest.Click += new EventHandler(this.BtnLogoutAndStartQuest_Click);
			this.findBtn.FlatAppearance.BorderColor = SystemColors.ButtonFace;
			this.findBtn.FlatStyle = FlatStyle.Popup;
			this.findBtn.Location = new Point(11, 55);
			this.findBtn.Name = "findBtn";
			this.findBtn.Size = new Size(100, 20);
			this.findBtn.TabIndex = 13;
			this.findBtn.Text = "Dungeon Mode";
			this.findBtn.UseCompatibleTextRendering = true;
			this.findBtn.UseVisualStyleBackColor = true;
			this.findBtn.Click += new EventHandler(this.findBtn_Click);
			this.BtnAggroRangeOverride.FlatAppearance.BorderColor = SystemColors.ButtonFace;
			this.BtnAggroRangeOverride.FlatStyle = FlatStyle.Popup;
			this.BtnAggroRangeOverride.Location = new Point(117, 239);
			this.BtnAggroRangeOverride.Name = "BtnAggroRangeOverride";
			this.BtnAggroRangeOverride.Size = new Size(100, 20);
			this.BtnAggroRangeOverride.TabIndex = 29;
			this.BtnAggroRangeOverride.Text = "New Aggrorange";
			this.BtnAggroRangeOverride.UseCompatibleTextRendering = true;
			this.BtnAggroRangeOverride.UseVisualStyleBackColor = true;
			this.BtnAggroRangeOverride.Click += new EventHandler(this.BtnAggroRangeOverride_Click);
			this.townPortalBtn.FlatAppearance.BorderColor = SystemColors.ButtonFace;
			this.townPortalBtn.FlatStyle = FlatStyle.Popup;
			this.townPortalBtn.Location = new Point(117, 55);
			this.townPortalBtn.Name = "townPortalBtn";
			this.townPortalBtn.Size = new Size(100, 20);
			this.townPortalBtn.TabIndex = 12;
			this.townPortalBtn.Text = "Townportal";
			this.townPortalBtn.UseCompatibleTextRendering = true;
			this.townPortalBtn.UseVisualStyleBackColor = true;
			this.townPortalBtn.Click += new EventHandler(this.townPortalBtn_Click);
			this.BtnFocusMob.BackColor = Color.White;
			this.BtnFocusMob.Enabled = false;
			this.BtnFocusMob.FlatAppearance.BorderColor = SystemColors.ButtonFace;
			this.BtnFocusMob.FlatStyle = FlatStyle.Popup;
			this.BtnFocusMob.Location = new Point(117, 301);
			this.BtnFocusMob.Name = "BtnFocusMob";
			this.BtnFocusMob.Size = new Size(100, 20);
			this.BtnFocusMob.TabIndex = 28;
			this.BtnFocusMob.Text = "Set Focus-Mob";
			this.BtnFocusMob.UseCompatibleTextRendering = true;
			this.BtnFocusMob.UseVisualStyleBackColor = false;
			this.BtnFocusMob.Visible = false;
			this.BtnFocusMob.Click += new EventHandler(this.BtnFocusMob_Click);
			this.teleportBtn.FlatAppearance.BorderColor = SystemColors.ButtonFace;
			this.teleportBtn.FlatStyle = FlatStyle.Popup;
			this.teleportBtn.Location = new Point(11, 81);
			this.teleportBtn.Name = "teleportBtn";
			this.teleportBtn.Size = new Size(100, 20);
			this.teleportBtn.TabIndex = 11;
			this.teleportBtn.Text = "Use WaypointTP";
			this.teleportBtn.UseCompatibleTextRendering = true;
			this.teleportBtn.UseVisualStyleBackColor = true;
			this.teleportBtn.Click += new EventHandler(this.teleportBtn_Click);
			this.BtnComment.FlatAppearance.BorderColor = SystemColors.ButtonFace;
			this.BtnComment.FlatStyle = FlatStyle.Popup;
			this.BtnComment.Location = new Point(117, 213);
			this.BtnComment.Name = "BtnComment";
			this.BtnComment.Size = new Size(100, 20);
			this.BtnComment.TabIndex = 27;
			this.BtnComment.Text = "Comment";
			this.BtnComment.UseCompatibleTextRendering = true;
			this.BtnComment.UseVisualStyleBackColor = true;
			this.BtnComment.Click += new EventHandler(this.BtnComment_Click);
			this.Btn_AwaitTransition.BackColor = Color.DarkGray;
			this.Btn_AwaitTransition.FlatAppearance.BorderColor = SystemColors.ButtonFace;
			this.Btn_AwaitTransition.FlatStyle = FlatStyle.Popup;
			this.Btn_AwaitTransition.Location = new Point(117, 381);
			this.Btn_AwaitTransition.Name = "Btn_AwaitTransition";
			this.Btn_AwaitTransition.Size = new Size(100, 20);
			this.Btn_AwaitTransition.TabIndex = 26;
			this.Btn_AwaitTransition.Text = "Await";
			this.Btn_AwaitTransition.UseCompatibleTextRendering = true;
			this.Btn_AwaitTransition.UseVisualStyleBackColor = false;
			this.Btn_AwaitTransition.Click += new EventHandler(this.Btn_AwaitTransition_Click);
			this.RadioBtn_AwaitBoth.AutoSize = true;
			this.RadioBtn_AwaitBoth.Location = new Point(137, 408);
			this.RadioBtn_AwaitBoth.Name = "RadioBtn_AwaitBoth";
			this.RadioBtn_AwaitBoth.Size = new Size(47, 17);
			this.RadioBtn_AwaitBoth.TabIndex = 25;
			this.RadioBtn_AwaitBoth.Text = "Both";
			this.RadioBtn_AwaitBoth.UseVisualStyleBackColor = true;
			this.recordSleepBtn.FlatAppearance.BorderColor = SystemColors.ButtonFace;
			this.recordSleepBtn.FlatStyle = FlatStyle.Popup;
			this.recordSleepBtn.Location = new Point(11, 355);
			this.recordSleepBtn.Name = "recordSleepBtn";
			this.recordSleepBtn.Size = new Size(100, 20);
			this.recordSleepBtn.TabIndex = 5;
			this.recordSleepBtn.Text = "Delay";
			this.recordSleepBtn.UseCompatibleTextRendering = true;
			this.recordSleepBtn.UseVisualStyleBackColor = true;
			this.recordSleepBtn.Click += new EventHandler(this.recordSleepBtn_Click);
			this.RadioBtn_AwaitQuest.AutoSize = true;
			this.RadioBtn_AwaitQuest.Location = new Point(78, 408);
			this.RadioBtn_AwaitQuest.Name = "RadioBtn_AwaitQuest";
			this.RadioBtn_AwaitQuest.Size = new Size(53, 17);
			this.RadioBtn_AwaitQuest.TabIndex = 24;
			this.RadioBtn_AwaitQuest.Text = "Quest";
			this.RadioBtn_AwaitQuest.UseVisualStyleBackColor = true;
			this.interactObjectBtn.FlatAppearance.BorderColor = SystemColors.ButtonFace;
			this.interactObjectBtn.FlatStyle = FlatStyle.Popup;
			this.interactObjectBtn.Location = new Point(11, 133);
			this.interactObjectBtn.Name = "interactObjectBtn";
			this.interactObjectBtn.Size = new Size(100, 20);
			this.interactObjectBtn.TabIndex = 7;
			this.interactObjectBtn.Text = "Nearest";
			this.interactObjectBtn.UseCompatibleTextRendering = true;
			this.interactObjectBtn.UseVisualStyleBackColor = true;
			this.interactObjectBtn.Click += new EventHandler(this.interactObjectBtn_Click);
			this.RadioBtn_AwaitWorld.AutoSize = true;
			this.RadioBtn_AwaitWorld.Checked = true;
			this.RadioBtn_AwaitWorld.Location = new Point(19, 407);
			this.RadioBtn_AwaitWorld.Name = "RadioBtn_AwaitWorld";
			this.RadioBtn_AwaitWorld.Size = new Size(53, 17);
			this.RadioBtn_AwaitWorld.TabIndex = 23;
			this.RadioBtn_AwaitWorld.TabStop = true;
			this.RadioBtn_AwaitWorld.Text = "World";
			this.RadioBtn_AwaitWorld.UseVisualStyleBackColor = true;
			this.waitTimeSelector.DecimalPlaces = 1;
			this.waitTimeSelector.Increment = new decimal(new int[]
			{
				1,
				0,
				0,
				65536
			});
			this.waitTimeSelector.Location = new Point(117, 355);
			NumericUpDown arg_16F2_0 = this.waitTimeSelector;
			int[] array = new int[4];
			array[0] = 60;
			arg_16F2_0.Maximum = new decimal(array);
			this.waitTimeSelector.Minimum = new decimal(new int[]
			{
				1,
				0,
				0,
				65536
			});
			this.waitTimeSelector.Name = "waitTimeSelector";
			this.waitTimeSelector.Size = new Size(52, 20);
			this.waitTimeSelector.TabIndex = 9;
			this.waitTimeSelector.Value = new decimal(new int[]
			{
				5,
				0,
				0,
				65536
			});
			this.BtnBeginTransition.BackColor = Color.DarkGray;
			this.BtnBeginTransition.FlatAppearance.BorderColor = SystemColors.ButtonFace;
			this.BtnBeginTransition.FlatStyle = FlatStyle.Popup;
			this.BtnBeginTransition.Location = new Point(11, 381);
			this.BtnBeginTransition.Name = "BtnBeginTransition";
			this.BtnBeginTransition.Size = new Size(100, 20);
			this.BtnBeginTransition.TabIndex = 22;
			this.BtnBeginTransition.Text = "Begin";
			this.BtnBeginTransition.UseCompatibleTextRendering = true;
			this.BtnBeginTransition.UseVisualStyleBackColor = false;
			this.BtnBeginTransition.Click += new EventHandler(this.BtnBeginTransition_Click);
			this.nextScriptBtn.FlatAppearance.BorderColor = SystemColors.ButtonFace;
			this.nextScriptBtn.FlatStyle = FlatStyle.Popup;
			this.nextScriptBtn.Location = new Point(11, 239);
			this.nextScriptBtn.Name = "nextScriptBtn";
			this.nextScriptBtn.Size = new Size(100, 20);
			this.nextScriptBtn.TabIndex = 20;
			this.nextScriptBtn.Text = "Continue Quest";
			this.nextScriptBtn.UseCompatibleTextRendering = true;
			this.nextScriptBtn.UseVisualStyleBackColor = true;
			this.nextScriptBtn.Click += new EventHandler(this.nextScriptBtn_Click);
			this.interactSubstringBtn.FlatAppearance.BorderColor = SystemColors.ButtonFace;
			this.interactSubstringBtn.FlatStyle = FlatStyle.Popup;
			this.interactSubstringBtn.Location = new Point(117, 159);
			this.interactSubstringBtn.Name = "interactSubstringBtn";
			this.interactSubstringBtn.Size = new Size(100, 20);
			this.interactSubstringBtn.TabIndex = 19;
			this.interactSubstringBtn.Text = "By Name";
			this.interactSubstringBtn.UseCompatibleTextRendering = true;
			this.interactSubstringBtn.UseVisualStyleBackColor = true;
			this.interactSubstringBtn.Click += new EventHandler(this.interactSubstringBtn_Click);
			this.interactHoverBtn.FlatAppearance.BorderColor = SystemColors.ButtonFace;
			this.interactHoverBtn.FlatStyle = FlatStyle.Popup;
			this.interactHoverBtn.Location = new Point(11, 157);
			this.interactHoverBtn.Name = "interactHoverBtn";
			this.interactHoverBtn.Size = new Size(100, 20);
			this.interactHoverBtn.TabIndex = 18;
			this.interactHoverBtn.Text = "Last selected";
			this.interactHoverBtn.UseCompatibleTextRendering = true;
			this.interactHoverBtn.UseVisualStyleBackColor = true;
			this.interactHoverBtn.Click += new EventHandler(this.interactHoverBtn_Click);
			this.cancelCutsceneBtn.FlatAppearance.BorderColor = SystemColors.ButtonFace;
			this.cancelCutsceneBtn.FlatStyle = FlatStyle.Popup;
			this.cancelCutsceneBtn.Location = new Point(117, 133);
			this.cancelCutsceneBtn.Name = "cancelCutsceneBtn";
			this.cancelCutsceneBtn.Size = new Size(100, 20);
			this.cancelCutsceneBtn.TabIndex = 15;
			this.cancelCutsceneBtn.Text = "Skip Dialog";
			this.cancelCutsceneBtn.UseCompatibleTextRendering = true;
			this.cancelCutsceneBtn.UseVisualStyleBackColor = true;
			this.cancelCutsceneBtn.Click += new EventHandler(this.cancelCutsceneBtn_Click);
			this.eventScriptBtn.FlatAppearance.BorderColor = SystemColors.ButtonFace;
			this.eventScriptBtn.FlatStyle = FlatStyle.Popup;
			this.eventScriptBtn.Location = new Point(11, 213);
			this.eventScriptBtn.Name = "eventScriptBtn";
			this.eventScriptBtn.Size = new Size(100, 20);
			this.eventScriptBtn.TabIndex = 16;
			this.eventScriptBtn.Text = "Hardcoded Script";
			this.eventScriptBtn.UseCompatibleTextRendering = true;
			this.eventScriptBtn.UseVisualStyleBackColor = true;
			this.eventScriptBtn.Click += new EventHandler(this.eventScriptBtn_Click);
			this.errorProvider_0.ContainerControl = this;
			this.BtnSaveAndClose.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.BtnSaveAndClose.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Underline, GraphicsUnit.Point, 0);
			this.BtnSaveAndClose.Location = new Point(436, 537);
			this.BtnSaveAndClose.Name = "BtnSaveAndClose";
			this.BtnSaveAndClose.Size = new Size(126, 23);
			this.BtnSaveAndClose.TabIndex = 1;
			this.BtnSaveAndClose.Text = "Save and Close";
			this.BtnSaveAndClose.UseVisualStyleBackColor = true;
			this.BtnSaveAndClose.Click += new EventHandler(this.BtnSaveAndClose_Click);
			this.BtnAbort.Anchor = AnchorStyles.Bottom;
			this.BtnAbort.Location = new Point(204, 537);
			this.BtnAbort.Name = "BtnAbort";
			this.BtnAbort.Size = new Size(80, 23);
			this.BtnAbort.TabIndex = 2;
			this.BtnAbort.Text = "Cancel";
			this.BtnAbort.UseVisualStyleBackColor = true;
			this.BtnAbort.Click += new EventHandler(this.BtnAbort_Click);
			this.ComboBoxAssociatedQuest.DropDownStyle = ComboBoxStyle.DropDownList;
			this.ComboBoxAssociatedQuest.FormattingEnabled = true;
			this.ComboBoxAssociatedQuest.Location = new Point(85, 21);
			this.ComboBoxAssociatedQuest.Name = "ComboBoxAssociatedQuest";
			this.ComboBoxAssociatedQuest.Size = new Size(149, 21);
			this.ComboBoxAssociatedQuest.TabIndex = 3;
			this.ComboBoxAssociatedQuest.SelectedIndexChanged += new EventHandler(this.ComboBoxAssociatedQuest_SelectedIndexChanged);
			this.groupBox2.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.groupBox2.Controls.Add(this.BtnQuestStepGet);
			this.groupBox2.Controls.Add(this.questStep2);
			this.groupBox2.Controls.Add(this.questStep1);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.ComboBoxAssociatedQuest);
			this.groupBox2.Location = new Point(12, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new Size(550, 52);
			this.groupBox2.TabIndex = 5;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Select the quest";
			this.BtnQuestStepGet.Location = new Point(489, 19);
			this.BtnQuestStepGet.Name = "BtnQuestStepGet";
			this.BtnQuestStepGet.Size = new Size(40, 23);
			this.BtnQuestStepGet.TabIndex = 7;
			this.BtnQuestStepGet.Text = "Get";
			this.BtnQuestStepGet.UseVisualStyleBackColor = true;
			this.BtnQuestStepGet.Click += new EventHandler(this.BtnQuestStepGet_Click);
			this.questStep2.Font = new Font("Lucida Console", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.questStep2.Location = new Point(405, 22);
			this.questStep2.Name = "questStep2";
			this.questStep2.Size = new Size(78, 18);
			this.questStep2.TabIndex = 6;
			this.questStep2.Text = "0x000000FF";
			this.questStep1.Font = new Font("Lucida Console", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.questStep1.Location = new Point(321, 22);
			this.questStep1.Name = "questStep1";
			this.questStep1.Size = new Size(78, 18);
			this.questStep1.TabIndex = 5;
			this.questStep1.Text = "0xFFFFFF00";
			this.label6.AutoSize = true;
			this.label6.Location = new Point(252, 24);
			this.label6.Name = "label6";
			this.label6.Size = new Size(63, 13);
			this.label6.TabIndex = 4;
			this.label6.Text = "Quest Step:";
			this.label2.AutoSize = true;
			this.label2.Location = new Point(16, 24);
			this.label2.Name = "label2";
			this.label2.Size = new Size(63, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "Start Quest:";
			this.BtnUnitList.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.BtnUnitList.BackColor = Color.FromArgb(128, 255, 128);
			this.BtnUnitList.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.BtnUnitList.Location = new Point(12, 537);
			this.BtnUnitList.Name = "BtnUnitList";
			this.BtnUnitList.Size = new Size(112, 23);
			this.BtnUnitList.TabIndex = 12;
			this.BtnUnitList.Text = "Unit List";
			this.BtnUnitList.UseVisualStyleBackColor = false;
			this.BtnUnitList.Click += new EventHandler(this.BtnUnitList_Click);
			this.BtnSave.Anchor = AnchorStyles.Bottom;
			this.BtnSave.Location = new Point(290, 537);
			this.BtnSave.Name = "BtnSave";
			this.BtnSave.Size = new Size(80, 23);
			this.BtnSave.TabIndex = 13;
			this.BtnSave.Text = "Save";
			this.BtnSave.UseVisualStyleBackColor = true;
			this.BtnSave.Click += new EventHandler(this.BtnSave_Click);
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(574, 572);
			base.Controls.Add(this.BtnSave);
			base.Controls.Add(this.BtnUnitList);
			base.Controls.Add(this.groupBox4);
			base.Controls.Add(this.groupBox2);
			base.Controls.Add(this.groupBox1);
			base.Controls.Add(this.BtnAbort);
			base.Controls.Add(this.BtnSaveAndClose);
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			this.MinimumSize = new Size(590, 610);
			base.Name = "ScriptEditor";
			base.ShowIcon = false;
			base.StartPosition = FormStartPosition.Manual;
			this.Text = "Quest Editor";
			base.FormClosing += new FormClosingEventHandler(this.ScriptEditor_FormClosing);
			base.Load += new EventHandler(this.ScriptEditor_Load);
			this.groupBox4.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((ISupportInitialize)this.waitTimeSelector).EndInit();
			((ISupportInitialize)this.errorProvider_0).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			base.ResumeLayout(false);
		}
	}
}
