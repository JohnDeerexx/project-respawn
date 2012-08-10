using D3Core;
using D3Core.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
namespace ns1
{
	internal class Class45 : Class44
	{
		internal static List<Class42> list_0 = new List<Class42>();
		private List<Class39> list_1 = new List<Class39>();
		private List<Class39> list_2 = new List<Class39>();
		internal static List<Class41> list_3 = new List<Class41>();
		private Random random_0 = new Random();
		private int int_0 = 0;
		private Interface1 interface1_0 = new Class122(15f);
		private Interface0 interface0_0 = new Class113();
		private int int_1 = 4;
		private int int_2 = 40;
		private int int_3 = 14;
		internal static Vector3? vector3_0 = null;
		private Class40 class40_0 = null;
		private int int_4 = 0;
		[CompilerGenerated]
		private static int int_5;
		[CompilerGenerated]
		private static Func<Class39, float> func_0;
		[CompilerGenerated]
		private static Func<Class39, float> func_1;
		[CompilerGenerated]
		private static Func<Class39, float> func_2;
		[CompilerGenerated]
		private static Func<Class39, float> func_3;
		[CompilerGenerated]
		private static Func<Class39, float> func_4;
		[CompilerGenerated]
		private static Func<Class39, float> func_5;
		public static int LastRan
		{
			get;
			private set;
		}
		internal override bool vmethod_0()
		{
			bool result;
			if (Class96.smethod_2())
			{
				result = true;
			}
			else
			{
				this.list_1.Clear();
				this.list_2.Clear();
				this.method_1();
				if (this.list_1.Count + this.list_2.Count > 0)
				{
					result = true;
				}
				else
				{
					if (Class45.vector3_0.HasValue)
					{
						float num = Class44.smethod_0(Framework.Hero.Position, Class45.vector3_0.Value);
						if (num > 6f)
						{
							result = true;
							return result;
						}
						Class45.vector3_0 = null;
					}
					result = false;
				}
			}
			return result;
		}
		private void method_1()
		{
			float num = GClass0.smethod_0().method_12() - 10f;
			if (num > 0f)
			{
				num *= num;
				Vector3 position = Framework.Hero.Position;
				using (List<D3Actor>.Enumerator enumerator = Framework.Actors.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						D3Actor current = enumerator.Current;
						if (this.method_2(current))
						{
							float num2 = (current.Position - position).LengthSquared();
							if (num2 <= num)
							{
								List<Vector3> path = Framework.Navigator.GetPath(position, current.Position, 10f, 20f);
								for (int i = 0; i < path.Count; i++)
								{
									if ((path[i] - position).LengthSquared() <= num)
									{
									}
								}
								bool flag = Framework.Navigator.TraceRay_Projectile_CanPass(position, current.Position);
								int num3 = (int)(100f - num2);
								Class39 item = new Class39(current, num2, flag, num3);
								if (flag)
								{
									this.list_1.Add(item);
								}
								else
								{
									this.list_2.Add(item);
								}
							}
						}
					}
					return;
				}
			}
			if (Environment.TickCount - this.int_4 > 600)
			{
				this.int_4 = Environment.TickCount;
				GClass0.smethod_0().method_5("AggroRange is 0, skipping combat");
			}
		}
		private bool method_2(D3Actor d3Actor_0)
		{
			bool result;
			if (d3Actor_0 == null)
			{
				result = false;
			}
			else
			{
				if (d3Actor_0.Team != D3Team.Diablo)
				{
					result = false;
				}
				else
				{
					if (d3Actor_0.GetFloat((D3Attribute)4294963302u) < 0.0011f)
					{
						result = false;
					}
					else
					{
						if (d3Actor_0.GetInt((D3Attribute)4294963292u) == 1)
						{
							result = false;
						}
						else
						{
							if (d3Actor_0.GetInt((D3Attribute)4294963431u) == 1)
							{
								result = false;
							}
							else
							{
								if (Class138.smethod_0(d3Actor_0.UInt32_0))
								{
									result = false;
								}
								else
								{
									foreach (Class41 current in Class45.list_3)
									{
										if (d3Actor_0.Modelname == current.ActorName)
										{
											result = false;
											return result;
										}
									}
									result = true;
								}
							}
						}
					}
				}
			}
			return result;
		}
		internal override void vmethod_1()
		{
			Class45.LastRan = Environment.TickCount;
			this.method_4();
		}
		private bool method_3()
		{
			bool result;
			if (Class96.smethod_2())
			{
				Class96.smethod_4();
				result = true;
			}
			else
			{
				bool flag = false;
				IEnumerable<Class39> arg_3B_0 = this.list_1;
				if (Class45.func_0 == null)
				{
					Class45.func_0 = new Func<Class39, float>(Class45.smethod_1);
				}
				IEnumerable<Class39> enumerable = arg_3B_0.OrderBy(Class45.func_0).TakeWhile(new Func<Class39, bool>(this.method_7));
				int num = enumerable.Count<Class39>();
				if (num == 0)
				{
					result = false;
				}
				else
				{
					float num2 = Framework.Hero.CurrentHP / Framework.Hero.MaxHP - 0.36f;
					if ((float)num >= (float)this.int_1 * num2)
					{
						flag = true;
					}
					else
					{
						IEnumerable<Class39> arg_B8_0 = enumerable;
						if (Class45.func_1 == null)
						{
							Class45.func_1 = new Func<Class39, float>(Class45.smethod_2);
						}
						float num3 = arg_B8_0.Sum(Class45.func_1);
						if (num3 >= (float)this.int_2 * num2)
						{
							flag = true;
						}
					}
					if (!flag)
					{
						result = false;
					}
					else
					{
						if (Class96.smethod_1())
						{
							result = false;
						}
						else
						{
							Class96.smethod_4();
							result = true;
						}
					}
				}
			}
			return result;
		}
		private void method_4()
		{
			Vector3 position = Framework.Hero.Position;
			if (this.list_1.Count + this.list_2.Count == 0)
			{
				if (Class45.vector3_0.HasValue)
				{
					Movement.MoveTo(Class45.vector3_0.Value);
				}
			}
			else
			{
				bool flag = false;
				int num = 0;
				int i = 0;
				while (i < this.list_1.Count && !flag)
				{
					if (this.list_1[i].DistanceSquared < 49f)
					{
						num++;
					}
					if (num >= 4)
					{
						flag = true;
					}
					i++;
				}
				if (!flag)
				{
					List<Class39> list = new List<Class39>();
					foreach (Class39 @class in this.list_1)
					{
						for (i = 0; i < Class45.list_0.Count; i++)
						{
							if (Class45.list_0[i].method_2(@class.Actor))
							{
								float float_ = Class45.list_0[i].method_0() * Class45.list_0[i].method_0();
								if (base.method_0(@class.Actor, position, float_))
								{
									list.Add(@class);
								}
							}
						}
					}
					List<Class39> list2 = new List<Class39>();
					foreach (Class39 @class in this.list_2)
					{
						for (i = 0; i < Class45.list_0.Count; i++)
						{
							if (Class45.list_0[i].method_2(@class.Actor) && base.method_0(@class.Actor, position, Class45.list_0[i].method_0()))
							{
								list2.Add(@class);
							}
						}
					}
					if (list.Count > 0)
					{
						this.list_1 = list;
						IEnumerable<Class39> arg_228_0 = this.list_1;
						if (Class45.func_2 == null)
						{
							Class45.func_2 = new Func<Class39, float>(Class45.smethod_3);
						}
						Class39 class2 = arg_228_0.OrderBy(Class45.func_2).FirstOrDefault<Class39>();
						if (class2.DistanceSquared > 900f)
						{
							this.list_1.Clear();
							this.list_2.Clear();
							class2.DirectlyVisible = false;
							this.list_2.Add(class2);
						}
					}
					else
					{
						if (list2.Count > 0)
						{
							this.list_1.Clear();
							this.list_2 = list2;
						}
					}
				}
				try
				{
					List<D3Actor> list3 = new List<D3Actor>();
					foreach (D3Actor current in Framework.Actors)
					{
						float num2 = 0f;
						if (Class49.smethod_1(current, out num2))
						{
							list3.Add(current);
						}
					}
					if (this.list_1.Count == 0)
					{
						IEnumerable<Class39> arg_323_0 = this.list_2;
						if (Class45.func_3 == null)
						{
							Class45.func_3 = new Func<Class39, float>(Class45.smethod_4);
						}
						Class39 class3 = arg_323_0.OrderBy(Class45.func_3).First<Class39>();
						bool flag2 = this.method_5(Framework.Hero.Position, class3.Actor.Position, list3);
						if (!class3.DirectlyVisible || flag2)
						{
							Movement.MoveTo(class3.Actor.Position);
							return;
						}
					}
					Class39 @class = this.interface1_0.imethod_0(this.list_1);
					if (@class == null)
					{
						IEnumerable<Class39> arg_3B8_0 = this.list_1;
						if (Class45.func_4 == null)
						{
							Class45.func_4 = new Func<Class39, float>(Class45.smethod_5);
						}
						arg_3B8_0.OrderBy(Class45.func_4).FirstOrDefault<Class39>();
					}
					D3Power d3Power = this.interface0_0.imethod_0(this.list_1);
					if (d3Power == D3Power.Invalid && Environment.TickCount - this.int_0 > 500)
					{
						GClass0.smethod_0().method_5("Combat: No spell is useable...");
						this.int_0 = Environment.TickCount;
					}
					if (@class != null && d3Power != D3Power.Invalid)
					{
						if (this.method_5(Framework.Hero.Position, @class.Actor.Position, list3))
						{
							Movement.MoveTo(@class.Actor.Position);
						}
						else
						{
							if (D3Spell.SpellsWithoutTarget.Contains(d3Power))
							{
								Framework.Hero.Attack(null, d3Power);
							}
							else
							{
								Framework.Hero.Attack(@class.Actor, d3Power);
							}
							D3Spell.SetSpellCooldown(d3Power);
							Class45.vector3_0 = new Vector3?(@class.Actor.Position);
						}
					}
					else
					{
						IEnumerable<Class39> arg_4D4_0 = this.list_1;
						if (Class45.func_5 == null)
						{
							Class45.func_5 = new Func<Class39, float>(Class45.smethod_6);
						}
						Class39 class4 = arg_4D4_0.OrderBy(Class45.func_5).First<Class39>();
						if (class4 != null)
						{
							if (class4.Actor != null)
							{
								Vector3 position2 = class4.Actor.Position;
								Class45.vector3_0 = new Vector3?(position2);
								List<Vector3> path = Framework.Navigator.GetPath(Framework.Hero.Position, position2, 10f, 20f);
								if (path.Count > 0)
								{
									Movement.MoveTo(path[0]);
								}
								else
								{
									GClass0.smethod_0().method_4("Combat: Cannot find a path to \"{0}\", ignoring the mob.".smethod_0(class4.Actor.Modelname));
									Class45.list_3.Add(new Class41(class4.Actor.Modelname, 4000));
								}
							}
						}
					}
				}
				catch (Exception ex)
				{
					GClass0.smethod_0().method_4("ERROR when fighting: " + ex.Message);
				}
			}
		}
		private bool method_5(Vector3 vector3_1, Vector3 vector3_2, List<D3Actor> list_4)
		{
			Vector3 value = vector3_1 - vector3_2;
			float num = value.Length();
			if (num > 100f)
			{
				num = 100f;
			}
			int num2 = (int)(num / 5f) + 1;
			Vector3 value2 = value / num;
			bool result;
			for (int i = 0; i < num2; i++)
			{
				Vector3 value3 = vector3_1 + value2 * 5f * (float)i;
				foreach (D3Actor current in list_4)
				{
					float num3 = Vector3.DistanceSquared(current.Position, value3);
					if (num3 < 400f)
					{
						result = true;
						return result;
					}
				}
			}
			result = false;
			return result;
		}
		internal void method_6(string string_0)
		{
			this.class40_0 = new Class40();
			this.class40_0.NameSubstring = string_0;
			this.class40_0.LastSeenTimestamp = Environment.TickCount;
		}
		internal override int vmethod_2()
		{
			return 5;
		}
		internal override string vmethod_3()
		{
			string result;
			if (Class45.vector3_0.HasValue)
			{
				result = "Must reach positon: " + Class45.vector3_0.Value.ToString();
			}
			else
			{
				result = "Combat against {0} monsters".smethod_0(this.list_1.Count + this.list_2.Count);
			}
			return result;
		}
		[CompilerGenerated]
		private static float smethod_1(Class39 class39_0)
		{
			return class39_0.Actor.DistanceToHero();
		}
		[CompilerGenerated]
		private bool method_7(Class39 class39_0)
		{
			return class39_0.Actor.DistanceToHero() < (float)this.int_3;
		}
		[CompilerGenerated]
		private static float smethod_2(Class39 class39_0)
		{
			return (class39_0.Actor.GetFloat((D3Attribute)4294963302u) + class39_0.Actor.GetFloat((D3Attribute)4294963311u)) * 0.5f;
		}
		[CompilerGenerated]
		private static float smethod_3(Class39 class39_0)
		{
			return class39_0.DistanceSquared;
		}
		[CompilerGenerated]
		private static float smethod_4(Class39 class39_0)
		{
			return class39_0.DistanceSquared;
		}
		[CompilerGenerated]
		private static float smethod_5(Class39 class39_0)
		{
			return class39_0.DistanceSquared;
		}
		[CompilerGenerated]
		private static float smethod_6(Class39 class39_0)
		{
			return class39_0.DistanceSquared;
		}
	}
}
