using D3Core;
using D3Core.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
namespace ns1
{
	internal class Class49 : Class44
	{
		[CompilerGenerated]
		private sealed class Class108
		{
			public D3Actor d3Actor_0;
			public bool method_0(Class97 class97_0)
			{
				return class97_0.CompleteModelName == this.d3Actor_0.Modelname;
			}
			public bool method_1(Class97 class97_0)
			{
				return class97_0.CompleteModelName == this.d3Actor_0.Modelname;
			}
		}
		[CompilerGenerated]
		private sealed class Class107
		{
			public D3Actor d3Actor_0;
			public bool method_0(D3Actor d3Actor_1)
			{
				return d3Actor_1.Modelname == this.d3Actor_0.Modelname;
			}
		}
		[CompilerGenerated]
		private sealed class Class109
		{
			public float float_0;
			public bool method_0(D3Actor d3Actor_0)
			{
				return Class49.smethod_1(d3Actor_0, out this.float_0);
			}
		}
		public static List<Class42> list_0 = new List<Class42>();
		private static List<Class97> list_1 = new List<Class97>();
		private D3Actor d3Actor_0 = null;
		private int int_0 = 0;
		private int int_1 = 0;
		internal static bool smethod_1(D3Actor d3Actor_1, out float float_0)
		{
			Func<Class97, bool> func = null;
			Class49.Class108 @class = new Class49.Class108();
			@class.d3Actor_0 = d3Actor_1;
			float_0 = -1f;
			bool result;
			if (@class.d3Actor_0 == null)
			{
				result = false;
			}
			else
			{
				if (@class.d3Actor_0.GetInt((D3Attribute)4294963682u) == 1)
				{
					result = false;
				}
				else
				{
					Class97 class2 = Class49.list_1.FirstOrDefault(new Func<Class97, bool>(@class.method_0));
					if (class2 != null)
					{
						result = false;
					}
					else
					{
						if (@class.d3Actor_0.GetInt((D3Attribute)4294963553u) == 1)
						{
							IEnumerable<Class97> arg_9C_0 = Class49.list_1;
							if (func == null)
							{
								func = new Func<Class97, bool>(@class.method_1);
							}
							if (arg_9C_0.FirstOrDefault(func) == null)
							{
								Class49.list_1.Add(new Class97(@class.d3Actor_0.Modelname, 0, true));
							}
							result = false;
						}
						else
						{
							for (int i = 0; i < Class49.list_0.Count; i++)
							{
								if (Class49.list_0[i].ModelId != -1 && (ulong)@class.d3Actor_0.UInt32_0 == (ulong)((long)Class49.list_0[i].ModelId))
								{
									float_0 = Class49.list_0[i].method_0();
									result = true;
									return result;
								}
							}
							for (int i = 0; i < Class49.list_0.Count; i++)
							{
								if (Class49.list_0[i].ModelId == -1 && @class.d3Actor_0.Modelname.Contains(Class49.list_0[i].ModelNameSubstring))
								{
									float_0 = Class49.list_0[i].method_0();
									result = true;
									return result;
								}
							}
							result = false;
						}
					}
				}
			}
			return result;
		}
		private bool method_1(D3Actor d3Actor_1)
		{
			Class49.Class107 @class = new Class49.Class107();
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
					Class49.list_1.Add(new Class97(@class.d3Actor_0.Modelname, Environment.TickCount + 5000));
					result = false;
				}
				else
				{
					float num = 0f;
					if (!Class49.smethod_1(@class.d3Actor_0, out num))
					{
						Class49.list_1.Add(new Class97(@class.d3Actor_0.Modelname, Environment.TickCount + 5000));
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
			bool result;
			try
			{
				Class49.Class109 @class = new Class49.Class109();
				int arg_0C_0 = Environment.TickCount;
				for (int i = 0; i < Class49.list_1.Count; i++)
				{
					if (Class49.list_1[i].method_0())
					{
						Class49.list_1.RemoveAt(i--);
					}
				}
				if (this.int_1 > 0)
				{
					result = true;
				}
				else
				{
					if (this.d3Actor_0 != null)
					{
						if (this.method_1(this.d3Actor_0))
						{
							result = true;
							return result;
						}
						this.int_0 = 0;
						this.d3Actor_0 = null;
					}
					Tuple<D3Actor, float> tuple = null;
					@class.float_0 = 0f;
					foreach (D3Actor current in Framework.Actors.Where(new Func<D3Actor, bool>(@class.method_0)))
					{
						float num = current.DistanceToHero();
						if (num < @class.float_0 && (tuple == null || tuple.Item2 > num))
						{
							tuple = Tuple.Create<D3Actor, float>(current, num);
						}
					}
					if (tuple == null)
					{
						result = false;
					}
					else
					{
						this.int_0 = 0;
						this.d3Actor_0 = tuple.Item1;
						result = true;
					}
				}
			}
			catch (Exception ex)
			{
				GClass0.smethod_0().method_4("Error in DoorAndLoot: " + ex.Message);
				result = false;
			}
			return result;
		}
		internal override int vmethod_2()
		{
			return 1;
		}
		internal override string vmethod_3()
		{
			string text = "Opening Door: ";
			if (this.d3Actor_0 != null)
			{
				text += this.d3Actor_0.Modelname;
			}
			return text;
		}
		internal override void vmethod_1()
		{
			try
			{
				if (this.int_1 > 0)
				{
					this.int_1--;
				}
				else
				{
					if (!this.method_1(this.d3Actor_0))
					{
						this.int_0 = 0;
						this.d3Actor_0 = null;
					}
					else
					{
						Framework.Hero.Interact(this.d3Actor_0);
						this.int_0++;
						if (this.int_0 >= 30)
						{
							Class49.list_1.Add(new Class97(this.d3Actor_0.Modelname, Environment.TickCount + 10000));
						}
						this.int_1 = 2;
					}
				}
			}
			catch (Exception ex)
			{
				GClass0.smethod_0().method_4("Do \"Doors\": " + ex.Message);
			}
		}
	}
}
