using D3Core;
using D3Core.Classes;
using Newtonsoft.Json;
using ns1;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Windows.Forms;
namespace HellBuddy.Scripting
{
	[JsonObject(MemberSerialization.OptIn)]
	[Serializable]
	public class Script
	{
		[CompilerGenerated]
		private sealed class Class87
		{
			public Interact interact_0;
			public bool method_0(D3Actor d3Actor_0)
			{
				return d3Actor_0.Modelname.Substring(0, d3Actor_0.Modelname.IndexOf('-')) == this.interact_0.TargetSubstring;
			}
			public bool method_1(D3Actor d3Actor_0)
			{
				return d3Actor_0.Modelname.Contains(this.interact_0.TargetSubstring);
			}
		}
		[CompilerGenerated]
		private sealed class Class86
		{
			public RelativeMove relativeMove_0;
			public bool method_0(Scene scene_0)
			{
				return scene_0.SNOName.Contains(this.relativeMove_0.SceneName);
			}
		}
		[CompilerGenerated]
		private sealed class Class85
		{
			public DispatchEventScript dispatchEventScript_0;
			public bool method_0(Class57 class57_0)
			{
				return class57_0.vmethod_0().Contains(this.dispatchEventScript_0.EventScriptName);
			}
		}
		public static readonly string FileExtension = ".quest";
		[JsonProperty]
		internal List<ScriptActionBase> ScriptActions;
		[NonSerialized]
		private static string _baseDirectory = null;
		private int currentIndex = 0;
		private Dictionary<Type, Func<ScriptActionBase, bool>> ScriptHandlers = new Dictionary<Type, Func<ScriptActionBase, bool>>();
		[NonSerialized]
		private int timeoutEnd = 0;
		[NonSerialized]
		private int skipDialog = 0;
		[NonSerialized]
		private int remainingScriptTimeWait = 0;
		[NonSerialized]
		private int lastTick = 0;
		[NonSerialized]
		private bool lastStepCompleted = false;
		[NonSerialized]
		private Class61 currentTransition = null;
		internal event Action<Script> OnScriptCompleted;
		internal event Action<int> OnScriptActionIndexChanged;
		[JsonProperty]
		public D3Quest AssociatedStartQuest
		{
			get;
			set;
		}
		[JsonProperty]
		public uint QuestStep1
		{
			get;
			set;
		}
		[JsonProperty]
		public uint QuestStep2
		{
			get;
			set;
		}
		internal static string ScriptBaseDirectory
		{
			get
			{
				if (Script._baseDirectory == null)
				{
					Script._baseDirectory = Path.Combine(Path.GetTempPath(), "HellBuddy\\Quests");
					if (!Directory.Exists(Script._baseDirectory))
					{
						Directory.CreateDirectory(Script._baseDirectory);
					}
				}
				return Script._baseDirectory;
			}
		}
		internal int CurrentIndex
		{
			get
			{
				return this.currentIndex;
			}
			set
			{
				this.currentIndex = value;
				if (this.currentIndex >= 0 && this.currentIndex < this.ScriptActions.Count && this.OnScriptActionIndexChanged != null)
				{
					this.OnScriptActionIndexChanged(value);
				}
			}
		}
		internal bool ScriptFinished
		{
			get
			{
				return this.CurrentIndex >= this.ScriptActions.Count;
			}
		}
		internal static string LastLoadedFileName
		{
			get;
			set;
		}
		public string LoadedFromFileName
		{
			get;
			set;
		}
		internal bool ScriptIsWaiting
		{
			get
			{
				return this.remainingScriptTimeWait > 0;
			}
		}
		internal DateTime ScriptStartedTime
		{
			get;
			set;
		}
		public int LastRan
		{
			get;
			private set;
		}
		public int DeathCounter
		{
			get;
			set;
		}
		[JsonConstructor]
		internal Script()
		{
			this.AssociatedStartQuest = D3Quest.A1_Q1;
			this.ScriptActions = new List<ScriptActionBase>();
			Dictionary<Type, Func<ScriptActionBase, bool>> arg_A8_0 = this.ScriptHandlers;
			Type arg_A8_1 = typeof(Move);
			Func<ScriptActionBase, bool> value = (ScriptActionBase cmd) => this.MoveHandler((Move)cmd);
			arg_A8_0.Add(arg_A8_1, value);
			Dictionary<Type, Func<ScriptActionBase, bool>> arg_CB_0 = this.ScriptHandlers;
			Type arg_CB_1 = typeof(Interact);
			Func<ScriptActionBase, bool> value2 = (ScriptActionBase cmd) => this.InteractHandler((Interact)cmd);
			arg_CB_0.Add(arg_CB_1, value2);
			Dictionary<Type, Func<ScriptActionBase, bool>> arg_EE_0 = this.ScriptHandlers;
			Type arg_EE_1 = typeof(Wait);
			Func<ScriptActionBase, bool> value3 = (ScriptActionBase cmd) => this.WaitHandler((Wait)cmd);
			arg_EE_0.Add(arg_EE_1, value3);
			Dictionary<Type, Func<ScriptActionBase, bool>> arg_111_0 = this.ScriptHandlers;
			Type arg_111_1 = typeof(UseTeleporter);
			Func<ScriptActionBase, bool> value4 = (ScriptActionBase cmd) => this.UseWaypointHandler((UseTeleporter)cmd);
			arg_111_0.Add(arg_111_1, value4);
			Dictionary<Type, Func<ScriptActionBase, bool>> arg_136_0 = this.ScriptHandlers;
			Type arg_136_1 = typeof(TownPortal);
			Func<ScriptActionBase, bool> value5 = (ScriptActionBase cmd) => this.TownPortalHandler((TownPortal)cmd);
			arg_136_0.Add(arg_136_1, value5);
			Dictionary<Type, Func<ScriptActionBase, bool>> arg_15B_0 = this.ScriptHandlers;
			Type arg_15B_1 = typeof(ForceTownState);
			Func<ScriptActionBase, bool> value6 = (ScriptActionBase cmd) => this.ForceTownStateHandler((ForceTownState)cmd);
			arg_15B_0.Add(arg_15B_1, value6);
			Dictionary<Type, Func<ScriptActionBase, bool>> arg_180_0 = this.ScriptHandlers;
			Type arg_180_1 = typeof(Find);
			Func<ScriptActionBase, bool> value7 = (ScriptActionBase cmd) => this.FindHandler((Find)cmd);
			arg_180_0.Add(arg_180_1, value7);
			Dictionary<Type, Func<ScriptActionBase, bool>> arg_1A5_0 = this.ScriptHandlers;
			Type arg_1A5_1 = typeof(CancelCutscene);
			Func<ScriptActionBase, bool> value8 = (ScriptActionBase cmd) => this.CancelCutsceneHandler((CancelCutscene)cmd);
			arg_1A5_0.Add(arg_1A5_1, value8);
			Dictionary<Type, Func<ScriptActionBase, bool>> arg_1CA_0 = this.ScriptHandlers;
			Type arg_1CA_1 = typeof(RelativeMove);
			Func<ScriptActionBase, bool> value9 = (ScriptActionBase cmd) => this.RelativeMoveHandler((RelativeMove)cmd);
			arg_1CA_0.Add(arg_1CA_1, value9);
			Dictionary<Type, Func<ScriptActionBase, bool>> arg_1EF_0 = this.ScriptHandlers;
			Type arg_1EF_1 = typeof(DispatchEventScript);
			Func<ScriptActionBase, bool> value10 = (ScriptActionBase cmd) => this.DispatchEventScriptHandler((DispatchEventScript)cmd);
			arg_1EF_0.Add(arg_1EF_1, value10);
			Dictionary<Type, Func<ScriptActionBase, bool>> arg_214_0 = this.ScriptHandlers;
			Type arg_214_1 = typeof(LoadNextScript);
			Func<ScriptActionBase, bool> value11 = (ScriptActionBase cmd) => this.LoadNextScriptHandler((LoadNextScript)cmd);
			arg_214_0.Add(arg_214_1, value11);
			Dictionary<Type, Func<ScriptActionBase, bool>> arg_239_0 = this.ScriptHandlers;
			Type arg_239_1 = typeof(SetFocusTarget);
			Func<ScriptActionBase, bool> value12 = (ScriptActionBase cmd) => this.SetFocusTargetHandler((SetFocusTarget)cmd);
			arg_239_0.Add(arg_239_1, value12);
			Dictionary<Type, Func<ScriptActionBase, bool>> arg_25E_0 = this.ScriptHandlers;
			Type arg_25E_1 = typeof(OverrideAggroRange);
			Func<ScriptActionBase, bool> value13 = (ScriptActionBase cmd) => this.OverrideAggroRangeHandler((OverrideAggroRange)cmd);
			arg_25E_0.Add(arg_25E_1, value13);
			Dictionary<Type, Func<ScriptActionBase, bool>> arg_283_0 = this.ScriptHandlers;
			Type arg_283_1 = typeof(BeginTransition);
			Func<ScriptActionBase, bool> value14 = (ScriptActionBase cmd) => this.BeginTransitionHandler((BeginTransition)cmd);
			arg_283_0.Add(arg_283_1, value14);
			Dictionary<Type, Func<ScriptActionBase, bool>> arg_2A8_0 = this.ScriptHandlers;
			Type arg_2A8_1 = typeof(TransitionAwait);
			Func<ScriptActionBase, bool> value15 = (ScriptActionBase cmd) => this.TransitionAwaitHandler((TransitionAwait)cmd);
			arg_2A8_0.Add(arg_2A8_1, value15);
			Dictionary<Type, Func<ScriptActionBase, bool>> arg_2CD_0 = this.ScriptHandlers;
			Type arg_2CD_1 = typeof(ScriptComment);
			Func<ScriptActionBase, bool> value16 = (ScriptActionBase cmd) => this.CommentEventHandler((ScriptComment)cmd);
			arg_2CD_0.Add(arg_2CD_1, value16);
			Dictionary<Type, Func<ScriptActionBase, bool>> arg_2F2_0 = this.ScriptHandlers;
			Type arg_2F2_1 = typeof(LogoutAndStartNewQuest);
			Func<ScriptActionBase, bool> value17 = (ScriptActionBase cmd) => this.LogoutAndStartNewQuestHandler((LogoutAndStartNewQuest)cmd);
			arg_2F2_0.Add(arg_2F2_1, value17);
			Dictionary<Type, Func<ScriptActionBase, bool>> arg_317_0 = this.ScriptHandlers;
			Type arg_317_1 = typeof(DeathSavePoint);
			Func<ScriptActionBase, bool> value18 = (ScriptActionBase cmd) => this.DeathSavePointHandler((DeathSavePoint)cmd);
			arg_317_0.Add(arg_317_1, value18);
			this.OnScriptCompleted += delegate(Script s)
			{
				GClass0.smethod_0().method_11(null);
			};
		}
		internal void ResetScript()
		{
			this.timeoutEnd = 0;
			this.skipDialog = 0;
			this.remainingScriptTimeWait = 0;
			this.lastTick = 0;
			this.lastStepCompleted = false;
		}
		internal void RewindToLastSavepoint()
		{
			for (int i = this.CurrentIndex; i >= 0; i--)
			{
				if (this.ScriptActions[i] is DeathSavePoint)
				{
					GClass0.smethod_0().method_5("Script: Reverting script to index {0} because of death".smethod_0(i));
					this.CurrentIndex = i;
					this.lastStepCompleted = false;
					this.remainingScriptTimeWait += 500;
					this.currentTransition = null;
					return;
				}
			}
		}
		internal void Run()
		{
			this.LastRan = Environment.TickCount;
			if (this.CurrentIndex == 0)
			{
				this.timeoutEnd = 0;
				this.remainingScriptTimeWait = 0;
			}
			bool flag = false;
			if (Environment.TickCount < this.timeoutEnd)
			{
				flag = true;
			}
			else
			{
				this.timeoutEnd = Environment.TickCount;
			}
			int num = Environment.TickCount - this.lastTick;
			if (num > 300 || num < 0)
			{
				num = 0;
			}
			if (num > this.remainingScriptTimeWait)
			{
				num = this.remainingScriptTimeWait;
			}
			if (this.remainingScriptTimeWait > 0)
			{
				this.remainingScriptTimeWait -= num;
			}
			this.lastTick = Environment.TickCount;
			if (this.remainingScriptTimeWait > 0)
			{
				flag = true;
			}
			if (!flag)
			{
				if (this.skipDialog > 0)
				{
					this.skipDialog--;
					Framework.UI_BossEncounterJoinParty_Accept();
					Framework.CutsceneCancel();
					Framework.SkipDialog();
					Framework.CloseQuestReward();
					Framework.CutsceneCancel();
					for (int i = 0; i < 20; i++)
					{
						Framework.AdvanceDialog();
					}
				}
				else
				{
					if (this.CurrentIndex < 0)
					{
						this.CurrentIndex = 0;
					}
					if (!this.ScriptFinished)
					{
						if (this.lastStepCompleted)
						{
							this.CurrentIndex++;
							this.lastStepCompleted = false;
							if (this.ScriptFinished)
							{
								if (this.OnScriptCompleted != null)
								{
									this.OnScriptCompleted(this);
									return;
								}
								return;
							}
						}
						try
						{
							ScriptActionBase scriptActionBase = this.ScriptActions[this.CurrentIndex];
							if (this.ScriptHandlers[scriptActionBase.GetType()](scriptActionBase))
							{
								this.lastStepCompleted = true;
							}
						}
						catch (Exception ex)
						{
							GClass0.smethod_0().method_4("SCRIPT: Exception: " + ex.Message);
							GClass0.smethod_0().method_4("SCRIPT: InnerException: " + ex.InnerException);
							this.CurrentIndex = this.ScriptActions.Count;
						}
					}
				}
			}
		}
		private bool MoveHandler(Move move)
		{
			float num = Vector3.DistanceSquared(move.Target, Framework.Hero.Position);
			bool result;
			if (this.currentIndex + 1 < this.ScriptActions.Count)
			{
				int index = this.currentIndex + 1;
				Move move2 = this.ScriptActions[index] as Move;
				if (move2 != null)
				{
					float num2 = Vector3.Distance(Framework.Hero.Position, move.Target);
					if (num2 < 120f)
					{
						List<Vector3> path = Framework.Navigator.GetPath(Framework.Hero.Position, move.Target, 10f, 20f);
						if (path.Count > 1)
						{
							string string_ = "Skipping Move-Command, at index: " + this.currentIndex + ", because the next Move is in range.";
							GClass0.smethod_0().method_5(string_);
							result = true;
							return result;
						}
					}
				}
			}
			if (num > 81f)
			{
				Movement.MoveTo(move.Target);
				this.timeoutEnd += 150;
				result = false;
			}
			else
			{
				result = true;
			}
			return result;
		}
		private bool InteractHandler(Interact interact)
		{
			Script.Class87 @class = new Script.Class87();
			@class.interact_0 = interact;
			IEnumerable<D3Actor> source = 
				from a in Framework.Actors
				where a.IsD3Object && !a.Modelname.Contains("PHY-") && a.Team != D3Team.Diablo && a.Team != (D3Team)4294967295u
				select a;
			IEnumerable<D3Actor> source2;
			if (@class.interact_0.ExactMatch)
			{
				source2 = source.Where(new Func<D3Actor, bool>(@class.method_0));
			}
			else
			{
				source2 = source.Where(new Func<D3Actor, bool>(@class.method_1));
			}
			D3Actor d3Actor = (
				from a in source2
				orderby a.DistanceToHero()
				select a).FirstOrDefault<D3Actor>();
			bool result;
			if (d3Actor != null)
			{
				Movement.MoveTo(d3Actor.Position);
				this.timeoutEnd += 200;
				if (d3Actor.Modelname.Contains("_BSS_"))
				{
					GClass0.smethod_0().method_5("Interact:\"" + d3Actor.Modelname + "\"");
					result = Framework.Hero.InteractWithObject(d3Actor);
				}
				else
				{
					if (d3Actor.GetInt((D3Attribute)4294963561u) == 1)
					{
						GClass0.smethod_0().method_5("Interact: \"" + d3Actor.Modelname + "\"");
						result = Framework.Hero.InteractWithNPC(d3Actor);
					}
					else
					{
						GClass0.smethod_0().method_5("Interact:\"" + d3Actor.Modelname + "\"");
						result = Framework.Hero.InteractWithObject(d3Actor);
					}
				}
			}
			else
			{
				if (@class.interact_0.SkipBeginAwait)
				{
					for (int i = this.currentIndex; i < this.ScriptActions.Count; i++)
					{
						if (this.ScriptActions[i] is TransitionAwait && i + 1 < this.ScriptActions.Count)
						{
							this.currentIndex = i + 1;
							this.currentTransition = null;
						}
					}
					result = true;
				}
				else
				{
					if (!@class.interact_0.AllowFail)
					{
						if (this.currentTransition != null && this.currentTransition.method_1())
						{
							result = true;
							return result;
						}
						string errorMessage = string.Format("Cannot find: \"{0}\" Index: {1}", @class.interact_0.TargetSubstring, this.CurrentIndex);
						this.AbortWithError(errorMessage);
					}
					result = true;
				}
			}
			return result;
		}
		private bool WaitHandler(Wait wait)
		{
			int num = (int)(1000f * wait.WaitSeconds);
			if (num < 0)
			{
				num = 0;
			}
			if (wait.ScriptTime)
			{
				this.remainingScriptTimeWait += num;
			}
			else
			{
				this.timeoutEnd += num;
			}
			return true;
		}
		private bool ForceTownStateHandler(ForceTownState townState)
		{
			GClass0.smethod_0().GotoTown = true;
			this.timeoutEnd += 7000;
			return true;
		}
		private bool UseWaypointHandler(UseTeleporter teleport)
		{
			bool result;
			if (Movement.IsMoving)
			{
				result = false;
			}
			else
			{
				D3Actor d3Actor = (
					from a in Framework.Actors
					where a.Modelname.StartsWith("Waypoint")
					select a into x
					orderby x.DistanceToHero()
					select x).FirstOrDefault<D3Actor>();
				if (d3Actor != null)
				{
					if (d3Actor.DistanceToHero() > 30f)
					{
						Movement.MoveTo(d3Actor.Position);
						result = false;
					}
					else
					{
						Framework.RequestWaypointTeleport(teleport.TeleportIndex, d3Actor);
						this.timeoutEnd += 3000;
						result = true;
					}
				}
				else
				{
					GClass0.smethod_0().method_4("SCRIPT ERROR: Cannot find a waypoint in range, maybe the name has changed?");
					this.CurrentIndex = this.ScriptActions.Count;
					result = false;
				}
			}
			return result;
		}
		private bool TownPortalHandler(TownPortal tp)
		{
			Framework.TownPortal();
			this.timeoutEnd += 8500;
			return true;
		}
		private bool FindHandler(Find find)
		{
			Class46 class46_ = new Class46(find.SceneNameSubstring, find.ActorNameSubstring);
			GClass0.smethod_0().class46_0 = class46_;
			return true;
		}
		private bool CancelCutsceneHandler(CancelCutscene cc)
		{
			Framework.CutsceneCancel();
			this.skipDialog = 14;
			this.remainingScriptTimeWait += 200;
			return true;
		}
		private bool RelativeMoveHandler(RelativeMove rm)
		{
			Script.Class86 @class = new Script.Class86();
			@class.relativeMove_0 = rm;
			Scene scene = Framework.Navigator.LoadedScenes.FirstOrDefault(new Func<Scene, bool>(@class.method_0));
			bool result;
			if (scene == null)
			{
				this.AbortWithError(string.Format("Relative Move: Cannot find Scene with name: \"{0}\"", @class.relativeMove_0.SceneName));
				result = false;
			}
			else
			{
				Vector3 vector = scene.Center + @class.relativeMove_0.CenterOffset;
				if (Framework.Hero.DistanceTo(vector) > 15f)
				{
					Movement.MoveTo(vector);
					result = false;
				}
				else
				{
					result = true;
				}
			}
			return result;
		}
		private bool DispatchEventScriptHandler(DispatchEventScript cmd)
		{
			Script.Class85 @class = new Script.Class85();
			@class.dispatchEventScript_0 = cmd;
			Class57 class2 = GClass0.smethod_0().list_2.FirstOrDefault(new Func<Class57, bool>(@class.method_0));
			bool result;
			if (class2 == null)
			{
				this.AbortWithError("SCRIPT: Cannot dispatch EventScript: \"" + @class.dispatchEventScript_0.EventScriptName + "\"! The script could not be found!");
				result = false;
			}
			else
			{
				GClass0.smethod_0().method_15(class2);
				result = true;
			}
			return result;
		}
		private bool LoadNextScriptHandler(LoadNextScript cmd)
		{
			bool result;
			if (InjectedWindow.Instance.scriptEditor_0 != null)
			{
				string text = "The script editor is open. \"LoadNextScript\" will not be executed!";
				GClass0.smethod_0().method_5(text);
				InjectedWindow.Instance.method_16(text);
				result = true;
			}
			else
			{
				Script script = Script.LoadFromFile(cmd.ScriptFileName);
				if (script != null)
				{
					GClass0.smethod_0().method_11(script);
				}
				else
				{
					this.AbortWithError("SCRIPT: Error! Cannot find the next file: " + cmd.ScriptFileName);
				}
				result = true;
			}
			return result;
		}
		private bool SetFocusTargetHandler(SetFocusTarget cmd)
		{
			Class44 @class = GClass0.smethod_0().list_0.First((Class44 coreState) => coreState is Class45);
			bool result;
			if (@class == null)
			{
				this.AbortWithError("Script: Internal error! No connection to the combat system could be made");
				result = false;
			}
			else
			{
				Class45 class2 = @class as Class45;
				class2.method_6(cmd.TargetSubstring);
				result = true;
			}
			return result;
		}
		private bool OverrideAggroRangeHandler(OverrideAggroRange cmd)
		{
			GClass0.smethod_0().method_16(cmd.NewRange, cmd.ResetOnWorldChange, cmd.MaximumOverrideTimeSeconds);
			return true;
		}
		private bool BeginTransitionHandler(BeginTransition cmd)
		{
			if (this.currentTransition != null)
			{
				Debug.Print("Beginning transition, but there is already a transition in this context!!!");
			}
			this.timeoutEnd += 100;
			Class61 @class = new Class61(this.CurrentIndex + 1);
			this.currentTransition = @class;
			return true;
		}
		private bool TransitionAwaitHandler(TransitionAwait cmd)
		{
			bool result;
			if (this.currentTransition == null)
			{
				GClass0.smethod_0().method_5("Command to await a transition, before beginning one!!");
				result = true;
			}
			else
			{
				this.currentTransition.method_0(cmd.Type);
				if (this.currentTransition.method_1())
				{
					this.currentTransition = null;
					result = true;
				}
				else
				{
					this.CurrentIndex = this.currentTransition.SavedScriptIndex;
					this.timeoutEnd += 100;
					result = false;
				}
			}
			return result;
		}
		private bool CommentEventHandler(ScriptComment cmd)
		{
			GClass0.smethod_0().method_5("Comment: " + cmd.Text);
			return true;
		}
		private bool LogoutAndStartNewQuestHandler(LogoutAndStartNewQuest cmd)
		{
			bool result;
			if (InjectedWindow.Instance.scriptEditor_0 != null)
			{
				string text = "The script editor is open. \"LogoutAndStartNewQuest\" will not be executed!";
				GClass0.smethod_0().method_5(text);
				InjectedWindow.Instance.method_16(text);
				result = true;
			}
			else
			{
				if (cmd.NewScriptFile == "$this")
				{
					GClass0.smethod_0().method_17(this.LoadedFromFileName);
				}
				else
				{
					GClass0.smethod_0().method_17(cmd.NewScriptFile);
				}
				result = false;
			}
			return result;
		}
		private bool DeathSavePointHandler(DeathSavePoint cmd)
		{
			return true;
		}
		private void AbortWithError(string errorMessage)
		{
			errorMessage = "SCRIPT ERROR: " + errorMessage;
			GClass0.smethod_0().method_4(errorMessage);
			InjectedWindow.Instance.method_0(errorMessage);
			this.CurrentIndex = this.ScriptActions.Count;
		}
		internal void SaveToFile(string fileName)
		{
			try
			{
				string text = Path.Combine(Script.ScriptBaseDirectory, Path.GetFileNameWithoutExtension(fileName));
				text += Script.FileExtension;
				JsonSerializerSettings jsonSerializerSettings = new JsonSerializerSettings();
				jsonSerializerSettings.TypeNameAssemblyFormat = FormatterAssemblyStyle.Simple;
				jsonSerializerSettings.TypeNameHandling = TypeNameHandling.Objects;
				if (File.Exists(text))
				{
					File.SetAttributes(text, FileAttributes.Normal);
				}
				string s = JsonConvert.SerializeObject(this, Formatting.Indented, jsonSerializerSettings);
				byte[] bytes = Encoding.UTF8.GetBytes(s);
				Script.EncryptBuffer(ref bytes);
				FileStream fileStream = new FileStream(text, FileMode.Create);
				fileStream.Write(bytes, 0, bytes.Length);
				fileStream.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Cannot save script \"" + fileName + "\"\nException: " + ex.Message);
			}
		}
		internal static Script LoadFromFile(string FileName)
		{
			string path = Path.Combine(Script.ScriptBaseDirectory, Path.GetFileNameWithoutExtension(FileName) + Script.FileExtension);
			Script script = null;
			try
			{
				JsonSerializerSettings jsonSerializerSettings = new JsonSerializerSettings();
				jsonSerializerSettings.TypeNameAssemblyFormat = FormatterAssemblyStyle.Simple;
				jsonSerializerSettings.TypeNameHandling = TypeNameHandling.Objects;
				byte[] bytes = File.ReadAllBytes(path);
				Script.DecryptBuffer(ref bytes);
				string @string = Encoding.UTF8.GetString(bytes);
				script = JsonConvert.DeserializeObject<Script>(@string, jsonSerializerSettings);
				script.LoadedFromFileName = Path.GetFileNameWithoutExtension(FileName);
				Script.LastLoadedFileName = Path.GetFileNameWithoutExtension(FileName);
			}
			catch (IOException ex)
			{
				MessageBox.Show("Cannot load script: \"" + FileName + "\"\n\nException:\n" + ex.Message, "HellBuddy Bot", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			catch (Exception)
			{
				MessageBox.Show("Cannot load script: \"" + FileName + "\"\nUnknown error...", "HellBuddy Bot", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				Process.GetCurrentProcess().Kill();
			}
			return script;
		}
		private static void EncryptBuffer(ref byte[] input)
		{
			byte b = 239;
			byte b2 = 231;
			for (int i = 0; i < input.Length; i++)
			{
				byte[] expr_18_cp_0 = input;
				int expr_18_cp_1 = i;
				expr_18_cp_0[expr_18_cp_1] += b;
				byte[] expr_2E_cp_0 = input;
				int expr_2E_cp_1 = i;
				expr_2E_cp_0[expr_2E_cp_1] ^= b2;
			}
		}
		private static void DecryptBuffer(ref byte[] input)
		{
			byte b = 239;
			byte b2 = 231;
			for (int i = 0; i < input.Length; i++)
			{
				byte[] expr_18_cp_0 = input;
				int expr_18_cp_1 = i;
				expr_18_cp_0[expr_18_cp_1] ^= b2;
				byte[] expr_2E_cp_0 = input;
				int expr_2E_cp_1 = i;
				expr_2E_cp_0[expr_2E_cp_1] -= b;
			}
		}
	}
}
