using D3Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
namespace ns1
{
	internal class Class52 : Class44
	{
		[CompilerGenerated]
		private sealed class Class136
		{
			public int int_0;
			public bool method_0(D3Item d3Item_0)
			{
				return d3Item_0.IsPotion && d3Item_0.CanUseItem() && d3Item_0.GetReqLevelForPotion() <= this.int_0;
			}
		}
		private const uint uint_0 = 4267u;
		private const int int_0 = 20;
		private const int int_1 = 5;
		private D3Item d3Item_0 = null;
		[CompilerGenerated]
		private static Func<D3Item, float> func_0;
		internal override bool vmethod_0()
		{
			bool result;
			try
			{
				this.d3Item_0 = null;
				float @float = Framework.Hero.GetFloat((D3Attribute)4294963311u);
				float float2 = Framework.Hero.GetFloat((D3Attribute)4294963302u);
				float num = float2 / @float;
				if (num < 0.36f)
				{
					Class52.Class136 @class = new Class52.Class136();
					@class.int_0 = Framework.Hero.GetInt((D3Attribute)4294963259u);
					IEnumerable<D3Item> arg_8C_0 = Framework.Hero.Inventory.Where(new Func<D3Item, bool>(@class.method_0));
					if (Class52.func_0 == null)
					{
						Class52.func_0 = new Func<D3Item, float>(Class52.smethod_1);
					}
					D3Item d3Item = arg_8C_0.OrderByDescending(Class52.func_0).FirstOrDefault<D3Item>();
					if (d3Item != null)
					{
						this.d3Item_0 = d3Item;
						result = true;
						return result;
					}
				}
				result = false;
			}
			catch (Exception ex)
			{
				GClass0.smethod_0().method_4("Error in SurviveState.Run(): " + ex.Message);
				result = false;
			}
			return result;
		}
		internal override int vmethod_2()
		{
			return 3;
		}
		internal override string vmethod_3()
		{
			string result = "null";
			if (this.d3Item_0 != null)
			{
				result = "Use Potion: " + this.d3Item_0.Modelname + " ({0}HP, Level: {1})".smethod_1(this.d3Item_0.HitpointsGranted, this.d3Item_0.GetReqLevelForPotion());
			}
			return result;
		}
		internal override void vmethod_1()
		{
			try
			{
				if (this.d3Item_0 != null)
				{
					this.d3Item_0.UseItem();
				}
			}
			catch (Exception ex)
			{
				GClass0.smethod_0().method_4("Survial error: " + ex.Message);
			}
		}
		[CompilerGenerated]
		private static float smethod_1(D3Item d3Item_1)
		{
			return d3Item_1.HitpointsGranted;
		}
	}
}
