using System;
using System.Collections.Generic;
using System.Linq;
namespace D3Core.Classes
{
	public sealed class HeroActor : D3Actor
	{
		public D3Class Class
		{
			get
			{
				string modelname = base.Modelname;
				D3Class result;
				if (modelname.Contains("Wizard"))
				{
					result = D3Class.Wizard;
				}
				else
				{
					if (modelname.Contains("WitchDoctor"))
					{
						result = D3Class.WitchDoctor;
					}
					else
					{
						if (modelname.Contains("Barbarian"))
						{
							result = D3Class.Barbarian;
						}
						else
						{
							if (modelname.Contains("Demonhunter"))
							{
								result = D3Class.DemonHunter;
							}
							else
							{
								if (modelname.Contains("Monk"))
								{
									result = D3Class.Monk;
								}
								else
								{
									result = D3Class.Invalid;
								}
							}
						}
					}
				}
				return result;
			}
		}
		public List<D3Item> Inventory
		{
			get
			{
				return base.GetItemsByLocation(ItemLocationIndex.Inventory);
			}
		}
		public List<D3Item> Equipped
		{
			get
			{
				List<D3Item> list = new List<D3Item>();
				list.AddRange(base.GetItemsByLocation(ItemLocationIndex.Head));
				list.AddRange(base.GetItemsByLocation(ItemLocationIndex.Shoulders));
				list.AddRange(base.GetItemsByLocation(ItemLocationIndex.Neck));
				list.AddRange(base.GetItemsByLocation(ItemLocationIndex.Chest));
				list.AddRange(base.GetItemsByLocation(ItemLocationIndex.Hands));
				list.AddRange(base.GetItemsByLocation(ItemLocationIndex.Wrists));
				list.AddRange(base.GetItemsByLocation(ItemLocationIndex.LeftRing));
				list.AddRange(base.GetItemsByLocation(ItemLocationIndex.RightRing));
				list.AddRange(base.GetItemsByLocation(ItemLocationIndex.Belt));
				list.AddRange(base.GetItemsByLocation(ItemLocationIndex.Legs));
				list.AddRange(base.GetItemsByLocation(ItemLocationIndex.Boots));
				list.AddRange(base.GetItemsByLocation(ItemLocationIndex.Mainhand));
				list.AddRange(base.GetItemsByLocation(ItemLocationIndex.OffHand));
				return list;
			}
		}
		public List<D3Item> StashItems
		{
			get
			{
				return base.GetItemsByLocation(ItemLocationIndex.Stash);
			}
		}
		public float CurrentHP
		{
			get
			{
				return base.GetFloat((D3Attribute)4294963302u);
			}
		}
		public float MaxHP
		{
			get
			{
				return base.GetFloat((D3Attribute)4294963311u);
			}
		}
		public HeroActor(IntPtr intPtr) : base(intPtr)
		{
		}
		public Dictionary<int, D3Spell> GetActiveSpells()
		{
			Dictionary<int, D3Spell> result;
			try
			{
				Dictionary<int, D3Spell> dictionary = new Dictionary<int, D3Spell>();
				for (int i = 0; i < 6; i++)
				{
					D3Spell spellIDByIndex = Framework.GetSpellIDByIndex(i);
					if (spellIDByIndex != null)
					{
						dictionary[i] = spellIDByIndex;
					}
				}
				result = dictionary;
			}
			catch (Exception ex)
			{
				Framework.smethod_0("Error in Framework.Hero.GetActivespells(): " + ex.Message);
				result = null;
			}
			return result;
		}
		public D3Item GetFirstItemBySlot(ItemLocationIndex index)
		{
			return base.GetItemsByLocation(index).FirstOrDefault<D3Item>();
		}
		public float GetResource(D3ResourceMask mask)
		{
			uint statIndex = (uint)((D3ResourceMask)119u | mask);
			uint objActor = Framework.GetACDByGuid(base.ObjectGuid);
			return Framework.GetFloat(objActor, statIndex);
		}
		public bool CollectItem(D3Actor actor)
		{
			bool result;
			if (actor.GetInt((D3Attribute)4294963257u) > 0)
			{
				this.method_1(actor);
				result = (Vector3.DistanceSquared(actor.Position, Framework.Hero.Position) <= 25f);
			}
			else
			{
				result = Framework.UsePower_Target(30021u, actor);
			}
			return result;
		}
		public bool InteractWithObject(D3Actor actor)
		{
			return Framework.UsePower_Target(30021u, actor);
		}
		public bool InteractWithNPC(D3Actor actor)
		{
			return Framework.UsePower_Target(30022u, actor);
		}
		public bool Interact(D3Actor actor)
		{
			bool result;
			if (actor.GetInt((D3Attribute)4294963561u) == 1)
			{
				result = this.InteractWithNPC(actor);
			}
			else
			{
				result = this.InteractWithObject(actor);
			}
			return result;
		}
		private void method_1(D3Actor d3Actor_0)
		{
			Vector3 vector = d3Actor_0.Position - Framework.Hero.Position;
			vector.Normalize();
			vector *= 6f;
			Vector3 targetPos = d3Actor_0.Position + vector;
			Movement.MoveTo(targetPos);
		}
		public void Attack(D3Actor target, D3Power spell)
		{
			if (target == null)
			{
				Framework.UsePower_Meta(4294967295u, (uint)spell);
			}
			else
			{
				Framework.UsePower_Meta(target.Guid, (uint)spell);
			}
		}
	}
}
