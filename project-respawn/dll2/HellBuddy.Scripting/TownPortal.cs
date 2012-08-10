using Newtonsoft.Json;
using System;
namespace HellBuddy.Scripting
{
	[JsonObject(MemberSerialization = MemberSerialization.OptOut)]
	[Serializable]
	internal class TownPortal : ScriptActionBase
	{
		public override string ToString()
		{
			return string.Format("Use Townportal Spell", new object[0]);
		}
	}
}
