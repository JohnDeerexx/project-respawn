using D3Core.Classes;
using System;
using System.Runtime.CompilerServices;
namespace ns1
{
	internal class Class39
	{
		[CompilerGenerated]
		private D3Actor d3Actor_0;
		[CompilerGenerated]
		private float float_0;
		[CompilerGenerated]
		private bool bool_0;
		public D3Actor Actor
		{
			get;
			private set;
		}
		public float DistanceSquared
		{
			get;
			private set;
		}
		public bool DirectlyVisible
		{
			get;
			set;
		}
		public Class39(D3Actor d3Actor_1, float float_1, bool bool_1, int int_0)
		{
			this.Actor = d3Actor_1;
			this.DistanceSquared = float_1;
			this.DirectlyVisible = bool_1;
		}
	}
}
