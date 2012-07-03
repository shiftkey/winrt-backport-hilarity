using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.StartScreen
{
	[Flags, Version(100794368u)]
	public enum TileOptions : uint
	{
		None = 0u,
		ShowNameOnLogo = 1u,
		ShowNameOnWideLogo = 2u,
		CopyOnDeployment = 4u
	}
}
