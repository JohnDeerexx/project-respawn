using System;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Threading;
namespace D3Core
{
	public static class D3CharSelect
	{
		private static Action action_0 = null;
		private static Action action_1 = null;
		private static Action action_2 = null;
		private static Action action_3 = null;
		[CompilerGenerated]
		private static Action action_4;
		private static uint smethod_0()
		{
			uint num = Helper.smethod_1(23094640u);
			num = Helper.smethod_1(num + 16u);
			return Helper.smethod_1(num + 12u);
		}
		[HandleProcessCorruptedStateExceptions]
		public static void Logon_StartNew(D3Quest StartQuest, uint questStep1, uint questStep2)
		{
			if (D3CharSelect.action_0 == null)
			{
				D3CharSelect.action_0 = Helper.RegisterDelegate<Action>(13028784u);
				D3CharSelect.action_1 = Helper.RegisterDelegate<Action>(12994720u);
				D3CharSelect.action_2 = Helper.RegisterDelegate<Action>(13496768u);
				D3CharSelect.action_3 = Helper.RegisterDelegate<Action>(11770176u);
			}
			Framework.RunInD3ContextSynced(D3CharSelect.action_3);
			Thread.Sleep(50);
			Framework.RunInD3ContextSynced(D3CharSelect.action_1);
			int int_ = 0;
			string text = StartQuest.ToString();
			if (text.StartsWith("A1"))
			{
				int_ = 0;
			}
			else
			{
				if (text.StartsWith("A2"))
				{
					int_ = 25600;
				}
				else
				{
					if (text.StartsWith("A3"))
					{
						int_ = 51200;
					}
					else
					{
						if (text.StartsWith("A4"))
						{
							int_ = 76800;
						}
					}
				}
			}
			uint num = D3CharSelect.smethod_0();
			uint num2 = num + 1572u;
			uint uint_ = num2 + 24u;
			uint uint_2 = num2 + 28u;
			uint uint_3 = num2 + 32u;
			uint uint_4 = num2 + 36u;
			Helper.smethod_2(uint_, int_);
			Helper.smethod_2(uint_2, (int)StartQuest);
			Helper.smethod_2(uint_3, (int)questStep1);
			Helper.smethod_2(uint_4, (int)questStep2);
			Framework.RunInD3ContextSynced(D3CharSelect.action_2);
			Helper.smethod_2(uint_, int_);
			Helper.smethod_2(uint_2, (int)StartQuest);
			Helper.smethod_2(uint_3, (int)questStep1);
			Helper.smethod_2(uint_4, (int)questStep2);
			Framework.RunInD3ContextSynced(D3CharSelect.action_0);
			if (D3CharSelect.action_4 == null)
			{
				D3CharSelect.action_4 = new Action(D3CharSelect.smethod_1);
			}
			Framework.RunInD3ContextSynced(D3CharSelect.action_4);
		}
		[HandleProcessCorruptedStateExceptions]
		public static void Startgame(D3Quest quest, uint questStep1, uint questStep2, Difficulty difficulty = Difficulty.DontChange)
		{
			D3CharSelect.action_0 = Helper.RegisterDelegate<Action>(13028784u);
			uint num = D3CharSelect.smethod_0() + 1572u;
			int uint_ = 0;
			string text = quest.ToString();
			if (text.StartsWith("A2"))
			{
				uint_ = 100;
			}
			else
			{
				if (text.StartsWith("A3"))
				{
					uint_ = 200;
				}
				else
				{
					if (text.StartsWith("A4"))
					{
						uint_ = 300;
					}
				}
			}
			if (difficulty != Difficulty.DontChange)
			{
				Helper.smethod_3(num + 20u, (uint)difficulty);
			}
			Helper.smethod_3(num + 24u, (uint)uint_);
			Helper.smethod_3(num + 28u, (uint)quest);
			Helper.smethod_3(num + 32u, questStep1);
			Helper.smethod_3(num + 36u, questStep2);
			Framework.RunInD3ContextSynced(D3CharSelect.action_0);
		}
		public static void GetQuestValues(out int questId, out int questStep1, out int questStep2)
		{
			uint num = D3CharSelect.smethod_0();
			uint num2 = num + 1572u;
			uint uint_ = num2 + 28u;
			uint uint_2 = num2 + 32u;
			uint uint_3 = num2 + 36u;
			questId = (int)Helper.smethod_1(uint_);
			questStep1 = (int)Helper.smethod_1(uint_2);
			questStep2 = (int)Helper.smethod_1(uint_3);
		}
		[CompilerGenerated]
		private static void smethod_1()
		{
			try
			{
				Framework.ModalNotificationOK();
			}
			catch
			{
			}
		}
	}
}
