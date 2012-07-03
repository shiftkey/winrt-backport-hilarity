using System;
using Windows.Foundation.Metadata;
namespace Windows.Graphics.Display
{
	[Flags, Version(100794368u)]
	public enum DisplayOrientations : uint
	{
		None = 0u,
		Landscape = 1u,
		Portrait = 2u,
		LandscapeFlipped = 4u,
		PortraitFlipped = 8u
	}
}
