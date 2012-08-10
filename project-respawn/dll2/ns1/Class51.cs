using D3Core;
using D3Core.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
namespace ns1
{
	internal class Class51 : Class44
	{
		private class Class131
		{
			[CompilerGenerated]
			private sealed class Class135
			{
				public List<D3Item> list_0;
				public bool method_0(D3Item d3Item_0)
				{
					return this.list_0.Contains(d3Item_0);
				}
			}
			[CompilerGenerated]
			private sealed class Class133
			{
				public uint uint_0;
			}
			[CompilerGenerated]
			private sealed class Class134
			{
				public Class51.Class131.Class133 class133_0;
				public uint uint_0;
				public bool method_0(D3Item d3Item_0)
				{
					return d3Item_0.UInt32_0 == this.uint_0 && d3Item_0.UInt32_1 == this.class133_0.uint_0;
				}
				public bool method_1(D3Item d3Item_0)
				{
					return d3Item_0.UInt32_0 == this.uint_0 && d3Item_0.UInt32_1 == this.class133_0.uint_0 - 1u && d3Item_0.IsBigItem;
				}
				public bool method_2(D3Item d3Item_0)
				{
					return d3Item_0.UInt32_0 == this.uint_0 && d3Item_0.UInt32_1 == this.class133_0.uint_0 + 1u;
				}
				public bool method_3(Tuple<uint, uint> tuple_0)
				{
					return tuple_0.Item1 == this.uint_0 && tuple_0.Item2 == this.class133_0.uint_0;
				}
				public bool method_4(Tuple<uint, uint> tuple_0)
				{
					return tuple_0.Item1 == this.uint_0 && tuple_0.Item2 == this.class133_0.uint_0;
				}
			}
			private Class51 class51_0;
			private bool bool_0 = false;
			private bool bool_1 = false;
			private bool bool_2 = false;
			private D3Item d3Item_0;
			private int int_0;
			private bool bool_3;
			[CompilerGenerated]
			private static Func<D3Actor, bool> func_0;
			[CompilerGenerated]
			private static Func<D3Actor, bool> func_1;
			[CompilerGenerated]
			private static Func<D3Item, bool> func_2;
			[CompilerGenerated]
			private static Func<D3Item, bool> func_3;
			public Class131(Class51 class51_1)
			{
				this.class51_0 = class51_1;
			}
			internal void method_0()
			{
				this.bool_0 = false;
				this.bool_1 = false;
				this.bool_3 = false;
				this.bool_2 = false;
			}
			internal bool method_1()
			{
				bool result;
				if (this.int_0 > Environment.TickCount)
				{
					result = true;
				}
				else
				{
					this.d3Item_0 = null;
					foreach (D3Item current in Framework.Hero.Inventory)
					{
						if (current.IsUnidentified)
						{
							this.d3Item_0 = current;
							result = true;
							return result;
						}
					}
					result = !this.bool_0;
				}
				return result;
			}
			internal void method_2()
			{
				Class51.Class131.Class135 @class = new Class51.Class131.Class135();
				if (!this.bool_3)
				{
					this.class51_0.int_0 = Environment.TickCount + 500;
					this.bool_3 = true;
				}
				else
				{
					if (this.int_0 <= Environment.TickCount)
					{
						if (this.d3Item_0 != null)
						{
							GClass0.smethod_0().method_5(string.Concat(new object[]
							{
								"Identifying item: ",
								this.d3Item_0.Modelname,
								", ID: ",
								this.d3Item_0.Sno
							}));
							Framework.RequestIdentify(this.d3Item_0);
							this.int_0 = Environment.TickCount + 3000;
						}
						else
						{
							IEnumerable<D3Actor> arg_DB_0 = Framework.Actors;
							if (Class51.Class131.func_0 == null)
							{
								Class51.Class131.func_0 = new Func<D3Actor, bool>(Class51.Class131.smethod_0);
							}
							D3Actor d3Actor = arg_DB_0.First(Class51.Class131.func_0);
							if (d3Actor.DistanceToHero() > 9f)
							{
								Movement.MoveTo(d3Actor.Position);
							}
							else
							{
								IEnumerable<D3Actor> arg_125_0 = Framework.Actors;
								if (Class51.Class131.func_1 == null)
								{
									Class51.Class131.func_1 = new Func<D3Actor, bool>(Class51.Class131.smethod_1);
								}
								D3Actor d3Actor2 = arg_125_0.FirstOrDefault(Class51.Class131.func_1);
								if (!this.bool_1)
								{
									if (d3Actor2 != null)
									{
										this.bool_1 = Framework.Hero.InteractWithObject(d3Actor2);
									}
									this.class51_0.int_0 = Environment.TickCount + 500;
								}
								else
								{
									Framework.Hero.InteractWithObject(d3Actor2);
									bool flag = true;
									List<D3Item> collection = Framework.Hero.StashItems.ToList<D3Item>();
									List<D3Item> list = Framework.Hero.Inventory.ToList<D3Item>();
									list.AddRange(collection);
									int @int = Framework.Hero.GetInt((D3Attribute)4294963209u);
									IEnumerable<D3Item> arg_1CF_0 = list;
									if (Class51.Class131.func_2 == null)
									{
										Class51.Class131.func_2 = new Func<D3Item, bool>(Class51.Class131.smethod_2);
									}
									List<D3Item> list2 = arg_1CF_0.Where(Class51.Class131.func_2).ToList<D3Item>();
									@class.list_0 = new List<D3Item>();
									int num = 0;
									foreach (D3Item current in list2)
									{
										if (current.IsBigItem)
										{
											num += 2;
										}
										else
										{
											num++;
										}
										if (num > @int)
										{
											break;
										}
										@class.list_0.Add(current);
									}
									List<D3Item> list3 = Framework.Hero.Inventory.Where(new Func<D3Item, bool>(@class.method_0)).ToList<D3Item>();
									IEnumerable<D3Item> arg_292_0 = Framework.Hero.StashItems;
									if (Class51.Class131.func_3 == null)
									{
										Class51.Class131.func_3 = new Func<D3Item, bool>(Class51.Class131.smethod_3);
									}
									List<D3Item> list4 = arg_292_0.Where(Class51.Class131.func_3).ToList<D3Item>();
									if (InjectedWindow.Instance.class71_0.AllowToTakeOutStashItems && !this.bool_2)
									{
										List<Tuple<uint, uint>> list5 = new List<Tuple<uint, uint>>();
										foreach (D3Item current in list4)
										{
											Tuple<uint, uint> tuple = this.method_3(false, current.IsBigItem, list5, current);
											if (tuple == null)
											{
												GClass0.smethod_0().method_5("Can't move item: " + current.Modelname + ", not enough space in inventory?");
												break;
											}
											flag = false;
											current.MoveItem(ItemLocationIndex.Inventory, tuple.Item1, tuple.Item2);
											list5.Add(new Tuple<uint, uint>(tuple.Item1, tuple.Item2));
											if (current.IsBigItem)
											{
												list5.Add(new Tuple<uint, uint>(tuple.Item1, tuple.Item2 + 1u));
											}
										}
										this.bool_2 = true;
									}
									List<Tuple<uint, uint>> list6 = new List<Tuple<uint, uint>>();
									foreach (D3Item current in list3)
									{
										Tuple<uint, uint> tuple = this.method_3(true, current.IsBigItem, list6, current);
										if (tuple == null)
										{
											GClass0.smethod_0().method_5("Can't move item: " + current.Modelname + ", not enough space in stash?");
											break;
										}
										flag = false;
										current.MoveItem(ItemLocationIndex.Stash, tuple.Item1, tuple.Item2);
										list6.Add(new Tuple<uint, uint>(tuple.Item1, tuple.Item2));
										if (current.IsBigItem)
										{
											list6.Add(new Tuple<uint, uint>(tuple.Item1, tuple.Item2 + 1u));
										}
									}
									if (flag)
									{
										this.bool_0 = true;
										this.class51_0.int_0 = Environment.TickCount + 300;
									}
								}
							}
						}
					}
				}
			}
			private Tuple<uint, uint> method_3(bool bool_4, bool bool_5, List<Tuple<uint, uint>> list_0, D3Item d3Item_1)
			{
				int num;
				int num2;
				List<D3Item> list;
				if (bool_4)
				{
					num = Framework.Hero.GetInt((D3Attribute)4294963209u);
					num2 = 7;
					list = Framework.Hero.StashItems.ToList<D3Item>();
				}
				else
				{
					num = 60;
					num2 = 10;
					list = Framework.Hero.Inventory.ToList<D3Item>();
				}
				Class51.Class131.Class133 @class = new Class51.Class131.Class133();
				@class.uint_0 = 0u;
				Tuple<uint, uint> result;
				while ((ulong)@class.uint_0 < (ulong)((long)(num / num2)))
				{
					Func<D3Item, bool> func = null;
					Func<D3Item, bool> func2 = null;
					Func<D3Item, bool> func3 = null;
					Func<Tuple<uint, uint>, bool> func4 = null;
					Func<Tuple<uint, uint>, bool> func5 = null;
					Class51.Class131.Class134 class2 = new Class51.Class131.Class134();
					class2.class133_0 = @class;
					class2.uint_0 = 0u;
					while ((ulong)class2.uint_0 < (ulong)((long)num2))
					{
						bool flag = @class.uint_0 != 0u && (@class.uint_0 + 1u) % 10u == 0u;
						if (!bool_5 || !flag)
						{
							bool flag2 = @class.uint_0 % 10u == 0u;
							IEnumerable<D3Item> arg_CC_0 = list;
							if (func == null)
							{
								func = new Func<D3Item, bool>(class2.method_0);
							}
							D3Item d3Item = arg_CC_0.FirstOrDefault(func);
							if (d3Item != null)
							{
								if (d3Item.Sno == d3Item_1.Sno)
								{
									int @int = d3Item_1.GetInt((D3Attribute)4294963507u);
									if (@int != 0)
									{
										int num3 = Class132.smethod_4(d3Item) - @int;
										if (num3 > 0)
										{
											result = new Tuple<uint, uint>(d3Item.UInt32_0, d3Item.UInt32_1);
											return result;
										}
									}
								}
							}
							else
							{
								if (!flag2)
								{
									IEnumerable<D3Item> arg_142_0 = list;
									if (func2 == null)
									{
										func2 = new Func<D3Item, bool>(class2.method_1);
									}
									D3Item d3Item2 = arg_142_0.FirstOrDefault(func2);
									if (d3Item2 != null)
									{
										goto IL_1C5;
									}
								}
								if (bool_5)
								{
									IEnumerable<D3Item> arg_16C_0 = list;
									if (func3 == null)
									{
										func3 = new Func<D3Item, bool>(class2.method_2);
									}
									D3Item d3Item3 = arg_16C_0.FirstOrDefault(func3);
									if (d3Item3 == null)
									{
										if (func4 == null)
										{
											func4 = new Func<Tuple<uint, uint>, bool>(class2.method_3);
										}
										if (list_0.FirstOrDefault(func4) == null)
										{
											result = new Tuple<uint, uint>(class2.uint_0, @class.uint_0);
											return result;
										}
									}
								}
								else
								{
									if (func5 == null)
									{
										func5 = new Func<Tuple<uint, uint>, bool>(class2.method_4);
									}
									if (list_0.FirstOrDefault(func5) == null)
									{
										result = new Tuple<uint, uint>(class2.uint_0, @class.uint_0);
										return result;
									}
								}
							}
						}
						IL_1C5:
						class2.uint_0 += 1u;
					}
					@class.uint_0 += 1u;
				}
				result = null;
				return result;
			}
			[CompilerGenerated]
			private static bool smethod_0(D3Actor d3Actor_0)
			{
				return d3Actor_0.UInt32_0 == 130400u;
			}
			[CompilerGenerated]
			private static bool smethod_1(D3Actor d3Actor_0)
			{
				return d3Actor_0.UInt32_0 == 130400u;
			}
			[CompilerGenerated]
			private static bool smethod_2(D3Item d3Item_1)
			{
				return d3Item_1.GetFloat((D3Attribute)4294963307u) <= 0f && (Class132.smethod_0(d3Item_1.Modelname) || d3Item_1.GetInt((D3Attribute)4294963494u) >= InjectedWindow.Instance.class71_0.MinimumItemQualityToStash);
			}
			[CompilerGenerated]
			private static bool smethod_3(D3Item d3Item_1)
			{
				return !Class132.smethod_0(d3Item_1.Modelname) && (d3Item_1.HitpointsGranted > 0f || d3Item_1.GetInt((D3Attribute)4294963494u) < InjectedWindow.Instance.class71_0.MaximumSellOrSalvageValue);
			}
		}
		private class Class130
		{
			private Class51 class51_0;
			private bool bool_0;
			private bool bool_1;
			private List<D3Item> list_0;
			[CompilerGenerated]
			private static Func<D3Item, bool> func_0;
			[CompilerGenerated]
			private static Func<D3Item, float> func_1;
			[CompilerGenerated]
			private static Func<D3Item, bool> func_2;
			[CompilerGenerated]
			private static Func<D3Item, float> func_3;
			[CompilerGenerated]
			private static Func<D3Actor, bool> func_4;
			public Class130(Class51 class51_1)
			{
				this.class51_0 = class51_1;
			}
			public bool method_0()
			{
				if (InjectedWindow.Instance.class71_0.SellInsteadOfSalvage)
				{
					this.list_0 = new List<D3Item>();
				}
				if (this.list_0 == null)
				{
					if (InjectedWindow.Instance.class71_0.UseCustomItemFactors)
					{
						IEnumerable<D3Item> arg_6C_0 = Framework.Hero.Inventory;
						if (Class51.Class130.func_0 == null)
						{
							Class51.Class130.func_0 = new Func<D3Item, bool>(Class51.Class130.smethod_0);
						}
						IEnumerable<D3Item> arg_8E_0 = arg_6C_0.Where(Class51.Class130.func_0);
						if (Class51.Class130.func_1 == null)
						{
							Class51.Class130.func_1 = new Func<D3Item, float>(Class51.Class130.smethod_1);
						}
						this.list_0 = arg_8E_0.OrderBy(Class51.Class130.func_1).ToList<D3Item>();
					}
					else
					{
						IEnumerable<D3Item> arg_C7_0 = Framework.Hero.Inventory;
						if (Class51.Class130.func_2 == null)
						{
							Class51.Class130.func_2 = new Func<D3Item, bool>(Class51.Class130.smethod_2);
						}
						IEnumerable<D3Item> arg_E9_0 = arg_C7_0.Where(Class51.Class130.func_2);
						if (Class51.Class130.func_3 == null)
						{
							Class51.Class130.func_3 = new Func<D3Item, float>(Class51.Class130.smethod_3);
						}
						this.list_0 = arg_E9_0.OrderBy(Class51.Class130.func_3).ToList<D3Item>();
					}
				}
				return !this.bool_0;
			}
			public void method_1()
			{
				this.bool_0 = false;
				this.bool_1 = false;
				this.list_0 = null;
			}
			public void method_2()
			{
				IEnumerable<D3Actor> arg_22_0 = Framework.Actors;
				if (Class51.Class130.func_4 == null)
				{
					Class51.Class130.func_4 = new Func<D3Actor, bool>(Class51.Class130.smethod_4);
				}
				D3Actor d3Actor = arg_22_0.FirstOrDefault(Class51.Class130.func_4);
				if (Framework.Hero.DistanceTo(this.class51_0.vector3_1) > 11f)
				{
					Movement.MoveTo(this.class51_0.vector3_1);
				}
				else
				{
					if (!this.bool_1 && d3Actor != null)
					{
						this.class51_0.int_0 = Environment.TickCount + 850;
						this.bool_1 = Framework.Hero.Interact(d3Actor);
						if (!this.bool_1)
						{
							Movement.MoveTo(d3Actor.Position);
						}
					}
					else
					{
						D3Item d3Item = this.list_0.FirstOrDefault<D3Item>();
						if (d3Item != null)
						{
							GClass0.smethod_0().method_5(string.Concat(new object[]
							{
								"Salvaging item: ",
								d3Item.Modelname,
								", id: ",
								d3Item.Sno
							}));
							this.class51_0.int_0 = Environment.TickCount + 120;
							Framework.Hero.Interact(d3Actor);
							Framework.SalvageItem(d3Item);
							this.list_0.RemoveAt(0);
						}
						else
						{
							this.class51_0.int_0 = Environment.TickCount + 500;
							this.bool_0 = true;
						}
					}
				}
			}
			[CompilerGenerated]
			private static bool smethod_0(D3Item d3Item_0)
			{
				bool result;
				if (!d3Item_0.CanSalvage)
				{
					result = false;
				}
				else
				{
					float num = Class100.smethod_0(d3Item_0);
					if (num < InjectedWindow.Instance.class71_0.CustomItemFactors_MaximumValue)
					{
						GClass0.smethod_0().method_5(string.Concat(new object[]
						{
							"Salvaging item: ",
							d3Item_0.Modelname,
							", ItemValue: ",
							num,
							" < ",
							InjectedWindow.Instance.class71_0.CustomItemFactors_MaximumValue
						}));
						result = true;
					}
					else
					{
						GClass0.smethod_0().method_5(string.Concat(new object[]
						{
							"Not salvaging item: ",
							d3Item_0.Modelname,
							", ItemValue: ",
							num
						}));
						result = false;
					}
				}
				return result;
			}
			[CompilerGenerated]
			private static float smethod_1(D3Item d3Item_0)
			{
				return Class100.smethod_0(d3Item_0);
			}
			[CompilerGenerated]
			private static bool smethod_2(D3Item d3Item_0)
			{
				bool result;
				if (!d3Item_0.CanSalvage)
				{
					result = false;
				}
				else
				{
					int @int = d3Item_0.GetInt((D3Attribute)4294963494u);
					if (@int > 8 || @int >= InjectedWindow.Instance.class71_0.MaximumSellOrSalvageValue)
					{
						GClass0.smethod_0().method_5("Item: " + d3Item_0.Modelname + ", cannot be salvaged because of its quality");
						result = false;
					}
					else
					{
						result = true;
					}
				}
				return result;
			}
			[CompilerGenerated]
			private static float smethod_3(D3Item d3Item_0)
			{
				return Class100.smethod_0(d3Item_0);
			}
			[CompilerGenerated]
			private static bool smethod_4(D3Actor d3Actor_0)
			{
				return d3Actor_0.UInt32_0 == 195170u;
			}
		}
		public class Class129
		{
			private int int_0 = -1;
			private string string_0 = string.Empty;
			private Vector3? vector3_0 = null;
			private Class51 class51_0;
			private bool bool_0;
			private bool bool_1;
			[CompilerGenerated]
			private static Func<D3Item, bool> func_0;
			public Class129(Class51 class51_1)
			{
				this.class51_0 = class51_1;
			}
			public bool method_0()
			{
				D3_IngameAct currentAct = Framework.CurrentAct;
				if (currentAct <= D3_IngameAct.Act2)
				{
					if (currentAct != D3_IngameAct.Act1)
					{
						if (currentAct == D3_IngameAct.Act2)
						{
							this.string_0 = "A2_UniqueVendor_Fence_InTown";
							this.vector3_0 = new Vector3?(new Vector3(340f, 144f, -16f));
						}
					}
					else
					{
						this.string_0 = "Miner_InTown_";
						this.int_0 = 4440;
						this.vector3_0 = new Vector3?(new Vector3(2901f, 2783f, 24f));
					}
				}
				else
				{
					if (currentAct != D3_IngameAct.Act3)
					{
						if (currentAct == D3_IngameAct.Act4)
						{
							this.string_0 = "A4_UniqueVendor_Miner_InTown_";
							this.vector3_0 = new Vector3?(new Vector3(393.6f, 510f, 0f));
						}
					}
					else
					{
						this.string_0 = "A3_UniqueVendor_Miner_InTown_";
						this.vector3_0 = new Vector3?(new Vector3(394f, 513f, 0f));
					}
				}
				return !this.bool_1;
			}
			public void method_1()
			{
				this.bool_0 = false;
				this.bool_1 = false;
			}
			public void method_2()
			{
				if (this.vector3_0.HasValue && Vector3.DistanceSquared(Framework.Hero.Position, this.vector3_0.Value) > 8f)
				{
					Movement.MoveTo(this.vector3_0.Value);
				}
				else
				{
					D3Actor d3Actor = Framework.Actors.First(new Func<D3Actor, bool>(this.method_3));
					if (d3Actor == null)
					{
						this.bool_1 = true;
					}
					else
					{
						if (!this.bool_0)
						{
							Framework.UsePower_Meta(d3Actor.Guid, 30022u);
							this.class51_0.int_0 = Environment.TickCount + 800;
							this.bool_0 = true;
						}
						else
						{
							if (InjectedWindow.Instance.class71_0.SellInsteadOfSalvage)
							{
								IEnumerable<D3Item> arg_E9_0 = Framework.Hero.Inventory;
								if (Class51.Class129.func_0 == null)
								{
									Class51.Class129.func_0 = new Func<D3Item, bool>(Class51.Class129.smethod_0);
								}
								IEnumerable<D3Item> enumerable = arg_E9_0.Where(Class51.Class129.func_0);
								foreach (D3Item current in enumerable)
								{
									Framework.RequestSellItem(current);
								}
							}
							Framework.RequestRepairAll();
							this.bool_1 = true;
						}
					}
				}
			}
			[CompilerGenerated]
			private bool method_3(D3Actor d3Actor_0)
			{
				return d3Actor_0.Modelname.Contains(this.string_0);
			}
			[CompilerGenerated]
			private static bool smethod_0(D3Item d3Item_0)
			{
				bool result;
				if (d3Item_0.GetFloat((D3Attribute)4294963307u) > 0f)
				{
					result = false;
				}
				else
				{
					if (Class132.smethod_0(d3Item_0.Modelname))
					{
						result = false;
					}
					else
					{
						if (InjectedWindow.Instance.class71_0.UseCustomItemFactors)
						{
							float num = Class100.smethod_0(d3Item_0);
							if (num < InjectedWindow.Instance.class71_0.CustomItemFactors_MaximumValue)
							{
								GClass0.smethod_0().method_5(string.Concat(new object[]
								{
									"Selling item: ",
									d3Item_0.Modelname,
									", ItemValue: ",
									num
								}));
								result = true;
							}
							else
							{
								GClass0.smethod_0().method_5(string.Concat(new object[]
								{
									"Not selling item: ",
									d3Item_0.Modelname,
									", ItemValue: ",
									num
								}));
								result = false;
							}
						}
						else
						{
							if (d3Item_0.GetInt((D3Attribute)4294963494u) < 3)
							{
								result = (d3Item_0.GetFloat((D3Attribute)4294963248u) > 0f || d3Item_0.GetFloat((D3Attribute)4294963356u) > 0f);
							}
							else
							{
								result = (d3Item_0.GetInt((D3Attribute)4294963494u) < InjectedWindow.Instance.class71_0.MaximumSellOrSalvageValue);
							}
						}
					}
				}
				return result;
			}
		}
		private Class51.Class131 class131_0;
		private Class51.Class130 class130_0;
		private Class51.Class129 class129_0;
		private Vector3 vector3_0 = Vector3.Zero;
		private string string_0 = string.Empty;
		internal Vector3 vector3_1 = Vector3.Zero;
		private int int_0 = 0;
		private bool bool_0;
		private bool bool_1 = false;
		[CompilerGenerated]
		private static Func<D3Actor, bool> func_0;
		public Class51()
		{
			this.class131_0 = new Class51.Class131(this);
			this.class130_0 = new Class51.Class130(this);
			this.class129_0 = new Class51.Class129(this);
		}
		internal override int vmethod_2()
		{
			return 8;
		}
		internal override string vmethod_3()
		{
			string result;
			if (this.class131_0 != null && this.class130_0 != null && this.class129_0 != null)
			{
				result = "Done: Stash: {0}, Salvage: {1}, Repair: {2}".smethod_2(!this.class131_0.method_1(), !this.class130_0.method_0(), !this.class129_0.method_0());
			}
			else
			{
				result = "null";
			}
			return result;
		}
		internal override bool vmethod_0()
		{
			D3_IngameAct currentAct = Framework.CurrentAct;
			if (currentAct <= D3_IngameAct.Act2)
			{
				if (currentAct != D3_IngameAct.Act1)
				{
					if (currentAct == D3_IngameAct.Act2)
					{
						this.string_0 = "caOUT_RefugeeCamp";
						this.vector3_0 = new Vector3(301f, 281f, 0f);
						this.vector3_1 = new Vector3(281f, 221f, 0f);
					}
				}
				else
				{
					this.string_0 = "trOUT_Town";
					this.vector3_0 = new Vector3(2981f, 2835f, 24f);
					this.vector3_1 = new Vector3(2942f, 2848f, 24f);
				}
			}
			else
			{
				if (currentAct != D3_IngameAct.Act3)
				{
					if (currentAct == D3_IngameAct.Act4)
					{
						this.string_0 = "a4dun_heaven_hub_keep";
						this.vector3_0 = new Vector3(387f, 391f, 0f);
						this.vector3_1 = new Vector3(320f, 420f, 0f);
					}
				}
				else
				{
					this.string_0 = "a3dun_hub_keep";
					this.vector3_0 = new Vector3(387f, 391f, 0f);
					this.vector3_1 = new Vector3(332f, 413f, 0f);
				}
			}
			bool result;
			if (Environment.TickCount < this.int_0)
			{
				result = true;
			}
			else
			{
				if (Framework.World != this.string_0 && !Framework.CanUsePower(191590))
				{
					result = false;
				}
				else
				{
					if (GClass0.smethod_0().GotoTown)
					{
						result = true;
					}
					else
					{
						int num = 0;
						foreach (D3Item current in Framework.Hero.Inventory)
						{
							if (current.IsBigItem)
							{
								num += 2;
							}
							else
							{
								num++;
							}
						}
						if (num > 50)
						{
							GClass0.smethod_0().method_5("Going to town, because inventory is full");
							GClass0.smethod_0().GotoTown = true;
							result = true;
						}
						else
						{
							foreach (D3Item current2 in Framework.Hero.Equipped)
							{
								int @int = current2.GetInt((D3Attribute)4294963491u);
								int int2 = current2.GetInt((D3Attribute)4294963492u);
								if (int2 > 0 && @int > 0 && (float)@int < (float)int2 * 0.2f)
								{
									GClass0.smethod_0().method_5("Going to town, because we need to repair");
									GClass0.smethod_0().GotoTown = true;
									result = true;
									return result;
								}
							}
							this.class131_0.method_0();
							this.class130_0.method_1();
							this.class129_0.method_1();
							result = false;
						}
					}
				}
			}
			return result;
		}
		internal override void vmethod_1()
		{
			try
			{
				if (Environment.TickCount >= this.int_0)
				{
					if (!this.bool_0 && Framework.Navigator.World != this.string_0)
					{
						if (Movement.IsMoving)
						{
							Movement.WritePositionDirect(Framework.Hero.Position);
						}
						else
						{
							GClass0.smethod_0().method_5("Taking portal to town");
							this.bool_1 = true;
							Framework.TownPortal();
							this.int_0 = Environment.TickCount + 8000;
						}
					}
					else
					{
						if (this.bool_0)
						{
							GClass0.smethod_0().method_5("Stash,Salvage,Sell is finished");
							this.bool_0 = false;
							GClass0.smethod_0().GotoTown = false;
							this.class131_0.method_0();
							this.class130_0.method_1();
							this.class129_0.method_1();
							if (GClass0.smethod_0().class46_0 != null)
							{
								GClass0.smethod_0().class46_0.method_2();
							}
						}
						else
						{
							if (!GClass0.smethod_0().GotoTown)
							{
								GClass0.smethod_0().method_5("Starting town routine");
								GClass0.smethod_0().GotoTown = true;
							}
							float num = (Framework.Hero.Position - this.vector3_0).Length();
							if ((Framework.CurrentAct == D3_IngameAct.Act1 && Framework.Navigator.World != this.string_0) || num > 160f)
							{
								this.class131_0.method_0();
								this.class130_0.method_1();
								this.class129_0.method_1();
								Framework.TownPortal();
								this.int_0 = Environment.TickCount + 5000;
							}
							else
							{
								if (this.class131_0.method_1())
								{
									this.class131_0.method_2();
								}
								else
								{
									if (this.class130_0.method_0())
									{
										this.class130_0.method_2();
									}
									else
									{
										if (this.class129_0.method_0())
										{
											this.class129_0.method_2();
										}
										else
										{
											if (this.bool_1)
											{
												IEnumerable<D3Actor> arg_23A_0 = Framework.Actors;
												if (Class51.func_0 == null)
												{
													Class51.func_0 = new Func<D3Actor, bool>(Class51.smethod_1);
												}
												D3Actor d3Actor = arg_23A_0.FirstOrDefault(Class51.func_0);
												if (num > 10f && d3Actor == null)
												{
													Movement.MoveTo(this.vector3_0);
													return;
												}
												if (d3Actor != null)
												{
													if (Framework.Hero.DistanceTo(d3Actor.Position) > 10f)
													{
														Movement.MoveTo(d3Actor.Position);
														return;
													}
													if (Movement.IsMoving)
													{
														return;
													}
													GClass0.smethod_0().method_5("Taking portal back to continue");
													Framework.Hero.InteractWithObject(d3Actor);
												}
											}
											this.bool_0 = true;
											this.int_0 = Environment.TickCount + 500;
										}
									}
								}
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				GClass0.smethod_0().method_5("Town error: " + ex.Message);
			}
		}
		[CompilerGenerated]
		private static bool smethod_1(D3Actor d3Actor_0)
		{
			return d3Actor_0.UInt32_0 == 191492u;
		}
	}
}
