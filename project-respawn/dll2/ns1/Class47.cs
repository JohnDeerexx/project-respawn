using D3Core;
using D3Core.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
namespace ns1
{
	internal class Class47 : Class44
	{
		[CompilerGenerated]
		private sealed class Class98
		{
			public D3Actor d3Actor_0;
			public bool method_0(D3Actor d3Actor_1)
			{
				return d3Actor_1.Modelname == this.d3Actor_0.Modelname;
			}
		}
		[CompilerGenerated]
		private sealed class Class99
		{
			public Vector3 vector3_0;
			public float method_0(D3Actor d3Actor_0)
			{
				return Vector3.DistanceSquared(d3Actor_0.Position, this.vector3_0);
			}
		}
		internal static List<Class42> list_0 = new List<Class42>();
		internal static List<Class97> list_1 = new List<Class97>();
		private Random random_0 = new Random();
		private D3Actor d3Actor_0 = null;
		private int int_0 = 0;
		private int int_1 = 0;
		[CompilerGenerated]
		private static Func<KeyValuePair<int, D3Spell>, bool> func_0;
		[CompilerGenerated]
		private static Func<KeyValuePair<int, D3Spell>, bool> func_1;
		private bool method_1(D3Actor d3Actor_1, out float float_0)
		{
			float_0 = -1f;
			bool result;
			if (d3Actor_1.GetInt((D3Attribute)4294963682u) == 1)
			{
				result = false;
			}
			else
			{
				if (d3Actor_1.GetFloat((D3Attribute)4294963302u) != 0.001f)
				{
					result = false;
				}
				else
				{
					int @int = d3Actor_1.GetInt((D3Attribute)4294963540u);
					int int2 = d3Actor_1.GetInt((D3Attribute)4294963539u);
					if (int2 == @int && @int != 0)
					{
						result = false;
					}
					else
					{
						foreach (Class42 current in Class47.list_0)
						{
							if (current.ModelId != -1 && (ulong)d3Actor_1.UInt32_0 == (ulong)((long)current.ModelId))
							{
								float_0 = current.method_0();
								result = true;
								return result;
							}
						}
						foreach (Class42 current in Class47.list_0)
						{
							if (current.ModelId == -1 && d3Actor_1.Modelname.Contains(current.ModelNameSubstring))
							{
								float_0 = current.method_0();
								result = true;
								return result;
							}
						}
						result = false;
					}
				}
			}
			return result;
		}
		private bool method_2(D3Actor d3Actor_1)
		{
			Class47.Class98 @class = new Class47.Class98();
			@class.d3Actor_0 = d3Actor_1;
			bool result;
			if (@class.d3Actor_0 == null)
			{
				result = false;
			}
			else
			{
				if (Framework.Actors.FirstOrDefault(new Func<D3Actor, bool>(@class.method_0)) == null)
				{
					Class47.list_1.Add(new Class97(@class.d3Actor_0.Modelname, Environment.TickCount + 5000));
					result = false;
				}
				else
				{
					float num = 0f;
					if (!this.method_1(@class.d3Actor_0, out num))
					{
						Class47.list_1.Add(new Class97(@class.d3Actor_0.Modelname, Environment.TickCount + 5000));
						result = false;
					}
					else
					{
						result = base.method_0(@class.d3Actor_0, Framework.Hero.Position, num * num);
					}
				}
			}
			return result;
		}
		internal override bool vmethod_0()
		{
			Class47.Class99 @class = new Class47.Class99();
			int arg_0B_0 = Environment.TickCount;
			for (int i = 0; i < Class47.list_1.Count; i++)
			{
				if (Class47.list_1[i].method_0())
				{
					Class47.list_1.RemoveAt(i--);
				}
			}
			bool result;
			if (Environment.TickCount < this.int_1)
			{
				result = true;
			}
			else
			{
				if (this.d3Actor_0 != null)
				{
					if (this.method_2(this.d3Actor_0))
					{
						result = true;
						return result;
					}
					this.d3Actor_0 = null;
				}
				List<D3Actor> list = new List<D3Actor>();
				@class.vector3_0 = Framework.Hero.Position;
				foreach (D3Actor current in Framework.Actors)
				{
					float num = 0f;
					if (this.method_1(current, out num) && base.method_0(current, @class.vector3_0, num * num))
					{
						list.Add(current);
					}
				}
				this.d3Actor_0 = list.OrderBy(new Func<D3Actor, float>(@class.method_0)).FirstOrDefault<D3Actor>();
				result = (this.d3Actor_0 != null);
			}
			return result;
		}
		internal override int vmethod_2()
		{
			return 2;
		}
		internal override string vmethod_3()
		{
			string text = "Destroying: ";
			if (this.d3Actor_0 != null)
			{
				text += this.d3Actor_0.Modelname;
			}
			else
			{
				text += "null";
			}
			return text;
		}
		internal override void vmethod_1()
		{
			try
			{
				if (Environment.TickCount >= this.int_1)
				{
					if (!this.method_2(this.d3Actor_0))
					{
						this.d3Actor_0 = null;
					}
					else
					{
						bool flag = Framework.Navigator.TraceRay_Projectile_CanPass(Framework.Hero.Position, this.d3Actor_0.Position);
						if (Framework.Hero.Class == D3Class.Barbarian && this.int_0 < Environment.TickCount)
						{
							Movement.MoveTo(this.d3Actor_0.Position);
							this.int_1 = Environment.TickCount + 350;
							this.int_0 = Environment.TickCount + 350 + 350;
						}
						else
						{
							if (Framework.Hero.Class == D3Class.Barbarian && Environment.TickCount < this.int_0)
							{
								IEnumerable<KeyValuePair<int, D3Spell>> arg_FA_0 = Framework.Hero.GetActiveSpells();
								if (Class47.func_0 == null)
								{
									Class47.func_0 = new Func<KeyValuePair<int, D3Spell>, bool>(Class47.smethod_1);
								}
								IEnumerable<KeyValuePair<int, D3Spell>> source = arg_FA_0.Where(Class47.func_0);
								if (source.Count<KeyValuePair<int, D3Spell>>() > 0)
								{
									D3Power d3Power = source.First<KeyValuePair<int, D3Spell>>().Value.D3Power;
									Framework.Hero.Attack(this.d3Actor_0, d3Power);
								}
							}
							else
							{
								if (!flag)
								{
									Movement.MoveTo(this.d3Actor_0.Position);
								}
								else
								{
									IEnumerable<KeyValuePair<int, D3Spell>> arg_177_0 = Framework.Hero.GetActiveSpells();
									if (Class47.func_1 == null)
									{
										Class47.func_1 = new Func<KeyValuePair<int, D3Spell>, bool>(Class47.smethod_2);
									}
									IEnumerable<KeyValuePair<int, D3Spell>> source2 = arg_177_0.Where(Class47.func_1);
									if (source2.Count<KeyValuePair<int, D3Spell>>() > 0)
									{
										D3Power d3Power = source2.First<KeyValuePair<int, D3Spell>>().Value.D3Power;
										Framework.Hero.Attack(this.d3Actor_0, d3Power);
									}
									this.int_1 = Environment.TickCount + 200;
								}
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				GClass0.smethod_0().method_4("Do \"Obstacles\": " + ex.Message);
			}
		}
		[CompilerGenerated]
		private static bool smethod_1(KeyValuePair<int, D3Spell> keyValuePair_0)
		{
			return keyValuePair_0.Value.CanCast;
		}
		[CompilerGenerated]
		private static bool smethod_2(KeyValuePair<int, D3Spell> keyValuePair_0)
		{
			return keyValuePair_0.Value.CanCast;
		}
	}
}
