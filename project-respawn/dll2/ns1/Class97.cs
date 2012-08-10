using D3Core;
using System;
using System.Runtime.CompilerServices;
namespace ns1
{
	internal class Class97
	{
		[CompilerGenerated]
		private string string_0;
		[CompilerGenerated]
		private int int_0;
		[CompilerGenerated]
		private bool bool_0;
		[CompilerGenerated]
		private string string_1;
		public string CompleteModelName
		{
			get;
			private set;
		}
		private int EndTick
		{
			get;
			set;
		}
		private bool ResetOnWorldChange
		{
			get;
			set;
		}
		private string IssuedWorld
		{
			get;
			set;
		}
		public Class97(string string_2, int int_1)
		{
			if (int_1 <= 0)
			{
				int_1 = Environment.TickCount + 12000;
			}
			this.EndTick = int_1;
			this.CompleteModelName = string_2;
			this.ResetOnWorldChange = false;
		}
		public Class97(string string_2, int int_1, bool bool_1)
		{
			if (int_1 <= 0)
			{
				int_1 = Environment.TickCount + 12000;
			}
			this.EndTick = int_1;
			this.CompleteModelName = string_2;
			this.ResetOnWorldChange = bool_1;
			if (bool_1)
			{
				this.IssuedWorld = Framework.World;
			}
		}
		public bool method_0()
		{
			bool result;
			if (this.ResetOnWorldChange)
			{
				if (Framework.World != this.IssuedWorld)
				{
					result = true;
					return result;
				}
			}
			else
			{
				if (Environment.TickCount > this.EndTick)
				{
					result = true;
					return result;
				}
			}
			result = false;
			return result;
		}
	}
}
