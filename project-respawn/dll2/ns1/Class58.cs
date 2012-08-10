using D3Core;
using D3Core.Classes;
using HellBuddy.Scripting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
namespace ns1
{
	internal class Class58 : Class57
	{
		private int int_0 = 176002;
		private string string_0;
		private string string_1;
		private bool bool_0 = false;
		private bool bool_1 = false;
		private bool bool_2 = false;
		private Vector3? vector3_0 = null;
		private int int_1 = 0;
		private int int_2 = 0;
		[CompilerGenerated]
		private static Func<D3Actor, bool> func_0;
		[CompilerGenerated]
		private static Func<D3Actor, float> func_1;
		public Class58()
		{
			this.string_0 = "CRYPT_CORRECT";
			this.string_1 = "trOUT_Town";
		}
		public override string vmethod_0()
		{
			return "Quest3: When inside the correct crypt start quest: \"CRYPT_CORRECT\"";
		}
		public override bool vmethod_1()
		{
			if (Framework.World.Contains("FalsePassage") && !this.vector3_0.HasValue)
			{
				this.vector3_0 = new Vector3?(Framework.Hero.Position);
			}
			return (!this.bool_0 || !this.bool_1) && !this.bool_2;
		}
		public override void vmethod_2()
		{
			Func<D3Actor, bool> func = null;
			if (Framework.World.Contains(this.string_1))
			{
				if (this.bool_0)
				{
					GClass0.smethod_0().method_5("Left a wrong crypt");
					this.bool_1 = true;
				}
				this.int_2++;
				if (this.int_2 >= 30)
				{
					IEnumerable<D3Actor> arg_7A_0 = Framework.Actors;
					if (Class58.func_0 == null)
					{
						Class58.func_0 = new Func<D3Actor, bool>(Class58.smethod_0);
					}
					IEnumerable<D3Actor> arg_9C_0 = arg_7A_0.Where(Class58.func_0);
					if (Class58.func_1 == null)
					{
						Class58.func_1 = new Func<D3Actor, float>(Class58.smethod_1);
					}
					IOrderedEnumerable<D3Actor> source = arg_9C_0.OrderBy(Class58.func_1);
					D3Actor d3Actor = source.FirstOrDefault<D3Actor>();
					if (d3Actor == null || d3Actor.DistanceToHero() > 30f)
					{
						this.bool_1 = true;
						this.bool_0 = true;
					}
					else
					{
						Framework.Hero.InteractWithObject(d3Actor);
					}
				}
			}
			else
			{
				if (Framework.World.Contains("FalsePassage"))
				{
					this.bool_0 = true;
					if (this.int_1 > 0)
					{
						this.int_1--;
					}
					else
					{
						IEnumerable<D3Actor> arg_13A_0 = Framework.Actors;
						if (func == null)
						{
							func = new Func<D3Actor, bool>(this.method_0);
						}
						D3Actor d3Actor2 = arg_13A_0.FirstOrDefault(func);
						if (d3Actor2 != null)
						{
							Framework.Hero.InteractWithObject(d3Actor2);
							this.int_1 += 30;
						}
						else
						{
							if (this.vector3_0.HasValue)
							{
								Movement.MoveTo(this.vector3_0.Value);
							}
							else
							{
								GClass0.smethod_0().method_4("Inside a wrong crypt, but there is no way back out ?");
							}
						}
					}
				}
				else
				{
					GClass0.smethod_0().method_5("Right tomb found, next script: \"" + this.string_0 + "\"");
					Script script = Script.LoadFromFile(this.string_0);
					if (script != null)
					{
						GClass0.smethod_0().method_11(script);
						this.bool_2 = true;
					}
				}
			}
		}
		[CompilerGenerated]
		private static bool smethod_0(D3Actor d3Actor_0)
		{
			return d3Actor_0.Modelname.Contains("Portal");
		}
		[CompilerGenerated]
		private static float smethod_1(D3Actor d3Actor_0)
		{
			return d3Actor_0.DistanceToHero();
		}
		[CompilerGenerated]
		private bool method_0(D3Actor d3Actor_0)
		{
			return (ulong)d3Actor_0.UInt32_0 == (ulong)((long)this.int_0);
		}
	}
}
