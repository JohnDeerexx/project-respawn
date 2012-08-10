using System;
namespace D3Core
{
	public struct ContainerStruct
	{
		public uint StringContainer_unused;
		public uint FuckingAddress;
		public uint unused3;
		public uint unused4;
		public ContainerStruct(uint stringContainer_unused, uint fuckingAddress, uint unused3, uint unused4)
		{
			this.StringContainer_unused = stringContainer_unused;
			this.FuckingAddress = fuckingAddress;
			this.unused3 = unused3;
			this.unused4 = unused4;
		}
	}
}
