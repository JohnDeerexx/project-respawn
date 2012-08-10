using D3Core;
using D3Core.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
namespace ns1
{
	internal static class Class96
	{
		private const float float_0 = 100f;
		private const int int_0 = 10;
		private static int int_1 = 300;
		private static int int_2 = 0;
		private static string string_0 = "";
		private static LinkedList<Vector3> linkedList_0 = new LinkedList<Vector3>();
		public static int int_3 = 700;
		private static int int_4 = 0;
		private static int int_5 = 0;
		private static int int_6 = 0;
		[CompilerGenerated]
		private static LinkedList<Vector3> linkedList_1;
		public static LinkedList<Vector3> KitingPath
		{
			get;
			private set;
		}
		public static int smethod_0()
		{
			return 600 + (int)(Framework.Hero.CurrentHP / Framework.Hero.MaxHP * 1000f);
		}
		public static bool smethod_1()
		{
			return Environment.TickCount < Class96.int_5;
		}
		public static bool smethod_2()
		{
			return Class96.KitingPath != null;
		}
		public static void smethod_3()
		{
			string world = Framework.World;
			if (Class96.string_0 != world)
			{
				Class96.string_0 = world;
				Class96.int_2 = 0;
				Class96.linkedList_0.Clear();
			}
			if (Environment.TickCount >= Class96.int_2)
			{
				Class96.int_2 = Environment.TickCount + Class96.int_1;
				float num = 9999f;
				if (Class96.linkedList_0.Count > 0)
				{
					num = (Class96.linkedList_0.Last<Vector3>() - Framework.Hero.Position).LengthSquared();
				}
				if (num >= 10000f)
				{
					GClass0.smethod_0().method_5("KitingSystem: Adding waypoint");
					Class96.linkedList_0.AddLast(Framework.Hero.Position);
					Class96.int_6++;
					while (Class96.linkedList_0.Count > 10)
					{
						Class96.linkedList_0.RemoveFirst();
					}
				}
			}
		}
		public static void smethod_4()
		{
			if (Class96.KitingPath == null)
			{
				List<Vector3> list = Framework.Navigator.OptimizePath(Class96.linkedList_0.ToList<Vector3>());
				GClass0.smethod_0().method_5("Kiting started with " + list.Count + " nodes...");
				Class96.KitingPath = new LinkedList<Vector3>();
				foreach (Vector3 current in list)
				{
					Class96.KitingPath.AddFirst(current);
				}
				Class96.int_5 = 0;
				Class96.int_4 = Environment.TickCount + Class96.int_3;
				GClass0.smethod_0().method_5("KitingSystem: Kiting started with " + Class96.KitingPath.Count + " nodes!");
			}
			if (Class96.int_4 < Environment.TickCount)
			{
				GClass0.smethod_0().method_5("KitingSystem: Kiting ended!");
				Class96.int_5 = Environment.TickCount + Class96.smethod_0();
				Class96.KitingPath = null;
			}
			else
			{
				while (Class96.KitingPath.Count > 0 && Framework.Hero.DistanceTo(Class96.KitingPath.First.Value) < 30f)
				{
					Class96.KitingPath.RemoveFirst();
				}
				if (Class96.KitingPath.Count > 0)
				{
					Movement.MoveTo(Class96.KitingPath.First.Value);
				}
				else
				{
					GClass0.smethod_0().method_5("KitingSystem: there are no more kiting points to follow");
					Class96.KitingPath = null;
				}
			}
		}
	}
}
