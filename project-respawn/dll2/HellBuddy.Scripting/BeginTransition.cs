using Newtonsoft.Json;
using System;
namespace HellBuddy.Scripting
{
	[JsonObject(MemberSerialization = MemberSerialization.OptOut)]
	[Serializable]
	public class BeginTransition : ScriptActionBase
	{
		public override string ToString()
		{
			return string.Format("Begin World/Quest Transition", new object[0]);
		}
	}
}
