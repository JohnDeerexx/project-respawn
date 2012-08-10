using ns0;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace D3Core.Classes
{
	public class D3Actor
	{
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate IntPtr Delegate3(IntPtr objActor, int index, int address);
		private delegate uint Delegate2(uint ACDPtr);
		private static D3Actor.Delegate3 delegate3_0;
		private static IntPtr intptr_0;
		public IntPtr _Ptr;
		private uint uint_0 = 4294967295u;
		private string string_0 = null;
		private static D3Actor.Delegate2 delegate2_0;
		private Vector3? vector3_0 = null;
		private float float_0 = -1f;
		[CompilerGenerated]
		private D3Team d3Team_0;
		public bool IsValidAsTarget
		{
			get
			{
				return this.Team == D3Team.Diablo && this.GetFloat((D3Attribute)4294963302u) >= 0.0011f && this.GetInt((D3Attribute)4294963292u) != 1;
			}
		}
		public bool IsD3Object
		{
			get
			{
				return this.ObjectGuid != 4294967295u;
			}
		}
		public uint Guid
		{
			get
			{
				if (this.uint_0 == 4294967295u)
				{
					this.uint_0 = (uint)Marshal.ReadInt32(this._Ptr);
				}
				return this.uint_0;
			}
		}
		public uint ObjectGuid
		{
			get
			{
				return (uint)Marshal.ReadInt32(this._Ptr, (int)Class3.Class2.uint_1);
			}
		}
		public uint UsePowerTargetID
		{
			get
			{
				return (uint)Marshal.ReadInt32(this._Ptr, (int)Class3.Class2.uint_8);
			}
		}
		public string Modelname
		{
			get
			{
				if (this.string_0 == null)
				{
					this.string_0 = Marshal.PtrToStringAnsi(this._Ptr + (int)Class3.Class2.uint_2);
				}
				return this.string_0;
			}
		}
		public int CurrentSceneId
		{
			get
			{
				uint num = (uint)this._Ptr.ToInt32();
				int result;
				if (num == 0u)
				{
					result = 0;
				}
				else
				{
					num += Class3.Class2.uint_6;
					result = Marshal.ReadInt32(new IntPtr((long)((ulong)num)));
				}
				return result;
			}
		}
		public uint UInt32_0
		{
			get
			{
				uint result;
				try
				{
					result = (uint)Marshal.ReadInt32(this._Ptr, (int)Class3.Class2.uint_7);
					return result;
				}
				catch
				{
				}
				result = 4294967295u;
				return result;
			}
		}
		public D3Team Team
		{
			get;
			private set;
		}
		public Vector3 Position
		{
			get
			{
				if (!this.vector3_0.HasValue)
				{
					float x = Helper.ReadFloat(this._Ptr + (int)Class3.Class2.uint_3);
					float y = Helper.ReadFloat(this._Ptr + (int)Class3.Class2.uint_4);
					float z = Helper.ReadFloat(this._Ptr + (int)Class3.Class2.uint_5);
					this.vector3_0 = new Vector3?(new Vector3(x, y, z));
				}
				return this.vector3_0.Value;
			}
		}
		public uint GlobalGuid
		{
			get
			{
				return Framework.GetServerGUID(this);
			}
		}
		static D3Actor()
		{
			D3Actor.intptr_0 = IntPtr.Zero;
			byte[] array = new byte[]
			{
				85,
				139,
				236,
				139,
				93,
				16,
				139,
				69,
				12,
				80,
				139,
				69,
				8,
				255,
				211,
				139,
				229,
				93,
				195
			};
			D3Actor.intptr_0 = Marshal.AllocCoTaskMem(array.Length);
			Marshal.Copy(array, 0, D3Actor.intptr_0, array.Length);
			D3Actor.delegate3_0 = Helper.RegisterDelegate<D3Actor.Delegate3>(D3Actor.intptr_0);
		}
		public D3Actor(IntPtr ptr)
		{
			this._Ptr = ptr;
			this.Team = this.method_0();
		}
		private D3Team method_0()
		{
			D3Team result;
			try
			{
				if (this.ObjectGuid == 4294967295u)
				{
					result = (D3Team)4294967295u;
				}
				else
				{
					int @int = this.GetInt((D3Attribute)4294963290u);
					if (Enum.IsDefined(typeof(D3Team), (uint)@int))
					{
						result = (D3Team)@int;
					}
					else
					{
						Framework.smethod_0("Missing D3Team: 0x" + @int.ToString("x"));
						result = (D3Team)4294967295u;
					}
				}
			}
			catch (Exception ex)
			{
				Framework.smethod_0("Error in D3Actor: " + ex.Message);
				result = (D3Team)4294967295u;
			}
			return result;
		}
		public List<D3Item> GetItemsByLocation(ItemLocationIndex index)
		{
			IntPtr objActor = new IntPtr((long)((ulong)Framework.GetACDByGuid(this.ObjectGuid)));
			List<D3Item> list = new List<D3Item>();
			IntPtr intPtr = D3Actor.delegate3_0(objActor, (int)index, 8688512);
			if (intPtr != IntPtr.Zero)
			{
				ItemArrayContainer itemArrayContainer = new ItemArrayContainer(intPtr);
				IntPtr pointer = Marshal.ReadIntPtr(itemArrayContainer.Ptr);
				int itemCount = itemArrayContainer.ItemCount;
				for (int i = 0; i < itemCount; i++)
				{
					uint num = (uint)Marshal.ReadInt32(pointer + i * 4);
					if (num != 4294967295u)
					{
						list.Add(new D3Item(new IntPtr((long)((ulong)Framework.GetACDByGuid(num)))));
					}
				}
			}
			return list;
		}
		public float GetFloat(D3Attribute attribute)
		{
			float result;
			if (this.ObjectGuid == 0u || this.ObjectGuid == 4294967295u)
			{
				result = 0f;
			}
			else
			{
				try
				{
					uint objActor = Framework.GetACDByGuid(this.ObjectGuid);
					result = Framework.GetFloat(objActor, (uint)attribute);
				}
				catch (Exception)
				{
					result = -666f;
				}
			}
			return result;
		}
		public int GetInt(D3Attribute attribute)
		{
			int result;
			if (this.ObjectGuid == 0u || this.ObjectGuid == 4294967295u)
			{
				result = 0;
			}
			else
			{
				try
				{
					uint objActor = Framework.GetACDByGuid(this.ObjectGuid);
					result = Framework.GetInt(objActor, (uint)attribute);
				}
				catch (Exception)
				{
					result = -666;
				}
			}
			return result;
		}
		public int GetGold()
		{
			if (D3Actor.delegate2_0 == null)
			{
				D3Actor.delegate2_0 = Helper.RegisterDelegate<D3Actor.Delegate2>(8695840u);
			}
			int result;
			if (this.ObjectGuid == 4294967295u)
			{
				result = 0;
			}
			else
			{
				uint aCDPtr = Framework.GetACDByGuid(this.ObjectGuid);
				uint objActor = D3Actor.delegate2_0(aCDPtr);
				int num = Framework.GetInt(objActor, 4294963507u);
				result = num;
			}
			return result;
		}
		public float DistanceToHero()
		{
			if (this.float_0 == -1f)
			{
				this.float_0 = Vector2.Distance(Framework.Hero.Position, this.Position);
			}
			return this.float_0;
		}
		public float DistanceTo(Vector3 vect)
		{
			return Vector2.Distance(vect, this.Position);
		}
		internal static void smethod_0()
		{
			if (D3Actor.intptr_0 != IntPtr.Zero)
			{
				Marshal.FreeCoTaskMem(D3Actor.intptr_0);
				D3Actor.intptr_0 = IntPtr.Zero;
			}
		}
	}
}
