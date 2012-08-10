using D3Core;
using D3Core.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
namespace ns1
{
	internal class Class48 : Class44
	{
		[CompilerGenerated]
		private sealed class Class101
		{
			public D3Actor d3Actor_0;
			public bool method_0(D3Actor d3Actor_1)
			{
				return d3Actor_1.Guid == this.d3Actor_0.Guid && d3Actor_1.Modelname == this.d3Actor_0.Modelname;
			}
			public bool method_1(Class97 class97_0)
			{
				return class97_0.CompleteModelName == this.d3Actor_0.Modelname;
			}
			public bool method_2(Class97 class97_0)
			{
				return class97_0.CompleteModelName == this.d3Actor_0.Modelname;
			}
		}
		internal static D3ItemRarity d3ItemRarity_0 = D3ItemRarity.Magic_BlueGood;
		internal static List<Class42> list_0 = new List<Class42>();
		internal static List<Class97> list_1 = new List<Class97>();
		private D3Actor d3Actor_0;
		private int int_0 = 0;
		private string string_0 = "";
		private int int_1 = 0;
		[CompilerGenerated]
		private static int int_2;
		[CompilerGenerated]
		private static Func<D3Actor, float> func_0;
		public static int LastRan
		{
			get;
			private set;
		}
		private bool method_1(D3Actor d3Actor_1, out float float_0)
		{
			Func<Class97, bool> func = null;
			Class48.Class101 @class = new Class48.Class101();
			@class.d3Actor_0 = d3Actor_1;
			float_0 = GClass0.smethod_0().float_2;
			bool result;
			if (@class.d3Actor_0 == null)
			{
				result = false;
			}
			else
			{
				if (Framework.Actors.FirstOrDefault(new Func<D3Actor, bool>(@class.method_0)) == null)
				{
					result = false;
				}
				else
				{
					if (Class48.list_1.FirstOrDefault(new Func<Class97, bool>(@class.method_1)) != null)
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
							if (@class.d3Actor_0.GetFloat((D3Attribute)4294963307u) > 0f)
							{
								result = !InjectedWindow.Instance.class71_0.DontPickupPotions;
							}
							else
							{
								if (@class.d3Actor_0.GetInt((D3Attribute)4294963553u) == 1)
								{
									IEnumerable<Class97> arg_102_0 = Class48.list_1;
									if (func == null)
									{
										func = new Func<Class97, bool>(@class.method_2);
									}
									if (arg_102_0.FirstOrDefault(func) == null)
									{
										Class48.list_1.Add(new Class97(@class.d3Actor_0.Modelname, 0, true));
										GClass0.smethod_0().method_5("Banning item: " + @class.d3Actor_0.Modelname + ", because it has already been operated");
									}
									result = false;
								}
								else
								{
									if (@class.d3Actor_0.GetInt((D3Attribute)4294963545u) == 1)
									{
										result = false;
									}
									else
									{
										if (@class.d3Actor_0.GetInt((D3Attribute)4294963257u) > InjectedWindow.Instance.class71_0.MinimumGoldToLoot)
										{
											result = true;
										}
										else
										{
											if (@class.d3Actor_0.GetInt((D3Attribute)4294963494u) >= (int)Class48.d3ItemRarity_0)
											{
												result = true;
											}
											else
											{
												foreach (Class42 current in Class48.list_0)
												{
													if (current.ModelId != -1 && (ulong)@class.d3Actor_0.UInt32_0 == (ulong)((long)current.ModelId))
													{
														float_0 = current.method_0();
														result = true;
														return result;
													}
												}
												foreach (Class42 current in Class48.list_0)
												{
													if (current.ModelId == -1 && @class.d3Actor_0.Modelname.Contains(current.ModelNameSubstring))
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
								}
							}
						}
					}
				}
			}
			return result;
		}
		internal override bool vmethod_0()
		{
			Func<D3Actor, bool> func = null;
			bool result;
			if (GClass0.smethod_0().float_2 == 0f)
			{
				result = false;
			}
			else
			{
				if (this.int_1 > 0)
				{
					result = true;
				}
				else
				{
					for (int i = 0; i < Class48.list_1.Count; i++)
					{
						if (Class48.list_1[i].method_0())
						{
							Class48.list_1.RemoveAt(i--);
						}
					}
					if (this.d3Actor_0 != null)
					{
						float num = 0f;
						if (!this.method_1(this.d3Actor_0, out num))
						{
							this.d3Actor_0 = null;
						}
					}
					if (this.d3Actor_0 != null)
					{
						IEnumerable<D3Actor> arg_B8_0 = Framework.Actors;
						if (func == null)
						{
							func = new Func<D3Actor, bool>(this.method_2);
						}
						bool flag = arg_B8_0.FirstOrDefault(func) == null;
						float num = 0f;
						if (!this.method_1(this.d3Actor_0, out num) || flag)
						{
							this.d3Actor_0 = null;
						}
					}
					D3Actor d3Actor = this.d3Actor_0;
					List<D3Actor> list = Framework.Actors.ToList<D3Actor>();
					Vector3 position = Framework.Hero.Position;
					List<D3Actor> list2 = new List<D3Actor>();
					foreach (D3Actor current in list)
					{
						float num2 = 0f;
						if (this.method_1(current, out num2))
						{
							float num3 = Class44.smethod_0(position, current.Position);
							if (num3 != 0f && num3 < num2)
							{
								if (InjectedWindow.Instance.class71_0.UseCustomItemFactors && InjectedWindow.Instance.class71_0.CustomItemFactors != null)
								{
									float num4 = Class100.smethod_1(current);
									if (num4 < InjectedWindow.Instance.class71_0.CustomItemFactors_MinimumValue)
									{
										Class48.list_1.Add(new Class97(current.Modelname, 0, true));
										GClass0.smethod_0().method_5("Banning item: " + current.Modelname + ", because its calculated value is too bad.");
										result = false;
										return result;
									}
								}
								list2.Add(current);
							}
						}
					}
					IEnumerable<D3Actor> arg_22D_0 = list2;
					if (Class48.func_0 == null)
					{
						Class48.func_0 = new Func<D3Actor, float>(Class48.smethod_1);
					}
					IOrderedEnumerable<D3Actor> source = arg_22D_0.OrderBy(Class48.func_0);
					this.d3Actor_0 = source.FirstOrDefault<D3Actor>();
					if (this.d3Actor_0 == null && d3Actor != null)
					{
						this.d3Actor_0 = d3Actor;
						result = true;
					}
					else
					{
						if (this.d3Actor_0 != null && d3Actor != null)
						{
							float num5 = Class44.smethod_0(position, this.d3Actor_0.Position);
							float num6 = Class44.smethod_0(position, d3Actor.Position);
							if (num5 == 0f || num6 == 0f)
							{
								result = true;
							}
							else
							{
								if (num6 + 10f < num5)
								{
									this.d3Actor_0 = d3Actor;
								}
								result = true;
							}
						}
						else
						{
							result = false;
						}
					}
				}
			}
			return result;
		}
		internal override int vmethod_2()
		{
			return 6;
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
					Class48.LastRan = Environment.TickCount;
					if (this.d3Actor_0 != null)
					{
						if (this.string_0 != this.d3Actor_0.Modelname)
						{
							this.string_0 = this.d3Actor_0.Modelname;
							this.int_0 = Environment.TickCount + 20000;
						}
						if (this.int_0 < Environment.TickCount && this.string_0.Length > 2)
						{
							Class48.list_1.Add(new Class97(this.string_0, Environment.TickCount + 25000, true));
						}
						float num = Class44.smethod_0(Framework.Hero.Position, this.d3Actor_0.Position);
						if (num > 9f)
						{
							GClass0.smethod_0().method_5(string.Concat(new object[]
							{
								"Moving: ",
								this.d3Actor_0.Position,
								", dist: ",
								Class44.smethod_0(Framework.Hero.Position, this.d3Actor_0.Position)
							}));
							Movement.MoveTo(this.d3Actor_0.Position);
						}
						else
						{
							GClass0.smethod_0().method_5(string.Concat(new object[]
							{
								"Collecting item: ",
								this.d3Actor_0.Modelname,
								", dist: ",
								Class44.smethod_0(Framework.Hero.Position, this.d3Actor_0.Position)
							}));
							Framework.Hero.CollectItem(this.d3Actor_0);
						}
						this.int_1 = 2;
					}
				}
			}
			catch (Exception ex)
			{
				GClass0.smethod_0().method_4("Do \"Loot\": " + ex.Message);
			}
		}
		internal override string vmethod_3()
		{
			string text = "Target: ";
			if (this.d3Actor_0 != null)
			{
				text = text + this.d3Actor_0.Modelname + " (dis: {0})".smethod_0(Class44.smethod_0(Framework.Hero.Position, this.d3Actor_0.Position));
			}
			else
			{
				text += "null";
			}
			return text;
		}
		[CompilerGenerated]
		private bool method_2(D3Actor d3Actor_1)
		{
			return d3Actor_1.Modelname == this.d3Actor_0.Modelname;
		}
		[CompilerGenerated]
		private static float smethod_1(D3Actor d3Actor_1)
		{
			return Class44.smethod_0(d3Actor_1.Position, Framework.Hero.Position);
		}
	}
}
