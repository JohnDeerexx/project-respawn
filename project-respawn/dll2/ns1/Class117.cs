using D3Core;
using System;
using System.Collections.Generic;
namespace ns1
{
	internal static class Class117
	{
		internal static List<Class115> list_0;
		static Class117()
		{
			Class117.list_0 = new List<Class115>();
			Class117.list_0.Add(new Class115(D3Power.Barbarian_GroundStomp, 12f, 3));
			Class117.list_0.Add(new Class115(D3Power.Barbarian_Earthquake, 18f, 3));
			Class117.list_0.Add(new Class115(D3Power.Barbarian_Whirlwind, 15f, 3));
			Class117.list_0.Add(new Class115(D3Power.DemonHunter_FanOfKnives, 10f, 3));
			Class117.list_0.Add(new Class115(D3Power.Monk_BlindingFlash, 20f, 3));
			Class117.list_0.Add(new Class115(D3Power.Monk_CycloneStrike, 10f, 3));
			Class117.list_0.Add(new Class115(D3Power.Monk_SevenSidedStrike, 8f, 3));
			Class117.list_0.Add(new Class115(D3Power.Monk_InnerSanctuary, 10f, 3));
			Class117.list_0.Add(new Class115(D3Power.Monk_WaveOfLight, 20f, 3));
			Class117.list_0.Add(new Class115(D3Power.WitchDoctor_Horrify, 12f, 3));
			Class117.list_0.Add(new Class115(D3Power.WitchDoctor_Sacrifice, 15f, 3));
			Class117.list_0.Add(new Class115(D3Power.WitchDoctor_AcidCloud, 15f, 3));
			Class117.list_0.Add(new Class115(D3Power.WitchDoctor_Hex, 15f, 3));
			Class117.list_0.Add(new Class115(D3Power.WitchDoctor_MassConfusion, 20f, 3));
			Class117.list_0.Add(new Class115(D3Power.WitchDoctor_BigBadVoodoo, 20f, 3));
			Class117.list_0.Add(new Class115(D3Power.WitchDoctor_WallOfZombies, 15f, 3));
			Class117.list_0.Add(new Class115(D3Power.WitchDoctor_FetishArmy, 15f, 3));
			Class117.list_0.Add(new Class115(D3Power.WitchDoctor_BigBadVoodoo, 20f, 3));
			Class117.list_0.Add(new Class115(D3Power.WitchDoctor_Firebats, 15f, 2));
			Class117.list_0.Add(new Class115(D3Power.Wizard_FrostNova, 15f, 3));
			Class117.list_0.Add(new Class115(D3Power.Wizard_WaveOfForce, 20f, 3));
			Class117.list_0.Add(new Class115(D3Power.Wizard_ExplosiveBlast, 12f, 3));
			Class117.list_0.Add(new Class115(D3Power.Wizard_Meteor, 15f, 3));
			Class117.list_0.Add(new Class115(D3Power.Wizard_Blizzard, 15f, 3));
			Class117.list_0.Add(new Class115(D3Power.Wizard_Archon, 20f, 3));
		}
		internal static bool smethod_0(D3Power d3Power_0)
		{
			bool result;
			for (int i = 0; i < Class117.list_0.Count; i++)
			{
				if (Class117.list_0[i].Power == d3Power_0)
				{
					result = true;
					return result;
				}
			}
			result = false;
			return result;
		}
	}
}
