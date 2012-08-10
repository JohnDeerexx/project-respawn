using System;
namespace D3Core
{
	public static class D3QuestStatus
	{
		private const int int_0 = 276;
		private static uint uint_0 = 0u;
		private static byte[] byte_0 = new byte[276];
		private static int int_1 = 0;
		public static int LastQuestStatusChange
		{
			get
			{
				return D3QuestStatus.int_1;
			}
		}
		public static byte[] GetQuestData()
		{
			uint num = Framework.GetCurrentQuest();
			byte[] result;
			if (num != 0u && num != 4294967295u)
			{
				result = Helper.ReadBytes(num, 276);
			}
			else
			{
				result = null;
			}
			return result;
		}
		internal static void smethod_0()
		{
			uint num = Framework.GetCurrentQuest();
			byte[] array = Helper.ReadBytes(num, 276);
			if (D3QuestStatus.uint_0 == num)
			{
				bool flag = true;
				int i = 0;
				while (i < 276)
				{
					if (array[i] == D3QuestStatus.byte_0[i])
					{
						i++;
					}
					else
					{
						flag = false;
					
						if (!flag)
						{
							D3QuestStatus.byte_0 = array;
							D3QuestStatus.int_1 = Environment.TickCount;
							return;
						}
						return;
					}
				}
				
			}
			D3QuestStatus.uint_0 = num;
			D3QuestStatus.int_1 = Environment.TickCount;
			D3QuestStatus.byte_0 = array;
		}
	}
}
