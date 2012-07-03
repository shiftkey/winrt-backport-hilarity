using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media.Imaging
{
	[Flags, Version(100794368u), WebHostHidden]
	public enum BitmapCreateOptions : uint
	{
		None = 0u,
		IgnoreImageCache = 8u
	}
}
