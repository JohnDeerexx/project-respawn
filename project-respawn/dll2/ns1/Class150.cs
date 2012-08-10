using System;
using System.Collections.Generic;
using System.Threading;
namespace ns1
{
	internal class Class150
	{
		private int int_0 = 0;
		private SortedSet<int> sortedSet_0 = new SortedSet<int>();
		private SortedSet<int> sortedSet_1 = new SortedSet<int>();
		public Class150()
		{
		}
		public Class150(int int_1)
		{
			this.int_0 = int_1;
		}
		public int method_0()
		{
			bool flag = false;
			int result;
			try
			{
				Monitor.Enter(this, ref flag);
				if (this.sortedSet_0.Count > 0)
				{
					int num = this.sortedSet_0.Min;
					this.sortedSet_0.Remove(num);
					this.sortedSet_1.Add(num);
					result = num;
				}
				else
				{
					int num = this.int_0++;
					this.sortedSet_1.Add(num);
					result = num;
				}
			}
			finally
			{
				if (flag)
				{
					Monitor.Exit(this);
				}
			}
			return result;
		}
		public void method_1(int int_1)
		{
			bool flag = false;
			try
			{
				Monitor.Enter(this, ref flag);
				if (!this.sortedSet_1.Remove(int_1))
				{
					throw new Exception("Returning unused id");
				}
				this.sortedSet_0.Add(int_1);
			}
			finally
			{
				if (flag)
				{
					Monitor.Exit(this);
				}
			}
		}
	}
}
