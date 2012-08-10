using D3Core;
using D3Core.Classes;
using System;
using System.Collections.Generic;
namespace ns1
{
	internal class Class53 : Class44
	{
		internal static Dictionary<D3Power, int> dictionary_0;
		private Dictionary<D3Power, int> dictionary_1 = new Dictionary<D3Power, int>();
		private D3Spell d3Spell_0 = null;
		private int int_0;
		static Class53()
		{
			Class53.dictionary_0 = new Dictionary<D3Power, int>();
			Class53.dictionary_0.Add(D3Power.Wizard_MagicWeapon, 120);
			Class53.dictionary_0.Add(D3Power.Wizard_IceArmor, 120);
			Class53.dictionary_0.Add(D3Power.Wizard_StormArmor, 120);
		}
		internal override int vmethod_2()
		{
			return 0;
		}
		internal override string vmethod_3()
		{
			string result = "null";
			if (this.d3Spell_0 != null)
			{
				result = "Buffing: " + this.d3Spell_0.D3Power.ToString();
			}
			return result;
		}
		internal override bool vmethod_0()
		{
			bool result;
			if (this.int_0 < Environment.TickCount)
			{
				result = false;
			}
			else
			{
				this.int_0 = Environment.TickCount + 300;
				this.d3Spell_0 = null;
				foreach (KeyValuePair<int, D3Spell> current in Framework.Hero.GetActiveSpells())
				{
					if (Class53.dictionary_0.ContainsKey(current.Value.D3Power) && (!this.dictionary_1.ContainsKey(current.Value.D3Power) || (this.dictionary_1[current.Value.D3Power] < Environment.TickCount && current.Value.CanCast)))
					{
						this.d3Spell_0 = current.Value;
						break;
					}
				}
				result = (this.d3Spell_0 != null);
			}
			return result;
		}
		internal override void vmethod_1()
		{
			this.dictionary_1[this.d3Spell_0.D3Power] = Environment.TickCount + Class53.dictionary_0[this.d3Spell_0.D3Power] * 1000;
			Framework.UsePower_Position((uint)this.d3Spell_0.D3Power, Framework.Hero.Position);
		}
	}
}
