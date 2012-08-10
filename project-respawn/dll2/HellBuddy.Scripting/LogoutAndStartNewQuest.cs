using Newtonsoft.Json;
using System;
namespace HellBuddy.Scripting
{
	[JsonObject(MemberSerialization = MemberSerialization.OptOut)]
	[Serializable]
	public class LogoutAndStartNewQuest : ScriptActionBase
	{
		public string NewScriptFile;
		public bool TaskStarted;
		public override string ToString()
		{
			return "Logout and start: " + this.NewScriptFile;
		}
	}
}
