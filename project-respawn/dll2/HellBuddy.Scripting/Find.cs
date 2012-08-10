using Newtonsoft.Json;
using System;
namespace HellBuddy.Scripting
{
	[JsonObject(MemberSerialization = MemberSerialization.OptOut)]
	[Serializable]
	internal class Find : ScriptActionBase
	{
		public string SceneNameSubstring;
		public string ActorNameSubstring;
		public override string ToString()
		{
			return string.Format("Search for scene: {0} and unit: {1}", this.SceneNameSubstring, this.ActorNameSubstring);
		}
	}
}
