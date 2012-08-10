using System;
using System.Runtime.CompilerServices;
namespace ns1
{
	internal class Class41
	{
		[CompilerGenerated]
		private string string_0;
		[CompilerGenerated]
		private int int_0;
		public string ActorName
		{
			get;
			private set;
		}
		public int Expire
		{
			get;
			private set;
		}
		public Class41(string string_1, int int_1 = 4000)
		{
			this.ActorName = string_1;
			this.Expire = Environment.TickCount + int_1;
		}
	}
}
