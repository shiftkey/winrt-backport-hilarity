using System;
using Windows.Foundation.Metadata;
namespace Windows.System
{
	[Flags, Version(100794368u)]
	public enum VirtualKeyModifiers : uint
	{
		None = 0u,
		Control = 1u,
		Menu = 2u,
		Shift = 4u,
		Windows = 8u
	}
}
