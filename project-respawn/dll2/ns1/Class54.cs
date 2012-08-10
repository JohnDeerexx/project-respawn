using D3Core;
using System;
using System.Collections.Generic;
namespace ns1
{
	internal class Class54 : Class44
	{
		private int int_0;
		private Tuple<D3Item, ItemLocationIndex> tuple_0 = null;
		internal override int vmethod_2()
		{
			return 7;
		}
		internal override bool vmethod_0()
		{
			bool result;
			try
			{
				if (!InjectedWindow.Instance.class71_0.ChangeEquip)
				{
					result = false;
				}
				else
				{
					List<D3Item> arg_23_0 = Framework.Hero.Inventory;
					this.tuple_0 = null;
					if (Environment.TickCount < this.int_0)
					{
						result = false;
					}
					else
					{
						foreach (D3Item current in Framework.Hero.Inventory)
						{
							if (!current.IsTwoHander)
							{
								foreach (ItemLocationIndex current2 in current.smethod_0())
								{
									D3Item firstItemBySlot = Framework.Hero.GetFirstItemBySlot(current2);
									if (firstItemBySlot == null || Class100.smethod_0(firstItemBySlot) < Class100.smethod_0(current))
									{
										this.tuple_0 = new Tuple<D3Item, ItemLocationIndex>(current, current2);
										result = true;
										return result;
									}
								}
							}
						}
						result = false;
					}
				}
			}
			catch (Exception ex)
			{
				GClass0.smethod_0().method_4("Error while equiping items: " + ex.Message);
				result = false;
			}
			return result;
		}
		internal override void vmethod_1()
		{
			try
			{
				if (this.tuple_0 != null)
				{
					this.tuple_0.Item1.MoveItem(this.tuple_0.Item2, 0u, 0u);
					this.int_0 = Environment.TickCount + 1000;
				}
			}
			catch (Exception)
			{
				GClass0.smethod_0().method_4("Exception while equiping items");
			}
		}
		internal override string vmethod_3()
		{
			string result = "null";
			if (this.tuple_0 != null)
			{
				result = "item: " + this.tuple_0.Item1.Modelname + ", to slot: " + this.tuple_0.Item2.ToString();
			}
			return result;
		}
	}
}
