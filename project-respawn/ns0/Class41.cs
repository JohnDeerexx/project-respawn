using System;
using System.Reflection;
using System.Runtime.CompilerServices;
namespace ns0
{
	[DefaultMember("Item")]
	internal sealed class Class41<T> where T : new()
	{
		private T[] gparam_0;
		[CompilerGenerated]
		private int int_0;
		public int Count
		{
			get;
			private set;
		}
		public Class41(int int_1)
		{
			this.Count = 0;
			this.gparam_0 = new T[int_1];
			for (int i = 0; i < int_1; i++)
			{
				this.gparam_0[i] = ((default(T) == null) ? Activator.CreateInstance<T>() : default(T));
			}
		}
		public int method_0()
		{
			return this.gparam_0.Length;
		}
		public void method_1(int int_1)
		{
			this.Count--;
			T t = this.gparam_0[int_1];
			this.gparam_0[int_1] = this.gparam_0[this.Count];
			this.gparam_0[this.Count] = t;
		}
		public int method_2()
		{
			if (this.Count == this.gparam_0.Length)
			{
				return -1;
			}
			int count = this.Count;
			this.Count++;
			return count;
		}
		public T method_3(int int_1)
		{
			return this.gparam_0[int_1];
		}
		public void method_4(int int_1, T gparam_1)
		{
			this.gparam_0[int_1] = gparam_1;
		}
		internal void method_5()
		{
			this.Count = 0;
		}
	}
}
