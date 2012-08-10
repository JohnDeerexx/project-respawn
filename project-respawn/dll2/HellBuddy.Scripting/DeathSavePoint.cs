using Newtonsoft.Json;
using System;
namespace HellBuddy.Scripting
{
	[JsonObject(MemberSerialization = MemberSerialization.OptOut)]
	[Serializable]
	public class DeathSavePoint : ScriptActionBase
	{
		public override string ToString()
		{
			return "== SAVEPOINT == Script will jump here on deah";
		}
	}
}
