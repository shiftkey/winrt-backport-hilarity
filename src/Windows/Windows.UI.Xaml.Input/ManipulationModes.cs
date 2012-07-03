using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Input
{
	[Flags, Version(100794368u), WebHostHidden]
	public enum ManipulationModes : uint
	{
		None = 0u,
		TranslateX = 1u,
		TranslateY = 2u,
		TranslateRailsX = 4u,
		TranslateRailsY = 8u,
		Rotate = 16u,
		Scale = 32u,
		TranslateInertia = 64u,
		RotateInertia = 128u,
		ScaleInertia = 256u,
		All = 65535u,
		System = 65536u
	}
}
