using D3Core.Classes;
using System;
using System.Runtime.CompilerServices;
namespace ns1
{
	internal sealed class Class42
	{
		private const float float_0 = 120f;
		private float float_1;
		[CompilerGenerated]
		private int int_0;
		[CompilerGenerated]
		private string string_0;
		public int ModelId
		{
			get;
			set;
		}
		public string ModelNameSubstring
		{
			get;
			set;
		}
		public Class42()
		{
			this.ModelId = -1;
			this.method_1(-1f);
			this.ModelNameSubstring = string.Empty;
		}
		public float method_0()
		{
			return this.float_1;
		}
		public void method_1(float float_2)
		{
			if (float_2 > 120f)
			{
				this.float_1 = 120f;
			}
			else
			{
				this.float_1 = float_2;
			}
		}
		public bool method_2(D3Actor d3Actor_0)
		{
			bool result;
			if (this.ModelId != -1)
			{
				result = ((ulong)d3Actor_0.UInt32_0 == (ulong)((long)this.ModelId));
			}
			else
			{
				result = d3Actor_0.Modelname.Contains(this.ModelNameSubstring);
			}
			return result;
		}
	}
}
