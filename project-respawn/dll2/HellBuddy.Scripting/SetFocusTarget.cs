using Newtonsoft.Json;
using System;
namespace HellBuddy.Scripting
{
	[JsonObject(MemberSerialization = MemberSerialization.OptOut)]
	[Serializable]
	public class SetFocusTarget : ScriptActionBase
	{
		public string TargetSubstring;
		public override string ToString()
		{
			return string.Format("Set focus target to: {0}", this.TargetSubstring);
		}
	}
}
