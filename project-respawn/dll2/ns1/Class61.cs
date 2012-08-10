using D3Core;
using HellBuddy.Scripting;
using System;
using System.Runtime.CompilerServices;
namespace ns1
{
	internal class Class61
	{
		private TransitionAwait.TransitionType? transitionType_0;
		private bool bool_0 = false;
		[CompilerGenerated]
		private int int_0;
		[CompilerGenerated]
		private byte[] byte_0;
		[CompilerGenerated]
		private string string_0;
		public int SavedScriptIndex
		{
			get;
			set;
		}
		private byte[] SavedQuestState
		{
			get;
			set;
		}
		private string SavedWorldZone
		{
			get;
			set;
		}
		public Class61(int int_1)
		{
			this.SavedScriptIndex = int_1;
			this.SavedQuestState = D3QuestStatus.GetQuestData();
			this.SavedWorldZone = Framework.World + "-" + Framework.Scene;
		}
		internal void method_0(TransitionAwait.TransitionType transitionType_1)
		{
			if (!this.transitionType_0.HasValue)
			{
				this.transitionType_0 = new TransitionAwait.TransitionType?(transitionType_1);
			}
		}
		internal bool method_1()
		{
			bool result;
			if (this.bool_0)
			{
				result = true;
			}
			else
			{
				if (this.transitionType_0.HasValue)
				{
					string b = Framework.World + "-" + Framework.Scene;
					byte[] questData = D3QuestStatus.GetQuestData();
					bool flag = this.SavedWorldZone != b;
					bool flag2 = false;
					for (int i = 0; i < this.SavedQuestState.Length; i++)
					{
						if (this.SavedQuestState[i] != questData[i])
						{
							flag2 = true;
							IL_80:
							if (this.transitionType_0 == TransitionAwait.TransitionType.World)
							{
								if (flag)
								{
									this.bool_0 = true;
									result = true;
									return result;
								}
							}
							else
							{
								if (this.transitionType_0 == TransitionAwait.TransitionType.Quest)
								{
									if (flag2)
									{
										this.bool_0 = true;
										result = true;
										return result;
									}
								}
								else
								{
									if (flag && flag2)
									{
										this.bool_0 = true;
										result = true;
										return result;
									}
								}
							}
							result = false;
							return result;
						}
					}
					
				}
				result = false;
			}
			return result;
		}
	}
}
