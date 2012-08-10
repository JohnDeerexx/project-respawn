using Newtonsoft.Json;
using System;
namespace HellBuddy.Scripting
{
	[JsonObject(MemberSerialization = MemberSerialization.OptOut)]
	[Serializable]
	internal class DispatchEventScript : ScriptActionBase
	{
		public string EventScriptName;
		public override string ToString()
		{
			return string.Format("Special Script: \"{0}\"", this.EventScriptName);
		}
	}
}
