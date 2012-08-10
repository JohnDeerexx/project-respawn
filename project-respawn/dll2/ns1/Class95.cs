using D3Core;
using D3Core.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
namespace ns1
{
	internal class Class95 : Class94
	{
		private List<Vector3> list_0;
		private int int_0;
		internal Class95(List<Vector3> list_1, int int_1 = 10)
		{
			this.int_0 = int_1;
			this.list_0 = list_1;
		}
		internal override void vmethod_0()
		{
			if (this.list_0 != null)
			{
				while (this.list_0.Count > 1 && Vector3.Distance(this.list_0.First<Vector3>(), Framework.Hero.Position) < 10f)
				{
					this.list_0.RemoveAt(0);
				}
				while (this.list_0.Count == 1 && Vector3.Distance(this.list_0.First<Vector3>(), Framework.Hero.Position) < (float)this.int_0)
				{
					this.list_0.RemoveAt(0);
				}
				if (this.list_0.Count > 0)
				{
					Movement.MoveTo(this.list_0[0]);
				}
			}
		}
		internal override bool vmethod_1()
		{
			return this.list_0 == null || this.list_0.Count == 0;
		}
	}
}
