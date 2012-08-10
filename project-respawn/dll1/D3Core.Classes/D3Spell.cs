using System;
using System.Collections.Generic;
namespace D3Core.Classes
{
	public sealed class D3Spell
	{
		public static HashSet<D3Power> SpellsWithoutTarget;
		public static Dictionary<D3Power, int> CooldownTable;
		public static Dictionary<D3Power, int> CurrentCooldownEnds;
		public D3Power D3Power = D3Power.Invalid;
		public int Rune = 0;
		public bool IsOnCooldown
		{
			get
			{
				int num = 0;
				return (D3Spell.CurrentCooldownEnds.TryGetValue(this.D3Power, out num) && Environment.TickCount < num) || Framework.IsCooldown((int)this.D3Power);
			}
		}
		public bool CanCast
		{
			get
			{
				return !this.IsOnCooldown && Framework.CanUsePower((int)this.D3Power);
			}
		}
		static D3Spell()
		{
			D3Spell.CooldownTable = new Dictionary<D3Power, int>();
			D3Spell.CurrentCooldownEnds = new Dictionary<D3Power, int>();
			D3Spell.SpellsWithoutTarget = new HashSet<D3Power>();
			D3Spell.SpellsWithoutTarget.Add(D3Power.Wizard_RayOfFrost);
			D3Spell.SpellsWithoutTarget.Add(D3Power.Wizard_FrostNova);
			D3Spell.SpellsWithoutTarget.Add(D3Power.Wizard_DiamondSkin);
			D3Spell.SpellsWithoutTarget.Add(D3Power.Wizard_IceArmor);
			D3Spell.SpellsWithoutTarget.Add(D3Power.Wizard_StormArmor);
			D3Spell.SpellsWithoutTarget.Add(D3Power.Wizard_MagicWeapon);
			D3Spell.SpellsWithoutTarget.Add(D3Power.Wizard_WaveOfForce);
			D3Spell.SpellsWithoutTarget.Add(D3Power.Monk_MantraOfConviction);
			D3Spell.SpellsWithoutTarget.Add(D3Power.Monk_MantraOfEvasion);
			D3Spell.SpellsWithoutTarget.Add(D3Power.Monk_MantraOfHealing);
			D3Spell.SpellsWithoutTarget.Add(D3Power.Monk_MantraOfRetribution);
			D3Spell.SpellsWithoutTarget.Add(D3Power.Barbarian_BattleRage);
			D3Spell.SpellsWithoutTarget.Add(D3Power.Barbarian_GroundStomp);
			D3Spell.SpellsWithoutTarget.Add(D3Power.Barbarian_WarCry);
			D3Spell.CooldownTable.Add(D3Power.Barbarian_Rend, 3000);
			D3Spell.CooldownTable.Add(D3Power.Barbarian_Revenge, 4000);
			D3Spell.CooldownTable.Add(D3Power.Barbarian_ThreateningShout, 10000);
			D3Spell.CooldownTable.Add(D3Power.Barbarian_Whirlwind, 4000);
			D3Spell.CooldownTable.Add(D3Power.Barbarian_BattleRage, 26000);
			D3Spell.CooldownTable.Add(D3Power.Barbarian_IgnorePain, 5000);
			D3Spell.CooldownTable.Add(D3Power.DemonHunter_SmokeScreen, 4000);
			D3Spell.CooldownTable.Add(D3Power.DemonHunter_ShadowPower, 4000);
			D3Spell.CooldownTable.Add(D3Power.DemonHunter_Companion, 10000);
			D3Spell.CooldownTable.Add(D3Power.DemonHunter_MarkedForDeath, 5000);
			D3Spell.CooldownTable.Add(D3Power.DemonHunter_Sentry, 6000);
			D3Spell.CooldownTable.Add(D3Power.Monk_ExplodingPalm, 3000);
			D3Spell.CooldownTable.Add(D3Power.Monk_CycloneStrike, 5000);
			D3Spell.CooldownTable.Add(D3Power.Monk_MantraOfEvasion, 180000);
			D3Spell.CooldownTable.Add(D3Power.Monk_MantraOfRetribution, 180000);
			D3Spell.CooldownTable.Add(D3Power.Monk_MantraOfHealing, 180000);
			D3Spell.CooldownTable.Add(D3Power.Monk_MantraOfConviction, 180000);
			D3Spell.CooldownTable.Add(D3Power.Monk_SweepingWind, 10000);
			D3Spell.CooldownTable.Add(D3Power.Monk_MysticAlly, 25000);
			D3Spell.CooldownTable.Add(D3Power.WitchDoctor_Locust_Swarm, 8000);
			D3Spell.CooldownTable.Add(D3Power.WitchDoctor_AcidCloud, 3000);
			D3Spell.CooldownTable.Add(D3Power.WitchDoctor_FetishArmy, 19000);
			D3Spell.CooldownTable.Add(D3Power.Wizard_IceArmor, 120000);
			D3Spell.CooldownTable.Add(D3Power.Wizard_StormArmor, 120000);
			D3Spell.CooldownTable.Add(D3Power.Wizard_MagicWeapon, 300000);
			D3Spell.CooldownTable.Add(D3Power.Wizard_Hydra, 2000);
			D3Spell.CooldownTable.Add(D3Power.Wizard_Familiar, 300000);
			D3Spell.CooldownTable.Add(D3Power.Wizard_EnergyArmor, 120000);
		}
		public D3Spell(D3Power d3Power, int rune = -1)
		{
			this.D3Power = d3Power;
			this.Rune = rune;
		}
		public static void SetSpellCooldown(D3Power spell)
		{
			int num = 0;
			if (D3Spell.CooldownTable.TryGetValue(spell, out num))
			{
				D3Spell.CurrentCooldownEnds[spell] = Environment.TickCount + num;
			}
		}
		public override string ToString()
		{
			return string.Format("{0}, {1}", this.D3Power, this.Rune);
		}
		public override int GetHashCode()
		{
			return (int)(this.D3Power ^ (D3Power)this.Rune);
		}
		public override bool Equals(object obj)
		{
			D3Spell d3Spell = obj as D3Spell;
			bool result;
			if (d3Spell != null)
			{
				result = (this.D3Power == d3Spell.D3Power && this.Rune == d3Spell.Rune);
			}
			else
			{
				result = base.Equals(obj);
			}
			return result;
		}
		public static bool operator ==(D3Spell a, D3Spell b)
		{
			return object.ReferenceEquals(a, b) || (a != null && b != null && a.Equals(b));
		}
		public static bool operator !=(D3Spell a, D3Spell b)
		{
			return !(a == b);
		}
	}
}
