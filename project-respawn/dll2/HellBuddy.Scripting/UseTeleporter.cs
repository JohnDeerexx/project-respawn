using Newtonsoft.Json;
using System;
namespace HellBuddy.Scripting
{
	[JsonObject(MemberSerialization = MemberSerialization.OptOut)]
	[Serializable]
	internal class UseTeleporter : ScriptActionBase
	{
		public int TeleportIndex;
		public override string ToString()
		{
			return string.Format("Waypoint Teleport index: \"{0}\"", this.TeleportIndex);
		}
	}
}
