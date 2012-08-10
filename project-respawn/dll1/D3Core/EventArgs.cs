using System;
using System.Runtime.CompilerServices;
namespace D3Core
{
	public sealed class EventArgs<T> : EventArgs
	{
		[CompilerGenerated]
		private T gparam_0;
		public T Value
		{
			get;
			private set;
		}
		public EventArgs(T value)
		{
			this.Value = value;
		}
	}
}
