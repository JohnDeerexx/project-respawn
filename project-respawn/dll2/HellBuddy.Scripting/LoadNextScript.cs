using Newtonsoft.Json;
using System;
namespace HellBuddy.Scripting
{
	[JsonObject(MemberSerialization = MemberSerialization.OptOut)]
	[Serializable]
	internal class LoadNextScript : ScriptActionBase
	{
		public string ScriptFileName;
		public override string ToString()
		{
			return string.Format("Load next Script: \"{0}\"", this.ScriptFileName);
		}
	}
}
