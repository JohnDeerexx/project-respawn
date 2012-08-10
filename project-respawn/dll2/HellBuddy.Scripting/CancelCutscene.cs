using Newtonsoft.Json;
using System;
namespace HellBuddy.Scripting
{
	[JsonObject(MemberSerialization = MemberSerialization.OptOut)]
	[Serializable]
	internal class CancelCutscene : ScriptActionBase
	{
		public override string ToString()
		{
			return "Abort Dialog / Cutscene / Cinematic";
		}
	}
}
