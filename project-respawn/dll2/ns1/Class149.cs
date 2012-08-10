using System;
namespace ns1
{
	internal class Class149
	{
		private Random random_0;
		private int int_0;
		private double[] double_0;
		private double double_1 = 1.0;
		public Class149(int int_1 = 20, double double_2 = 1.0)
		{
			if (double_2 < 1.0)
			{
				throw new Exception("Compression must be >= 1");
			}
			this.random_0 = new Random();
			this.double_0 = new double[int_1];
			this.int_0 = 0;
			this.double_1 = 1.0 / double_2;
			this.method_0();
		}
		private void method_0()
		{
			double num = 0.0;
			for (int i = 0; i < this.double_0.Length; i++)
			{
				this.double_0[i] = 2.0 * this.method_1();
				num += this.double_0[i];
			}
			double num2 = num / (double)this.double_0.Length;
			double num3 = 1.0 / num2;
			for (int i = 0; i < this.double_0.Length; i++)
			{
				double num4 = this.double_0[i];
				num4 *= num3;
				num4 -= 1.0;
				num4 *= this.double_1;
				this.double_0[i] = num4;
			}
			num = 0.0;
			double num5 = 0.0;
			double num6 = 0.0;
			for (int i = 0; i < this.double_0.Length; i++)
			{
				if (this.double_0[i] < num5)
				{
					num5 = this.double_0[i];
				}
				if (this.double_0[i] > num6)
				{
					num6 = this.double_0[i];
				}
				num += this.double_0[i];
			}
			num2 = num / (double)this.double_0.Length;
		}
		private double method_1()
		{
			double num = this.random_0.NextDouble() + this.random_0.NextDouble() + this.random_0.NextDouble();
			return num / 3.0;
		}
		public double method_2()
		{
			double result = this.double_0[this.int_0];
			this.int_0++;
			if (this.int_0 >= this.double_0.Length)
			{
				this.int_0 = 0;
				this.method_0();
			}
			return result;
		}
	}
}
