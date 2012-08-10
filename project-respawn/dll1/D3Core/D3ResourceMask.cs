using System;
namespace D3Core
{
	public enum D3ResourceMask : uint
	{
		None,
		ArcanePower = 4096u,
		Rage = 8192u,
		Spirit = 12288u,
		Mana = 16384u,
		Hatred = 20480u,
		Discipline = 24576u
	}
}
