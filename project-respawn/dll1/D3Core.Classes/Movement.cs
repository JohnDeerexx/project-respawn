using ns0;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
namespace D3Core.Classes
{
	public static class Movement
	{
		private static uint uint_0;
		private static Random random_0 = new Random();
		private static Vector3 vector3_0 = Vector3.Zero;
		private static Vector3 vector3_1 = Vector3.Zero;
		private static int int_0 = 0;
		private static int int_1 = 0;
		private static Vector3 vector3_2 = Vector3.Zero;
		private static List<Vector3> list_0 = new List<Vector3>();
		private static int int_2 = 0;
		private static int int_3 = 0;
		public static List<Vector3> CurrentPath
		{
			get
			{
				return Movement.list_0.ToList<Vector3>();
			}
		}
		public static bool IsMoving
		{
			get
			{
				Movement.smethod_0();
				return Marshal.ReadInt32(new IntPtr((long)((ulong)(Movement.uint_0 + 52u)))) == 1;
			}
		}
		private static void smethod_0()
		{
			Movement.uint_0 = (uint)Marshal.ReadInt32(new IntPtr((long)((ulong)((int)Framework.Hero._Ptr + (int)Class3.Class2.uint_9))));
		}
		private static float smethod_1()
		{
			return (Framework.Hero.Position - Movement.CurrentPath[0]).Length();
		}
		public static void MoveTo(Vector3 targetPos)
		{
			if (Environment.TickCount >= Movement.int_2)
			{
				Movement.int_2 = Environment.TickCount + 100;
				float num = Vector3.DistanceSquared(targetPos, Framework.Hero.Position);
				if (Framework.Hero == null || num > 16900f)
				{
					if (Framework.Hero == null)
					{
						Framework.smethod_1("Core error: Received a movement command while hero == null");
					}
					else
					{
						Framework.smethod_1("Core error: Received a movement command where the target position is very far away!");
						Framework.smethod_1(string.Concat(new object[]
						{
							"DistanceSQ is: ",
							num,
							", Distance: ",
							Math.Sqrt((double)num)
						}));
						Framework.smethod_1("Stacktrace: \r\n" + new StackTrace().ToString());
					}
				}
				Movement.smethod_0();
				if (Environment.TickCount < Movement.int_1)
				{
					targetPos = Movement.vector3_2;
				}
				Movement.list_0 = Framework.Navigator.GetPath(Framework.Hero.Position, targetPos, 10f, 20f);
				if (Movement.list_0.Count > 0)
				{
					targetPos = Movement.list_0[0];
				}
				else
				{
					targetPos = targetPos;
				}
				if (Movement.int_3 < Environment.TickCount && Vector3.DistanceSquared(Framework.Hero.Position, Movement.vector3_1) < 2f)
				{
					if (Environment.TickCount - Movement.int_0 >= 1600 && Movement.int_1 < Environment.TickCount)
					{
						List<Vector3> path;
						do
						{
							Movement.vector3_2 = Framework.Hero.Position + new Vector3((float)(Movement.random_0.Next(60) - 30), (float)(Movement.random_0.Next(60) - 30), 0f);
							path = Framework.Navigator.GetPath(Framework.Hero.Position, Movement.vector3_2, 20f, 10f);
						}
						while (path == null || path.Count == 0);
						Movement.int_1 = Environment.TickCount + 1500;
						Movement.int_3 = Environment.TickCount + 3500;
						return;
					}
				}
				else
				{
					Movement.int_0 = Environment.TickCount;
					Movement.vector3_1 = Framework.Hero.Position;
				}
				Helper.WriteFloat(new IntPtr((long)((ulong)(Movement.uint_0 + 60u))), targetPos.float_0);
				Helper.WriteFloat(new IntPtr((long)((ulong)(Movement.uint_0 + 64u))), targetPos.float_1);
				Helper.WriteFloat(new IntPtr((long)((ulong)(Movement.uint_0 + 68u))), targetPos.float_2);
				Framework.UsePower_Position(30588u, targetPos);
				Helper.WriteFloat(new IntPtr((long)((ulong)(Movement.uint_0 + 60u))), targetPos.float_0);
				Helper.WriteFloat(new IntPtr((long)((ulong)(Movement.uint_0 + 64u))), targetPos.float_1);
				Helper.WriteFloat(new IntPtr((long)((ulong)(Movement.uint_0 + 68u))), targetPos.float_2);
			}
		}
		public static void HoldPosition()
		{
			Movement.WritePositionDirect(Framework.Hero.Position);
		}
		public static void WritePositionDirect(Vector3 displacement)
		{
			Movement.smethod_0();
			Helper.WriteFloat(new IntPtr((long)((ulong)(Movement.uint_0 + 60u))), displacement.float_0);
			Helper.WriteFloat(new IntPtr((long)((ulong)(Movement.uint_0 + 64u))), displacement.float_1);
			Helper.WriteFloat(new IntPtr((long)((ulong)(Movement.uint_0 + 68u))), displacement.float_2);
		}
	}
}
