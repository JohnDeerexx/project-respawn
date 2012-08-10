using D3Core;
using D3Core.Classes;
using System;
using System.Collections.Generic;
namespace ns1
{
	internal static class Class100
	{
		private static GClass0 gclass0_0;
		private static Dictionary<D3Attribute, float> dictionary_0;
		internal static Dictionary<D3Attribute, float> dictionary_1;
		internal static Dictionary<ItemLocationIndex, float> dictionary_2;
		static Class100()
		{
			Class100.dictionary_0 = new Dictionary<D3Attribute, float>();
			Class100.dictionary_1 = null;
			Class100.dictionary_2 = new Dictionary<ItemLocationIndex, float>();
			Class100.dictionary_0[(D3Attribute)4294963261u] = 2500f;
			Class100.dictionary_0[(D3Attribute)4294963335u] = 2000f;
			Class100.dictionary_0[(D3Attribute)4294963258u] = 1000f;
			Class100.dictionary_0[(D3Attribute)4294963213u] = 8f;
			Class100.dictionary_0[(D3Attribute)4294963212u] = 6f;
			Class100.dictionary_0[(D3Attribute)4294963210u] = 6f;
			Class100.dictionary_0[(D3Attribute)4294963211u] = 6f;
			Class100.dictionary_0[(D3Attribute)4294963252u] = 1f;
			Class100.dictionary_2[ItemLocationIndex.LeftRing] = 1.5f;
			Class100.dictionary_2[ItemLocationIndex.RightRing] = 1.5f;
			Class100.dictionary_2[ItemLocationIndex.Neck] = 1.5f;
			Class100.dictionary_2[ItemLocationIndex.Belt] = 1.2f;
			Class100.dictionary_2[ItemLocationIndex.Mainhand] = 2f;
			Class100.gclass0_0 = GClass0.smethod_0();
		}
		internal static float smethod_0(D3Item d3Item_0)
		{
			float num = 0f;
			float @float = d3Item_0.GetFloat(4294963384u);
			float float2 = d3Item_0.GetFloat(4294963380u);
			float num2 = (@float + (@float + float2)) / 2f;
			float num3 = d3Item_0.GetFloat(4294963360u) * num2;
			num += num3;
			if (Class100.dictionary_1 != null && Class100.dictionary_1.Count > 0)
			{
				using (Dictionary<D3Attribute, float>.Enumerator enumerator = Class100.dictionary_1.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						KeyValuePair<D3Attribute, float> current = enumerator.Current;
						num += d3Item_0.GetFloat((uint)current.Key) * current.Value;
					}
					goto IL_EC;
				}
			}
			foreach (KeyValuePair<D3Attribute, float> current2 in Class100.dictionary_0)
			{
				num += d3Item_0.GetFloat((uint)current2.Key) * current2.Value;
			}
			IL_EC:
			foreach (ItemLocationIndex current3 in d3Item_0.GetPossibleSlots())
			{
				float num4 = 0f;
				if (Class100.dictionary_2.TryGetValue(current3, out num4) && num4 > 0f)
				{
					num *= num4;
				}
			}
			return num;
		}
		internal static float smethod_1(D3Actor d3Actor_0)
		{
			float num = 0f;
			float @float = d3Actor_0.GetFloat((D3Attribute)4294963384u);
			float float2 = d3Actor_0.GetFloat((D3Attribute)4294963380u);
			float num2 = (@float + (@float + float2)) / 2f;
			float num3 = d3Actor_0.GetFloat((D3Attribute)4294963360u) * num2;
			float result;
			if (float.IsNaN(num3))
			{
				result = 0f;
			}
			else
			{
				num += num3;
				if (Class100.dictionary_1 != null && Class100.dictionary_1.Count > 0)
				{
					using (Dictionary<D3Attribute, float>.Enumerator enumerator = Class100.dictionary_1.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							KeyValuePair<D3Attribute, float> current = enumerator.Current;
							num += d3Actor_0.GetFloat(current.Key) * current.Value;
						}
						goto IL_104;
					}
				}
				foreach (KeyValuePair<D3Attribute, float> current2 in Class100.dictionary_0)
				{
					num += d3Actor_0.GetFloat(current2.Key) * current2.Value;
				}
				IL_104:
				result = num;
			}
			return result;
		}
	}
}
