using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace D3Core.Classes
{
	public sealed class Scene
	{
		private IntPtr intptr_0;
		[CompilerGenerated]
		private List<Scene> list_0;
		[CompilerGenerated]
		private uint uint_0;
		[CompilerGenerated]
		private string string_0;
		[CompilerGenerated]
		private int int_0;
		[CompilerGenerated]
		private float float_0;
		[CompilerGenerated]
		private float float_1;
		[CompilerGenerated]
		private float float_2;
		[CompilerGenerated]
		private float float_3;
		[CompilerGenerated]
		private float float_4;
		public List<Scene> AdjecentScenes
		{
			get;
			set;
		}
		public uint UInt32_0
		{
			get;
			private set;
		}
		public string SNOName
		{
			get;
			private set;
		}
		public int SceneId
		{
			get;
			private set;
		}
		public float XMin
		{
			get;
			private set;
		}
		public float YMin
		{
			get;
			private set;
		}
		public float XMax
		{
			get;
			private set;
		}
		public float YMax
		{
			get;
			private set;
		}
		public float ZMin
		{
			get;
			private set;
		}
		public NavMesh NavMesh
		{
			get
			{
				IntPtr ptr = Marshal.ReadIntPtr(this.intptr_0, 380);
				return new NavMesh(ptr);
			}
		}
		public Vector3 Center
		{
			get
			{
				return new Vector3((this.XMin + this.XMax) * 0.5f, (this.YMin + this.YMax) * 0.5f, 0f);
			}
		}
		public Scene(IntPtr ptr)
		{
			this.intptr_0 = ptr;
			this.AdjecentScenes = new List<Scene>(4);
			this.XMin = Helper.ReadFloat(this.intptr_0 + 348);
			this.XMax = Helper.ReadFloat(this.intptr_0 + 356);
			this.YMin = Helper.ReadFloat(this.intptr_0 + 352);
			this.YMax = Helper.ReadFloat(this.intptr_0 + 360);
			this.ZMin = Helper.ReadFloat(this.intptr_0 + 372);
			this.SceneId = Marshal.ReadInt32(this.intptr_0, 0);
			this.UInt32_0 = Helper.smethod_1((uint)((int)this.intptr_0 + 216));
			ContainerStruct containerStruct = default(ContainerStruct);
			Framework.GetSnoName(ref containerStruct, 33, this.UInt32_0, 0);
			uint fuckingAddress = containerStruct.FuckingAddress;
			string sNOName;
			if (fuckingAddress == 0u)
			{
				sNOName = "";
			}
			else
			{
				sNOName = Helper.ReadString(fuckingAddress, null);
			}
			this.SNOName = sNOName;
		}
	}
}
