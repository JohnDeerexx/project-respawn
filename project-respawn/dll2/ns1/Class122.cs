using D3Core;
using D3Core.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
namespace ns1
{
	internal class Class122 : Interface1
	{
		[CompilerGenerated]
		private sealed class Class123
		{
			public Vector3 vector3_0;
			public Class122 class122_0;
			public float method_0(Class39 class39_0)
			{
				return Vector3.DistanceSquared(class39_0.Actor.Position, this.vector3_0);
			}
		}
		public static string string_0 = "";
		private float float_0;
		public Class122(float float_1)
		{
			this.float_0 = float_1 * float_1;
		}
		public Class39 imethod_0(IEnumerable<Class39> ienumerable_0)
		{
			Class122.Class123 @class = new Class122.Class123();
			@class.class122_0 = this;
			Vector3 position = Framework.Hero.Position;
			IEnumerable<Class39> enumerable = ienumerable_0.Where(new Func<Class39, bool>(this.method_0));
			Vector3 vector = Vector3.Zero;
			foreach (Class39 current in enumerable)
			{
				Vector3 value = position - current.Actor.Position;
				value.Normalize();
				vector += value;
			}
			vector.Normalize();
			@class.vector3_0 = position + vector * 5f;
			Class39 class2 = ienumerable_0.OrderBy(new Func<Class39, float>(@class.method_0)).FirstOrDefault<Class39>();
			Class39 result;
			if (class2 != null)
			{
				Class122.string_0 = string.Concat(new object[]
				{
					class2.Actor.Modelname,
					" - ",
					class2.Actor.Position.ToString(),
					" - ",
					Environment.TickCount
				});
				result = class2;
			}
			else
			{
				result = null;
			}
			return result;
		}
		[CompilerGenerated]
		private bool method_0(Class39 class39_0)
		{
			return class39_0.DistanceSquared < this.float_0;
		}
	}
}
