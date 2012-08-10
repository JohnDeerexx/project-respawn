using D3Core;
using D3Core.Classes;
using System;
using System.Collections.Generic;
namespace ns1
{
	internal abstract class Class44
	{
		internal abstract bool vmethod_0();
		internal abstract void vmethod_1();
		internal abstract int vmethod_2();
		internal abstract string vmethod_3();
		internal bool method_0(D3Actor d3Actor_0, Vector3 vector3_0, float float_0)
		{
			float num = Vector3.DistanceSquared(vector3_0, d3Actor_0.Position);
			bool result;
			if (num > float_0)
			{
				result = false;
			}
			else
			{
				float num2 = Class44.smethod_0(vector3_0, d3Actor_0.Position);
				result = (num2 * num2 <= float_0);
			}
			return result;
		}
		internal static float smethod_0(Vector3 vector3_0, Vector3 vector3_1)
		{
			List<Vector3> path = Framework.Navigator.GetPath(vector3_0, vector3_1, 10f, 0f);
			double num = 0.0;
			for (int i = 1; i < path.Count; i++)
			{
				num += (double)Vector3.DistanceSquared(path[i], path[i - 1]);
			}
			num = Math.Sqrt(num) * Math.Sqrt((double)path.Count);
			if (num < 1.0)
			{
				num = (double)Vector3.Distance(vector3_0, vector3_1);
			}
			return (float)num;
		}
	}
}
