using D3Core;
using D3Core.Classes;
using System;
using System.Collections.Generic;
namespace ns1
{
	internal class Class55 : Class44
	{
		private int int_0 = 0;
		private List<Vector3> list_0 = new List<Vector3>();
		private string string_0;
		private string string_1;
		private bool bool_0;
		internal override bool vmethod_0()
		{
			if (this.int_0 < Environment.TickCount)
			{
				this.int_0 = Environment.TickCount + 500;
				this.list_0 = Framework.Navigator.OpenEnds;
				this.bool_0 = (this.list_0.Count > 0);
			}
			return this.bool_0;
		}
		internal override void vmethod_1()
		{
		}
		internal override string vmethod_3()
		{
			return "Explorer has no target...";
		}
		internal override int vmethod_2()
		{
			return 9999;
		}
	}
}
