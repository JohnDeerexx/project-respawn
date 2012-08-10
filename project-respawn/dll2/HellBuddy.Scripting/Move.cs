using D3Core.Classes;
using Newtonsoft.Json;
using System;
namespace HellBuddy.Scripting
{
	[JsonObject(MemberSerialization = MemberSerialization.OptOut)]
	[Serializable]
	internal class Move : ScriptActionBase
	{
		public Vector3 Target;
		public override string ToString()
		{
			return string.Format("Move to position ({0:0}, {1:0})", this.Target.float_0, this.Target.float_1);
		}
	}
}
