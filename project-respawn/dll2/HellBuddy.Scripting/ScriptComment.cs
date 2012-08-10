using Newtonsoft.Json;
using System;
namespace HellBuddy.Scripting
{
	[JsonObject(MemberSerialization = MemberSerialization.OptOut)]
	[Serializable]
	public class ScriptComment : ScriptActionBase
	{
		public string Text;
		public override string ToString()
		{
			return "     " + this.Text;
		}
	}
}
