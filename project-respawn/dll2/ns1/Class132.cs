using D3Core;
using System;
namespace ns1
{
	internal static class Class132
	{
		internal static bool smethod_0(string string_0)
		{
			return Class132.smethod_3(string_0) || Class132.smethod_2(string_0) || Class132.smethod_1(string_0);
		}
		internal static bool smethod_1(string string_0)
		{
			return string_0.StartsWith("Crafting_Training_");
		}
		internal static bool smethod_2(string string_0)
		{
			return string_0.StartsWith("Crafting_Tier_");
		}
		internal static bool smethod_3(string string_0)
		{
			return string_0.StartsWith("Ruby_") || string_0.StartsWith("Amethyst_") || string_0.StartsWith("Emerald_") || string_0.StartsWith("Topaz_");
		}
		internal static int smethod_4(D3Item d3Item_0)
		{
			int result;
			if (d3Item_0.GetFloat((D3Attribute)4294963307u) > 0f)
			{
				result = 100;
			}
			else
			{
				if (Class132.smethod_3(d3Item_0.Modelname))
				{
					result = 30;
				}
				else
				{
					if (Class132.smethod_2(d3Item_0.Modelname))
					{
						result = 100;
					}
					else
					{
						if (Class132.smethod_1(d3Item_0.Modelname))
						{
							result = 1000;
						}
						else
						{
							result = 1;
						}
					}
				}
			}
			return result;
		}
	}
}
