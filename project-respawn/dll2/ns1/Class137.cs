using D3Core;
using System;
using System.Collections.Generic;
namespace ns1
{
	internal static class Class137
	{
		public static List<ItemLocationIndex> smethod_0(this D3Item d3Item_0)
		{
			List<ItemLocationIndex> list = new List<ItemLocationIndex>();
			List<ItemLocationIndex> possibleSlots = d3Item_0.GetPossibleSlots();
			foreach (ItemLocationIndex current in possibleSlots)
			{
				if (d3Item_0.CanMoveItem(current, 0u, 0u))
				{
					list.Add(current);
				}
			}
			return list;
		}
	}
}
