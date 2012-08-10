using D3Core;
using System;
using System.Runtime.CompilerServices;
namespace ns1
{
	internal class Class115
	{
		[CompilerGenerated]
		private D3Power d3Power_0;
		[CompilerGenerated]
		private float float_0;
		[CompilerGenerated]
		private float float_1;
		[CompilerGenerated]
		private int int_0;
		public D3Power Power
		{
			get;
			private set;
		}
		public float Range
		{
			get;
			private set;
		}
		public float RangeSq
		{
			get;
			private set;
		}
		public int MinimumTargets
		{
			get;
			private set;
		}
		public Class115(D3Power d3Power_1, float float_2, int int_1 = 3)
		{
			this.Power = d3Power_1;
			this.Range = float_2;
			this.MinimumTargets = int_1;
			this.RangeSq = float_2 * float_2;
		}
	}
}
