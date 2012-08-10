using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
namespace ns0
{
	internal sealed class Class39<T, U, V>
	{
		private sealed class Class40<W, X, Y>
		{
			[CompilerGenerated]
			private W gparam_0;
			[CompilerGenerated]
			private X gparam_1;
			[CompilerGenerated]
			private Y gparam_2;
			[CompilerGenerated]
			private int int_0;
			[CompilerGenerated]
			private int int_1;
			[CompilerGenerated]
			private int int_2;
			public W Parameter1
			{
				get;
				set;
			}
			public X Parameter2
			{
				get;
				set;
			}
			public Y Result
			{
				get;
				set;
			}
			public int AccessCount
			{
				get;
				set;
			}
			public int LastUsedTick
			{
				get;
				set;
			}
			public int ExpiryTick
			{
				get;
				set;
			}
		}
		private Dictionary<T, Dictionary<U, Class39<T, U, V>.Class40<T, U, V>>> dictionary_0;
		private int int_0;
		private int int_1;
		private int int_2 = 230;
		public Class39(TimeSpan timeSpan_0)
		{
			this.int_0 = (int)timeSpan_0.TotalMilliseconds;
			this.dictionary_0 = new Dictionary<T, Dictionary<U, Class39<T, U, V>.Class40<T, U, V>>>();
		}
		public void method_0(T gparam_0, U gparam_1, V gparam_2)
		{
			Class39<T, U, V>.Class40<T, U, V> @class = new Class39<T, U, V>.Class40<T, U, V>();
			@class.AccessCount = 0;
			@class.ExpiryTick = Environment.TickCount + this.int_0;
			@class.LastUsedTick = Environment.TickCount;
			@class.Parameter1 = gparam_0;
			@class.Parameter2 = gparam_1;
			@class.Result = gparam_2;
			Dictionary<U, Class39<T, U, V>.Class40<T, U, V>> dictionary;
			if (this.dictionary_0.TryGetValue(gparam_0, out dictionary))
			{
				dictionary[gparam_1] = @class;
			}
			else
			{
				dictionary = new Dictionary<U, Class39<T, U, V>.Class40<T, U, V>>();
				dictionary[gparam_1] = @class;
				this.dictionary_0[gparam_0] = dictionary;
			}
			if (this.int_1 < Environment.TickCount)
			{
				this.int_1 = Environment.TickCount + this.int_2;
				this.method_1();
			}
		}
		private void method_1()
		{
			int tickCount = Environment.TickCount;
			List<U> list = new List<U>(50);
			foreach (KeyValuePair<T, Dictionary<U, Class39<T, U, V>.Class40<T, U, V>>> current in this.dictionary_0)
			{
				list.Clear();
				foreach (KeyValuePair<U, Class39<T, U, V>.Class40<T, U, V>> current2 in current.Value)
				{
					if (current2.Value.ExpiryTick < tickCount)
					{
						list.Add(current2.Key);
					}
				}
				foreach (U current3 in list)
				{
					current.Value.Remove(current3);
				}
			}
		}
		public bool method_2(T gparam_0, U gparam_1, out V gparam_2)
		{
			Dictionary<U, Class39<T, U, V>.Class40<T, U, V>> dictionary;
			Class39<T, U, V>.Class40<T, U, V> @class;
			if (this.dictionary_0.TryGetValue(gparam_0, out dictionary) && dictionary.TryGetValue(gparam_1, out @class))
			{
				gparam_2 = @class.Result;
				return true;
			}
			gparam_2 = default(V);
			return false;
		}
	}
}
