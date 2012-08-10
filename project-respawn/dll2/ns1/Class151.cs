using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
namespace ns1
{
	internal class Class151<T, U, V>
	{
		private class Class152<W, X, Y>
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
		private Dictionary<T, Dictionary<U, Class151<T, U, V>.Class152<T, U, V>>> dictionary_0;
		private int int_0;
		private int int_1 = 0;
		private int int_2 = 230;
		public Class151(TimeSpan timeSpan_0)
		{
			this.int_0 = (int)timeSpan_0.TotalMilliseconds;
			this.dictionary_0 = new Dictionary<T, Dictionary<U, Class151<T, U, V>.Class152<T, U, V>>>();
		}
		public void method_0(T gparam_0, U gparam_1, V gparam_2)
		{
			Class151<T, U, V>.Class152<T, U, V> @class = new Class151<T, U, V>.Class152<T, U, V>();
			@class.AccessCount = 0;
			@class.ExpiryTick = Environment.TickCount + this.int_0;
			@class.LastUsedTick = Environment.TickCount;
			@class.Parameter1 = gparam_0;
			@class.Parameter2 = gparam_1;
			@class.Result = gparam_2;
			Dictionary<U, Class151<T, U, V>.Class152<T, U, V>> dictionary;
			if (this.dictionary_0.TryGetValue(gparam_0, out dictionary))
			{
				dictionary[gparam_1] = @class;
			}
			else
			{
				dictionary = new Dictionary<U, Class151<T, U, V>.Class152<T, U, V>>();
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
			foreach (KeyValuePair<T, Dictionary<U, Class151<T, U, V>.Class152<T, U, V>>> current in this.dictionary_0)
			{
				list.Clear();
				foreach (KeyValuePair<U, Class151<T, U, V>.Class152<T, U, V>> current2 in current.Value)
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
			Dictionary<U, Class151<T, U, V>.Class152<T, U, V>> dictionary;
			Class151<T, U, V>.Class152<T, U, V> @class;
			bool result;
			if (this.dictionary_0.TryGetValue(gparam_0, out dictionary) && dictionary.TryGetValue(gparam_1, out @class))
			{
				gparam_2 = @class.Result;
				result = true;
			}
			else
			{
				gparam_2 = default(V);
				result = false;
			}
			return result;
		}
	}
}
