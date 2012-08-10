using Newtonsoft.Json;
using System;
namespace HellBuddy.Scripting
{
	[JsonObject(MemberSerialization = MemberSerialization.OptOut)]
	[Serializable]
	public class TransitionAwait : ScriptActionBase
	{
		public enum TransitionType
		{
			World,
			Quest,
			Both
		}
		public TransitionAwait.TransitionType Type;
		public override string ToString()
		{
			string result;
			if (this.Type == TransitionAwait.TransitionType.Both)
			{
				result = "Await World and Quest Transition";
			}
			else
			{
				result = string.Format("Await " + this.Type + " Transition", new object[0]);
			}
			return result;
		}
	}
}
