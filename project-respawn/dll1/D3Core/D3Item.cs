using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
namespace D3Core
{
	public sealed class D3Item
	{
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		private delegate int Delegate9(uint d3Item, ref D3Item.MoveItemInfo equipItemInfo, int zero);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		private delegate int Delegate4(uint objectHeroPtr, uint d3ItemB4, ref int numberOfTargets, ref D3Item.AvailableEquipSlots availableTargets);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		private delegate int Delegate8(uint d3item, ref D3Item.MoveItemInfo moveItemInfo, int zero, int zero2);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		private delegate int Delegate7(uint d3Item, int minusOne, int one);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		private delegate bool Delegate6(uint objectHero, uint d3Item);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		private delegate int Delegate5(int d3Item);
		public struct MoveItemInfo
		{
			public uint HeroObjectGuid;
			public ItemLocationIndex TargetSlot;
			public uint uint_0;
			public uint uint_1;
		}
		public struct AvailableEquipSlots
		{
			public ItemLocationIndex FirstSlot;
			public ItemLocationIndex SecondSlot;
			public ItemLocationIndex ThirdSlot;
		}
		private static D3Item.Delegate9 delegate9_0;
		private static D3Item.Delegate4 delegate4_0;
		private static D3Item.Delegate8 delegate8_0;
		private static D3Item.Delegate7 delegate7_0;
		private static D3Item.Delegate6 delegate6_0;
		private static D3Item.Delegate5 delegate5_0;
		public uint Ptr;
		public string Modelname
		{
			get
			{
				return Marshal.PtrToStringAnsi(new IntPtr((long)((ulong)(this.Ptr + 4u))));
			}
		}
		public uint GUID
		{
			get
			{
				return Helper.smethod_1(this.Ptr);
			}
		}
		public ItemLocationIndex ItemLocation
		{
			get
			{
				return (ItemLocationIndex)Marshal.ReadInt32(this.Ptr, 276);
			}
		}
		public uint Sno
		{
			get
			{
				return Helper.smethod_1(this.Ptr + 144u);
			}
		}
		public SnoType SnoType
		{
			get
			{
				SnoType result;
				try
				{
					uint num = Helper.smethod_1(this.Ptr + 144u);
					if (Enum.IsDefined(typeof(SnoType), num))
					{
						result = (SnoType)num;
					}
					else
					{
						Framework.smethod_0(string.Format("Missing SNOtype for object @ {0} with sno: {1}", this.Ptr.ToString("x"), num.ToString()));
						result = (SnoType)4294967295u;
					}
				}
				catch (Exception ex)
				{
					Framework.smethod_0("Error in D3Item.SnoType: " + ex.Message);
					result = (SnoType)4294967295u;
				}
				return result;
			}
		}
		public bool IsUnidentified
		{
			get
			{
				return Helper.smethod_1(this.Ptr + 176u) == 2u && Helper.smethod_1(this.Ptr + 356u) > 0u;
			}
		}
		public bool IsTwoHander
		{
			get
			{
				List<ItemLocationIndex> possibleSlots = this.GetPossibleSlots();
				return possibleSlots.Contains(ItemLocationIndex.OffHand) && possibleSlots.Contains(ItemLocationIndex.Mainhand);
			}
		}
		public bool IsBigItem
		{
			get
			{
				List<ItemLocationIndex> possibleSlots = this.GetPossibleSlots();
				return possibleSlots.Contains(ItemLocationIndex.Head) || possibleSlots.Contains(ItemLocationIndex.Shoulders) || possibleSlots.Contains(ItemLocationIndex.Chest) || possibleSlots.Contains(ItemLocationIndex.Hands) || possibleSlots.Contains(ItemLocationIndex.Wrists) || possibleSlots.Contains(ItemLocationIndex.Legs) || possibleSlots.Contains(ItemLocationIndex.Boots) || possibleSlots.Contains(ItemLocationIndex.Mainhand) || possibleSlots.Contains(ItemLocationIndex.OffHand);
			}
		}
		public float HitpointsGranted
		{
			get
			{
				return this.GetFloat((D3Attribute)4294963307u);
			}
		}
		public uint UInt32_0
		{
			get
			{
				return Helper.smethod_1(this.Ptr + 280u);
			}
		}
		public uint UInt32_1
		{
			get
			{
				return Helper.smethod_1(this.Ptr + 284u);
			}
		}
		public bool IsPotion
		{
			get
			{
				return this.HitpointsGranted > 0f;
			}
		}
		public bool CanSalvage
		{
			get
			{
				return this.GetInt((D3Attribute)4294963494u) > 2 && this.SnoType != SnoType.FallenTooth && this.SnoType != SnoType.MinorHealthPotion && this.SnoType != SnoType.LesserHealthPotion && this.SnoType != SnoType.SubtleEssence && this.SnoType != SnoType.PetrifiedBark;
			}
		}
		static D3Item()
		{
			if (D3Item.delegate9_0 == null)
			{
				D3Item.delegate9_0 = Helper.RegisterDelegate<D3Item.Delegate9>(12208320u);
			}
			if (D3Item.delegate4_0 == null)
			{
				D3Item.delegate4_0 = Helper.RegisterDelegate<D3Item.Delegate4>(8707056u);
			}
			if (D3Item.delegate8_0 == null)
			{
				D3Item.delegate8_0 = Helper.RegisterDelegate<D3Item.Delegate8>(8704336u);
			}
			if (D3Item.delegate6_0 == null)
			{
				D3Item.delegate6_0 = Helper.RegisterDelegate<D3Item.Delegate6>(8677808u);
			}
			if (D3Item.delegate7_0 == null)
			{
				D3Item.delegate7_0 = Helper.RegisterDelegate<D3Item.Delegate7>(12210000u);
			}
			if (D3Item.delegate5_0 == null)
			{
				D3Item.delegate5_0 = Helper.RegisterDelegate<D3Item.Delegate5>(12251072u);
			}
		}
		public D3Item(IntPtr ptr)
		{
			this.Ptr = (uint)((int)ptr);
		}
		public void Buy()
		{
			try
			{
				D3Item.delegate5_0((int)this.Ptr);
			}
			catch (Exception ex)
			{
				Framework.smethod_0("Error buying item:" + ex.Message);
			}
		}
		public bool CanUseItem()
		{
			bool result;
			try
			{
				uint objectHero = Framework.GetACDByGuid(Framework.Hero.ObjectGuid);
				result = D3Item.delegate6_0(objectHero, this.Ptr);
			}
			catch (Exception ex)
			{
				Framework.smethod_0("Error in D3Item.CanUseItem() :" + ex.Message);
				result = false;
			}
			return result;
		}
		public void UseItem()
		{
			try
			{
				D3Item.delegate7_0(this.Ptr, -1, 1);
			}
			catch (Exception ex)
			{
				Framework.smethod_0("Error in D3Item.UseItem() :" + ex.Message);
			}
		}
		public float GetFloat(D3Attribute attribute)
		{
			float result;
			try
			{
				uint objActor = Framework.GetACDByGuid(this.GUID);
				result = Framework.GetFloat(objActor, (uint)attribute);
			}
			catch (Exception ex)
			{
				Framework.smethod_0("Error in D3Item.GetFloat: " + ex.Message);
				result = 0f;
			}
			return result;
		}
		public int GetInt(D3Attribute attribute)
		{
			int result;
			try
			{
				uint objActor = Framework.GetACDByGuid(this.GUID);
				result = Framework.GetInt(objActor, (uint)attribute);
			}
			catch (Exception ex)
			{
				Framework.smethod_0("Error in D3Item.GetFloat: " + ex.Message);
				result = 0;
			}
			return result;
		}
		public float GetFloat(uint index)
		{
			uint objActor = Framework.GetACDByGuid(this.GUID);
			return Framework.GetFloat(objActor, index);
		}
		public int GetInt(uint index)
		{
			uint objActor = Framework.GetACDByGuid(this.GUID);
			return Framework.GetInt(objActor, index);
		}
		public List<ItemLocationIndex> GetPossibleSlots()
		{
			List<ItemLocationIndex> list = new List<ItemLocationIndex>();
			uint objectHeroPtr = Framework.GetACDByGuid(Framework.Hero.ObjectGuid);
			int num = 0;
			D3Item.AvailableEquipSlots availableEquipSlots = default(D3Item.AvailableEquipSlots);
			D3Item.delegate4_0(objectHeroPtr, Helper.smethod_1(this.Ptr + 180u), ref num, ref availableEquipSlots);
			if (num > 0)
			{
				list.Add(availableEquipSlots.FirstSlot);
			}
			if (num > 1)
			{
				list.Add(availableEquipSlots.SecondSlot);
			}
			if (num > 2)
			{
				list.Add(availableEquipSlots.ThirdSlot);
			}
			return list;
		}
		public bool CanMoveItem(ItemLocationIndex index, uint x = 0u, uint y = 0u)
		{
			bool result;
			try
			{
				D3Item.MoveItemInfo moveItemInfo = default(D3Item.MoveItemInfo);
				moveItemInfo.TargetSlot = index;
				moveItemInfo.HeroObjectGuid = Framework.Hero.ObjectGuid;
				moveItemInfo.uint_0 = x;
				moveItemInfo.uint_1 = y;
				int num = D3Item.delegate8_0(this.Ptr, ref moveItemInfo, 0, 0);
				result = (num == -1);
			}
			catch (Exception)
			{
				result = false;
			}
			return result;
		}
		public void MoveItem(ItemLocationIndex location, uint x = 0u, uint y = 0u)
		{
			try
			{
				D3Item.MoveItemInfo moveItemInfo = default(D3Item.MoveItemInfo);
				moveItemInfo.HeroObjectGuid = Framework.Hero.ObjectGuid;
				moveItemInfo.TargetSlot = location;
				moveItemInfo.uint_0 = x;
				moveItemInfo.uint_1 = y;
				D3Item.delegate9_0(this.Ptr, ref moveItemInfo, 0);
			}
			catch (Exception)
			{
			}
		}
		public override int GetHashCode()
		{
			return (int)this.GUID;
		}
		public override bool Equals(object obj)
		{
			D3Item d3Item;
			bool result;
			if ((d3Item = (obj as D3Item)) != null)
			{
				result = (d3Item.GUID == this.GUID);
			}
			else
			{
				result = base.Equals(obj);
			}
			return result;
		}
		public int GetReqLevelForPotion()
		{
			uint sno = this.Sno;
			int result;
			switch (sno)
			{
			case 4436u:
				result = 21;
				return result;
			case 4437u:
			case 4438u:
			case 4441u:
				break;
			case 4439u:
				result = 6;
				return result;
			case 4440u:
				result = 1;
				return result;
			case 4442u:
				result = 26;
				return result;
			default:
				switch (sno)
				{
				case 226395u:
					result = 37;
					return result;
				case 226396u:
					result = 47;
					return result;
				case 226397u:
					result = 58;
					return result;
				case 226398u:
					result = 53;
					return result;
				}
				break;
			}
			result = 999;
			return result;
		}
	}
}
