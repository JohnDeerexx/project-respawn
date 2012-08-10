using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
namespace ns0
{
	[CompilerGenerated]
	internal sealed class Class21<T, U>
	{
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly T gparam_0;
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly U gparam_1;
		public T Object
		{
			get
			{
				return this.gparam_0;
			}
		}
		public U Value
		{
			get
			{
				return this.gparam_1;
			}
		}
		[DebuggerHidden]
		public Class21(T gparam_2, U gparam_3)
		{
			this.gparam_0 = gparam_2;
			this.gparam_1 = gparam_3;
		}
		[DebuggerHidden]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("{ Object = ");
			stringBuilder.Append(this.gparam_0);
			stringBuilder.Append(", Value = ");
			stringBuilder.Append(this.gparam_1);
			stringBuilder.Append(" }");
			return stringBuilder.ToString();
		}
		[DebuggerHidden]
		public override bool Equals(object value)
		{
			Class21<T, U> @class = value as Class21<T, U>;
			return @class != null && EqualityComparer<T>.Default.Equals(this.gparam_0, @class.gparam_0) && EqualityComparer<U>.Default.Equals(this.gparam_1, @class.gparam_1);
		}
		[DebuggerHidden]
		public override int GetHashCode()
		{
			long num =  EqualityComparer<T>.Default.GetHashCode(this.gparam_0);
			return EqualityComparer<U>.Default.GetHashCode(this.gparam_1);
		}
	}
}
