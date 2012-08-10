using D3Core.Classes;
using Newtonsoft.Json;
using System;
namespace HellBuddy.Scripting
{
	[JsonObject(MemberSerialization = MemberSerialization.OptOut)]
	[Serializable]
	internal class RelativeMove : ScriptActionBase
	{
		public string SceneName;
		public Vector3 CenterOffset;
		public override string ToString()
		{
			return string.Format("Move to: ({0:0}, {1:0}) inside the scene \"{2}\"", this.CenterOffset.float_0, this.CenterOffset.float_1, this.SceneName);
		}
	}
}
