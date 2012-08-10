using Newtonsoft.Json;
using System;
namespace HellBuddy.Scripting
{
	[JsonObject(MemberSerialization = MemberSerialization.OptOut)]
	[Serializable]
	public class OverrideAggroRange : ScriptActionBase
	{
		public float NewRange;
		public bool ResetOnWorldChange;
		public int MaximumOverrideTimeSeconds;
		public override string ToString()
		{
			string result;
			if (this.ResetOnWorldChange && this.MaximumOverrideTimeSeconds == -1)
			{
				result = string.Format("Override Aggro range with: {0} and reset when changing world", this.NewRange);
			}
			else
			{
				if (!this.ResetOnWorldChange && this.MaximumOverrideTimeSeconds > 0)
				{
					result = string.Format("Override Aggro range with: {0} and reset after {1} seconds", this.NewRange, this.MaximumOverrideTimeSeconds);
				}
				else
				{
					result = string.Format("Override Aggro range with {0} ({1}, {2})", this.NewRange, this.ResetOnWorldChange, this.MaximumOverrideTimeSeconds);
				}
			}
			return result;
		}
	}
}
