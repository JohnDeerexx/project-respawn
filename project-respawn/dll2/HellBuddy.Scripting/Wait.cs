using Newtonsoft.Json;
using System;
namespace HellBuddy.Scripting
{
	[JsonObject(MemberSerialization = MemberSerialization.OptOut)]
	[Serializable]
	internal class Wait : ScriptActionBase
	{
		public float WaitSeconds;
		public bool ScriptTime;
		public override string ToString()
		{
			return string.Format("Wait {0:0.0} seconds", this.WaitSeconds);
		}
	}
}
