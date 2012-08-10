using System;
namespace ns0
{
	internal sealed class Class43
	{
		private float[] float_0;
		private int int_0;
		private int int_1;
		private float float_1;
		internal Class43(int int_2)
		{
			this.int_0 = int_2;
			this.float_0 = new float[int_2];
		}
		internal void method_0(float float_2)
		{
			if (this.int_1 == this.int_0)
			{
				this.int_1 = 0;
				this.float_1 = 0f;
				for (int i = 0; i < this.int_0; i++)
				{
					this.float_1 += this.float_0[i];
				}
			}
			this.float_1 -= this.float_0[this.int_1];
			this.float_1 += float_2;
			this.float_0[this.int_1] = float_2;
			this.int_1++;
		}
		internal float method_1()
		{
			return this.float_1 / (float)this.int_0;
		}
	}
}
