using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
namespace ns0
{
	[DefaultMember("Item")]
	internal sealed class Class42<T> : IEnumerable
	{
		private static Random random_0 = new Random(Environment.TickCount);
		public T[] gparam_0;
		[CompilerGenerated]
		private int int_0;
		public int Count
		{
			get;
			private set;
		}
		public Class42(int int_1)
		{
			this.Count = 0;
			this.gparam_0 = new T[int_1];
		}
		public Class42(IList<T> ilist_0)
		{
			this.gparam_0 = new T[ilist_0.Count];
			for (int i = 0; i < ilist_0.Count; i++)
			{
				this.gparam_0[i] = ilist_0[i];
			}
			this.Count = this.gparam_0.Length;
		}
		public int method_0()
		{
			return this.gparam_0.Length;
		}
		public void method_1(int int_1)
		{
			this.Count--;
			this.gparam_0[int_1] = this.gparam_0[this.Count];
			this.gparam_0[this.Count] = default(T);
		}
		public void method_2(Func<T, bool> func_0)
		{
			for (int i = 0; i < this.Count; i++)
			{
				if (func_0(this.gparam_0[i]))
				{
					this.method_1(i--);
				}
			}
		}
		public void method_3(T gparam_1)
		{
			if (this.Count == this.gparam_0.Length)
			{
				this.method_4();
			}
			this.gparam_0[this.Count] = gparam_1;
			this.Count++;
		}
		private void method_4()
		{
			T[] sourceArray = this.gparam_0;
			this.gparam_0 = new T[this.gparam_0.Length * 2];
			Array.Copy(sourceArray, this.gparam_0, this.Count);
		}
		public T method_5(int int_1)
		{
			return this.gparam_0[int_1];
		}
		public void method_6(int int_1, T gparam_1)
		{
			this.gparam_0[int_1] = gparam_1;
		}
		internal void method_7()
		{
			for (int i = 0; i < this.Count; i++)
			{
				this.gparam_0[i] = default(T);
			}
			this.Count = 0;
		}
		internal bool method_8(object object_0)
		{
			for (int i = 0; i < this.Count; i++)
			{
				if (object.ReferenceEquals(object_0, this.gparam_0[i]))
				{
					return true;
				}
			}
			return false;
		}
		internal void method_9()
		{
			T[] array = new T[this.gparam_0.Length];
			for (int i = 0; i < array.Length; i++)
			{
				int int_ = Class42<T>.random_0.Next(this.Count);
				T t = this.method_5(int_);
				array[i] = t;
				this.method_1(int_);
			}
			this.gparam_0 = array;
		}
		public IEnumerator GetEnumerator()
		{
			return this.gparam_0.GetEnumerator();
		}
	}
}
