using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Input
{
	[Flags, Version(100794368u)]
	public enum GestureSettings : uint
	{
		None = 0u,
		Tap = 1u,
		DoubleTap = 2u,
		Hold = 4u,
		HoldWithMouse = 8u,
		RightTap = 16u,
		Drag = 32u,
		ManipulationTranslateX = 64u,
		ManipulationTranslateY = 128u,
		ManipulationTranslateRailsX = 256u,
		ManipulationTranslateRailsY = 512u,
		ManipulationRotate = 1024u,
		ManipulationScale = 2048u,
		ManipulationTranslateInertia = 4096u,
		ManipulationRotateInertia = 8192u,
		ManipulationScaleInertia = 16384u,
		CrossSlide = 32768u
	}
}
