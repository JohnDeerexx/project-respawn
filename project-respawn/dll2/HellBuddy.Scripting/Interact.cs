using Newtonsoft.Json;
using System;
namespace HellBuddy.Scripting
{
	[JsonObject(MemberSerialization = MemberSerialization.OptOut)]
	[Serializable]
	public class Interact : ScriptActionBase
	{
		public string TargetSubstring;
		public bool ExactMatch;
		public bool AllowFail;
		public bool SkipBeginAwait;
		public override string ToString()
		{
			return string.Format("Interact with \"{0}\" {1}{2}", this.TargetSubstring, this.ExactMatch ? "" : "as name-part", this.AllowFail ? " and ignore error" : " and ABORT on error");
		}
	}
}
