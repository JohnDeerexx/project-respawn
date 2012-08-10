using Newtonsoft.Json;
using System;
namespace HellBuddy.Scripting
{
	[JsonObject(MemberSerialization = MemberSerialization.OptOut)]
	[Serializable]
	internal class ForceTownState : ScriptActionBase
	{
		public override string ToString()
		{
			return "Go to stash, salvage items, repair";
		}
	}
}
