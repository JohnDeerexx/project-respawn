using D3Core;
using D3Core.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
namespace ns1
{
	public static class GClass3
	{
		public class GClass2
		{
			public int int_0;
			public List<D3Spell> list_0;
		}
		public static List<GClass3.GClass2> list_0 = new List<GClass3.GClass2>();
		public static List<GClass3.GClass2> list_1 = new List<GClass3.GClass2>();
		public static List<GClass3.GClass2> list_2 = new List<GClass3.GClass2>();
		public static List<GClass3.GClass2> list_3 = new List<GClass3.GClass2>();
		public static List<GClass3.GClass2> list_4 = new List<GClass3.GClass2>();
		[CompilerGenerated]
		private static Func<GClass3.GClass2, int> func_0;
		[CompilerGenerated]
		private static Func<GClass3.GClass2, int> func_1;
		[CompilerGenerated]
		private static Func<GClass3.GClass2, int> func_2;
		[CompilerGenerated]
		private static Func<GClass3.GClass2, int> func_3;
		[CompilerGenerated]
		private static Func<GClass3.GClass2, int> func_4;
		internal static List<D3Spell> smethod_0()
		{
			int @int = Framework.Hero.GetInt((D3Attribute)4294963259u);
			List<D3Spell> result;
			switch (Framework.Hero.Class)
			{
			case D3Class.Wizard:
			{
				IEnumerable<GClass3.GClass2> arg_5C_0 = GClass3.list_0;
				if (GClass3.func_0 == null)
				{
					GClass3.func_0 = new Func<GClass3.GClass2, int>(GClass3.smethod_1);
				}
				using (IEnumerator<GClass3.GClass2> enumerator = arg_5C_0.OrderByDescending(GClass3.func_0).GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						GClass3.GClass2 current = enumerator.Current;
						if (@int >= current.int_0)
						{
							result = current.list_0;
							return result;
						}
					}
					goto IL_250;
				}
				break;
			}
			case D3Class.Monk:
				break;
			case D3Class.Barbarian:
				goto IL_112;
			case D3Class.DemonHunter:
				goto IL_17E;
			case D3Class.WitchDoctor:
				goto IL_1EA;
			default:
				goto IL_250;
			}
			IEnumerable<GClass3.GClass2> arg_C8_0 = GClass3.list_1;
			if (GClass3.func_1 == null)
			{
				GClass3.func_1 = new Func<GClass3.GClass2, int>(GClass3.smethod_2);
			}
			using (IEnumerator<GClass3.GClass2> enumerator = arg_C8_0.OrderByDescending(GClass3.func_1).GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					GClass3.GClass2 current = enumerator.Current;
					if (@int >= current.int_0)
					{
						result = current.list_0;
						return result;
					}
				}
				goto IL_250;
			}
			IL_112:
			IEnumerable<GClass3.GClass2> arg_134_0 = GClass3.list_2;
			if (GClass3.func_2 == null)
			{
				GClass3.func_2 = new Func<GClass3.GClass2, int>(GClass3.smethod_3);
			}
			using (IEnumerator<GClass3.GClass2> enumerator = arg_134_0.OrderByDescending(GClass3.func_2).GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					GClass3.GClass2 current = enumerator.Current;
					if (@int >= current.int_0)
					{
						result = current.list_0;
						return result;
					}
				}
				goto IL_250;
			}
			IL_17E:
			IEnumerable<GClass3.GClass2> arg_1A0_0 = GClass3.list_3;
			if (GClass3.func_3 == null)
			{
				GClass3.func_3 = new Func<GClass3.GClass2, int>(GClass3.smethod_4);
			}
			using (IEnumerator<GClass3.GClass2> enumerator = arg_1A0_0.OrderByDescending(GClass3.func_3).GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					GClass3.GClass2 current = enumerator.Current;
					if (@int >= current.int_0)
					{
						result = current.list_0;
						return result;
					}
				}
				goto IL_250;
			}
			IL_1EA:
			IEnumerable<GClass3.GClass2> arg_20C_0 = GClass3.list_4;
			if (GClass3.func_4 == null)
			{
				GClass3.func_4 = new Func<GClass3.GClass2, int>(GClass3.smethod_5);
			}
			foreach (GClass3.GClass2 current in arg_20C_0.OrderByDescending(GClass3.func_4))
			{
				GClass3.GClass2 current1;
				if (@int >= current.int_0)
				{
					result = current.list_0;
					return result;
				}
			}
			IL_250:
			GClass0.smethod_0().method_4("No spells for this class/hero combination have been set:");
			GClass0.smethod_0().method_4("Class: " + Framework.Hero.Class);
			GClass0.smethod_0().method_4("Level: " + Framework.Hero.GetInt((D3Attribute)4294963259u));
			result = null;
			return result;
		}
		[CompilerGenerated]
		private static int smethod_1(GClass3.GClass2 gclass2_0)
		{
			return gclass2_0.int_0;
		}
		[CompilerGenerated]
		private static int smethod_2(GClass3.GClass2 gclass2_0)
		{
			return gclass2_0.int_0;
		}
		[CompilerGenerated]
		private static int smethod_3(GClass3.GClass2 gclass2_0)
		{
			return gclass2_0.int_0;
		}
		[CompilerGenerated]
		private static int smethod_4(GClass3.GClass2 gclass2_0)
		{
			return gclass2_0.int_0;
		}
		[CompilerGenerated]
		private static int smethod_5(GClass3.GClass2 gclass2_0)
		{
			return gclass2_0.int_0;
		}
	}
}
