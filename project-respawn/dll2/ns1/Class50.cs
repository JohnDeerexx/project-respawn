using D3Core;
using D3Core.Classes;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
namespace ns1
{
	internal class Class50 : Class44
	{
		private const int int_0 = 500;
		private int int_1 = 0;
		private List<D3Spell> list_0;
		private List<D3Spell> list_1;
		[CompilerGenerated]
		private static bool bool_0;
		internal static bool StateActive
		{
			get;
			set;
		}
		internal Class50()
		{
		}
		internal override bool vmethod_0()
		{
			bool result;
			if (!Class50.StateActive)
			{
				result = false;
			}
			else
			{
				try
				{
					if (Environment.TickCount < this.int_1)
					{
						result = false;
					}
					else
					{
						this.int_1 = Environment.TickCount + 500;
						Dictionary<int, D3Spell> activeSpells = Framework.Hero.GetActiveSpells();
						this.list_0 = new List<D3Spell>();
						foreach (KeyValuePair<int, D3Spell> current in activeSpells)
						{
							if (current.Value != null)
							{
								this.list_0.Add(current.Value);
							}
						}
						if (this.list_0 == null)
						{
							result = false;
						}
						else
						{
							this.list_1 = GClass3.smethod_0();
							if (this.list_1 == null)
							{
								result = false;
							}
							else
							{
								if (this.list_1.Count != this.list_0.Count)
								{
									result = true;
								}
								else
								{
									for (int i = 0; i < this.list_0.Count; i++)
									{
										if (this.list_0[i] != this.list_1[i])
										{
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
				catch (Exception ex)
				{
					GClass0.smethod_0().method_4("Error selecting spells :(\n" + ex.Message);
					result = false;
				}
			}
			return result;
		}
		internal override int vmethod_2()
		{
			return 9;
		}
		internal override string vmethod_3()
		{
			return "Spellchange has no target...";
		}
		internal override void vmethod_1()
		{
			try
			{
				int i = 0;
				while (i < this.list_1.Count)
				{
					GClass0.smethod_0().method_5("Changing a spell");
					if (i < this.list_0.Count)
					{
						if (!(this.list_0[i] != this.list_1[i]))
						{
							i++;
							continue;
						}
						Framework.RequestSpellChange(this.list_1[i], i);
					}
					else
					{
						Framework.RequestSpellChange(this.list_1[i], i);
					}
					break;
				}
			}
			catch (Exception ex)
			{
				GClass0.smethod_0().method_4("Error when changing spells: " + ex.Message);
				this.int_1 = Environment.TickCount + 500;
			}
		}
	}
}
