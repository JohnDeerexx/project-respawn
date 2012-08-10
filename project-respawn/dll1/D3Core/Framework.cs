using D3Core.Classes;
using D3Core.Classes.Navigation;
using ns0;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
namespace D3Core
{
	public static class Framework
	{
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		private delegate IntPtr Delegate23(uint guid);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		private delegate uint Delegate22();
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
		public delegate float GetFloatDelegate(uint ObjActor, uint StatIndex);
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
		public delegate int GetIntDelegate(uint ObjActor, uint StatIndex);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate uint GetACDByGuidDelegate(uint Guid);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		private delegate IntPtr Delegate21(out int v14, uint objActor, int one, int zero);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		private delegate void Delegate20();
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		private delegate uint Delegate16();
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		private delegate void Delegate19(uint maybeOPCode, IntPtr data, int maybeDatagramSize);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal delegate uint Delegate1(uint localObjectGUID);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		private delegate int Delegate0();
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void SkipDialogDelegate();
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		private delegate string Delegate18(int a1, int a2);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void LeaveGameDelegate(uint someUIElement);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void LoginButtonDelegate();
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void ReviveAtCheckpointDelegate();
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void TownPortalDelegate();
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
		public delegate uint IterateActorsDelegate(uint RActors, ref int index, out uint actor);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate uint GetSnoNameDelegate(ref ContainerStruct a, int b, uint c, int d);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		private delegate uint Delegate15(short ui16);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		private delegate int Delegate14(uint objectInfoContainer, int spellId, ref int noIdea);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate uint GetCurrentQuestDelegate();
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		private delegate int Delegate17(uint objGuid16);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		private delegate int Delegate11(uint heroPtr, ref Framework.Struct4 cmdPacket);
		private struct Struct4
		{
			public uint uint_0;
			public uint uint_1;
			public uint uint_2;
			public uint uint_3;
			public float float_0;
			public float float_1;
			public float float_2;
			public uint uint_4;
			public int int_0;
		}
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate int Delegate10(uint cmdPacket, uint Hero, uint unk1, uint unk2, int address);
		private struct Struct3
		{
			private uint uint_0;
			private uint uint_1;
			private uint uint_2;
			private uint uint_3;
			private uint uint_4;
			public Struct3(uint uint_5, uint uint_6)
			{
				this.uint_0 = uint_5;
				this.uint_1 = uint_6;
				this.uint_2 = uint_6;
				this.uint_3 = 0u;
				this.uint_4 = 4294967295u;
			}
		}
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void UIGenericDelegate();
		[CompilerGenerated]
		private sealed class Class32
		{
			public Action action_0;
			public void method_0()
			{
				this.action_0();
			}
		}
		[CompilerGenerated]
		private sealed class Class8
		{
			public uint uint_0;
			public bool method_0(D3Actor d3Actor_0)
			{
				return d3Actor_0.Guid == this.uint_0;
			}
		}
		private static Framework.Delegate23 delegate23_0;
		private static Framework.Delegate22 delegate22_0;
		public static Framework.GetFloatDelegate GetFloat;
		public static Framework.GetIntDelegate GetInt;
		public static Framework.GetACDByGuidDelegate GetACDByGuid;
		private static Framework.Delegate21 delegate21_0;
		private static Framework.Delegate20 delegate20_0;
		private static Framework.Delegate16 delegate16_0;
		private static Framework.Delegate19 delegate19_0;
		internal static Framework.Delegate1 delegate1_0;
		private static Framework.Delegate0 delegate0_0;
		public static Framework.SkipDialogDelegate SkipDialog;
		private static Framework.SkipDialogDelegate skipDialogDelegate_0;
		private static Framework.Delegate18 delegate18_0;
		public static Framework.LeaveGameDelegate D3LeaveGame;
		public static Framework.LoginButtonDelegate PressLoginButton;
		public static Framework.ReviveAtCheckpointDelegate ReviveAtCheckpointButton;
		public static Framework.TownPortalDelegate TownPortal_Internal;
		public static Framework.IterateActorsDelegate IterateActors;
		public static Framework.GetSnoNameDelegate GetSnoName;
		private static Framework.Delegate15 delegate15_0;
		private static Framework.Delegate14 delegate14_0;
		public static Framework.GetCurrentQuestDelegate GetCurrentQuest;
		private static Framework.Delegate17 delegate17_0;
		private static Framework.Delegate11 delegate11_0;
		private static Framework.Delegate10 delegate10_0;
		public static Framework.UIGenericDelegate UICloseAllTabs;
		public static Framework.UIGenericDelegate UI_Confirm_OnOk;
		public static Framework.UIGenericDelegate CloseQuestReward;
		private static Framework.UIGenericDelegate uigenericDelegate_0;
		public static Framework.UIGenericDelegate UI_BossEncounterJoinParty_Accept;
		public static readonly List<D3Actor> Actors = new List<D3Actor>();
		private static Hook hook_0;
		private static EventHandler eventHandler_0;
		private static EventHandler<EventArgs<string>> eventHandler_1;
		private static EventHandler<EventArgs<string>> eventHandler_2;
		private static EventHandler<EventArgs<string>> eventHandler_3;
		private static bool bool_0 = false;
		private static List<Action> list_0 = new List<Action>();
		private static object object_0 = new object();
		private static int int_0 = 0;
		private static Navi navi_0 = new Navi();
		private static uint uint_0 = 0u;
		private static List<IntPtr> list_1 = new List<IntPtr>();
		[CompilerGenerated]
		private static HeroActor heroActor_0;
		[CompilerGenerated]
		private static string string_0;
		[CompilerGenerated]
		private static int int_1;
		[CompilerGenerated]
		private static Action action_0;
		[CompilerGenerated]
		private static Func<Scene, bool> func_0;
		public static event EventHandler Pulse
		{
			add
			{
				EventHandler eventHandler = Framework.eventHandler_0;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref Framework.eventHandler_0, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			remove
			{
				EventHandler eventHandler = Framework.eventHandler_0;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref Framework.eventHandler_0, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}
		public static event EventHandler<EventArgs<string>> Error
		{
			add
			{
				EventHandler<EventArgs<string>> eventHandler = Framework.eventHandler_1;
				EventHandler<EventArgs<string>> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs<string>> value2 = (EventHandler<EventArgs<string>>)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs<string>>>(ref Framework.eventHandler_1, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			remove
			{
				EventHandler<EventArgs<string>> eventHandler = Framework.eventHandler_1;
				EventHandler<EventArgs<string>> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs<string>> value2 = (EventHandler<EventArgs<string>>)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs<string>>>(ref Framework.eventHandler_1, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}
		public static event EventHandler<EventArgs<string>> Log
		{
			add
			{
				EventHandler<EventArgs<string>> eventHandler = Framework.eventHandler_2;
				EventHandler<EventArgs<string>> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs<string>> value2 = (EventHandler<EventArgs<string>>)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs<string>>>(ref Framework.eventHandler_2, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			remove
			{
				EventHandler<EventArgs<string>> eventHandler = Framework.eventHandler_2;
				EventHandler<EventArgs<string>> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs<string>> value2 = (EventHandler<EventArgs<string>>)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs<string>>>(ref Framework.eventHandler_2, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}
		public static event EventHandler<EventArgs<string>> FileLog
		{
			add
			{
				EventHandler<EventArgs<string>> eventHandler = Framework.eventHandler_3;
				EventHandler<EventArgs<string>> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs<string>> value2 = (EventHandler<EventArgs<string>>)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs<string>>>(ref Framework.eventHandler_3, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			remove
			{
				EventHandler<EventArgs<string>> eventHandler = Framework.eventHandler_3;
				EventHandler<EventArgs<string>> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs<string>> value2 = (EventHandler<EventArgs<string>>)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs<string>>>(ref Framework.eventHandler_3, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}
		public static HeroActor Hero
		{
			get;
			private set;
		}
		public static string HostBaseDirectory
		{
			get;
			set;
		}
		public static int TheNumber
		{
			get;
			private set;
		}
		public static string World
		{
			get
			{
				string result;
				if (Framework.navi_0 != null)
				{
					result = Framework.navi_0.World;
				}
				else
				{
					result = string.Empty;
				}
				return result;
			}
		}
		public static string Scene
		{
			get
			{
				string result;
				if (Framework.Hero != null && Framework.navi_0 != null)
				{
					IEnumerable<Scene> arg_3B_0 = Framework.navi_0.LoadedScenes;
					if (Framework.func_0 == null)
					{
						Framework.func_0 = new Func<Scene, bool>(Framework.smethod_6);
					}
					Scene scene = arg_3B_0.FirstOrDefault(Framework.func_0);
					if (scene != null)
					{
						result = scene.SNOName;
						return result;
					}
				}
				result = string.Empty;
				return result;
			}
		}
		public static Navi Navigator
		{
			get
			{
				return Framework.navi_0;
			}
		}
		public static uint HoverGUID
		{
			get
			{
				uint num = Helper.smethod_1(24417116u);
				uint result;
				if (num == 0u)
				{
					result = 0u;
				}
				else
				{
					num += 2080u;
					uint num2 = Helper.smethod_1(num);
					if (num2 != 0u && num2 != 4294967295u)
					{
						Framework.uint_0 = num2;
					}
					result = num2;
				}
				return result;
			}
		}
		public static uint LastHoverGUID
		{
			get
			{
				return Framework.uint_0;
			}
		}
		public static bool IsConnectedToBattleNet
		{
			get
			{
				return Helper.smethod_1(24683800u) == 1u || Framework.IsIngame;
			}
		}
		public static bool IsIngame
		{
			get
			{
				return Framework.HoverGUID != 0u && Framework.Actors != null && Framework.Hero != null;
			}
		}
		public static D3_IngameAct CurrentAct
		{
			get
			{
				D3_IngameAct result;
				try
				{
					result = (D3_IngameAct)Framework.delegate0_0();
				}
				catch (Exception ex)
				{
					Framework.smethod_0("GetActIndex error: " + ex.Message);
					result = D3_IngameAct.Act1;
				}
				return result;
			}
		}
		[HandleProcessCorruptedStateExceptions]
		public static void AdvanceDialog()
		{
			try
			{
				Framework.skipDialogDelegate_0();
			}
			catch
			{
			}
		}
		[HandleProcessCorruptedStateExceptions]
		public static void Initialize()
		{
			Framework.smethod_2("registering...");
			try
			{
				Framework.delegate23_0 = Helper.RegisterDelegate<Framework.Delegate23>(new IntPtr(8558624));
				Framework.delegate22_0 = Helper.RegisterDelegate<Framework.Delegate22>(new IntPtr(9948176));
				Framework.GetFloat = Helper.RegisterDelegate<Framework.GetFloatDelegate>(new IntPtr(9127136));
				Framework.GetInt = Helper.RegisterDelegate<Framework.GetIntDelegate>(new IntPtr(9127328));
				Framework.GetACDByGuid = Helper.RegisterDelegate<Framework.GetACDByGuidDelegate>(new IntPtr(8482160));
				Framework.delegate21_0 = Helper.RegisterDelegate<Framework.Delegate21>(new IntPtr(9864176));
				Framework.delegate20_0 = Helper.RegisterDelegate<Framework.Delegate20>(new IntPtr(12290656));
				Framework.delegate16_0 = Helper.RegisterDelegate<Framework.Delegate16>(new IntPtr(9948112));
				Framework.delegate19_0 = Helper.RegisterDelegate<Framework.Delegate19>(new IntPtr(10508240));
				Framework.delegate1_0 = Helper.RegisterDelegate<Framework.Delegate1>(new IntPtr(8737680));
				Framework.PressLoginButton = Helper.RegisterDelegate<Framework.LoginButtonDelegate>(new IntPtr(13156288));
				Framework.SkipDialog = Helper.RegisterDelegate<Framework.SkipDialogDelegate>(new IntPtr(10682064));
				Framework.skipDialogDelegate_0 = Helper.RegisterDelegate<Framework.SkipDialogDelegate>(new IntPtr(10683536));
				Framework.D3LeaveGame = Helper.RegisterDelegate<Framework.LeaveGameDelegate>(new IntPtr(11168032));
				Framework.ReviveAtCheckpointButton = Helper.RegisterDelegate<Framework.ReviveAtCheckpointDelegate>(new IntPtr(13093920));
				Framework.TownPortal_Internal = Helper.RegisterDelegate<Framework.TownPortalDelegate>(12180320u);
				Framework.delegate0_0 = Helper.RegisterDelegate<Framework.Delegate0>(8562256u);
				Framework.CloseQuestReward = Helper.RegisterDelegate<Framework.UIGenericDelegate>(11057344u);
				Framework.IterateActors = Helper.RegisterDelegate<Framework.IterateActorsDelegate>(10361296u);
				Framework.GetSnoName = Helper.RegisterDelegate<Framework.GetSnoNameDelegate>(8545712u);
				Framework.delegate15_0 = Helper.RegisterDelegate<Framework.Delegate15>(8460944u);
				Framework.delegate14_0 = Helper.RegisterDelegate<Framework.Delegate14>(9160960u);
				Framework.GetCurrentQuest = Helper.RegisterDelegate<Framework.GetCurrentQuestDelegate>(8807936u);
				IntPtr ptr = Marshal.AllocHGlobal(200);
				List<byte> list = new List<byte>(200);
				for (int i = 0; i < 10; i++)
				{
					list.Add(144);
				}
				list.AddRange(new byte[]
				{
					85
				});
				list.AddRange(new byte[]
				{
					139,
					236
				});
				list.AddRange(new byte[]
				{
					141,
					69,
					8
				});
				list.AddRange(new byte[]
				{
					80
				});
				list.AddRange(new byte[]
				{
					106,
					1
				});
				list.AddRange(new byte[]
				{
					106,
					1
				});
				list.AddRange(new byte[]
				{
					139,
					69,
					8
				});
				list.AddRange(new byte[]
				{
					139,
					117,
					12
				});
				list.AddRange(new byte[]
				{
					232
				});
				list.AddRange(BitConverter.GetBytes(9938768 - (ptr.ToInt32() + list.Count + 4)));
				list.AddRange(new byte[]
				{
					139,
					229
				});
				list.AddRange(new byte[]
				{
					93
				});
				list.AddRange(new byte[]
				{
					195
				});
				while (list.Count < 200)
				{
					list.Add(144);
				}
				Helper.WriteBytes(ptr, list.ToArray());
				Framework.delegate11_0 = Helper.RegisterDelegate<Framework.Delegate11>(ptr);
				byte[] array = new byte[]
				{
					85,
					139,
					236,
					139,
					93,
					24,
					139,
					69,
					20,
					80,
					139,
					69,
					16,
					80,
					139,
					69,
					12,
					80,
					139,
					69,
					8,
					255,
					211,
					139,
					229,
					93,
					195
				};
				IntPtr intPtr = Marshal.AllocCoTaskMem(array.Length);
				Marshal.Copy(array, 0, intPtr, array.Length);
				Framework.delegate10_0 = Helper.RegisterDelegate<Framework.Delegate10>(intPtr);
				Framework.UICloseAllTabs = Helper.RegisterDelegate<Framework.UIGenericDelegate>(11808672u);
				Framework.UI_Confirm_OnOk = Helper.RegisterDelegate<Framework.UIGenericDelegate>(10902816u);
				Framework.uigenericDelegate_0 = Helper.RegisterDelegate<Framework.UIGenericDelegate>(11757376u);
				Framework.UI_BossEncounterJoinParty_Accept = Helper.RegisterDelegate<Framework.UIGenericDelegate>(13529024u);
			}
			catch (Exception)
			{
				Framework.smethod_2("execption in Core.Initialize");
				MessageBox.Show("init core has returned an error");
			}
			Framework.smethod_2("end of register, now hooking");
			IntPtr intPtr2 = Class33.smethod_0();
			Framework.TheNumber = intPtr2.ToInt32();
			Framework.smethod_2("N = " + Framework.TheNumber);
			int arg_435_0 = intPtr2.ToInt32() + 36;
			int arg_435_1 = 0;
			if (Framework.action_0 == null)
			{
				Framework.action_0 = new Action(Framework.smethod_5);
			}
			Framework.hook_0 = new Hook(arg_435_0, arg_435_1, Framework.action_0, true);
		}
		[HandleProcessCorruptedStateExceptions]
		public static void ModalNotificationOK()
		{
			Framework.smethod_1("Clicking OK on a ModalNotification");
			try
			{
				Framework.uigenericDelegate_0();
			}
			catch
			{
			}
		}
		public static string GetTranslation(D3Item itm)
		{
			string result;
			try
			{
				int stringAddress = 0;
				Framework.delegate21_0(out stringAddress, itm.Ptr, 1, 0);
				result = Helper.ReadString((uint)stringAddress, null);
			}
			catch (Exception ex)
			{
				Framework.smethod_0("Error in Framework.GetTranslation: " + ex.Message);
				result = string.Empty;
			}
			return result;
		}
		public static bool IsInAnimation()
		{
			if (Framework.delegate17_0 == null)
			{
				Framework.delegate17_0 = Helper.RegisterDelegate<Framework.Delegate17>(9169584u);
			}
			uint objGuid = Framework.delegate15_0(Helper.smethod_0((uint)((int)Framework.Hero._Ptr + 4)));
			int num = Framework.delegate17_0(objGuid);
			return num == 8 && num != 1 && num != 7 && num != 12 && num != 2 && num != 10;
		}
		public static bool CanUsePower(int powerId)
		{
			bool result;
			try
			{
				uint objectInfoContainer = Framework.delegate15_0(Helper.smethod_0((uint)((int)Framework.Hero._Ptr + 4)));
				int num = 2;
				int num2 = Framework.delegate14_0(objectInfoContainer, powerId, ref num);
				if (num2 == 0)
				{
					result = true;
				}
				else
				{
					result = (num2 == 4);
				}
			}
			catch (Exception)
			{
				result = false;
			}
			return result;
		}
		public static bool IsCooldown(int powerId)
		{
			bool result;
			try
			{
				uint objectInfoContainer = Framework.delegate15_0(Helper.smethod_0((uint)((int)Framework.Hero._Ptr + 4)));
				int num = 2;
				int num2 = Framework.delegate14_0(objectInfoContainer, powerId, ref num);
				result = ((num2 & 8) == 8);
			}
			catch (Exception)
			{
				result = true;
			}
			return result;
		}
		internal static void smethod_0(string string_1)
		{
			if (Framework.eventHandler_1 != null)
			{
				Framework.eventHandler_1(null, new EventArgs<string>(string_1));
			}
		}
		internal static void smethod_1(string string_1)
		{
			if (Framework.eventHandler_2 != null)
			{
				Framework.eventHandler_2(null, new EventArgs<string>(string_1));
			}
		}
		internal static void smethod_2(string string_1)
		{
			if (Framework.eventHandler_3 != null)
			{
				Framework.eventHandler_3(null, new EventArgs<string>(string_1));
			}
		}
		public static void BeginRunInD3Context(Action action)
		{
			lock (Framework.object_0)
			{
				Framework.list_0.Add(action);
			}
		}
		[HandleProcessCorruptedStateExceptions]
		public static void RunInD3ContextSynced(Action action)
		{
			Action action2 = null;
			Framework.Class32 @class = new Framework.Class32();
			@class.action_0 = action;
			lock (Framework.object_0)
			{
				Framework.bool_0 = false;
				List<Action> arg_3B_0 = Framework.list_0;
				if (action2 == null)
				{
					action2 = new Action(@class.method_0);
				}
				arg_3B_0.Add(action2);
				goto IL_7F;
			}
			bool flag2;
			try
			{
				IL_4F:
				object obj;
				Monitor.Enter(obj = Framework.object_0, ref flag2);
				if (Framework.bool_0)
				{
					return;
				}
			}
			finally
			{
				if (flag2)
				{
					object obj;
					Monitor.Exit(obj);
				}
			}
			Thread.Sleep(5);
			IL_7F:
			flag2 = false;
			
		}
		[HandleProcessCorruptedStateExceptions]
		private static void smethod_3()
		{
			(Environment.TickCount - Framework.int_0).smethod_0(0, 300);
			Framework.int_0 = Environment.TickCount;
			Class30.smethod_0("Hook start");
			try
			{
				lock (Framework.object_0)
				{
					Class30.smethod_0("Start RActors");
					Framework.Actors.Clear();
					uint num = 0u;
					uint rActors = Helper.smethod_1(Helper.smethod_1(22522396u) + 2224u);
					int num2 = -1;
					uint num3 = Framework.delegate22_0();
					Framework.Hero = null;
					while (Framework.IterateActors(rActors, ref num2, out num) != 0u)
					{
						D3Actor d3Actor = new D3Actor(new IntPtr((long)((ulong)num)));
						if (d3Actor.Guid == num3)
						{
							Framework.Hero = new HeroActor(new IntPtr((long)((ulong)num)));
						}
						if (!Class31.smethod_0(d3Actor.UInt32_0))
						{
							Framework.Actors.Add(d3Actor);
						}
					}
					Class30.smethod_0("End RActors, start Scenes");
					if (Framework.IsIngame)
					{
						Framework.Navigator.Pulse();
					}
					Class30.smethod_0("QuestData");
					D3QuestStatus.smethod_0();
					Class30.smethod_0("SyncActions");
					foreach (Action current in Framework.list_0.ToList<Action>())
					{
						try
						{
							current();
						}
						catch
						{
						}
					}
					Framework.list_0.Clear();
					Framework.bool_0 = true;
				}
			}
			catch (Exception ex)
			{
				Framework.smethod_0("Error:" + ex.Message);
			}
			Class30.smethod_0("Engine start");
			if (Framework.eventHandler_0 != null)
			{
				Framework.eventHandler_0(null, null);
			}
			Class30.smethod_0("Engine end");
		}
		public static void SalvageItem(D3Item item)
		{
			Framework.smethod_1("Salvaging item:" + item.Modelname);
			Marshal.WriteInt32(new IntPtr(22472512), (int)item.GUID);
			Marshal.WriteInt32(new IntPtr(22472516), (int)Framework.Hero.ObjectGuid);
			Framework.delegate20_0();
		}
		public static void RequestIdentify(D3Item item)
		{
			Struct9 @struct = new Struct9(item);
			IntPtr intPtr = Marshal.AllocHGlobal(Marshal.SizeOf(@struct));
			Marshal.StructureToPtr(@struct, intPtr, true);
			Framework.delegate19_0(281u, intPtr, 12);
			Marshal.FreeHGlobal(intPtr);
		}
		public static void RequestSpellChange(D3Spell spell, int SlotIndex)
		{
			try
			{
				Struct8 @struct = new Struct8((int)spell.D3Power, spell.Rune, SlotIndex);
				IntPtr intPtr = Marshal.AllocHGlobal(Marshal.SizeOf(@struct));
				Marshal.StructureToPtr(@struct, intPtr, true);
				Framework.delegate19_0(107u, intPtr, Marshal.SizeOf(@struct));
				Marshal.FreeHGlobal(intPtr);
			}
			catch (Exception ex)
			{
				Framework.smethod_0("Error in Framework.RequestSpellChange(): " + ex.Message);
			}
		}
		public static void RequestWaypointTeleport(int Index, D3Actor Waypoint)
		{
			Framework.smethod_1("Using a teleporter");
			if (Waypoint != null)
			{
				uint objectGuid = Waypoint.ObjectGuid;
				if (objectGuid != 4294967295u)
				{
					uint num = Framework.delegate1_0(objectGuid);
					if (num != 4294967295u)
					{
						Struct7 @struct = new Struct7(Index, num);
						IntPtr intPtr = Marshal.AllocHGlobal(16);
						Marshal.StructureToPtr(@struct, intPtr, true);
						Framework.delegate19_0(151u, intPtr, 16);
						Marshal.FreeHGlobal(intPtr);
					}
				}
			}
		}
		public static void RequestRepairAll()
		{
			Framework.smethod_1("Requesting repair");
			Struct6 @struct = default(Struct6);
			@struct.method_0();
			IntPtr intPtr = Marshal.AllocHGlobal(Marshal.SizeOf(@struct));
			Marshal.StructureToPtr(@struct, intPtr, true);
			Framework.delegate19_0(273u, intPtr, Marshal.SizeOf(@struct));
			Marshal.FreeHGlobal(intPtr);
		}
		public static void RequestSellItem(D3Item item)
		{
			Struct5 @struct = new Struct5(item);
			IntPtr intPtr = Marshal.AllocHGlobal(Marshal.SizeOf(@struct));
			Marshal.StructureToPtr(@struct, intPtr, true);
			Framework.delegate19_0(36u, intPtr, Marshal.SizeOf(@struct));
			Marshal.FreeHGlobal(intPtr);
		}
		public static void UsePower_Meta(uint TargetGUID, uint ActionID)
		{
			Framework.Struct3 @struct = new Framework.Struct3(TargetGUID, ActionID);
			IntPtr intPtr = Marshal.AllocHGlobal(20);
			Framework.list_1.Add(intPtr);
			Marshal.StructureToPtr(@struct, intPtr, true);
			Framework.delegate10_0((uint)((int)intPtr), (uint)((int)Framework.Hero._Ptr), 1u, 0u, 9939344);
			while (Framework.list_1.Count > 6000)
			{
				Marshal.FreeHGlobal(Framework.list_1.First<IntPtr>());
				Framework.list_1.RemoveAt(0);
			}
		}
		private static bool smethod_4(uint uint_1, uint uint_2, Vector3 vector3_0, bool bool_1)
		{
			Func<D3Actor, bool> func = null;
			Framework.Class8 @class = new Framework.Class8();
			@class.uint_0 = uint_2;
			Framework.Struct4 @struct = default(Framework.Struct4);
			@struct.uint_0 = uint_1;
			@struct.uint_1 = uint_1;
			if (bool_1)
			{
				@struct.uint_2 = 1u;
			}
			else
			{
				@struct.uint_2 = 2u;
			}
			@struct.uint_3 = @class.uint_0;
			@struct.float_0 = vector3_0.float_0;
			@struct.float_1 = vector3_0.float_1;
			@struct.float_2 = vector3_0.float_2;
			if (!bool_1)
			{
				if (@class.uint_0 != 4294967295u)
				{
					IEnumerable<D3Actor> arg_9A_0 = Framework.Actors;
					if (func == null)
					{
						func = new Func<D3Actor, bool>(@class.method_0);
					}
					D3Actor d3Actor = arg_9A_0.FirstOrDefault(func);
					if (d3Actor != null)
					{
						uint num = Framework.GetACDByGuid(d3Actor.ObjectGuid);
						num += Class3.Class2.uint_10;
						uint uint_3 = Helper.smethod_1(num);
						@struct.uint_4 = uint_3;
					}
				}
				else
				{
					@struct.uint_4 = Framework.Hero.UsePowerTargetID;
				}
			}
			@struct.int_0 = -1;
			return Framework.delegate11_0((uint)((int)Framework.Hero._Ptr), ref @struct) == 1;
		}
		public static bool UsePower_Target(uint ActionID, D3Actor target)
		{
			bool result;
			if (target == null)
			{
				Framework.smethod_0("UsePower: TARGET == NULL");
				result = false;
			}
			else
			{
				result = Framework.smethod_4(ActionID, target.ObjectGuid, target.Position, true);
			}
			return result;
		}
		public static bool UsePower_Position(uint ActionID, Vector3 position)
		{
			return Framework.smethod_4(ActionID, 4294967295u, position, false);
		}
		public static void Unload()
		{
			Framework.smethod_1("Unloading core...");
			if (Framework.hook_0.IsApplied)
			{
				Framework.hook_0.Remove();
			}
			if (Framework.navi_0 != null)
			{
				Framework.navi_0.method_10();
			}
			Framework.navi_0 = null;
			D3Actor.smethod_0();
		}
		public static D3Spell GetSpellIDByIndex(int index)
		{
			uint num = Framework.delegate16_0();
			D3Spell result;
			if (num != 0u)
			{
				D3Power d3Power = (D3Power)Helper.smethod_1(num + (uint)(index * 8) + 2532u);
				int rune = (int)Helper.smethod_1(num + (uint)(index * 8) + 2536u);
				result = new D3Spell(d3Power, rune);
			}
			else
			{
				result = null;
			}
			return result;
		}
		public static uint GetServerGUID(D3Actor a)
		{
			uint result;
			if (a.IsD3Object)
			{
				result = Framework.delegate1_0(a.ObjectGuid);
			}
			else
			{
				result = 0u;
			}
			return result;
		}
		public static void ActivateGame()
		{
			Helper.WriteBytes(new IntPtr(22373036L), new byte[]
			{
				1
			});
		}
		[HandleProcessCorruptedStateExceptions]
		public static void CutsceneCancel()
		{
			try
			{
				Framework.UI_Confirm_OnOk();
				Framework.UICloseAllTabs();
				Framework.UI_Confirm_OnOk();
			}
			catch
			{
			}
		}
		public static void TownPortal()
		{
			Framework.smethod_1("Using Townportal");
			Framework.TownPortal_Internal();
		}
		[HandleProcessCorruptedStateExceptions]
		public static void LeaveGame()
		{
			Framework.smethod_1("Leaving game");
			try
			{
				uint someUIElement = Helper.smethod_1(22442744u);
				Framework.D3LeaveGame(someUIElement);
			}
			catch
			{
			}
		}
		public static int PlayersInCurrentGame()
		{
			int result;
			try
			{
				uint num = Helper.smethod_1(23094640u);
				if (num == 0u)
				{
					result = 0;
				}
				else
				{
					num = Helper.smethod_1(num + 16u);
					if (num == 0u)
					{
						result = 0;
					}
					else
					{
						num = Helper.smethod_1(num + 24u);
						if (num == 0u)
						{
							result = 0;
						}
						else
						{
							num = Helper.smethod_1(num + 1556u);
							result = (int)num;
						}
					}
				}
			}
			catch
			{
				result = 0;
			}
			return result;
		}
		public static bool IsDisconnected()
		{
			return Framework.PlayersInCurrentGame() == 0 || !Framework.IsConnectedToBattleNet;
		}
		[CompilerGenerated]
		private static void smethod_5()
		{
			try
			{
				Framework.smethod_3();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error in hook!\n\n" + ex.Message);
			}
		}
		[CompilerGenerated]
		private static bool smethod_6(Scene scene_0)
		{
			return scene_0.SceneId == Framework.Hero.CurrentSceneId;
		}
	}
}
