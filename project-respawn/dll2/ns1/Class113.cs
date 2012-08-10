using D3Core;
using D3Core.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
namespace ns1
{
	internal class Class113 : Interface0
	{
		[CompilerGenerated]
		private sealed class Class114
		{
			public D3Spell d3Spell_0;
			public bool method_0(Class115 class115_0)
			{
				return class115_0.Power == this.d3Spell_0.D3Power;
			}
		}
		[CompilerGenerated]
		private sealed class Class116
		{
			public Class113.Class114 class114_0;
			public Class115 class115_0;
			public bool method_0(Class39 class39_0)
			{
				return class39_0.DistanceSquared < this.class115_0.RangeSq;
			}
		}
		public static string string_0 = "";
		[CompilerGenerated]
		private static Func<Class39, bool> func_0;
		[CompilerGenerated]
		private static Func<KeyValuePair<int, D3Spell>, D3Spell> func_1;
		[CompilerGenerated]
		private static Func<D3Spell, bool> func_2;
		[CompilerGenerated]
		private static Func<D3Spell, bool> func_3;
		public D3Power imethod_0(IEnumerable<Class39> ienumerable_0)
		{
			if (Class113.func_0 == null)
			{
				Class113.func_0 = new Func<Class39, bool>(Class113.smethod_0);
			}
			List<Class39> source = ienumerable_0.Where(Class113.func_0).ToList<Class39>();
			IEnumerable<KeyValuePair<int, D3Spell>> arg_50_0 = Framework.Hero.GetActiveSpells();
			if (Class113.func_1 == null)
			{
				Class113.func_1 = new Func<KeyValuePair<int, D3Spell>, D3Spell>(Class113.smethod_1);
			}
			IEnumerable<D3Spell> arg_72_0 = arg_50_0.Select(Class113.func_1);
			if (Class113.func_2 == null)
			{
				Class113.func_2 = new Func<D3Spell, bool>(Class113.smethod_2);
			}
			IEnumerable<D3Spell> arg_94_0 = arg_72_0.Where(Class113.func_2);
			if (Class113.func_3 == null)
			{
				Class113.func_3 = new Func<D3Spell, bool>(Class113.smethod_3);
			}
			List<D3Spell> list = arg_94_0.Where(Class113.func_3).smethod_2<D3Spell>().ToList<D3Spell>();
			List<D3Power> list2 = new List<D3Power>(8);
			D3Power result;
			using (List<D3Spell>.Enumerator enumerator = list.GetEnumerator())
			{
				Func<Class115, bool> func = null;
				Class113.Class114 @class = new Class113.Class114();
				while (enumerator.MoveNext())
				{
					@class.d3Spell_0 = enumerator.Current;
					Class113.Class116 class2 = new Class113.Class116();
					class2.class114_0 = @class;
					if (!Class117.smethod_0(@class.d3Spell_0.D3Power))
					{
						list2.Add(@class.d3Spell_0.D3Power);
					}
					else
					{
						Class113.Class116 arg_127_0 = class2;
						IEnumerable<Class115> arg_122_0 = Class117.list_0;
						if (func == null)
						{
							func = new Func<Class115, bool>(@class.method_0);
						}
						arg_127_0.class115_0 = arg_122_0.First(func);
						List<Class39> list3 = source.Where(new Func<Class39, bool>(class2.method_0)).ToList<Class39>();
						if (list3.Count >= class2.class115_0.MinimumTargets)
						{
							Class113.string_0 = @class.d3Spell_0.ToString() + " - " + Environment.TickCount;
							result = @class.d3Spell_0.D3Power;
							return result;
						}
					}
				}
			}
			if (list2.Count > 0)
			{
				result = list2.First<D3Power>();
			}
			else
			{
				result = D3Power.Invalid;
			}
			return result;
		}
		[CompilerGenerated]
		private static bool smethod_0(Class39 class39_0)
		{
			return class39_0.DistanceSquared < 400f;
		}
		[CompilerGenerated]
		private static D3Spell smethod_1(KeyValuePair<int, D3Spell> keyValuePair_0)
		{
			return keyValuePair_0.Value;
		}
		[CompilerGenerated]
		private static bool smethod_2(D3Spell d3Spell_0)
		{
			return !d3Spell_0.IsOnCooldown;
		}
		[CompilerGenerated]
		private static bool smethod_3(D3Spell d3Spell_0)
		{
			return d3Spell_0.CanCast;
		}
	}
}
