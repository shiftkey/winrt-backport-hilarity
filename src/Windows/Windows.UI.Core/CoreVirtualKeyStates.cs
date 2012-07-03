using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Core
{
	[Flags, Version(100794368u), WebHostHidden]
	public enum CoreVirtualKeyStates : uint
	{
		None = 0u,
		Down = 1u,
		Locked = 2u
	}
}
